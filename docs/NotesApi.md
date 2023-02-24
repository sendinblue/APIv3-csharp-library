# sib_api_v3_sdk.Api.NotesApi

All URIs are relative to *https://api.sendinblue.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CrmNotesGet**](NotesApi.md#crmnotesget) | **GET** /crm/notes | Get all notes
[**CrmNotesIdDelete**](NotesApi.md#crmnotesiddelete) | **DELETE** /crm/notes/{id} | Delete a note
[**CrmNotesIdGet**](NotesApi.md#crmnotesidget) | **GET** /crm/notes/{id} | Get a note
[**CrmNotesIdPatch**](NotesApi.md#crmnotesidpatch) | **PATCH** /crm/notes/{id} | Update a note
[**CrmNotesPost**](NotesApi.md#crmnotespost) | **POST** /crm/notes | Create a note


<a name="crmnotesget"></a>
# **CrmNotesGet**
> NoteList CrmNotesGet (string entity = null, string entityIds = null, int? dateFrom = null, int? dateTo = null, long? offset = null, long? limit = null, string sort = null)

Get all notes

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmNotesGetExample
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

            var apiInstance = new NotesApi();
            var entity = entity_example;  // string | Filter by note entity type (optional) 
            var entityIds = entityIds_example;  // string | Filter by note entity IDs (optional) 
            var dateFrom = 56;  // int? | dateFrom to date range filter type (timestamp in milliseconds) (optional) 
            var dateTo = 56;  // int? | dateTo to date range filter type (timestamp in milliseconds) (optional) 
            var offset = 789;  // long? | Index of the first document of the page (optional) 
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order. Default order is **descending** by creation if `sort` is not passed (optional) 

            try
            {
                // Get all notes
                NoteList result = apiInstance.CrmNotesGet(entity, entityIds, dateFrom, dateTo, offset, limit, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.CrmNotesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity** | **string**| Filter by note entity type | [optional] 
 **entityIds** | **string**| Filter by note entity IDs | [optional] 
 **dateFrom** | **int?**| dateFrom to date range filter type (timestamp in milliseconds) | [optional] 
 **dateTo** | **int?**| dateTo to date range filter type (timestamp in milliseconds) | [optional] 
 **offset** | **long?**| Index of the first document of the page | [optional] 
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **sort** | **string**| Sort the results in the ascending/descending order. Default order is **descending** by creation if &#x60;sort&#x60; is not passed | [optional] 

### Return type

[**NoteList**](NoteList.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmnotesiddelete"></a>
# **CrmNotesIdDelete**
> void CrmNotesIdDelete (string id)

Delete a note

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmNotesIdDeleteExample
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

            var apiInstance = new NotesApi();
            var id = id_example;  // string | Note ID to delete

            try
            {
                // Delete a note
                apiInstance.CrmNotesIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.CrmNotesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Note ID to delete | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmnotesidget"></a>
# **CrmNotesIdGet**
> Note CrmNotesIdGet (string id)

Get a note

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmNotesIdGetExample
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

            var apiInstance = new NotesApi();
            var id = id_example;  // string | Note ID to get

            try
            {
                // Get a note
                Note result = apiInstance.CrmNotesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.CrmNotesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Note ID to get | 

### Return type

[**Note**](Note.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmnotesidpatch"></a>
# **CrmNotesIdPatch**
> void CrmNotesIdPatch (string id, NoteData body)

Update a note

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmNotesIdPatchExample
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

            var apiInstance = new NotesApi();
            var id = id_example;  // string | Note ID to update
            var body = new NoteData(); // NoteData | Note data to update a note

            try
            {
                // Update a note
                apiInstance.CrmNotesIdPatch(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.CrmNotesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Note ID to update | 
 **body** | [**NoteData**](NoteData.md)| Note data to update a note | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmnotespost"></a>
# **CrmNotesPost**
> NoteId CrmNotesPost (NoteData body)

Create a note

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmNotesPostExample
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

            var apiInstance = new NotesApi();
            var body = new NoteData(); // NoteData | Note data to create a note.

            try
            {
                // Create a note
                NoteId result = apiInstance.CrmNotesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotesApi.CrmNotesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NoteData**](NoteData.md)| Note data to create a note. | 

### Return type

[**NoteId**](NoteId.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

