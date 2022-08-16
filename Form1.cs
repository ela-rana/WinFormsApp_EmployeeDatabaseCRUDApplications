using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_EmployeeDatabaseCRUDApplications
{
    public partial class Form1 : Form
    {
        EmpRepository empRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empRepository = new EmpRepository();
            dtgrdEmployeeRecords.DataSource = empRepository.GetAllRecords();
            dtgrdEmployeeRecords.Columns[5].Visible = false;
            txtEmployeeID.ReadOnly = true;
            //filling the combo with dept names instead of id
            foreach (var d in empRepository.GetAllDepartments())
                cmbbxDepartment.Items.Add(d.DeptName);
            RefreshAddRecordFields();
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEmployeeID.Text) && !string.IsNullOrEmpty(txtFirstName.Text) &&
               !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(dttmDateOfBirth.Text) &&
               !string.IsNullOrEmpty(cmbbxDepartment.Text) )
            {
                var newEmp = new Employee();
                newEmp.EmpID = Int32.Parse(txtEmployeeID.Text);
                newEmp.FirstName = txtFirstName.Text;
                newEmp.LastName = txtLastName.Text;
                newEmp.DateOfBirth = DateTime.Parse(dttmDateOfBirth.Text);
                newEmp.DeptID = cmbbxDepartment.SelectedIndex + 1;
            }
        }            
        internal void RefreshAddRecordFields()
        {
            txtEmployeeID.Clear();
            txtEmployeeID.Text = (empRepository.GetMaxId() + 1).ToString();
            txtFirstName.Clear();
            txtLastName.Clear();
            dttmDateOfBirth.CustomFormat = "";
            //filling the combo with dept names instead of id
            foreach (var d in empRepository.GetAllDepartments())
                cmbbxDepartment.Items.Add(d.DeptName);
            cmbbxDepartment.SelectedIndex = -1;

        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            dtgrdEmployeeRecords.DataSource = null;
            dtgrdEmployeeRecords.DataSource = empRepository.GetAllRecords();
            dtgrdEmployeeRecords.Columns[5].Visible = false;

        }
    }
}
