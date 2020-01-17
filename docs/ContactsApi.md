# sib_api_v3_sdk.Api.ContactsApi

All URIs are relative to *https://api.sendinblue.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddContactToList**](ContactsApi.md#addcontacttolist) | **POST** /contacts/lists/{listId}/contacts/add | Add existing contacts to a list
[**CreateAttribute**](ContactsApi.md#createattribute) | **POST** /contacts/attributes/{attributeCategory}/{attributeName} | Creates contact attribute
[**CreateContact**](ContactsApi.md#createcontact) | **POST** /contacts | Create a contact
[**CreateFolder**](ContactsApi.md#createfolder) | **POST** /contacts/folders | Create a folder
[**CreateList**](ContactsApi.md#createlist) | **POST** /contacts/lists | Create a list
[**DeleteAttribute**](ContactsApi.md#deleteattribute) | **DELETE** /contacts/attributes/{attributeCategory}/{attributeName} | Deletes an attribute
[**DeleteContact**](ContactsApi.md#deletecontact) | **DELETE** /contacts/{email} | Deletes a contact
[**DeleteFolder**](ContactsApi.md#deletefolder) | **DELETE** /contacts/folders/{folderId} | Delete a folder (and all its lists)
[**DeleteList**](ContactsApi.md#deletelist) | **DELETE** /contacts/lists/{listId} | Delete a list
[**GetAttributes**](ContactsApi.md#getattributes) | **GET** /contacts/attributes | Lists all attributes
[**GetContactInfo**](ContactsApi.md#getcontactinfo) | **GET** /contacts/{email} | Retrieves contact informations
[**GetContactStats**](ContactsApi.md#getcontactstats) | **GET** /contacts/{email}/campaignStats | Get the campaigns statistics for a contact
[**GetContacts**](ContactsApi.md#getcontacts) | **GET** /contacts | Get all the contacts
[**GetContactsFromList**](ContactsApi.md#getcontactsfromlist) | **GET** /contacts/lists/{listId}/contacts | Get the contacts in a list
[**GetFolder**](ContactsApi.md#getfolder) | **GET** /contacts/folders/{folderId} | Returns folder details
[**GetFolderLists**](ContactsApi.md#getfolderlists) | **GET** /contacts/folders/{folderId}/lists | Get the lists in a folder
[**GetFolders**](ContactsApi.md#getfolders) | **GET** /contacts/folders | Get all the folders
[**GetList**](ContactsApi.md#getlist) | **GET** /contacts/lists/{listId} | Get the details of a list
[**GetLists**](ContactsApi.md#getlists) | **GET** /contacts/lists | Get all the lists
[**ImportContacts**](ContactsApi.md#importcontacts) | **POST** /contacts/import | Import contacts
[**RemoveContactFromList**](ContactsApi.md#removecontactfromlist) | **POST** /contacts/lists/{listId}/contacts/remove | Remove existing contacts from a list
[**RequestContactExport**](ContactsApi.md#requestcontactexport) | **POST** /contacts/export | Export contacts
[**UpdateAttribute**](ContactsApi.md#updateattribute) | **PUT** /contacts/attributes/{attributeCategory}/{attributeName} | Updates contact attribute
[**UpdateContact**](ContactsApi.md#updatecontact) | **PUT** /contacts/{email} | Updates a contact
[**UpdateFolder**](ContactsApi.md#updatefolder) | **PUT** /contacts/folders/{folderId} | Update a contact folder
[**UpdateList**](ContactsApi.md#updatelist) | **PUT** /contacts/lists/{listId} | Update a list


<a name="addcontacttolist"></a>
# **AddContactToList**
> PostContactInfo AddContactToList (long? listId, AddContactToList contactEmails)

Add existing contacts to a list

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class AddContactToListExample
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

            var apiInstance = new ContactsApi();
            var listId = 789;  // long? | Id of the list
            var contactEmails = new AddContactToList(); // AddContactToList | Emails addresses of the contacts

            try
            {
                // Add existing contacts to a list
                PostContactInfo result = apiInstance.AddContactToList(listId, contactEmails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.AddContactToList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **long?**| Id of the list | 
 **contactEmails** | [**AddContactToList**](AddContactToList.md)| Emails addresses of the contacts | 

### Return type

[**PostContactInfo**](PostContactInfo.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createattribute"></a>
# **CreateAttribute**
> void CreateAttribute (string attributeCategory, string attributeName, CreateAttribute createAttribute)

Creates contact attribute

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CreateAttributeExample
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

            var apiInstance = new ContactsApi();
            var attributeCategory = attributeCategory_example;  // string | Category of the attribute
            var attributeName = attributeName_example;  // string | Name of the attribute
            var createAttribute = new CreateAttribute(); // CreateAttribute | Values to create an attribute

            try
            {
                // Creates contact attribute
                apiInstance.CreateAttribute(attributeCategory, attributeName, createAttribute);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateAttribute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attributeCategory** | **string**| Category of the attribute | 
 **attributeName** | **string**| Name of the attribute | 
 **createAttribute** | [**CreateAttribute**](CreateAttribute.md)| Values to create an attribute | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcontact"></a>
# **CreateContact**
> CreateUpdateContactModel CreateContact (CreateContact createContact)

Create a contact

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CreateContactExample
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

            var apiInstance = new ContactsApi();
            var createContact = new CreateContact(); // CreateContact | Values to create a contact

            try
            {
                // Create a contact
                CreateUpdateContactModel result = apiInstance.CreateContact(createContact);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createContact** | [**CreateContact**](CreateContact.md)| Values to create a contact | 

### Return type

[**CreateUpdateContactModel**](CreateUpdateContactModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfolder"></a>
# **CreateFolder**
> CreateModel CreateFolder (CreateUpdateFolder createFolder)

Create a folder

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CreateFolderExample
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

            var apiInstance = new ContactsApi();
            var createFolder = new CreateUpdateFolder(); // CreateUpdateFolder | Name of the folder

            try
            {
                // Create a folder
                CreateModel result = apiInstance.CreateFolder(createFolder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createFolder** | [**CreateUpdateFolder**](CreateUpdateFolder.md)| Name of the folder | 

### Return type

[**CreateModel**](CreateModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlist"></a>
# **CreateList**
> CreateModel CreateList (CreateList createList)

Create a list

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CreateListExample
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

            var apiInstance = new ContactsApi();
            var createList = new CreateList(); // CreateList | Values to create a list

            try
            {
                // Create a list
                CreateModel result = apiInstance.CreateList(createList);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createList** | [**CreateList**](CreateList.md)| Values to create a list | 

### Return type

[**CreateModel**](CreateModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteattribute"></a>
# **DeleteAttribute**
> void DeleteAttribute (string attributeCategory, string attributeName)

Deletes an attribute

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DeleteAttributeExample
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

            var apiInstance = new ContactsApi();
            var attributeCategory = attributeCategory_example;  // string | Category of the attribute
            var attributeName = attributeName_example;  // string | Name of the existing attribute

            try
            {
                // Deletes an attribute
                apiInstance.DeleteAttribute(attributeCategory, attributeName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteAttribute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attributeCategory** | **string**| Category of the attribute | 
 **attributeName** | **string**| Name of the existing attribute | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontact"></a>
# **DeleteContact**
> void DeleteContact (string email)

Deletes a contact

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DeleteContactExample
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

            var apiInstance = new ContactsApi();
            var email = email_example;  // string | Email (urlencoded) of the contact

            try
            {
                // Deletes a contact
                apiInstance.DeleteContact(email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email (urlencoded) of the contact | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefolder"></a>
# **DeleteFolder**
> void DeleteFolder (long? folderId)

Delete a folder (and all its lists)

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DeleteFolderExample
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

            var apiInstance = new ContactsApi();
            var folderId = 789;  // long? | Id of the folder

            try
            {
                // Delete a folder (and all its lists)
                apiInstance.DeleteFolder(folderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **long?**| Id of the folder | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelist"></a>
# **DeleteList**
> void DeleteList (long? listId)

Delete a list

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DeleteListExample
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

            var apiInstance = new ContactsApi();
            var listId = 789;  // long? | Id of the list

            try
            {
                // Delete a list
                apiInstance.DeleteList(listId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **long?**| Id of the list | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getattributes"></a>
# **GetAttributes**
> GetAttributes GetAttributes ()

Lists all attributes

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetAttributesExample
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

            var apiInstance = new ContactsApi();

            try
            {
                // Lists all attributes
                GetAttributes result = apiInstance.GetAttributes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetAttributes**](GetAttributes.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactinfo"></a>
# **GetContactInfo**
> GetExtendedContactDetails GetContactInfo (string email)

Retrieves contact informations

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetContactInfoExample
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

            var apiInstance = new ContactsApi();
            var email = email_example;  // string | Email (urlencoded) of the contact OR its SMS attribute value

            try
            {
                // Retrieves contact informations
                GetExtendedContactDetails result = apiInstance.GetContactInfo(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email (urlencoded) of the contact OR its SMS attribute value | 

### Return type

[**GetExtendedContactDetails**](GetExtendedContactDetails.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactstats"></a>
# **GetContactStats**
> GetContactCampaignStats GetContactStats (string email)

Get the campaigns statistics for a contact

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetContactStatsExample
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

            var apiInstance = new ContactsApi();
            var email = email_example;  // string | Email address (urlencoded) of the contact

            try
            {
                // Get the campaigns statistics for a contact
                GetContactCampaignStats result = apiInstance.GetContactStats(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email address (urlencoded) of the contact | 

### Return type

[**GetContactCampaignStats**](GetContactCampaignStats.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontacts"></a>
# **GetContacts**
> GetContacts GetContacts (long? limit = null, long? offset = null, DateTime? modifiedSince = null)

Get all the contacts

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetContactsExample
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

            var apiInstance = new ContactsApi();
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document of the page (optional)  (default to 0)
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter (urlencoded) the contacts modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. (optional) 

            try
            {
                // Get all the contacts
                GetContacts result = apiInstance.GetContacts(limit, offset, modifiedSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document of the page | [optional] [default to 0]
 **modifiedSince** | **DateTime?**| Filter (urlencoded) the contacts modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. | [optional] 

### Return type

[**GetContacts**](GetContacts.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactsfromlist"></a>
# **GetContactsFromList**
> GetContacts GetContactsFromList (long? listId, DateTime? modifiedSince = null, long? limit = null, long? offset = null)

Get the contacts in a list

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetContactsFromListExample
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

            var apiInstance = new ContactsApi();
            var listId = 789;  // long? | Id of the list
            var modifiedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter (urlencoded) the contacts modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. (optional) 
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document of the page (optional)  (default to 0)

            try
            {
                // Get the contacts in a list
                GetContacts result = apiInstance.GetContactsFromList(listId, modifiedSince, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContactsFromList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **long?**| Id of the list | 
 **modifiedSince** | **DateTime?**| Filter (urlencoded) the contacts modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. | [optional] 
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document of the page | [optional] [default to 0]

### Return type

[**GetContacts**](GetContacts.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfolder"></a>
# **GetFolder**
> GetFolder GetFolder (long? folderId)

Returns folder details

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetFolderExample
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

            var apiInstance = new ContactsApi();
            var folderId = 789;  // long? | id of the folder

            try
            {
                // Returns folder details
                GetFolder result = apiInstance.GetFolder(folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **long?**| id of the folder | 

### Return type

[**GetFolder**](GetFolder.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfolderlists"></a>
# **GetFolderLists**
> GetFolderLists GetFolderLists (long? folderId, long? limit = null, long? offset = null)

Get the lists in a folder

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetFolderListsExample
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

            var apiInstance = new ContactsApi();
            var folderId = 789;  // long? | Id of the folder
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 10)
            var offset = 789;  // long? | Index of the first document of the page (optional)  (default to 0)

            try
            {
                // Get the lists in a folder
                GetFolderLists result = apiInstance.GetFolderLists(folderId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetFolderLists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **long?**| Id of the folder | 
 **limit** | **long?**| Number of documents per page | [optional] [default to 10]
 **offset** | **long?**| Index of the first document of the page | [optional] [default to 0]

### Return type

[**GetFolderLists**](GetFolderLists.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfolders"></a>
# **GetFolders**
> GetFolders GetFolders (long? limit, long? offset)

Get all the folders

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetFoldersExample
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

            var apiInstance = new ContactsApi();
            var limit = 789;  // long? | Number of documents per page (default to 10)
            var offset = 789;  // long? | Index of the first document of the page (default to 0)

            try
            {
                // Get all the folders
                GetFolders result = apiInstance.GetFolders(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents per page | [default to 10]
 **offset** | **long?**| Index of the first document of the page | [default to 0]

### Return type

[**GetFolders**](GetFolders.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlist"></a>
# **GetList**
> GetExtendedList GetList (long? listId)

Get the details of a list

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetListExample
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

            var apiInstance = new ContactsApi();
            var listId = 789;  // long? | Id of the list

            try
            {
                // Get the details of a list
                GetExtendedList result = apiInstance.GetList(listId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **long?**| Id of the list | 

### Return type

[**GetExtendedList**](GetExtendedList.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlists"></a>
# **GetLists**
> GetLists GetLists (long? limit = null, long? offset = null)

Get all the lists

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetListsExample
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

            var apiInstance = new ContactsApi();
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 10)
            var offset = 789;  // long? | Index of the first document of the page (optional)  (default to 0)

            try
            {
                // Get all the lists
                GetLists result = apiInstance.GetLists(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetLists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents per page | [optional] [default to 10]
 **offset** | **long?**| Index of the first document of the page | [optional] [default to 0]

### Return type

[**GetLists**](GetLists.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importcontacts"></a>
# **ImportContacts**
> CreatedProcessId ImportContacts (RequestContactImport requestContactImport)

Import contacts

It returns the background process ID which on completion calls the notify URL that you have set in the input.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class ImportContactsExample
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

            var apiInstance = new ContactsApi();
            var requestContactImport = new RequestContactImport(); // RequestContactImport | Values to import contacts in Sendinblue. To know more about the expected format, please have a look at ``https://help.sendinblue.com/hc/en-us/articles/209499265-Build-contacts-lists-for-your-email-marketing-campaigns``

            try
            {
                // Import contacts
                CreatedProcessId result = apiInstance.ImportContacts(requestContactImport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ImportContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestContactImport** | [**RequestContactImport**](RequestContactImport.md)| Values to import contacts in Sendinblue. To know more about the expected format, please have a look at &#x60;&#x60;https://help.sendinblue.com/hc/en-us/articles/209499265-Build-contacts-lists-for-your-email-marketing-campaigns&#x60;&#x60; | 

### Return type

[**CreatedProcessId**](CreatedProcessId.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removecontactfromlist"></a>
# **RemoveContactFromList**
> PostContactInfo RemoveContactFromList (long? listId, RemoveContactFromList contactEmails)

Remove existing contacts from a list

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class RemoveContactFromListExample
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

            var apiInstance = new ContactsApi();
            var listId = 789;  // long? | Id of the list
            var contactEmails = new RemoveContactFromList(); // RemoveContactFromList | Emails adresses of the contact

            try
            {
                // Remove existing contacts from a list
                PostContactInfo result = apiInstance.RemoveContactFromList(listId, contactEmails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.RemoveContactFromList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **long?**| Id of the list | 
 **contactEmails** | [**RemoveContactFromList**](RemoveContactFromList.md)| Emails adresses of the contact | 

### Return type

[**PostContactInfo**](PostContactInfo.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestcontactexport"></a>
# **RequestContactExport**
> CreatedProcessId RequestContactExport (RequestContactExport requestContactExport)

Export contacts

It returns the background process ID which on completion calls the notify URL that you have set in the input. File will be available in csv.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class RequestContactExportExample
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

            var apiInstance = new ContactsApi();
            var requestContactExport = new RequestContactExport(); // RequestContactExport | Values to request a contact export

            try
            {
                // Export contacts
                CreatedProcessId result = apiInstance.RequestContactExport(requestContactExport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.RequestContactExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestContactExport** | [**RequestContactExport**](RequestContactExport.md)| Values to request a contact export | 

### Return type

[**CreatedProcessId**](CreatedProcessId.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateattribute"></a>
# **UpdateAttribute**
> void UpdateAttribute (string attributeCategory, string attributeName, UpdateAttribute updateAttribute)

Updates contact attribute

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class UpdateAttributeExample
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

            var apiInstance = new ContactsApi();
            var attributeCategory = attributeCategory_example;  // string | Category of the attribute
            var attributeName = attributeName_example;  // string | Name of the existing attribute
            var updateAttribute = new UpdateAttribute(); // UpdateAttribute | Values to update an attribute

            try
            {
                // Updates contact attribute
                apiInstance.UpdateAttribute(attributeCategory, attributeName, updateAttribute);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateAttribute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attributeCategory** | **string**| Category of the attribute | 
 **attributeName** | **string**| Name of the existing attribute | 
 **updateAttribute** | [**UpdateAttribute**](UpdateAttribute.md)| Values to update an attribute | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontact"></a>
# **UpdateContact**
> void UpdateContact (string email, UpdateContact updateContact)

Updates a contact

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class UpdateContactExample
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

            var apiInstance = new ContactsApi();
            var email = email_example;  // string | Email (urlencoded) of the contact
            var updateContact = new UpdateContact(); // UpdateContact | Values to update a contact

            try
            {
                // Updates a contact
                apiInstance.UpdateContact(email, updateContact);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email (urlencoded) of the contact | 
 **updateContact** | [**UpdateContact**](UpdateContact.md)| Values to update a contact | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefolder"></a>
# **UpdateFolder**
> void UpdateFolder (long? folderId, CreateUpdateFolder updateFolder)

Update a contact folder

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class UpdateFolderExample
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

            var apiInstance = new ContactsApi();
            var folderId = 789;  // long? | Id of the folder
            var updateFolder = new CreateUpdateFolder(); // CreateUpdateFolder | Name of the folder

            try
            {
                // Update a contact folder
                apiInstance.UpdateFolder(folderId, updateFolder);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **long?**| Id of the folder | 
 **updateFolder** | [**CreateUpdateFolder**](CreateUpdateFolder.md)| Name of the folder | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelist"></a>
# **UpdateList**
> void UpdateList (long? listId, UpdateList updateList)

Update a list

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class UpdateListExample
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

            var apiInstance = new ContactsApi();
            var listId = 789;  // long? | Id of the list
            var updateList = new UpdateList(); // UpdateList | Values to update a list

            try
            {
                // Update a list
                apiInstance.UpdateList(listId, updateList);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **long?**| Id of the list | 
 **updateList** | [**UpdateList**](UpdateList.md)| Values to update a list | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

