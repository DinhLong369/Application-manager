﻿using System;
using System.Windows.Forms;

namespace QuanLyQuanLauNuong
{
    partial class fAdmin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.tbFoodCategory = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTableID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txbPassAcc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpFood.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.tbFoodCategory.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.panel8.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tbFoodCategory);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(0, 2);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1314, 864);
            this.tcAdmin.TabIndex = 2;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 29);
            this.tpBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpBill.Size = new System.Drawing.Size(1306, 831);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh Thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvBill);
            this.panel2.Location = new System.Drawing.Point(9, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 720);
            this.panel2.TabIndex = 2;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(3, 4);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 51;
            this.dtgvBill.RowTemplate.Height = 24;
            this.dtgvBill.Size = new System.Drawing.Size(1277, 712);
            this.dtgvBill.TabIndex = 0;
            this.dtgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewBill);
            this.panel1.Controls.Add(this.dtpkToDate);
            this.panel1.Controls.Add(this.dtpkFromDate);
            this.panel1.Location = new System.Drawing.Point(9, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 85);
            this.panel1.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(531, 4);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(169, 72);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Location = new System.Drawing.Point(749, 20);
            this.dtpkToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(509, 31);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Location = new System.Drawing.Point(20, 20);
            this.dtpkFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(456, 31);
            this.dtpkFromDate.TabIndex = 0;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 29);
            this.tpFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpFood.Size = new System.Drawing.Size(1306, 831);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức Ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmFoodPrice);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.cbFoodCategory);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txbFoodName);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txbFoodID);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(686, 131);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(606, 678);
            this.panel6.TabIndex = 7;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmFoodPrice.Location = new System.Drawing.Point(170, 284);
            this.nmFoodPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(423, 35);
            this.nmFoodPrice.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Giá:";
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(170, 199);
            this.cbFoodCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(422, 37);
            this.cbFoodCategory.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Danh mục:";
            // 
            // txbFoodName
            // 
            this.txbFoodName.AcceptsReturn = true;
            this.txbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFoodName.Location = new System.Drawing.Point(170, 116);
            this.txbFoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(422, 35);
            this.txbFoodName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên món:";
            // 
            // txbFoodID
            // 
            this.txbFoodID.AcceptsReturn = true;
            this.txbFoodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFoodID.Location = new System.Drawing.Point(170, 46);
            this.txbFoodID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(422, 35);
            this.txbFoodID.TabIndex = 23;
            this.txbFoodID.TextChanged += new System.EventHandler(this.txbFoodID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbSearchFoodName);
            this.panel5.Controls.Add(this.btnSearchFood);
            this.panel5.Location = new System.Drawing.Point(686, 20);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(606, 104);
            this.panel5.TabIndex = 6;
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchFoodName.Location = new System.Drawing.Point(38, 29);
            this.txbSearchFoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(408, 35);
            this.txbSearchFoodName.TabIndex = 19;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(474, 15);
            this.btnSearchFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(119, 72);
            this.btnSearchFood.TabIndex = 4;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShowFood);
            this.panel4.Controls.Add(this.btnEditFood);
            this.panel4.Controls.Add(this.btnDeleteFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(12, 20);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(667, 104);
            this.panel4.TabIndex = 5;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(486, 15);
            this.btnShowFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(119, 72);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(342, 15);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(119, 72);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(200, 15);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(119, 72);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xoá";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(60, 15);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(119, 72);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvFood);
            this.panel3.Location = new System.Drawing.Point(12, 131);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 678);
            this.panel3.TabIndex = 4;
            // 
            // dtgvFood
            // 
            this.dtgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(0, 0);
            this.dtgvFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.RowTemplate.Height = 24;
            this.dtgvFood.Size = new System.Drawing.Size(664, 676);
            this.dtgvFood.TabIndex = 0;
            // 
            // tbFoodCategory
            // 
            this.tbFoodCategory.Controls.Add(this.panel10);
            this.tbFoodCategory.Controls.Add(this.panel9);
            this.tbFoodCategory.Controls.Add(this.panel7);
            this.tbFoodCategory.Location = new System.Drawing.Point(4, 29);
            this.tbFoodCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFoodCategory.Name = "tbFoodCategory";
            this.tbFoodCategory.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFoodCategory.Size = new System.Drawing.Size(1306, 831);
            this.tbFoodCategory.TabIndex = 2;
            this.tbFoodCategory.Text = "Danh Mục";
            this.tbFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtgvCategory);
            this.panel10.Location = new System.Drawing.Point(9, 131);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(667, 678);
            this.panel10.TabIndex = 6;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(1, 1);
            this.dtgvCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.RowTemplate.Height = 24;
            this.dtgvCategory.Size = new System.Drawing.Size(664, 676);
            this.dtgvCategory.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbCategoryName);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.txbCategoryID);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(683, 131);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(613, 678);
            this.panel9.TabIndex = 5;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.AcceptsReturn = true;
            this.txbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoryName.Location = new System.Drawing.Point(243, 122);
            this.txbCategoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(354, 35);
            this.txbCategoryName.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 32);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tên danh mục:";
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.AcceptsReturn = true;
            this.txbCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoryID.Location = new System.Drawing.Point(243, 52);
            this.txbCategoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.ReadOnly = true;
            this.txbCategoryID.Size = new System.Drawing.Size(354, 35);
            this.txbCategoryID.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "ID:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnShowCategory);
            this.panel7.Controls.Add(this.btnEditCategory);
            this.panel7.Controls.Add(this.btnDeleteCategory);
            this.panel7.Controls.Add(this.btnAddCategory);
            this.panel7.Location = new System.Drawing.Point(9, 20);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(667, 104);
            this.panel7.TabIndex = 4;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Location = new System.Drawing.Point(487, 15);
            this.btnShowCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(119, 72);
            this.btnShowCategory.TabIndex = 7;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(343, 15);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(119, 72);
            this.btnEditCategory.TabIndex = 6;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(201, 15);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(119, 72);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Xoá";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(61, 15);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(119, 72);
            this.btnAddCategory.TabIndex = 4;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel12);
            this.tpTable.Controls.Add(this.panel11);
            this.tpTable.Controls.Add(this.panel8);
            this.tpTable.Location = new System.Drawing.Point(4, 29);
            this.tpTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpTable.Size = new System.Drawing.Size(1306, 831);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Bàn Ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            this.tpTable.Click += new System.EventHandler(this.tpTable_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txbTableName);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.txbTableID);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Location = new System.Drawing.Point(681, 131);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(615, 678);
            this.panel12.TabIndex = 5;
            // 
            // txbTableName
            // 
            this.txbTableName.AcceptsReturn = true;
            this.txbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTableName.Location = new System.Drawing.Point(227, 115);
            this.txbTableName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(370, 35);
            this.txbTableName.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tên bàn:";
            // 
            // txbTableID
            // 
            this.txbTableID.AcceptsReturn = true;
            this.txbTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTableID.Location = new System.Drawing.Point(227, 45);
            this.txbTableID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTableID.Name = "txbTableID";
            this.txbTableID.ReadOnly = true;
            this.txbTableID.Size = new System.Drawing.Size(370, 35);
            this.txbTableID.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 32);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dtgvTable);
            this.panel11.Location = new System.Drawing.Point(9, 131);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(667, 678);
            this.panel11.TabIndex = 4;
            // 
            // dtgvTable
            // 
            this.dtgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(1, 1);
            this.dtgvTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(664, 676);
            this.dtgvTable.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnShowTable);
            this.panel8.Controls.Add(this.btnEditTable);
            this.panel8.Controls.Add(this.btnDeleteTable);
            this.panel8.Controls.Add(this.btnAddTable);
            this.panel8.Location = new System.Drawing.Point(9, 20);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(667, 104);
            this.panel8.TabIndex = 3;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Location = new System.Drawing.Point(487, 15);
            this.btnShowTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(119, 72);
            this.btnShowTable.TabIndex = 11;
            this.btnShowTable.Text = "Xem";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Location = new System.Drawing.Point(343, 15);
            this.btnEditTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(119, 72);
            this.btnEditTable.TabIndex = 10;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(201, 15);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(119, 72);
            this.btnDeleteTable.TabIndex = 9;
            this.btnDeleteTable.Text = "Xoá";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(61, 15);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(119, 72);
            this.btnAddTable.TabIndex = 8;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel15);
            this.tpAccount.Controls.Add(this.panel14);
            this.tpAccount.Controls.Add(this.panel13);
            this.tpAccount.Location = new System.Drawing.Point(4, 29);
            this.tpAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpAccount.Size = new System.Drawing.Size(1306, 831);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài Khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txbPassAcc);
            this.panel15.Controls.Add(this.label13);
            this.panel15.Controls.Add(this.numericUpDown1);
            this.panel15.Controls.Add(this.label9);
            this.panel15.Controls.Add(this.label10);
            this.panel15.Controls.Add(this.txbDisplayName);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Controls.Add(this.txbUserName);
            this.panel15.Controls.Add(this.label12);
            this.panel15.Location = new System.Drawing.Point(683, 131);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(613, 678);
            this.panel15.TabIndex = 5;
            // 
            // txbPassAcc
            // 
            this.txbPassAcc.AcceptsReturn = true;
            this.txbPassAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassAcc.Location = new System.Drawing.Point(227, 199);
            this.txbPassAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPassAcc.Name = "txbPassAcc";
            this.txbPassAcc.Size = new System.Drawing.Size(370, 35);
            this.txbPassAcc.TabIndex = 50;
            this.txbPassAcc.TabStop = false;
            this.txbPassAcc.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 32);
            this.label13.TabIndex = 49;
            this.label13.Text = "Mật khẩu: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(227, 268);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(370, 35);
            this.numericUpDown1.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 32);
            this.label10.TabIndex = 44;
            this.label10.Text = "Loại tài khoản:";
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.AcceptsReturn = true;
            this.txbDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayName.Location = new System.Drawing.Point(227, 128);
            this.txbDisplayName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(370, 35);
            this.txbDisplayName.TabIndex = 43;
            this.txbDisplayName.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 32);
            this.label11.TabIndex = 42;
            this.label11.Text = "Tên hiển thị:";
            // 
            // txbUserName
            // 
            this.txbUserName.AcceptsReturn = true;
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(227, 58);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(370, 35);
            this.txbUserName.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 32);
            this.label12.TabIndex = 40;
            this.label12.Text = "Tên tài khoản:";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dtgvAccount);
            this.panel14.Location = new System.Drawing.Point(9, 131);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(667, 678);
            this.panel14.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(1, 1);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 40;
            this.dtgvAccount.RowTemplate.Height = 24;
            this.dtgvAccount.Size = new System.Drawing.Size(664, 676);
            this.dtgvAccount.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnShowAccount);
            this.panel13.Controls.Add(this.btnEditAccount);
            this.panel13.Controls.Add(this.btnDeleteAccount);
            this.panel13.Controls.Add(this.btnAddAccount);
            this.panel13.Location = new System.Drawing.Point(9, 20);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(667, 104);
            this.panel13.TabIndex = 3;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(487, 15);
            this.btnShowAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(119, 72);
            this.btnShowAccount.TabIndex = 11;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(343, 15);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(119, 72);
            this.btnEditAccount.TabIndex = 10;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(201, 15);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(119, 72);
            this.btnDeleteAccount.TabIndex = 9;
            this.btnDeleteAccount.Text = "Xoá";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(61, 15);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(119, 72);
            this.btnAddAccount.TabIndex = 8;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 869);
            this.Controls.Add(this.tcAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.tcAdmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.tbFoodCategory.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.panel8.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbSearchFoodName;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.TabPage tbFoodCategory;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTableID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txbPassAcc;
        private System.Windows.Forms.Label label13;
        private DataGridViewCellEventHandler dtgvBill_CellContentClick;
        private EventHandler tpTable_Click;
    }
}