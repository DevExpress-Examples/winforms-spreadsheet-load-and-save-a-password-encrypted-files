Namespace EncryptionExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.spreadsheetCommandBarButtonItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barBtnSetEncryptionTypePassword = New DevExpress.XtraBars.BarButtonItem()
            Me.barEncryptionTypeComboBox = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemComboBoxEncType = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.barPasswordEdit = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.barBtnLoadCorruptedFile = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.fileRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup()
            Me.infoRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup()
            Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
            Me.spreadsheetNameBoxControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.spreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController()
            Me.barCheckSubscribeEvent = New DevExpress.XtraBars.BarCheckItem()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemComboBoxEncType, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            DirectCast(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 178)
            Me.spreadsheetControl1.MenuManager = Me.ribbonControl1
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Size = New System.Drawing.Size(784, 383)
            Me.spreadsheetControl1.TabIndex = 0
            Me.spreadsheetControl1.Text = "spreadsheetControl1"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.AutoSizeItems = True
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.spreadsheetCommandBarButtonItem1, Me.spreadsheetCommandBarButtonItem2, Me.spreadsheetCommandBarButtonItem3, Me.spreadsheetCommandBarButtonItem4, Me.spreadsheetCommandBarButtonItem5, Me.spreadsheetCommandBarButtonItem6, Me.spreadsheetCommandBarButtonItem7, Me.spreadsheetCommandBarButtonItem8, Me.spreadsheetCommandBarButtonItem9, Me.spreadsheetCommandBarButtonItem10, Me.spreadsheetCommandBarButtonItem11, Me.barBtnSetEncryptionTypePassword, Me.barEncryptionTypeComboBox, Me.barPasswordEdit, Me.barBtnLoadCorruptedFile, Me.barCheckSubscribeEvent})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 17
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.fileRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBoxEncType, Me.repositoryItemTextEdit1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.Size = New System.Drawing.Size(784, 146)
            ' 
            ' spreadsheetCommandBarButtonItem1
            ' 
            Me.spreadsheetCommandBarButtonItem1.CommandName = "FileNew"
            Me.spreadsheetCommandBarButtonItem1.Id = 1
            Me.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1"
            ' 
            ' spreadsheetCommandBarButtonItem2
            ' 
            Me.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen"
            Me.spreadsheetCommandBarButtonItem2.Id = 2
            Me.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2"
            ' 
            ' spreadsheetCommandBarButtonItem3
            ' 
            Me.spreadsheetCommandBarButtonItem3.CommandName = "FileSave"
            Me.spreadsheetCommandBarButtonItem3.Id = 3
            Me.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3"
            ' 
            ' spreadsheetCommandBarButtonItem4
            ' 
            Me.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs"
            Me.spreadsheetCommandBarButtonItem4.Id = 4
            Me.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4"
            ' 
            ' spreadsheetCommandBarButtonItem5
            ' 
            Me.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint"
            Me.spreadsheetCommandBarButtonItem5.Id = 5
            Me.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5"
            ' 
            ' spreadsheetCommandBarButtonItem6
            ' 
            Me.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint"
            Me.spreadsheetCommandBarButtonItem6.Id = 6
            Me.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6"
            ' 
            ' spreadsheetCommandBarButtonItem7
            ' 
            Me.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview"
            Me.spreadsheetCommandBarButtonItem7.Id = 7
            Me.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7"
            ' 
            ' spreadsheetCommandBarButtonItem8
            ' 
            Me.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo"
            Me.spreadsheetCommandBarButtonItem8.Id = 8
            Me.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8"
            ' 
            ' spreadsheetCommandBarButtonItem9
            ' 
            Me.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo"
            Me.spreadsheetCommandBarButtonItem9.Id = 9
            Me.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9"
            ' 
            ' spreadsheetCommandBarButtonItem10
            ' 
            Me.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt"
            Me.spreadsheetCommandBarButtonItem10.Id = 10
            Me.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10"
            ' 
            ' spreadsheetCommandBarButtonItem11
            ' 
            Me.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties"
            Me.spreadsheetCommandBarButtonItem11.Id = 11
            Me.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11"
            ' 
            ' barBtnSetEncryptionTypePassword
            ' 
            Me.barBtnSetEncryptionTypePassword.Caption = "Save File with Specified Encryption Type and Password"
            Me.barBtnSetEncryptionTypePassword.Id = 12
            Me.barBtnSetEncryptionTypePassword.ImageOptions.Image = (DirectCast(resources.GetObject("barBtnSetEncryptionTypePassword.ImageOptions.Image"), System.Drawing.Image))
            Me.barBtnSetEncryptionTypePassword.ImageOptions.LargeImage = (DirectCast(resources.GetObject("barBtnSetEncryptionTypePassword.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.barBtnSetEncryptionTypePassword.Name = "barBtnSetEncryptionTypePassword"
            Me.barBtnSetEncryptionTypePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' barEncryptionTypeComboBox
            ' 
            Me.barEncryptionTypeComboBox.Caption = "Encryption Type"
            Me.barEncryptionTypeComboBox.Edit = Me.repositoryItemComboBoxEncType
            Me.barEncryptionTypeComboBox.EditWidth = 100
            Me.barEncryptionTypeComboBox.Id = 13
            Me.barEncryptionTypeComboBox.Name = "barEncryptionTypeComboBox"
            Me.barEncryptionTypeComboBox.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' repositoryItemComboBoxEncType
            ' 
            Me.repositoryItemComboBoxEncType.AutoHeight = False
            Me.repositoryItemComboBoxEncType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBoxEncType.Name = "repositoryItemComboBoxEncType"
            ' 
            ' barPasswordEdit
            ' 
            Me.barPasswordEdit.Caption = "Password"
            Me.barPasswordEdit.Edit = Me.repositoryItemTextEdit1
            Me.barPasswordEdit.EditWidth = 100
            Me.barPasswordEdit.Id = 14
            Me.barPasswordEdit.Name = "barPasswordEdit"
            Me.barPasswordEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' barBtnLoadCorruptedFile
            ' 
            Me.barBtnLoadCorruptedFile.Caption = "Load Corrupted File"
            Me.barBtnLoadCorruptedFile.Id = 15
            Me.barBtnLoadCorruptedFile.ImageOptions.Image = (DirectCast(resources.GetObject("barBtnLoadCorruptedFile.ImageOptions.Image"), System.Drawing.Image))
            Me.barBtnLoadCorruptedFile.ImageOptions.LargeImage = (DirectCast(resources.GetObject("barBtnLoadCorruptedFile.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.barBtnLoadCorruptedFile.Name = "barBtnLoadCorruptedFile"
            Me.barBtnLoadCorruptedFile.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Encryption"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barBtnSetEncryptionTypePassword)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barEncryptionTypeComboBox)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barCheckSubscribeEvent)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barPasswordEdit)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barBtnLoadCorruptedFile)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Encryption Tests"
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.infoRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem2)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem3)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem4)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem5)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem6)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem7)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem8)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem9)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' infoRibbonPageGroup1
            ' 
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem10)
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem11)
            Me.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
            ' 
            ' spreadsheetFormulaBarControl1
            ' 
            Me.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetFormulaBarControl1.Location = New System.Drawing.Point(0, 0)
            Me.spreadsheetFormulaBarControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1"
            Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(627, 20)
            Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetFormulaBarControl1.TabIndex = 0
            ' 
            ' spreadsheetNameBoxControl1
            ' 
            Me.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetNameBoxControl1.EditValue = "A1"
            Me.spreadsheetNameBoxControl1.Location = New System.Drawing.Point(0, 0)
            Me.spreadsheetNameBoxControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1"
            Me.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spreadsheetNameBoxControl1.ReadOnly = DevExpress.Utils.DefaultBoolean.Default
            Me.spreadsheetNameBoxControl1.Size = New System.Drawing.Size(145, 20)
            Me.spreadsheetNameBoxControl1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetNameBoxControl1.TabIndex = 0
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 146)
            Me.splitContainerControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.spreadsheetNameBoxControl1)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetFormulaBarControl1)
            Me.splitContainerControl1.Size = New System.Drawing.Size(784, 20)
            Me.splitContainerControl1.SplitterPosition = 145
            Me.splitContainerControl1.TabIndex = 2
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitterControl1.Location = New System.Drawing.Point(0, 166)
            Me.splitterControl1.MinSize = 20
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(784, 12)
            Me.splitterControl1.TabIndex = 1
            Me.splitterControl1.TabStop = False
            ' 
            ' spreadsheetBarController1
            ' 
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem11)
            Me.spreadsheetBarController1.Control = Me.spreadsheetControl1
            ' 
            ' barCheckSubscribeEvent
            ' 
            Me.barCheckSubscribeEvent.BindableChecked = True
            Me.barCheckSubscribeEvent.Caption = "EncryptedFilePasswordRequest Event"
            Me.barCheckSubscribeEvent.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText
            Me.barCheckSubscribeEvent.Checked = True
            Me.barCheckSubscribeEvent.Id = 16
            Me.barCheckSubscribeEvent.Name = "barCheckSubscribeEvent"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.spreadsheetControl1)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Encryption Example"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemComboBoxEncType, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            DirectCast(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private spreadsheetCommandBarButtonItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private fileRibbonPage1 As DevExpress.XtraSpreadsheet.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup
        Private infoRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup
        Private spreadsheetFormulaBarControl1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
        Private spreadsheetNameBoxControl1 As DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
        Private spreadsheetBarController1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController
        Private WithEvents barBtnSetEncryptionTypePassword As DevExpress.XtraBars.BarButtonItem
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private barEncryptionTypeComboBox As DevExpress.XtraBars.BarEditItem
        Private WithEvents barPasswordEdit As DevExpress.XtraBars.BarEditItem
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private WithEvents barBtnLoadCorruptedFile As DevExpress.XtraBars.BarButtonItem
        Private repositoryItemComboBoxEncType As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private WithEvents barCheckSubscribeEvent As DevExpress.XtraBars.BarCheckItem
    End Class
End Namespace

