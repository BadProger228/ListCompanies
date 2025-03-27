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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            typeListSort = new ComboBox();
            searchList1 = new TextBox();
            searchList2 = new TextBox();
            SortText = new Label();
            label1 = new Label();
            label2 = new Label();
            SortForAge = new Label();
            AgeSortBox = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveInTextFileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            openFileAndAddInYourListToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addEmployeeToolStripMenuItem = new ToolStripMenuItem();
            addCompanyToolStripMenuItem = new ToolStripMenuItem();
            deleteSelectElementToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(35, 149);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(415, 344);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(498, 149);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(414, 344);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            listBox2.DoubleClick += listBox2_DoubleClick;
            // 
            // typeListSort
            // 
            typeListSort.AccessibleDescription = "";
            typeListSort.FormattingEnabled = true;
            typeListSort.Location = new Point(126, 32);
            typeListSort.Name = "typeListSort";
            typeListSort.Size = new Size(324, 28);
            typeListSort.TabIndex = 14;
            typeListSort.Text = "Employe";
            typeListSort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // searchList1
            // 
            searchList1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            searchList1.Location = new Point(35, 111);
            searchList1.Name = "searchList1";
            searchList1.Size = new Size(415, 27);
            searchList1.TabIndex = 16;
            searchList1.TextChanged += searchList1_TextChanged;
            // 
            // searchList2
            // 
            searchList2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            searchList2.Location = new Point(498, 111);
            searchList2.Name = "searchList2";
            searchList2.Size = new Size(414, 27);
            searchList2.TabIndex = 17;
            searchList2.TextChanged += searchList2_TextChanged;
            // 
            // SortText
            // 
            SortText.AutoSize = true;
            SortText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            SortText.Location = new Point(36, 35);
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
            label2.Location = new Point(498, 87);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 20;
            label2.Text = "Seach in the second column";
            // 
            // SortForAge
            // 
            SortForAge.AutoSize = true;
            SortForAge.Location = new Point(498, 39);
            SortForAge.Name = "SortForAge";
            SortForAge.Size = new Size(39, 20);
            SortForAge.TabIndex = 21;
            SortForAge.Text = "Age:";
            // 
            // AgeSortBox
            // 
            AgeSortBox.FormattingEnabled = true;
            AgeSortBox.Items.AddRange(new object[] { "All", "18-25", "26-35", "36-50", "50+" });
            AgeSortBox.Location = new Point(543, 28);
            AgeSortBox.Name = "AgeSortBox";
            AgeSortBox.Size = new Size(369, 28);
            AgeSortBox.TabIndex = 22;
            AgeSortBox.SelectedIndexChanged += AgeSortBox_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(942, 28);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, saveInTextFileToolStripMenuItem, openFileToolStripMenuItem, openFileAndAddInYourListToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(284, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveInTextFileToolStripMenuItem
            // 
            saveInTextFileToolStripMenuItem.Name = "saveInTextFileToolStripMenuItem";
            saveInTextFileToolStripMenuItem.Size = new Size(284, 26);
            saveInTextFileToolStripMenuItem.Text = "Save in text file";
            saveInTextFileToolStripMenuItem.Click += saveInTextFileToolStripMenuItem_Click;
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(284, 26);
            openFileToolStripMenuItem.Text = "Open file";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // openFileAndAddInYourListToolStripMenuItem
            // 
            openFileAndAddInYourListToolStripMenuItem.Name = "openFileAndAddInYourListToolStripMenuItem";
            openFileAndAddInYourListToolStripMenuItem.Size = new Size(284, 26);
            openFileAndAddInYourListToolStripMenuItem.Text = "Open file and add in your list";
            openFileAndAddInYourListToolStripMenuItem.Click += openFileAndAddInYourListToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addEmployeeToolStripMenuItem, addCompanyToolStripMenuItem, deleteSelectElementToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(223, 76);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // addEmployeeToolStripMenuItem
            // 
            addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            addEmployeeToolStripMenuItem.Size = new Size(222, 24);
            addEmployeeToolStripMenuItem.Text = "Add employee";
            addEmployeeToolStripMenuItem.Click += addEmployeeToolStripMenuItem_Click;
            // 
            // addCompanyToolStripMenuItem
            // 
            addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            addCompanyToolStripMenuItem.Size = new Size(222, 24);
            addCompanyToolStripMenuItem.Text = "Add company";
            addCompanyToolStripMenuItem.Click += addCompanyToolStripMenuItem_Click;
            // 
            // deleteSelectElementToolStripMenuItem
            // 
            deleteSelectElementToolStripMenuItem.Name = "deleteSelectElementToolStripMenuItem";
            deleteSelectElementToolStripMenuItem.Size = new Size(222, 24);
            deleteSelectElementToolStripMenuItem.Text = "Delete select element";
            deleteSelectElementToolStripMenuItem.Click += deleteSelectElementToolStripMenuItem_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 533);
            Controls.Add(AgeSortBox);
            Controls.Add(SortForAge);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SortText);
            Controls.Add(searchList2);
            Controls.Add(searchList1);
            Controls.Add(typeListSort);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(960, 580);
            Name = "mainForm";
            Tag = "1";
            Text = "Control Emploee";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox listBox1;
        public ListBox listBox2;
        public ComboBox typeListSort;
        private TextBox searchList1;
        private TextBox searchList2;
        private Label SortText;
        private Label label1;
        private Label label2;
        private Label SortForAge;
        private ComboBox AgeSortBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveInTextFileToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addEmployeeToolStripMenuItem;
        private ToolStripMenuItem addCompanyToolStripMenuItem;
        private ToolStripMenuItem deleteSelectElementToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem openFileAndAddInYourListToolStripMenuItem;
    }
}