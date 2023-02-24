# sib_api_v3_sdk.Model.GetProductDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Product ID for which you requested the details | 
**Name** | **string** | Name of the product for which you requested the details | 
**CreatedAt** | **string** | Creation UTC date-time of the product (YYYY-MM-DDTHH:mm:ss.SSSZ) | 
**ModifiedAt** | **string** | Last modification UTC date-time of the product (YYYY-MM-DDTHH:mm:ss.SSSZ) | 
**Url** | **string** | URL to the product | [optional] 
**ImageUrl** | **string** | Absolute URL to the cover image of the product | [optional] 
**Sku** | **string** | Product identifier from the shop | [optional] 
**Price** | **float?** | Price of the product | [optional] 
**Categories** | **List&lt;string&gt;** | Category ID-s of the product | [optional] 
**ParentId** | **string** | Parent product id of the product | [optional] 
**S3Original** | **string** | S3 url of original image | [optional] 
**S3ThumbAnalytics** | **string** | S3 thumbnail url of original image in 120x120 dimension for analytics section | 
**MetaInfo** | **Object** | Meta data of product such as description, vendor, producer, stock level, etc. | [optional] 
**S3ThumbEditor** | **string** | S3 thumbnail url of original image in 600x400 dimension for editor section | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

