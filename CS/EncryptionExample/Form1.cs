using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionExample {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        string documentName = "encrypted.xlsx";

        public Form1() {
            InitializeComponent();
            InitializeEncryptionTypeComboBox();
            InitializePasswordEdit();
            // The EncryptedFileIntegrityCheckFailed event allows you to perform custom actions when trying to load a corrupted file.
            spreadsheetControl1.EncryptedFileIntegrityCheckFailed += SpreadsheetControl1_EncryptedFileIntegrityCheckFailed;
            // If 
            // The EncryptedFilePasswordRequest event allows you to specify a password in the event handler.
            spreadsheetControl1.EncryptedFilePasswordRequest += SpreadsheetControl1_EncryptedFilePasswordRequest;
        }
        void InitializeEncryptionTypeComboBox() {
            foreach (DevExpress.Spreadsheet.EncryptionType currentValue in Enum.GetValues(typeof(DevExpress.Spreadsheet.EncryptionType)))
                ((DevExpress.XtraEditors.Repository.RepositoryItemComboBox)(barEncryptionTypeComboBox.Edit)).Items.Add(currentValue.ToString());
            barEncryptionTypeComboBox.EditValue = DevExpress.Spreadsheet.EncryptionType.Strong.ToString();
        }

        private void InitializePasswordEdit() {
            barPasswordEdit.EditValue = "123";
        }

        private void Form1_Load(object sender, EventArgs e) {
            #region #OptionsImportPassword
            spreadsheetControl1.Options.Import.Password = "123";
            spreadsheetControl1.LoadDocument(documentName);
            #endregion #OptionsImportPassword
        }

        private void barPasswordEdit_EditValueChanged(object sender, EventArgs e) {
            spreadsheetControl1.Options.Import.Password = barPasswordEdit.EditValue.ToString();
        }

        private void barBtnSetEncryptionTypeAndPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            #region #SetEncryptionTypeAndPassword
            IWorkbook workbook = spreadsheetControl1.Document;
            workbook.DocumentSettings.Encryption.Type = (EncryptionType)Enum.Parse(typeof(EncryptionType), barEncryptionTypeComboBox.EditValue.ToString());
            workbook.DocumentSettings.Encryption.Password = barPasswordEdit.EditValue.ToString();
            spreadsheetControl1.SaveDocumentAs();
            #endregion #SetEncryptionTypeAndPassword
        }

        private void barBtnLoadCorruptedFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            spreadsheetControl1.LoadDocument("corrupted.xlsx");
        }

        #region #EncryptedFilePasswordRequest
        private void SpreadsheetControl1_EncryptedFilePasswordRequest(object sender, EncryptedFilePasswordRequestEventArgs e) {
            if (e.DocumentName == "encrypted_test.xlsx") e.Password = "test";
            if (e.DocumentName == "corrupted.xlsx") e.Password = "000";
            e.Handled = true;
        }
        #endregion #EncryptedFilePasswordRequest

        #region #EncryptedFileIntegrityCheckFailed
        private void SpreadsheetControl1_EncryptedFileIntegrityCheckFailed(object sender, EncryptedFileIntegrityCheckFailedEventArgs e) {
            e.Cancel = true;
            e.Handled = true;
            MessageBox.Show("File is corrupted. Cannot load.","Warning");
        }
        #endregion #EncryptedFileIntegrityCheckFailed

        private void barCheckSubscribeEvent_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (barCheckSubscribeEvent.Checked)
                spreadsheetControl1.EncryptedFilePasswordRequest += SpreadsheetControl1_EncryptedFilePasswordRequest;
            else
                spreadsheetControl1.EncryptedFilePasswordRequest -= SpreadsheetControl1_EncryptedFilePasswordRequest;
        }
    }
}
