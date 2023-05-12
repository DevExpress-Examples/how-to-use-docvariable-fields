<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611442/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3099)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DocumentVariablesExample/Form1.cs) (VB: [Form1.vb](./VB/DocumentVariablesExample/Form1.vb))
* [MyProgressIndicator.cs](./CS/DocumentVariablesExample/MyProgressIndicator.cs) (VB: [MyProgressIndicator.vb](./VB/DocumentVariablesExample/MyProgressIndicator.vb))
<!-- default file list end -->
# How to use document variable (DOCVARIABLE) fields


<p>This example illustrates the use of a <strong>DOCVARIABLE </strong>field to provide additional information which is dependent on the value of a merged field. This technique is implemented so each merged document contains a weather report for a location that corresponds to the current data record.</p>
<p>NB: We do not provide code for retrieving weather information. You can implement a custom weather information provider.</p>
<p>The location is represented by a merge field. It is included as an argument within the DOCVARIABLE field. When the DOCVARIABLE field is updated, the <strong>DevExpress.XtraRichEdit.API.Native.Document.CalculateDocumentVariable</strong> event is triggered. A code within the event handler obtains the information on weather. It uses <u>e.VariableName</u> to get the name of the variable within the field, <u>e.Arguments</u> to get the location and returns the calculated result in <u>e.Value</u> property.<br /> The <strong>MailMergeRecordStarted</strong> event is handled to insert a hidden text indicating when the document is created. <br /> The <strong>MyProgressIndicatorService</strong> class is implemented and registered as a service to allow progress indication using the ProgressBar control.</p>


<h3>Description</h3>

Illustrates the use of&nbsp;<a href="http://help.devexpress.com/#WindowsForms/CustomDocument17168">locked field</a>&nbsp;feature to retain&nbsp;<strong>DOCVARIABLE </strong>field value after mail merge. When the field is locked, it is not updated during mail merge and the resulting document contains the DOCVARIABLE field with the original value. <br>Setting the <a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditFieldOptions_UpdateLockedFieldstopic">RichEditControl.Options.Fields.UpdateLockedFields</a>&nbsp;property to the<strong>&nbsp;UpdateLockedFields.Never</strong> value prevents locked fields from being updated by any means.&nbsp;<br>If you set the&nbsp;<a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditFieldOptions_UpdateLockedFieldstopic">RichEditControl.Options.Fields.UpdateLockedFields</a>&nbsp;property to the&nbsp;<strong>UpdateLockedFields.DocVariableOnly</strong> value, the&nbsp;<a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeFieldCollection_Updatetopic">Fields.Update</a>&nbsp;method will calculate only&nbsp;DOCVARIABLE&nbsp;fields.<br>DOCVARIABLE field calculation fires the&nbsp;<a href="http://help.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeDocument_CalculateDocumentVariabletopic">Document.CalculateDocVariable</a>&nbsp;event. By handling this event, you can change the field's value or leave it the same (to retain the value, set <strong>e.Value</strong> to the&nbsp;<strong>DocVariableValue.Current</strong> value).<br>When you run the project, perform the following steps.<br>1. Click <strong>Mail Merge</strong> to load&nbsp;the resulting document in another&nbsp;RichEditControl.<br>2. Click <strong>Show Field Codes</strong> to observe that the&nbsp;DOCVARIABLE field remains.<br>3. Modify the DOCVARIABLE field - remove the DO NOT CHANGE text.&nbsp;<br>4. Click <strong>Update Locked DOCVARIABLE Fields</strong> button to change the&nbsp;RichEditControl.Options.Fields.UpdateLockedFields option and&nbsp;update the field.

<br/>


