# sib_api_v3_sdk.Model.SendEmail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailTo** | **List&lt;string&gt;** | List of the email addresses of the recipients. For example, [&#39;abc@example.com&#39;, &#39;asd@example.com&#39;]. | 
**EmailBcc** | **List&lt;string&gt;** | List of the email addresses of the recipients in bcc | [optional] 
**EmailCc** | **List&lt;string&gt;** | List of the email addresses of the recipients in cc | [optional] 
**ReplyTo** | **string** | Email address which shall be used by campaign recipients to reply back | [optional] 
**AttachmentUrl** | **string** | Absolute url of the attachment (no local file). Extension allowed: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub and eps | [optional] 
**Attachment** | [**List&lt;SendEmailAttachment&gt;**](SendEmailAttachment.md) | Pass the list of content (base64 encoded) and name of the attachment. For example, [{&#39;content&#39;:&#39;base64 encoded content 1&#39;, &#39;name&#39;:&#39;attcahment1&#39;}, {&#39;content&#39;:&#39;base64 encoded content 2&#39;, &#39;name&#39;:&#39;attcahment2&#39;}]. | [optional] 
**Headers** | **Object** | Pass the set of headers that shall be sent along the mail headers in the original email. &#39;sender.ip&#39; header can be set (only for dedicated ip users) to mention the IP to be used for sending transactional emails. For example, {&#39;Content-Type&#39;:&#39;text/html&#39;, &#39;charset&#39;:&#39;iso-8859-1&#39;, &#39;sender.ip&#39;:&#39;1.2.3.4&#39;} | [optional] 
**Attributes** | **Object** | Pass the set of attributes to customize the template. For example, {&#39;FNAME&#39;:&#39;Joe&#39;, &#39;LNAME&#39;:&#39;Doe&#39;} | [optional] 
**Tags** | **List&lt;string&gt;** | Tag your emails to find them more easily | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

