# sib_api_v3_sdk.Model.UpdateContact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Attributes** | **Object** | Pass the set of attributes to be updated. These attributes must be present in your account. To update existing email address of a contact with the new one please pass EMAIL in attributes. For example, &#x60;{ &quot;EMAIL&quot;:&quot;newemail@domain.com&quot;, &quot;FNAME&quot;:&quot;Ellie&quot;, &quot;LNAME&quot;:&quot;Roger&quot;}&#x60;. The attribute&#39;s parameter should be passed in capital letter while updating a contact. Keep in mind transactional attributes can be updated the same way as normal attributes. Mobile Number in &quot;SMS&quot; field should be passed with proper country code. For example {&quot;SMS&quot;:&quot;+91xxxxxxxxxx&quot;} or {&quot;SMS&quot;:&quot;0091xxxxxxxxxx&quot;} | [optional] 
**EmailBlacklisted** | **bool?** | Set/unset this field to blacklist/allow the contact for emails (emailBlacklisted &#x3D; true) | [optional] 
**SmsBlacklisted** | **bool?** | Set/unset this field to blacklist/allow the contact for SMS (smsBlacklisted &#x3D; true) | [optional] 
**ListIds** | **List&lt;long?&gt;** | Ids of the lists to add the contact to | [optional] 
**UnlinkListIds** | **List&lt;long?&gt;** | Ids of the lists to remove the contact from | [optional] 
**SmtpBlacklistSender** | **List&lt;string&gt;** | transactional email forbidden sender for contact. Use only for email Contact | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

