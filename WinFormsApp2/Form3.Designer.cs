namespace WinFormsApp2
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            CompanyRedact = new Button();
            Cancel = new Button();
            NameText = new Label();
            InformationText = new Label();
            ImageText = new Label();
            ExceptionText = new Label();
            ExceptionName = new Label();
            ExceptionEdit = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 42);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 28);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 166);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 196);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(418, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // CompanyRedact
            // 
            CompanyRedact.Location = new Point(66, 386);
            CompanyRedact.Name = "CompanyRedact";
            CompanyRedact.Size = new Size(259, 52);
            CompanyRedact.TabIndex = 3;
            CompanyRedact.Text = "Redact";
            CompanyRedact.UseVisualStyleBackColor = true;
            CompanyRedact.Click += CompanyRedact_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(626, 383);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(143, 51);
            Cancel.TabIndex = 4;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(22, 45);
            NameText.Name = "NameText";
            NameText.Size = new Size(52, 20);
            NameText.TabIndex = 5;
            NameText.Text = "Name:";
            NameText.Click += NameText_Click;
            // 
            // InformationText
            // 
            InformationText.AutoSize = true;
            InformationText.Location = new Point(23, 139);
            InformationText.Name = "InformationText";
            InformationText.Size = new Size(198, 20);
            InformationText.TabIndex = 6;
            InformationText.Text = "Information about company:";
            // 
            // ImageText
            // 
            ImageText.AutoSize = true;
            ImageText.Location = new Point(418, 38);
            ImageText.Name = "ImageText";
            ImageText.Size = new Size(260, 20);
            ImageText.TabIndex = 7;
            ImageText.Text = "Image, double clicke for open picture:";
            // 
            // ExceptionText
            // 
            ExceptionText.AutoSize = true;
            ExceptionText.ForeColor = Color.Red;
            ExceptionText.Location = new Point(237, 139);
            ExceptionText.Name = "ExceptionText";
            ExceptionText.Size = new Size(0, 20);
            ExceptionText.TabIndex = 8;
            ExceptionText.Visible = false;
            // 
            // ExceptionName
            // 
            ExceptionName.AutoSize = true;
            ExceptionName.ForeColor = Color.Red;
            ExceptionName.Location = new Point(81, 13);
            ExceptionName.Name = "ExceptionName";
            ExceptionName.Size = new Size(0, 20);
            ExceptionName.TabIndex = 9;
            ExceptionName.Visible = false;
            // 
            // ExceptionEdit
            // 
            ExceptionEdit.AutoSize = true;
            ExceptionEdit.ForeColor = Color.Red;
            ExceptionEdit.Location = new Point(26, 365);
            ExceptionEdit.Name = "ExceptionEdit";
            ExceptionEdit.Size = new Size(0, 20);
            ExceptionEdit.TabIndex = 10;
            ExceptionEdit.Visible = false;
            ExceptionEdit.Click += label1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExceptionEdit);
            Controls.Add(ExceptionName);
            Controls.Add(ExceptionText);
            Controls.Add(ImageText);
            Controls.Add(InformationText);
            Controls.Add(NameText);
            Controls.Add(Cancel);
            Controls.Add(CompanyRedact);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button CompanyRedact;
        private Button Cancel;
        private Label NameText;
        private Label InformationText;
        private Label ImageText;
        private Label ExceptionText;
        private Label ExceptionName;
        private Label ExceptionEdit;
    }
}