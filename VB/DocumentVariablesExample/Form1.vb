Imports System
Imports System.Drawing
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Services

#End Region  ' #usings
Namespace DocumentVariablesExample

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private richEdit As RichEditControl

        Public Sub New()
            InitializeComponent()
            richEditControl1.LoadDocument("Docs\invitation.docx")
            LockFields()
            richEditControl1.Options.MailMerge.DataSource = New SampleData()
            AddHandler richEditControl2.Document.CalculateDocumentVariable, New CalculateDocumentVariableEventHandler(AddressOf eventHandler_CalculateDocumentVariable)
            richEdit = richEditControl1
        End Sub

        Private Sub LockFields()
#Region "#lockfields"
            richEditControl1.Document.Fields(0).Locked = True
            richEditControl2.Options.Fields.UpdateLockedFields = UpdateLockedFields.Never
#End Region  ' #lockfields
        End Sub

        Private Sub btnMailMerge_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim myMergeOptions As MailMergeOptions = richEditControl1.Document.CreateMailMergeOptions()
            myMergeOptions.MergeMode = MergeMode.NewSection
            Cursor = Cursors.WaitCursor
            richEditControl1.Document.MailMerge(myMergeOptions, richEditControl2.Document)
            Cursor = Cursors.Default
            xtraTabControl1.SelectedTabPageIndex = 1
        End Sub

#Region "#servicesubst"
        Private Sub richEditControl1_MailMergeStarted(ByVal sender As Object, ByVal e As MailMergeStartedEventArgs)
            richEditControl1.RemoveService(GetType(IProgressIndicationService))
            richEditControl1.AddService(GetType(IProgressIndicationService), New MyProgressIndicatorService(richEditControl1, progressBarControl1))
        End Sub

#End Region  ' #servicesubst
        Private Sub richEditControl1_MailMergeFinished(ByVal sender As Object, ByVal e As MailMergeFinishedEventArgs)
            richEditControl1.RemoveService(GetType(IProgressIndicationService))
        End Sub

#Region "#mailmergerecordstarted"
        Private Sub richEditControl1_MailMergeRecordStarted(ByVal sender As Object, ByVal e As MailMergeRecordStartedEventArgs)
            Dim _range As DocumentRange = e.RecordDocument.InsertText(e.RecordDocument.Range.Start, String.Format("Created on {0:G}" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf, Date.Now))
            Dim cp As CharacterProperties = e.RecordDocument.BeginUpdateCharacters(_range)
            cp.FontSize = 8
            cp.ForeColor = Color.Red
            cp.Hidden = True
            e.RecordDocument.EndUpdateCharacters(cp)
        End Sub

#End Region  ' #mailmergerecordstarted
#Region "#mailmergerecordfinished"
        Private Sub richEditControl1_MailMergeRecordFinished(ByVal sender As Object, ByVal e As MailMergeRecordFinishedEventArgs)
            e.RecordDocument.AppendDocumentContent("Docs\bungalow.docx", DocumentFormat.OpenXml)
        End Sub

#End Region  ' #mailmergerecordfinished
#Region "#calculatedocumentvariable"
        Private Sub eventHandler_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            Dim location As String = e.Arguments(0).Value.ToString()
            If(Equals(location.Trim(), String.Empty)) OrElse location.Contains("<") Then
                e.Value = " "
                e.Handled = True
                Return
            End If

            Select Case e.VariableName
                Case "Weather"
                    Dim conditions As Conditions = New Conditions()
                    conditions = Weather.GetCurrentConditions(location)
                    e.Value = String.Format("Weather for {0}: " & Microsoft.VisualBasic.Constants.vbLf & "Conditions: {1}" & Microsoft.VisualBasic.Constants.vbLf & "Temperature (C) :{2}" & Microsoft.VisualBasic.Constants.vbLf & "Humidity: {3}" & Microsoft.VisualBasic.Constants.vbLf & "Wind: {4}" & Microsoft.VisualBasic.Constants.vbLf, location, conditions.Condition, conditions.TempC, conditions.Humidity, conditions.Wind)
                Case "LOCATION"
                    If Equals(location, "DO NOT CHANGE!") Then e.Value = DocVariableValue.Current
            End Select

            e.Handled = True
        End Sub

#End Region  ' #calculatedocumentvariable
        Private Sub btnUpdateDocVariableFields_Click(ByVal sender As Object, ByVal e As EventArgs)
#Region "#updatedocvariablefields"
            richEditControl2.Options.Fields.UpdateLockedFields = UpdateLockedFields.DocVariableOnly
            richEditControl2.Document.Fields.Update()
#End Region  ' #updatedocvariablefields
        End Sub

        Private Sub xtraTabControl1_Selected(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageEventArgs)
            Select Case e.PageIndex
                Case 0
                    richEdit = richEditControl1
                    btnMailMerge.Enabled = True
                Case 1
                    richEdit = richEditControl2
                    btnMailMerge.Enabled = False
            End Select
        End Sub

        Private Sub btn_ShowCodes_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim doc As Document = richEdit.Document
            Dim showCodes As Boolean = btn_ShowCodes.Checked
            doc.BeginUpdate()
            For Each f As Field In doc.Fields
                f.ShowCodes = showCodes
            Next

            doc.EndUpdate()
        End Sub

        Private Sub btn_ShowHiddenText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            richEdit.Options.FormattingMarkVisibility.HiddenText = If(btn_ShowHiddenText.Checked, RichEditFormattingMarkVisibility.Visible, RichEditFormattingMarkVisibility.Hidden)
        End Sub
    End Class
End Namespace
