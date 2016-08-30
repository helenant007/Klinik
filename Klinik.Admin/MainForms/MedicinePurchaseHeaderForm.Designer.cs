namespace Klinik.Admin.MainForms
{
    partial class MedicinePurchaseHeaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicinePurchaseHeaderForm));
            this.BtnSearch = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbSearchBy = new System.Windows.Forms.ComboBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DtpExp = new System.Windows.Forms.DateTimePicker();
            this.NumQty = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbSection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbMedicName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.LightGray;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(1188, 27);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 59;
            this.BtnSearch.Text = "Search!";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(994, 27);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(188, 23);
            this.textBox8.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.Location = new System.Drawing.Point(755, 30);
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
            "Type",
            "Price",
            "Exp Date"});
            this.CbSearchBy.Location = new System.Drawing.Point(842, 27);
            this.CbSearchBy.Name = "CbSearchBy";
            this.CbSearchBy.Size = new System.Drawing.Size(146, 25);
            this.CbSearchBy.TabIndex = 56;
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(995, 283);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.ReadOnly = true;
            this.TbPrice.Size = new System.Drawing.Size(200, 23);
            this.TbPrice.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(825, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Total Type of Medicine:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(706, 310);
            this.dataGridView1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(228, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Month:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(340, 24);
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
            this.BtnCancel.Location = new System.Drawing.Point(1033, 675);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.BtnCancel.Size = new System.Drawing.Size(150, 34);
            this.BtnCancel.TabIndex = 55;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.UseVisualStyleBackColor = false;
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
            this.BtnSave.Location = new System.Drawing.Point(855, 675);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(35, 0, 25, 0);
            this.BtnSave.Size = new System.Drawing.Size(150, 34);
            this.BtnSave.TabIndex = 54;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.UseVisualStyleBackColor = false;
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
            this.BtnDelete.Location = new System.Drawing.Point(1114, 77);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.BtnDelete.Size = new System.Drawing.Size(150, 34);
            this.BtnDelete.TabIndex = 53;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.UseVisualStyleBackColor = false;
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
            this.BtnUpdate.Location = new System.Drawing.Point(949, 77);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Padding = new System.Windows.Forms.Padding(25, 0, 15, 0);
            this.BtnUpdate.Size = new System.Drawing.Size(150, 34);
            this.BtnUpdate.TabIndex = 52;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdate.UseVisualStyleBackColor = false;
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
            this.BtnInsert.Location = new System.Drawing.Point(780, 77);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Padding = new System.Windows.Forms.Padding(35, 0, 25, 0);
            this.BtnInsert.Size = new System.Drawing.Size(150, 34);
            this.BtnInsert.TabIndex = 51;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInsert.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(995, 251);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(825, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Date:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(780, 388);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 25, 0);
            this.button1.Size = new System.Drawing.Size(484, 34);
            this.button1.TabIndex = 64;
            this.button1.Text = "Medicine Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DtpExp
            // 
            this.DtpExp.Location = new System.Drawing.Point(995, 593);
            this.DtpExp.Name = "DtpExp";
            this.DtpExp.Size = new System.Drawing.Size(200, 23);
            this.DtpExp.TabIndex = 74;
            // 
            // NumQty
            // 
            this.NumQty.Location = new System.Drawing.Point(995, 533);
            this.NumQty.Name = "NumQty";
            this.NumQty.Size = new System.Drawing.Size(200, 23);
            this.NumQty.TabIndex = 73;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(995, 561);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(825, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(825, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 70;
            this.label6.Text = "Expired Date:";
            // 
            // CbSection
            // 
            this.CbSection.FormattingEnabled = true;
            this.CbSection.Items.AddRange(new object[] {
            "masih",
            "kosong"});
            this.CbSection.Location = new System.Drawing.Point(995, 501);
            this.CbSection.Name = "CbSection";
            this.CbSection.Size = new System.Drawing.Size(200, 25);
            this.CbSection.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(825, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(825, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Quantity:";
            // 
            // TbMedicName
            // 
            this.TbMedicName.Location = new System.Drawing.Point(995, 472);
            this.TbMedicName.Name = "TbMedicName";
            this.TbMedicName.Size = new System.Drawing.Size(200, 23);
            this.TbMedicName.TabIndex = 66;
            this.TbMedicName.Text = "-Pick List-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(825, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Medicine\'s Name:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(28, 426);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(706, 224);
            this.dataGridView2.TabIndex = 75;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(779, 153);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 25, 0);
            this.button2.Size = new System.Drawing.Size(484, 34);
            this.button2.TabIndex = 76;
            this.button2.Text = "Medicine Transaction";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // MedicinePurchaseHeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 724);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.DtpExp);
            this.Controls.Add(this.NumQty);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbMedicName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CbSearchBy);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicinePurchaseHeaderForm";
            this.Text = "Medicine Stock -  Admin Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DtpExp;
        private System.Windows.Forms.NumericUpDown NumQty;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbMedicName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
    }
}