namespace individualne4
{
    partial class frmOrganizationStructure
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.cmbHierarchyLevel = new System.Windows.Forms.ComboBox();
            this.dgwCompany = new System.Windows.Forms.DataGridView();
            this.dgwDivision = new System.Windows.Forms.DataGridView();
            this.dgwProject = new System.Windows.Forms.DataGridView();
            this.dgwDepartment = new System.Windows.Forms.DataGridView();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnAddDivision = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnCompanyDirector = new System.Windows.Forms.Button();
            this.btnDivisionDirector = new System.Windows.Forms.Button();
            this.btnProjectDirector = new System.Windows.Forms.Button();
            this.btnDepartmentDirector = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(233, 475);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Company Name";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(233, 501);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(121, 20);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "Company Code";
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(233, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Company";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(381, 501);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(121, 20);
            this.txtLevel.TabIndex = 3;
            this.txtLevel.Text = "Hierarchy Level";
            this.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbHierarchyLevel
            // 
            this.cmbHierarchyLevel.FormattingEnabled = true;
            this.cmbHierarchyLevel.Location = new System.Drawing.Point(381, 474);
            this.cmbHierarchyLevel.Name = "cmbHierarchyLevel";
            this.cmbHierarchyLevel.Size = new System.Drawing.Size(121, 21);
            this.cmbHierarchyLevel.TabIndex = 4;
            // 
            // dgwCompany
            // 
            this.dgwCompany.AllowUserToAddRows = false;
            this.dgwCompany.AllowUserToDeleteRows = false;
            this.dgwCompany.AllowUserToResizeColumns = false;
            this.dgwCompany.AllowUserToResizeRows = false;
            this.dgwCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompany.Location = new System.Drawing.Point(12, 49);
            this.dgwCompany.Name = "dgwCompany";
            this.dgwCompany.ReadOnly = true;
            this.dgwCompany.RowHeadersVisible = false;
            this.dgwCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCompany.Size = new System.Drawing.Size(281, 258);
            this.dgwCompany.TabIndex = 5;
            this.dgwCompany.SelectionChanged += new System.EventHandler(this.dgwCompany_SelectionChanged);
            // 
            // dgwDivision
            // 
            this.dgwDivision.AllowUserToAddRows = false;
            this.dgwDivision.AllowUserToDeleteRows = false;
            this.dgwDivision.AllowUserToResizeColumns = false;
            this.dgwDivision.AllowUserToResizeRows = false;
            this.dgwDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDivision.Location = new System.Drawing.Point(299, 49);
            this.dgwDivision.Name = "dgwDivision";
            this.dgwDivision.ReadOnly = true;
            this.dgwDivision.RowHeadersVisible = false;
            this.dgwDivision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDivision.Size = new System.Drawing.Size(289, 258);
            this.dgwDivision.TabIndex = 6;
            this.dgwDivision.SelectionChanged += new System.EventHandler(this.dgwDivision_SelectionChanged);
            // 
            // dgwProject
            // 
            this.dgwProject.AllowUserToAddRows = false;
            this.dgwProject.AllowUserToDeleteRows = false;
            this.dgwProject.AllowUserToResizeColumns = false;
            this.dgwProject.AllowUserToResizeRows = false;
            this.dgwProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProject.Location = new System.Drawing.Point(594, 49);
            this.dgwProject.Name = "dgwProject";
            this.dgwProject.ReadOnly = true;
            this.dgwProject.RowHeadersVisible = false;
            this.dgwProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProject.Size = new System.Drawing.Size(281, 258);
            this.dgwProject.TabIndex = 7;
            this.dgwProject.SelectionChanged += new System.EventHandler(this.dgwProject_SelectionChanged);
            // 
            // dgwDepartment
            // 
            this.dgwDepartment.AllowUserToAddRows = false;
            this.dgwDepartment.AllowUserToDeleteRows = false;
            this.dgwDepartment.AllowUserToResizeColumns = false;
            this.dgwDepartment.AllowUserToResizeRows = false;
            this.dgwDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepartment.Location = new System.Drawing.Point(881, 49);
            this.dgwDepartment.Name = "dgwDepartment";
            this.dgwDepartment.ReadOnly = true;
            this.dgwDepartment.RowHeadersVisible = false;
            this.dgwDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDepartment.Size = new System.Drawing.Size(266, 258);
            this.dgwDepartment.TabIndex = 8;
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(122, 327);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(140, 23);
            this.btnAddCompany.TabIndex = 9;
            this.btnAddCompany.Text = "Add Company";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // btnAddDivision
            // 
            this.btnAddDivision.Location = new System.Drawing.Point(387, 327);
            this.btnAddDivision.Name = "btnAddDivision";
            this.btnAddDivision.Size = new System.Drawing.Size(140, 23);
            this.btnAddDivision.TabIndex = 10;
            this.btnAddDivision.Text = "Add Division";
            this.btnAddDivision.UseVisualStyleBackColor = true;
            this.btnAddDivision.Click += new System.EventHandler(this.btnAddDivision_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(651, 327);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(140, 23);
            this.btnAddProject.TabIndex = 11;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(914, 327);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(140, 23);
            this.btnAddDepartment.TabIndex = 12;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnCompanyDirector
            // 
            this.btnCompanyDirector.Location = new System.Drawing.Point(122, 356);
            this.btnCompanyDirector.Name = "btnCompanyDirector";
            this.btnCompanyDirector.Size = new System.Drawing.Size(140, 23);
            this.btnCompanyDirector.TabIndex = 13;
            this.btnCompanyDirector.Text = "Add Company Director";
            this.btnCompanyDirector.UseVisualStyleBackColor = true;
            // 
            // btnDivisionDirector
            // 
            this.btnDivisionDirector.Location = new System.Drawing.Point(387, 356);
            this.btnDivisionDirector.Name = "btnDivisionDirector";
            this.btnDivisionDirector.Size = new System.Drawing.Size(140, 23);
            this.btnDivisionDirector.TabIndex = 14;
            this.btnDivisionDirector.Text = "Add Division Director";
            this.btnDivisionDirector.UseVisualStyleBackColor = true;
            // 
            // btnProjectDirector
            // 
            this.btnProjectDirector.Location = new System.Drawing.Point(651, 356);
            this.btnProjectDirector.Name = "btnProjectDirector";
            this.btnProjectDirector.Size = new System.Drawing.Size(140, 23);
            this.btnProjectDirector.TabIndex = 15;
            this.btnProjectDirector.Text = "Add Project Director";
            this.btnProjectDirector.UseVisualStyleBackColor = true;
            // 
            // btnDepartmentDirector
            // 
            this.btnDepartmentDirector.Location = new System.Drawing.Point(914, 356);
            this.btnDepartmentDirector.Name = "btnDepartmentDirector";
            this.btnDepartmentDirector.Size = new System.Drawing.Size(140, 23);
            this.btnDepartmentDirector.TabIndex = 16;
            this.btnDepartmentDirector.Text = "Add Department Director";
            this.btnDepartmentDirector.UseVisualStyleBackColor = true;
            // 
            // frmOrganizationStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 578);
            this.Controls.Add(this.btnDepartmentDirector);
            this.Controls.Add(this.btnProjectDirector);
            this.Controls.Add(this.btnDivisionDirector);
            this.Controls.Add(this.btnCompanyDirector);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnAddDivision);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.dgwDepartment);
            this.Controls.Add(this.dgwProject);
            this.Controls.Add(this.dgwDivision);
            this.Controls.Add(this.dgwCompany);
            this.Controls.Add(this.cmbHierarchyLevel);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Name = "frmOrganizationStructure";
            this.Text = "OraganizationStructure";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.ComboBox cmbHierarchyLevel;
        private System.Windows.Forms.DataGridView dgwCompany;
        private System.Windows.Forms.DataGridView dgwDivision;
        private System.Windows.Forms.DataGridView dgwProject;
        private System.Windows.Forms.DataGridView dgwDepartment;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnAddDivision;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnCompanyDirector;
        private System.Windows.Forms.Button btnDivisionDirector;
        private System.Windows.Forms.Button btnProjectDirector;
        private System.Windows.Forms.Button btnDepartmentDirector;
    }
}

