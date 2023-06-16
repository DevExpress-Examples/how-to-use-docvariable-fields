<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611442/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3099)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to Use Document Variable (DOCVARIABLE) Fields to Insert Dynamic Content

The following example illustrates how to use the [DOCVARIABLE](https://docs.devexpress.com/OfficeFileAPI/15291/word-processing-document-api/fields/field-codes/docvariable) field and the [Document.CalculateDocVariable](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.CalculateDocumentVariable) event to insert dynamic content in a document.

In this example, a variable name specified in the DOCVARIABLE indicates a choice between location and weather, while the location itself is specified by the field argument.

> **Note:**
> We do not provide a code sample to retrieve weather information. You can implement a custom weather information provider.

The [MailMergeRecordStarted](https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.MailMergeRecordStarted) event is handled to insert a hidden document's creation date.

The **MyProgressIndicatorService** class is implemented and registered as a service to use the ProgressBar control.

## Files to Review

* [Form1.cs](./CS/DocumentVariablesExample/Form1.cs) (VB: [Form1.vb](./VB/DocumentVariablesExample/Form1.vb))
* [MyProgressIndicator.cs](./CS/DocumentVariablesExample/MyProgressIndicator.cs) (VB: [MyProgressIndicator.vb](./VB/DocumentVariablesExample/MyProgressIndicator.vb))

## Documentation

* [DOCVARIABLE](https://docs.devexpress.com/OfficeFileAPI/15291/word-processing-document-api/fields/field-codes/docvariable)
* [Document.CalculateDocVariable](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.Document.CalculateDocumentVariable)
* [How to: Insert Dynamic Content](https://docs.devexpress.com/OfficeFileAPI/401197/word-processing-document-api/examples/text/how-to-insert-dynamic-content)
