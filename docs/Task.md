# sib_api_v3_sdk.Model.Task
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstContact** | [**Contact**](Contact.md) |  | [optional] 
**Id** | **string** | Unique task id | [optional] 
**TaskTypeId** | **string** | Id for type of task e.g Call / Email / Meeting etc. | 
**Name** | **string** | Name of task | 
**ContactsIds** | **List&lt;int?&gt;** | Contact ids for contacts linked to this task | [optional] 
**Contacts** | [**List&lt;Contact&gt;**](Contact.md) | Contact details for contacts linked to this task | [optional] 
**DealsIds** | **List&lt;string&gt;** | Deal ids for deals a task is linked to | [optional] 
**CompaniesIds** | **List&lt;string&gt;** | Companies ids for companies a task is linked to | [optional] 
**AssignToId** | **string** | User id to whom task is assigned | [optional] 
**Date** | **DateTime?** | Task date/time | 
**Duration** | **int?** | Duration of task | [optional] 
**Notes** | **string** | Notes added to a task | [optional] 
**Done** | **bool?** | Task marked as done | [optional] 
**Reminder** | [**TaskReminder**](TaskReminder.md) | Task reminder date/time for a task | [optional] 
**CreatedAt** | **DateTime?** | Task created date/time | [optional] 
**UpdatedAt** | **DateTime?** | Task update date/time | [optional] 
**Refs** | **Object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

