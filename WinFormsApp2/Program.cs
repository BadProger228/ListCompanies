using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WinFormsApp2
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            XmlDocument emploeeFile = new XmlDocument();
            emploeeFile.Load(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName).FullName 
                + @"\Employees.xml");

            XmlDocument companyFile = new XmlDocument();
            companyFile.Load(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName).FullName
                + @"\Companies.xml");


            XmlElement xRootEmployee = emploeeFile.DocumentElement;
            foreach (XmlElement xNod in xRootEmployee)
            {
                Employee tmpEmployee = new Employee { Name = xNod.Attributes.GetNamedItem("name").Value };

                foreach (XmlNode Child_xNod in xNod.ChildNodes)
                {
                    switch (Child_xNod.Name)
                    {
                        case "company":
                            tmpEmployee.company = Child_xNod.InnerText;
                            break;

                        case "age":
                            tmpEmployee.age = Child_xNod.InnerText;
                            break;

                        case "text":
                            tmpEmployee.text = Child_xNod.InnerText;
                            break;

                        case "image":
                            tmpEmployee.image = Child_xNod.InnerText;
                            break;
                    }
                }
                Data.employeeList.Add(tmpEmployee);
            }

            XmlElement xRootCompany = companyFile.DocumentElement;
            foreach (XmlElement xNod in xRootCompany)
            {
                Company tmpCompany = new Company { Name = xNod.Attributes.GetNamedItem("name").Value };
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
            

            ApplicationConfiguration.Initialize();
            Application.Run(new mainForm());



            XDocument emploeeFileSave = new XDocument();
            emploeeFileSave.Add(new XElement("Employer"));
            XElement xRootEmployeeSave = emploeeFileSave.Element("Employer");

            foreach (Employee employee in Data.employeeList)
            {
                xRootEmployeeSave.Add(new XElement("emloyer",
                new XAttribute("name", employee.Name),
                new XElement("company", employee.company),
                new XElement("age", employee.age),
                new XElement("text", employee.text),
                new XElement("image", employee.image)));
            }
            emploeeFileSave.Save(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName).FullName
                + @"\Employees.xml");

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
            companyFileSave.Save(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName).FullName
                + @"\Companies.xml");
        }
    }
}