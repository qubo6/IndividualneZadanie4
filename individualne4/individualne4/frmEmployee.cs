using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individualne4
{
    public partial class frmEmployee : Form
    {
        private EmployeeViewModel _employeeViewModel = new EmployeeViewModel();
        public int DirectorId { get; set; }
        public frmEmployee()
        {
            InitializeComponent();
            FillGrid();
        }

        private void FillGrid()
        {
            dgwEmployee.DataSource = _employeeViewModel.GetAllEmployees();
            dgwEmployee.Columns[0].Visible = false;
            dgwEmployee.Columns[6].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmployee addEmployee = new frmAddEmployee();
            if (addEmployee.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _employeeViewModel.DeleteEmployee(Convert.ToInt32(dgwEmployee.SelectedRows[0].Cells[0].Value));
            FillGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DirectorId = Convert.ToInt32(dgwEmployee.SelectedRows[0].Cells[0].Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ModelEmployee modelEmployee = new ModelEmployee();
            modelEmployee.Id = Convert.ToInt32(dgwEmployee.SelectedRows[0].Cells[0].Value);
            modelEmployee.Title = (dgwEmployee.SelectedRows[0].Cells[1].Value).ToString();
            modelEmployee.FirstName = (dgwEmployee.SelectedRows[0].Cells[2].Value).ToString();
            modelEmployee.LastName = (dgwEmployee.SelectedRows[0].Cells[3].Value).ToString();
            modelEmployee.Phone = (dgwEmployee.SelectedRows[0].Cells[4].Value).ToString();
            modelEmployee.Email = (dgwEmployee.SelectedRows[0].Cells[5].Value).ToString();
            frmAddEmployee addEmployee = new frmAddEmployee(modelEmployee);
            if (addEmployee.ShowDialog() == DialogResult.OK)
            {
                FillGrid();
            }
        }
    }
}
