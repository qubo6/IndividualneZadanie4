using Data.Enum;
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
    public partial class frmOrganizationStructure : Form
    {
        private SectionManagerViewModel _sectionManagerViewModel = new SectionManagerViewModel();
        private int _sectionDirectorId;

        public frmOrganizationStructure()
        {
            InitializeComponent();
            RefreshGrids();
        }

        #region Add new section
        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            frmAddSection addSection = new frmAddSection(null, HierarchyLevel.Company);
            addSection.ShowDialog();
            GridContent(dgwCompany, _sectionManagerViewModel.GetCompanies());
            RefreshGrids();
        }

        private void AddSubordinatedSection(DataGridView parentGrid, HierarchyLevel level)
        {
            frmAddSection addSection = new frmAddSection(Convert.ToInt32(parentGrid.SelectedRows[0].Cells[0].Value), level);
            addSection.ShowDialog();
            RefreshGrids();
        }
        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            AddSubordinatedSection(dgwCompany, HierarchyLevel.Division);
            RefreshGrids();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            AddSubordinatedSection(dgwDivision, HierarchyLevel.Project);
            RefreshGrids();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            AddSubordinatedSection(dgwProject, HierarchyLevel.Department);
            RefreshGrids();
        }
        #endregion

        #region Add Employee To Department
        private void btnAddEmployy_Click(object sender, EventArgs e)
        {
            frmEmployee employee = new frmEmployee();
            if (employee.ShowDialog() == DialogResult.OK)
            {
                _sectionDirectorId = employee.DirectorId;
            }
            ModelEmployee employeeModel = new ModelEmployee();
            employeeModel.Id = _sectionDirectorId;
            employeeModel.WorkAtDepartmentId = Convert.ToInt32(dgwDepartment.SelectedRows[0].Cells[0].Value);
            _sectionManagerViewModel.UpdateEmployee(employeeModel);
            RefreshGrids();
        }
        #endregion

        #region Add directors for sections
        private void SetDirectorForSection(DataGridView dgw)
        {
            frmEmployee employee = new frmEmployee();
            if (employee.ShowDialog() == DialogResult.OK)
            {
                _sectionDirectorId = employee.DirectorId;
            }
            ModelSection section = new ModelSection();
            section.DirectorId = _sectionDirectorId;
            section.Id = Convert.ToInt32(dgw.SelectedRows[0].Cells[0].Value);
            _sectionManagerViewModel.SetSectionDirector(section);
        }
        private void btnCompanyDirector_Click(object sender, EventArgs e)
        {
            SetDirectorForSection(dgwCompany);
            RefreshGrids();
        }

        private void btnDivisionDirector_Click(object sender, EventArgs e)
        {
            SetDirectorForSection(dgwDivision);
            RefreshGrids();
        }


        private void btnProjectDirector_Click(object sender, EventArgs e)
        {
            SetDirectorForSection(dgwProject);
            RefreshGrids();
        }

        private void btnDepartmentDirector_Click(object sender, EventArgs e)
        {
            SetDirectorForSection(dgwDepartment);
            RefreshGrids();
        }
        #endregion

        #region Fill Grid
        private void GridContent(DataGridView dgw, List<ModelSection> model)
        {
            dgw.DataSource = model;
            dgw.Columns[0].Visible = false;
            dgw.Columns[3].Visible = false;
            dgw.Columns[4].Visible = false;
            dgw.Columns[5].Visible = false;
        }
        private void GridContentEmployee(DataGridView dgw, List<ModelEmployee> model)
        {
            dgw.DataSource = model;
            dgw.Columns[0].Visible = false;
            dgw.Columns[4].Visible = false;
            dgw.Columns[5].Visible = false;
            dgw.Columns[6].Visible = false;
        }
        private void ClearGrid(DataGridView dgw)
        {
            dgw.DataSource = null;
            dgw.Rows.Clear();
        }

        private void FillGrid(DataGridView parentGrid, DataGridView childGrid, Label directorName)
        {
            if (parentGrid.SelectedRows.Count != 0)
            {
                GridContent(childGrid,
                    _sectionManagerViewModel.GetSections(Convert.ToInt32(parentGrid.SelectedRows[0].Cells[0].Value)));
                directorName.Text = $"Director: {_sectionManagerViewModel.SelectDirectorBySection(Convert.ToInt32(parentGrid.SelectedRows[0].Cells[0].Value))}";
            }
            else
            {
                ClearGrid(childGrid);
            }
            EnableButtons();
        }

        private void dgwCompany_SelectionChanged(object sender, EventArgs e)
        {
            FillGrid(dgwCompany, dgwDivision, lblCompany);
            DisableAddButton(dgwCompany, btnAddDivision);
        }

        private void dgwDivision_SelectionChanged(object sender, EventArgs e)
        {
            FillGrid(dgwDivision, dgwProject, lblDivision);
            DisableAddButton(dgwDivision, btnAddProject);
        }

        private void dgwProject_SelectionChanged(object sender, EventArgs e)
        {
            FillGrid(dgwProject, dgwDepartment, lblProject);
            DisableAddButton(dgwProject, btnAddDepartment);
        }

        private void dgwDepartment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwDepartment.SelectedRows.Count != 0)
            {
                GridContentEmployee(dgwEmployees,
                    _sectionManagerViewModel.GetEmployeesByDepartmet
                    (Convert.ToInt32(dgwDepartment.SelectedRows[0].Cells[0].Value)));
                lblDept.Text = $"Director: {_sectionManagerViewModel.SelectDirectorBySection(Convert.ToInt32(dgwDepartment.SelectedRows[0].Cells[0].Value))}";
            }
            else
            {
                ClearGrid(dgwEmployees);
            }
        }

        #endregion

        #region Enable/Disable Buttons
        private void DisableAddButton(DataGridView dgwParent, Button btnChild)
        {
            if (dgwParent.Rows.Count != 0)
            {
                btnChild.Enabled = true;
            }
        }

        private void EnableButtons()
        {
            int companySum = dgwCompany.Rows.Count;
            int divisionSum = dgwDivision.Rows.Count;
            int projectSum = dgwProject.Rows.Count;
            int deptSum = dgwDepartment.Rows.Count;
            int employeeSum = dgwEmployees.Rows.Count;

            List<Button> companiesBtn = new List<Button>() { btnAddCompany, btnCompanyDirector,btnEditCompany };
            List<Button> divisionsBtn = new List<Button>() { btnDivisionDirector, btnAddDivision,btnEditDivision };
            List<Button> projectsBtn = new List<Button>() { btnProjectDirector, btnAddProject,btnEditProject };
            List<Button> departmentsBtn = new List<Button>() { btnDepartmentDirector, btnAddDepartment,btnEditDept };

            foreach (Button item in companiesBtn)
            {
                item.Enabled = companySum != 0;
            }
            foreach (Button item in divisionsBtn)
            {
                item.Enabled = divisionSum != 0;
            }
            foreach (Button item in projectsBtn)
            {
                item.Enabled = projectSum != 0;
            }
            foreach (Button item in departmentsBtn)
            {
                item.Enabled = deptSum != 0;
            }
            btnAddEmployy.Enabled = deptSum != 0;
        }
        #endregion

        #region Edit Sections
        private void EditCompany(DataGridView gridToEdit)
        {
            ModelSection sectionForEdit = new ModelSection();
            sectionForEdit.Id = Convert.ToInt32(gridToEdit.SelectedRows[0].Cells[0].Value);
            sectionForEdit.Name = (gridToEdit.SelectedRows[0].Cells[1].Value).ToString();
            sectionForEdit.Code = (gridToEdit.SelectedRows[0].Cells[2].Value).ToString();
            frmAddSection addSection = new frmAddSection(sectionForEdit);
            addSection.ShowDialog();
            RefreshGrids();
        }
        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            EditCompany(dgwCompany);
        }
        private void btnEditDivision_Click(object sender, EventArgs e)
        {
            EditCompany(dgwDivision);
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            EditCompany(dgwProject);
        }

        private void btnEditDept_Click(object sender, EventArgs e)
        {
            EditCompany(dgwDepartment);
        }
        #endregion
        private void RefreshGrids()
        {
            _sectionManagerViewModel.GetCompanies();
            GridContent(dgwCompany, _sectionManagerViewModel.GetCompanies());
            FillGrid(dgwCompany, dgwDivision, lblCompany);
            FillGrid(dgwDivision, dgwProject, lblDivision);
            FillGrid(dgwProject, dgwDepartment, lblProject);
            DisableAddButton(dgwCompany, btnAddDivision);
            DisableAddButton(dgwDivision, btnAddProject);
            DisableAddButton(dgwProject, btnAddDepartment);
            DisableAddButton(dgwDepartment, btnAddEmployy);
        }
    }
}