namespace WinFormsApp2
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            Add_Employee = new Button();
            listBox2 = new ListBox();
            Delete_element = new Button();
            AddCompany = new Button();
            typeListSort = new ComboBox();
            label3 = new Label();
            searchList1 = new TextBox();
            searchList2 = new TextBox();
            SortText = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(35, 149);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(374, 344);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // Add_Employee
            // 
            Add_Employee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Add_Employee.Location = new Point(842, 50);
            Add_Employee.Name = "Add_Employee";
            Add_Employee.Size = new Size(239, 57);
            Add_Employee.TabIndex = 1;
            Add_Employee.Text = "+Add Employee";
            Add_Employee.UseVisualStyleBackColor = true;
            Add_Employee.Click += AddEmployee_Click;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(437, 149);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(374, 344);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            listBox2.DoubleClick += listBox2_DoubleClick;
            // 
            // Delete_element
            // 
            Delete_element.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Delete_element.Location = new Point(842, 436);
            Delete_element.Name = "Delete_element";
            Delete_element.Size = new Size(239, 57);
            Delete_element.TabIndex = 5;
            Delete_element.Text = "-delete";
            Delete_element.UseVisualStyleBackColor = true;
            Delete_element.Click += Delete_element_Click;
            // 
            // AddCompany
            // 
            AddCompany.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddCompany.Location = new Point(842, 232);
            AddCompany.Name = "AddCompany";
            AddCompany.Size = new Size(239, 57);
            AddCompany.TabIndex = 1;
            AddCompany.Text = "+Add Company";
            AddCompany.UseVisualStyleBackColor = true;
            AddCompany.Click += button1_Click;
            // 
            // typeListSort
            // 
            typeListSort.AccessibleDescription = "";
            typeListSort.FormattingEnabled = true;
            typeListSort.Location = new Point(126, 32);
            typeListSort.Name = "typeListSort";
            typeListSort.Size = new Size(283, 28);
            typeListSort.TabIndex = 14;
            typeListSort.Text = "Employe";
            typeListSort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Location = new Point(437, 9);
            label3.Name = "label3";
            label3.Size = new Size(218, 40);
            label3.TabIndex = 11;
            label3.Click += label3_Click;
            // 
            // searchList1
            // 
            searchList1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            searchList1.Location = new Point(35, 111);
            searchList1.Name = "searchList1";
            searchList1.Size = new Size(374, 27);
            searchList1.TabIndex = 16;
            searchList1.TextChanged += searchList1_TextChanged;
            // 
            // searchList2
            // 
            searchList2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            searchList2.Location = new Point(437, 111);
            searchList2.Name = "searchList2";
            searchList2.Size = new Size(374, 27);
            searchList2.TabIndex = 17;
            searchList2.TextChanged += searchList2_TextChanged;
            // 
            // SortText
            // 
            SortText.AutoSize = true;
            SortText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            SortText.Location = new Point(36, 31);
            SortText.Name = "SortText";
            SortText.Size = new Size(84, 25);
            SortText.TabIndex = 18;
            SortText.Text = "Sort for:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(36, 87);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 19;
            label1.Text = "Search in the first column";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(437, 88);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 20;
            label2.Text = "Seach in the second column";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 533);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SortText);
            Controls.Add(searchList2);
            Controls.Add(searchList1);
            Controls.Add(typeListSort);
            Controls.Add(label3);
            Controls.Add(Delete_element);
            Controls.Add(listBox2);
            Controls.Add(AddCompany);
            Controls.Add(Add_Employee);
            Controls.Add(listBox1);
            MinimumSize = new Size(960, 580);
            Name = "mainForm";
            Tag = "1";
            Text = "Control Emploee";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox listBox1;
        private Button Add_Employee;
        public ListBox listBox2;
        private Button Delete_element;
        private Button AddCompany;
        public ComboBox typeListSort;
        private Label label3;
        private TextBox searchList1;
        private TextBox searchList2;
        private Label SortText;
        private Label label1;
        private Label label2;
    }
}