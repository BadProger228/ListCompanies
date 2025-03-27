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
using System.Xml.Linq;
using WinFormsApp2;

namespace Control_Employees
{
    public partial class OpenFileForm : Form
    {
        public OpenFileForm()
        {
            InitializeComponent();
        }

        private void fullPathDetected()
        {


        }

        private void AddEmployeeList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            if(Data.OpenEmploeeListFrom(openFile.FileName))
                pathEmployeeList.Text = openFile.FileName;
            
            //Data.employeeList.Clear();
            //XmlDocument employeeFile = new XmlDocument();
            //employeeFile.Load(openFile.FileName);


            //XmlElement xRootEmployee = employeeFile.DocumentElement;
            //foreach (XmlElement xNod in xRootEmployee)
            //{
            //    Employee tmpEmployee;
            //    try
            //    {
            //        tmpEmployee = new Employee { Name = xNod.Attributes.GetNamedItem("name").Value };
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("It's not employee list");
            //        Data.employeeList.Clear();
            //        return;
            //        throw;
            //    }


            //    foreach (XmlNode Child_xNod in xNod.ChildNodes)
            //    {
            //        switch (Child_xNod.Name)
            //        {
            //            case "company":
            //                tmpEmployee.company = Child_xNod.InnerText;
            //                break;

            //            case "age":
            //                tmpEmployee.age = int.Parse(Child_xNod.InnerText);
            //                break;

            //            case "text":
            //                tmpEmployee.text = Child_xNod.InnerText;
            //                break;

            //            case "image":
            //                tmpEmployee.image = Child_xNod.InnerText;
            //                break;
            //        }
            //    }
            //    Data.employeeList.Add(tmpEmployee);
            //}
            //Data.pathEmployeeList = openFile.FileName;
            //pathEmployeeList.Text = openFile.FileName;
        }

        private void AddCompanyList_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            if (Data.OpenCompanyListFrom(openFile.FileName))
                pathCompanyList.Text = openFile.FileName;

            //Data.companyList.Clear();
            //XmlDocument companyFile = new XmlDocument();
            //companyFile.Load(openFile.FileName);

            //XmlElement xRootCompany = companyFile.DocumentElement;
            //foreach (XmlElement xNod in xRootCompany)
            //{
            //    Company tmpCompany;
            //    try
            //    {
            //        tmpCompany = new Company { Name = xNod.Attributes.GetNamedItem("name").Value };
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("It's not company list");
            //        Data.companyList.Clear();
            //        return;
            //        throw;
            //    }
            //    foreach (XmlNode Child_xNod in xNod.ChildNodes)
            //    {
            //        switch (Child_xNod.Name)
            //        {
            //            case "text":
            //                tmpCompany.text = Child_xNod.InnerText;
            //                break;

            //            case "image":
            //                tmpCompany.image = Child_xNod.InnerText;
            //                break;
            //        }
            //    }
            //    Data.companyList.Add(tmpCompany);
            //}
            //Data.pathCompanyList = openFile.FileName;
            //pathCompanyList.Text = openFile.FileName;

        }
        private void OpenFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
        }
        private void OpenFileForm_Load(object sender, EventArgs e)
        {
            pathCompanyList.Enabled = false;
            pathEmployeeList.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pathEmployeeList_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (pathEmployeeList.Text == "" || pathCompanyList.Text == "")
            {
                MessageBox.Show("You don't open lists");
                return;
            }
            
            XDocument recentProject = new XDocument(@"C:\\Users\\Нагибатор\\source\\repos\\WinFormsApp2\\WinFormsApp2\\RecentProject.xml");
            recentProject.Add(new XElement("nameProject",
                new XAttribute("name", "Linker"),
                new XElement("pathEmployeeList", pathEmployeeList.Text),
                new XElement("pathCompanyList", pathCompanyList.Text)));

            recentProject.Save(@"C:\\Users\\Нагибатор\\source\\repos\\WinFormsApp2\\WinFormsApp2\\RecentProject.xml");

            Data.fileName = "";

            mainForm mainForm = new mainForm();
            this.Close();
            mainForm.ShowDialog();

        }
    }
}
