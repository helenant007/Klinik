namespace Klinik.Admin.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LbGreet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.BtnMedicine = new System.Windows.Forms.Button();
            this.BtnSection = new System.Windows.Forms.Button();
            this.BtnHospitalized = new System.Windows.Forms.Button();
            this.BtnDVL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbGreet
            // 
            this.LbGreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbGreet.AutoSize = true;
            this.LbGreet.BackColor = System.Drawing.Color.Transparent;
            this.LbGreet.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.LbGreet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbGreet.Location = new System.Drawing.Point(464, 9);
            this.LbGreet.Name = "LbGreet";
            this.LbGreet.Size = new System.Drawing.Size(103, 23);
            this.LbGreet.TabIndex = 1;
            this.LbGreet.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.LbGreet);
            this.panel1.Controls.Add(this.BtnExcel);
            this.panel1.Controls.Add(this.BtnMedicine);
            this.panel1.Controls.Add(this.BtnSection);
            this.panel1.Controls.Add(this.BtnHospitalized);
            this.panel1.Controls.Add(this.BtnDVL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 573);
            this.panel1.TabIndex = 5;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSettings.Image = global::Klinik.Admin.Properties.Resources.settings;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.Location = new System.Drawing.Point(642, 513);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Padding = new System.Windows.Forms.Padding(50, 0, 70, 0);
            this.BtnSettings.Size = new System.Drawing.Size(250, 50);
            this.BtnSettings.TabIndex = 7;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSettings.UseVisualStyleBackColor = false;
            // 
            // BtnExcel
            // 
            this.BtnExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.BtnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExcel.Image = global::Klinik.Admin.Properties.Resources.logout;
            this.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcel.Location = new System.Drawing.Point(135, 512);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Padding = new System.Windows.Forms.Padding(30, 0, 50, 0);
            this.BtnExcel.Size = new System.Drawing.Size(250, 50);
            this.BtnExcel.TabIndex = 6;
            this.BtnExcel.Text = "Export to Excel";
            this.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcel.UseVisualStyleBackColor = false;
            // 
            // BtnMedicine
            // 
            this.BtnMedicine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(152)))), ((int)(((byte)(117)))));
            this.BtnMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedicine.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMedicine.Image = global::Klinik.Admin.Properties.Resources.ointment_1;
            this.BtnMedicine.Location = new System.Drawing.Point(771, 136);
            this.BtnMedicine.Name = "BtnMedicine";
            this.BtnMedicine.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.BtnMedicine.Size = new System.Drawing.Size(250, 250);
            this.BtnMedicine.TabIndex = 5;
            this.BtnMedicine.Text = "Medicine Stock";
            this.BtnMedicine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMedicine.UseVisualStyleBackColor = false;
            // 
            // BtnSection
            // 
            this.BtnSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(152)))), ((int)(((byte)(117)))));
            this.BtnSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSection.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSection.Image = global::Klinik.Admin.Properties.Resources.first_aid_kit;
            this.BtnSection.Location = new System.Drawing.Point(258, 136);
            this.BtnSection.Name = "BtnSection";
            this.BtnSection.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.BtnSection.Size = new System.Drawing.Size(250, 250);
            this.BtnSection.TabIndex = 3;
            this.BtnSection.Text = "List Based on Section";
            this.BtnSection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSection.UseVisualStyleBackColor = false;
            this.BtnSection.Click += new System.EventHandler(this.BtnSection_Click);
            // 
            // BtnHospitalized
            // 
            this.BtnHospitalized.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnHospitalized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(152)))), ((int)(((byte)(117)))));
            this.BtnHospitalized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHospitalized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHospitalized.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHospitalized.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnHospitalized.Image = global::Klinik.Admin.Properties.Resources.stethoscope;
            this.BtnHospitalized.Location = new System.Drawing.Point(514, 136);
            this.BtnHospitalized.Name = "BtnHospitalized";
            this.BtnHospitalized.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.BtnHospitalized.Size = new System.Drawing.Size(250, 250);
            this.BtnHospitalized.TabIndex = 4;
            this.BtnHospitalized.Text = "Hospitalized Visitor";
            this.BtnHospitalized.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHospitalized.UseVisualStyleBackColor = false;
            this.BtnHospitalized.Click += new System.EventHandler(this.BtnHospitalized_Click);
            // 
            // BtnDVL
            // 
            this.BtnDVL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDVL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(152)))), ((int)(((byte)(117)))));
            this.BtnDVL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDVL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDVL.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDVL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDVL.Image = ((System.Drawing.Image)(resources.GetObject("BtnDVL.Image")));
            this.BtnDVL.Location = new System.Drawing.Point(4, 136);
            this.BtnDVL.Name = "BtnDVL";
            this.BtnDVL.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.BtnDVL.Size = new System.Drawing.Size(250, 250);
            this.BtnDVL.TabIndex = 2;
            this.BtnDVL.Text = "Daily Visitors List";
            this.BtnDVL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDVL.UseVisualStyleBackColor = false;
            this.BtnDVL.Click += new System.EventHandler(this.BtnDVL_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1025, 573);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDVL;
        private System.Windows.Forms.Button BtnHospitalized;
        private System.Windows.Forms.Button BtnSection;
        private System.Windows.Forms.Button BtnMedicine;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Label LbGreet;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Panel panel1;
    }
}