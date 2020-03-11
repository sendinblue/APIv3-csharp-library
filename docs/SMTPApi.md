# sib_api_v3_sdk.Api.SMTPApi

All URIs are relative to *https://api.sendinblue.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSmtpTemplate**](SMTPApi.md#createsmtptemplate) | **POST** /smtp/templates | Create a transactional email template
[**DeleteHardbounces**](SMTPApi.md#deletehardbounces) | **POST** /smtp/deleteHardbounces | Delete hardbounces
[**DeleteSmtpTemplate**](SMTPApi.md#deletesmtptemplate) | **DELETE** /smtp/templates/{templateId} | Delete an inactive transactional email template
[**GetAggregatedSmtpReport**](SMTPApi.md#getaggregatedsmtpreport) | **GET** /smtp/statistics/aggregatedReport | Get your transactional email activity aggregated over a period of time
[**GetEmailEventReport**](SMTPApi.md#getemaileventreport) | **GET** /smtp/statistics/events | Get all your transactional email activity (unaggregated events)
[**GetSmtpReport**](SMTPApi.md#getsmtpreport) | **GET** /smtp/statistics/reports | Get your transactional email activity aggregated per day
[**GetSmtpTemplate**](SMTPApi.md#getsmtptemplate) | **GET** /smtp/templates/{templateId} | Returns the template informations
[**GetSmtpTemplates**](SMTPApi.md#getsmtptemplates) | **GET** /smtp/templates | Get the list of transactional email templates
[**GetTransacBlockedContacts**](SMTPApi.md#gettransacblockedcontacts) | **GET** /smtp/blockedContacts | Get the list of blocked or unsubscribed transactional contacts
[**GetTransacEmailContent**](SMTPApi.md#gettransacemailcontent) | **GET** /smtp/emails/{uuid} | Get the personalized content of a sent transactional email
[**GetTransacEmailsList**](SMTPApi.md#gettransacemailslist) | **GET** /smtp/emails | Get the list of transactional emails on the basis of allowed filters
[**SendTemplate**](SMTPApi.md#sendtemplate) | **POST** /smtp/templates/{templateId}/send | Send a template
[**SendTestTemplate**](SMTPApi.md#sendtesttemplate) | **POST** /smtp/templates/{templateId}/sendTest | Send a template to your test list
[**SendTransacEmail**](SMTPApi.md#sendtransacemail) | **POST** /smtp/email | Send a transactional email
[**SmtpBlockedContactsEmailDelete**](SMTPApi.md#smtpblockedcontactsemaildelete) | **DELETE** /smtp/blockedContacts/{email} | Unblock or resubscribe a transactional contact
[**SmtpLogMessageIdDelete**](SMTPApi.md#smtplogmessageiddelete) | **DELETE** /smtp/log/{messageId} | Delete an SMTP transactional log
[**UpdateSmtpTemplate**](SMTPApi.md#updatesmtptemplate) | **PUT** /smtp/templates/{templateId} | Updates a transactional email templates


<a name="createsmtptemplate"></a>
# **CreateSmtpTemplate**
> CreateModel CreateSmtpTemplate (CreateSmtpTemplate smtpTemplate)

Create a transactional email template

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CreateSmtpTemplateExample
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

            var apiInstance = new SMTPApi();
            var smtpTemplate = new CreateSmtpTemplate(); // CreateSmtpTemplate | values to update in transactional email template

            try
            {
                // Create a transactional email template
                CreateModel result = apiInstance.CreateSmtpTemplate(smtpTemplate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.CreateSmtpTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smtpTemplate** | [**CreateSmtpTemplate**](CreateSmtpTemplate.md)| values to update in transactional email template | 

### Return type

[**CreateModel**](CreateModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehardbounces"></a>
# **DeleteHardbounces**
> void DeleteHardbounces (DeleteHardbounces deleteHardbounces = null)

Delete hardbounces

Delete hardbounces. To use carefully (e.g. in case of temporary ISP failures)

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DeleteHardbouncesExample
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

            var apiInstance = new SMTPApi();
            var deleteHardbounces = new DeleteHardbounces(); // DeleteHardbounces | values to delete hardbounces (optional) 

            try
            {
                // Delete hardbounces
                apiInstance.DeleteHardbounces(deleteHardbounces);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.DeleteHardbounces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deleteHardbounces** | [**DeleteHardbounces**](DeleteHardbounces.md)| values to delete hardbounces | [optional] 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesmtptemplate"></a>
# **DeleteSmtpTemplate**
> void DeleteSmtpTemplate (long? templateId)

Delete an inactive transactional email template

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DeleteSmtpTemplateExample
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

            var apiInstance = new SMTPApi();
            var templateId = 789;  // long? | id of the template

            try
            {
                // Delete an inactive transactional email template
                apiInstance.DeleteSmtpTemplate(templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.DeleteSmtpTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **long?**| id of the template | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaggregatedsmtpreport"></a>
# **GetAggregatedSmtpReport**
> GetAggregatedReport GetAggregatedSmtpReport (string startDate = null, string endDate = null, int? days = null, string tag = null)

Get your transactional email activity aggregated over a period of time

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetAggregatedSmtpReportExample
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

            var apiInstance = new SMTPApi();
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate (optional) 
            var days = 56;  // int? | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var tag = tag_example;  // string | Tag of the emails (optional) 

            try
            {
                // Get your transactional email activity aggregated over a period of time
                GetAggregatedReport result = apiInstance.GetAggregatedSmtpReport(startDate, endDate, days, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.GetAggregatedSmtpReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate | [optional] 
 **days** | **int?**| Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional] 
 **tag** | **string**| Tag of the emails | [optional] 

### Return type

[**GetAggregatedReport**](GetAggregatedReport.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaileventreport"></a>
# **GetEmailEventReport**
> GetEmailEventReport GetEmailEventReport (long? limit = null, long? offset = null, string startDate = null, string endDate = null, int? days = null, string email = null, string _event = null, string tags = null, string messageId = null, long? templateId = null)

Get all your transactional email activity (unaggregated events)

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetEmailEventReportExample
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

            var apiInstance = new SMTPApi();
            var limit = 789;  // long? | Number limitation for the result returned (optional)  (default to 50)
            var offset = 789;  // long? | Beginning point in the list to retrieve from. (optional)  (default to 0)
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate (optional) 
            var days = 56;  // int? | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var email = email_example;  // string | Filter the report for a specific email addresses (optional) 
            var _event = _event_example;  // string | Filter the report for a specific event type (optional) 
            var tags = tags_example;  // string | Filter the report for tags (serialized and urlencoded array) (optional) 
            var messageId = messageId_example;  // string | Filter on a specific message id (optional) 
            var templateId = 789;  // long? | Filter on a specific template id (optional) 

            try
            {
                // Get all your transactional email activity (unaggregated events)
                GetEmailEventReport result = apiInstance.GetEmailEventReport(limit, offset, startDate, endDate, days, email, _event, tags, messageId, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.GetEmailEventReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number limitation for the result returned | [optional] [default to 50]
 **offset** | **long?**| Beginning point in the list to retrieve from. | [optional] [default to 0]
 **startDate** | **string**| Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate | [optional] 
 **days** | **int?**| Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional] 
 **email** | **string**| Filter the report for a specific email addresses | [optional] 
 **_event** | **string**| Filter the report for a specific event type | [optional] 
 **tags** | **string**| Filter the report for tags (serialized and urlencoded array) | [optional] 
 **messageId** | **string**| Filter on a specific message id | [optional] 
 **templateId** | **long?**| Filter on a specific template id | [optional] 

### Return type

[**GetEmailEventReport**](GetEmailEventReport.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmtpreport"></a>
# **GetSmtpReport**
> GetReports GetSmtpReport (long? limit = null, long? offset = null, string startDate = null, string endDate = null, int? days = null, string tag = null)

Get your transactional email activity aggregated per day

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetSmtpReportExample
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

            var apiInstance = new SMTPApi();
            var limit = 789;  // long? | Number of documents returned per page (optional)  (default to 10)
            var offset = 789;  // long? | Index of the first document on the page (optional)  (default to 0)
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD) (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD) (optional) 
            var days = 56;  // int? | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var tag = tag_example;  // string | Tag of the emails (optional) 

            try
            {
                // Get your transactional email activity aggregated per day
                GetReports result = apiInstance.GetSmtpReport(limit, offset, startDate, endDate, days, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.GetSmtpReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents returned per page | [optional] [default to 10]
 **offset** | **long?**| Index of the first document on the page | [optional] [default to 0]
 **startDate** | **string**| Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD) | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD) | [optional] 
 **days** | **int?**| Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional] 
 **tag** | **string**| Tag of the emails | [optional] 

### Return type

[**GetReports**](GetReports.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmtptemplate"></a>
# **GetSmtpTemplate**
> GetSmtpTemplateOverview GetSmtpTemplate (long? templateId)

Returns the template informations

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetSmtpTemplateExample
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

            var apiInstance = new SMTPApi();
            var templateId = 789;  // long? | id of the template

            try
            {
                // Returns the template informations
                GetSmtpTemplateOverview result = apiInstance.GetSmtpTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.GetSmtpTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **long?**| id of the template | 

### Return type

[**GetSmtpTemplateOverview**](GetSmtpTemplateOverview.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmtptemplates"></a>
# **GetSmtpTemplates**
> GetSmtpTemplates GetSmtpTemplates (bool? templateStatus = null, long? limit = null, long? offset = null)

Get the list of transactional email templates

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetSmtpTemplatesExample
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

            var apiInstance = new SMTPApi();
            var templateStatus = true;  // bool? | Filter on the status of the template. Active = true, inactive = false (optional) 
            var limit = 789;  // long? | Number of documents returned per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document in the page (optional)  (default to 0)

            try
            {
                // Get the list of transactional email templates
                GetSmtpTemplates result = apiInstance.GetSmtpTemplates(templateStatus, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.GetSmtpTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateStatus** | **bool?**| Filter on the status of the template. Active &#x3D; true, inactive &#x3D; false | [optional] 
 **limit** | **long?**| Number of documents returned per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document in the page | [optional] [default to 0]

### Return type

[**GetSmtpTemplates**](GetSmtpTemplates.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransacblockedcontacts"></a>
# **GetTransacBlockedContacts**
> GetTransacBlockedContacts GetTransacBlockedContacts (string startDate = null, string endDate = null, long? limit = null, long? offset = null, List<string> senders = null)

Get the list of blocked or unsubscribed transactional contacts

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetTransacBlockedContactsExample
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

            var apiInstance = new SMTPApi();
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the blocked or unsubscribed contacts (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the blocked or unsubscribed contacts (optional) 
            var limit = 789;  // long? | Number of documents returned per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document on the page (optional)  (default to 0)
            var senders = new List<string>(); // List<string> | Comma separated list of emails of the senders from which contacts are blocked or unsubscribed (optional) 

            try
            {
                // Get the list of blocked or unsubscribed transactional contacts
                GetTransacBlockedContacts result = apiInstance.GetTransacBlockedContacts(startDate, endDate, limit, offset, senders);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.GetTransacBlockedContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the blocked or unsubscribed contacts | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the blocked or unsubscribed contacts | [optional] 
 **limit** | **long?**| Number of documents returned per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document on the page | [optional] [default to 0]
 **senders** | [**List&lt;string&gt;**](string.md)| Comma separated list of emails of the senders from which contacts are blocked or unsubscribed | [optional] 

### Return type

[**GetTransacBlockedContacts**](GetTransacBlockedContacts.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransacemailcontent"></a>
# **GetTransacEmailContent**
> GetTransacEmailContent GetTransacEmailContent (string uuid)

Get the personalized content of a sent transactional email

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetTransacEmailContentExample
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

            var apiInstance = new SMTPApi();
            var uuid = uuid_example;  // string | Unique id of the transactional email that has been sent to a particular contact

            try
            {
                // Get the personalized content of a sent transactional email
                GetTransacEmailContent result = apiInstance.GetTransacEmailContent(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.GetTransacEmailContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| Unique id of the transactional email that has been sent to a particular contact | 

### Return type

[**GetTransacEmailContent**](GetTransacEmailContent.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransacemailslist"></a>
# **GetTransacEmailsList**
> GetTransacEmailsList GetTransacEmailsList (string email = null, long? templateId = null, string messageId = null, string startDate = null, DateTime? endDate = null)

Get the list of transactional emails on the basis of allowed filters

This endpoint will show the list of emails for past 30 days by default. To retrieve emails before that time, please pass startDate and endDate in query filters.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetTransacEmailsListExample
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

            var apiInstance = new SMTPApi();
            var email = email_example;  // string | Mandatory if templateId and messageId are not passed in query filters. Email address to which transactional email has been sent. (optional) 
            var templateId = 789;  // long? | Mandatory if email and messageId are not passed in query filters. Id of the template that was used to compose transactional email. (optional) 
            var messageId = messageId_example;  // string | Mandatory if templateId and email are not passed in query filters. Message ID of the transactional email sent. (optional) 
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 
            var endDate = 2013-10-20;  // DateTime? | Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 

            try
            {
                // Get the list of transactional emails on the basis of allowed filters
                GetTransacEmailsList result = apiInstance.GetTransacEmailsList(email, templateId, messageId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.GetTransacEmailsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Mandatory if templateId and messageId are not passed in query filters. Email address to which transactional email has been sent. | [optional] 
 **templateId** | **long?**| Mandatory if email and messageId are not passed in query filters. Id of the template that was used to compose transactional email. | [optional] 
 **messageId** | **string**| Mandatory if templateId and email are not passed in query filters. Message ID of the transactional email sent. | [optional] 
 **startDate** | **string**| Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Maximum time period that can be selected is one month. | [optional] 
 **endDate** | **DateTime?**| Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. | [optional] 

### Return type

[**GetTransacEmailsList**](GetTransacEmailsList.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtemplate"></a>
# **SendTemplate**
> SendTemplateEmail SendTemplate (long? templateId, SendEmail sendEmail)

Send a template

This endpoint is deprecated. Prefer v3/smtp/email instead.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class SendTemplateExample
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

            var apiInstance = new SMTPApi();
            var templateId = 789;  // long? | Id of the template
            var sendEmail = new SendEmail(); // SendEmail | 

            try
            {
                // Send a template
                SendTemplateEmail result = apiInstance.SendTemplate(templateId, sendEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.SendTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **long?**| Id of the template | 
 **sendEmail** | [**SendEmail**](SendEmail.md)|  | 

### Return type

[**SendTemplateEmail**](SendTemplateEmail.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtesttemplate"></a>
# **SendTestTemplate**
> void SendTestTemplate (long? templateId, SendTestEmail sendTestEmail)

Send a template to your test list

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class SendTestTemplateExample
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

            var apiInstance = new SMTPApi();
            var templateId = 789;  // long? | Id of the template
            var sendTestEmail = new SendTestEmail(); // SendTestEmail | 

            try
            {
                // Send a template to your test list
                apiInstance.SendTestTemplate(templateId, sendTestEmail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.SendTestTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **long?**| Id of the template | 
 **sendTestEmail** | [**SendTestEmail**](SendTestEmail.md)|  | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtransacemail"></a>
# **SendTransacEmail**
> CreateSmtpEmail SendTransacEmail (SendSmtpEmail sendSmtpEmail)

Send a transactional email

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class SendTransacEmailExample
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

            var apiInstance = new SMTPApi();
            var sendSmtpEmail = new SendSmtpEmail(); // SendSmtpEmail | Values to send a transactional email

            try
            {
                // Send a transactional email
                CreateSmtpEmail result = apiInstance.SendTransacEmail(sendSmtpEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.SendTransacEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sendSmtpEmail** | [**SendSmtpEmail**](SendSmtpEmail.md)| Values to send a transactional email | 

### Return type

[**CreateSmtpEmail**](CreateSmtpEmail.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smtpblockedcontactsemaildelete"></a>
# **SmtpBlockedContactsEmailDelete**
> void SmtpBlockedContactsEmailDelete (string email)

Unblock or resubscribe a transactional contact

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class SmtpBlockedContactsEmailDeleteExample
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

            var apiInstance = new SMTPApi();
            var email = email_example;  // string | contact email (urlencoded) to unblock.

            try
            {
                // Unblock or resubscribe a transactional contact
                apiInstance.SmtpBlockedContactsEmailDelete(email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.SmtpBlockedContactsEmailDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| contact email (urlencoded) to unblock. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smtplogmessageiddelete"></a>
# **SmtpLogMessageIdDelete**
> void SmtpLogMessageIdDelete (string messageId)

Delete an SMTP transactional log

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class SmtpLogMessageIdDeleteExample
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

            var apiInstance = new SMTPApi();
            var messageId = messageId_example;  // string | MessageId of the transactional log to delete

            try
            {
                // Delete an SMTP transactional log
                apiInstance.SmtpLogMessageIdDelete(messageId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.SmtpLogMessageIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| MessageId of the transactional log to delete | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesmtptemplate"></a>
# **UpdateSmtpTemplate**
> void UpdateSmtpTemplate (long? templateId, UpdateSmtpTemplate smtpTemplate)

Updates a transactional email templates

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class UpdateSmtpTemplateExample
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

            var apiInstance = new SMTPApi();
            var templateId = 789;  // long? | id of the template
            var smtpTemplate = new UpdateSmtpTemplate(); // UpdateSmtpTemplate | values to update in transactional email template

            try
            {
                // Updates a transactional email templates
                apiInstance.UpdateSmtpTemplate(templateId, smtpTemplate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SMTPApi.UpdateSmtpTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **long?**| id of the template | 
 **smtpTemplate** | [**UpdateSmtpTemplate**](UpdateSmtpTemplate.md)| values to update in transactional email template | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

