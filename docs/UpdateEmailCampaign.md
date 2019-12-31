# sib_api_v3_sdk.Model.UpdateEmailCampaign
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tag** | **string** | Tag of the campaign | [optional] 
**Sender** | [**UpdateEmailCampaignSender**](UpdateEmailCampaignSender.md) |  | [optional] 
**Name** | **string** | Name of the campaign | [optional] 
**HtmlContent** | **string** | Body of the message (HTML version). REQUIRED if htmlUrl is empty | [optional] 
**HtmlUrl** | **string** | Url which contents the body of the email message. REQUIRED if htmlContent is empty | [optional] 
**ScheduledAt** | **DateTime?** | UTC date-time on which the campaign has to run (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. If sendAtBestTime is set to true, your campaign will be sent according to the date passed (ignoring the time part). | [optional] 
**Subject** | **string** | Subject of the campaign | [optional] 
**ReplyTo** | **string** | Email on which campaign recipients will be able to reply to | [optional] 
**ToField** | **string** | To personalize the «To» Field. If you want to include the first name and last name of your recipient, add {FNAME} {LNAME}. These contact attributes must already exist in your SendinBlue account. If input parameter &#39;params&#39; used please use {{contact.FNAME}} {{contact.LNAME}} for personalization | [optional] 
**Recipients** | [**UpdateEmailCampaignRecipients**](UpdateEmailCampaignRecipients.md) |  | [optional] 
**AttachmentUrl** | **string** | Absolute url of the attachment (no local file). Extension allowed: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub and eps | [optional] 
**InlineImageActivation** | **bool?** | Status of inline image. inlineImageActivation &#x3D; false means image can’t be embedded, &amp; inlineImageActivation &#x3D; true means image can be embedded, in the email. You cannot send a campaign of more than 4MB with images embedded in the email. Campaigns with the images embedded in the email must be sent to less than 5000 contacts. | [optional] [default to false]
**MirrorActive** | **bool?** | Status of mirror links in campaign. mirrorActive &#x3D; false means mirror links are deactivated, &amp; mirrorActive &#x3D; true means mirror links are activated, in the campaign | [optional] 
**Recurring** | **bool?** | FOR TRIGGER ONLY ! Type of trigger campaign.recurring &#x3D; false means contact can receive the same Trigger campaign only once, &amp; recurring &#x3D; true means contact can receive the same Trigger campaign several times | [optional] [default to false]
**Footer** | **string** | Footer of the email campaign | [optional] 
**Header** | **string** | Header of the email campaign | [optional] 
**UtmCampaign** | **string** | Customize the utm_campaign value. If this field is empty, the campaign name will be used. Only alphanumeric characters and spaces are allowed | [optional] 
**Params** | **Object** | Pass the set of attributes to customize the type &#39;classic&#39; campaign. For example, {&#39;FNAME&#39;:&#39;Joe&#39;, &#39;LNAME&#39;:&#39;Doe&#39;}. The &#39;params&#39; field will get updated, only if the campaign is in New Template Language, else ignored. The New Template Language is dependent on the values of &#39;subject&#39;, &#39;htmlContent/htmlUrl&#39;, &#39;sender.name&#39; &amp; &#39;toField&#39; | [optional] 
**SendAtBestTime** | **bool?** | Set this to true if you want to send your campaign at best time. Note:- if true, warmup ip will be disabled. | [optional] 
**AbTesting** | **bool?** | Status of A/B Test. abTesting &#x3D; false means it is disabled, &amp; abTesting &#x3D; true means it is enabled. &#39;subjectA&#39;, &#39;subjectB&#39;, &#39;splitRule&#39;, &#39;winnerCriteria&#39; &amp; &#39;winnerDelay&#39; will be considered if abTesting is set to true. &#39;subject&#39; if passed is ignored.  Can be set to true only if &#39;sendAtBestTime&#39; is &#39;false&#39;. You will be able to set up two subject lines for your campaign and send them to a random sample of your total recipients. Half of the test group will receive version A, and the other half will receive version B | [optional] [default to false]
**SubjectA** | **string** | Subject A of the campaign. Considered if abTesting &#x3D; true. subjectA &amp; subjectB should have unique value | [optional] 
**SubjectB** | **string** | Subject B of the campaign. Considered if abTesting &#x3D; true. subjectA &amp; subjectB should have unique value | [optional] 
**SplitRule** | **long?** | Add the size of your test groups. Considered if abTesting &#x3D; true. We&#39;ll send version A and B to a random sample of recipients, and then the winning version to everyone else | [optional] 
**WinnerCriteria** | **string** | Choose the metrics that will determinate the winning version. Considered if &#39;splitRule&#39; &gt;&#x3D; 1 and &lt; 50. If splitRule &#x3D; 50, &#39;winnerCriteria&#39; is ignored if passed or alreday exist in record | [optional] 
**WinnerDelay** | **long?** | Choose the duration of the test in hours. Maximum is 7 days, pass 24*7 &#x3D; 168 hours. The winning version will be sent at the end of the test. Considered if &#39;splitRule&#39; &gt;&#x3D; 1 and &lt; 50. If splitRule &#x3D; 50, &#39;winnerDelay&#39; is ignored if passed or alreday exist in record | [optional] 
**IpWarmupEnable** | **bool?** | Available for dedicated ip clients. Set this to true if you wish to warm up your ip. | [optional] [default to false]
**InitialQuota** | **long?** | Set an initial quota greater than 1 for warming up your ip. We recommend you set a value of 3000. | [optional] 
**IncreaseRate** | **long?** | Set a percentage increase rate for warming up your ip. We recommend you set the increase rate to 30% per day. If you want to send the same number of emails every day, set the daily increase value to 0%. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

