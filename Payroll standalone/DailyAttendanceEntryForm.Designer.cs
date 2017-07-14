﻿namespace Payroll_standalone
{
    partial class DailyAttendanceEntryForm
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
            this.dataSet1 = new System.Data.DataSet();
            this.FormTitle = new System.Windows.Forms.Label();
            this.panelTableEntry = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClrRow = new System.Windows.Forms.Button();
            this.btnAddSingle = new System.Windows.Forms.Button();
            this.btnClrAll = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSingleEntry = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBxEmpID = new System.Windows.Forms.ComboBox();
            this.tbxEmpName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panelTableEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSingleEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.Font = new System.Drawing.Font("Arial Narrow", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.Location = new System.Drawing.Point(130, 53);
            this.FormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(881, 88);
            this.FormTitle.TabIndex = 0;
            this.FormTitle.Text = "Daily Attendance Entry Form";
            // 
            // panelTableEntry
            // 
            this.panelTableEntry.Controls.Add(this.label9);
            this.panelTableEntry.Controls.Add(this.btnClrRow);
            this.panelTableEntry.Controls.Add(this.btnAddSingle);
            this.panelTableEntry.Controls.Add(this.btnClrAll);
            this.panelTableEntry.Controls.Add(this.btnSubmit);
            this.panelTableEntry.Controls.Add(this.dateTimePicker1);
            this.panelTableEntry.Controls.Add(this.dataGridView1);
            this.panelTableEntry.Controls.Add(this.label1);
            this.panelTableEntry.Location = new System.Drawing.Point(90, 230);
            this.panelTableEntry.Margin = new System.Windows.Forms.Padding(4);
            this.panelTableEntry.Name = "panelTableEntry";
            this.panelTableEntry.Size = new System.Drawing.Size(1651, 1014);
            this.panelTableEntry.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(158, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "(yyyy-mm-dd)";
            // 
            // btnClrRow
            // 
            this.btnClrRow.Location = new System.Drawing.Point(1371, 759);
            this.btnClrRow.Name = "btnClrRow";
            this.btnClrRow.Size = new System.Drawing.Size(237, 77);
            this.btnClrRow.TabIndex = 6;
            this.btnClrRow.Text = "Clear Row";
            this.btnClrRow.UseVisualStyleBackColor = true;
            this.btnClrRow.Click += new System.EventHandler(this.btnClrRow_Click);
            // 
            // btnAddSingle
            // 
            this.btnAddSingle.Location = new System.Drawing.Point(1309, 31);
            this.btnAddSingle.Name = "btnAddSingle";
            this.btnAddSingle.Size = new System.Drawing.Size(286, 77);
            this.btnAddSingle.TabIndex = 7;
            this.btnAddSingle.Text = "Single Record Entry";
            this.btnAddSingle.UseVisualStyleBackColor = true;
            this.btnAddSingle.Click += new System.EventHandler(this.btnAddSingle_Click);
            // 
            // btnClrAll
            // 
            this.btnClrAll.Location = new System.Drawing.Point(1371, 882);
            this.btnClrAll.Name = "btnClrAll";
            this.btnClrAll.Size = new System.Drawing.Size(237, 77);
            this.btnClrAll.TabIndex = 5;
            this.btnClrAll.Text = "Clear All";
            this.btnClrAll.UseVisualStyleBackColor = true;
            this.btnClrAll.Click += new System.EventHandler(this.btnClrAll_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1371, 629);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(237, 77);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(557, 40);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName,
            this.InTime,
            this.OutTime,
            this.Absent});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(55, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 826);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // EmpID
            // 
            this.EmpID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EmpID.Frozen = true;
            this.EmpID.HeaderText = "Employee ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            this.EmpID.Width = 208;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpName.FillWeight = 400F;
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // InTime
            // 
            this.InTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.InTime.HeaderText = "In Time";
            this.InTime.Name = "InTime";
            this.InTime.Width = 146;
            // 
            // OutTime
            // 
            this.OutTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OutTime.HeaderText = "Out Time";
            this.OutTime.Name = "OutTime";
            this.OutTime.Width = 167;
            // 
            // Absent
            // 
            this.Absent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Absent.FillWeight = 10F;
            this.Absent.HeaderText = "Absent";
            this.Absent.Name = "Absent";
            this.Absent.Width = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // panelSingleEntry
            // 
            this.panelSingleEntry.Controls.Add(this.label7);
            this.panelSingleEntry.Controls.Add(this.dateTimePicker4);
            this.panelSingleEntry.Controls.Add(this.dateTimePicker3);
            this.panelSingleEntry.Controls.Add(this.btnAddAll);
            this.panelSingleEntry.Controls.Add(this.button2);
            this.panelSingleEntry.Controls.Add(this.btnClear);
            this.panelSingleEntry.Controls.Add(this.btnNext);
            this.panelSingleEntry.Controls.Add(this.label6);
            this.panelSingleEntry.Controls.Add(this.label5);
            this.panelSingleEntry.Controls.Add(this.label4);
            this.panelSingleEntry.Controls.Add(this.dateTimePicker2);
            this.panelSingleEntry.Controls.Add(this.label3);
            this.panelSingleEntry.Controls.Add(this.label2);
            this.panelSingleEntry.Controls.Add(this.cBxEmpID);
            this.panelSingleEntry.Controls.Add(this.tbxEmpName);
            this.panelSingleEntry.Location = new System.Drawing.Point(90, 230);
            this.panelSingleEntry.Name = "panelSingleEntry";
            this.panelSingleEntry.Size = new System.Drawing.Size(1651, 1014);
            this.panelSingleEntry.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "(yyyy-mm-dd)";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "h:mm tt";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(391, 495);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(530, 40);
            this.dateTimePicker4.TabIndex = 11;
            this.dateTimePicker4.Value = new System.DateTime(2017, 7, 13, 17, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "h:mm tt";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(391, 389);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(530, 40);
            this.dateTimePicker3.TabIndex = 10;
            this.dateTimePicker3.Value = new System.DateTime(2017, 7, 13, 8, 0, 0, 0);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(1309, 45);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(286, 77);
            this.btnAddAll.TabIndex = 8;
            this.btnAddAll.Text = "Table Entry";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1309, 794);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 82);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1309, 671);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(299, 82);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1309, 541);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(299, 82);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next Entry";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Out Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "In Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Employee Name";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(391, 68);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(530, 40);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // cBxEmpID
            // 
            this.cBxEmpID.FormattingEnabled = true;
            this.cBxEmpID.Location = new System.Drawing.Point(391, 172);
            this.cBxEmpID.Name = "cBxEmpID";
            this.cBxEmpID.Size = new System.Drawing.Size(530, 41);
            this.cBxEmpID.TabIndex = 1;
            this.cBxEmpID.SelectedIndexChanged += new System.EventHandler(this.cBxEmpID_SelectedIndexChanged);
            // 
            // tbxEmpName
            // 
            this.tbxEmpName.Location = new System.Drawing.Point(391, 281);
            this.tbxEmpName.Name = "tbxEmpName";
            this.tbxEmpName.ReadOnly = true;
            this.tbxEmpName.Size = new System.Drawing.Size(530, 40);
            this.tbxEmpName.TabIndex = 2;
            // 
            // DailyAttendanceEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1790, 1304);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.panelTableEntry);
            this.Controls.Add(this.panelSingleEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DailyAttendanceEntryForm";
            this.Text = "Attendance Entry";
            this.Load += new System.EventHandler(this.DailyAttendanceEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panelTableEntry.ResumeLayout(false);
            this.panelTableEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSingleEntry.ResumeLayout(false);
            this.panelSingleEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Panel panelTableEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panelSingleEntry;
        private System.Windows.Forms.TextBox tbxEmpName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClrAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBxEmpID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClrRow;
        private System.Windows.Forms.Button btnAddSingle;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Absent;
    }
}

