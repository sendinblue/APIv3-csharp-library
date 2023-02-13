# sib_api_v3_sdk.Api.TasksApi

All URIs are relative to *https://api.sendinblue.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CrmTasksGet**](TasksApi.md#crmtasksget) | **GET** /crm/tasks | Get all tasks
[**CrmTasksIdDelete**](TasksApi.md#crmtasksiddelete) | **DELETE** /crm/tasks/{id} | Delete a task
[**CrmTasksIdGet**](TasksApi.md#crmtasksidget) | **GET** /crm/tasks/{id} | Get a task
[**CrmTasksIdPatch**](TasksApi.md#crmtasksidpatch) | **PATCH** /crm/tasks/{id} | Update a task
[**CrmTasksPost**](TasksApi.md#crmtaskspost) | **POST** /crm/tasks | Create a task
[**CrmTasktypesGet**](TasksApi.md#crmtasktypesget) | **GET** /crm/tasktypes | Get all task types


<a name="crmtasksget"></a>
# **CrmTasksGet**
> TaskList CrmTasksGet (string filterType = null, string filterStatus = null, string filterDate = null, string filterAssignTo = null, string filterContacts = null, string filterDeals = null, string filterCompanies = null, int? dateFrom = null, int? dateTo = null, long? offset = null, long? limit = null, string sort = null, string sortBy = null)

Get all tasks

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmTasksGetExample
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

            var apiInstance = new TasksApi();
            var filterType = filterType_example;  // string | Filter by task type (ID) (optional) 
            var filterStatus = filterStatus_example;  // string | Filter by task status (optional) 
            var filterDate = filterDate_example;  // string | Filter by date (optional) 
            var filterAssignTo = filterAssignTo_example;  // string | Filter by assignTo id (optional) 
            var filterContacts = filterContacts_example;  // string | Filter by contact ids (optional) 
            var filterDeals = filterDeals_example;  // string | Filter by deals ids (optional) 
            var filterCompanies = filterCompanies_example;  // string | Filter by companies ids (optional) 
            var dateFrom = 56;  // int? | dateFrom to date range filter type (timestamp in milliseconds) (optional) 
            var dateTo = 56;  // int? | dateTo to date range filter type (timestamp in milliseconds) (optional) 
            var offset = 789;  // long? | Index of the first document of the page (optional) 
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order. Default order is **descending** by creation if `sort` is not passed (optional) 
            var sortBy = sortBy_example;  // string | The field used to sort field names. (optional) 

            try
            {
                // Get all tasks
                TaskList result = apiInstance.CrmTasksGet(filterType, filterStatus, filterDate, filterAssignTo, filterContacts, filterDeals, filterCompanies, dateFrom, dateTo, offset, limit, sort, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CrmTasksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterType** | **string**| Filter by task type (ID) | [optional] 
 **filterStatus** | **string**| Filter by task status | [optional] 
 **filterDate** | **string**| Filter by date | [optional] 
 **filterAssignTo** | **string**| Filter by assignTo id | [optional] 
 **filterContacts** | **string**| Filter by contact ids | [optional] 
 **filterDeals** | **string**| Filter by deals ids | [optional] 
 **filterCompanies** | **string**| Filter by companies ids | [optional] 
 **dateFrom** | **int?**| dateFrom to date range filter type (timestamp in milliseconds) | [optional] 
 **dateTo** | **int?**| dateTo to date range filter type (timestamp in milliseconds) | [optional] 
 **offset** | **long?**| Index of the first document of the page | [optional] 
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **sort** | **string**| Sort the results in the ascending/descending order. Default order is **descending** by creation if &#x60;sort&#x60; is not passed | [optional] 
 **sortBy** | **string**| The field used to sort field names. | [optional] 

### Return type

[**TaskList**](TaskList.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmtasksiddelete"></a>
# **CrmTasksIdDelete**
> void CrmTasksIdDelete (string id)

Delete a task

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmTasksIdDeleteExample
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

            var apiInstance = new TasksApi();
            var id = id_example;  // string | 

            try
            {
                // Delete a task
                apiInstance.CrmTasksIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CrmTasksIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmtasksidget"></a>
# **CrmTasksIdGet**
> Task CrmTasksIdGet (string id)

Get a task

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmTasksIdGetExample
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

            var apiInstance = new TasksApi();
            var id = id_example;  // string | 

            try
            {
                // Get a task
                Task result = apiInstance.CrmTasksIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CrmTasksIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**Task**](Task.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmtasksidpatch"></a>
# **CrmTasksIdPatch**
> void CrmTasksIdPatch (string id, Body7 body)

Update a task

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmTasksIdPatchExample
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

            var apiInstance = new TasksApi();
            var id = id_example;  // string | 
            var body = new Body7(); // Body7 | Updated task details.

            try
            {
                // Update a task
                apiInstance.CrmTasksIdPatch(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CrmTasksIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Body7**](Body7.md)| Updated task details. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmtaskspost"></a>
# **CrmTasksPost**
> InlineResponse2011 CrmTasksPost (Body6 body)

Create a task

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmTasksPostExample
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

            var apiInstance = new TasksApi();
            var body = new Body6(); // Body6 | Task name.

            try
            {
                // Create a task
                InlineResponse2011 result = apiInstance.CrmTasksPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CrmTasksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body6**](Body6.md)| Task name. | 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmtasktypesget"></a>
# **CrmTasktypesGet**
> TaskTypes CrmTasktypesGet ()

Get all task types

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CrmTasktypesGetExample
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

            var apiInstance = new TasksApi();

            try
            {
                // Get all task types
                TaskTypes result = apiInstance.CrmTasktypesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CrmTasktypesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TaskTypes**](TaskTypes.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

