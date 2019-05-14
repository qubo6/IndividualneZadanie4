using Data.Model;
using Data.Repositories;
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
    public partial class frmAddEmployee : Form
    {
        private AddEmployeeViewModel _addEmployeeViewModel = new AddEmployeeViewModel();
        private ModelEmployee _modelEmployee = null;
        public frmAddEmployee()
        {
            InitializeComponent();
        }
        public frmAddEmployee(ModelEmployee modelEmployee)
        {
            InitializeComponent();
            _modelEmployee = modelEmployee;
            txtTitle.Text = _modelEmployee.Title;
            txtFirstName.Text = _modelEmployee.FirstName;
            txtLastName.Text = _modelEmployee.LastName;
            txtPhone.Text = _modelEmployee.Phone;
            txtEmail.Text = _modelEmployee.Email;
        }


        //private ModelEmployee SetEmployee()
        //{
        //    _modelEmployee = new ModelEmployee();
        //    _modelEmployee.Title = txtTitle.Text;
        //    _modelEmployee.FirstName = txtFirstName.Text ;
        //    _modelEmployee.LastName = txtLastName.Text ;
        //    _modelEmployee.Phone = txtPhone.Text ;
        //    _modelEmployee.Email = txtEmail.Text;
        //    return _modelEmployee;
        //}

        private void btnSaveDirector_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (_modelEmployee==null)
            {
                ModelEmployee model = new ModelEmployee();
                model.Title = txtTitle.Text;
                model.FirstName = txtFirstName.Text;
                model.LastName = txtLastName.Text;
                model.Phone = txtPhone.Text;
                model.Email = txtEmail.Text;
                _addEmployeeViewModel.InsertEmployee(model);
            }
            else
            {
                _modelEmployee.Title = txtTitle.Text;
                _modelEmployee.FirstName = txtFirstName.Text;
                _modelEmployee.LastName = txtLastName.Text;
                _modelEmployee.Phone = txtPhone.Text;
                _modelEmployee.Email = txtEmail.Text;
                _addEmployeeViewModel.UpdateEmployeeBy(_modelEmployee);
            }           
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
 