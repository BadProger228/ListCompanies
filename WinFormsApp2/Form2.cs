using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class addCompany : Form
    {
        private Employee _employee = new Employee();
        private string _nameOld;
        private bool _nameTest = false;
        private bool _ageTest = false;
        private bool _textTest = false;
        public addCompany(string name)
        {
            InitializeComponent();
            this._nameOld = name;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Tag = 2;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox1.Text = _nameOld;

            if (_nameOld == null)
                this.Text = "Add emploee";
            else
                this.Text = "Edit emploee";

            foreach (Company company in Data.companyList)
                comboBox1.Items.Add(company.Name);


            foreach (Employee employee in Data.employeeList)
            {
                if (employee.Name == textBox1.Text)
                {
                    this._employee = employee;
                    comboBox1.Text = employee.company;
                    textBox2.Text = employee.age;
                    textBox3.Text = employee.text;
                    pictureBox1.ImageLocation = employee.image;
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this._nameTest = false;

            foreach (Employee employee in Data.employeeList)
            {
                if ((employee.Name == textBox1.Text || textBox1.Text == "") && this._nameOld != textBox1.Text)
                {
                    ExceptionNameText.Visible = true;
                    ExceptionNameText.Text = "The given name is already in use or the string is empty";
                    return;
                }
            }

            ExceptionNameText.Visible = false;

            this._nameTest = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string text = textBox3.Text;

            if (text.Length < 40)
            {
                ExceptionText.Visible = true;
                ExceptionText.Text = $"It remains to enter {40 - text.Length}";
                return;
            }

            ExceptionText.Visible = false;

            this._textTest = true;
        }

        private void cancelEmploe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RedactEmploe_Click(object sender, EventArgs e)
        {
            mainForm main = this.Owner as mainForm;
            if (this._nameTest && comboBox1.Text != "" && _ageTest && _textTest && pictureBox1.Image != null)
            {
                Employee tmpEmployee = new Employee
                {
                    Name = textBox1.Text,
                    company = comboBox1.Text,
                    age = textBox2.Text,
                    text = textBox3.Text,
                    image = pictureBox1.ImageLocation
                };

                if (main.typeListSort.Text == "Company")
                {
                    main.listBox2.Items.Remove(_employee.Name);
                    main.listBox2.Items.Add(tmpEmployee.Name);
                }
                else
                {
                    main.listBox1.Items.Remove(_employee.Name);
                    main.listBox1.Items.Add(tmpEmployee.Name);
                }

                Data.employeeList.Remove(_employee);
                Data.employeeList.Add(tmpEmployee);

                Close();
            }
            ExceptionRedactText.Visible = true;
            ExceptionRedactText.Text = "You entered incorrect data or filled out not all fields";
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    string deletePictureName = pictureBox1.ImageLocation;

                    pictureBox1.Image = null;
                    File.Delete(deletePictureName);
                }

                string loadPicture = openFile.FileName;
                pictureBox1.Load(loadPicture);


                string loadSave = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName).FullName, "Picture", "employee\\")
                + Path.GetFileName(loadPicture);


                try
                {
                    File.Copy(loadPicture, loadSave);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You open picture with the same name");
                }


                pictureBox1.ImageLocation = loadSave;






            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this._ageTest = false;
            int tmpAge;
            try
            {
                tmpAge = int.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                ExceptionAge1.Visible = true;
                ExceptionAge1.Text = "Can only use numbers";
                return;
            }

            ExceptionAge1.Visible = false;

            if (tmpAge < 18 || tmpAge > 125)
            {
                ExceptionAge1.Visible = true;
                ExceptionAge1.Text = "You entered an invalid age";
                return;
            }

            this._ageTest = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
