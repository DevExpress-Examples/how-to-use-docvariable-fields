<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611442/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3099)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DocumentVariablesExample/Form1.cs) (VB: [Form1.vb](./VB/DocumentVariablesExample/Form1.vb))
* [MyProgressIndicator.cs](./CS/DocumentVariablesExample/MyProgressIndicator.cs) (VB: [MyProgressIndicator.vb](./VB/DocumentVariablesExample/MyProgressIndicator.vb))
* [Program.cs](./CS/DocumentVariablesExample/Program.cs) (VB: [Program.vb](./VB/DocumentVariablesExample/Program.vb))
* [SampleData.cs](./CS/DocumentVariablesExample/SampleData.cs) (VB: [SampleData.vb](./VB/DocumentVariablesExample/SampleData.vb))
* [Weather.cs](./CS/DocumentVariablesExample/Weather.cs) (VB: [Weather.vb](./VB/DocumentVariablesExample/Weather.vb))
<!-- default file list end -->
# How to use document variable (DOCVARIABLE) fields


<p>This example illustrates the use of a <strong>DOCVARIABLE </strong>field to provide additional information which is dependent on the value of a merged field. This technique is implemented so each merged document contains a weather report for a location that corresponds to the current data record.</p>
<p>NB: We do not provide code for retrieving weather information. You can implement a custom weather information provider.</p>
<p>The location is represented by a merge field. It is included as an argument within the DOCVARIABLE field. When the DOCVARIABLE field is updated, the <strong>DevExpress.XtraRichEdit.API.Native.Document.CalculateDocumentVariable</strong> event is triggered. A code within the event handler obtains the information on weather. It uses <u>e.VariableName</u> to get the name of the variable within the field, <u>e.Arguments</u> to get the location and returns the calculated result in <u>e.Value</u> property.<br /> The <strong>MailMergeRecordStarted</strong> event is handled to insert a hidden text indicating when the document is created. <br /> The <strong>MyProgressIndicatorService</strong> class is implemented and registered as a service to allow progress indication using the ProgressBar control.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-docvariable-fields&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-docvariable-fields&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
