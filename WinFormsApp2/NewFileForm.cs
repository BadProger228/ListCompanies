using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace Control_Employees
{
    public partial class NewFileForm : Form
    {
        public NewFileForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextClick_Click(object sender, EventArgs e)
        {

            Data.fileName = textBox1.Text;
            if (!Data.SaveFile())
            {
                Data.fileName = null;
                return;
            }
            this.Close();
        }

        private void NewFileForm_Load(object sender, EventArgs e)
        {

        }

        private void NewFileForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void NewFileForm_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void NextClick_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NextClick_Click(sender, e);
            
        }
    }
}
