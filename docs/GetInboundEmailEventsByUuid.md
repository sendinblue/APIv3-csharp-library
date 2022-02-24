# sib_api_v3_sdk.Model.GetInboundEmailEventsByUuid
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReceivedAt** | **DateTime?** | Date when email was received on SMTP relay | [optional] 
**DeliveredAt** | **DateTime?** | Date when email was delivered successfully to client’s webhook | [optional] 
**Recipient** | **string** | Recipient’s email address | [optional] 
**Sender** | **string** | Sender’s email address | [optional] 
**MessageId** | **string** | Value of the Message-ID header. This will be present only after the processing is done. | [optional] 
**Subject** | **string** | Value of the Subject header. This will be present only after the processing is done.  | [optional] 
**Attachments** | [**List&lt;GetInboundEmailEventsByUuidAttachments&gt;**](GetInboundEmailEventsByUuidAttachments.md) | List of attachments of the email. This will be present only after the processing is done. | [optional] 
**Logs** | [**List&lt;GetInboundEmailEventsByUuidLogs&gt;**](GetInboundEmailEventsByUuidLogs.md) | List of events/logs that describe the lifecycle of the email on SIB platform | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

