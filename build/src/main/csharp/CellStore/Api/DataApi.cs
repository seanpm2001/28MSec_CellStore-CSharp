using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using CellStore.Client;
using CellStore.Model;

namespace CellStore.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataApi
    {
        
        /// <summary>
        /// Retrieve a summary for all components of a given filing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <returns>Object</returns>
        Object ListComponents (string token, string profileName = null, string formatIndent = no, List<string> eid = null, List<string> ticker = null, List<string> tag = null, List<string> sic = null, List<string> cik = null, List<int?> edinetcode = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, string aid = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? count = false, int? top = null, int? skip = null, bool? validate = false, string language = null);
  
        /// <summary>
        /// Retrieve a summary for all components of a given filing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListComponentsAsync (string token, string profileName = null, string formatIndent = no, List<string> eid = null, List<string> ticker = null, List<string> tag = null, List<string> sic = null, List<string> cik = null, List<int?> edinetcode = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, string aid = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? count = false, int? top = null, int? skip = null, bool? validate = false, string language = null);
        
        /// <summary>
        /// Retrieve metadata about the entities that submit filings. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="entitySearch">Includes in the results the entities whose name match this full-text query</param>
        /// <param name="entitySearchOffset">Includes in the results the entities whose name match the entity-search parameter skipping the first entity-search-offset results (default: 0)</param>
        /// <param name="entitySearchLimit">Includes in the results the entities whose name match the entity-search parameter limited to a maximum of entity-search-limit results (default: 10)</param>
        /// <param name="language">Specifies in which language to perform the entity-search query (default: en-US)</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListEntities (string token, string profileName = null, string formatIndent = no, List<string> tag = null, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> sic = null, List<string> ticker = null, string entitySearch = null, int? entitySearchOffset = null, int? entitySearchLimit = null, string language = en-US, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve metadata about the entities that submit filings. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="entitySearch">Includes in the results the entities whose name match this full-text query</param>
        /// <param name="entitySearchOffset">Includes in the results the entities whose name match the entity-search parameter skipping the first entity-search-offset results (default: 0)</param>
        /// <param name="entitySearchLimit">Includes in the results the entities whose name match the entity-search parameter limited to a maximum of entity-search-limit results (default: 10)</param>
        /// <param name="language">Specifies in which language to perform the entity-search query (default: en-US)</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListEntitiesAsync (string token, string profileName = null, string formatIndent = no, List<string> tag = null, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> sic = null, List<string> ticker = null, string entitySearch = null, int? entitySearchOffset = null, int? entitySearchLimit = null, string language = en-US, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Add or update entity. The entities are identified with Entity IDs (EIDs).\n\nAn entity must be specified as a JSON object that must be valid against a JSound schema.  It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| EID   | string | optional | The entity ID (EID). |\n| EIDs  | array of strings (at least one) | required if EID is absent | The EIDs, if more than one EID exists for this entity. Must be present if and only if EID is absent. |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following field is allowed for the purpose of feeding back the output of the entities endpoint as input:\n\n- Archives (string)\n\nSeveral entities can be created at the same time by posting a sequence of non-comma-separated JSON objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="entity">The entity objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        Object InsertEntities (string token, Object entity, string profileName = null);
  
        /// <summary>
        /// Add or update entity. The entities are identified with Entity IDs (EIDs).\n\nAn entity must be specified as a JSON object that must be valid against a JSound schema.  It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| EID   | string | optional | The entity ID (EID). |\n| EIDs  | array of strings (at least one) | required if EID is absent | The EIDs, if more than one EID exists for this entity. Must be present if and only if EID is absent. |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following field is allowed for the purpose of feeding back the output of the entities endpoint as input:\n\n- Archives (string)\n\nSeveral entities can be created at the same time by posting a sequence of non-comma-separated JSON objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="entity">The entity objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> InsertEntitiesAsync (string token, Object entity, string profileName = null);
        
        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <returns>Object</returns>
        Object DeleteEntity (string token, string profileName = null, string formatIndent = no, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> ticker = null);
  
        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> DeleteEntityAsync (string token, string profileName = null, string formatIndent = no, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> ticker = null);
        
        /// <summary>
        /// Retrieve one or more facts for a combination of filings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="map">[Deprecated, use report] The concept map that should be used to resolve the concept (default: none).</param>
        /// <param name="rule">[Deprecated, use report] The rules that should be used to resolve the concept (default: none).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param>
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string.</param>
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string.</param>
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param>
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param>
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param>
        /// <param name="dimensionColumns">If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order).</param>
        /// <param name="dimensionAggregation">[Deprecated] Specifies whether this dimension is a dicer (&#39;group&#39;) or not (&#39;no&#39;). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers (&#39;group&#39;) and non-key aspects are not (&#39;no&#39;). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer.</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListFacts (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string map = null, string rule = null, string report = null, string additionalRules = null, bool? labels = false, string auditTrails = no, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, Dictionary<string, string> dimensionAggregation = null, string aggregationFunction = null, bool? validate = false, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve one or more facts for a combination of filings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="map">[Deprecated, use report] The concept map that should be used to resolve the concept (default: none).</param>
        /// <param name="rule">[Deprecated, use report] The rules that should be used to resolve the concept (default: none).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param>
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string.</param>
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string.</param>
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param>
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param>
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param>
        /// <param name="dimensionColumns">If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order).</param>
        /// <param name="dimensionAggregation">[Deprecated] Specifies whether this dimension is a dicer (&#39;group&#39;) or not (&#39;no&#39;). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers (&#39;group&#39;) and non-key aspects are not (&#39;no&#39;). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer.</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListFactsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string map = null, string rule = null, string report = null, string additionalRules = null, bool? labels = false, string auditTrails = no, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, Dictionary<string, string> dimensionAggregation = null, string aggregationFunction = null, bool? validate = false, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Add a fact to a filing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="fact">The fact objects (they must be valid, and have an archive aspect that points to an existing archive). To logically delete a fact, omit the Value field.</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        Object AddFacts (string token, Object fact, string formatIndent = no);
  
        /// <summary>
        /// Add a fact to a filing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="fact">The fact objects (they must be valid, and have an archive aspect that points to an existing archive). To logically delete a fact, omit the Value field.</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> AddFactsAsync (string token, Object fact, string formatIndent = no);
        
        /// <summary>
        /// Patch one or more facts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="patch">The patch object, which will be merged into each facts (the facts must be valid after applying it).</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="map">[Deprecated, use report] The concept map that should be used to resolve the concept (default: none).</param>
        /// <param name="rule">[Deprecated, use report] The rules that should be used to resolve the concept (default: none).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param>
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string.</param>
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string.</param>
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param>
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param>
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param>
        /// <param name="dimensionColumns">If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order).</param>
        /// <param name="dimensionAggregation">[Deprecated] Specifies whether this dimension is a dicer (&#39;group&#39;) or not (&#39;no&#39;). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers (&#39;group&#39;) and non-key aspects are not (&#39;no&#39;). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer.</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <returns>Object</returns>
        Object PatchFacts (string token, Object patch, string profileName = null, string formatIndent = no, List<string> tag = null, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> sic = null, List<string> ticker = null, string aid = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string map = null, string rule = null, string report = null, string additionalRules = null, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, Dictionary<string, string> dimensionAggregation = null, string aggregationFunction = null, bool? validate = false, bool? count = false);
  
        /// <summary>
        /// Patch one or more facts
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="patch">The patch object, which will be merged into each facts (the facts must be valid after applying it).</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="map">[Deprecated, use report] The concept map that should be used to resolve the concept (default: none).</param>
        /// <param name="rule">[Deprecated, use report] The rules that should be used to resolve the concept (default: none).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param>
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string.</param>
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string.</param>
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param>
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param>
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param>
        /// <param name="dimensionColumns">If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order).</param>
        /// <param name="dimensionAggregation">[Deprecated] Specifies whether this dimension is a dicer (&#39;group&#39;) or not (&#39;no&#39;). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers (&#39;group&#39;) and non-key aspects are not (&#39;no&#39;). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer.</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> PatchFactsAsync (string token, Object patch, string profileName = null, string formatIndent = no, List<string> tag = null, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> sic = null, List<string> ticker = null, string aid = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string map = null, string rule = null, string report = null, string additionalRules = null, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, Dictionary<string, string> dimensionAggregation = null, string aggregationFunction = null, bool? validate = false, bool? count = false);
        
        /// <summary>
        /// Retrieve the fact table for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param>
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param>
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param>
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="merge">Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListFactTable (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<int?> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, string additionalRules = null, bool? labels = false, string auditTrails = no, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, List<string> filingKind = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string aggregationFunction = null, bool? validate = false, bool? merge = true, string language = null, bool? _override = null, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve the fact table for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param>
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param>
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param>
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="merge">Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListFactTableAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<int?> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, string additionalRules = null, bool? labels = false, string auditTrails = no, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, List<string> filingKind = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string aggregationFunction = null, bool? validate = false, bool? merge = true, string language = null, bool? _override = null, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListFactTableForReport (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, bool? open = null, string report = null, bool? labels = false, string auditTrails = no, string language = null, string aggregationFunction = null, bool? validate = false, bool? _override = null, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListFactTableForReportAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, bool? open = null, string report = null, bool? labels = false, string auditTrails = no, string language = null, string aggregationFunction = null, bool? validate = false, bool? _override = null, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Retrieve metadata about the filings, also called archives. The filings are identified with Archive IDs (AIDs). Facts can be bound with filings with the xbrl28:Archive aspect, whose values are AIDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListFilings (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, string language = null, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve metadata about the filings, also called archives. The filings are identified with Archive IDs (AIDs). Facts can be bound with filings with the xbrl28:Archive aspect, whose values are AIDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListFilingsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, string language = null, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Add or update filings. The filings are identified with Archive IDs (AIDs).\n\nThere are two ways to create a filing: a full import of an XBRL instance and taxonomy out of a ZIP file, or a new empty filing with a JSON object containing its metadata.\n\nA full import is performed by provided, in the body of the request, a ZIP Deflate-compressed archive. This will import all the facts from the instance, as well as the taxonomy schema and linkbases.\n\nAlternatively, a new empty filing can be created by submitting a JSON object containing general information about the filing. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive |\n| Entity   | string | optional | The EID to which the archive belongs |\n| Entities  | array of strings (at least one) | required if Entity is absent | Used if the archive reports information on more than one entity. |\n| InstanceURL  | string | optional | The URL of the original XBRL instance |\n| Namespaces  | object with string values | optional | Maps prefixes to namespaces for the filing (common bindings are automatically added) |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the filings endpoint as input:\n\n- Components (string)\n- Sections (string)\n- NumSections (integer)\n- NumFacts (integer)\n- NumFootnotes (integer)\n- NumReportElements (integer)\n- NumHypercubes (integer)\n- NumDimensions (integer)\n- NumMembers (integer)\n- NumLineItems (integer)\n- NumAbstracts (integer)\n- NumConcepts (integer)\n\nSeveral empty filings can be created at the same time by posting a sequence of non-comma-separated JSON objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="filing">The body of the request. If the content type is application/json, the filing JSON objects, which must satisfy the constraints described in the field table. If the content type is application/xbrlx, a ZIP-Deflate-compressed XBRL filing.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="filingDetectionProfileName">when the specified filing is a folder or an xbrlx archive, this parameter can be used to override the algorithm used to identify which files are the filing entrypoint. Allowed values: XBRL (*.xbrl files), XML (*.xml files), XBRLANDXML (*.xbrl and *.xml files), SEC (*.xml files, with custom filters to exclude linkbases), and FSA.</param>
        /// <param name="taxonomy">Whether the specified filing is an XBRL taxonomy or not. (Only used when providing compressed XBRL filings)</param>
        /// <param name="insertEntity">If false, and one or more of the archive entities are not present in the repository an error is raised. If true, the missing entity is inserted. (Default is true, only used when providing compressed XBRL filings)</param>
        /// <param name="contentType">Content-Type of the request, as an HTTP header. It must be set to \&quot;application/json\&quot; when providing a filing in json format, or to \&quot;application/xbrlx\&quot; when providing a ZIP Deflate-compressed XBRL filing.</param>
        /// <returns>Object</returns>
        Object InsertFilings (string token, Object filing, string profileName = null, string formatIndent = no, string aid = null, string filingDetectionProfileName = null, bool? taxonomy = null, bool? insertEntity = true, string contentType = null);
  
        /// <summary>
        /// Add or update filings. The filings are identified with Archive IDs (AIDs).\n\nThere are two ways to create a filing: a full import of an XBRL instance and taxonomy out of a ZIP file, or a new empty filing with a JSON object containing its metadata.\n\nA full import is performed by provided, in the body of the request, a ZIP Deflate-compressed archive. This will import all the facts from the instance, as well as the taxonomy schema and linkbases.\n\nAlternatively, a new empty filing can be created by submitting a JSON object containing general information about the filing. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive |\n| Entity   | string | optional | The EID to which the archive belongs |\n| Entities  | array of strings (at least one) | required if Entity is absent | Used if the archive reports information on more than one entity. |\n| InstanceURL  | string | optional | The URL of the original XBRL instance |\n| Namespaces  | object with string values | optional | Maps prefixes to namespaces for the filing (common bindings are automatically added) |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the filings endpoint as input:\n\n- Components (string)\n- Sections (string)\n- NumSections (integer)\n- NumFacts (integer)\n- NumFootnotes (integer)\n- NumReportElements (integer)\n- NumHypercubes (integer)\n- NumDimensions (integer)\n- NumMembers (integer)\n- NumLineItems (integer)\n- NumAbstracts (integer)\n- NumConcepts (integer)\n\nSeveral empty filings can be created at the same time by posting a sequence of non-comma-separated JSON objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="filing">The body of the request. If the content type is application/json, the filing JSON objects, which must satisfy the constraints described in the field table. If the content type is application/xbrlx, a ZIP-Deflate-compressed XBRL filing.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="filingDetectionProfileName">when the specified filing is a folder or an xbrlx archive, this parameter can be used to override the algorithm used to identify which files are the filing entrypoint. Allowed values: XBRL (*.xbrl files), XML (*.xml files), XBRLANDXML (*.xbrl and *.xml files), SEC (*.xml files, with custom filters to exclude linkbases), and FSA.</param>
        /// <param name="taxonomy">Whether the specified filing is an XBRL taxonomy or not. (Only used when providing compressed XBRL filings)</param>
        /// <param name="insertEntity">If false, and one or more of the archive entities are not present in the repository an error is raised. If true, the missing entity is inserted. (Default is true, only used when providing compressed XBRL filings)</param>
        /// <param name="contentType">Content-Type of the request, as an HTTP header. It must be set to \&quot;application/json\&quot; when providing a filing in json format, or to \&quot;application/xbrlx\&quot; when providing a ZIP Deflate-compressed XBRL filing.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> InsertFilingsAsync (string token, Object filing, string profileName = null, string formatIndent = no, string aid = null, string filingDetectionProfileName = null, bool? taxonomy = null, bool? insertEntity = true, string contentType = null);
        
        /// <summary>
        /// Deletes a filing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <returns>Object</returns>
        Object DeleteFiling (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null);
  
        /// <summary>
        /// Deletes a filing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> DeleteFilingAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null);
        
        /// <summary>
        /// Retrieve labels for the supplied components and report elements
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="labelRole">A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values).</param>
        /// <param name="onlyTextBlocks">If set to true only labels for concepts defined as textBlockItemType are returned (default: false).</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="eliminateReportElementDuplicates">Whether to eliminate (concept name, language, label role) duplicates. By default no duplicate elimination</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListLabels (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string language = null, string labelRole = null, bool? onlyTextBlocks = null, string kind = null, bool? eliminateReportElementDuplicates = null, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve labels for the supplied components and report elements
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="labelRole">A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values).</param>
        /// <param name="onlyTextBlocks">If set to true only labels for concepts defined as textBlockItemType are returned (default: false).</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="eliminateReportElementDuplicates">Whether to eliminate (concept name, language, label role) duplicates. By default no duplicate elimination</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListLabelsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string language = null, string labelRole = null, bool? onlyTextBlocks = null, string kind = null, bool? eliminateReportElementDuplicates = null, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Add or update labels. A label is identified with an Archive ID (AID),\na section URI, a report element, a language and a label role.\n\nA label can be created by submitting a JSON object containing general\ninformation about the label. This JSON object must be valid against a\nJSound schema. It can be either taken from the output of a GET request\nto the same endpoint (in which case it will be valid), or created\nmanually.\n\nFor convenience, we offer a user-friendly summary of the fields\ninvolved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field         | Type   | Presence | Content                          |\n|---------------|--------|----------|----------------------------------|\n| AID           | string | required | The AID of the archive to which the section belongs |\n| SectionURI    | string | required | The URI of the section           |\n| ReportElement | string | required | The name of a report element     |\n| Language      | string | required | A language code, e.g., en-US or de |\n| Role          | string | required | A label role                     |\n| Value         | string | required | The label itself                 |\n\nSeveral labels can be created at the same time by posting a sequence of\nnon-comma-separated JSON objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="label">The label objects (they must be valid).</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        Object UpsertLabels (string token, Object label, string profileName = null, string formatIndent = no);
  
        /// <summary>
        /// Add or update labels. A label is identified with an Archive ID (AID),\na section URI, a report element, a language and a label role.\n\nA label can be created by submitting a JSON object containing general\ninformation about the label. This JSON object must be valid against a\nJSound schema. It can be either taken from the output of a GET request\nto the same endpoint (in which case it will be valid), or created\nmanually.\n\nFor convenience, we offer a user-friendly summary of the fields\ninvolved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field         | Type   | Presence | Content                          |\n|---------------|--------|----------|----------------------------------|\n| AID           | string | required | The AID of the archive to which the section belongs |\n| SectionURI    | string | required | The URI of the section           |\n| ReportElement | string | required | The name of a report element     |\n| Language      | string | required | A language code, e.g., en-US or de |\n| Role          | string | required | A label role                     |\n| Value         | string | required | The label itself                 |\n\nSeveral labels can be created at the same time by posting a sequence of\nnon-comma-separated JSON objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="label">The label objects (they must be valid).</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> UpsertLabelsAsync (string token, Object label, string profileName = null, string formatIndent = no);
        
        /// <summary>
        /// Deletes a label.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="labelRole">A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values).</param>
        /// <returns>Object</returns>
        Object DeleteLabel (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null, List<string> reportElement = null, string language = null, string labelRole = null);
  
        /// <summary>
        /// Deletes a label.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="labelRole">A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> DeleteLabelAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null, List<string> reportElement = null, string language = null, string labelRole = null);
        
        /// <summary>
        /// Retrieve the model structure for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="indent">If set to true all labels will be prepended with 8 space characters for each level of depth within the model structure (default: false).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListModelStructure (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string language = null, bool? indent = false, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve the model structure for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="indent">If set to true all labels will be prepended with 8 space characters for each level of depth within the model structure (default: false).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListModelStructureAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string language = null, bool? indent = false, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Add or update components by providing their model structures. The components are identified with an AID, a section URI and the qualified name of a hypercube.\n\nA new component can be created by submitting a JSON object containing the model structure of the component. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the component belongs |\n| SectionURI   | string (URI) | optional | The URI of the section to which the component belongs |\n| HypercubeName  | string (QName lexical space) | required | The name of the hypercube that this component involves |\n| ModelStructure  | array of model structure node objects | required | The hierarchical model structure, as a tree of nodes that reference report elements (see below) |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:\n\n- Section (string)\n- Hypercube (string)\n\n#### Model structure node properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| Name | string | required | The qualified name of a report element that exists in the component&#39;s section |\n| Children   | array | optional | An array of model structure node objects that reference further children report elements |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:\n\n- Depth (integer)\n- Label (string)\n- BaseType (string)\n- Kind (string)\n- Order (integer)\n- DataType (string)\n- BaseDataType (string)\n- Balance (string)\n- Abstract (boolean)\n- PeriodType (string)\n\nThe hierarchy of the model structure must fulfill the constraints described in the documentation of model structures. We repeat it here for convenience:\n\n| Kind of report element |  Allowed children                           |\n|------------------------|---------------------------------------------|\n| Abstract               | Hypercube (if top-level), Abstract, Concept |\n| Hypercube              | Dimension, LineItems                        |\n| Dimension              | Member                                      |\n| Member                 | Member                                      |\n| LineItems              | Abstract, Concept                           |\n| Concept                | none                                        |\n\nThe model structure MUST involve the hypercube referred to in the top-level HypercubeName field, only this one, and only once, either top-level or below a top-level abstract. Its children are the dimensions with their members, as well as the line items hierarchy.\n\nThe only exception to the requirement of the hypercube report element is the special xbrl28:ImpliedTable hypercube. If HypercubeName is xbrl28:ImpliedTable, then the model structure can only involve Abstracts and Concepts, and has no dimensionality.\n\nSeveral components can be created at the same time by posting a sequence of non-comma-separated JSON model structure objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="modelStructure">The model structures, which must satisfy the constraints described in the properties table.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        Object InsertComponentModelStructure (string token, Object modelStructure, string profileName = null, string formatIndent = no);
  
        /// <summary>
        /// Add or update components by providing their model structures. The components are identified with an AID, a section URI and the qualified name of a hypercube.\n\nA new component can be created by submitting a JSON object containing the model structure of the component. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the component belongs |\n| SectionURI   | string (URI) | optional | The URI of the section to which the component belongs |\n| HypercubeName  | string (QName lexical space) | required | The name of the hypercube that this component involves |\n| ModelStructure  | array of model structure node objects | required | The hierarchical model structure, as a tree of nodes that reference report elements (see below) |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:\n\n- Section (string)\n- Hypercube (string)\n\n#### Model structure node properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| Name | string | required | The qualified name of a report element that exists in the component&#39;s section |\n| Children   | array | optional | An array of model structure node objects that reference further children report elements |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:\n\n- Depth (integer)\n- Label (string)\n- BaseType (string)\n- Kind (string)\n- Order (integer)\n- DataType (string)\n- BaseDataType (string)\n- Balance (string)\n- Abstract (boolean)\n- PeriodType (string)\n\nThe hierarchy of the model structure must fulfill the constraints described in the documentation of model structures. We repeat it here for convenience:\n\n| Kind of report element |  Allowed children                           |\n|------------------------|---------------------------------------------|\n| Abstract               | Hypercube (if top-level), Abstract, Concept |\n| Hypercube              | Dimension, LineItems                        |\n| Dimension              | Member                                      |\n| Member                 | Member                                      |\n| LineItems              | Abstract, Concept                           |\n| Concept                | none                                        |\n\nThe model structure MUST involve the hypercube referred to in the top-level HypercubeName field, only this one, and only once, either top-level or below a top-level abstract. Its children are the dimensions with their members, as well as the line items hierarchy.\n\nThe only exception to the requirement of the hypercube report element is the special xbrl28:ImpliedTable hypercube. If HypercubeName is xbrl28:ImpliedTable, then the model structure can only involve Abstracts and Concepts, and has no dimensionality.\n\nSeveral components can be created at the same time by posting a sequence of non-comma-separated JSON model structure objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="modelStructure">The model structures, which must satisfy the constraints described in the properties table.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> InsertComponentModelStructureAsync (string token, Object modelStructure, string profileName = null, string formatIndent = no);
        
        /// <summary>
        /// Deletes a component including its model structure.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <returns>Object</returns>
        Object DeleteComponentModelStructure (string token, string aid = null, List<int?> section = null, List<string> hypercube = null);
  
        /// <summary>
        /// Deletes a component including its model structure.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> DeleteComponentModelStructureAsync (string token, string aid = null, List<int?> section = null, List<string> hypercube = null);
        
        /// <summary>
        /// Retrieve the periods of the filings filed by a particular entity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListPeriods (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve the periods of the filings filed by a particular entity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListPeriodsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Retrieve the report elements contained in a set of filings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="onlyNames">Whether only the names of the report elements should be returned. If so, the values don&#39;t contain duplicates. (default: false)</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="label">A search term to search in the labels of report elements (e.g. stock)</param>
        /// <param name="onlyTextBlocks">Filters by text block/not text block (default: no filtering)</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="contentType">Content-Type of the request</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListReportElements (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, bool? onlyNames = null, string report = null, string label = null, bool? onlyTextBlocks = null, string kind = null, string language = null, string contentType = null, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve the report elements contained in a set of filings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="onlyNames">Whether only the names of the report elements should be returned. If so, the values don&#39;t contain duplicates. (default: false)</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="label">A search term to search in the labels of report elements (e.g. stock)</param>
        /// <param name="onlyTextBlocks">Filters by text block/not text block (default: no filtering)</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="contentType">Content-Type of the request</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListReportElementsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, bool? onlyNames = null, string report = null, string label = null, bool? onlyTextBlocks = null, string kind = null, string language = null, string contentType = null, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Add or update report elements. The report elements are identified with an AID, a section URI and a qualified name.\n\nA new report element can be created by submitting a JSON object containing general information about the report element. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the report element belongs |\n| SectionURI   | string (URI) | required | The URI of the section to which the report element belongs |\n| Name  | string (QName lexical space) | required | The name of the report element (of the form foo:Bar) |\n| Kind  | One of: Concept, Abstract, LineItems, Hypercube, Dimension, Member | optional | One of the six kinds of report element |\n| PeriodType  | One of: instant, duration | optional | Only allowed for the Concept kind. Indicates the period type (whether facts against this concept must have instant or duration periods). |\n| DataType | string (QName lexical space) | optional | Only allowed for the Concept kind. Indicates the data type (value facts against this concept must have). |\n| Balance | One of: credit, debit | optional | Only allowed for the Concept kind, and if the data type is monetary. Indicates the balance. |\n| IsNillable | boolean | optional | Only allowed for the Concept kind. Specifies whether null is accepted as a fact value. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the report-elements endpoint as input:\n\n- Components (string)\n- IsAbstract (boolean)\n- BaseType (string)\n- ClosestSchemaBuiltinType (string)\n- IsTextBlock (boolean)\n- Labels (string)\n- Facts (string)\n- Labels (string)\n- Label (string)\n- Section (string)\n- CIK (string)\n- EntityRegistrantName (string)\n- FiscalYear (integer)\n- FiscalPeriod (string)\n\nFor report elements with the kind Concept, the data type must be one of the following:\n\n- xbrli:decimalItemType\n- xbrli:floatItemType\n- xbrli:doubleItemType\n- xbrli:integerItemType\n- xbrli:positiveIntegerItemType\n- xbrli:nonPositiveIntegerItemType\n- xbrli:nonNegativeIntegerItemType\n- xbrli:negativeIntegershortItemType\n- xbrli:byteItemType\n- xbrli:intItemType\n- xbrli:longItemType\n- xbrli:unsignedShorItemType\n- xbrli:unsignedByteItemType\n- xbrli:unsignedIntItemType\n- xbrli:unsignedLongItemType\n- xbrli:stringItemType (implied/only one allowed for Hypercube, Dimension, LineItems and Abstract kinds)\n- xbrli:booleanItemType\n- xbrli:hexBinaryItemType\n- xbrli:base64BinaryItemType\n- xbrli:anyURIItemType\n- xbrli:QNameItemType\n- xbrli:durationItemType\n- xbrli:timeItemType\n- xbrli:dateItemType\n- xbrli:gYearMonthItemType\n- xbrli:gYearItemType\n- xbrli:gMonthItemType\n- xbrli:gMonthDayItemType\n- xbrli:gDayItemType\n- xbrli:normalizedStringItemType\n- xbrli:tokenItemType\n- xbrli:languageItemType\n- xbrli:NameItemType\n- xbrli:NCNameItemType\n- xbrli:monetaryItemType (allows Balance)\n- xbrli:pureItemType\n- xbrli:sharesItemType\n- xbrli:fractionItemType\n- nonnum:domainItemType (implied/only one allowed for Member kind)\n- nonnum:escapedItemType\n- nonnum:xmlNodesItemType\n- nonnum:xmlItemType\n- nonnum:textBlockItemType\n- num:percentItemType\n- num:perShareItemType\n- num:areaItemType\n- num:volumeItemType\n- num:massItemType\n- num:weightItemType\n- num:energyItemType\n- num:powerItemType\n- num:lengthItemType\n- num:noDecimalsMonetaryItemType (allows Balance)\n- num:nonNegativeMonetaryItemType (allows Balance)\n- num:nonNegativeNoDecimalsMonetaryItemType (allows Balance)\n- num:enumerationItemType\n\nSeveral report elements can be created at the same time by posting a sequence of non-comma-separated JSON objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="reportElement">The report element objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        Object UpsertReportElements (string token, Object reportElement, string profileName = null, string formatIndent = no);
  
        /// <summary>
        /// Add or update report elements. The report elements are identified with an AID, a section URI and a qualified name.\n\nA new report element can be created by submitting a JSON object containing general information about the report element. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the report element belongs |\n| SectionURI   | string (URI) | required | The URI of the section to which the report element belongs |\n| Name  | string (QName lexical space) | required | The name of the report element (of the form foo:Bar) |\n| Kind  | One of: Concept, Abstract, LineItems, Hypercube, Dimension, Member | optional | One of the six kinds of report element |\n| PeriodType  | One of: instant, duration | optional | Only allowed for the Concept kind. Indicates the period type (whether facts against this concept must have instant or duration periods). |\n| DataType | string (QName lexical space) | optional | Only allowed for the Concept kind. Indicates the data type (value facts against this concept must have). |\n| Balance | One of: credit, debit | optional | Only allowed for the Concept kind, and if the data type is monetary. Indicates the balance. |\n| IsNillable | boolean | optional | Only allowed for the Concept kind. Specifies whether null is accepted as a fact value. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the report-elements endpoint as input:\n\n- Components (string)\n- IsAbstract (boolean)\n- BaseType (string)\n- ClosestSchemaBuiltinType (string)\n- IsTextBlock (boolean)\n- Labels (string)\n- Facts (string)\n- Labels (string)\n- Label (string)\n- Section (string)\n- CIK (string)\n- EntityRegistrantName (string)\n- FiscalYear (integer)\n- FiscalPeriod (string)\n\nFor report elements with the kind Concept, the data type must be one of the following:\n\n- xbrli:decimalItemType\n- xbrli:floatItemType\n- xbrli:doubleItemType\n- xbrli:integerItemType\n- xbrli:positiveIntegerItemType\n- xbrli:nonPositiveIntegerItemType\n- xbrli:nonNegativeIntegerItemType\n- xbrli:negativeIntegershortItemType\n- xbrli:byteItemType\n- xbrli:intItemType\n- xbrli:longItemType\n- xbrli:unsignedShorItemType\n- xbrli:unsignedByteItemType\n- xbrli:unsignedIntItemType\n- xbrli:unsignedLongItemType\n- xbrli:stringItemType (implied/only one allowed for Hypercube, Dimension, LineItems and Abstract kinds)\n- xbrli:booleanItemType\n- xbrli:hexBinaryItemType\n- xbrli:base64BinaryItemType\n- xbrli:anyURIItemType\n- xbrli:QNameItemType\n- xbrli:durationItemType\n- xbrli:timeItemType\n- xbrli:dateItemType\n- xbrli:gYearMonthItemType\n- xbrli:gYearItemType\n- xbrli:gMonthItemType\n- xbrli:gMonthDayItemType\n- xbrli:gDayItemType\n- xbrli:normalizedStringItemType\n- xbrli:tokenItemType\n- xbrli:languageItemType\n- xbrli:NameItemType\n- xbrli:NCNameItemType\n- xbrli:monetaryItemType (allows Balance)\n- xbrli:pureItemType\n- xbrli:sharesItemType\n- xbrli:fractionItemType\n- nonnum:domainItemType (implied/only one allowed for Member kind)\n- nonnum:escapedItemType\n- nonnum:xmlNodesItemType\n- nonnum:xmlItemType\n- nonnum:textBlockItemType\n- num:percentItemType\n- num:perShareItemType\n- num:areaItemType\n- num:volumeItemType\n- num:massItemType\n- num:weightItemType\n- num:energyItemType\n- num:powerItemType\n- num:lengthItemType\n- num:noDecimalsMonetaryItemType (allows Balance)\n- num:nonNegativeMonetaryItemType (allows Balance)\n- num:nonNegativeNoDecimalsMonetaryItemType (allows Balance)\n- num:enumerationItemType\n\nSeveral report elements can be created at the same time by posting a sequence of non-comma-separated JSON objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="reportElement">The report element objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> UpsertReportElementsAsync (string token, Object reportElement, string profileName = null, string formatIndent = no);
        
        /// <summary>
        /// Deletes a report element.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <returns>Object</returns>
        Object DeleteReportElement (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null, List<string> reportElement = null);
  
        /// <summary>
        /// Deletes a report element.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> DeleteReportElementAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null, List<string> reportElement = null);
        
        /// <summary>
        /// Retrieve a summary for all rules of a given section
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListRules (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve a summary for all rules of a given section
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListRulesAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Retrieve a summary for all sections of a given filing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        Object ListSections (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? validate = false, string language = null, bool? count = false, int? top = null, int? skip = null);
  
        /// <summary>
        /// Retrieve a summary for all sections of a given filing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListSectionsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? validate = false, string language = null, bool? count = false, int? top = null, int? skip = null);
        
        /// <summary>
        /// Add or update sections. A section is identified with an Archive ID (AID) and a section URI.\n\nA section can be created by submitting a JSON object containing general information about the section. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the section belongs |\n| SectionURI   | string | required | The URI of the section |\n| Section  | string | required | A user-friendly label for the section (preferably in English). |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the sections endpoint as input:\n\n- Components (string)\n- ReportElements (string)\n- FactTable (string)\n- Spreadsheet (string)\n- Category (string)\n- SubCategory (string)\n- Disclosure (string)\n- NumRules (integer)\n- NumReportElements (integer)\n- NumHypercubes (integer)\n- NumDimensions (integer)\n- NumMembers (integer)\n- NumLineItems (integer)\n- NumAbstracts (integer)\n- NumConcepts (integer)\n- EntityRegistrantName (string)\n- CIK (string)\n- FiscalYear (integer)\n- FiscalPeriod (string)\n- AcceptanceDatetime (string)\n- FormType (string)\n\nSeveral empty sections can be created at the same time by posting a sequence of non-comma-separated JSON objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="section">The section objects (they must be valid).</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        Object UpsertSections (string token, Object section, string profileName = null, string formatIndent = no);
  
        /// <summary>
        /// Add or update sections. A section is identified with an Archive ID (AID) and a section URI.\n\nA section can be created by submitting a JSON object containing general information about the section. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the section belongs |\n| SectionURI   | string | required | The URI of the section |\n| Section  | string | required | A user-friendly label for the section (preferably in English). |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the sections endpoint as input:\n\n- Components (string)\n- ReportElements (string)\n- FactTable (string)\n- Spreadsheet (string)\n- Category (string)\n- SubCategory (string)\n- Disclosure (string)\n- NumRules (integer)\n- NumReportElements (integer)\n- NumHypercubes (integer)\n- NumDimensions (integer)\n- NumMembers (integer)\n- NumLineItems (integer)\n- NumAbstracts (integer)\n- NumConcepts (integer)\n- EntityRegistrantName (string)\n- CIK (string)\n- FiscalYear (integer)\n- FiscalPeriod (string)\n- AcceptanceDatetime (string)\n- FormType (string)\n\nSeveral empty sections can be created at the same time by posting a sequence of non-comma-separated JSON objects as above.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="section">The section objects (they must be valid).</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> UpsertSectionsAsync (string token, Object section, string profileName = null, string formatIndent = no);
        
        /// <summary>
        /// Deletes a section.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <returns>Object</returns>
        Object DeleteSection (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null);
  
        /// <summary>
        /// Deletes a section.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> DeleteSectionAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null);
        
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a given component.\n\nA component can be selected in several ways, for example with an Archive ID (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="merge">Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param>
        /// <param name="eliminate">Whether to eliminate empty rows / columns (Default: true if no row / column parameter is used).</param>
        /// <param name="eliminationThreshold">When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0).</param>
        /// <param name="autoSlice">If set to true then slicers are automatically defined (default: true).</param>
        /// <param name="row">Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination.</param>
        /// <param name="column">Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination.</param>
        /// <param name="flattenRowHeaders">Whether to flatten row headers to single columns (Default: true).</param>
        /// <returns>Object</returns>
        Object SpreadsheetForComponent (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<int?> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, string additionalRules = null, string auditTrails = no, bool? open = null, List<string> filingKind = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string aggregationFunction = null, bool? validate = false, bool? merge = true, string language = null, bool? _override = null, bool? eliminate = null, int? eliminationThreshold = 0, bool? autoSlice = true, List<int?> row = null, List<int?> column = null, bool? flattenRowHeaders = true);
  
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a given component.\n\nA component can be selected in several ways, for example with an Archive ID (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="merge">Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param>
        /// <param name="eliminate">Whether to eliminate empty rows / columns (Default: true if no row / column parameter is used).</param>
        /// <param name="eliminationThreshold">When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0).</param>
        /// <param name="autoSlice">If set to true then slicers are automatically defined (default: true).</param>
        /// <param name="row">Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination.</param>
        /// <param name="column">Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination.</param>
        /// <param name="flattenRowHeaders">Whether to flatten row headers to single columns (Default: true).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> SpreadsheetForComponentAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<int?> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, string additionalRules = null, string auditTrails = no, bool? open = null, List<string> filingKind = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string aggregationFunction = null, bool? validate = false, bool? merge = true, string language = null, bool? _override = null, bool? eliminate = null, int? eliminationThreshold = 0, bool? autoSlice = true, List<int?> row = null, List<int?> column = null, bool? flattenRowHeaders = true);
        
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a report.\n\nFilters can be overriden. Filters MUST be overriden if the report is not already filtering.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="eliminate">Whether to eliminate empty rows / columns (Default: true if no row / column parameter is used).</param>
        /// <param name="eliminationThreshold">When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0).</param>
        /// <param name="row">Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination.</param>
        /// <param name="column">Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination.</param>
        /// <param name="flattenRowHeaders">Whether to flatten row headers to single columns (Default: true).</param>
        /// <returns>Object</returns>
        Object ListSpreadsheetForReport (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string report = null, bool? validate = false, string language = null, bool? eliminate = null, int? eliminationThreshold = 0, List<int?> row = null, List<int?> column = null, bool? flattenRowHeaders = true);
  
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a report.\n\nFilters can be overriden. Filters MUST be overriden if the report is not already filtering.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="eliminate">Whether to eliminate empty rows / columns (Default: true if no row / column parameter is used).</param>
        /// <param name="eliminationThreshold">When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0).</param>
        /// <param name="row">Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination.</param>
        /// <param name="column">Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination.</param>
        /// <param name="flattenRowHeaders">Whether to flatten row headers to single columns (Default: true).</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListSpreadsheetForReportAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string report = null, bool? validate = false, string language = null, bool? eliminate = null, int? eliminationThreshold = 0, List<int?> row = null, List<int?> column = null, bool? flattenRowHeaders = true);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DataApi : IDataApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DataApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Retrieve a summary for all components of a given filing 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param> 
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param> 
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param> 
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <returns>Object</returns>            
        public Object ListComponents (string token, string profileName = null, string formatIndent = no, List<string> eid = null, List<string> ticker = null, List<string> tag = null, List<string> sic = null, List<string> cik = null, List<int?> edinetcode = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, string aid = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? count = false, int? top = null, int? skip = null, bool? validate = false, string language = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListComponents");
            
    
            var path = "/api/components";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListComponents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListComponents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a summary for all components of a given filing 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListComponentsAsync (string token, string profileName = null, string formatIndent = no, List<string> eid = null, List<string> ticker = null, List<string> tag = null, List<string> sic = null, List<string> cik = null, List<int?> edinetcode = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, string aid = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? count = false, int? top = null, int? skip = null, bool? validate = false, string language = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListComponents");
            
    
            var path = "/api/components";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListComponents: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve metadata about the entities that submit filings. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="entitySearch">Includes in the results the entities whose name match this full-text query</param> 
        /// <param name="entitySearchOffset">Includes in the results the entities whose name match the entity-search parameter skipping the first entity-search-offset results (default: 0)</param> 
        /// <param name="entitySearchLimit">Includes in the results the entities whose name match the entity-search parameter limited to a maximum of entity-search-limit results (default: 10)</param> 
        /// <param name="language">Specifies in which language to perform the entity-search query (default: en-US)</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListEntities (string token, string profileName = null, string formatIndent = no, List<string> tag = null, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> sic = null, List<string> ticker = null, string entitySearch = null, int? entitySearchOffset = null, int? entitySearchLimit = null, string language = en-US, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListEntities");
            
    
            var path = "/api/entities";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (entitySearch != null) queryParams.Add("entity-search", ApiClient.ParameterToString(entitySearch)); // query parameter
            if (entitySearchOffset != null) queryParams.Add("entity-search-offset", ApiClient.ParameterToString(entitySearchOffset)); // query parameter
            if (entitySearchLimit != null) queryParams.Add("entity-search-limit", ApiClient.ParameterToString(entitySearchLimit)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListEntities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListEntities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve metadata about the entities that submit filings. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="entitySearch">Includes in the results the entities whose name match this full-text query</param>
        /// <param name="entitySearchOffset">Includes in the results the entities whose name match the entity-search parameter skipping the first entity-search-offset results (default: 0)</param>
        /// <param name="entitySearchLimit">Includes in the results the entities whose name match the entity-search parameter limited to a maximum of entity-search-limit results (default: 10)</param>
        /// <param name="language">Specifies in which language to perform the entity-search query (default: en-US)</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListEntitiesAsync (string token, string profileName = null, string formatIndent = no, List<string> tag = null, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> sic = null, List<string> ticker = null, string entitySearch = null, int? entitySearchOffset = null, int? entitySearchLimit = null, string language = en-US, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListEntities");
            
    
            var path = "/api/entities";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (entitySearch != null) queryParams.Add("entity-search", ApiClient.ParameterToString(entitySearch)); // query parameter
            if (entitySearchOffset != null) queryParams.Add("entity-search-offset", ApiClient.ParameterToString(entitySearchOffset)); // query parameter
            if (entitySearchLimit != null) queryParams.Add("entity-search-limit", ApiClient.ParameterToString(entitySearchLimit)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListEntities: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Add or update entity. The entities are identified with Entity IDs (EIDs).\n\nAn entity must be specified as a JSON object that must be valid against a JSound schema.  It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| EID   | string | optional | The entity ID (EID). |\n| EIDs  | array of strings (at least one) | required if EID is absent | The EIDs, if more than one EID exists for this entity. Must be present if and only if EID is absent. |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following field is allowed for the purpose of feeding back the output of the entities endpoint as input:\n\n- Archives (string)\n\nSeveral entities can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="entity">The entity objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <returns>Object</returns>            
        public Object InsertEntities (string token, Object entity, string profileName = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling InsertEntities");
            
            // verify the required parameter 'entity' is set
            if (entity == null) throw new ApiException(400, "Missing required parameter 'entity' when calling InsertEntities");
            
    
            var path = "/api/entities";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(entity); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InsertEntities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InsertEntities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Add or update entity. The entities are identified with Entity IDs (EIDs).\n\nAn entity must be specified as a JSON object that must be valid against a JSound schema.  It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| EID   | string | optional | The entity ID (EID). |\n| EIDs  | array of strings (at least one) | required if EID is absent | The EIDs, if more than one EID exists for this entity. Must be present if and only if EID is absent. |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following field is allowed for the purpose of feeding back the output of the entities endpoint as input:\n\n- Archives (string)\n\nSeveral entities can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="entity">The entity objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> InsertEntitiesAsync (string token, Object entity, string profileName = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling InsertEntities");
            // verify the required parameter 'entity' is set
            if (entity == null) throw new ApiException(400, "Missing required parameter 'entity' when calling InsertEntities");
            
    
            var path = "/api/entities";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(entity); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InsertEntities: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Deletes an entity. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <returns>Object</returns>            
        public Object DeleteEntity (string token, string profileName = null, string formatIndent = no, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> ticker = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteEntity");
            
    
            var path = "/api/entities";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Deletes an entity. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteEntityAsync (string token, string profileName = null, string formatIndent = no, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> ticker = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteEntity");
            
    
            var path = "/api/entities";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteEntity: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve one or more facts for a combination of filings. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param> 
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param> 
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param> 
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="map">[Deprecated, use report] The concept map that should be used to resolve the concept (default: none).</param> 
        /// <param name="rule">[Deprecated, use report] The rules that should be used to resolve the concept (default: none).</param> 
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param> 
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param> 
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param> 
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param> 
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param> 
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param> 
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string.</param> 
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string.</param> 
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param> 
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param> 
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param> 
        /// <param name="dimensionColumns">If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order).</param> 
        /// <param name="dimensionAggregation">[Deprecated] Specifies whether this dimension is a dicer (&#39;group&#39;) or not (&#39;no&#39;). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers (&#39;group&#39;) and non-key aspects are not (&#39;no&#39;). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer.</param> 
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param> 
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListFacts (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string map = null, string rule = null, string report = null, string additionalRules = null, bool? labels = false, string auditTrails = no, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, Dictionary<string, string> dimensionAggregation = null, string aggregationFunction = null, bool? validate = false, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFacts");
            
    
            var path = "/api/facts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (map != null) queryParams.Add("map", ApiClient.ParameterToString(map)); // query parameter
            if (rule != null) queryParams.Add("rule", ApiClient.ParameterToString(rule)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (auditTrails != null) queryParams.Add("audit-trails", ApiClient.ParameterToString(auditTrails)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (aggregationFunction != null) queryParams.Add("aggregation-function", ApiClient.ParameterToString(aggregationFunction)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            if (dimensions != null) ApiClient.AddPatternQueryParameters(dimensions, "^[^:]+:[^:]+$", queryParams); // pattern query parameter
            if (dimensionTypes != null) ApiClient.AddPatternQueryParameters(dimensionTypes, "^[^:]+:[^:]+::type$", queryParams); // pattern query parameter
            if (defaultDimensionValues != null) ApiClient.AddPatternQueryParameters(defaultDimensionValues, "^[^:]+:[^:]+::default$", queryParams); // pattern query parameter
            if (dimensionsCategory != null) ApiClient.AddPatternQueryParameters(dimensionsCategory, "^[^:]+:[^:]+::category$", queryParams); // pattern query parameter
            if (dimensionsVisible != null) ApiClient.AddPatternQueryParameters(dimensionsVisible, "^[^:]+:[^:]+::visible$", queryParams); // pattern query parameter
            if (dimensionSlicers != null) ApiClient.AddPatternQueryParameters(dimensionSlicers, "^[^:]+:[^:]+::slicer$", queryParams); // pattern query parameter
            if (dimensionColumns != null) ApiClient.AddPatternQueryParameters(dimensionColumns, "^[^:]+:[^:]+::column$", queryParams); // pattern query parameter
            if (dimensionAggregation != null) ApiClient.AddPatternQueryParameters(dimensionAggregation, "^[^:]+:[^:]+::aggregation$", queryParams); // pattern query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve one or more facts for a combination of filings. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="map">[Deprecated, use report] The concept map that should be used to resolve the concept (default: none).</param>
        /// <param name="rule">[Deprecated, use report] The rules that should be used to resolve the concept (default: none).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param>
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string.</param>
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string.</param>
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param>
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param>
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param>
        /// <param name="dimensionColumns">If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order).</param>
        /// <param name="dimensionAggregation">[Deprecated] Specifies whether this dimension is a dicer (&#39;group&#39;) or not (&#39;no&#39;). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers (&#39;group&#39;) and non-key aspects are not (&#39;no&#39;). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer.</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListFactsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string map = null, string rule = null, string report = null, string additionalRules = null, bool? labels = false, string auditTrails = no, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, Dictionary<string, string> dimensionAggregation = null, string aggregationFunction = null, bool? validate = false, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFacts");
            
    
            var path = "/api/facts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (map != null) queryParams.Add("map", ApiClient.ParameterToString(map)); // query parameter
            if (rule != null) queryParams.Add("rule", ApiClient.ParameterToString(rule)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (auditTrails != null) queryParams.Add("audit-trails", ApiClient.ParameterToString(auditTrails)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (aggregationFunction != null) queryParams.Add("aggregation-function", ApiClient.ParameterToString(aggregationFunction)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            if (dimensions != null) ApiClient.AddPatternQueryParameters(dimensions, "^[^:]+:[^:]+$", queryParams); // pattern query parameter
            if (dimensionTypes != null) ApiClient.AddPatternQueryParameters(dimensionTypes, "^[^:]+:[^:]+::type$", queryParams); // pattern query parameter
            if (defaultDimensionValues != null) ApiClient.AddPatternQueryParameters(defaultDimensionValues, "^[^:]+:[^:]+::default$", queryParams); // pattern query parameter
            if (dimensionsCategory != null) ApiClient.AddPatternQueryParameters(dimensionsCategory, "^[^:]+:[^:]+::category$", queryParams); // pattern query parameter
            if (dimensionsVisible != null) ApiClient.AddPatternQueryParameters(dimensionsVisible, "^[^:]+:[^:]+::visible$", queryParams); // pattern query parameter
            if (dimensionSlicers != null) ApiClient.AddPatternQueryParameters(dimensionSlicers, "^[^:]+:[^:]+::slicer$", queryParams); // pattern query parameter
            if (dimensionColumns != null) ApiClient.AddPatternQueryParameters(dimensionColumns, "^[^:]+:[^:]+::column$", queryParams); // pattern query parameter
            if (dimensionAggregation != null) ApiClient.AddPatternQueryParameters(dimensionAggregation, "^[^:]+:[^:]+::aggregation$", queryParams); // pattern query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFacts: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Add a fact to a filing. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="fact">The fact objects (they must be valid, and have an archive aspect that points to an existing archive). To logically delete a fact, omit the Value field.</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <returns>Object</returns>            
        public Object AddFacts (string token, Object fact, string formatIndent = no)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddFacts");
            
            // verify the required parameter 'fact' is set
            if (fact == null) throw new ApiException(400, "Missing required parameter 'fact' when calling AddFacts");
            
    
            var path = "/api/facts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(fact); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Add a fact to a filing. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="fact">The fact objects (they must be valid, and have an archive aspect that points to an existing archive). To logically delete a fact, omit the Value field.</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> AddFactsAsync (string token, Object fact, string formatIndent = no)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddFacts");
            // verify the required parameter 'fact' is set
            if (fact == null) throw new ApiException(400, "Missing required parameter 'fact' when calling AddFacts");
            
    
            var path = "/api/facts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(fact); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFacts: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Patch one or more facts 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="patch">The patch object, which will be merged into each facts (the facts must be valid after applying it).</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param> 
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param> 
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param> 
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="map">[Deprecated, use report] The concept map that should be used to resolve the concept (default: none).</param> 
        /// <param name="rule">[Deprecated, use report] The rules that should be used to resolve the concept (default: none).</param> 
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param> 
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param> 
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param> 
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param> 
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string.</param> 
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string.</param> 
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param> 
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param> 
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param> 
        /// <param name="dimensionColumns">If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order).</param> 
        /// <param name="dimensionAggregation">[Deprecated] Specifies whether this dimension is a dicer (&#39;group&#39;) or not (&#39;no&#39;). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers (&#39;group&#39;) and non-key aspects are not (&#39;no&#39;). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer.</param> 
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param> 
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <returns>Object</returns>            
        public Object PatchFacts (string token, Object patch, string profileName = null, string formatIndent = no, List<string> tag = null, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> sic = null, List<string> ticker = null, string aid = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string map = null, string rule = null, string report = null, string additionalRules = null, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, Dictionary<string, string> dimensionAggregation = null, string aggregationFunction = null, bool? validate = false, bool? count = false)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling PatchFacts");
            
            // verify the required parameter 'patch' is set
            if (patch == null) throw new ApiException(400, "Missing required parameter 'patch' when calling PatchFacts");
            
    
            var path = "/api/facts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (map != null) queryParams.Add("map", ApiClient.ParameterToString(map)); // query parameter
            if (rule != null) queryParams.Add("rule", ApiClient.ParameterToString(rule)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (aggregationFunction != null) queryParams.Add("aggregation-function", ApiClient.ParameterToString(aggregationFunction)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            
            if (dimensions != null) ApiClient.AddPatternQueryParameters(dimensions, "^[^:]+:[^:]+$", queryParams); // pattern query parameter
            if (dimensionTypes != null) ApiClient.AddPatternQueryParameters(dimensionTypes, "^[^:]+:[^:]+::type$", queryParams); // pattern query parameter
            if (defaultDimensionValues != null) ApiClient.AddPatternQueryParameters(defaultDimensionValues, "^[^:]+:[^:]+::default$", queryParams); // pattern query parameter
            if (dimensionsCategory != null) ApiClient.AddPatternQueryParameters(dimensionsCategory, "^[^:]+:[^:]+::category$", queryParams); // pattern query parameter
            if (dimensionsVisible != null) ApiClient.AddPatternQueryParameters(dimensionsVisible, "^[^:]+:[^:]+::visible$", queryParams); // pattern query parameter
            if (dimensionSlicers != null) ApiClient.AddPatternQueryParameters(dimensionSlicers, "^[^:]+:[^:]+::slicer$", queryParams); // pattern query parameter
            if (dimensionColumns != null) ApiClient.AddPatternQueryParameters(dimensionColumns, "^[^:]+:[^:]+::column$", queryParams); // pattern query parameter
            if (dimensionAggregation != null) ApiClient.AddPatternQueryParameters(dimensionAggregation, "^[^:]+:[^:]+::aggregation$", queryParams); // pattern query parameter
            
            
            
            postBody = ApiClient.Serialize(patch); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchFacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchFacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Patch one or more facts 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="patch">The patch object, which will be merged into each facts (the facts must be valid after applying it).</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="map">[Deprecated, use report] The concept map that should be used to resolve the concept (default: none).</param>
        /// <param name="rule">[Deprecated, use report] The rules that should be used to resolve the concept (default: none).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param>
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions; Some further dimensions may have default types depending on the profile). Each key is in the form prefix:dimension::type, each value is a string.</param>
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string.</param>
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param>
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param>
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param>
        /// <param name="dimensionColumns">If the dimension is visible in the output, specifies the position at which it appears in the output fact table (default: arbitrary order).</param>
        /// <param name="dimensionAggregation">[Deprecated] Specifies whether this dimension is a dicer (&#39;group&#39;) or not (&#39;no&#39;). If a dicer, facts will be grouped along this dimension before applying the supplied aggregation function. By default, all key aspects, except those explicitly specified as slicers, are dicers (&#39;group&#39;) and non-key aspects are not (&#39;no&#39;). Has no effect if no aggregation function is supplied, or if the dimension is explicitly specified as a slicer.</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> PatchFactsAsync (string token, Object patch, string profileName = null, string formatIndent = no, List<string> tag = null, List<string> eid = null, List<string> cik = null, List<int?> edinetcode = null, List<string> sic = null, List<string> ticker = null, string aid = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, List<string> archiveFiscalYear = null, List<string> archiveFiscalPeriod = null, string map = null, string rule = null, string report = null, string additionalRules = null, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, Dictionary<string, string> dimensionAggregation = null, string aggregationFunction = null, bool? validate = false, bool? count = false)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling PatchFacts");
            // verify the required parameter 'patch' is set
            if (patch == null) throw new ApiException(400, "Missing required parameter 'patch' when calling PatchFacts");
            
    
            var path = "/api/facts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (map != null) queryParams.Add("map", ApiClient.ParameterToString(map)); // query parameter
            if (rule != null) queryParams.Add("rule", ApiClient.ParameterToString(rule)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (aggregationFunction != null) queryParams.Add("aggregation-function", ApiClient.ParameterToString(aggregationFunction)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            
            if (dimensions != null) ApiClient.AddPatternQueryParameters(dimensions, "^[^:]+:[^:]+$", queryParams); // pattern query parameter
            if (dimensionTypes != null) ApiClient.AddPatternQueryParameters(dimensionTypes, "^[^:]+:[^:]+::type$", queryParams); // pattern query parameter
            if (defaultDimensionValues != null) ApiClient.AddPatternQueryParameters(defaultDimensionValues, "^[^:]+:[^:]+::default$", queryParams); // pattern query parameter
            if (dimensionsCategory != null) ApiClient.AddPatternQueryParameters(dimensionsCategory, "^[^:]+:[^:]+::category$", queryParams); // pattern query parameter
            if (dimensionsVisible != null) ApiClient.AddPatternQueryParameters(dimensionsVisible, "^[^:]+:[^:]+::visible$", queryParams); // pattern query parameter
            if (dimensionSlicers != null) ApiClient.AddPatternQueryParameters(dimensionSlicers, "^[^:]+:[^:]+::slicer$", queryParams); // pattern query parameter
            if (dimensionColumns != null) ApiClient.AddPatternQueryParameters(dimensionColumns, "^[^:]+:[^:]+::column$", queryParams); // pattern query parameter
            if (dimensionAggregation != null) ApiClient.AddPatternQueryParameters(dimensionAggregation, "^[^:]+:[^:]+::aggregation$", queryParams); // pattern query parameter
            
            
            
            postBody = ApiClient.Serialize(patch); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PatchFacts: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the fact table for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param> 
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param> 
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param> 
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param> 
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param> 
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param> 
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param> 
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param> 
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param> 
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param> 
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param> 
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param> 
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param> 
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param> 
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param> 
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param> 
        /// <param name="merge">Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true).</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListFactTable (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<int?> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, string additionalRules = null, bool? labels = false, string auditTrails = no, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, List<string> filingKind = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string aggregationFunction = null, bool? validate = false, bool? merge = true, string language = null, bool? _override = null, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFactTable");
            
    
            var path = "/api/facttable-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (auditTrails != null) queryParams.Add("audit-trails", ApiClient.ParameterToString(auditTrails)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (aggregationFunction != null) queryParams.Add("aggregation-function", ApiClient.ParameterToString(aggregationFunction)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (merge != null) queryParams.Add("merge", ApiClient.ParameterToString(merge)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (_override != null) queryParams.Add("override", ApiClient.ParameterToString(_override)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            if (dimensions != null) ApiClient.AddPatternQueryParameters(dimensions, "^[^:]+:[^:]+$", queryParams); // pattern query parameter
            if (dimensionsCategory != null) ApiClient.AddPatternQueryParameters(dimensionsCategory, "^[^:]+:[^:]+::category$", queryParams); // pattern query parameter
            if (dimensionsVisible != null) ApiClient.AddPatternQueryParameters(dimensionsVisible, "^[^:]+:[^:]+::visible$", queryParams); // pattern query parameter
            if (dimensionSlicers != null) ApiClient.AddPatternQueryParameters(dimensionSlicers, "^[^:]+:[^:]+::slicer$", queryParams); // pattern query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the fact table for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string.</param>
        /// <param name="dimensionsCategory">Specifies whether the dimension is a slicer, a dicer, or unchanged. If an aggregation function is specified, facts are aggregated along this dimension (default: unchanged).</param>
        /// <param name="dimensionsVisible">Specifies whether the dimension is visible in the output. Only applies to dimensions defined as slicers. Default: false for slicers, but always true for dicers.</param>
        /// <param name="dimensionSlicers">[Deprecated] Specifies whether the dimension is a slicer (true) or not (false). Slicer dimensions do not appear in the output fact table, and if an aggregation function is specified, facts are aggregated along this dimension (default: false).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="merge">Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListFactTableAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<int?> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, string additionalRules = null, bool? labels = false, string auditTrails = no, bool? open = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionsCategory = null, Dictionary<string, bool?> dimensionsVisible = null, Dictionary<string, bool?> dimensionSlicers = null, List<string> filingKind = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string aggregationFunction = null, bool? validate = false, bool? merge = true, string language = null, bool? _override = null, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFactTable");
            
    
            var path = "/api/facttable-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (auditTrails != null) queryParams.Add("audit-trails", ApiClient.ParameterToString(auditTrails)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (aggregationFunction != null) queryParams.Add("aggregation-function", ApiClient.ParameterToString(aggregationFunction)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (merge != null) queryParams.Add("merge", ApiClient.ParameterToString(merge)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (_override != null) queryParams.Add("override", ApiClient.ParameterToString(_override)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            if (dimensions != null) ApiClient.AddPatternQueryParameters(dimensions, "^[^:]+:[^:]+$", queryParams); // pattern query parameter
            if (dimensionsCategory != null) ApiClient.AddPatternQueryParameters(dimensionsCategory, "^[^:]+:[^:]+::category$", queryParams); // pattern query parameter
            if (dimensionsVisible != null) ApiClient.AddPatternQueryParameters(dimensionsVisible, "^[^:]+:[^:]+::visible$", queryParams); // pattern query parameter
            if (dimensionSlicers != null) ApiClient.AddPatternQueryParameters(dimensionSlicers, "^[^:]+:[^:]+::slicer$", queryParams); // pattern query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTable: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param> 
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param> 
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param> 
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param> 
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param> 
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param> 
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param> 
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param> 
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListFactTableForReport (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, bool? open = null, string report = null, bool? labels = false, string auditTrails = no, string language = null, string aggregationFunction = null, bool? validate = false, bool? _override = null, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFactTableForReport");
            
    
            var path = "/api/facttable-for-report";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (auditTrails != null) queryParams.Add("audit-trails", ApiClient.ParameterToString(auditTrails)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (aggregationFunction != null) queryParams.Add("aggregation-function", ApiClient.ParameterToString(aggregationFunction)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (_override != null) queryParams.Add("override", ApiClient.ParameterToString(_override)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTableForReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTableForReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="labels">Whether human-readable labels should be included for concepts in each fact (default: false).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListFactTableForReportAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, bool? open = null, string report = null, bool? labels = false, string auditTrails = no, string language = null, string aggregationFunction = null, bool? validate = false, bool? _override = null, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFactTableForReport");
            
    
            var path = "/api/facttable-for-report";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (auditTrails != null) queryParams.Add("audit-trails", ApiClient.ParameterToString(auditTrails)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (aggregationFunction != null) queryParams.Add("aggregation-function", ApiClient.ParameterToString(aggregationFunction)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (_override != null) queryParams.Add("override", ApiClient.ParameterToString(_override)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTableForReport: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve metadata about the filings, also called archives. The filings are identified with Archive IDs (AIDs). Facts can be bound with filings with the xbrl28:Archive aspect, whose values are AIDs. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListFilings (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, string language = null, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFilings");
            
    
            var path = "/api/filings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFilings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFilings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve metadata about the filings, also called archives. The filings are identified with Archive IDs (AIDs). Facts can be bound with filings with the xbrl28:Archive aspect, whose values are AIDs. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListFilingsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, string language = null, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFilings");
            
    
            var path = "/api/filings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFilings: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Add or update filings. The filings are identified with Archive IDs (AIDs).\n\nThere are two ways to create a filing: a full import of an XBRL instance and taxonomy out of a ZIP file, or a new empty filing with a JSON object containing its metadata.\n\nA full import is performed by provided, in the body of the request, a ZIP Deflate-compressed archive. This will import all the facts from the instance, as well as the taxonomy schema and linkbases.\n\nAlternatively, a new empty filing can be created by submitting a JSON object containing general information about the filing. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive |\n| Entity   | string | optional | The EID to which the archive belongs |\n| Entities  | array of strings (at least one) | required if Entity is absent | Used if the archive reports information on more than one entity. |\n| InstanceURL  | string | optional | The URL of the original XBRL instance |\n| Namespaces  | object with string values | optional | Maps prefixes to namespaces for the filing (common bindings are automatically added) |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the filings endpoint as input:\n\n- Components (string)\n- Sections (string)\n- NumSections (integer)\n- NumFacts (integer)\n- NumFootnotes (integer)\n- NumReportElements (integer)\n- NumHypercubes (integer)\n- NumDimensions (integer)\n- NumMembers (integer)\n- NumLineItems (integer)\n- NumAbstracts (integer)\n- NumConcepts (integer)\n\nSeveral empty filings can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="filing">The body of the request. If the content type is application/json, the filing JSON objects, which must satisfy the constraints described in the field table. If the content type is application/xbrlx, a ZIP-Deflate-compressed XBRL filing.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="filingDetectionProfileName">when the specified filing is a folder or an xbrlx archive, this parameter can be used to override the algorithm used to identify which files are the filing entrypoint. Allowed values: XBRL (*.xbrl files), XML (*.xml files), XBRLANDXML (*.xbrl and *.xml files), SEC (*.xml files, with custom filters to exclude linkbases), and FSA.</param> 
        /// <param name="taxonomy">Whether the specified filing is an XBRL taxonomy or not. (Only used when providing compressed XBRL filings)</param> 
        /// <param name="insertEntity">If false, and one or more of the archive entities are not present in the repository an error is raised. If true, the missing entity is inserted. (Default is true, only used when providing compressed XBRL filings)</param> 
        /// <param name="contentType">Content-Type of the request, as an HTTP header. It must be set to \&quot;application/json\&quot; when providing a filing in json format, or to \&quot;application/xbrlx\&quot; when providing a ZIP Deflate-compressed XBRL filing.</param> 
        /// <returns>Object</returns>            
        public Object InsertFilings (string token, Object filing, string profileName = null, string formatIndent = no, string aid = null, string filingDetectionProfileName = null, bool? taxonomy = null, bool? insertEntity = true, string contentType = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling InsertFilings");
            
            // verify the required parameter 'filing' is set
            if (filing == null) throw new ApiException(400, "Missing required parameter 'filing' when calling InsertFilings");
            
    
            var path = "/api/filings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (filingDetectionProfileName != null) queryParams.Add("filing-detection-profile-name", ApiClient.ParameterToString(filingDetectionProfileName)); // query parameter
            if (taxonomy != null) queryParams.Add("taxonomy", ApiClient.ParameterToString(taxonomy)); // query parameter
            if (insertEntity != null) queryParams.Add("insert-entity", ApiClient.ParameterToString(insertEntity)); // query parameter
            
            
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            
            
            postBody = ApiClient.Serialize(filing); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InsertFilings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InsertFilings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Add or update filings. The filings are identified with Archive IDs (AIDs).\n\nThere are two ways to create a filing: a full import of an XBRL instance and taxonomy out of a ZIP file, or a new empty filing with a JSON object containing its metadata.\n\nA full import is performed by provided, in the body of the request, a ZIP Deflate-compressed archive. This will import all the facts from the instance, as well as the taxonomy schema and linkbases.\n\nAlternatively, a new empty filing can be created by submitting a JSON object containing general information about the filing. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive |\n| Entity   | string | optional | The EID to which the archive belongs |\n| Entities  | array of strings (at least one) | required if Entity is absent | Used if the archive reports information on more than one entity. |\n| InstanceURL  | string | optional | The URL of the original XBRL instance |\n| Namespaces  | object with string values | optional | Maps prefixes to namespaces for the filing (common bindings are automatically added) |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the filings endpoint as input:\n\n- Components (string)\n- Sections (string)\n- NumSections (integer)\n- NumFacts (integer)\n- NumFootnotes (integer)\n- NumReportElements (integer)\n- NumHypercubes (integer)\n- NumDimensions (integer)\n- NumMembers (integer)\n- NumLineItems (integer)\n- NumAbstracts (integer)\n- NumConcepts (integer)\n\nSeveral empty filings can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="filing">The body of the request. If the content type is application/json, the filing JSON objects, which must satisfy the constraints described in the field table. If the content type is application/xbrlx, a ZIP-Deflate-compressed XBRL filing.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="filingDetectionProfileName">when the specified filing is a folder or an xbrlx archive, this parameter can be used to override the algorithm used to identify which files are the filing entrypoint. Allowed values: XBRL (*.xbrl files), XML (*.xml files), XBRLANDXML (*.xbrl and *.xml files), SEC (*.xml files, with custom filters to exclude linkbases), and FSA.</param>
        /// <param name="taxonomy">Whether the specified filing is an XBRL taxonomy or not. (Only used when providing compressed XBRL filings)</param>
        /// <param name="insertEntity">If false, and one or more of the archive entities are not present in the repository an error is raised. If true, the missing entity is inserted. (Default is true, only used when providing compressed XBRL filings)</param>
        /// <param name="contentType">Content-Type of the request, as an HTTP header. It must be set to \&quot;application/json\&quot; when providing a filing in json format, or to \&quot;application/xbrlx\&quot; when providing a ZIP Deflate-compressed XBRL filing.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> InsertFilingsAsync (string token, Object filing, string profileName = null, string formatIndent = no, string aid = null, string filingDetectionProfileName = null, bool? taxonomy = null, bool? insertEntity = true, string contentType = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling InsertFilings");
            // verify the required parameter 'filing' is set
            if (filing == null) throw new ApiException(400, "Missing required parameter 'filing' when calling InsertFilings");
            
    
            var path = "/api/filings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (filingDetectionProfileName != null) queryParams.Add("filing-detection-profile-name", ApiClient.ParameterToString(filingDetectionProfileName)); // query parameter
            if (taxonomy != null) queryParams.Add("taxonomy", ApiClient.ParameterToString(taxonomy)); // query parameter
            if (insertEntity != null) queryParams.Add("insert-entity", ApiClient.ParameterToString(insertEntity)); // query parameter
            
            
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            
            
            postBody = ApiClient.Serialize(filing); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InsertFilings: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Deletes a filing. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <returns>Object</returns>            
        public Object DeleteFiling (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteFiling");
            
    
            var path = "/api/filings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFiling: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFiling: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Deletes a filing. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteFilingAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteFiling");
            
    
            var path = "/api/filings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFiling: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve labels for the supplied components and report elements 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param> 
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param> 
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param> 
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <param name="labelRole">A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values).</param> 
        /// <param name="onlyTextBlocks">If set to true only labels for concepts defined as textBlockItemType are returned (default: false).</param> 
        /// <param name="kind">Filters by concept kind (default: no filtering)</param> 
        /// <param name="eliminateReportElementDuplicates">Whether to eliminate (concept name, language, label role) duplicates. By default no duplicate elimination</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListLabels (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string language = null, string labelRole = null, bool? onlyTextBlocks = null, string kind = null, bool? eliminateReportElementDuplicates = null, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListLabels");
            
    
            var path = "/api/labels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (labelRole != null) queryParams.Add("labelRole", ApiClient.ParameterToString(labelRole)); // query parameter
            if (onlyTextBlocks != null) queryParams.Add("onlyTextBlocks", ApiClient.ParameterToString(onlyTextBlocks)); // query parameter
            if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
            if (eliminateReportElementDuplicates != null) queryParams.Add("eliminateReportElementDuplicates", ApiClient.ParameterToString(eliminateReportElementDuplicates)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListLabels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve labels for the supplied components and report elements 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="labelRole">A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values).</param>
        /// <param name="onlyTextBlocks">If set to true only labels for concepts defined as textBlockItemType are returned (default: false).</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="eliminateReportElementDuplicates">Whether to eliminate (concept name, language, label role) duplicates. By default no duplicate elimination</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListLabelsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string language = null, string labelRole = null, bool? onlyTextBlocks = null, string kind = null, bool? eliminateReportElementDuplicates = null, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListLabels");
            
    
            var path = "/api/labels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (labelRole != null) queryParams.Add("labelRole", ApiClient.ParameterToString(labelRole)); // query parameter
            if (onlyTextBlocks != null) queryParams.Add("onlyTextBlocks", ApiClient.ParameterToString(onlyTextBlocks)); // query parameter
            if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
            if (eliminateReportElementDuplicates != null) queryParams.Add("eliminateReportElementDuplicates", ApiClient.ParameterToString(eliminateReportElementDuplicates)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListLabels: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Add or update labels. A label is identified with an Archive ID (AID),\na section URI, a report element, a language and a label role.\n\nA label can be created by submitting a JSON object containing general\ninformation about the label. This JSON object must be valid against a\nJSound schema. It can be either taken from the output of a GET request\nto the same endpoint (in which case it will be valid), or created\nmanually.\n\nFor convenience, we offer a user-friendly summary of the fields\ninvolved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field         | Type   | Presence | Content                          |\n|---------------|--------|----------|----------------------------------|\n| AID           | string | required | The AID of the archive to which the section belongs |\n| SectionURI    | string | required | The URI of the section           |\n| ReportElement | string | required | The name of a report element     |\n| Language      | string | required | A language code, e.g., en-US or de |\n| Role          | string | required | A label role                     |\n| Value         | string | required | The label itself                 |\n\nSeveral labels can be created at the same time by posting a sequence of\nnon-comma-separated JSON objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="label">The label objects (they must be valid).</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <returns>Object</returns>            
        public Object UpsertLabels (string token, Object label, string profileName = null, string formatIndent = no)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpsertLabels");
            
            // verify the required parameter 'label' is set
            if (label == null) throw new ApiException(400, "Missing required parameter 'label' when calling UpsertLabels");
            
    
            var path = "/api/labels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(label); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertLabels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Add or update labels. A label is identified with an Archive ID (AID),\na section URI, a report element, a language and a label role.\n\nA label can be created by submitting a JSON object containing general\ninformation about the label. This JSON object must be valid against a\nJSound schema. It can be either taken from the output of a GET request\nto the same endpoint (in which case it will be valid), or created\nmanually.\n\nFor convenience, we offer a user-friendly summary of the fields\ninvolved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field         | Type   | Presence | Content                          |\n|---------------|--------|----------|----------------------------------|\n| AID           | string | required | The AID of the archive to which the section belongs |\n| SectionURI    | string | required | The URI of the section           |\n| ReportElement | string | required | The name of a report element     |\n| Language      | string | required | A language code, e.g., en-US or de |\n| Role          | string | required | A label role                     |\n| Value         | string | required | The label itself                 |\n\nSeveral labels can be created at the same time by posting a sequence of\nnon-comma-separated JSON objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="label">The label objects (they must be valid).</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> UpsertLabelsAsync (string token, Object label, string profileName = null, string formatIndent = no)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpsertLabels");
            // verify the required parameter 'label' is set
            if (label == null) throw new ApiException(400, "Missing required parameter 'label' when calling UpsertLabels");
            
    
            var path = "/api/labels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(label); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertLabels: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Deletes a label. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <param name="labelRole">A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values).</param> 
        /// <returns>Object</returns>            
        public Object DeleteLabel (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null, List<string> reportElement = null, string language = null, string labelRole = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteLabel");
            
    
            var path = "/api/labels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (labelRole != null) queryParams.Add("labelRole", ApiClient.ParameterToString(labelRole)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLabel: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Deletes a label. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="labelRole">A label role (default: no filtering by label role). A more comprehensive list of label roles can be found in the [XBRL Standard](http://www.xbrl.org/Specification/XBRL-2.1/REC-2003-12-31/XBRL-2.1-REC-2003-12-31+corrected-errata-2013-02-20.html#Standard-label-role-attribute-values).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteLabelAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null, List<string> reportElement = null, string language = null, string labelRole = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteLabel");
            
    
            var path = "/api/labels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (labelRole != null) queryParams.Add("labelRole", ApiClient.ParameterToString(labelRole)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLabel: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the model structure for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param> 
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param> 
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param> 
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <param name="indent">If set to true all labels will be prepended with 8 space characters for each level of depth within the model structure (default: false).</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListModelStructure (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string language = null, bool? indent = false, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListModelStructure");
            
    
            var path = "/api/modelstructure-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (indent != null) queryParams.Add("indent", ApiClient.ParameterToString(indent)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListModelStructure: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListModelStructure: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the model structure for a given component. A component can be selected in several ways, for example with an accession number (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="indent">If set to true all labels will be prepended with 8 space characters for each level of depth within the model structure (default: false).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListModelStructureAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string language = null, bool? indent = false, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListModelStructure");
            
    
            var path = "/api/modelstructure-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (indent != null) queryParams.Add("indent", ApiClient.ParameterToString(indent)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListModelStructure: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Add or update components by providing their model structures. The components are identified with an AID, a section URI and the qualified name of a hypercube.\n\nA new component can be created by submitting a JSON object containing the model structure of the component. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the component belongs |\n| SectionURI   | string (URI) | optional | The URI of the section to which the component belongs |\n| HypercubeName  | string (QName lexical space) | required | The name of the hypercube that this component involves |\n| ModelStructure  | array of model structure node objects | required | The hierarchical model structure, as a tree of nodes that reference report elements (see below) |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:\n\n- Section (string)\n- Hypercube (string)\n\n#### Model structure node properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| Name | string | required | The qualified name of a report element that exists in the component&#39;s section |\n| Children   | array | optional | An array of model structure node objects that reference further children report elements |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:\n\n- Depth (integer)\n- Label (string)\n- BaseType (string)\n- Kind (string)\n- Order (integer)\n- DataType (string)\n- BaseDataType (string)\n- Balance (string)\n- Abstract (boolean)\n- PeriodType (string)\n\nThe hierarchy of the model structure must fulfill the constraints described in the documentation of model structures. We repeat it here for convenience:\n\n| Kind of report element |  Allowed children                           |\n|------------------------|---------------------------------------------|\n| Abstract               | Hypercube (if top-level), Abstract, Concept |\n| Hypercube              | Dimension, LineItems                        |\n| Dimension              | Member                                      |\n| Member                 | Member                                      |\n| LineItems              | Abstract, Concept                           |\n| Concept                | none                                        |\n\nThe model structure MUST involve the hypercube referred to in the top-level HypercubeName field, only this one, and only once, either top-level or below a top-level abstract. Its children are the dimensions with their members, as well as the line items hierarchy.\n\nThe only exception to the requirement of the hypercube report element is the special xbrl28:ImpliedTable hypercube. If HypercubeName is xbrl28:ImpliedTable, then the model structure can only involve Abstracts and Concepts, and has no dimensionality.\n\nSeveral components can be created at the same time by posting a sequence of non-comma-separated JSON model structure objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="modelStructure">The model structures, which must satisfy the constraints described in the properties table.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <returns>Object</returns>            
        public Object InsertComponentModelStructure (string token, Object modelStructure, string profileName = null, string formatIndent = no)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling InsertComponentModelStructure");
            
            // verify the required parameter 'modelStructure' is set
            if (modelStructure == null) throw new ApiException(400, "Missing required parameter 'modelStructure' when calling InsertComponentModelStructure");
            
    
            var path = "/api/modelstructure-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(modelStructure); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InsertComponentModelStructure: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InsertComponentModelStructure: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Add or update components by providing their model structures. The components are identified with an AID, a section URI and the qualified name of a hypercube.\n\nA new component can be created by submitting a JSON object containing the model structure of the component. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the component belongs |\n| SectionURI   | string (URI) | optional | The URI of the section to which the component belongs |\n| HypercubeName  | string (QName lexical space) | required | The name of the hypercube that this component involves |\n| ModelStructure  | array of model structure node objects | required | The hierarchical model structure, as a tree of nodes that reference report elements (see below) |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:\n\n- Section (string)\n- Hypercube (string)\n\n#### Model structure node properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| Name | string | required | The qualified name of a report element that exists in the component&#39;s section |\n| Children   | array | optional | An array of model structure node objects that reference further children report elements |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the modelstructure-for-component endpoint as input:\n\n- Depth (integer)\n- Label (string)\n- BaseType (string)\n- Kind (string)\n- Order (integer)\n- DataType (string)\n- BaseDataType (string)\n- Balance (string)\n- Abstract (boolean)\n- PeriodType (string)\n\nThe hierarchy of the model structure must fulfill the constraints described in the documentation of model structures. We repeat it here for convenience:\n\n| Kind of report element |  Allowed children                           |\n|------------------------|---------------------------------------------|\n| Abstract               | Hypercube (if top-level), Abstract, Concept |\n| Hypercube              | Dimension, LineItems                        |\n| Dimension              | Member                                      |\n| Member                 | Member                                      |\n| LineItems              | Abstract, Concept                           |\n| Concept                | none                                        |\n\nThe model structure MUST involve the hypercube referred to in the top-level HypercubeName field, only this one, and only once, either top-level or below a top-level abstract. Its children are the dimensions with their members, as well as the line items hierarchy.\n\nThe only exception to the requirement of the hypercube report element is the special xbrl28:ImpliedTable hypercube. If HypercubeName is xbrl28:ImpliedTable, then the model structure can only involve Abstracts and Concepts, and has no dimensionality.\n\nSeveral components can be created at the same time by posting a sequence of non-comma-separated JSON model structure objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="modelStructure">The model structures, which must satisfy the constraints described in the properties table.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> InsertComponentModelStructureAsync (string token, Object modelStructure, string profileName = null, string formatIndent = no)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling InsertComponentModelStructure");
            // verify the required parameter 'modelStructure' is set
            if (modelStructure == null) throw new ApiException(400, "Missing required parameter 'modelStructure' when calling InsertComponentModelStructure");
            
    
            var path = "/api/modelstructure-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(modelStructure); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InsertComponentModelStructure: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Deletes a component including its model structure. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param> 
        /// <returns>Object</returns>            
        public Object DeleteComponentModelStructure (string token, string aid = null, List<int?> section = null, List<string> hypercube = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteComponentModelStructure");
            
    
            var path = "/api/modelstructure-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteComponentModelStructure: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteComponentModelStructure: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Deletes a component including its model structure. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteComponentModelStructureAsync (string token, string aid = null, List<int?> section = null, List<string> hypercube = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteComponentModelStructure");
            
    
            var path = "/api/modelstructure-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteComponentModelStructure: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the periods of the filings filed by a particular entity 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListPeriods (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListPeriods");
            
    
            var path = "/api/periods";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPeriods: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPeriods: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the periods of the filings filed by a particular entity 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListPeriodsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListPeriods");
            
    
            var path = "/api/periods";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPeriods: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the report elements contained in a set of filings. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param> 
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param> 
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param> 
        /// <param name="onlyNames">Whether only the names of the report elements should be returned. If so, the values don&#39;t contain duplicates. (default: false)</param> 
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param> 
        /// <param name="label">A search term to search in the labels of report elements (e.g. stock)</param> 
        /// <param name="onlyTextBlocks">Filters by text block/not text block (default: no filtering)</param> 
        /// <param name="kind">Filters by concept kind (default: no filtering)</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <param name="contentType">Content-Type of the request</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListReportElements (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, bool? onlyNames = null, string report = null, string label = null, bool? onlyTextBlocks = null, string kind = null, string language = null, string contentType = null, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListReportElements");
            
    
            var path = "/api/report-elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (onlyNames != null) queryParams.Add("onlyNames", ApiClient.ParameterToString(onlyNames)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (onlyTextBlocks != null) queryParams.Add("onlyTextBlocks", ApiClient.ParameterToString(onlyTextBlocks)); // query parameter
            if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListReportElements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListReportElements: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the report elements contained in a set of filings. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="onlyNames">Whether only the names of the report elements should be returned. If so, the values don&#39;t contain duplicates. (default: false)</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="label">A search term to search in the labels of report elements (e.g. stock)</param>
        /// <param name="onlyTextBlocks">Filters by text block/not text block (default: no filtering)</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="contentType">Content-Type of the request</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListReportElementsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, bool? onlyNames = null, string report = null, string label = null, bool? onlyTextBlocks = null, string kind = null, string language = null, string contentType = null, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListReportElements");
            
    
            var path = "/api/report-elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (onlyNames != null) queryParams.Add("onlyNames", ApiClient.ParameterToString(onlyNames)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (onlyTextBlocks != null) queryParams.Add("onlyTextBlocks", ApiClient.ParameterToString(onlyTextBlocks)); // query parameter
            if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListReportElements: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Add or update report elements. The report elements are identified with an AID, a section URI and a qualified name.\n\nA new report element can be created by submitting a JSON object containing general information about the report element. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the report element belongs |\n| SectionURI   | string (URI) | required | The URI of the section to which the report element belongs |\n| Name  | string (QName lexical space) | required | The name of the report element (of the form foo:Bar) |\n| Kind  | One of: Concept, Abstract, LineItems, Hypercube, Dimension, Member | optional | One of the six kinds of report element |\n| PeriodType  | One of: instant, duration | optional | Only allowed for the Concept kind. Indicates the period type (whether facts against this concept must have instant or duration periods). |\n| DataType | string (QName lexical space) | optional | Only allowed for the Concept kind. Indicates the data type (value facts against this concept must have). |\n| Balance | One of: credit, debit | optional | Only allowed for the Concept kind, and if the data type is monetary. Indicates the balance. |\n| IsNillable | boolean | optional | Only allowed for the Concept kind. Specifies whether null is accepted as a fact value. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the report-elements endpoint as input:\n\n- Components (string)\n- IsAbstract (boolean)\n- BaseType (string)\n- ClosestSchemaBuiltinType (string)\n- IsTextBlock (boolean)\n- Labels (string)\n- Facts (string)\n- Labels (string)\n- Label (string)\n- Section (string)\n- CIK (string)\n- EntityRegistrantName (string)\n- FiscalYear (integer)\n- FiscalPeriod (string)\n\nFor report elements with the kind Concept, the data type must be one of the following:\n\n- xbrli:decimalItemType\n- xbrli:floatItemType\n- xbrli:doubleItemType\n- xbrli:integerItemType\n- xbrli:positiveIntegerItemType\n- xbrli:nonPositiveIntegerItemType\n- xbrli:nonNegativeIntegerItemType\n- xbrli:negativeIntegershortItemType\n- xbrli:byteItemType\n- xbrli:intItemType\n- xbrli:longItemType\n- xbrli:unsignedShorItemType\n- xbrli:unsignedByteItemType\n- xbrli:unsignedIntItemType\n- xbrli:unsignedLongItemType\n- xbrli:stringItemType (implied/only one allowed for Hypercube, Dimension, LineItems and Abstract kinds)\n- xbrli:booleanItemType\n- xbrli:hexBinaryItemType\n- xbrli:base64BinaryItemType\n- xbrli:anyURIItemType\n- xbrli:QNameItemType\n- xbrli:durationItemType\n- xbrli:timeItemType\n- xbrli:dateItemType\n- xbrli:gYearMonthItemType\n- xbrli:gYearItemType\n- xbrli:gMonthItemType\n- xbrli:gMonthDayItemType\n- xbrli:gDayItemType\n- xbrli:normalizedStringItemType\n- xbrli:tokenItemType\n- xbrli:languageItemType\n- xbrli:NameItemType\n- xbrli:NCNameItemType\n- xbrli:monetaryItemType (allows Balance)\n- xbrli:pureItemType\n- xbrli:sharesItemType\n- xbrli:fractionItemType\n- nonnum:domainItemType (implied/only one allowed for Member kind)\n- nonnum:escapedItemType\n- nonnum:xmlNodesItemType\n- nonnum:xmlItemType\n- nonnum:textBlockItemType\n- num:percentItemType\n- num:perShareItemType\n- num:areaItemType\n- num:volumeItemType\n- num:massItemType\n- num:weightItemType\n- num:energyItemType\n- num:powerItemType\n- num:lengthItemType\n- num:noDecimalsMonetaryItemType (allows Balance)\n- num:nonNegativeMonetaryItemType (allows Balance)\n- num:nonNegativeNoDecimalsMonetaryItemType (allows Balance)\n- num:enumerationItemType\n\nSeveral report elements can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="reportElement">The report element objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <returns>Object</returns>            
        public Object UpsertReportElements (string token, Object reportElement, string profileName = null, string formatIndent = no)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpsertReportElements");
            
            // verify the required parameter 'reportElement' is set
            if (reportElement == null) throw new ApiException(400, "Missing required parameter 'reportElement' when calling UpsertReportElements");
            
    
            var path = "/api/report-elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(reportElement); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertReportElements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertReportElements: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Add or update report elements. The report elements are identified with an AID, a section URI and a qualified name.\n\nA new report element can be created by submitting a JSON object containing general information about the report element. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the report element belongs |\n| SectionURI   | string (URI) | required | The URI of the section to which the report element belongs |\n| Name  | string (QName lexical space) | required | The name of the report element (of the form foo:Bar) |\n| Kind  | One of: Concept, Abstract, LineItems, Hypercube, Dimension, Member | optional | One of the six kinds of report element |\n| PeriodType  | One of: instant, duration | optional | Only allowed for the Concept kind. Indicates the period type (whether facts against this concept must have instant or duration periods). |\n| DataType | string (QName lexical space) | optional | Only allowed for the Concept kind. Indicates the data type (value facts against this concept must have). |\n| Balance | One of: credit, debit | optional | Only allowed for the Concept kind, and if the data type is monetary. Indicates the balance. |\n| IsNillable | boolean | optional | Only allowed for the Concept kind. Specifies whether null is accepted as a fact value. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the report-elements endpoint as input:\n\n- Components (string)\n- IsAbstract (boolean)\n- BaseType (string)\n- ClosestSchemaBuiltinType (string)\n- IsTextBlock (boolean)\n- Labels (string)\n- Facts (string)\n- Labels (string)\n- Label (string)\n- Section (string)\n- CIK (string)\n- EntityRegistrantName (string)\n- FiscalYear (integer)\n- FiscalPeriod (string)\n\nFor report elements with the kind Concept, the data type must be one of the following:\n\n- xbrli:decimalItemType\n- xbrli:floatItemType\n- xbrli:doubleItemType\n- xbrli:integerItemType\n- xbrli:positiveIntegerItemType\n- xbrli:nonPositiveIntegerItemType\n- xbrli:nonNegativeIntegerItemType\n- xbrli:negativeIntegershortItemType\n- xbrli:byteItemType\n- xbrli:intItemType\n- xbrli:longItemType\n- xbrli:unsignedShorItemType\n- xbrli:unsignedByteItemType\n- xbrli:unsignedIntItemType\n- xbrli:unsignedLongItemType\n- xbrli:stringItemType (implied/only one allowed for Hypercube, Dimension, LineItems and Abstract kinds)\n- xbrli:booleanItemType\n- xbrli:hexBinaryItemType\n- xbrli:base64BinaryItemType\n- xbrli:anyURIItemType\n- xbrli:QNameItemType\n- xbrli:durationItemType\n- xbrli:timeItemType\n- xbrli:dateItemType\n- xbrli:gYearMonthItemType\n- xbrli:gYearItemType\n- xbrli:gMonthItemType\n- xbrli:gMonthDayItemType\n- xbrli:gDayItemType\n- xbrli:normalizedStringItemType\n- xbrli:tokenItemType\n- xbrli:languageItemType\n- xbrli:NameItemType\n- xbrli:NCNameItemType\n- xbrli:monetaryItemType (allows Balance)\n- xbrli:pureItemType\n- xbrli:sharesItemType\n- xbrli:fractionItemType\n- nonnum:domainItemType (implied/only one allowed for Member kind)\n- nonnum:escapedItemType\n- nonnum:xmlNodesItemType\n- nonnum:xmlItemType\n- nonnum:textBlockItemType\n- num:percentItemType\n- num:perShareItemType\n- num:areaItemType\n- num:volumeItemType\n- num:massItemType\n- num:weightItemType\n- num:energyItemType\n- num:powerItemType\n- num:lengthItemType\n- num:noDecimalsMonetaryItemType (allows Balance)\n- num:nonNegativeMonetaryItemType (allows Balance)\n- num:nonNegativeNoDecimalsMonetaryItemType (allows Balance)\n- num:enumerationItemType\n\nSeveral report elements can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="reportElement">The report element objects, which must be supplied in the body of the request, and which must satisfy the constraints described in the field table.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> UpsertReportElementsAsync (string token, Object reportElement, string profileName = null, string formatIndent = no)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpsertReportElements");
            // verify the required parameter 'reportElement' is set
            if (reportElement == null) throw new ApiException(400, "Missing required parameter 'reportElement' when calling UpsertReportElements");
            
    
            var path = "/api/report-elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(reportElement); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertReportElements: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Deletes a report element. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param> 
        /// <returns>Object</returns>            
        public Object DeleteReportElement (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null, List<string> reportElement = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteReportElement");
            
    
            var path = "/api/report-elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteReportElement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteReportElement: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Deletes a report element. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteReportElementAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null, List<string> reportElement = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteReportElement");
            
    
            var path = "/api/report-elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteReportElement: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve a summary for all rules of a given section 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param> 
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param> 
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListRules (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListRules");
            
    
            var path = "/api/rules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListRules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListRules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a summary for all rules of a given section 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListRulesAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListRules");
            
    
            var path = "/api/rules";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListRules: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve a summary for all sections of a given filing 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param> 
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param> 
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param> 
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param> 
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <param name="count">If true, only outputs statistics (default: false).</param> 
        /// <param name="top">Output only the first [top] results (default: no limit).</param> 
        /// <param name="skip">Skip the first [skip] results.</param> 
        /// <returns>Object</returns>            
        public Object ListSections (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? validate = false, string language = null, bool? count = false, int? top = null, int? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListSections");
            
    
            var path = "/api/sections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSections: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSections: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a summary for all sections of a given filing 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="count">If true, only outputs statistics (default: false).</param>
        /// <param name="top">Output only the first [top] results (default: no limit).</param>
        /// <param name="skip">Skip the first [skip] results.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListSectionsAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, List<string> filingKind = null, List<int?> section = null, List<string> hypercube = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, bool? validate = false, string language = null, bool? count = false, int? top = null, int? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListSections");
            
    
            var path = "/api/sections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSections: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Add or update sections. A section is identified with an Archive ID (AID) and a section URI.\n\nA section can be created by submitting a JSON object containing general information about the section. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the section belongs |\n| SectionURI   | string | required | The URI of the section |\n| Section  | string | required | A user-friendly label for the section (preferably in English). |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the sections endpoint as input:\n\n- Components (string)\n- ReportElements (string)\n- FactTable (string)\n- Spreadsheet (string)\n- Category (string)\n- SubCategory (string)\n- Disclosure (string)\n- NumRules (integer)\n- NumReportElements (integer)\n- NumHypercubes (integer)\n- NumDimensions (integer)\n- NumMembers (integer)\n- NumLineItems (integer)\n- NumAbstracts (integer)\n- NumConcepts (integer)\n- EntityRegistrantName (string)\n- CIK (string)\n- FiscalYear (integer)\n- FiscalPeriod (string)\n- AcceptanceDatetime (string)\n- FormType (string)\n\nSeveral empty sections can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="section">The section objects (they must be valid).</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <returns>Object</returns>            
        public Object UpsertSections (string token, Object section, string profileName = null, string formatIndent = no)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpsertSections");
            
            // verify the required parameter 'section' is set
            if (section == null) throw new ApiException(400, "Missing required parameter 'section' when calling UpsertSections");
            
    
            var path = "/api/sections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(section); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertSections: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertSections: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Add or update sections. A section is identified with an Archive ID (AID) and a section URI.\n\nA section can be created by submitting a JSON object containing general information about the section. This JSON object must be valid agains a JSound schema. It can be either taken from the output of a GET request to the same endpoint (in which case it will be valid), or created manually.\n\nFor convenience, we offer a user-friendly summary of the fields involved. The JSound schema is available on request.\n\n#### Body properties\n\n| Field | Type | Presence | Content |\n|-------|------|----------|---------|\n| AID | string | required | The AID of the archive to which the section belongs |\n| SectionURI   | string | required | The URI of the section |\n| Section  | string | required | A user-friendly label for the section (preferably in English). |\n| Profiles | object | optional | Maps profile names to additional profile-specific information. The profile-specific information must have a Name field containing the profile name, that is, identical to its key. The other fields in the profile information is not restricted. |\n\nAdditionally, the following fields are allowed for the purpose of feeding back the output of the sections endpoint as input:\n\n- Components (string)\n- ReportElements (string)\n- FactTable (string)\n- Spreadsheet (string)\n- Category (string)\n- SubCategory (string)\n- Disclosure (string)\n- NumRules (integer)\n- NumReportElements (integer)\n- NumHypercubes (integer)\n- NumDimensions (integer)\n- NumMembers (integer)\n- NumLineItems (integer)\n- NumAbstracts (integer)\n- NumConcepts (integer)\n- EntityRegistrantName (string)\n- CIK (string)\n- FiscalYear (integer)\n- FiscalPeriod (string)\n- AcceptanceDatetime (string)\n- FormType (string)\n\nSeveral empty sections can be created at the same time by posting a sequence of non-comma-separated JSON objects as above. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="section">The section objects (they must be valid).</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> UpsertSectionsAsync (string token, Object section, string profileName = null, string formatIndent = no)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpsertSections");
            // verify the required parameter 'section' is set
            if (section == null) throw new ApiException(400, "Missing required parameter 'section' when calling UpsertSections");
            
    
            var path = "/api/sections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(section); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertSections: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Deletes a section. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <returns>Object</returns>            
        public Object DeleteSection (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteSection");
            
    
            var path = "/api/sections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Deletes a section. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteSectionAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<int?> section = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteSection");
            
    
            var path = "/api/sections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSection: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a given component.\n\nA component can be selected in several ways, for example with an Archive ID (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param> 
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param> 
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param> 
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param> 
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param> 
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param> 
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param> 
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param> 
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param> 
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param> 
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param> 
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param> 
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param> 
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param> 
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param> 
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param> 
        /// <param name="merge">Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true).</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param> 
        /// <param name="eliminate">Whether to eliminate empty rows / columns (Default: true if no row / column parameter is used).</param> 
        /// <param name="eliminationThreshold">When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0).</param> 
        /// <param name="autoSlice">If set to true then slicers are automatically defined (default: true).</param> 
        /// <param name="row">Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination.</param> 
        /// <param name="column">Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination.</param> 
        /// <param name="flattenRowHeaders">Whether to flatten row headers to single columns (Default: true).</param> 
        /// <returns>Object</returns>            
        public Object SpreadsheetForComponent (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<int?> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, string additionalRules = null, string auditTrails = no, bool? open = null, List<string> filingKind = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string aggregationFunction = null, bool? validate = false, bool? merge = true, string language = null, bool? _override = null, bool? eliminate = null, int? eliminationThreshold = 0, bool? autoSlice = true, List<int?> row = null, List<int?> column = null, bool? flattenRowHeaders = true)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling SpreadsheetForComponent");
            
    
            var path = "/api/spreadsheet-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (auditTrails != null) queryParams.Add("audit-trails", ApiClient.ParameterToString(auditTrails)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (aggregationFunction != null) queryParams.Add("aggregation-function", ApiClient.ParameterToString(aggregationFunction)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (merge != null) queryParams.Add("merge", ApiClient.ParameterToString(merge)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (_override != null) queryParams.Add("override", ApiClient.ParameterToString(_override)); // query parameter
            if (eliminate != null) queryParams.Add("eliminate", ApiClient.ParameterToString(eliminate)); // query parameter
            if (eliminationThreshold != null) queryParams.Add("elimination-threshold", ApiClient.ParameterToString(eliminationThreshold)); // query parameter
            if (autoSlice != null) queryParams.Add("auto-slice", ApiClient.ParameterToString(autoSlice)); // query parameter
            if (row != null) queryParams.Add("row", ApiClient.ParameterToString(row)); // query parameter
            if (column != null) queryParams.Add("column", ApiClient.ParameterToString(column)); // query parameter
            if (flattenRowHeaders != null) queryParams.Add("flatten-row-headers", ApiClient.ParameterToString(flattenRowHeaders)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SpreadsheetForComponent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SpreadsheetForComponent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a given component.\n\nA component can be selected in several ways, for example with an Archive ID (AID), section URI and hypercube name, or with a CIK, fiscal year, fiscal period, and disclosure, etc. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="section">The URI of a particular section, to retrieve a section, component or report element.</param>
        /// <param name="hypercube">The name of a hypercube report element, to retrieve components / sections.</param>
        /// <param name="concept">The name of a concept to dice facts (a synonym for the dimension xbrl:Concept).</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="archiveFiscalYear">The fiscal year focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="archiveFiscalPeriod">The fiscal period focus of the filing, to retrieve filings, sections, components or slice facts (default: ALL).</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts).</param>
        /// <param name="auditTrails">Whether audit trails should be included in each fact (default: no).</param>
        /// <param name="open">Whether the hypercube query has open hypercube semantics, i.e., automatically stretches to accommodate for all found dimensions (default: false).</param>
        /// <param name="filingKind">The kind of the filing, to retrieve filings, sections, components or slice facts (default: no filtering).</param>
        /// <param name="disclosure">A disclosure, to identify sections or components (e.g. BalanceSheet).</param>
        /// <param name="reportElement">The name of the report element to search for, to retrieve a section, a component or a report element (e.g. us-gaap:Goodwill).</param>
        /// <param name="label">A search term to search in the labels of components, to retrieve components (e.g. stock).</param>
        /// <param name="aggregationFunction">Specify an aggregation function to aggregate facts. Will aggregate facts, grouped by dicers, but aggregated along slicers, with this function.</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="merge">Whether to merge components if multiple components are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved (default: true).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="_override">Whether the static component or report hypercube should be tampered with using the same hypercube-building API as the facts endpoint (default: automatically detected).</param>
        /// <param name="eliminate">Whether to eliminate empty rows / columns (Default: true if no row / column parameter is used).</param>
        /// <param name="eliminationThreshold">When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0).</param>
        /// <param name="autoSlice">If set to true then slicers are automatically defined (default: true).</param>
        /// <param name="row">Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination.</param>
        /// <param name="column">Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination.</param>
        /// <param name="flattenRowHeaders">Whether to flatten row headers to single columns (Default: true).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> SpreadsheetForComponentAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<int?> section = null, List<string> hypercube = null, List<string> concept = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string archiveFiscalYear = ALL, List<string> archiveFiscalPeriod = ALL, string additionalRules = null, string auditTrails = no, bool? open = null, List<string> filingKind = null, List<string> disclosure = null, List<string> reportElement = null, string label = null, string aggregationFunction = null, bool? validate = false, bool? merge = true, string language = null, bool? _override = null, bool? eliminate = null, int? eliminationThreshold = 0, bool? autoSlice = true, List<int?> row = null, List<int?> column = null, bool? flattenRowHeaders = true)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling SpreadsheetForComponent");
            
    
            var path = "/api/spreadsheet-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (archiveFiscalYear != null) queryParams.Add("archiveFiscalYear", ApiClient.ParameterToString(archiveFiscalYear)); // query parameter
            if (archiveFiscalPeriod != null) queryParams.Add("archiveFiscalPeriod", ApiClient.ParameterToString(archiveFiscalPeriod)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (auditTrails != null) queryParams.Add("audit-trails", ApiClient.ParameterToString(auditTrails)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (aggregationFunction != null) queryParams.Add("aggregation-function", ApiClient.ParameterToString(aggregationFunction)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (merge != null) queryParams.Add("merge", ApiClient.ParameterToString(merge)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (_override != null) queryParams.Add("override", ApiClient.ParameterToString(_override)); // query parameter
            if (eliminate != null) queryParams.Add("eliminate", ApiClient.ParameterToString(eliminate)); // query parameter
            if (eliminationThreshold != null) queryParams.Add("elimination-threshold", ApiClient.ParameterToString(eliminationThreshold)); // query parameter
            if (autoSlice != null) queryParams.Add("auto-slice", ApiClient.ParameterToString(autoSlice)); // query parameter
            if (row != null) queryParams.Add("row", ApiClient.ParameterToString(row)); // query parameter
            if (column != null) queryParams.Add("column", ApiClient.ParameterToString(column)); // query parameter
            if (flattenRowHeaders != null) queryParams.Add("flatten-row-headers", ApiClient.ParameterToString(flattenRowHeaders)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SpreadsheetForComponent: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a report.\n\nFilters can be overriden. Filters MUST be overriden if the report is not already filtering. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param> 
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param> 
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param> 
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param> 
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param> 
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param> 
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param> 
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param> 
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param> 
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param> 
        /// <param name="language">A language code (default: en-US) for displaying labels.</param> 
        /// <param name="eliminate">Whether to eliminate empty rows / columns (Default: true if no row / column parameter is used).</param> 
        /// <param name="eliminationThreshold">When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0).</param> 
        /// <param name="row">Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination.</param> 
        /// <param name="column">Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination.</param> 
        /// <param name="flattenRowHeaders">Whether to flatten row headers to single columns (Default: true).</param> 
        /// <returns>Object</returns>            
        public Object ListSpreadsheetForReport (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string report = null, bool? validate = false, string language = null, bool? eliminate = null, int? eliminationThreshold = 0, List<int?> row = null, List<int?> column = null, bool? flattenRowHeaders = true)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListSpreadsheetForReport");
            
    
            var path = "/api/spreadsheet-for-report";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (eliminate != null) queryParams.Add("eliminate", ApiClient.ParameterToString(eliminate)); // query parameter
            if (eliminationThreshold != null) queryParams.Add("elimination-threshold", ApiClient.ParameterToString(eliminationThreshold)); // query parameter
            if (row != null) queryParams.Add("row", ApiClient.ParameterToString(row)); // query parameter
            if (column != null) queryParams.Add("column", ApiClient.ParameterToString(column)); // query parameter
            if (flattenRowHeaders != null) queryParams.Add("flatten-row-headers", ApiClient.ParameterToString(flattenRowHeaders)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSpreadsheetForReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSpreadsheetForReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a report.\n\nFilters can be overriden. Filters MUST be overriden if the report is not already filtering. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API. Gives you read (GET) and/or write (POST, DELETE, PATCH) credentials.</param>
        /// <param name="profileName">Specifies which profile to use, which will enable some parameters or modify hypercube queries accordingly. The default depends on the underlying repository</param>
        /// <param name="formatIndent">Whether or not to indent JSON or XML output (default: no indent).</param>
        /// <param name="aid">Archive IDs, to retrieve filings, sections, components or slice facts.</param>
        /// <param name="eid">The EID (scheme + local name) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="cik">The CIK of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="ticker">The ticker of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="edinetcode">The EDINET code of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="tag">The tag of an entity (such as an index), to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="sic">The SIC (industry group) of a company, to retrieve entities, filings, sections, components or dice facts.</param>
        /// <param name="fiscalYear">A fiscal year to slice facts (a synonym for the dimension xbrl28:FiscalYear, default: no filtering).</param>
        /// <param name="fiscalPeriod">A fiscal period to slice facts (a synonym for the dimension xbrl28:FiscalPeriod, default: no filtering).</param>
        /// <param name="fiscalPeriodType">A fiscal period type to slice facts (a synonym for the dimension xbrl28:FiscalPeriodType, default: no filtering).</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none).</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false).</param>
        /// <param name="language">A language code (default: en-US) for displaying labels.</param>
        /// <param name="eliminate">Whether to eliminate empty rows / columns (Default: true if no row / column parameter is used).</param>
        /// <param name="eliminationThreshold">When you eliminate, you can specify a threshold of elimination between 0 and 100. If the threshold is set to 0 (which is the default), only fully empty rows and columns are eliminated. With 100, everything is eliminated. With a value inbetween, say, 50, the rows and columns with less than 50% of filled cells are eliminated (Default: 0).</param>
        /// <param name="row">Filters the spreadsheet to display only the rows specified (default: no filter). Deactivates elimination.</param>
        /// <param name="column">Filters the spreadsheet to display only the columns specified (default: no filter). Deactivates elimination.</param>
        /// <param name="flattenRowHeaders">Whether to flatten row headers to single columns (Default: true).</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListSpreadsheetForReportAsync (string token, string profileName = null, string formatIndent = no, string aid = null, List<string> eid = null, List<string> cik = null, List<string> ticker = null, List<int?> edinetcode = null, List<string> tag = null, List<string> sic = null, List<string> fiscalYear = null, List<string> fiscalPeriod = null, List<string> fiscalPeriodType = null, string report = null, bool? validate = false, string language = null, bool? eliminate = null, int? eliminationThreshold = 0, List<int?> row = null, List<int?> column = null, bool? flattenRowHeaders = true)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListSpreadsheetForReport");
            
    
            var path = "/api/spreadsheet-for-report";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (formatIndent != null) queryParams.Add("format-indent", ApiClient.ParameterToString(formatIndent)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (eliminate != null) queryParams.Add("eliminate", ApiClient.ParameterToString(eliminate)); // query parameter
            if (eliminationThreshold != null) queryParams.Add("elimination-threshold", ApiClient.ParameterToString(eliminationThreshold)); // query parameter
            if (row != null) queryParams.Add("row", ApiClient.ParameterToString(row)); // query parameter
            if (column != null) queryParams.Add("column", ApiClient.ParameterToString(column)); // query parameter
            if (flattenRowHeaders != null) queryParams.Add("flatten-row-headers", ApiClient.ParameterToString(flattenRowHeaders)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSpreadsheetForReport: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
    }
    
}
