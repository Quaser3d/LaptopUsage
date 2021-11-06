
namespace LaptopManagement
{
    partial class StudentsProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblDateSubmitted = new System.Windows.Forms.Label();
            this.lblLaptopBag = new System.Windows.Forms.Label();
            this.lblOperatingSystem = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblLaptopUUID = new System.Windows.Forms.Label();
            this.lblLaptopModel = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.txtLaptopModel = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.cboStudentsClass = new System.Windows.Forms.ComboBox();
            this.cboLaptopBag = new System.Windows.Forms.ComboBox();
            this.dtDateSubmitted = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnImportImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExportAsExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dlgImportImage = new System.Windows.Forms.OpenFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Students Laptop";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(23, 93);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(117, 28);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "Firstname:";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(624, 186);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(103, 28);
            this.lblRemarks.TabIndex = 5;
            this.lblRemarks.Text = "Remarks:";
            // 
            // lblDateSubmitted
            // 
            this.lblDateSubmitted.AutoSize = true;
            this.lblDateSubmitted.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSubmitted.Location = new System.Drawing.Point(624, 141);
            this.lblDateSubmitted.Name = "lblDateSubmitted";
            this.lblDateSubmitted.Size = new System.Drawing.Size(168, 28);
            this.lblDateSubmitted.TabIndex = 6;
            this.lblDateSubmitted.Text = "Date Submitted:";
            // 
            // lblLaptopBag
            // 
            this.lblLaptopBag.AutoSize = true;
            this.lblLaptopBag.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaptopBag.Location = new System.Drawing.Point(624, 93);
            this.lblLaptopBag.Name = "lblLaptopBag";
            this.lblLaptopBag.Size = new System.Drawing.Size(126, 28);
            this.lblLaptopBag.TabIndex = 7;
            this.lblLaptopBag.Text = "Laptop Bag:";
            // 
            // lblOperatingSystem
            // 
            this.lblOperatingSystem.AutoSize = true;
            this.lblOperatingSystem.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatingSystem.Location = new System.Drawing.Point(23, 360);
            this.lblOperatingSystem.Name = "lblOperatingSystem";
            this.lblOperatingSystem.Size = new System.Drawing.Size(189, 28);
            this.lblOperatingSystem.TabIndex = 8;
            this.lblOperatingSystem.Text = "Operating System:";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(23, 186);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(160, 28);
            this.lblStudents.TabIndex = 9;
            this.lblStudents.Text = "Students Class:";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNo.Location = new System.Drawing.Point(23, 317);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(108, 28);
            this.lblSerialNo.TabIndex = 10;
            this.lblSerialNo.Text = "Serial No:";
            // 
            // lblLaptopUUID
            // 
            this.lblLaptopUUID.AutoSize = true;
            this.lblLaptopUUID.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaptopUUID.Location = new System.Drawing.Point(23, 273);
            this.lblLaptopUUID.Name = "lblLaptopUUID";
            this.lblLaptopUUID.Size = new System.Drawing.Size(143, 28);
            this.lblLaptopUUID.TabIndex = 11;
            this.lblLaptopUUID.Text = "Laptop UUID:";
            // 
            // lblLaptopModel
            // 
            this.lblLaptopModel.AutoSize = true;
            this.lblLaptopModel.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaptopModel.Location = new System.Drawing.Point(23, 227);
            this.lblLaptopModel.Name = "lblLaptopModel";
            this.lblLaptopModel.Size = new System.Drawing.Size(150, 28);
            this.lblLaptopModel.TabIndex = 12;
            this.lblLaptopModel.Text = "Laptop Model:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(23, 141);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(112, 28);
            this.lblLastname.TabIndex = 13;
            this.lblLastname.Text = "Lastname:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(284, 99);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(257, 22);
            this.txtFirstname.TabIndex = 14;
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(284, 366);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(257, 22);
            this.txtOS.TabIndex = 15;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(284, 323);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(257, 22);
            this.txtSerialNo.TabIndex = 16;
            // 
            // txtUUID
            // 
            this.txtUUID.Location = new System.Drawing.Point(284, 282);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.Size = new System.Drawing.Size(257, 22);
            this.txtUUID.TabIndex = 17;
            // 
            // txtLaptopModel
            // 
            this.txtLaptopModel.Location = new System.Drawing.Point(284, 233);
            this.txtLaptopModel.Name = "txtLaptopModel";
            this.txtLaptopModel.Size = new System.Drawing.Size(257, 22);
            this.txtLaptopModel.TabIndex = 18;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(284, 141);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(257, 22);
            this.txtLastname.TabIndex = 20;
            // 
            // cboStudentsClass
            // 
            this.cboStudentsClass.FormattingEnabled = true;
            this.cboStudentsClass.Items.AddRange(new object[] {
            "JS1 Gold",
            "JS1 Red",
            "JS1 Blue",
            "JS1 Green",
            "JS1 Purple",
            "JS2 Gold",
            "JS2 Red",
            "JS2 Blue",
            "JS2 Green",
            "JS2 Purple",
            "JS3 Gold",
            "JS3 Red",
            "JS3 Blue",
            "JS3 Green",
            "JS3 Purple",
            "SS1 Gold",
            "SS1 Red",
            "SS1 Blue",
            "SS1 Green",
            "SS1 Purple",
            "SS2 Gold",
            "SS2 Red",
            "SS2 Blue",
            "SS2 Green",
            "SS2 Purple",
            "SS3 Gold",
            "SS3 Red",
            "SS3 Blue",
            "SS3 Green",
            "SS3 Purple"});
            this.cboStudentsClass.Location = new System.Drawing.Point(284, 186);
            this.cboStudentsClass.Name = "cboStudentsClass";
            this.cboStudentsClass.Size = new System.Drawing.Size(257, 24);
            this.cboStudentsClass.TabIndex = 21;
            // 
            // cboLaptopBag
            // 
            this.cboLaptopBag.FormattingEnabled = true;
            this.cboLaptopBag.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboLaptopBag.Location = new System.Drawing.Point(818, 99);
            this.cboLaptopBag.Name = "cboLaptopBag";
            this.cboLaptopBag.Size = new System.Drawing.Size(206, 24);
            this.cboLaptopBag.TabIndex = 22;
            // 
            // dtDateSubmitted
            // 
            this.dtDateSubmitted.Location = new System.Drawing.Point(818, 147);
            this.dtDateSubmitted.Name = "dtDateSubmitted";
            this.dtDateSubmitted.Size = new System.Drawing.Size(206, 22);
            this.dtDateSubmitted.TabIndex = 23;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(818, 192);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(206, 112);
            this.txtRemarks.TabIndex = 24;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(818, 310);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(206, 187);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 25;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // btnImportImage
            // 
            this.btnImportImage.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportImage.Location = new System.Drawing.Point(629, 340);
            this.btnImportImage.Name = "btnImportImage";
            this.btnImportImage.Size = new System.Drawing.Size(121, 35);
            this.btnImportImage.TabIndex = 26;
            this.btnImportImage.Text = "Import Image";
            this.btnImportImage.UseVisualStyleBackColor = true;
            this.btnImportImage.Click += new System.EventHandler(this.btnImportImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(237, 459);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 38);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(397, 459);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 38);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(568, 459);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 38);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExportAsExcel
            // 
            this.btnExportAsExcel.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportAsExcel.Location = new System.Drawing.Point(324, 513);
            this.btnExportAsExcel.Name = "btnExportAsExcel";
            this.btnExportAsExcel.Size = new System.Drawing.Size(277, 38);
            this.btnExportAsExcel.TabIndex = 30;
            this.btnExportAsExcel.Text = "Export as Excel file";
            this.btnExportAsExcel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 557);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(996, 196);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(23, 413);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(83, 28);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Search:";
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "Firstname",
            "Lastname",
            "Class"});
            this.cboSearch.Location = new System.Drawing.Point(510, 408);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(130, 24);
            this.cboSearch.TabIndex = 33;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(284, 410);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 22);
            this.txtSearch.TabIndex = 34;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(LaptopManagement.StudentsProfile);
            // 
            // StudentsProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 777);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExportAsExcel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImportImage);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.dtDateSubmitted);
            this.Controls.Add(this.cboLaptopBag);
            this.Controls.Add(this.cboStudentsClass);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtLaptopModel);
            this.Controls.Add(this.txtUUID);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblLaptopModel);
            this.Controls.Add(this.lblLaptopUUID);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblOperatingSystem);
            this.Controls.Add(this.lblLaptopBag);
            this.Controls.Add(this.lblDateSubmitted);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.label1);
            this.Name = "StudentsProfile";
            this.Text = "Students Laptop Profile";
            this.Load += new System.EventHandler(this.StudentsProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblDateSubmitted;
        private System.Windows.Forms.Label lblLaptopBag;
        private System.Windows.Forms.Label lblOperatingSystem;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblLaptopUUID;
        private System.Windows.Forms.Label lblLaptopModel;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.TextBox txtLaptopModel;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.ComboBox cboStudentsClass;
        private System.Windows.Forms.ComboBox cboLaptopBag;
        private System.Windows.Forms.DateTimePicker dtDateSubmitted;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnImportImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExportAsExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.OpenFileDialog dlgImportImage;
    }
}