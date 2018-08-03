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
            this.tbLicenseKey = new System.Windows.Forms.TextBox();
            this.tbDateLimit = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLicenseKey
            // 
            this.tbLicenseKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLicenseKey.BackColor = System.Drawing.Color.White;
            this.tbLicenseKey.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbLicenseKey.ForeColor = System.Drawing.Color.Red;
            this.tbLicenseKey.Location = new System.Drawing.Point(13, 65);
            this.tbLicenseKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLicenseKey.MaxLength = 29;
            this.tbLicenseKey.Name = "tbLicenseKey";
            this.tbLicenseKey.ReadOnly = true;
            this.tbLicenseKey.Size = new System.Drawing.Size(357, 33);
            this.tbLicenseKey.TabIndex = 0;
            // 
            // tbDateLimit
            // 
            this.tbDateLimit.Location = new System.Drawing.Point(156, 23);
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
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.OK;
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
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lisans Süresi:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 105);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbDateLimit);
            this.Controls.Add(this.tbLicenseKey);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "License Key Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLicenseKey;
        private System.Windows.Forms.TextBox tbDateLimit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
    }
}

