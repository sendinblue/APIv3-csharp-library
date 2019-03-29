# sib_api_v3_sdk.Model.UpdateSmtpTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tag** | **string** | Tag of the template | [optional] 
**Sender** | [**UpdateSmtpTemplateSender**](UpdateSmtpTemplateSender.md) |  | [optional] 
**TemplateName** | **string** | Name of the template | [optional] 
**HtmlContent** | **string** | Required if htmlUrl is empty. Body of the message (HTML must have more than 10 characters) | [optional] 
**HtmlUrl** | **string** | Required if htmlContent is empty. URL to the body of the email (HTML) | [optional] 
**Subject** | **string** | Subject of the email | [optional] 
**ReplyTo** | **string** | Email on which campaign recipients will be able to reply to | [optional] 
**ToField** | **string** | To personalize the «To» Field. If you want to include the first name and last name of your recipient, add {FNAME} {LNAME}. These contact attributes must already exist in your SendinBlue account. If input parameter &#39;params&#39; used please use {{contact.FNAME}} {{contact.LNAME}} for personalization | [optional] 
**AttachmentUrl** | **string** | Absolute url of the attachment (no local file). Extension allowed: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub and eps | [optional] 
**IsActive** | **bool?** | Status of the template. isActive &#x3D; false means template is inactive, isActive &#x3D; true means template is active | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

