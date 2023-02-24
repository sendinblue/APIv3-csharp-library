# sib_api_v3_sdk.Api.MasterAccountApi

All URIs are relative to *https://api.sendinblue.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CorporateMasterAccountGet**](MasterAccountApi.md#corporatemasteraccountget) | **GET** /corporate/masterAccount | Get the details of requested master account
[**CorporateSubAccountGet**](MasterAccountApi.md#corporatesubaccountget) | **GET** /corporate/subAccount | Get the list of all the sub-accounts of the master account.
[**CorporateSubAccountIdDelete**](MasterAccountApi.md#corporatesubaccountiddelete) | **DELETE** /corporate/subAccount/{id} | Delete a sub-account
[**CorporateSubAccountIdGet**](MasterAccountApi.md#corporatesubaccountidget) | **GET** /corporate/subAccount/{id} | Get sub-account details
[**CorporateSubAccountIdPlanPut**](MasterAccountApi.md#corporatesubaccountidplanput) | **PUT** /corporate/subAccount/{id}/plan | Update sub-account plan
[**CorporateSubAccountKeyPost**](MasterAccountApi.md#corporatesubaccountkeypost) | **POST** /corporate/subAccount/key | Create an API key for a sub-account
[**CorporateSubAccountPost**](MasterAccountApi.md#corporatesubaccountpost) | **POST** /corporate/subAccount | Create a new sub-account under a master account.
[**CorporateSubAccountSsoTokenPost**](MasterAccountApi.md#corporatesubaccountssotokenpost) | **POST** /corporate/subAccount/ssoToken | Generate SSO token to access Sendinblue


<a name="corporatemasteraccountget"></a>
# **CorporateMasterAccountGet**
> MasterDetailsResponse CorporateMasterAccountGet ()

Get the details of requested master account

This endpoint will provide the details of the master account.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CorporateMasterAccountGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new MasterAccountApi();

            try
            {
                // Get the details of requested master account
                MasterDetailsResponse result = apiInstance.CorporateMasterAccountGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateMasterAccountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MasterDetailsResponse**](MasterDetailsResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountget"></a>
# **CorporateSubAccountGet**
> SubAccountsResponse CorporateSubAccountGet (int? offset, int? limit)

Get the list of all the sub-accounts of the master account.

This endpoint will provide the list all the sub-accounts of the master account.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CorporateSubAccountGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new MasterAccountApi();
            var offset = 56;  // int? | Index of the first sub-account in the page
            var limit = 56;  // int? | Number of sub-accounts to be displayed on each page

            try
            {
                // Get the list of all the sub-accounts of the master account.
                SubAccountsResponse result = apiInstance.CorporateSubAccountGet(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Index of the first sub-account in the page | 
 **limit** | **int?**| Number of sub-accounts to be displayed on each page | 

### Return type

[**SubAccountsResponse**](SubAccountsResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountiddelete"></a>
# **CorporateSubAccountIdDelete**
> void CorporateSubAccountIdDelete (long? id)

Delete a sub-account

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CorporateSubAccountIdDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new MasterAccountApi();
            var id = 789;  // long? | Id of the sub-account organization to be deleted

            try
            {
                // Delete a sub-account
                apiInstance.CorporateSubAccountIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the sub-account organization to be deleted | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountidget"></a>
# **CorporateSubAccountIdGet**
> SubAccountDetailsResponse CorporateSubAccountIdGet (long? id)

Get sub-account details

This endpoint will provide the details for the specified sub-account company

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CorporateSubAccountIdGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new MasterAccountApi();
            var id = 789;  // long? | Id of the sub-account organization

            try
            {
                // Get sub-account details
                SubAccountDetailsResponse result = apiInstance.CorporateSubAccountIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the sub-account organization | 

### Return type

[**SubAccountDetailsResponse**](SubAccountDetailsResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountidplanput"></a>
# **CorporateSubAccountIdPlanPut**
> void CorporateSubAccountIdPlanPut (long? id, SubAccountUpdatePlanRequest updatePlanDetails)

Update sub-account plan

This endpoint will update the sub-account plan

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CorporateSubAccountIdPlanPutExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new MasterAccountApi();
            var id = 789;  // long? | Id of the sub-account organization
            var updatePlanDetails = new SubAccountUpdatePlanRequest(); // SubAccountUpdatePlanRequest | Values to update a sub-account plan

            try
            {
                // Update sub-account plan
                apiInstance.CorporateSubAccountIdPlanPut(id, updatePlanDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountIdPlanPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the sub-account organization | 
 **updatePlanDetails** | [**SubAccountUpdatePlanRequest**](SubAccountUpdatePlanRequest.md)| Values to update a sub-account plan | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountkeypost"></a>
# **CorporateSubAccountKeyPost**
> CreateApiKeyResponse CorporateSubAccountKeyPost (CreateApiKeyRequest createApiKeyRequest)

Create an API key for a sub-account

This endpoint will generate an API v3 key for a sub account

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CorporateSubAccountKeyPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new MasterAccountApi();
            var createApiKeyRequest = new CreateApiKeyRequest(); // CreateApiKeyRequest | Values to generate API key for sub-account

            try
            {
                // Create an API key for a sub-account
                CreateApiKeyResponse result = apiInstance.CorporateSubAccountKeyPost(createApiKeyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountKeyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createApiKeyRequest** | [**CreateApiKeyRequest**](CreateApiKeyRequest.md)| Values to generate API key for sub-account | 

### Return type

[**CreateApiKeyResponse**](CreateApiKeyResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountpost"></a>
# **CorporateSubAccountPost**
> CreateSubAccountResponse CorporateSubAccountPost (CreateSubAccount subAccountCreate)

Create a new sub-account under a master account.

This endpoint will create a new sub-account under a master account

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CorporateSubAccountPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new MasterAccountApi();
            var subAccountCreate = new CreateSubAccount(); // CreateSubAccount | values to create new sub-account

            try
            {
                // Create a new sub-account under a master account.
                CreateSubAccountResponse result = apiInstance.CorporateSubAccountPost(subAccountCreate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subAccountCreate** | [**CreateSubAccount**](CreateSubAccount.md)| values to create new sub-account | 

### Return type

[**CreateSubAccountResponse**](CreateSubAccountResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountssotokenpost"></a>
# **CorporateSubAccountSsoTokenPost**
> GetSsoToken CorporateSubAccountSsoTokenPost (SsoTokenRequest ssoTokenRequest)

Generate SSO token to access Sendinblue

This endpoint generates an sso token to authenticate and access a sub-account of the master using the account endpoint https://account-app.sendinblue.com/account/login/sub-account/sso/[token], where [token] will be replaced by the actual token.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CorporateSubAccountSsoTokenPostExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new MasterAccountApi();
            var ssoTokenRequest = new SsoTokenRequest(); // SsoTokenRequest | Values to generate SSO token for sub-account

            try
            {
                // Generate SSO token to access Sendinblue
                GetSsoToken result = apiInstance.CorporateSubAccountSsoTokenPost(ssoTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountSsoTokenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ssoTokenRequest** | [**SsoTokenRequest**](SsoTokenRequest.md)| Values to generate SSO token for sub-account | 

### Return type

[**GetSsoToken**](GetSsoToken.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

