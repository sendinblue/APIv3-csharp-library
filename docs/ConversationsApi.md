# sib_api_v3_sdk.Api.ConversationsApi

All URIs are relative to *https://api.sendinblue.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConversationsAgentOnlinePingPost**](ConversationsApi.md#conversationsagentonlinepingpost) | **POST** /conversations/agentOnlinePing | Sets agent’s status to online for 2-3 minutes
[**ConversationsMessagesIdDelete**](ConversationsApi.md#conversationsmessagesiddelete) | **DELETE** /conversations/messages/{id} | Delete a message sent by an agent
[**ConversationsMessagesIdGet**](ConversationsApi.md#conversationsmessagesidget) | **GET** /conversations/messages/{id} | Get a message
[**ConversationsMessagesIdPut**](ConversationsApi.md#conversationsmessagesidput) | **PUT** /conversations/messages/{id} | Update a message sent by an agent
[**ConversationsMessagesPost**](ConversationsApi.md#conversationsmessagespost) | **POST** /conversations/messages | Send a message as an agent
[**ConversationsPushedMessagesIdDelete**](ConversationsApi.md#conversationspushedmessagesiddelete) | **DELETE** /conversations/pushedMessages/{id} | Delete an automated message
[**ConversationsPushedMessagesIdGet**](ConversationsApi.md#conversationspushedmessagesidget) | **GET** /conversations/pushedMessages/{id} | Get an automated message
[**ConversationsPushedMessagesIdPut**](ConversationsApi.md#conversationspushedmessagesidput) | **PUT** /conversations/pushedMessages/{id} | Update an automated message
[**ConversationsPushedMessagesPost**](ConversationsApi.md#conversationspushedmessagespost) | **POST** /conversations/pushedMessages | Send an automated message to a visitor


<a name="conversationsagentonlinepingpost"></a>
# **ConversationsAgentOnlinePingPost**
> void ConversationsAgentOnlinePingPost (Body12 body)

Sets agent’s status to online for 2-3 minutes

We recommend pinging this endpoint every minute for as long as the agent has to be considered online.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class ConversationsAgentOnlinePingPostExample
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

            var apiInstance = new ConversationsApi();
            var body = new Body12(); // Body12 | Agent fields.

            try
            {
                // Sets agent’s status to online for 2-3 minutes
                apiInstance.ConversationsAgentOnlinePingPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsAgentOnlinePingPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body12**](Body12.md)| Agent fields. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="conversationsmessagesiddelete"></a>
# **ConversationsMessagesIdDelete**
> void ConversationsMessagesIdDelete (string id)

Delete a message sent by an agent

Only agents’ messages can be deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class ConversationsMessagesIdDeleteExample
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

            var apiInstance = new ConversationsApi();
            var id = id_example;  // string | ID of the message

            try
            {
                // Delete a message sent by an agent
                apiInstance.ConversationsMessagesIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsMessagesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the message | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="conversationsmessagesidget"></a>
# **ConversationsMessagesIdGet**
> ConversationsMessage ConversationsMessagesIdGet (string id)

Get a message

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class ConversationsMessagesIdGetExample
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

            var apiInstance = new ConversationsApi();
            var id = id_example;  // string | ID of the message

            try
            {
                // Get a message
                ConversationsMessage result = apiInstance.ConversationsMessagesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsMessagesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the message | 

### Return type

[**ConversationsMessage**](ConversationsMessage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="conversationsmessagesidput"></a>
# **ConversationsMessagesIdPut**
> ConversationsMessage ConversationsMessagesIdPut (string id, Body9 body = null)

Update a message sent by an agent

Only agents’ messages can be edited.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class ConversationsMessagesIdPutExample
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

            var apiInstance = new ConversationsApi();
            var id = id_example;  // string | ID of the message
            var body = new Body9(); // Body9 |  (optional) 

            try
            {
                // Update a message sent by an agent
                ConversationsMessage result = apiInstance.ConversationsMessagesIdPut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsMessagesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the message | 
 **body** | [**Body9**](Body9.md)|  | [optional] 

### Return type

[**ConversationsMessage**](ConversationsMessage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="conversationsmessagespost"></a>
# **ConversationsMessagesPost**
> ConversationsMessage ConversationsMessagesPost (Body8 body)

Send a message as an agent

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class ConversationsMessagesPostExample
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

            var apiInstance = new ConversationsApi();
            var body = new Body8(); // Body8 | Message fields.

            try
            {
                // Send a message as an agent
                ConversationsMessage result = apiInstance.ConversationsMessagesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsMessagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body8**](Body8.md)| Message fields. | 

### Return type

[**ConversationsMessage**](ConversationsMessage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="conversationspushedmessagesiddelete"></a>
# **ConversationsPushedMessagesIdDelete**
> void ConversationsPushedMessagesIdDelete (string id)

Delete an automated message

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class ConversationsPushedMessagesIdDeleteExample
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

            var apiInstance = new ConversationsApi();
            var id = id_example;  // string | ID of the message

            try
            {
                // Delete an automated message
                apiInstance.ConversationsPushedMessagesIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsPushedMessagesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the message | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="conversationspushedmessagesidget"></a>
# **ConversationsPushedMessagesIdGet**
> ConversationsMessage ConversationsPushedMessagesIdGet (string id)

Get an automated message

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class ConversationsPushedMessagesIdGetExample
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

            var apiInstance = new ConversationsApi();
            var id = id_example;  // string | ID of the message sent previously

            try
            {
                // Get an automated message
                ConversationsMessage result = apiInstance.ConversationsPushedMessagesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsPushedMessagesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the message sent previously | 

### Return type

[**ConversationsMessage**](ConversationsMessage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="conversationspushedmessagesidput"></a>
# **ConversationsPushedMessagesIdPut**
> ConversationsMessage ConversationsPushedMessagesIdPut (string id, Body11 body)

Update an automated message

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class ConversationsPushedMessagesIdPutExample
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

            var apiInstance = new ConversationsApi();
            var id = id_example;  // string | ID of the message
            var body = new Body11(); // Body11 | 

            try
            {
                // Update an automated message
                ConversationsMessage result = apiInstance.ConversationsPushedMessagesIdPut(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsPushedMessagesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of the message | 
 **body** | [**Body11**](Body11.md)|  | 

### Return type

[**ConversationsMessage**](ConversationsMessage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="conversationspushedmessagespost"></a>
# **ConversationsPushedMessagesPost**
> ConversationsMessage ConversationsPushedMessagesPost (Body10 body)

Send an automated message to a visitor

Example of automated messages: order status, announce new features in your web app, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class ConversationsPushedMessagesPostExample
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

            var apiInstance = new ConversationsApi();
            var body = new Body10(); // Body10 | 

            try
            {
                // Send an automated message to a visitor
                ConversationsMessage result = apiInstance.ConversationsPushedMessagesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConversationsApi.ConversationsPushedMessagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body10**](Body10.md)|  | 

### Return type

[**ConversationsMessage**](ConversationsMessage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

