using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        private Company _company = new Company();
        private string _name;
        private bool _nameTest = false;
        private bool _text = false;
        public Form3(string name)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this._name = name;
            textBox1.Text = name;

            if (name == null)
                this.Text = "Add company";
            else
                this.Text = "Edit company";

            foreach (Company company in Data.companyList)
            {
                if (company.Name == textBox1.Text)
                {
                    this._company = company;
                    textBox2.Text = company.text;
                    pictureBox1.ImageLocation = company.image;
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this._nameTest = false;
            foreach (Company company in Data.companyList)
            {
                if ((company.Name == textBox1.Text || textBox1.Text == "") && this._name != textBox1.Text)
                {
                    ExceptionName.Visible = true;
                    ExceptionName.Text = "This name is already in use or the string is empty";
                    return;
                }
            }
            ExceptionName.Visible = false;
            this._nameTest = true;
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
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    File.Delete(deletePictureName);
                }

                string loadPicture = openFile.FileName;
                pictureBox1.Load(loadPicture);


                //string loadSave = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName).FullName, "Picture", "company\\")
                //+ Path.GetFileName(loadPicture);

                try
                {
                    File.Copy(loadPicture, Data.pathPictureCompany + "\\" + Path.GetFileName(loadPicture));
                }
                catch
                {
                    MessageBox.Show("You open picture with the same name");
                }
                pictureBox1.ImageLocation = Data.pathPictureCompany + "\\" + Path.GetFileName(loadPicture);
            }
        }
        private void CompanyRedact_Click(object sender, EventArgs e)
        {
            mainForm main = this.Owner as mainForm;
            if (this._nameTest && _text && pictureBox1.Image != null)
            {
                Company tmpCompany = new Company
                {
                    Name = textBox1.Text,
                    text = textBox2.Text,
                    image = pictureBox1.ImageLocation
                };

                if (main.typeListSort.Text == "Company")
                {
                    main.listBox1.Items.Remove(_company.Name);
                    main.listBox1.Items.Add(tmpCompany.Name);
                }

                Data.companyList.Remove(_company);
                Data.companyList.Add(tmpCompany);
                Close();
            }
            ExceptionEdit.Visible = true;
            ExceptionEdit.Text = "You entered incorrect data or filled out not all fields";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (text.Length < 40)
            {
                ExceptionText.Visible = true;
                ExceptionText.Text = $"It remains to enter {40 - text.Length}";
                return;
            }
            ExceptionText.Visible = false;
            this._text = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void NameText_Click(object sender, EventArgs e)
        {

        }
    }
}
