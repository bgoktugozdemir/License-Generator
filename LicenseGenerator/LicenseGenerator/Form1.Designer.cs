namespace LicenseGenerator
{
    partial class Form1
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
            this.tbLicenseKey = new System.Windows.Forms.TextBox();
            this.tbDateLimit = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.tbLicenseKeyUpdate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNULL_2 = new System.Windows.Forms.Button();
            this.btnNULL_1 = new System.Windows.Forms.Button();
            this.cbIsUsableUpdate = new System.Windows.Forms.ComboBox();
            this.tbUsernameUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpExpirationDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dtpStartingDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDateLimitUpdate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblLicenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOVIZDataSet = new LicenseGenerator.DOVIZDataSet();
            this.tblLicenseTableAdapter = new LicenseGenerator.DOVIZDataSetTableAdapters.tblLicenseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLicenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOVIZDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLicenseKey
            // 
            this.tbLicenseKey.BackColor = System.Drawing.Color.White;
            this.tbLicenseKey.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.tbLicenseKey.ForeColor = System.Drawing.Color.Red;
            this.tbLicenseKey.Location = new System.Drawing.Point(23, 65);
            this.tbLicenseKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLicenseKey.MaxLength = 29;
            this.tbLicenseKey.Name = "tbLicenseKey";
            this.tbLicenseKey.ReadOnly = true;
            this.tbLicenseKey.Size = new System.Drawing.Size(347, 32);
            this.tbLicenseKey.TabIndex = 0;
            // 
            // tbDateLimit
            // 
            this.tbDateLimit.Location = new System.Drawing.Point(150, 27);
            this.tbDateLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDateLimit.Name = "tbDateLimit";
            this.tbDateLimit.Size = new System.Drawing.Size(71, 29);
            this.tbDateLimit.TabIndex = 0;
            this.tbDateLimit.Text = "0";
            this.tbDateLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDateLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDateLimit_KeyPress);
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.Location = new System.Drawing.Point(377, 65);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(102, 33);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Oluştur";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lisans Süresi:";
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpen.Location = new System.Drawing.Point(439, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 30);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = ">>";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDateLimit);
            this.groupBox1.Location = new System.Drawing.Point(12, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Lisans";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnGetir);
            this.groupBox2.Controls.Add(this.tbLicenseKeyUpdate);
            this.groupBox2.Location = new System.Drawing.Point(497, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 111);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lisans Güncelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "License Key";
            // 
            // btnGetir
            // 
            this.btnGetir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetir.Location = new System.Drawing.Point(371, 67);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(102, 33);
            this.btnGetir.TabIndex = 6;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // tbLicenseKeyUpdate
            // 
            this.tbLicenseKeyUpdate.BackColor = System.Drawing.Color.White;
            this.tbLicenseKeyUpdate.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.tbLicenseKeyUpdate.ForeColor = System.Drawing.Color.Black;
            this.tbLicenseKeyUpdate.Location = new System.Drawing.Point(7, 67);
            this.tbLicenseKeyUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLicenseKeyUpdate.MaxLength = 29;
            this.tbLicenseKeyUpdate.Name = "tbLicenseKeyUpdate";
            this.tbLicenseKeyUpdate.Size = new System.Drawing.Size(347, 32);
            this.tbLicenseKeyUpdate.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNULL_2);
            this.groupBox3.Controls.Add(this.btnNULL_1);
            this.groupBox3.Controls.Add(this.cbIsUsableUpdate);
            this.groupBox3.Controls.Add(this.tbUsernameUpdate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dtpExpirationDateUpdate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.dtpStartingDateUpdate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbDateLimitUpdate);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Location = new System.Drawing.Point(12, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(964, 111);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lisans Güncelle";
            // 
            // btnNULL_2
            // 
            this.btnNULL_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNULL_2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNULL_2.Location = new System.Drawing.Point(753, 78);
            this.btnNULL_2.Name = "btnNULL_2";
            this.btnNULL_2.Size = new System.Drawing.Size(62, 25);
            this.btnNULL_2.TabIndex = 19;
            this.btnNULL_2.Text = "NULL";
            this.btnNULL_2.UseVisualStyleBackColor = true;
            this.btnNULL_2.Click += new System.EventHandler(this.btnNULL_2_Click);
            // 
            // btnNULL_1
            // 
            this.btnNULL_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNULL_1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNULL_1.Location = new System.Drawing.Point(753, 30);
            this.btnNULL_1.Name = "btnNULL_1";
            this.btnNULL_1.Size = new System.Drawing.Size(62, 25);
            this.btnNULL_1.TabIndex = 18;
            this.btnNULL_1.Text = "NULL";
            this.btnNULL_1.UseVisualStyleBackColor = true;
            this.btnNULL_1.Click += new System.EventHandler(this.btnNULL_1_Click);
            // 
            // cbIsUsableUpdate
            // 
            this.cbIsUsableUpdate.FormattingEnabled = true;
            this.cbIsUsableUpdate.Items.AddRange(new object[] {
            "",
            "Usable",
            "Not Usable"});
            this.cbIsUsableUpdate.Location = new System.Drawing.Point(310, 75);
            this.cbIsUsableUpdate.Name = "cbIsUsableUpdate";
            this.cbIsUsableUpdate.Size = new System.Drawing.Size(121, 29);
            this.cbIsUsableUpdate.TabIndex = 17;
            // 
            // tbUsernameUpdate
            // 
            this.tbUsernameUpdate.BackColor = System.Drawing.Color.White;
            this.tbUsernameUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUsernameUpdate.ForeColor = System.Drawing.Color.Black;
            this.tbUsernameUpdate.Location = new System.Drawing.Point(89, 25);
            this.tbUsernameUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsernameUpdate.MaxLength = 12;
            this.tbUsernameUpdate.Name = "tbUsernameUpdate";
            this.tbUsernameUpdate.Size = new System.Drawing.Size(150, 33);
            this.tbUsernameUpdate.TabIndex = 16;
            this.tbUsernameUpdate.TextChanged += new System.EventHandler(this.tbUsernameUpdate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Username";
            // 
            // dtpExpirationDateUpdate
            // 
            this.dtpExpirationDateUpdate.CustomFormat = "dd/MM/yyyy HH:MM:ss";
            this.dtpExpirationDateUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpExpirationDateUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationDateUpdate.Location = new System.Drawing.Point(578, 78);
            this.dtpExpirationDateUpdate.MinDate = new System.DateTime(2018, 8, 3, 0, 0, 0, 0);
            this.dtpExpirationDateUpdate.Name = "dtpExpirationDateUpdate";
            this.dtpExpirationDateUpdate.Size = new System.Drawing.Size(169, 25);
            this.dtpExpirationDateUpdate.TabIndex = 15;
            this.dtpExpirationDateUpdate.DropDown += new System.EventHandler(this.dtpExpirationDateUpdate_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(477, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Expiration Date:";
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Location = new System.Drawing.Point(856, 26);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 33);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dtpStartingDateUpdate
            // 
            this.dtpStartingDateUpdate.CustomFormat = "dd/MM/yyyy HH:MM:ss";
            this.dtpStartingDateUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpStartingDateUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartingDateUpdate.Location = new System.Drawing.Point(578, 30);
            this.dtpStartingDateUpdate.MinDate = new System.DateTime(2018, 8, 3, 0, 0, 0, 0);
            this.dtpStartingDateUpdate.Name = "dtpStartingDateUpdate";
            this.dtpStartingDateUpdate.Size = new System.Drawing.Size(169, 25);
            this.dtpStartingDateUpdate.TabIndex = 12;
            this.dtpStartingDateUpdate.DropDown += new System.EventHandler(this.DtpStartingDateUpdate_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Starting Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Is Usable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Limit:";
            // 
            // tbDateLimitUpdate
            // 
            this.tbDateLimitUpdate.BackColor = System.Drawing.Color.White;
            this.tbDateLimitUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDateLimitUpdate.ForeColor = System.Drawing.Color.Black;
            this.tbDateLimitUpdate.Location = new System.Drawing.Point(89, 72);
            this.tbDateLimitUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDateLimitUpdate.Name = "tbDateLimitUpdate";
            this.tbDateLimitUpdate.Size = new System.Drawing.Size(116, 33);
            this.tbDateLimitUpdate.TabIndex = 7;
            this.tbDateLimitUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDateLimit_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Location = new System.Drawing.Point(856, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblLicenseBindingSource
            // 
            this.tblLicenseBindingSource.DataMember = "tblLicense";
            this.tblLicenseBindingSource.DataSource = this.dOVIZDataSet;
            // 
            // dOVIZDataSet
            // 
            this.dOVIZDataSet.DataSetName = "DOVIZDataSet";
            this.dOVIZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLicenseTableAdapter
            // 
            this.tblLicenseTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(296, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lisansları Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 232);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbLicenseKey);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 271);
            this.MinimumSize = new System.Drawing.Size(511, 154);
            this.Name = "Form1";
            this.Text = "License Key Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLicenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOVIZDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLicenseKey;
        private System.Windows.Forms.TextBox tbDateLimit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLicenseKeyUpdate;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDateLimitUpdate;
        private System.Windows.Forms.DateTimePicker dtpStartingDateUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpExpirationDateUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbUsernameUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbIsUsableUpdate;
        private System.Windows.Forms.Button btnNULL_2;
        private System.Windows.Forms.Button btnNULL_1;
        private DOVIZDataSet dOVIZDataSet;
        private System.Windows.Forms.BindingSource tblLicenseBindingSource;
        private DOVIZDataSetTableAdapters.tblLicenseTableAdapter tblLicenseTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

