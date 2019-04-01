# sib_api_v3_sdk.Model.GetSmtpTemplateOverview
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | ID of the template | 
**Name** | **string** | Name of the template | 
**Subject** | **string** | Subject of the template | 
**IsActive** | **bool?** | Status of template (true&#x3D;active, false&#x3D;inactive) | 
**TestSent** | **bool?** | Status of test sending for the template (true&#x3D;test email has been sent, false&#x3D;test email has not been sent) | 
**Sender** | [**GetSmtpTemplateOverviewSender**](GetSmtpTemplateOverviewSender.md) |  | 
**ReplyTo** | **string** | Email defined as the \&quot;Reply to\&quot; for the template | 
**ToField** | **string** | Customisation of the \&quot;to\&quot; field for the template | 
**Tag** | **string** | Tag of the template | 
**HtmlContent** | **string** | HTML content of the template | 
**CreatedAt** | **DateTime?** | Creation UTC date-time of the template (YYYY-MM-DDTHH:mm:ss.SSSZ) | 
**ModifiedAt** | **DateTime?** | Last modification UTC date-time of the template (YYYY-MM-DDTHH:mm:ss.SSSZ) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

