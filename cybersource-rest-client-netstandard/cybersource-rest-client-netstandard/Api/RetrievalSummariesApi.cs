/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;
using NLog;
using AuthenticationSdk.util;
using CyberSource.Utilities.Tracking;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRetrievalSummariesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Retrieval Summaries
        /// </summary>
        /// <remarks>
        /// Retrieval Summary Report Description
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>ReportingV3RetrievalSummariesGet200Response</returns>
        ReportingV3RetrievalSummariesGet200Response GetRetrievalSummary (DateTime? startTime, DateTime? endTime, string organizationId = null);

        /// <summary>
        /// Get Retrieval Summaries
        /// </summary>
        /// <remarks>
        /// Retrieval Summary Report Description
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3RetrievalSummariesGet200Response</returns>
        ApiResponse<ReportingV3RetrievalSummariesGet200Response> GetRetrievalSummaryWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Retrieval Summaries
        /// </summary>
        /// <remarks>
        /// Retrieval Summary Report Description
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of ReportingV3RetrievalSummariesGet200Response</returns>
        System.Threading.Tasks.Task<ReportingV3RetrievalSummariesGet200Response> GetRetrievalSummaryAsync (DateTime? startTime, DateTime? endTime, string organizationId = null);

        /// <summary>
        /// Get Retrieval Summaries
        /// </summary>
        /// <remarks>
        /// Retrieval Summary Report Description
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3RetrievalSummariesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportingV3RetrievalSummariesGet200Response>> GetRetrievalSummaryAsyncWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RetrievalSummariesApi : IRetrievalSummariesApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalSummariesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RetrievalSummariesApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrievalSummariesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RetrievalSummariesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieves the status code being set for the most recently executed API request.
        /// </summary>
        /// <returns>Status Code of previous request</returns>
        public int GetStatusCode()
        {
            return this._statusCode == null ? 0 : (int) this._statusCode;
        }

        /// <summary>
        /// Sets the value of status code for the most recently executed API request, in order to be retrieved later.
        /// </summary>
        /// <param name="statusCode">Status Code to be set</param>
        /// <returns></returns>
        public void SetStatusCode(int? statusCode)
        {
            this._statusCode = statusCode;
        }

        /// <summary>
        /// Get Retrieval Summaries Retrieval Summary Report Description
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>ReportingV3RetrievalSummariesGet200Response</returns>
        public ReportingV3RetrievalSummariesGet200Response GetRetrievalSummary (DateTime? startTime, DateTime? endTime, string organizationId = null)
        {
            logger.Debug("CALLING API \"GetRetrievalSummary\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<ReportingV3RetrievalSummariesGet200Response> localVarResponse = GetRetrievalSummaryWithHttpInfo(startTime, endTime, organizationId);
            logger.Debug("CALLING API \"GetRetrievalSummary\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Retrieval Summaries Retrieval Summary Report Description
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>ApiResponse of ReportingV3RetrievalSummariesGet200Response</returns>
        public ApiResponse< ReportingV3RetrievalSummariesGet200Response > GetRetrievalSummaryWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'startTime' is set
            if (startTime == null)
            {
                logger.Error("ApiException : Missing required parameter 'startTime' when calling RetrievalSummariesApi->GetRetrievalSummary");
                throw new ApiException(400, "Missing required parameter 'startTime' when calling RetrievalSummariesApi->GetRetrievalSummary");
            }
            // verify the required parameter 'endTime' is set
            if (endTime == null)
            {
                logger.Error("ApiException : Missing required parameter 'endTime' when calling RetrievalSummariesApi->GetRetrievalSummary");
                throw new ApiException(400, "Missing required parameter 'endTime' when calling RetrievalSummariesApi->GetRetrievalSummary");
            }

            var localVarPath = $"/reporting/v3/retrieval-summaries";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json",
                "application/xml"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (startTime != null)
            {
                localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            }
            if (endTime != null)
            {
                localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            }
            if (organizationId != null)
            {
                localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            if (Method.Get == Method.Post)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRetrievalSummary", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<ReportingV3RetrievalSummariesGet200Response>(localVarStatusCode,
                localVarResponse.Headers.GroupBy(h => h.Name).ToDictionary(x => x.Key, x => string.Join(", ", x.Select(h => h.Value.ToString()))),
                (ReportingV3RetrievalSummariesGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportingV3RetrievalSummariesGet200Response))); // Return statement
        }

        /// <summary>
        /// Get Retrieval Summaries Retrieval Summary Report Description
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of ReportingV3RetrievalSummariesGet200Response</returns>
        public async System.Threading.Tasks.Task<ReportingV3RetrievalSummariesGet200Response> GetRetrievalSummaryAsync (DateTime? startTime, DateTime? endTime, string organizationId = null)
        {
            logger.Debug("CALLING API \"GetRetrievalSummaryAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<ReportingV3RetrievalSummariesGet200Response> localVarResponse = await GetRetrievalSummaryAsyncWithHttpInfo(startTime, endTime, organizationId);
            logger.Debug("CALLING API \"GetRetrievalSummaryAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Get Retrieval Summaries Retrieval Summary Report Description
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3RetrievalSummariesGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportingV3RetrievalSummariesGet200Response>> GetRetrievalSummaryAsyncWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'startTime' is set
            if (startTime == null)
            {
                logger.Error("ApiException : Missing required parameter 'startTime' when calling RetrievalSummariesApi->GetRetrievalSummary");
                throw new ApiException(400, "Missing required parameter 'startTime' when calling RetrievalSummariesApi->GetRetrievalSummary");
            }
            // verify the required parameter 'endTime' is set
            if (endTime == null)
            {
                logger.Error("ApiException : Missing required parameter 'endTime' when calling RetrievalSummariesApi->GetRetrievalSummary");
                throw new ApiException(400, "Missing required parameter 'endTime' when calling RetrievalSummariesApi->GetRetrievalSummary");
            }

            var localVarPath = $"/reporting/v3/retrieval-summaries";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json",
                "application/xml"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (startTime != null)
            {
                localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            }
            if (endTime != null)
            {
                localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            }
            if (organizationId != null)
            {
                localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            if (Method.Get == Method.Post)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRetrievalSummary", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<ReportingV3RetrievalSummariesGet200Response>(localVarStatusCode,
                localVarResponse.Headers.GroupBy(h => h.Name).ToDictionary(x => x.Key, x => string.Join(", ", x.Select(h => h.Value.ToString()))),
                (ReportingV3RetrievalSummariesGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReportingV3RetrievalSummariesGet200Response))); // Return statement
        }
    }
}
