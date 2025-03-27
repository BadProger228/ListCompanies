namespace Control_Employees
{
    partial class StartForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            newFileToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteProjectFromListToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(798, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, newFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(153, 26);
            openFileToolStripMenuItem.Text = "Open file";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // newFileToolStripMenuItem
            // 
            newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            newFileToolStripMenuItem.Size = new Size(153, 26);
            newFileToolStripMenuItem.Text = "New file";
            newFileToolStripMenuItem.Click += newFileToolStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 74);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(774, 404);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 2;
            label1.Text = "Recent project";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteProjectFromListToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(232, 56);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // deleteProjectFromListToolStripMenuItem
            // 
            deleteProjectFromListToolStripMenuItem.Name = "deleteProjectFromListToolStripMenuItem";
            deleteProjectFromListToolStripMenuItem.Size = new Size(231, 24);
            deleteProjectFromListToolStripMenuItem.Text = "Delete Project from list";
            deleteProjectFromListToolStripMenuItem.Click += deleteProjectFromListToolStripMenuItem_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 513);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "StartForm";
            Text = "StartForm";
            Load += StartForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ListBox listBox1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteProjectFromListToolStripMenuItem;
    }
}