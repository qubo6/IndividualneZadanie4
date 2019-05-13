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
        private InsertDirectorViewModel _insertDirectorViewModel = new InsertDirectorViewModel();
        private ModelEmployee _employeeDirector = new ModelEmployee();
        public int DirectorId { get; set; }
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private ModelEmployee SetDirector()
        {
            _employeeDirector.Title = txtTitle.Text;
            _employeeDirector.FirstName = txtFirstName.Text ;
            _employeeDirector.LastName = txtLastName.Text ;
            _employeeDirector.Phone = txtPhone.Text ;
            _employeeDirector.Email = txtEmail.Text;
            return _employeeDirector;
        }

        private void btnSaveDirector_Click(object sender, EventArgs e)
        {
            DirectorId = _insertDirectorViewModel.InsertDirector(SetDirector());
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
 