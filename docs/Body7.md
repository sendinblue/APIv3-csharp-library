# sib_api_v3_sdk.Model.Body7
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of task | [optional] 
**Duration** | **int?** | Duration of task in milliseconds [1 minute &#x3D; 60000 ms] | [optional] 
**TaskTypeId** | **string** | Id for type of task e.g Call / Email / Meeting etc. | [optional] 
**Date** | **DateTime?** | Task date/time | [optional] 
**Notes** | **string** | Notes added to a task | [optional] 
**Done** | **bool?** | Task marked as done | [optional] 
**AssignToId** | **string** | User id to whom task is assigned | [optional] 
**ContactsIds** | **List&lt;int?&gt;** | Contact ids for contacts linked to this task | [optional] 
**DealsIds** | **List&lt;string&gt;** | Deal ids for deals a task is linked to | [optional] 
**CompaniesIds** | **List&lt;string&gt;** | Companies ids for companies a task is linked to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

