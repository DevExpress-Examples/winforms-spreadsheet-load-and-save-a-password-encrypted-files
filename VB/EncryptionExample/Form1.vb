Imports DevExpress.Spreadsheet
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace EncryptionExample
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Private documentName As String = "encrypted.xlsx"

        Public Sub New()
            InitializeComponent()
            InitializeEncryptionTypeComboBox()
            InitializePasswordEdit()
            ' The EncryptedFileIntegrityCheckFailed event allows you to perform custom actions when trying to load a corrupted file.
            AddHandler spreadsheetControl1.EncryptedFileIntegrityCheckFailed, AddressOf SpreadsheetControl1_EncryptedFileIntegrityCheckFailed
            ' If 
            ' The EncryptedFilePasswordRequest event allows you to specify a password in the event handler.
            AddHandler spreadsheetControl1.EncryptedFilePasswordRequest, AddressOf SpreadsheetControl1_EncryptedFilePasswordRequest
        End Sub
        Private Sub InitializeEncryptionTypeComboBox()
            For Each currentValue As DevExpress.Spreadsheet.EncryptionType In System.Enum.GetValues(GetType(DevExpress.Spreadsheet.EncryptionType))
                CType(barEncryptionTypeComboBox.Edit, DevExpress.XtraEditors.Repository.RepositoryItemComboBox).Items.Add(currentValue.ToString())
            Next currentValue
            barEncryptionTypeComboBox.EditValue = DevExpress.Spreadsheet.EncryptionType.Strong.ToString()
        End Sub

        Private Sub InitializePasswordEdit()
            barPasswordEdit.EditValue = "123"
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
'            #Region "#OptionsImportPassword"
            spreadsheetControl1.Options.Import.Password = "123"
            spreadsheetControl1.LoadDocument(documentName)
'            #End Region ' #OptionsImportPassword
        End Sub

        Private Sub barPasswordEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles barPasswordEdit.EditValueChanged
            spreadsheetControl1.Options.Import.Password = barPasswordEdit.EditValue.ToString()
        End Sub

        Private Sub barBtnSetEncryptionTypeAndPassword_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnSetEncryptionTypePassword.ItemClick
'            #Region "#SetEncryptionTypeAndPassword"
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            workbook.DocumentSettings.Encryption.Type = DirectCast(System.Enum.Parse(GetType(EncryptionType), barEncryptionTypeComboBox.EditValue.ToString()), EncryptionType)
            workbook.DocumentSettings.Encryption.Password = barPasswordEdit.EditValue.ToString()
            spreadsheetControl1.SaveDocumentAs()
'            #End Region ' #SetEncryptionTypeAndPassword
        End Sub

        Private Sub barBtnLoadCorruptedFile_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnLoadCorruptedFile.ItemClick
            spreadsheetControl1.LoadDocument("corrupted.xlsx")
        End Sub

        #Region "#EncryptedFilePasswordRequest"
        Private Sub SpreadsheetControl1_EncryptedFilePasswordRequest(ByVal sender As Object, ByVal e As EncryptedFilePasswordRequestEventArgs)
            If e.DocumentName = "encrypted_test.xlsx" Then
                e.Password = "test"
            End If
            If e.DocumentName = "corrupted.xlsx" Then
                e.Password = "000"
            End If
            e.Handled = True
        End Sub
        #End Region ' #EncryptedFilePasswordRequest

        #Region "#EncryptedFileIntegrityCheckFailed"
        Private Sub SpreadsheetControl1_EncryptedFileIntegrityCheckFailed(ByVal sender As Object, ByVal e As EncryptedFileIntegrityCheckFailedEventArgs)
            e.Cancel = True
            e.Handled = True
            MessageBox.Show("File is corrupted. Cannot load.","Warning")
        End Sub
        #End Region ' #EncryptedFileIntegrityCheckFailed

        Private Sub barCheckSubscribeEvent_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barCheckSubscribeEvent.CheckedChanged
            If barCheckSubscribeEvent.Checked Then
                AddHandler spreadsheetControl1.EncryptedFilePasswordRequest, AddressOf SpreadsheetControl1_EncryptedFilePasswordRequest
            Else
                RemoveHandler spreadsheetControl1.EncryptedFilePasswordRequest, AddressOf SpreadsheetControl1_EncryptedFilePasswordRequest
            End If
        End Sub
    End Class
End Namespace
