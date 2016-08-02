using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CellStore.Client;
using CellStore.Api;

namespace CellStore.Test
{
    /// <summary>
    ///  Class for testing SessionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SessionsApiTests
    {
        private SessionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new SessionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SessionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<SessionsApi> (instance, "instance is a SessionsApi");
        }

        
        /// <summary>
        /// Test Login
        /// </summary>
        [Test]
        public void LoginTest()
        {
            // TODO: add unit test for the method 'Login'
            string email = null; // TODO: replace null with proper value
            string password = null; // TODO: replace null with proper value
            var response = instance.Login(email, password);
            Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Logout
        /// </summary>
        [Test]
        public void LogoutTest()
        {
            // TODO: add unit test for the method 'Logout'
            string token = null; // TODO: replace null with proper value
            var response = instance.Logout(token);
            Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Revoke
        /// </summary>
        [Test]
        public void RevokeTest()
        {
            // TODO: add unit test for the method 'Revoke'
            string email = null; // TODO: replace null with proper value
            string password = null; // TODO: replace null with proper value
            string token = null; // TODO: replace null with proper value
            var response = instance.Revoke(email, password, token);
            Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Token
        /// </summary>
        [Test]
        public void TokenTest()
        {
            // TODO: add unit test for the method 'Token'
            string email = null; // TODO: replace null with proper value
            string password = null; // TODO: replace null with proper value
            string expiration = null; // TODO: replace null with proper value
            var response = instance.Token(email, password, expiration);
            Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Tokens
        /// </summary>
        [Test]
        public void TokensTest()
        {
            // TODO: add unit test for the method 'Tokens'
            string token = null; // TODO: replace null with proper value
            var response = instance.Tokens(token);
            Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
