# sib_api_v3_sdk.Api.ResellerApi

All URIs are relative to *https://api.sendinblue.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCredits**](ResellerApi.md#addcredits) | **POST** /reseller/children/{childAuthKey}/credits/add | Add Email and/or SMS credits to a specific child account
[**AssociateIpToChild**](ResellerApi.md#associateiptochild) | **POST** /reseller/children/{childAuthKey}/ips/associate | Associate a dedicated IP to the child
[**CreateChildDomain**](ResellerApi.md#createchilddomain) | **POST** /reseller/children/{childAuthKey}/domains | Creates a domain for a child account
[**CreateResellerChild**](ResellerApi.md#createresellerchild) | **POST** /reseller/children | Creates a reseller child
[**DeleteChildDomain**](ResellerApi.md#deletechilddomain) | **DELETE** /reseller/children/{childAuthKey}/domains/{domainName} | Deletes the sender domain of the reseller child based on the childAuthKey and domainName passed
[**DeleteResellerChild**](ResellerApi.md#deleteresellerchild) | **DELETE** /reseller/children/{childAuthKey} | Deletes a single reseller child based on the childAuthKey supplied
[**DissociateIpFromChild**](ResellerApi.md#dissociateipfromchild) | **POST** /reseller/children/{childAuthKey}/ips/dissociate | Dissociate a dedicated IP to the child
[**GetChildAccountCreationStatus**](ResellerApi.md#getchildaccountcreationstatus) | **GET** /reseller/children/{childAuthKey}/accountCreationStatus | Returns the status of reseller&#39;s child account creation, whether it is successfully created (exists) or not based on the childAuthKey supplied
[**GetChildDomains**](ResellerApi.md#getchilddomains) | **GET** /reseller/children/{childAuthKey}/domains | Gets all the sender domains of a specific child account
[**GetChildInfo**](ResellerApi.md#getchildinfo) | **GET** /reseller/children/{childAuthKey} | Gets the info about a specific child account
[**GetResellerChilds**](ResellerApi.md#getresellerchilds) | **GET** /reseller/children | Gets the list of all reseller&#39;s children accounts
[**GetSsoToken**](ResellerApi.md#getssotoken) | **GET** /reseller/children/{childAuthKey}/auth | Get session token to access Sendinblue (SSO)
[**RemoveCredits**](ResellerApi.md#removecredits) | **POST** /reseller/children/{childAuthKey}/credits/remove | Remove Email and/or SMS credits from a specific child account
[**UpdateChildAccountStatus**](ResellerApi.md#updatechildaccountstatus) | **PUT** /reseller/children/{childAuthKey}/accountStatus | Updates infos of reseller&#39;s child account status based on the childAuthKey supplied
[**UpdateChildDomain**](ResellerApi.md#updatechilddomain) | **PUT** /reseller/children/{childAuthKey}/domains/{domainName} | Updates the sender domain of reseller&#39;s child based on the childAuthKey and domainName passed
[**UpdateResellerChild**](ResellerApi.md#updateresellerchild) | **PUT** /reseller/children/{childAuthKey} | Updates infos of reseller&#39;s child based on the childAuthKey supplied


<a name="addcredits"></a>
# **AddCredits**
> RemainingCreditModel AddCredits (string childAuthKey, AddCredits addCredits)

Add Email and/or SMS credits to a specific child account

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class AddCreditsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child
            var addCredits = new AddCredits(); // AddCredits | Values to post to add credit to a specific child account

            try
            {
                // Add Email and/or SMS credits to a specific child account
                RemainingCreditModel result = apiInstance.AddCredits(childAuthKey, addCredits);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.AddCredits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 
 **addCredits** | [**AddCredits**](AddCredits.md)| Values to post to add credit to a specific child account | 

### Return type

[**RemainingCreditModel**](RemainingCreditModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="associateiptochild"></a>
# **AssociateIpToChild**
> void AssociateIpToChild (string childAuthKey, ManageIp ip)

Associate a dedicated IP to the child

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class AssociateIpToChildExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child
            var ip = new ManageIp(); // ManageIp | IP to associate

            try
            {
                // Associate a dedicated IP to the child
                apiInstance.AssociateIpToChild(childAuthKey, ip);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.AssociateIpToChild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 
 **ip** | [**ManageIp**](ManageIp.md)| IP to associate | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createchilddomain"></a>
# **CreateChildDomain**
> void CreateChildDomain (string childAuthKey, AddChildDomain addChildDomain)

Creates a domain for a child account

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CreateChildDomainExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child
            var addChildDomain = new AddChildDomain(); // AddChildDomain | Sender domain to add for a specific child account. This will not be displayed to the parent account.

            try
            {
                // Creates a domain for a child account
                apiInstance.CreateChildDomain(childAuthKey, addChildDomain);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.CreateChildDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 
 **addChildDomain** | [**AddChildDomain**](AddChildDomain.md)| Sender domain to add for a specific child account. This will not be displayed to the parent account. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createresellerchild"></a>
# **CreateResellerChild**
> CreateReseller CreateResellerChild (CreateChild resellerChild = null)

Creates a reseller child

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CreateResellerChildExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var resellerChild = new CreateChild(); // CreateChild | reseller child to add (optional) 

            try
            {
                // Creates a reseller child
                CreateReseller result = apiInstance.CreateResellerChild(resellerChild);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.CreateResellerChild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resellerChild** | [**CreateChild**](CreateChild.md)| reseller child to add | [optional] 

### Return type

[**CreateReseller**](CreateReseller.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletechilddomain"></a>
# **DeleteChildDomain**
> void DeleteChildDomain (string childAuthKey, string domainName)

Deletes the sender domain of the reseller child based on the childAuthKey and domainName passed

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DeleteChildDomainExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child
            var domainName = domainName_example;  // string | Pass the existing domain that needs to be deleted

            try
            {
                // Deletes the sender domain of the reseller child based on the childAuthKey and domainName passed
                apiInstance.DeleteChildDomain(childAuthKey, domainName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.DeleteChildDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 
 **domainName** | **string**| Pass the existing domain that needs to be deleted | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteresellerchild"></a>
# **DeleteResellerChild**
> void DeleteResellerChild (string childAuthKey)

Deletes a single reseller child based on the childAuthKey supplied

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DeleteResellerChildExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child

            try
            {
                // Deletes a single reseller child based on the childAuthKey supplied
                apiInstance.DeleteResellerChild(childAuthKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.DeleteResellerChild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dissociateipfromchild"></a>
# **DissociateIpFromChild**
> void DissociateIpFromChild (string childAuthKey, ManageIp ip)

Dissociate a dedicated IP to the child

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DissociateIpFromChildExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child
            var ip = new ManageIp(); // ManageIp | IP to dissociate

            try
            {
                // Dissociate a dedicated IP to the child
                apiInstance.DissociateIpFromChild(childAuthKey, ip);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.DissociateIpFromChild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 
 **ip** | [**ManageIp**](ManageIp.md)| IP to dissociate | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildaccountcreationstatus"></a>
# **GetChildAccountCreationStatus**
> GetChildAccountCreationStatus GetChildAccountCreationStatus (string childAuthKey)

Returns the status of reseller's child account creation, whether it is successfully created (exists) or not based on the childAuthKey supplied

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetChildAccountCreationStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child

            try
            {
                // Returns the status of reseller's child account creation, whether it is successfully created (exists) or not based on the childAuthKey supplied
                GetChildAccountCreationStatus result = apiInstance.GetChildAccountCreationStatus(childAuthKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.GetChildAccountCreationStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 

### Return type

[**GetChildAccountCreationStatus**](GetChildAccountCreationStatus.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchilddomains"></a>
# **GetChildDomains**
> GetChildDomains GetChildDomains (string childAuthKey)

Gets all the sender domains of a specific child account

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetChildDomainsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child

            try
            {
                // Gets all the sender domains of a specific child account
                GetChildDomains result = apiInstance.GetChildDomains(childAuthKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.GetChildDomains: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 

### Return type

[**GetChildDomains**](GetChildDomains.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchildinfo"></a>
# **GetChildInfo**
> GetChildInfo GetChildInfo (string childAuthKey)

Gets the info about a specific child account

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetChildInfoExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child

            try
            {
                // Gets the info about a specific child account
                GetChildInfo result = apiInstance.GetChildInfo(childAuthKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.GetChildInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 

### Return type

[**GetChildInfo**](GetChildInfo.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresellerchilds"></a>
# **GetResellerChilds**
> GetChildrenList GetResellerChilds (long? limit = null, long? offset = null)

Gets the list of all reseller's children accounts

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetResellerChildsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var limit = 789;  // long? | Number of documents for child accounts information per page (optional)  (default to 10)
            var offset = 789;  // long? | Index of the first document in the page (optional)  (default to 0)

            try
            {
                // Gets the list of all reseller's children accounts
                GetChildrenList result = apiInstance.GetResellerChilds(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.GetResellerChilds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents for child accounts information per page | [optional] [default to 10]
 **offset** | **long?**| Index of the first document in the page | [optional] [default to 0]

### Return type

[**GetChildrenList**](GetChildrenList.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getssotoken"></a>
# **GetSsoToken**
> GetSsoToken GetSsoToken (string childAuthKey)

Get session token to access Sendinblue (SSO)

It returns a session [token] which will remain valid for a short period of time. A child account will be able to access a white-labeled section by using the following url pattern => https:/email.mydomain.com/login/sso?token=[token]

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetSsoTokenExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child

            try
            {
                // Get session token to access Sendinblue (SSO)
                GetSsoToken result = apiInstance.GetSsoToken(childAuthKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.GetSsoToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 

### Return type

[**GetSsoToken**](GetSsoToken.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removecredits"></a>
# **RemoveCredits**
> RemainingCreditModel RemoveCredits (string childAuthKey, RemoveCredits removeCredits)

Remove Email and/or SMS credits from a specific child account

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class RemoveCreditsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child
            var removeCredits = new RemoveCredits(); // RemoveCredits | Values to post to remove email or SMS credits from a specific child account

            try
            {
                // Remove Email and/or SMS credits from a specific child account
                RemainingCreditModel result = apiInstance.RemoveCredits(childAuthKey, removeCredits);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.RemoveCredits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 
 **removeCredits** | [**RemoveCredits**](RemoveCredits.md)| Values to post to remove email or SMS credits from a specific child account | 

### Return type

[**RemainingCreditModel**](RemainingCreditModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechildaccountstatus"></a>
# **UpdateChildAccountStatus**
> void UpdateChildAccountStatus (string childAuthKey, UpdateChildAccountStatus updateChildAccountStatus)

Updates infos of reseller's child account status based on the childAuthKey supplied

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class UpdateChildAccountStatusExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child
            var updateChildAccountStatus = new UpdateChildAccountStatus(); // UpdateChildAccountStatus | values to update in child account status

            try
            {
                // Updates infos of reseller's child account status based on the childAuthKey supplied
                apiInstance.UpdateChildAccountStatus(childAuthKey, updateChildAccountStatus);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.UpdateChildAccountStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 
 **updateChildAccountStatus** | [**UpdateChildAccountStatus**](UpdateChildAccountStatus.md)| values to update in child account status | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatechilddomain"></a>
# **UpdateChildDomain**
> void UpdateChildDomain (string childAuthKey, string domainName, UpdateChildDomain updateChildDomain)

Updates the sender domain of reseller's child based on the childAuthKey and domainName passed

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class UpdateChildDomainExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child
            var domainName = domainName_example;  // string | Pass the existing domain that needs to be updated
            var updateChildDomain = new UpdateChildDomain(); // UpdateChildDomain | value to update for sender domain

            try
            {
                // Updates the sender domain of reseller's child based on the childAuthKey and domainName passed
                apiInstance.UpdateChildDomain(childAuthKey, domainName, updateChildDomain);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.UpdateChildDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 
 **domainName** | **string**| Pass the existing domain that needs to be updated | 
 **updateChildDomain** | [**UpdateChildDomain**](UpdateChildDomain.md)| value to update for sender domain | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateresellerchild"></a>
# **UpdateResellerChild**
> void UpdateResellerChild (string childAuthKey, UpdateChild resellerChild)

Updates infos of reseller's child based on the childAuthKey supplied

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class UpdateResellerChildExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ResellerApi();
            var childAuthKey = childAuthKey_example;  // string | auth key of reseller's child
            var resellerChild = new UpdateChild(); // UpdateChild | values to update in child profile

            try
            {
                // Updates infos of reseller's child based on the childAuthKey supplied
                apiInstance.UpdateResellerChild(childAuthKey, resellerChild);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResellerApi.UpdateResellerChild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childAuthKey** | **string**| auth key of reseller&#39;s child | 
 **resellerChild** | [**UpdateChild**](UpdateChild.md)| values to update in child profile | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

