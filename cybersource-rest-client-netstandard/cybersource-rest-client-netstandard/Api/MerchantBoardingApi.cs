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
    public interface IMerchantBoardingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets all the information on a boarding registration
        /// </summary>
        /// <remarks>
        /// This end point will get all information of a boarding registration 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationId">Identifies the boarding registration to be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetRegistration (string registrationId);

        /// <summary>
        /// Gets all the information on a boarding registration
        /// </summary>
        /// <remarks>
        /// This end point will get all information of a boarding registration 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationId">Identifies the boarding registration to be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> GetRegistrationWithHttpInfo (string registrationId);
        /// <summary>
        /// Create a boarding registration
        /// </summary>
        /// <remarks>
        /// Create a registration to board merchant  If you have  Card Processing product enabled in your boarding request, select payment processor from Configuration -&gt; Sample Request. You may unselect attributes from the Request Builder tree which you do not need in the request. For VPC, CUP and EFTPOS processors, replace the processor name from VPC or CUP or EFTPOS to the actual processor name in the sample request. e.g. replace VPC with &amp;lt;your vpc processor&amp;gt; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRegistrationBody">Boarding registration data</param>
        /// <param name="vCIdempotencyId">defines idempotency of the request (optional)</param>
        /// <returns>InlineResponse2011</returns>
        InlineResponse2011 PostRegistration (PostRegistrationBody postRegistrationBody, string vCIdempotencyId = null);

        /// <summary>
        /// Create a boarding registration
        /// </summary>
        /// <remarks>
        /// Create a registration to board merchant  If you have  Card Processing product enabled in your boarding request, select payment processor from Configuration -&gt; Sample Request. You may unselect attributes from the Request Builder tree which you do not need in the request. For VPC, CUP and EFTPOS processors, replace the processor name from VPC or CUP or EFTPOS to the actual processor name in the sample request. e.g. replace VPC with &amp;lt;your vpc processor&amp;gt; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRegistrationBody">Boarding registration data</param>
        /// <param name="vCIdempotencyId">defines idempotency of the request (optional)</param>
        /// <returns>ApiResponse of InlineResponse2011</returns>
        ApiResponse<InlineResponse2011> PostRegistrationWithHttpInfo (PostRegistrationBody postRegistrationBody, string vCIdempotencyId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets all the information on a boarding registration
        /// </summary>
        /// <remarks>
        /// This end point will get all information of a boarding registration 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationId">Identifies the boarding registration to be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> GetRegistrationAsync (string registrationId);

        /// <summary>
        /// Gets all the information on a boarding registration
        /// </summary>
        /// <remarks>
        /// This end point will get all information of a boarding registration 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationId">Identifies the boarding registration to be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> GetRegistrationAsyncWithHttpInfo (string registrationId);
        /// <summary>
        /// Create a boarding registration
        /// </summary>
        /// <remarks>
        /// Create a registration to board merchant  If you have  Card Processing product enabled in your boarding request, select payment processor from Configuration -&gt; Sample Request. You may unselect attributes from the Request Builder tree which you do not need in the request. For VPC, CUP and EFTPOS processors, replace the processor name from VPC or CUP or EFTPOS to the actual processor name in the sample request. e.g. replace VPC with &amp;lt;your vpc processor&amp;gt; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRegistrationBody">Boarding registration data</param>
        /// <param name="vCIdempotencyId">defines idempotency of the request (optional)</param>
        /// <returns>Task of InlineResponse2011</returns>
        System.Threading.Tasks.Task<InlineResponse2011> PostRegistrationAsync (PostRegistrationBody postRegistrationBody, string vCIdempotencyId = null);

        /// <summary>
        /// Create a boarding registration
        /// </summary>
        /// <remarks>
        /// Create a registration to board merchant  If you have  Card Processing product enabled in your boarding request, select payment processor from Configuration -&gt; Sample Request. You may unselect attributes from the Request Builder tree which you do not need in the request. For VPC, CUP and EFTPOS processors, replace the processor name from VPC or CUP or EFTPOS to the actual processor name in the sample request. e.g. replace VPC with &amp;lt;your vpc processor&amp;gt; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRegistrationBody">Boarding registration data</param>
        /// <param name="vCIdempotencyId">defines idempotency of the request (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2011)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2011>> PostRegistrationAsyncWithHttpInfo (PostRegistrationBody postRegistrationBody, string vCIdempotencyId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MerchantBoardingApi : IMerchantBoardingApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantBoardingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MerchantBoardingApi(string basePath)
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
        /// Initializes a new instance of the <see cref="MerchantBoardingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MerchantBoardingApi(Configuration configuration = null)
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
        /// Gets all the information on a boarding registration This end point will get all information of a boarding registration 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationId">Identifies the boarding registration to be updated</param>
        /// <returns>InlineResponse2002</returns>
        /// <remarks>DISCLAIMER : Cybersource may allow Customer to access, use, and/or test a Cybersource product or service that may still be in development or has not been market-tested ("Beta Product") solely for the purpose of evaluating the functionality or marketability of the Beta Product (a "Beta Evaluation"). Notwithstanding any language to the contrary, the following terms shall apply with respect to Customer's participation in any Beta Evaluation (and the Beta Product(s)) accessed thereunder): The Parties will enter into a separate form agreement detailing the scope of the Beta Evaluation, requirements, pricing, the length of the beta evaluation period ("Beta Product Form"). Beta Products are not, and may not become, Transaction Services and have not yet been publicly released and are offered for the sole purpose of internal testing and non-commercial evaluation. Customer's use of the Beta Product shall be solely for the purpose of conducting the Beta Evaluation. Customer accepts all risks arising out of the access and use of the Beta Products. Cybersource may, in its sole discretion, at any time, terminate or discontinue the Beta Evaluation. Customer acknowledges and agrees that any Beta Product may still be in development and that Beta Product is provided "AS IS" and may not perform at the level of a commercially available service, may not operate as expected and may be modified prior to release. CYBERSOURCE SHALL NOT BE RESPONSIBLE OR LIABLE UNDER ANY CONTRACT, TORT (INCLUDING NEGLIGENCE), OR OTHERWISE RELATING TO A BETA PRODUCT OR THE BETA EVALUATION (A) FOR LOSS OR INACCURACY OF DATA OR COST OF PROCUREMENT OF SUBSTITUTE GOODS, SERVICES OR TECHNOLOGY, (B) ANY CLAIM, LOSSES, DAMAGES, OR CAUSE OF ACTION ARISING IN CONNECTION WITH THE BETA PRODUCT; OR (C) FOR ANY INDIRECT, INCIDENTAL OR CONSEQUENTIAL DAMAGES INCLUDING, BUT NOT LIMITED TO, LOSS OF REVENUES AND LOSS OF PROFITS.</remarks>
        public InlineResponse2002 GetRegistration (string registrationId)
        {
            logger.Debug("CALLING API \"GetRegistration\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<InlineResponse2002> localVarResponse = GetRegistrationWithHttpInfo(registrationId);
            logger.Debug("CALLING API \"GetRegistration\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all the information on a boarding registration This end point will get all information of a boarding registration 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationId">Identifies the boarding registration to be updated</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > GetRegistrationWithHttpInfo (string registrationId)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'registrationId' is set
            if (registrationId == null)
            {
                logger.Error("ApiException : Missing required parameter 'registrationId' when calling MerchantBoardingApi->GetRegistration");
                throw new ApiException(400, "Missing required parameter 'registrationId' when calling MerchantBoardingApi->GetRegistration");
            }

            var localVarPath = $"/boarding/v1/registrations/{registrationId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (registrationId != null)
            {
                localVarPathParams.Add("registrationId", Configuration.ApiClient.ParameterToString(registrationId)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
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
                Exception exception = ExceptionFactory("GetRegistration", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002))); // Return statement
        }

        /// <summary>
        /// Gets all the information on a boarding registration This end point will get all information of a boarding registration 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationId">Identifies the boarding registration to be updated</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> GetRegistrationAsync (string registrationId)
        {
            logger.Debug("CALLING API \"GetRegistrationAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<InlineResponse2002> localVarResponse = await GetRegistrationAsyncWithHttpInfo(registrationId);
            logger.Debug("CALLING API \"GetRegistrationAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all the information on a boarding registration This end point will get all information of a boarding registration 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="registrationId">Identifies the boarding registration to be updated</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> GetRegistrationAsyncWithHttpInfo (string registrationId)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'registrationId' is set
            if (registrationId == null)
            {
                logger.Error("ApiException : Missing required parameter 'registrationId' when calling MerchantBoardingApi->GetRegistration");
                throw new ApiException(400, "Missing required parameter 'registrationId' when calling MerchantBoardingApi->GetRegistration");
            }

            var localVarPath = $"/boarding/v1/registrations/{registrationId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (registrationId != null)
            {
                localVarPathParams.Add("registrationId", Configuration.ApiClient.ParameterToString(registrationId)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
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
                Exception exception = ExceptionFactory("GetRegistration", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002))); // Return statement
        }
        /// <summary>
        /// Create a boarding registration Create a registration to board merchant  If you have  Card Processing product enabled in your boarding request, select payment processor from Configuration -&gt; Sample Request. You may unselect attributes from the Request Builder tree which you do not need in the request. For VPC, CUP and EFTPOS processors, replace the processor name from VPC or CUP or EFTPOS to the actual processor name in the sample request. e.g. replace VPC with &amp;lt;your vpc processor&amp;gt; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRegistrationBody">Boarding registration data</param>
        /// <param name="vCIdempotencyId">defines idempotency of the request (optional)</param>
        /// <returns>InlineResponse2011</returns>
        /// <remarks>DISCLAIMER : Cybersource may allow Customer to access, use, and/or test a Cybersource product or service that may still be in development or has not been market-tested ("Beta Product") solely for the purpose of evaluating the functionality or marketability of the Beta Product (a "Beta Evaluation"). Notwithstanding any language to the contrary, the following terms shall apply with respect to Customer's participation in any Beta Evaluation (and the Beta Product(s)) accessed thereunder): The Parties will enter into a separate form agreement detailing the scope of the Beta Evaluation, requirements, pricing, the length of the beta evaluation period ("Beta Product Form"). Beta Products are not, and may not become, Transaction Services and have not yet been publicly released and are offered for the sole purpose of internal testing and non-commercial evaluation. Customer's use of the Beta Product shall be solely for the purpose of conducting the Beta Evaluation. Customer accepts all risks arising out of the access and use of the Beta Products. Cybersource may, in its sole discretion, at any time, terminate or discontinue the Beta Evaluation. Customer acknowledges and agrees that any Beta Product may still be in development and that Beta Product is provided "AS IS" and may not perform at the level of a commercially available service, may not operate as expected and may be modified prior to release. CYBERSOURCE SHALL NOT BE RESPONSIBLE OR LIABLE UNDER ANY CONTRACT, TORT (INCLUDING NEGLIGENCE), OR OTHERWISE RELATING TO A BETA PRODUCT OR THE BETA EVALUATION (A) FOR LOSS OR INACCURACY OF DATA OR COST OF PROCUREMENT OF SUBSTITUTE GOODS, SERVICES OR TECHNOLOGY, (B) ANY CLAIM, LOSSES, DAMAGES, OR CAUSE OF ACTION ARISING IN CONNECTION WITH THE BETA PRODUCT; OR (C) FOR ANY INDIRECT, INCIDENTAL OR CONSEQUENTIAL DAMAGES INCLUDING, BUT NOT LIMITED TO, LOSS OF REVENUES AND LOSS OF PROFITS.</remarks>
        public InlineResponse2011 PostRegistration (PostRegistrationBody postRegistrationBody, string vCIdempotencyId = null)
        {
            logger.Debug("CALLING API \"PostRegistration\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<InlineResponse2011> localVarResponse = PostRegistrationWithHttpInfo(postRegistrationBody, vCIdempotencyId);
            logger.Debug("CALLING API \"PostRegistration\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a boarding registration Create a registration to board merchant  If you have  Card Processing product enabled in your boarding request, select payment processor from Configuration -&gt; Sample Request. You may unselect attributes from the Request Builder tree which you do not need in the request. For VPC, CUP and EFTPOS processors, replace the processor name from VPC or CUP or EFTPOS to the actual processor name in the sample request. e.g. replace VPC with &amp;lt;your vpc processor&amp;gt; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRegistrationBody">Boarding registration data</param>
        /// <param name="vCIdempotencyId">defines idempotency of the request (optional)</param>
        /// <returns>ApiResponse of InlineResponse2011</returns>
        public ApiResponse< InlineResponse2011 > PostRegistrationWithHttpInfo (PostRegistrationBody postRegistrationBody, string vCIdempotencyId = null)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'postRegistrationBody' is set
            if (postRegistrationBody == null)
            {
                logger.Error("ApiException : Missing required parameter 'postRegistrationBody' when calling MerchantBoardingApi->PostRegistration");
                throw new ApiException(400, "Missing required parameter 'postRegistrationBody' when calling MerchantBoardingApi->PostRegistration");
            }

            var localVarPath = $"/boarding/v1/registrations";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (vCIdempotencyId != null)
            {
                localVarHeaderParams.Add("v-c-idempotency-id", Configuration.ApiClient.ParameterToString(vCIdempotencyId)); // header parameter
            }
            if (postRegistrationBody != null && postRegistrationBody.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                postRegistrationBody = (PostRegistrationBody)sdkTracker.InsertDeveloperIdTracker(postRegistrationBody, postRegistrationBody.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(postRegistrationBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = postRegistrationBody; // byte array
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
                Exception exception = ExceptionFactory("PostRegistration", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<InlineResponse2011>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2011) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2011))); // Return statement
        }

        /// <summary>
        /// Create a boarding registration Create a registration to board merchant  If you have  Card Processing product enabled in your boarding request, select payment processor from Configuration -&gt; Sample Request. You may unselect attributes from the Request Builder tree which you do not need in the request. For VPC, CUP and EFTPOS processors, replace the processor name from VPC or CUP or EFTPOS to the actual processor name in the sample request. e.g. replace VPC with &amp;lt;your vpc processor&amp;gt; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRegistrationBody">Boarding registration data</param>
        /// <param name="vCIdempotencyId">defines idempotency of the request (optional)</param>
        /// <returns>Task of InlineResponse2011</returns>
        public async System.Threading.Tasks.Task<InlineResponse2011> PostRegistrationAsync (PostRegistrationBody postRegistrationBody, string vCIdempotencyId = null)
        {
            logger.Debug("CALLING API \"PostRegistrationAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<InlineResponse2011> localVarResponse = await PostRegistrationAsyncWithHttpInfo(postRegistrationBody, vCIdempotencyId);
            logger.Debug("CALLING API \"PostRegistrationAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Create a boarding registration Create a registration to board merchant  If you have  Card Processing product enabled in your boarding request, select payment processor from Configuration -&gt; Sample Request. You may unselect attributes from the Request Builder tree which you do not need in the request. For VPC, CUP and EFTPOS processors, replace the processor name from VPC or CUP or EFTPOS to the actual processor name in the sample request. e.g. replace VPC with &amp;lt;your vpc processor&amp;gt; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="postRegistrationBody">Boarding registration data</param>
        /// <param name="vCIdempotencyId">defines idempotency of the request (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2011)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2011>> PostRegistrationAsyncWithHttpInfo (PostRegistrationBody postRegistrationBody, string vCIdempotencyId = null)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'postRegistrationBody' is set
            if (postRegistrationBody == null)
            {
                logger.Error("ApiException : Missing required parameter 'postRegistrationBody' when calling MerchantBoardingApi->PostRegistration");
                throw new ApiException(400, "Missing required parameter 'postRegistrationBody' when calling MerchantBoardingApi->PostRegistration");
            }

            var localVarPath = $"/boarding/v1/registrations";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (vCIdempotencyId != null)
            {
                localVarHeaderParams.Add("v-c-idempotency-id", Configuration.ApiClient.ParameterToString(vCIdempotencyId)); // header parameter
            }
            if (postRegistrationBody != null && postRegistrationBody.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                postRegistrationBody = (PostRegistrationBody)sdkTracker.InsertDeveloperIdTracker(postRegistrationBody, postRegistrationBody.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(postRegistrationBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = postRegistrationBody; // byte array
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
                Exception exception = ExceptionFactory("PostRegistration", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<InlineResponse2011>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2011) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2011))); // Return statement
        }
    }
}
