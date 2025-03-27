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
    public partial class StartForm : Form
    {
        List<Project> RecentProjects = new();
        public StartForm()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //OpenFileForm openFileForm = new OpenFileForm();
            //openFileForm.ShowDialog();
            FolderBrowserDialog openFolder = new FolderBrowserDialog();

            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFolder.SelectedPath + "\\CompanyList") &&
                        File.Exists(openFolder.SelectedPath + "\\EmployeeList") &&
                        Directory.Exists(openFolder.SelectedPath + "\\Picture\\employee") &&
                        Directory.Exists(openFolder.SelectedPath + "\\Picture\\company")) 
                {
                    Data.pathCompanyList = openFolder.SelectedPath + "\\CompanyList";
                    Data.pathEmployeeList = openFolder.SelectedPath + "\\EmployeeList";
                    Data.pathPictureEmployee = openFolder.SelectedPath + "\\Picture\\employee";
                    Data.pathPictureCompany = openFolder.SelectedPath + "\\Picture\\company";
                    Data.fileName = Path.GetFileName(openFolder.SelectedPath);

                    XDocument recentProject = XDocument.Load(@"C:\Users\Нагибатор\source\repos\WinFormsApp2\WinFormsApp2\RecentProject.xml");

                    XElement projectElement = new XElement("nameProject",
                        new XAttribute("name", Data.fileName),
                        new XElement("pathFile", Directory.GetParent(Data.pathEmployeeList)));

                    recentProject.Root.Add(projectElement);

                    recentProject.Save(@"C:\Users\Нагибатор\source\repos\WinFormsApp2\WinFormsApp2\RecentProject.xml");



                    mainForm mainForm = new mainForm();
                    //this.Close();
                    mainForm.ShowDialog();
                }

            }
            this.Visible = true;
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFileForm newFile = new NewFileForm();
            newFile.ShowDialog();
            this.Visible = false;
            if (!Equals(Data.fileName, null))
            {

                XDocument recentProject = XDocument.Load(@"C:\Users\Нагибатор\source\repos\WinFormsApp2\WinFormsApp2\RecentProject.xml");

                XElement projectElement = new XElement("nameProject",
                    new XAttribute("name", Data.fileName),
                    new XElement("pathFile", Directory.GetParent(Data.pathEmployeeList)));

                recentProject.Root.Add(projectElement);

                recentProject.Save(@"C:\Users\Нагибатор\source\repos\WinFormsApp2\WinFormsApp2\RecentProject.xml");


                Data.employeeList.Clear();
                Data.companyList.Clear();
                mainForm main = new mainForm();
                main.Show();
            }
            else
                this.Visible = true;
        }

        private void newFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.ContextMenuStrip = contextMenuStrip1;
            XmlDocument xDocResentProjects = new XmlDocument();
            xDocResentProjects.Load(@"C:\\Users\\Нагибатор\\source\\repos\\WinFormsApp2\\WinFormsApp2\\RecentProject.xml");
            XmlElement xRootResentProjects = xDocResentProjects.DocumentElement;
            foreach (XmlElement xNod in xRootResentProjects)
            {
                string nameProject = xNod.Attributes.GetNamedItem("name").Value;
                string pathFile = null;
                
                listBox1.Items.Add(nameProject);

                foreach (XmlNode Child_xNod in xNod.ChildNodes)
                {
                    switch (Child_xNod.Name)
                    {
                        case "pathFile":
                            if (Child_xNod != null)
                                pathFile = Child_xNod.InnerText;
                            break;
                    }
                }
                RecentProjects.Add(new Project(nameProject, pathFile));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            foreach (Project project in RecentProjects)
            {
                if (Equals(project._name, listBox1.SelectedItem.ToString()))
                {
                    if (Equals(project.pathFile, ""))
                    {
                        MessageBox.Show("Project isn't work");
                        return;
                    }
                    Data.fileName = project._name;

                    Data.pathCompanyList = project.pathFile + "\\CompanyList";
                    Data.pathEmployeeList = project.pathFile + "\\EmployeeList";
                    Data.pathPictureCompany = project.pathFile + "\\Picture\\company";
                    Data.pathPictureEmployee = project.pathFile + "\\Picture\\employee";

                    if (Data.OpenEmploeeListFrom(project.pathFile + "\\EmployeeList") && Data.OpenCompanyListFrom(project.pathFile + "\\CompanyList"))
                    {
                        this.Visible = false;
                        mainForm mainForm = new mainForm();
                        mainForm.ShowDialog();
                        this.Visible = true;
                        return;
                    }
                    StartForm_Load(sender, e);
                    return;
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteProjectFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Project project in RecentProjects)
            {
                if (Equals(project._name, listBox1.SelectedItem.ToString()))
                {
                    Directory.Delete(project.pathFile, true);
                    Data.CheckRecentProject(project._name);
                    RecentProjects.Remove(project);
                    listBox1.Items.Remove(project._name);
                    StartForm_Load(sender, e);
                    return;
                }
            }

        }
    }
}

