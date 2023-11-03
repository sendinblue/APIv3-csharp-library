using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using sib_api_v3_sdk.Model;

namespace sib_api_v3_sdk.Api
{
    using sib_api_v3_sdk.Client;

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContactsApi : IApiAccessor
    {
        /// <summary>
        /// Get a contact&#39;s details
        /// </summary>
        /// <remarks>
        /// Along with the contact details, this endpoint will show the statistics of contact for the recent 90 days by default. To fetch the earlier statistics, please use Get contact campaign stats (https://developers.sendinblue.com/reference/contacts-7#getcontactstats) endpoint with the appropriate date ranges.
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Email (urlencoded) OR ID of the contact OR its SMS attribute value</param>
        /// <returns>Task of GetExtendedContactDetails</returns>
        System.Threading.Tasks.Task<GetExtendedContactDetails> GetContactInfoAsync (string identifier);

        /// <summary>
        /// Add existing contacts to a list
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">Id of the list</param>
        /// <param name="contactEmails">Emails addresses OR IDs of the contacts</param>
        /// <returns>Task of PostContactInfo</returns>
        System.Threading.Tasks.Task<PostContactInfo> AddContactToListAsync (long? listId, AddContactToList contactEmails);

        /// <summary>
        /// Update a contact
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Email (urlencoded) OR ID of the contact</param>
        /// <param name="updateContact">Values to update a contact</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateContactAsync (string identifier, UpdateContact updateContact);

        /// <summary>
        /// Create a contact
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createContact">Values to create a contact</param>
        /// <returns>Task of CreateUpdateContactModel</returns>
        System.Threading.Tasks.Task<CreateUpdateContactModel> CreateContactAsync (CreateContact createContact);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ContactsApi : IContactsApi
    {
        private sib_api_v3_sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContactsApi(String basePath)
        {
            this.Configuration = new sib_api_v3_sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = sib_api_v3_sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContactsApi(sib_api_v3_sdk.Client.Configuration configuration = null)
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
        [Obsolete(
            "SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public sib_api_v3_sdk.Client.Configuration Configuration { get; set; }

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
        /// Get a contact&#39;s details Along with the contact details, this endpoint will show the statistics of contact for the recent 90 days by default. To fetch the earlier statistics, please use Get contact campaign stats (https://developers.sendinblue.com/reference/contacts-7#getcontactstats) endpoint with the appropriate date ranges.
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Email (urlencoded) OR ID of the contact OR its SMS attribute value</param>
        /// <param name="startDate">**Mandatory if endDate is used.** Starting date (YYYY-MM-DD) of the statistic events specific to campaigns. Must be lower than equal to endDate  (optional)</param>
        /// <param name="endDate">**Mandatory if startDate is used.** Ending date (YYYY-MM-DD) of the statistic events specific to campaigns. Must be greater than equal to startDate.  (optional)</param>
        /// <returns>Task of GetExtendedContactDetails</returns>
        public async System.Threading.Tasks.Task<GetExtendedContactDetails> GetContactInfoAsync (string identifier)
        {
             var localVarResponse = await GetContactInfoAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a contact&#39;s details Along with the contact details, this endpoint will show the statistics of contact for the recent 90 days by default. To fetch the earlier statistics, please use Get contact campaign stats (https://developers.sendinblue.com/reference/contacts-7#getcontactstats) endpoint with the appropriate date ranges.
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Email (urlencoded) OR ID of the contact OR its SMS attribute value</param>
        /// <param name="startDate">**Mandatory if endDate is used.** Starting date (YYYY-MM-DD) of the statistic events specific to campaigns. Must be lower than equal to endDate  (optional)</param>
        /// <param name="endDate">**Mandatory if startDate is used.** Ending date (YYYY-MM-DD) of the statistic events specific to campaigns. Must be greater than equal to startDate.  (optional)</param>
        /// <returns>Task of ApiResponse (GetExtendedContactDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetExtendedContactDetails>> GetContactInfoAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ContactsApi->GetContactInfo");

            var localVarPath = $"./contacts/{identifier}";
            var request = this.Configuration.ApiClient.PrepareJsonGetRequest(localVarPath, "application/json");
            var response = await this.Configuration.ApiClient.RestClient.SendAsync(request);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetContactInfo", response);
                if (exception != null) throw exception;
            }

            var localVarStatusCode = (int) response.StatusCode;
            return new ApiResponse<GetExtendedContactDetails>(localVarStatusCode,
                response.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (GetExtendedContactDetails) this.Configuration.ApiClient.Deserialize(response, typeof(GetExtendedContactDetails)));
        }

        /// <summary>
        /// Add existing contacts to a list
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">Id of the list</param>
        /// <param name="contactEmails">Emails addresses OR IDs of the contacts</param>
        /// <returns>Task of PostContactInfo</returns>
        public async System.Threading.Tasks.Task<PostContactInfo> AddContactToListAsync (long? listId, AddContactToList contactEmails)
        {
             var localVarResponse = await AddContactToListAsyncWithHttpInfo(listId, contactEmails);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add existing contacts to a list
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="listId">Id of the list</param>
        /// <param name="contactEmails">Emails addresses OR IDs of the contacts</param>
        /// <returns>Task of ApiResponse (PostContactInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PostContactInfo>> AddContactToListAsyncWithHttpInfo (long? listId, AddContactToList contactEmails)
        {
            // verify the required parameter 'listId' is set
            if (listId == null)
                throw new ApiException(400, "Missing required parameter 'listId' when calling ContactsApi->AddContactToList");
            // verify the required parameter 'contactEmails' is set
            if (contactEmails == null)
                throw new ApiException(400, "Missing required parameter 'contactEmails' when calling ContactsApi->AddContactToList");

            var localVarPath = $"./contacts/lists/{listId}/contacts/add";
            var postBody = this.Configuration.ApiClient.Serialize(contactEmails);
            var request = this.Configuration.ApiClient.PreparePostBodyRequest(localVarPath, "application/json", postBody);
            var response = await this.Configuration.ApiClient.RestClient.SendAsync(request);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddContactToList", response);
                if (exception != null) throw exception;
            }

            var localVarStatusCode = (int) response.StatusCode;
            return new ApiResponse<PostContactInfo>(localVarStatusCode,
                response.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (PostContactInfo) this.Configuration.ApiClient.Deserialize(response, typeof(PostContactInfo)));
        }

        /// <summary>
        /// Update a contact
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Email (urlencoded) OR ID of the contact</param>
        /// <param name="updateContact">Values to update a contact</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateContactAsync (string identifier, UpdateContact updateContact)
        {
             await UpdateContactAsyncWithHttpInfo(identifier, updateContact);
        }

        /// <summary>
        /// Update a contact
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">Email (urlencoded) OR ID of the contact</param>
        /// <param name="updateContact">Values to update a contact</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateContactAsyncWithHttpInfo (string identifier, UpdateContact updateContact)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling ContactsApi->UpdateContact");
            // verify the required parameter 'updateContact' is set
            if (updateContact == null)
                throw new ApiException(400, "Missing required parameter 'updateContact' when calling ContactsApi->UpdateContact");

            var localVarPath = $"./contacts/{identifier}";
            var localVarPostBody = this.Configuration.ApiClient.Serialize(updateContact);
            var request = this.Configuration.ApiClient.PreparePostBodyRequest(localVarPath, "applicaton/json", localVarPostBody);
            var response = await this.Configuration.ApiClient.RestClient.SendAsync(request);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateContact", response);
                if (exception != null) throw exception;
            }

            var localVarStatusCode = (int) response.StatusCode;
            return new ApiResponse<Object>(localVarStatusCode,
                response.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create a contact
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createContact">Values to create a contact</param>
        /// <returns>Task of CreateUpdateContactModel</returns>
        public async System.Threading.Tasks.Task<CreateUpdateContactModel> CreateContactAsync (CreateContact createContact)
        {
             var localVarResponse = await CreateContactAsyncWithHttpInfo(createContact);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a contact
        /// </summary>
        /// <exception cref="sib_api_v3_sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createContact">Values to create a contact</param>
        /// <returns>Task of ApiResponse (CreateUpdateContactModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateUpdateContactModel>> CreateContactAsyncWithHttpInfo (CreateContact createContact)
        {
            // verify the required parameter 'createContact' is set
            if (createContact == null)
                throw new ApiException(400, "Missing required parameter 'createContact' when calling ContactsApi->CreateContact");

            var localVarPath = "./contacts";
            var localVarPostBody = this.Configuration.ApiClient.Serialize(createContact);
            var request = this.Configuration.ApiClient.PreparePostBodyRequest(localVarPath, "application/json", localVarPostBody);
            var response = await this.Configuration.ApiClient.RestClient.SendAsync(request);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateContact", response);
                if (exception != null) throw exception;
            }

            var localVarStatusCode = (int) response.StatusCode;
            return new ApiResponse<CreateUpdateContactModel>(localVarStatusCode,
                response.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (CreateUpdateContactModel) this.Configuration.ApiClient.Deserialize(response, typeof(CreateUpdateContactModel)));
        }
    }
}
