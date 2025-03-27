namespace Control_Employees
{
    partial class OpenFileForm
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
            AddEmployeeList = new Button();
            AddCompanyList = new Button();
            OpenFile = new Button();
            pathEmployeeList = new TextBox();
            pathCompanyList = new TextBox();
            SuspendLayout();
            // 
            // AddEmployeeList
            // 
            AddEmployeeList.Location = new Point(462, 12);
            AddEmployeeList.Name = "AddEmployeeList";
            AddEmployeeList.Size = new Size(141, 34);
            AddEmployeeList.TabIndex = 0;
            AddEmployeeList.Text = "Add Employeelist";
            AddEmployeeList.UseVisualStyleBackColor = true;
            AddEmployeeList.Click += AddEmployeeList_Click;
            // 
            // AddCompanyList
            // 
            AddCompanyList.Location = new Point(462, 58);
            AddCompanyList.Name = "AddCompanyList";
            AddCompanyList.Size = new Size(141, 34);
            AddCompanyList.TabIndex = 1;
            AddCompanyList.Text = "Add Companylist";
            AddCompanyList.UseVisualStyleBackColor = true;
            AddCompanyList.Click += AddCompanyList_Click;
            // 
            // OpenFile
            // 
            OpenFile.Location = new Point(231, 130);
            OpenFile.Name = "OpenFile";
            OpenFile.Size = new Size(143, 45);
            OpenFile.TabIndex = 4;
            OpenFile.Text = "Open file";
            OpenFile.UseVisualStyleBackColor = true;
            OpenFile.Click += OpenFile_Click;
            // 
            // pathEmployeeList
            // 
            pathEmployeeList.Location = new Point(15, 18);
            pathEmployeeList.Name = "pathEmployeeList";
            pathEmployeeList.Size = new Size(441, 27);
            pathEmployeeList.TabIndex = 5;
            pathEmployeeList.TextChanged += pathEmployeeList_TextChanged;
            // 
            // pathCompanyList
            // 
            pathCompanyList.Location = new Point(15, 62);
            pathCompanyList.Name = "pathCompanyList";
            pathCompanyList.Size = new Size(441, 27);
            pathCompanyList.TabIndex = 6;
            // 
            // OpenFileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 202);
            Controls.Add(pathCompanyList);
            Controls.Add(pathEmployeeList);
            Controls.Add(OpenFile);
            Controls.Add(AddCompanyList);
            Controls.Add(AddEmployeeList);
            Name = "OpenFileForm";
            Text = "OpenFileForm";
            Load += OpenFileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddEmployeeList;
        private Button AddCompanyList;
        private Button OpenFile;
        private TextBox pathEmployeeList;
        private TextBox pathCompanyList;
    }
}