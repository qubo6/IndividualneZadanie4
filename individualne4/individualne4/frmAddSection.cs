﻿using Data.Enum;
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
        public frmAddSection(int? parentId, HierarchyLevel level)
        {
            InitializeComponent();
            _parentId = parentId;
            _level = level;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ModelSection section = new ModelSection();
            section.HierarchyLevel = _level;
            section.ParentSectionId = _parentId;
            section.Name = txtName.Text;
            section.Code = txtCode.Text;
            _addSectionViewModel.AddSection(section);
            Close();
        }
    }
}
