# sib_api_v3_sdk.Api.WhatsappCampaignsApi

All URIs are relative to *https://api.sendinblue.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWhatsappCampaign**](WhatsappCampaignsApi.md#deletewhatsappcampaign) | **DELETE** /whatsappCampaigns/{campaignId} | Delete a whatsapp campaign
[**GetWhatsappCampaign**](WhatsappCampaignsApi.md#getwhatsappcampaign) | **GET** /whatsappCampaigns/{campaignId} | Get Whatsapp campaign Overview


<a name="deletewhatsappcampaign"></a>
# **DeleteWhatsappCampaign**
> void DeleteWhatsappCampaign (Object campaignId)

Delete a whatsapp campaign

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class DeleteWhatsappCampaignExample
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

            var apiInstance = new WhatsappCampaignsApi();
            var campaignId = new Object(); // Object | id of the campaign

            try
            {
                // Delete a whatsapp campaign
                apiInstance.DeleteWhatsappCampaign(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsappCampaignsApi.DeleteWhatsappCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | [**Object**](Object.md)| id of the campaign | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwhatsappcampaign"></a>
# **GetWhatsappCampaign**
> GetWhatsappCampaignOverview GetWhatsappCampaign (Object campaignId)

Get Whatsapp campaign Overview

### Example
```csharp
using System;
using System.Diagnostics;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Client;
using sib_api_v3_sdk.Model;

namespace Example
{
    public class GetWhatsappCampaignExample
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

            var apiInstance = new WhatsappCampaignsApi();
            var campaignId = new Object(); // Object | Id of the campaign

            try
            {
                // Get Whatsapp campaign Overview
                GetWhatsappCampaignOverview result = apiInstance.GetWhatsappCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsappCampaignsApi.GetWhatsappCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | [**Object**](Object.md)| Id of the campaign | 

### Return type

[**GetWhatsappCampaignOverview**](GetWhatsappCampaignOverview.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

