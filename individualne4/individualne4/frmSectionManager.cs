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

        public frmOrganizationStructure()
        {
            InitializeComponent();
            cmbHierarchyLevel.DataSource = Enum.GetValues(typeof(HierarchyLevel));
            FillGrid(dgwCompany, _sectionManagerViewModel.GetCompanies());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //frmInsertDirector insertDirector = new frmInsertDirector();
            //if (insertDirector.ShowDialog() == DialogResult.OK)
            //{
            //    int directorId = insertDirector.DirectorId;
            //}
            frmEmployee employee = new frmEmployee();
            employee.ShowDialog();
        }

        private void FillGrid(DataGridView dgw, List<ModelSection> modelSections)
        {
            dgw.DataSource = modelSections;
            dgw.Columns[3].Visible = false;
            dgw.Columns[4].Visible = false;
            dgw.Columns[5].Visible = false;

        }
        private void ClearGrid(DataGridView dgw)
        {
            dgw.DataSource = null;
            dgw.Rows.Clear();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            frmAddSection addSection = new frmAddSection(null, HierarchyLevel.Company);
            addSection.ShowDialog();
            FillGrid(dgwCompany,_sectionManagerViewModel.GetCompanies());
        }


        private void btnAddDivision_Click(object sender, EventArgs e)
        {
            frmAddSection addSection = new frmAddSection(Convert.ToInt32(dgwCompany.SelectedRows[0].Cells[0].Value), HierarchyLevel.Division);
            addSection.ShowDialog();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            frmAddSection addSection = new frmAddSection(Convert.ToInt32(dgwDivision.SelectedRows[0].Cells[0].Value), HierarchyLevel.Project);
            addSection.ShowDialog();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            frmAddSection addSection = new frmAddSection(Convert.ToInt32(dgwProject.SelectedRows[0].Cells[0].Value), HierarchyLevel.Department);
            addSection.ShowDialog();
        }

        private void dgwCompany_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwCompany.SelectedRows.Count !=0)
            {
                FillGrid(dgwDivision, _sectionManagerViewModel.GetSections(Convert.ToInt32(dgwCompany.SelectedRows[0].Cells[0].Value)));
            }
            else
            {
                ClearGrid(dgwDivision);
            }
        }

        private void dgwDivision_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwDivision.SelectedRows.Count != 0)
            {
                FillGrid(dgwProject, _sectionManagerViewModel.GetSections(Convert.ToInt32(dgwDivision.SelectedRows[0].Cells[0].Value)));
            }
            else
            {
                ClearGrid(dgwProject);
            }
        }

        private void dgwProject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwProject.SelectedRows.Count != 0)
            {
                FillGrid(dgwDepartment, _sectionManagerViewModel.GetSections(Convert.ToInt32(dgwProject.SelectedRows[0].Cells[0].Value)));
            }
            else
            {
                ClearGrid(dgwDepartment);
            }
        }
    }
}
