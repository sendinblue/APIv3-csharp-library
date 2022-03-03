# sib_api_v3_sdk.Model.RequestContactExport
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExportAttributes** | **List&lt;string&gt;** | List of all the attributes that you want to export. These attributes must be present in your contact database. For example, [&#39;fname&#39;, &#39;lname&#39;, &#39;email&#39;]. | [optional] 
**CustomContactFilter** | [**RequestContactExportCustomContactFilter**](RequestContactExportCustomContactFilter.md) |  | 
**NotifyUrl** | **string** | Webhook that will be called once the export process is finished. For reference, https://help.sendinblue.com/hc/en-us/articles/360007666479 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

