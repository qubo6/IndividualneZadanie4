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
    }
}
