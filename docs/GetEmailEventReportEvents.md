# sib_api_v3_sdk.Model.GetEmailEventReportEvents
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Email address which generates the event | 
**Date** | **DateTime?** | UTC date-time on which the event has been generated | 
**Subject** | **string** | Subject of the event | [optional] 
**MessageId** | **string** | Message ID which generated the event | 
**Event** | **string** | Event which occurred | 
**Reason** | **string** | Reason of bounce (only available if the event is hardbounce or softbounce) | [optional] 
**Tag** | **string** | Tag of the email which generated the event | [optional] 
**Ip** | **string** | IP from which the user has opened the email or clicked on the link (only available if the event is opened or clicks) | [optional] 
**Link** | **string** | The link which is sent to the user (only available if the event is requests or opened or clicks) | [optional] 
**From** | **string** | Sender email from which the emails are sent | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

