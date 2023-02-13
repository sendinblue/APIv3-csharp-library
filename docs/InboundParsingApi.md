# sib_api_v3_sdk.Api.InboundParsingApi

All URIs are relative to *https://api.sendinblue.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInboundEmailAttachment**](InboundParsingApi.md#getinboundemailattachment) | **GET** /inbound/attachments/{downloadToken} | Retrieve inbound attachment with download token.
[**GetInboundEmailEvents**](InboundParsingApi.md#getinboundemailevents) | **GET** /inbound/events | Get the list of all the events for the received emails.
[**GetInboundEmailEventsByUuid**](InboundParsingApi.md#getinboundemaileventsbyuuid) | **GET** /inbound/events/{uuid} | Fetch all events history for one particular received email.


<a name="getinboundemailattachment"></a>
# **GetInboundEmailAttachment**
> System.IO.Stream GetInboundEmailAttachment (string downloadToken)

Retrieve inbound attachment with download token.

This endpoint will retrieve inbound attachment with download token.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetInboundEmailAttachmentExample
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

            var apiInstance = new InboundParsingApi();
            var downloadToken = downloadToken_example;  // string | Token to fetch a particular attachment

            try
            {
                // Retrieve inbound attachment with download token.
                System.IO.Stream result = apiInstance.GetInboundEmailAttachment(downloadToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundParsingApi.GetInboundEmailAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **downloadToken** | **string**| Token to fetch a particular attachment | 

### Return type

**System.IO.Stream**

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinboundemailevents"></a>
# **GetInboundEmailEvents**
> GetInboundEmailEvents GetInboundEmailEvents (string sender = null, DateTime? startDate = null, DateTime? endDate = null, long? limit = null, long? offset = null, string sort = null)

Get the list of all the events for the received emails.

This endpoint will show the list of all the events for the received emails.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetInboundEmailEventsExample
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

            var apiInstance = new InboundParsingApi();
            var sender = sender_example;  // string | Email address of the sender. (optional) 
            var startDate = 2013-10-20;  // DateTime? | Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 
            var endDate = 2013-10-20;  // DateTime? | Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 
            var limit = 789;  // long? | Number of documents returned per page (optional)  (default to 100)
            var offset = 789;  // long? | Index of the first document on the page (optional)  (default to 0)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation (optional)  (default to desc)

            try
            {
                // Get the list of all the events for the received emails.
                GetInboundEmailEvents result = apiInstance.GetInboundEmailEvents(sender, startDate, endDate, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundParsingApi.GetInboundEmailEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sender** | **string**| Email address of the sender. | [optional] 
 **startDate** | **DateTime?**| Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Maximum time period that can be selected is one month. | [optional] 
 **endDate** | **DateTime?**| Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. | [optional] 
 **limit** | **long?**| Number of documents returned per page | [optional] [default to 100]
 **offset** | **long?**| Index of the first document on the page | [optional] [default to 0]
 **sort** | **string**| Sort the results in the ascending/descending order of record creation | [optional] [default to desc]

### Return type

[**GetInboundEmailEvents**](GetInboundEmailEvents.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinboundemaileventsbyuuid"></a>
# **GetInboundEmailEventsByUuid**
> GetInboundEmailEventsByUuid GetInboundEmailEventsByUuid (string uuid)

Fetch all events history for one particular received email.

This endpoint will show the list of all events history for one particular received email.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetInboundEmailEventsByUuidExample
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

            var apiInstance = new InboundParsingApi();
            var uuid = uuid_example;  // string | UUID to fetch events specific to recieved email

            try
            {
                // Fetch all events history for one particular received email.
                GetInboundEmailEventsByUuid result = apiInstance.GetInboundEmailEventsByUuid(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InboundParsingApi.GetInboundEmailEventsByUuid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| UUID to fetch events specific to recieved email | 

### Return type

[**GetInboundEmailEventsByUuid**](GetInboundEmailEventsByUuid.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

