namespace Control_Employees
{
    partial class NewFileForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            NextClick = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 0;
            label1.Text = "Pleace enter name file: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // NextClick
            // 
            NextClick.Location = new Point(285, 63);
            NextClick.Name = "NextClick";
            NextClick.Size = new Size(118, 40);
            NextClick.TabIndex = 2;
            NextClick.Text = "Next =>";
            NextClick.UseVisualStyleBackColor = true;
            NextClick.Click += NextClick_Click;
            NextClick.KeyDown += NextClick_KeyDown;
            // 
            // NewFileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 115);
            Controls.Add(NextClick);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "NewFileForm";
            Text = "NewFileForm";
            Load += NewFileForm_Load;
            KeyUp += NewFileForm_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button NextClick;
    }
}