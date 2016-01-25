'use strict';

var fs = require('fs');
var gulp = require('gulp');
var $ = require('gulp-load-plugins')();
var request = require('request');
var parseString = require('xml2js').parseString;
var _ = require('lodash');

var isOnTravis = process.env.CIRCLECI === 'true';
var artifactsDir = process.env.CIRCLE_ARTIFACTS;
var isOnTravisAndMaster = isOnTravis && process.env.CI_PULL_REQUEST === '' && process.env.CIRCLE_BRANCH === 'master';
var version;

var isWindows = /^win/.test(process.platform);
var nugetCmd = isWindows ? 'nuget' : 'mono nuget.exe';
var compileCmd = isWindows ? 'csc' : 'mcs -sdk:4.5';

var cellstore_nuspec;
parseString(fs.readFileSync('CellStore.dll.nuspec', 'utf-8'), { async: false }, function (err, result) {
    cellstore_nuspec = result;
    version = result.package.metadata[0].version[0];
});

var downloadCmd = function(url, output){
    if(isWindows){
        return 'curl -L -o "' + output + '" ' + url;
    } else {
        return 'wget -O "' + output + '" ' + url;
    }
};

var pathFix = function(str){
    if(isWindows){
        return str.replace(new RegExp('/', 'g'), '\\');
    } else {
        return str;
    }
};

gulp.task('swagger:clean', $.shell.task([
    'rm -rf build',
    'mkdir build'
]));

gulp.task('swagger:resolve', ['swagger:clean'], function(done){
    request({ url: 'http://28msec.github.io/cellstore-pro/swagger-aggregated.json' }, function(err, resp){
        fs.writeFileSync('build/swagger-aggregated.json', resp.body);
        done();
    });
});

gulp.task('swagger:install-codegen', ['swagger:resolve'], $.shell.task(
    'cd build && ' + downloadCmd('https://github.com/28msec/swagger-codegen/releases/download/v2.1.7/swagger-codegen-cli.jar', 'swagger-codegen-cli.jar'))
);

gulp.task('swagger:generate-csharp', ['swagger:install-codegen'], $.shell.task([
    'cp codegen-options.json build',
    'cd build && java -jar swagger-codegen-cli.jar generate -i swagger-aggregated.json -l csharp -c codegen-options.json  -o .'
]));

gulp.task('swagger:csharp', ['swagger:generate-csharp'], $.shell.task([
    'cd build && ' + pathFix(compileCmd + ' -r:bin/Newtonsoft.Json.dll,bin/RestSharp.dll,System.Runtime.Serialization.dll -target:library -out:bin/CellStore.dll -recurse:src/*.cs -doc:bin/CellStore.xml -platform:anycpu')
]));

gulp.task('swagger:test', $.shell.task([
    pathFix(compileCmd + ' -r:build/bin/Newtonsoft.Json.dll,build/bin/RestSharp.dll,build/bin/CellStore.dll,System.Runtime.Serialization.dll -out:samples/GetFacts/GetFacts/Program.exe samples/GetFacts/GetFacts/Program.cs'),
    'cp build/bin/*.dll samples/GetFacts/GetFacts',
    isWindows ? 'cd samples/GetFacts/GetFacts && Program.exe' : 'mono samples/GetFacts/GetFacts/Program.exe'
]));

gulp.task('swagger:pack', $.shell.task([
    'cp CellStore.dll.nuspec build',
    isWindows ? ':' : 'cd build && wget https://nuget.org/nuget.exe',
    'cd build && ' + nugetCmd + ' pack CellStore.dll.nuspec'
]));

gulp.task('swagger:push', $.shell.task([
    'cd build && ' + nugetCmd + ' setApiKey ' + process.env.NUGET_API_KEY + ' | cat &> /dev/null',
    'cd build && ' + nugetCmd + ' push CellStore.NET.' + version + '.nupkg'
]));

gulp.task('swagger:copy', $.shell.task([
    'cd build && if [ "' + artifactsDir + '" != "" ] ; then cp -R * ' + artifactsDir + ' ; fi'
]));

gulp.task('swagger', function(done){
    $.runSequence('swagger:csharp', 'swagger:test', 'swagger:pack', 'swagger:copy', function(){
        if(isOnTravisAndMaster) {
            $.runSequence('swagger:push', done);
        } else {
            done();
        }
    });
});

gulp.task('default', ['swagger']);
