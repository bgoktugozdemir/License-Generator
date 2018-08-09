namespace LicenseGenerator
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dOVIZDataSet = new LicenseGenerator.DOVIZDataSet();
            this.tblLicenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLicenseTableAdapter = new LicenseGenerator.DOVIZDataSetTableAdapters.tblLicenseTableAdapter();
            this.dOVIZDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLicenseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbIsUsable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOVIZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLicenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOVIZDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLicenseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbIsUsable);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btnGenerate);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(877, 253);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kullanılabilir Lisanslar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(869, 197);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dOVIZDataSet
            // 
            this.dOVIZDataSet.DataSetName = "DOVIZDataSet";
            this.dOVIZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLicenseBindingSource
            // 
            this.tblLicenseBindingSource.DataMember = "tblLicense";
            this.tblLicenseBindingSource.DataSource = this.dOVIZDataSet;
            // 
            // tblLicenseTableAdapter
            // 
            this.tblLicenseTableAdapter.ClearBeforeFill = true;
            // 
            // dOVIZDataSetBindingSource
            // 
            this.dOVIZDataSetBindingSource.DataSource = this.dOVIZDataSet;
            this.dOVIZDataSetBindingSource.Position = 0;
            // 
            // tblLicenseBindingSource1
            // 
            this.tblLicenseBindingSource1.DataMember = "tblLicense";
            this.tblLicenseBindingSource1.DataSource = this.dOVIZDataSet;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.Location = new System.Drawing.Point(794, 21);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 24);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Filtrele";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbIsUsable
            // 
            this.cbIsUsable.FormattingEnabled = true;
            this.cbIsUsable.Items.AddRange(new object[] {
            "ALL",
            "Usable",
            "Not Usable"});
            this.cbIsUsable.Location = new System.Drawing.Point(667, 21);
            this.cbIsUsable.Name = "cbIsUsable";
            this.cbIsUsable.Size = new System.Drawing.Size(121, 24);
            this.cbIsUsable.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Is Usable:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 253);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(893, 893);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(893, 271);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOVIZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLicenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOVIZDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLicenseBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DOVIZDataSet dOVIZDataSet;
        private System.Windows.Forms.BindingSource tblLicenseBindingSource;
        private DOVIZDataSetTableAdapters.tblLicenseTableAdapter tblLicenseTableAdapter;
        private System.Windows.Forms.BindingSource tblLicenseBindingSource1;
        private System.Windows.Forms.BindingSource dOVIZDataSetBindingSource;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbIsUsable;
        private System.Windows.Forms.Label label5;
    }
}