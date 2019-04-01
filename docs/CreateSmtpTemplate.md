# sib_api_v3_sdk.Model.CreateSmtpTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tag** | **string** | Tag of the template | [optional] 
**Sender** | [**CreateSmtpTemplateSender**](CreateSmtpTemplateSender.md) |  | 
**TemplateName** | **string** | Name of the template | 
**HtmlContent** | **string** | Body of the message (HTML version). The field must have more than 10 characters. REQUIRED if htmlUrl is empty | [optional] 
**HtmlUrl** | **string** | Url which contents the body of the email message. REQUIRED if htmlContent is empty | [optional] 
**Subject** | **string** | Subject of the template | 
**ReplyTo** | **string** | Email on which campaign recipients will be able to reply to | [optional] 
**ToField** | **string** | To personalize the «To» Field. If you want to include the first name and last name of your recipient, add {FNAME} {LNAME}. These contact attributes must already exist in your SendinBlue account. If input parameter &#39;params&#39; used please use {{contact.FNAME}} {{contact.LNAME}} for personalization | [optional] 
**AttachmentUrl** | **string** | Absolute url of the attachment (no local file). Extension allowed: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub and eps | [optional] 
**IsActive** | **bool?** | Status of template. isActive &#x3D; true means template is active and isActive &#x3D; false means template is inactive | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

