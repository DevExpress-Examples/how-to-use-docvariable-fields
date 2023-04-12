Namespace DocumentVariablesExample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.richEditControl2 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.btnUpdateDocVariableFields = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_ShowHiddenText = New DevExpress.XtraEditors.CheckButton()
            Me.btn_ShowCodes = New DevExpress.XtraEditors.CheckButton()
            Me.btnMailMerge = New DevExpress.XtraEditors.SimpleButton()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.xtraTabPage2.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' progressBarControl1
            ' 
            Me.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.progressBarControl1.Location = New System.Drawing.Point(0, 713)
            Me.progressBarControl1.Name = "progressBarControl1"
            Me.progressBarControl1.Size = New System.Drawing.Size(784, 18)
            Me.progressBarControl1.TabIndex = 1
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 111)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(784, 602)
            Me.xtraTabControl1.TabIndex = 2
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2})
            AddHandler Me.xtraTabControl1.Selected, New DevExpress.XtraTab.TabPageEventHandler(AddressOf Me.xtraTabControl1_Selected)
            ' 
            ' xtraTabPage1
            ' 
            Me.xtraTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.xtraTabPage1.Controls.Add(Me.richEditControl1)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(782, 577)
            Me.xtraTabPage1.Text = "Template"
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Always
            Me.richEditControl1.Size = New System.Drawing.Size(782, 577)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            AddHandler Me.richEditControl1.CalculateDocumentVariable, New DevExpress.XtraRichEdit.CalculateDocumentVariableEventHandler(AddressOf Me.eventHandler_CalculateDocumentVariable)
            AddHandler Me.richEditControl1.MailMergeStarted, New DevExpress.XtraRichEdit.MailMergeStartedEventHandler(AddressOf Me.richEditControl1_MailMergeStarted)
            AddHandler Me.richEditControl1.MailMergeRecordStarted, New DevExpress.XtraRichEdit.MailMergeRecordStartedEventHandler(AddressOf Me.richEditControl1_MailMergeRecordStarted)
            AddHandler Me.richEditControl1.MailMergeRecordFinished, New DevExpress.XtraRichEdit.MailMergeRecordFinishedEventHandler(AddressOf Me.richEditControl1_MailMergeRecordFinished)
            AddHandler Me.richEditControl1.MailMergeFinished, New DevExpress.XtraRichEdit.MailMergeFinishedEventHandler(AddressOf Me.richEditControl1_MailMergeFinished)
            ' 
            ' xtraTabPage2
            ' 
            Me.xtraTabPage2.Controls.Add(Me.richEditControl2)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Size = New System.Drawing.Size(782, 541)
            Me.xtraTabPage2.Text = "Result"
            ' 
            ' richEditControl2
            ' 
            Me.richEditControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl2.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl2.Name = "richEditControl2"
            Me.richEditControl2.Size = New System.Drawing.Size(782, 541)
            Me.richEditControl2.TabIndex = 0
            Me.richEditControl2.Text = "richEditControl2"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.btnUpdateDocVariableFields)
            Me.panelControl1.Controls.Add(Me.btn_ShowHiddenText)
            Me.panelControl1.Controls.Add(Me.btn_ShowCodes)
            Me.panelControl1.Controls.Add(Me.btnMailMerge)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(784, 111)
            Me.panelControl1.TabIndex = 3
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Location = New System.Drawing.Point(13, 38)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(390, 67)
            Me.labelControl1.TabIndex = 6
            Me.labelControl1.Text = "1. Click Mail Merge " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "2. Click Show Field Codes" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "3. Modify DOCVARIABLE field - re" & "move the DO NOT CHANGE text" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "4. Click Update Locked DOCVARIABLE Fields" & Global.Microsoft.VisualBasic.Constants.vbCrLf
            ' 
            ' btnUpdateDocVariableFields
            ' 
            Me.btnUpdateDocVariableFields.Enabled = False
            Me.btnUpdateDocVariableFields.Location = New System.Drawing.Point(569, 8)
            Me.btnUpdateDocVariableFields.Name = "btnUpdateDocVariableFields"
            Me.btnUpdateDocVariableFields.Size = New System.Drawing.Size(190, 23)
            Me.btnUpdateDocVariableFields.TabIndex = 5
            Me.btnUpdateDocVariableFields.Text = "Update Locked DOCVARIABLE Fields"
            AddHandler Me.btnUpdateDocVariableFields.Click, New System.EventHandler(AddressOf Me.btnUpdateDocVariableFields_Click)
            ' 
            ' btn_ShowHiddenText
            ' 
            Me.btn_ShowHiddenText.Location = New System.Drawing.Point(360, 9)
            Me.btn_ShowHiddenText.Name = "btn_ShowHiddenText"
            Me.btn_ShowHiddenText.Size = New System.Drawing.Size(104, 23)
            Me.btn_ShowHiddenText.TabIndex = 4
            Me.btn_ShowHiddenText.Text = "Show Hidden Text"
            AddHandler Me.btn_ShowHiddenText.CheckedChanged, New System.EventHandler(AddressOf Me.btn_ShowHiddenText_CheckedChanged)
            ' 
            ' btn_ShowCodes
            ' 
            Me.btn_ShowCodes.Location = New System.Drawing.Point(242, 9)
            Me.btn_ShowCodes.Name = "btn_ShowCodes"
            Me.btn_ShowCodes.Size = New System.Drawing.Size(95, 23)
            Me.btn_ShowCodes.TabIndex = 3
            Me.btn_ShowCodes.Text = "Show Field Codes"
            AddHandler Me.btn_ShowCodes.CheckedChanged, New System.EventHandler(AddressOf Me.btn_ShowCodes_Click)
            ' 
            ' btnMailMerge
            ' 
            Me.btnMailMerge.Location = New System.Drawing.Point(12, 8)
            Me.btnMailMerge.Name = "btnMailMerge"
            Me.btnMailMerge.Size = New System.Drawing.Size(111, 23)
            Me.btnMailMerge.TabIndex = 0
            Me.btnMailMerge.Text = "Mail Merge"
            AddHandler Me.btnMailMerge.Click, New System.EventHandler(AddressOf Me.btnMailMerge_Click)
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 731)
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Controls.Add(Me.progressBarControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.progressBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xtraTabControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.xtraTabPage2.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl

        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl

        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage

        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage

        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl

        Private richEditControl2 As DevExpress.XtraRichEdit.RichEditControl

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private btnMailMerge As DevExpress.XtraEditors.SimpleButton

        Private btn_ShowHiddenText As DevExpress.XtraEditors.CheckButton

        Private btn_ShowCodes As DevExpress.XtraEditors.CheckButton

        Private btnUpdateDocVariableFields As DevExpress.XtraEditors.SimpleButton

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private labelControl1 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
