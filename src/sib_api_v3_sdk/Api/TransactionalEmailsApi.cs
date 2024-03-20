using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace sib_api_v3_sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionalEmailsApi : IApiAccessor
    {
        /// <summary>
        /// Send a transactional email
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendSmtpEmail">Values to send a transactional email</param>
        /// <returns>Task of CreateSmtpEmail</returns>
        System.Threading.Tasks.Task<CreateSmtpEmail> SendTransacEmailAsync (SendSmtpEmail sendSmtpEmail);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionalEmailsApi : ITransactionalEmailsApi
    {
        private sib_api_v3_sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionalEmailsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransactionalEmailsApi(String basePath)
        {
            this.Configuration = new sib_api_v3_sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = sib_api_v3_sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionalEmailsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionalEmailsApi(sib_api_v3_sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = sib_api_v3_sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = sib_api_v3_sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseAddress.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public sib_api_v3_sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public sib_api_v3_sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Send a transactional email
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendSmtpEmail">Values to send a transactional email</param>
        /// <returns>Task of CreateSmtpEmail</returns>
        public async System.Threading.Tasks.Task<CreateSmtpEmail> SendTransacEmailAsync (SendSmtpEmail sendSmtpEmail)
        {
             var response = await SendTransacEmailAsyncWithHttpInfo(sendSmtpEmail);
             return response.Data;

        }

        /// <summary>
        /// Send a transactional email
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sendSmtpEmail">Values to send a transactional email</param>
        /// <returns>Task of ApiResponse (CreateSmtpEmail)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateSmtpEmail>> SendTransacEmailAsyncWithHttpInfo (SendSmtpEmail sendSmtpEmail)
        {
            // verify the required parameter 'sendSmtpEmail' is set
            if (sendSmtpEmail == null)
                throw new ApiException(400, "Missing required parameter 'sendSmtpEmail' when calling TransactionalEmailsApi->SendTransacEmail");

            var localVarPath = "./smtp/email";
            var localVarPostBody = this.Configuration.ApiClient.Serialize(sendSmtpEmail);

            var request = this.Configuration.ApiClient.PreparePostBodyRequest(localVarPath, "application/json", localVarPostBody);
            var response = await this.Configuration.ApiClient.RestClient.SendAsync(request);

            var localVarStatusCode = (int) response.StatusCode;

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendTransacEmail", response);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateSmtpEmail>(localVarStatusCode,
                response.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (CreateSmtpEmail) this.Configuration.ApiClient.Deserialize(response, typeof(CreateSmtpEmail)));
        }
    }
}
