using Control_Employees;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WinFormsApp2
{
    static class Data
    {
        public static string fileName = null;
        public static string pathEmployeeList = null;
        public static string pathCompanyList = null;
        public static string pathPictureEmployee = null;
        public static string pathPictureCompany = null;

        public static List<Employee> employeeList = new List<Employee>();

        public static List<Company> companyList = new List<Company>();
        public static bool CheckRecentProject(string FileName)
        {
            if (!(File.Exists(pathCompanyList) && File.Exists(pathEmployeeList) && Directory.Exists(pathPictureEmployee) && Directory.Exists(pathPictureCompany)))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(@"C:\\Users\\Нагибатор\\source\\repos\\WinFormsApp2\\WinFormsApp2\\RecentProject.xml");

                XmlNode elementToDelete = null;
                foreach (XmlElement tmpElementToDelete in xmlDoc.DocumentElement.ChildNodes)
                {
                    XmlAttribute nameAttribute = tmpElementToDelete.Attributes["name"];
                    if (nameAttribute != null && nameAttribute.Value == FileName)
                    {
                        elementToDelete = tmpElementToDelete;
                        break;
                    }
                }

                if (elementToDelete != null)
                {
                    xmlDoc.DocumentElement.RemoveChild(elementToDelete);

                    xmlDoc.Save(@"C:\Users\Нагибатор\source\repos\WinFormsApp2\WinFormsApp2\RecentProject.xml");
                }
                fileName = null;
                pathEmployeeList = null;
                pathCompanyList = null;
                pathPictureEmployee = null;
                pathPictureCompany = null;
                return false;
            }
            return true;
        }
        public static bool OpenEmploeeListFrom(string pathEmploeeList)
        {
            employeeList.Clear();
            if (!CheckRecentProject(fileName))
            {
                MessageBox.Show("File is damage"); 
                return false;
            }
            
            XmlDocument employeeFile = new XmlDocument();
            employeeFile.Load(pathEmploeeList);


            XmlElement xRootEmployee = employeeFile.DocumentElement;
            foreach (XmlElement xNod in xRootEmployee)
            {
                Employee tmpEmployee;
                try
                {
                    tmpEmployee = new Employee { Name = xNod.Attributes.GetNamedItem("name").Value };
                }
                catch (Exception)
                {
                    MessageBox.Show("It's not employee list");
                    Data.employeeList.Clear();
                    return false;
                    throw;
                }


                foreach (XmlNode Child_xNod in xNod.ChildNodes)
                {
                    switch (Child_xNod.Name)
                    {
                        case "company":
                            tmpEmployee.company = Child_xNod.InnerText;
                            break;

                        case "age":
                            tmpEmployee.age = int.Parse(Child_xNod.InnerText);
                            break;

                        case "text":
                            tmpEmployee.text = Child_xNod.InnerText;
                            break;

                        case "image":
                            tmpEmployee.image = Child_xNod.InnerText;
                            break;
                    }
                }
                employeeList.Add(tmpEmployee);
            }
            Data.pathEmployeeList = pathEmploeeList;
            return true;
        }

        public static bool OpenCompanyListFrom(string pathCompanyList)
        {
            Data.companyList.Clear();
            XmlDocument companyFile = new XmlDocument();
            companyFile.Load(pathCompanyList);

            XmlElement xRootCompany = companyFile.DocumentElement;
            foreach (XmlElement xNod in xRootCompany)
            {
                Company tmpCompany;
                try
                {
                    tmpCompany = new Company { Name = xNod.Attributes.GetNamedItem("name").Value };
                }
                catch (Exception)
                {
                    MessageBox.Show("It's not company list");
                    Data.companyList.Clear();
                    return false;
                    throw;
                }
                foreach (XmlNode Child_xNod in xNod.ChildNodes)
                {
                    switch (Child_xNod.Name)
                    {
                        case "text":
                            tmpCompany.text = Child_xNod.InnerText;
                            break;

                        case "image":
                            tmpCompany.image = Child_xNod.InnerText;
                            break;
                    }
                }
                Data.companyList.Add(tmpCompany);
            }
            Data.pathCompanyList = pathCompanyList;
            return true;
        }
        public static bool SaveFile()
        {
            
            if (pathCompanyList == null || pathEmployeeList == null)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                //if(fileName == null)
                //{
                //    NewFileForm newFileForm = new NewFileForm();
                //    newFileForm.ShowDialog();
                //    return true;
                //}    

                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                    return false;

                Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\" + fileName);
                Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\" + fileName + "\\Picture");
                Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\" + fileName + "\\Picture\\employee");
                Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\" + fileName + "\\Picture\\company");
                Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\" + fileName);
                pathEmployeeList = folderBrowserDialog.SelectedPath + $"\\{fileName}\\EmployeeList";
                pathCompanyList = folderBrowserDialog.SelectedPath + $"\\{fileName}\\CompanyList";
                pathPictureEmployee = folderBrowserDialog.SelectedPath + $"\\{fileName}\\Picture\\employee";
                pathPictureCompany = folderBrowserDialog.SelectedPath + $"\\{fileName}\\Picture\\company";
            }

            XDocument employeeFileSave = new XDocument();
            employeeFileSave.Add(new XElement("Employer"));
            XElement xRootEmployeeSave = employeeFileSave.Element("Employer");

            foreach (Employee employee in Data.employeeList)
            {
                xRootEmployeeSave.Add(new XElement("emloyer",
                new XAttribute("name", employee.Name),
                new XElement("company", employee.company),
                new XElement("age", employee.age),
                new XElement("text", employee.text),
                new XElement("image", employee.image)));
            }
            employeeFileSave.Save(pathEmployeeList);

            XDocument companyFileSave = new XDocument();
            companyFileSave.Add(new XElement("Company"));
            XElement Company = companyFileSave.Element("Company");

            foreach (Company company in Data.companyList)
            {
                Company.Add(new XElement("company",
                new XAttribute("name", company.Name),
                new XElement("text", company.text),
                new XElement("image", company.image)));
            }
            companyFileSave.Save(pathCompanyList);
            return true;
            //SaveRecentProjectInformation();
        }
        public static void SaveRecentProjectInformation()
        {
            List<Project> RecentProjects = new();
            XmlDocument xDocResentProjects = new XmlDocument();
            xDocResentProjects.Load(@"C:\\Users\\Нагибатор\\source\\repos\\WinFormsApp2\\WinFormsApp2\\RecentProject.xml");
            XmlElement xRootResentProjects = xDocResentProjects.DocumentElement;
            foreach (XmlElement xNod in xRootResentProjects)
            {
                if(!Equals(xNod.Attributes.GetNamedItem("nameProject").Value, fileName))
                {
                    XElement SaveHistoryProject = null;
                    SaveHistoryProject.Add(new XElement("ListProjects",
                        new XAttribute("nameProjects", fileName),
                        new XElement("pathEmployeeList", pathEmployeeList),
                        new XElement("pathCompanyList", pathCompanyList)));
                    // Don't foggot to switch path to the xml file
                    SaveHistoryProject.Save(@"C:\\Users\\Нагибатор\\source\\repos\\WinFormsApp2\\WinFormsApp2\\RecentProject.xml");
                }
            }
        }
    }
}
