# sib_api_v3_sdk.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID of the order. | 
**CreatedAt** | **string** | Event occurrence UTC date-time (YYYY-MM-DDTHH:mm:ssZ), when order is actually created. | 
**UpdatedAt** | **string** | Event updated UTC date-time (YYYY-MM-DDTHH:mm:ssZ), when the status of the order is actually changed/updated. | 
**Status** | **string** | State of the order. | 
**Amount** | **decimal?** | Total amount of the order, including all shipping expenses, tax and the price of items. | 
**Products** | [**List&lt;OrderProducts&gt;**](OrderProducts.md) |  | 
**Email** | **string** | Email of the contact, Mandatory if &quot;phone&quot; field is not passed in &quot;billing&quot; parameter. | [optional] 
**Billing** | [**OrderBilling**](OrderBilling.md) |  | [optional] 
**Coupons** | **List&lt;string&gt;** | Coupons applied to the order. Stored case insensitive. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

