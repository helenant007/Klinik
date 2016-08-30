namespace Klinik.Admin.MainForms
{
    partial class MedicinePurchaseDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicinePurchaseDetailForm));
            this.BtnSearch = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbSearchBy = new System.Windows.Forms.ComboBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbSection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbMedicName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NumQty = new System.Windows.Forms.NumericUpDown();
            this.DtpExp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQty)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.LightGray;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(1164, 16);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 59;
            this.BtnSearch.Text = "Search!";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(937, 16);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(221, 23);
            this.textBox8.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.Location = new System.Drawing.Point(702, 17);
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
            this.CbSearchBy.Location = new System.Drawing.Point(785, 16);
            this.CbSearchBy.Name = "CbSearchBy";
            this.CbSearchBy.Size = new System.Drawing.Size(146, 25);
            this.CbSearchBy.TabIndex = 56;
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(929, 262);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(200, 23);
            this.TbPrice.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(807, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(807, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Expired Date:";
            // 
            // CbSection
            // 
            this.CbSection.FormattingEnabled = true;
            this.CbSection.Items.AddRange(new object[] {
            "masih",
            "kosong"});
            this.CbSection.Location = new System.Drawing.Point(929, 202);
            this.CbSection.Name = "CbSection";
            this.CbSection.Size = new System.Drawing.Size(200, 25);
            this.CbSection.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(807, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Quantity:";
            // 
            // TbMedicName
            // 
            this.TbMedicName.Location = new System.Drawing.Point(929, 173);
            this.TbMedicName.Name = "TbMedicName";
            this.TbMedicName.Size = new System.Drawing.Size(200, 23);
            this.TbMedicName.TabIndex = 34;
            this.TbMedicName.Text = "-Pick List-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(807, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Medicine\'s Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 61);
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
            this.label1.Location = new System.Drawing.Point(207, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Month:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(319, 14);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 25);
            this.comboBox1.TabIndex = 30;
            // 
            // NumQty
            // 
            this.NumQty.Location = new System.Drawing.Point(929, 234);
            this.NumQty.Name = "NumQty";
            this.NumQty.Size = new System.Drawing.Size(200, 23);
            this.NumQty.TabIndex = 60;
            // 
            // DtpExp
            // 
            this.DtpExp.Location = new System.Drawing.Point(929, 294);
            this.DtpExp.Name = "DtpExp";
            this.DtpExp.Size = new System.Drawing.Size(200, 23);
            this.DtpExp.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Medicine Purchase Id: ";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Klinik.Admin.Properties.Resources.cancel;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1029, 938);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.button2.Size = new System.Drawing.Size(150, 34);
            this.button2.TabIndex = 78;
            this.button2.Text = "Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(851, 938);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 25, 0);
            this.button3.Size = new System.Drawing.Size(150, 34);
            this.button3.TabIndex = 77;
            this.button3.Text = "Save";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = global::Klinik.Admin.Properties.Resources.delete;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1099, 61);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.button4.Size = new System.Drawing.Size(150, 34);
            this.button4.TabIndex = 76;
            this.button4.Text = "Delete";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::Klinik.Admin.Properties.Resources.update;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(934, 61);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 15, 0);
            this.button5.Size = new System.Drawing.Size(150, 34);
            this.button5.TabIndex = 75;
            this.button5.Text = "Update";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Image = global::Klinik.Admin.Properties.Resources.insert;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(765, 61);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 25, 0);
            this.button6.Size = new System.Drawing.Size(150, 34);
            this.button6.TabIndex = 74;
            this.button6.Text = "Insert";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // MedicinePurchaseDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 1023);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpExp);
            this.Controls.Add(this.NumQty);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CbSearchBy);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbMedicName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicinePurchaseDetailForm";
            this.Text = "z";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbSearchBy;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbMedicName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown NumQty;
        private System.Windows.Forms.DateTimePicker DtpExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}