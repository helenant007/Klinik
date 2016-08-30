namespace Klinik.Admin.MainForms
{
    partial class HospitalizedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalizedForm));
            this.BtnSearch = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbSearchBy = new System.Windows.Forms.ComboBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbHName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbDiagnose = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbSection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbBinusID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.LightGray;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(1153, 17);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 59;
            this.BtnSearch.Text = "Search!";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(926, 17);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(221, 23);
            this.textBox8.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.Location = new System.Drawing.Point(691, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 57;
            this.label11.Text = "Search By:";
            // 
            // CbSearchBy
            // 
            this.CbSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbSearchBy.FormattingEnabled = true;
            this.CbSearchBy.Items.AddRange(new object[] {
            "Name",
            "Section",
            "Binusian ID",
            "Diagnose"});
            this.CbSearchBy.Location = new System.Drawing.Point(774, 17);
            this.CbSearchBy.Name = "CbSearchBy";
            this.CbSearchBy.Size = new System.Drawing.Size(146, 25);
            this.CbSearchBy.TabIndex = 56;
            // 
            // TbPhone
            // 
            this.TbPhone.Location = new System.Drawing.Point(926, 287);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(200, 23);
            this.TbPhone.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(804, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Phone:";
            // 
            // TbNotes
            // 
            this.TbNotes.Location = new System.Drawing.Point(926, 430);
            this.TbNotes.Multiline = true;
            this.TbNotes.Name = "TbNotes";
            this.TbNotes.Size = new System.Drawing.Size(200, 82);
            this.TbNotes.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(804, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Notes:";
            // 
            // TbHName
            // 
            this.TbHName.Location = new System.Drawing.Point(926, 404);
            this.TbHName.Multiline = true;
            this.TbHName.Name = "TbHName";
            this.TbHName.Size = new System.Drawing.Size(200, 20);
            this.TbHName.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(804, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Hospital Name:";
            // 
            // TbDiagnose
            // 
            this.TbDiagnose.Location = new System.Drawing.Point(926, 316);
            this.TbDiagnose.Multiline = true;
            this.TbDiagnose.Name = "TbDiagnose";
            this.TbDiagnose.Size = new System.Drawing.Size(200, 82);
            this.TbDiagnose.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(804, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Diagnose:";
            // 
            // CbSection
            // 
            this.CbSection.FormattingEnabled = true;
            this.CbSection.Location = new System.Drawing.Point(926, 227);
            this.CbSection.Name = "CbSection";
            this.CbSection.Size = new System.Drawing.Size(200, 25);
            this.CbSection.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(804, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Section:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(926, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(804, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Date:";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(926, 258);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(200, 23);
            this.TbName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Name:";
            // 
            // TbBinusID
            // 
            this.TbBinusID.Location = new System.Drawing.Point(926, 198);
            this.TbBinusID.Name = "TbBinusID";
            this.TbBinusID.Size = new System.Drawing.Size(200, 23);
            this.TbBinusID.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Binusian ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(706, 649);
            this.dataGridView1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Month:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(308, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 25);
            this.comboBox1.TabIndex = 30;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(152)))), ((int)(((byte)(117)))));
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Image = global::Klinik.Admin.Properties.Resources.cancel;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(1018, 613);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.BtnCancel.Size = new System.Drawing.Size(150, 34);
            this.BtnCancel.TabIndex = 55;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(152)))), ((int)(((byte)(117)))));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(834, 613);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(35, 0, 25, 0);
            this.BtnSave.Size = new System.Drawing.Size(150, 34);
            this.BtnSave.TabIndex = 54;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Image = global::Klinik.Admin.Properties.Resources.delete;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(1078, 62);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.BtnDelete.Size = new System.Drawing.Size(150, 34);
            this.BtnDelete.TabIndex = 53;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUpdate.Image = global::Klinik.Admin.Properties.Resources.update;
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdate.Location = new System.Drawing.Point(913, 62);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Padding = new System.Windows.Forms.Padding(25, 0, 15, 0);
            this.BtnUpdate.Size = new System.Drawing.Size(150, 34);
            this.BtnUpdate.TabIndex = 52;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnInsert.Image = global::Klinik.Admin.Properties.Resources.insert;
            this.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInsert.Location = new System.Drawing.Point(744, 62);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Padding = new System.Windows.Forms.Padding(35, 0, 25, 0);
            this.BtnInsert.Size = new System.Drawing.Size(150, 34);
            this.BtnInsert.TabIndex = 51;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // HospitalizedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 724);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CbSearchBy);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TbPhone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TbNotes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TbHName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbDiagnose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbBinusID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HospitalizedForm";
            this.Text = "HospitalizedForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbSearchBy;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbHName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbDiagnose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbBinusID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}