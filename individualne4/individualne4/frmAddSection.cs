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
    public partial class frmAddSection : Form
    {
        private int? _parentId;
        private HierarchyLevel _level;
        private AddSectionViewModel _addSectionViewModel = new AddSectionViewModel();
        private ModelSection _modelSection = null;
        public frmAddSection(int? parentId, HierarchyLevel level)
        {
            InitializeComponent();
            _parentId = parentId;
            _level = level;
        }

        public frmAddSection(ModelSection modelSection)
        {
            InitializeComponent();
            _modelSection = modelSection;
            txtName.Text = _modelSection.Name;
            txtCode.Text = _modelSection.Code;
        }
        private bool MustBeFilled()
        {
            if (txtName.Text.Length!=0 && txtCode.Text.Length != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Name and Code must contains some text");
                return false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MustBeFilled())
            {
                if (_modelSection == null)
                {
                    ModelSection section = new ModelSection();
                    section.HierarchyLevel = _level;
                    section.ParentSectionId = _parentId;
                    section.Name = txtName.Text;
                    section.Code = txtCode.Text;
                    _addSectionViewModel.AddSection(section);
                }
                else
                {
                    _modelSection.Name = txtName.Text;
                    _modelSection.Code = txtCode.Text;
                    _addSectionViewModel.UpdateSection(_modelSection);
                }
                Close();
            }
            
        }
    }
}
