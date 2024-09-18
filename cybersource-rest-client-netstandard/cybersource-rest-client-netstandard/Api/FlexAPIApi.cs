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
    public interface IFlexAPIApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Establish a Payment Session with a Capture Context
        /// </summary>
        /// <remarks>
        /// To establish a payment session, include the API fields you plan to use in that session in the body of the request.  The system then returns a JSON Web Token (JWT) that includes the capture context.   To determine which fields to include in your capture context, identify the personal information that you wish to isolate from the payment session.  **Capture Context Fields**&lt;br&gt; When making a session request, any fields that you request to be added to the capture context are required by default.  However, you can choose to make a field optional by setting the required parameter to false. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFlexAPICaptureContextRequest"></param>
        /// <returns>string</returns>
        string GenerateFlexAPICaptureContext (GenerateFlexAPICaptureContextRequest generateFlexAPICaptureContextRequest);

        /// <summary>
        /// Establish a Payment Session with a Capture Context
        /// </summary>
        /// <remarks>
        /// To establish a payment session, include the API fields you plan to use in that session in the body of the request.  The system then returns a JSON Web Token (JWT) that includes the capture context.   To determine which fields to include in your capture context, identify the personal information that you wish to isolate from the payment session.  **Capture Context Fields**&lt;br&gt; When making a session request, any fields that you request to be added to the capture context are required by default.  However, you can choose to make a field optional by setting the required parameter to false. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFlexAPICaptureContextRequest"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GenerateFlexAPICaptureContextWithHttpInfo (GenerateFlexAPICaptureContextRequest generateFlexAPICaptureContextRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Establish a Payment Session with a Capture Context
        /// </summary>
        /// <remarks>
        /// To establish a payment session, include the API fields you plan to use in that session in the body of the request.  The system then returns a JSON Web Token (JWT) that includes the capture context.   To determine which fields to include in your capture context, identify the personal information that you wish to isolate from the payment session.  **Capture Context Fields**&lt;br&gt; When making a session request, any fields that you request to be added to the capture context are required by default.  However, you can choose to make a field optional by setting the required parameter to false. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFlexAPICaptureContextRequest"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GenerateFlexAPICaptureContextAsync (GenerateFlexAPICaptureContextRequest generateFlexAPICaptureContextRequest);

        /// <summary>
        /// Establish a Payment Session with a Capture Context
        /// </summary>
        /// <remarks>
        /// To establish a payment session, include the API fields you plan to use in that session in the body of the request.  The system then returns a JSON Web Token (JWT) that includes the capture context.   To determine which fields to include in your capture context, identify the personal information that you wish to isolate from the payment session.  **Capture Context Fields**&lt;br&gt; When making a session request, any fields that you request to be added to the capture context are required by default.  However, you can choose to make a field optional by setting the required parameter to false. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFlexAPICaptureContextRequest"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GenerateFlexAPICaptureContextAsyncWithHttpInfo (GenerateFlexAPICaptureContextRequest generateFlexAPICaptureContextRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FlexAPIApi : IFlexAPIApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlexAPIApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FlexAPIApi(string basePath)
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
        /// Initializes a new instance of the <see cref="FlexAPIApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FlexAPIApi(Configuration configuration = null)
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
        /// Establish a Payment Session with a Capture Context To establish a payment session, include the API fields you plan to use in that session in the body of the request.  The system then returns a JSON Web Token (JWT) that includes the capture context.   To determine which fields to include in your capture context, identify the personal information that you wish to isolate from the payment session.  **Capture Context Fields**&lt;br&gt; When making a session request, any fields that you request to be added to the capture context are required by default.  However, you can choose to make a field optional by setting the required parameter to false. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFlexAPICaptureContextRequest"></param>
        /// <returns>string</returns>
        public string GenerateFlexAPICaptureContext (GenerateFlexAPICaptureContextRequest generateFlexAPICaptureContextRequest)
        {
            logger.Debug("CALLING API \"GenerateFlexAPICaptureContext\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<string> localVarResponse = GenerateFlexAPICaptureContextWithHttpInfo(generateFlexAPICaptureContextRequest);
            logger.Debug("CALLING API \"GenerateFlexAPICaptureContext\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Establish a Payment Session with a Capture Context To establish a payment session, include the API fields you plan to use in that session in the body of the request.  The system then returns a JSON Web Token (JWT) that includes the capture context.   To determine which fields to include in your capture context, identify the personal information that you wish to isolate from the payment session.  **Capture Context Fields**&lt;br&gt; When making a session request, any fields that you request to be added to the capture context are required by default.  However, you can choose to make a field optional by setting the required parameter to false. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFlexAPICaptureContextRequest"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > GenerateFlexAPICaptureContextWithHttpInfo (GenerateFlexAPICaptureContextRequest generateFlexAPICaptureContextRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'generateFlexAPICaptureContextRequest' is set
            if (generateFlexAPICaptureContextRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'generateFlexAPICaptureContextRequest' when calling FlexAPIApi->GenerateFlexAPICaptureContext");
                throw new ApiException(400, "Missing required parameter 'generateFlexAPICaptureContextRequest' when calling FlexAPIApi->GenerateFlexAPICaptureContext");
            }

            var localVarPath = $"/flex/v2/sessions";
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
                "application/jwt"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (generateFlexAPICaptureContextRequest != null && generateFlexAPICaptureContextRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                generateFlexAPICaptureContextRequest = (GenerateFlexAPICaptureContextRequest)sdkTracker.InsertDeveloperIdTracker(generateFlexAPICaptureContextRequest, generateFlexAPICaptureContextRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(generateFlexAPICaptureContextRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateFlexAPICaptureContextRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GenerateFlexAPICaptureContext", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.GroupBy(h => h.Name).ToDictionary(x => x.Key, x => string.Join(", ", x.Select(h => h.Value.ToString()))),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string))); // Return statement
        }

        /// <summary>
        /// Establish a Payment Session with a Capture Context To establish a payment session, include the API fields you plan to use in that session in the body of the request.  The system then returns a JSON Web Token (JWT) that includes the capture context.   To determine which fields to include in your capture context, identify the personal information that you wish to isolate from the payment session.  **Capture Context Fields**&lt;br&gt; When making a session request, any fields that you request to be added to the capture context are required by default.  However, you can choose to make a field optional by setting the required parameter to false. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFlexAPICaptureContextRequest"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GenerateFlexAPICaptureContextAsync (GenerateFlexAPICaptureContextRequest generateFlexAPICaptureContextRequest)
        {
            logger.Debug("CALLING API \"GenerateFlexAPICaptureContextAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<string> localVarResponse = await GenerateFlexAPICaptureContextAsyncWithHttpInfo(generateFlexAPICaptureContextRequest);
            logger.Debug("CALLING API \"GenerateFlexAPICaptureContextAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Establish a Payment Session with a Capture Context To establish a payment session, include the API fields you plan to use in that session in the body of the request.  The system then returns a JSON Web Token (JWT) that includes the capture context.   To determine which fields to include in your capture context, identify the personal information that you wish to isolate from the payment session.  **Capture Context Fields**&lt;br&gt; When making a session request, any fields that you request to be added to the capture context are required by default.  However, you can choose to make a field optional by setting the required parameter to false. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateFlexAPICaptureContextRequest"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> GenerateFlexAPICaptureContextAsyncWithHttpInfo (GenerateFlexAPICaptureContextRequest generateFlexAPICaptureContextRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'generateFlexAPICaptureContextRequest' is set
            if (generateFlexAPICaptureContextRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'generateFlexAPICaptureContextRequest' when calling FlexAPIApi->GenerateFlexAPICaptureContext");
                throw new ApiException(400, "Missing required parameter 'generateFlexAPICaptureContextRequest' when calling FlexAPIApi->GenerateFlexAPICaptureContext");
            }

            var localVarPath = $"/flex/v2/sessions";
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
                "application/jwt"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (generateFlexAPICaptureContextRequest != null && generateFlexAPICaptureContextRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                generateFlexAPICaptureContextRequest = (GenerateFlexAPICaptureContextRequest)sdkTracker.InsertDeveloperIdTracker(generateFlexAPICaptureContextRequest, generateFlexAPICaptureContextRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(generateFlexAPICaptureContextRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generateFlexAPICaptureContextRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GenerateFlexAPICaptureContext", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.GroupBy(h => h.Name).ToDictionary(x => x.Key, x => string.Join(", ", x.Select(h => h.Value.ToString()))),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string))); // Return statement
        }
    }
}
