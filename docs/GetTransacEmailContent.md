# sib_api_v3_sdk.Model.GetTransacEmailContent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Email address to which transactional email has been sent | 
**Subject** | **string** | Subject of the sent email | 
**TemplateId** | **long?** | Id of the template | [optional] 
**Date** | **DateTime?** | Date on which transactional email was sent | 
**Events** | [**List&lt;GetTransacEmailContentEvents&gt;**](GetTransacEmailContentEvents.md) | Series of events which occurred on the transactional email | 
**Body** | **string** | Actual content of the transactional email that has been sent | 
**AttachmentCount** | **long?** | Count of the attachments that were sent in the email | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

