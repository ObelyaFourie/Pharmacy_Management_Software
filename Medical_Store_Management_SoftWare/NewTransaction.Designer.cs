﻿namespace Medical_Store_Management_SoftWare
{
    partial class NewTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTransaction));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Mobile = new System.Windows.Forms.TextBox();
            this.lbl_ShowDate = new System.Windows.Forms.Label();
            this.lbl_ShowBill = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cBox_Item = new System.Windows.Forms.ComboBox();
            this.lbl_Item = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cBox_Quantity = new System.Windows.Forms.ComboBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile: ";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(122, 20);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(142, 24);
            this.txt_Name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(332, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Bill: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(332, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date: ";
            // 
            // txt_Mobile
            // 
            this.txt_Mobile.Location = new System.Drawing.Point(122, 82);
            this.txt_Mobile.Name = "txt_Mobile";
            this.txt_Mobile.Size = new System.Drawing.Size(142, 24);
            this.txt_Mobile.TabIndex = 5;
            // 
            // lbl_ShowDate
            // 
            this.lbl_ShowDate.AutoSize = true;
            this.lbl_ShowDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ShowDate.Location = new System.Drawing.Point(367, 18);
            this.lbl_ShowDate.Name = "lbl_ShowDate";
            this.lbl_ShowDate.Size = new System.Drawing.Size(0, 18);
            this.lbl_ShowDate.TabIndex = 6;
            // 
            // lbl_ShowBill
            // 
            this.lbl_ShowBill.AutoSize = true;
            this.lbl_ShowBill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ShowBill.Location = new System.Drawing.Point(367, 46);
            this.lbl_ShowBill.Name = "lbl_ShowBill";
            this.lbl_ShowBill.Size = new System.Drawing.Size(0, 18);
            this.lbl_ShowBill.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(629, 202);
            this.dataGridView1.TabIndex = 8;
            // 
            // cBox_Item
            // 
            this.cBox_Item.FormattingEnabled = true;
            this.cBox_Item.Location = new System.Drawing.Point(122, 145);
            this.cBox_Item.Name = "cBox_Item";
            this.cBox_Item.Size = new System.Drawing.Size(142, 26);
            this.cBox_Item.TabIndex = 9;
            this.cBox_Item.SelectedIndexChanged += new System.EventHandler(this.cBox_Item_SelectedIndexChanged);
            // 
            // lbl_Item
            // 
            this.lbl_Item.AutoSize = true;
            this.lbl_Item.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item.ForeColor = System.Drawing.Color.Black;
            this.lbl_Item.Location = new System.Drawing.Point(15, 141);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Size = new System.Drawing.Size(75, 33);
            this.lbl_Item.TabIndex = 10;
            this.lbl_Item.Text = "Item: ";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Black;
            this.lbl_Quantity.Location = new System.Drawing.Point(332, 140);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(127, 33);
            this.lbl_Quantity.TabIndex = 11;
            this.lbl_Quantity.Text = "Quantity: ";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(505, 447);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(136, 35);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cBox_Quantity
            // 
            this.cBox_Quantity.FormattingEnabled = true;
            this.cBox_Quantity.Location = new System.Drawing.Point(505, 140);
            this.cBox_Quantity.Name = "cBox_Quantity";
            this.cBox_Quantity.Size = new System.Drawing.Size(142, 26);
            this.cBox_Quantity.TabIndex = 13;
            this.cBox_Quantity.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.ForeColor = System.Drawing.Color.Black;
            this.btn_Ok.Location = new System.Drawing.Point(585, 181);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(56, 33);
            this.btn_Ok.TabIndex = 14;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(12, 447);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(47, 29);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "X";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // NewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(653, 500);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.cBox_Quantity);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Item);
            this.Controls.Add(this.cBox_Item);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_ShowBill);
            this.Controls.Add(this.lbl_ShowDate);
            this.Controls.Add(this.txt_Mobile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewTransaction";
            this.Text = "NewTransation";
            this.Load += new System.EventHandler(this.NewTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Mobile;
        private System.Windows.Forms.Label lbl_ShowDate;
        private System.Windows.Forms.Label lbl_ShowBill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cBox_Item;
        private System.Windows.Forms.Label lbl_Item;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ComboBox cBox_Quantity;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}