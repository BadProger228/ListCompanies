namespace WinFormsApp2
{
    partial class addEmployee
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            RedactEmploe = new Button();
            cancelEmploe = new Button();
            NameText = new Label();
            CompanyText = new Label();
            AgeText = new Label();
            AllinformationText = new Label();
            PersonImageText = new Label();
            ExceptionAge1 = new Label();
            ExceptionText = new Label();
            ExceptionRedactText = new Label();
            ExceptionNameText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(468, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(487, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(32, 320);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(400, 133);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 130);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 28);
            comboBox1.TabIndex = 7;
            // 
            // RedactEmploe
            // 
            RedactEmploe.Location = new Point(127, 501);
            RedactEmploe.Name = "RedactEmploe";
            RedactEmploe.Size = new Size(210, 54);
            RedactEmploe.TabIndex = 8;
            RedactEmploe.Text = "Redact";
            RedactEmploe.UseVisualStyleBackColor = true;
            RedactEmploe.Click += RedactEmploe_Click;
            // 
            // cancelEmploe
            // 
            cancelEmploe.Location = new Point(821, 502);
            cancelEmploe.Name = "cancelEmploe";
            cancelEmploe.Size = new Size(134, 53);
            cancelEmploe.TabIndex = 9;
            cancelEmploe.Text = "cancel";
            cancelEmploe.UseVisualStyleBackColor = true;
            cancelEmploe.Click += cancelEmploe_Click;
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(48, 50);
            NameText.Name = "NameText";
            NameText.Size = new Size(52, 20);
            NameText.TabIndex = 10;
            NameText.Text = "Name:";
            // 
            // CompanyText
            // 
            CompanyText.AutoSize = true;
            CompanyText.Location = new Point(49, 133);
            CompanyText.Name = "CompanyText";
            CompanyText.Size = new Size(75, 20);
            CompanyText.TabIndex = 11;
            CompanyText.Text = "Company:";
            // 
            // AgeText
            // 
            AgeText.AutoSize = true;
            AgeText.Location = new Point(49, 209);
            AgeText.Name = "AgeText";
            AgeText.Size = new Size(43, 20);
            AgeText.TabIndex = 12;
            AgeText.Text = "Age: ";
            // 
            // AllinformationText
            // 
            AllinformationText.AutoSize = true;
            AllinformationText.Location = new Point(48, 285);
            AllinformationText.Name = "AllinformationText";
            AllinformationText.Size = new Size(116, 20);
            AllinformationText.TabIndex = 13;
            AllinformationText.Text = "All information: ";
            // 
            // PersonImageText
            // 
            PersonImageText.AutoSize = true;
            PersonImageText.Location = new Point(468, 47);
            PersonImageText.Name = "PersonImageText";
            PersonImageText.Size = new Size(202, 20);
            PersonImageText.TabIndex = 14;
            PersonImageText.Text = "Image, double click for open:";
            // 
            // ExceptionAge1
            // 
            ExceptionAge1.AutoSize = true;
            ExceptionAge1.ForeColor = Color.Red;
            ExceptionAge1.Location = new Point(49, 178);
            ExceptionAge1.Name = "ExceptionAge1";
            ExceptionAge1.Size = new Size(0, 20);
            ExceptionAge1.TabIndex = 15;
            ExceptionAge1.Visible = false;
            // 
            // ExceptionText
            // 
            ExceptionText.AutoSize = true;
            ExceptionText.ForeColor = Color.Red;
            ExceptionText.Location = new Point(184, 285);
            ExceptionText.Name = "ExceptionText";
            ExceptionText.Size = new Size(0, 20);
            ExceptionText.TabIndex = 16;
            ExceptionText.Visible = false;
            // 
            // ExceptionRedactText
            // 
            ExceptionRedactText.AutoSize = true;
            ExceptionRedactText.ForeColor = Color.Red;
            ExceptionRedactText.Location = new Point(49, 462);
            ExceptionRedactText.Name = "ExceptionRedactText";
            ExceptionRedactText.Size = new Size(0, 20);
            ExceptionRedactText.TabIndex = 17;
            ExceptionRedactText.Visible = false;
            // 
            // ExceptionNameText
            // 
            ExceptionNameText.AutoSize = true;
            ExceptionNameText.Font = new Font("Source Sans Pro", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExceptionNameText.ForeColor = Color.Red;
            ExceptionNameText.Location = new Point(48, 20);
            ExceptionNameText.Name = "ExceptionNameText";
            ExceptionNameText.Size = new Size(0, 19);
            ExceptionNameText.TabIndex = 18;
            ExceptionNameText.Visible = false;
            // 
            // addCompany
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 567);
            Controls.Add(ExceptionNameText);
            Controls.Add(ExceptionRedactText);
            Controls.Add(ExceptionText);
            Controls.Add(ExceptionAge1);
            Controls.Add(PersonImageText);
            Controls.Add(AllinformationText);
            Controls.Add(AgeText);
            Controls.Add(CompanyText);
            Controls.Add(NameText);
            Controls.Add(cancelEmploe);
            Controls.Add(RedactEmploe);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "addCompany";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button RedactEmploe;
        private Button cancelEmploe;
        private Label NameText;
        private Label CompanyText;
        private Label AgeText;
        private Label AllinformationText;
        private Label PersonImageText;
        private Label ExceptionAge1;
        private Label ExceptionText;
        private Label ExceptionRedactText;
        private Label ExceptionNameText;
    }
}