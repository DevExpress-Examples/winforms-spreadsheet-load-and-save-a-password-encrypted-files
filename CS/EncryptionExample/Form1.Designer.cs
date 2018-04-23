namespace EncryptionExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.spreadsheetCommandBarButtonItem1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem2 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem3 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem4 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem5 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem6 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem7 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem8 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem9 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem10 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem11 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.barBtnSetEncryptionTypePassword = new DevExpress.XtraBars.BarButtonItem();
            this.barEncryptionTypeComboBox = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBoxEncType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barPasswordEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barBtnLoadCorruptedFile = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.fileRibbonPage1 = new DevExpress.XtraSpreadsheet.UI.FileRibbonPage();
            this.commonRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup();
            this.infoRibbonPageGroup1 = new DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup();
            this.spreadsheetFormulaBarControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl();
            this.spreadsheetNameBoxControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController();
            this.barCheckSubscribeEvent = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxEncType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 178);
            this.spreadsheetControl1.MenuManager = this.ribbonControl1;
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(784, 383);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.spreadsheetCommandBarButtonItem1,
            this.spreadsheetCommandBarButtonItem2,
            this.spreadsheetCommandBarButtonItem3,
            this.spreadsheetCommandBarButtonItem4,
            this.spreadsheetCommandBarButtonItem5,
            this.spreadsheetCommandBarButtonItem6,
            this.spreadsheetCommandBarButtonItem7,
            this.spreadsheetCommandBarButtonItem8,
            this.spreadsheetCommandBarButtonItem9,
            this.spreadsheetCommandBarButtonItem10,
            this.spreadsheetCommandBarButtonItem11,
            this.barBtnSetEncryptionTypePassword,
            this.barEncryptionTypeComboBox,
            this.barPasswordEdit,
            this.barBtnLoadCorruptedFile,
            this.barCheckSubscribeEvent});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.fileRibbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBoxEncType,
            this.repositoryItemTextEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(784, 146);
            // 
            // spreadsheetCommandBarButtonItem1
            // 
            this.spreadsheetCommandBarButtonItem1.CommandName = "FileNew";
            this.spreadsheetCommandBarButtonItem1.Id = 1;
            this.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1";
            // 
            // spreadsheetCommandBarButtonItem2
            // 
            this.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen";
            this.spreadsheetCommandBarButtonItem2.Id = 2;
            this.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2";
            // 
            // spreadsheetCommandBarButtonItem3
            // 
            this.spreadsheetCommandBarButtonItem3.CommandName = "FileSave";
            this.spreadsheetCommandBarButtonItem3.Id = 3;
            this.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3";
            // 
            // spreadsheetCommandBarButtonItem4
            // 
            this.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs";
            this.spreadsheetCommandBarButtonItem4.Id = 4;
            this.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4";
            // 
            // spreadsheetCommandBarButtonItem5
            // 
            this.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint";
            this.spreadsheetCommandBarButtonItem5.Id = 5;
            this.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5";
            // 
            // spreadsheetCommandBarButtonItem6
            // 
            this.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint";
            this.spreadsheetCommandBarButtonItem6.Id = 6;
            this.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6";
            // 
            // spreadsheetCommandBarButtonItem7
            // 
            this.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview";
            this.spreadsheetCommandBarButtonItem7.Id = 7;
            this.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7";
            // 
            // spreadsheetCommandBarButtonItem8
            // 
            this.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo";
            this.spreadsheetCommandBarButtonItem8.Id = 8;
            this.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8";
            // 
            // spreadsheetCommandBarButtonItem9
            // 
            this.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo";
            this.spreadsheetCommandBarButtonItem9.Id = 9;
            this.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9";
            // 
            // spreadsheetCommandBarButtonItem10
            // 
            this.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt";
            this.spreadsheetCommandBarButtonItem10.Id = 10;
            this.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10";
            // 
            // spreadsheetCommandBarButtonItem11
            // 
            this.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties";
            this.spreadsheetCommandBarButtonItem11.Id = 11;
            this.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11";
            // 
            // barBtnSetEncryptionTypePassword
            // 
            this.barBtnSetEncryptionTypePassword.Caption = "Save File with Specified Encryption Type and Password";
            this.barBtnSetEncryptionTypePassword.Id = 12;
            this.barBtnSetEncryptionTypePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSetEncryptionTypePassword.ImageOptions.Image")));
            this.barBtnSetEncryptionTypePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSetEncryptionTypePassword.ImageOptions.LargeImage")));
            this.barBtnSetEncryptionTypePassword.Name = "barBtnSetEncryptionTypePassword";
            this.barBtnSetEncryptionTypePassword.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnSetEncryptionTypePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSetEncryptionTypeAndPassword_ItemClick);
            // 
            // barEncryptionTypeComboBox
            // 
            this.barEncryptionTypeComboBox.Caption = "Encryption Type";
            this.barEncryptionTypeComboBox.Edit = this.repositoryItemComboBoxEncType;
            this.barEncryptionTypeComboBox.EditWidth = 100;
            this.barEncryptionTypeComboBox.Id = 13;
            this.barEncryptionTypeComboBox.Name = "barEncryptionTypeComboBox";
            this.barEncryptionTypeComboBox.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // repositoryItemComboBoxEncType
            // 
            this.repositoryItemComboBoxEncType.AutoHeight = false;
            this.repositoryItemComboBoxEncType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxEncType.Name = "repositoryItemComboBoxEncType";
            // 
            // barPasswordEdit
            // 
            this.barPasswordEdit.Caption = "Password";
            this.barPasswordEdit.Edit = this.repositoryItemTextEdit1;
            this.barPasswordEdit.EditWidth = 100;
            this.barPasswordEdit.Id = 14;
            this.barPasswordEdit.Name = "barPasswordEdit";
            this.barPasswordEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barPasswordEdit.EditValueChanged += new System.EventHandler(this.barPasswordEdit_EditValueChanged);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barBtnLoadCorruptedFile
            // 
            this.barBtnLoadCorruptedFile.Caption = "Load Corrupted File";
            this.barBtnLoadCorruptedFile.Id = 15;
            this.barBtnLoadCorruptedFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnLoadCorruptedFile.ImageOptions.Image")));
            this.barBtnLoadCorruptedFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnLoadCorruptedFile.ImageOptions.LargeImage")));
            this.barBtnLoadCorruptedFile.Name = "barBtnLoadCorruptedFile";
            this.barBtnLoadCorruptedFile.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnLoadCorruptedFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLoadCorruptedFile_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Encryption";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSetEncryptionTypePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEncryptionTypeComboBox);
            this.ribbonPageGroup1.ItemLinks.Add(this.barCheckSubscribeEvent);
            this.ribbonPageGroup1.ItemLinks.Add(this.barPasswordEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnLoadCorruptedFile);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Encryption Tests";
            // 
            // fileRibbonPage1
            // 
            this.fileRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.commonRibbonPageGroup1,
            this.infoRibbonPageGroup1});
            this.fileRibbonPage1.Name = "fileRibbonPage1";
            // 
            // commonRibbonPageGroup1
            // 
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem1);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem2);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem3);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem4);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem5);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem6);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem7);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem8);
            this.commonRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem9);
            this.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1";
            // 
            // infoRibbonPageGroup1
            // 
            this.infoRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem10);
            this.infoRibbonPageGroup1.ItemLinks.Add(this.spreadsheetCommandBarButtonItem11);
            this.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1";
            // 
            // spreadsheetFormulaBarControl1
            // 
            this.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetFormulaBarControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetFormulaBarControl1.MinimumSize = new System.Drawing.Size(0, 20);
            this.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1";
            this.spreadsheetFormulaBarControl1.Size = new System.Drawing.Size(627, 20);
            this.spreadsheetFormulaBarControl1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetFormulaBarControl1.TabIndex = 0;
            // 
            // spreadsheetNameBoxControl1
            // 
            this.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetNameBoxControl1.EditValue = "A1";
            this.spreadsheetNameBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetNameBoxControl1.MinimumSize = new System.Drawing.Size(0, 20);
            this.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1";
            this.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spreadsheetNameBoxControl1.ReadOnly = DevExpress.Utils.DefaultBoolean.Default;
            this.spreadsheetNameBoxControl1.Size = new System.Drawing.Size(145, 20);
            this.spreadsheetNameBoxControl1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetNameBoxControl1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 146);
            this.splitContainerControl1.MinimumSize = new System.Drawing.Size(0, 20);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.spreadsheetNameBoxControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.spreadsheetFormulaBarControl1);
            this.splitContainerControl1.Size = new System.Drawing.Size(784, 20);
            this.splitContainerControl1.SplitterPosition = 145;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 166);
            this.splitterControl1.MinSize = 20;
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(784, 12);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // spreadsheetBarController1
            // 
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem1);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem2);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem3);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem4);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem5);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem6);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem7);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem8);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem9);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem10);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem11);
            this.spreadsheetBarController1.Control = this.spreadsheetControl1;
            // 
            // barCheckSubscribeEvent
            // 
            this.barCheckSubscribeEvent.BindableChecked = true;
            this.barCheckSubscribeEvent.Caption = "EncryptedFilePasswordRequest Event";
            this.barCheckSubscribeEvent.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.barCheckSubscribeEvent.Checked = true;
            this.barCheckSubscribeEvent.Id = 16;
            this.barCheckSubscribeEvent.Name = "barCheckSubscribeEvent";
            this.barCheckSubscribeEvent.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckSubscribeEvent_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Encryption Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxEncType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem1;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem2;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem3;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem4;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem5;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem6;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem7;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem8;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem9;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem10;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem11;
        private DevExpress.XtraSpreadsheet.UI.FileRibbonPage fileRibbonPage1;
        private DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup commonRibbonPageGroup1;
        private DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup infoRibbonPageGroup1;
        private DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl spreadsheetFormulaBarControl1;
        private DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl spreadsheetNameBoxControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController spreadsheetBarController1;
        private DevExpress.XtraBars.BarButtonItem barBtnSetEncryptionTypePassword;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarEditItem barEncryptionTypeComboBox;
        private DevExpress.XtraBars.BarEditItem barPasswordEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem barBtnLoadCorruptedFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxEncType;
        private DevExpress.XtraBars.BarCheckItem barCheckSubscribeEvent;
    }
}

