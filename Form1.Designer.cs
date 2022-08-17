
namespace WinFormsApp_EmployeeDatabaseCRUDApplications
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
            this.dtgrdEmployeeRecords = new System.Windows.Forms.DataGridView();
            this.grpAddRecord = new System.Windows.Forms.GroupBox();
            this.btnAddNewRecord = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmployeID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.dttmDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbbxDepartment = new System.Windows.Forms.ComboBox();
            this.grpDisplayRecords = new System.Windows.Forms.GroupBox();
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.grpUpdateRecord = new System.Windows.Forms.GroupBox();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.grpDeleteRecord = new System.Windows.Forms.GroupBox();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdEmployeeRecords)).BeginInit();
            this.grpAddRecord.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpDisplayRecords.SuspendLayout();
            this.grpUpdateRecord.SuspendLayout();
            this.grpDeleteRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrdEmployeeRecords
            // 
            this.dtgrdEmployeeRecords.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dtgrdEmployeeRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdEmployeeRecords.GridColor = System.Drawing.Color.Bisque;
            this.dtgrdEmployeeRecords.Location = new System.Drawing.Point(0, 50);
            this.dtgrdEmployeeRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgrdEmployeeRecords.Name = "dtgrdEmployeeRecords";
            this.dtgrdEmployeeRecords.Size = new System.Drawing.Size(1186, 377);
            this.dtgrdEmployeeRecords.TabIndex = 0;
            // 
            // grpAddRecord
            // 
            this.grpAddRecord.Controls.Add(this.btnAddNewRecord);
            this.grpAddRecord.Controls.Add(this.tableLayoutPanel1);
            this.grpAddRecord.Location = new System.Drawing.Point(28, 453);
            this.grpAddRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAddRecord.Name = "grpAddRecord";
            this.grpAddRecord.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAddRecord.Size = new System.Drawing.Size(489, 287);
            this.grpAddRecord.TabIndex = 1;
            this.grpAddRecord.TabStop = false;
            this.grpAddRecord.Text = "Add New Employee Record";
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Location = new System.Drawing.Point(155, 222);
            this.btnAddNewRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Size = new System.Drawing.Size(145, 28);
            this.btnAddNewRecord.TabIndex = 1;
            this.btnAddNewRecord.Text = "Add New Record";
            this.btnAddNewRecord.UseVisualStyleBackColor = true;
            this.btnAddNewRecord.Click += new System.EventHandler(this.btnAddNewRecord_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.39362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.60638F));
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDateOfBirth, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDepartment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtEmployeeID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dttmDateOfBirth, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbbxDepartment, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 46);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(119, 62);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(301, 24);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(119, 33);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(301, 24);
            this.txtFirstName.TabIndex = 10;
            // 
            // lblEmployeID
            // 
            this.lblEmployeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeID.AutoSize = true;
            this.lblEmployeID.Location = new System.Drawing.Point(17, 6);
            this.lblEmployeID.Name = "lblEmployeID";
            this.lblEmployeID.Size = new System.Drawing.Size(82, 16);
            this.lblEmployeID.TabIndex = 0;
            this.lblEmployeID.Text = "Employee ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(74, 16);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(22, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(11, 93);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(93, 16);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(19, 124);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(77, 16);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Department";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(119, 4);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(301, 24);
            this.txtEmployeeID.TabIndex = 9;
            // 
            // dttmDateOfBirth
            // 
            this.dttmDateOfBirth.CustomFormat = "yyyy-mm-dd";
            this.dttmDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttmDateOfBirth.Location = new System.Drawing.Point(119, 91);
            this.dttmDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dttmDateOfBirth.Name = "dttmDateOfBirth";
            this.dttmDateOfBirth.Size = new System.Drawing.Size(301, 24);
            this.dttmDateOfBirth.TabIndex = 14;
            // 
            // cmbbxDepartment
            // 
            this.cmbbxDepartment.FormattingEnabled = true;
            this.cmbbxDepartment.Location = new System.Drawing.Point(119, 120);
            this.cmbbxDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbxDepartment.Name = "cmbbxDepartment";
            this.cmbbxDepartment.Size = new System.Drawing.Size(301, 24);
            this.cmbbxDepartment.TabIndex = 15;
            // 
            // grpDisplayRecords
            // 
            this.grpDisplayRecords.Controls.Add(this.btnRefreshGrid);
            this.grpDisplayRecords.Controls.Add(this.dtgrdEmployeeRecords);
            this.grpDisplayRecords.Location = new System.Drawing.Point(23, 18);
            this.grpDisplayRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDisplayRecords.Name = "grpDisplayRecords";
            this.grpDisplayRecords.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDisplayRecords.Size = new System.Drawing.Size(1186, 427);
            this.grpDisplayRecords.TabIndex = 2;
            this.grpDisplayRecords.TabStop = false;
            this.grpDisplayRecords.Text = "Display All Employee Records";
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(495, 20);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(115, 23);
            this.btnRefreshGrid.TabIndex = 1;
            this.btnRefreshGrid.Text = "Refresh Grid";
            this.btnRefreshGrid.UseVisualStyleBackColor = true;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
            // 
            // grpUpdateRecord
            // 
            this.grpUpdateRecord.Controls.Add(this.btnUpdateRecord);
            this.grpUpdateRecord.Location = new System.Drawing.Point(536, 456);
            this.grpUpdateRecord.Name = "grpUpdateRecord";
            this.grpUpdateRecord.Size = new System.Drawing.Size(351, 284);
            this.grpUpdateRecord.TabIndex = 3;
            this.grpUpdateRecord.TabStop = false;
            this.grpUpdateRecord.Text = "Update Employee Record";
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(95, 219);
            this.btnUpdateRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(145, 28);
            this.btnUpdateRecord.TabIndex = 2;
            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            // 
            // grpDeleteRecord
            // 
            this.grpDeleteRecord.Controls.Add(this.btnDeleteRecord);
            this.grpDeleteRecord.Location = new System.Drawing.Point(909, 456);
            this.grpDeleteRecord.Name = "grpDeleteRecord";
            this.grpDeleteRecord.Size = new System.Drawing.Size(281, 283);
            this.grpDeleteRecord.TabIndex = 4;
            this.grpDeleteRecord.TabStop = false;
            this.grpDeleteRecord.Text = "Delete Employee Record";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(65, 219);
            this.btnDeleteRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(145, 28);
            this.btnDeleteRecord.TabIndex = 3;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1232, 809);
            this.Controls.Add(this.grpDeleteRecord);
            this.Controls.Add(this.grpUpdateRecord);
            this.Controls.Add(this.grpDisplayRecords);
            this.Controls.Add(this.grpAddRecord);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Employee Management Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdEmployeeRecords)).EndInit();
            this.grpAddRecord.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpDisplayRecords.ResumeLayout(false);
            this.grpUpdateRecord.ResumeLayout(false);
            this.grpDeleteRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdEmployeeRecords;
        private System.Windows.Forms.GroupBox grpAddRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddNewRecord;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEmployeID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.DateTimePicker dttmDateOfBirth;
        private System.Windows.Forms.ComboBox cmbbxDepartment;
        private System.Windows.Forms.GroupBox grpDisplayRecords;
        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.GroupBox grpUpdateRecord;
        private System.Windows.Forms.GroupBox grpDeleteRecord;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
    }
}

