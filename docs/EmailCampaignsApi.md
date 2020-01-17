# sib_api_v3_sdk.Api.EmailCampaignsApi

All URIs are relative to *https://api.sendinblue.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEmailCampaign**](EmailCampaignsApi.md#createemailcampaign) | **POST** /emailCampaigns | Create an email campaign
[**DeleteEmailCampaign**](EmailCampaignsApi.md#deleteemailcampaign) | **DELETE** /emailCampaigns/{campaignId} | Delete an email campaign
[**EmailExportRecipients**](EmailCampaignsApi.md#emailexportrecipients) | **POST** /emailCampaigns/{campaignId}/exportRecipients | Export the recipients of a campaign
[**GetAbTestCampaignResult**](EmailCampaignsApi.md#getabtestcampaignresult) | **GET** /emailCampaigns/{campaignId}/abTestCampaignResult | Get A/B test email campaign result
[**GetEmailCampaign**](EmailCampaignsApi.md#getemailcampaign) | **GET** /emailCampaigns/{campaignId} | Get campaign informations
[**GetEmailCampaigns**](EmailCampaignsApi.md#getemailcampaigns) | **GET** /emailCampaigns | Return all your created campaigns
[**GetSharedTemplateUrl**](EmailCampaignsApi.md#getsharedtemplateurl) | **GET** /emailCampaigns/{campaignId}/sharedUrl | Get a shared template url
[**SendEmailCampaignNow**](EmailCampaignsApi.md#sendemailcampaignnow) | **POST** /emailCampaigns/{campaignId}/sendNow | Send an email campaign immediately, based on campaignId
[**SendReport**](EmailCampaignsApi.md#sendreport) | **POST** /emailCampaigns/{campaignId}/sendReport | Send the report of a campaigns
[**SendTestEmail**](EmailCampaignsApi.md#sendtestemail) | **POST** /emailCampaigns/{campaignId}/sendTest | Send an email campaign to your test list
[**UpdateCampaignStatus**](EmailCampaignsApi.md#updatecampaignstatus) | **PUT** /emailCampaigns/{campaignId}/status | Update a campaign status
[**UpdateEmailCampaign**](EmailCampaignsApi.md#updateemailcampaign) | **PUT** /emailCampaigns/{campaignId} | Update a campaign


<a name="createemailcampaign"></a>
# **CreateEmailCampaign**
> CreateModel CreateEmailCampaign (CreateEmailCampaign emailCampaigns)

Create an email campaign

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class CreateEmailCampaignExample
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

            var apiInstance = new EmailCampaignsApi();
            var emailCampaigns = new CreateEmailCampaign(); // CreateEmailCampaign | Values to create a campaign

            try
            {
                // Create an email campaign
                CreateModel result = apiInstance.CreateEmailCampaign(emailCampaigns);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.CreateEmailCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailCampaigns** | [**CreateEmailCampaign**](CreateEmailCampaign.md)| Values to create a campaign | 

### Return type

[**CreateModel**](CreateModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemailcampaign"></a>
# **DeleteEmailCampaign**
> void DeleteEmailCampaign (long? campaignId)

Delete an email campaign

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DeleteEmailCampaignExample
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

            var apiInstance = new EmailCampaignsApi();
            var campaignId = 789;  // long? | id of the campaign

            try
            {
                // Delete an email campaign
                apiInstance.DeleteEmailCampaign(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.DeleteEmailCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| id of the campaign | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emailexportrecipients"></a>
# **EmailExportRecipients**
> CreatedProcessId EmailExportRecipients (long? campaignId, EmailExportRecipients recipientExport = null)

Export the recipients of a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class EmailExportRecipientsExample
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

            var apiInstance = new EmailCampaignsApi();
            var campaignId = 789;  // long? | Id of the campaign
            var recipientExport = new EmailExportRecipients(); // EmailExportRecipients | Values to send for a recipient export request (optional) 

            try
            {
                // Export the recipients of a campaign
                CreatedProcessId result = apiInstance.EmailExportRecipients(campaignId, recipientExport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.EmailExportRecipients: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the campaign | 
 **recipientExport** | [**EmailExportRecipients**](EmailExportRecipients.md)| Values to send for a recipient export request | [optional] 

### Return type

[**CreatedProcessId**](CreatedProcessId.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getabtestcampaignresult"></a>
# **GetAbTestCampaignResult**
> AbTestCampaignResult GetAbTestCampaignResult (long? campaignId)

Get A/B test email campaign result

Obtain winning version of an A/B test email campaign

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetAbTestCampaignResultExample
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

            var apiInstance = new EmailCampaignsApi();
            var campaignId = 789;  // long? | Id of the A/B test campaign

            try
            {
                // Get A/B test email campaign result
                AbTestCampaignResult result = apiInstance.GetAbTestCampaignResult(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetAbTestCampaignResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the A/B test campaign | 

### Return type

[**AbTestCampaignResult**](AbTestCampaignResult.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcampaign"></a>
# **GetEmailCampaign**
> GetEmailCampaign GetEmailCampaign (long? campaignId)

Get campaign informations

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetEmailCampaignExample
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

            var apiInstance = new EmailCampaignsApi();
            var campaignId = 789;  // long? | Id of the campaign

            try
            {
                // Get campaign informations
                GetEmailCampaign result = apiInstance.GetEmailCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the campaign | 

### Return type

[**GetEmailCampaign**](GetEmailCampaign.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemailcampaigns"></a>
# **GetEmailCampaigns**
> GetEmailCampaigns GetEmailCampaigns (string type = null, string status = null, DateTime? startDate = null, DateTime? endDate = null, long? limit = null, long? offset = null)

Return all your created campaigns

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetEmailCampaignsExample
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

            var apiInstance = new EmailCampaignsApi();
            var type = type_example;  // string | Filter on the type of the campaigns (optional) 
            var status = status_example;  // string | Filter on the status of the campaign (optional) 
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Mandatory if endDate is used. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent email campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either 'status' not passed and if passed is set to 'sent' ) (optional) 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | Mandatory if startDate is used. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent email campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either 'status' not passed and if passed is set to 'sent' ) (optional) 
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 500)
            var offset = 789;  // long? | Index of the first document in the page (optional)  (default to 0)

            try
            {
                // Return all your created campaigns
                GetEmailCampaigns result = apiInstance.GetEmailCampaigns(type, status, startDate, endDate, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Filter on the type of the campaigns | [optional] 
 **status** | **string**| Filter on the status of the campaign | [optional] 
 **startDate** | **DateTime?**| Mandatory if endDate is used. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent email campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either &#39;status&#39; not passed and if passed is set to &#39;sent&#39; ) | [optional] 
 **endDate** | **DateTime?**| Mandatory if startDate is used. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent email campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either &#39;status&#39; not passed and if passed is set to &#39;sent&#39; ) | [optional] 
 **limit** | **long?**| Number of documents per page | [optional] [default to 500]
 **offset** | **long?**| Index of the first document in the page | [optional] [default to 0]

### Return type

[**GetEmailCampaigns**](GetEmailCampaigns.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsharedtemplateurl"></a>
# **GetSharedTemplateUrl**
> GetSharedTemplateUrl GetSharedTemplateUrl (long? campaignId)

Get a shared template url

Get a unique URL to share & import an email template from one Sendinblue account to another.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetSharedTemplateUrlExample
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

            var apiInstance = new EmailCampaignsApi();
            var campaignId = 789;  // long? | Id of the campaign or template

            try
            {
                // Get a shared template url
                GetSharedTemplateUrl result = apiInstance.GetSharedTemplateUrl(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetSharedTemplateUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the campaign or template | 

### Return type

[**GetSharedTemplateUrl**](GetSharedTemplateUrl.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendemailcampaignnow"></a>
# **SendEmailCampaignNow**
> void SendEmailCampaignNow (long? campaignId)

Send an email campaign immediately, based on campaignId

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class SendEmailCampaignNowExample
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

            var apiInstance = new EmailCampaignsApi();
            var campaignId = 789;  // long? | Id of the campaign

            try
            {
                // Send an email campaign immediately, based on campaignId
                apiInstance.SendEmailCampaignNow(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.SendEmailCampaignNow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the campaign | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendreport"></a>
# **SendReport**
> void SendReport (long? campaignId, SendReport sendReport)

Send the report of a campaigns

A PDF will be sent to the specified email addresses

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class SendReportExample
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

            var apiInstance = new EmailCampaignsApi();
            var campaignId = 789;  // long? | Id of the campaign
            var sendReport = new SendReport(); // SendReport | Values for send a report

            try
            {
                // Send the report of a campaigns
                apiInstance.SendReport(campaignId, sendReport);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.SendReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the campaign | 
 **sendReport** | [**SendReport**](SendReport.md)| Values for send a report | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtestemail"></a>
# **SendTestEmail**
> void SendTestEmail (long? campaignId, SendTestEmail emailTo)

Send an email campaign to your test list

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class SendTestEmailExample
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

            var apiInstance = new EmailCampaignsApi();
            var campaignId = 789;  // long? | Id of the campaign
            var emailTo = new SendTestEmail(); // SendTestEmail | 

            try
            {
                // Send an email campaign to your test list
                apiInstance.SendTestEmail(campaignId, emailTo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.SendTestEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the campaign | 
 **emailTo** | [**SendTestEmail**](SendTestEmail.md)|  | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecampaignstatus"></a>
# **UpdateCampaignStatus**
> void UpdateCampaignStatus (long? campaignId, UpdateCampaignStatus status)

Update a campaign status

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class UpdateCampaignStatusExample
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

            var apiInstance = new EmailCampaignsApi();
            var campaignId = 789;  // long? | Id of the campaign
            var status = new UpdateCampaignStatus(); // UpdateCampaignStatus | Status of the campaign

            try
            {
                // Update a campaign status
                apiInstance.UpdateCampaignStatus(campaignId, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.UpdateCampaignStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the campaign | 
 **status** | [**UpdateCampaignStatus**](UpdateCampaignStatus.md)| Status of the campaign | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateemailcampaign"></a>
# **UpdateEmailCampaign**
> void UpdateEmailCampaign (long? campaignId, UpdateEmailCampaign emailCampaign)

Update a campaign

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class UpdateEmailCampaignExample
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

            var apiInstance = new EmailCampaignsApi();
            var campaignId = 789;  // long? | Id of the campaign
            var emailCampaign = new UpdateEmailCampaign(); // UpdateEmailCampaign | Values to update a campaign

            try
            {
                // Update a campaign
                apiInstance.UpdateEmailCampaign(campaignId, emailCampaign);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.UpdateEmailCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the campaign | 
 **emailCampaign** | [**UpdateEmailCampaign**](UpdateEmailCampaign.md)| Values to update a campaign | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

