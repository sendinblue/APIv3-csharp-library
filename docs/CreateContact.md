# sib_api_v3_sdk.Model.CreateContact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Email address of the user. Mandatory if &quot;SMS&quot; field is not passed in &quot;attributes&quot; parameter. Mobile Number in &quot;SMS&quot; field should be passed with proper country code. For example {&quot;SMS&quot;:&quot;+91xxxxxxxxxx&quot;} or {&quot;SMS&quot;:&quot;0091xxxxxxxxxx&quot;} | [optional] 
**Attributes** | **Object** | Pass the set of attributes and their values. The attribute&#39;s parameter should be passed in capital letter while creating a contact. These attributes must be present in your SendinBlue account. For eg. {&quot;FNAME&quot;:&quot;Elly&quot;, &quot;LNAME&quot;:&quot;Roger&quot;} | [optional] 
**EmailBlacklisted** | **bool?** | Set this field to blacklist the contact for emails (emailBlacklisted &#x3D; true) | [optional] 
**SmsBlacklisted** | **bool?** | Set this field to blacklist the contact for SMS (smsBlacklisted &#x3D; true) | [optional] 
**ListIds** | **List&lt;long?&gt;** | Ids of the lists to add the contact to | [optional] 
**UpdateEnabled** | **bool?** | Facilitate to update the existing contact in the same request (updateEnabled &#x3D; true) | [optional] [default to false]
**SmtpBlacklistSender** | **List&lt;string&gt;** | transactional email forbidden sender for contact. Use only for email Contact ( only available if updateEnabled &#x3D; true ) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

