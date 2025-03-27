using Control_Employees;
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
            //XmlDocument emploeeFile = new XmlDocument();
            //string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName).FullName
            //    + @"\Employees.xml";
            //emploeeFile.Load(path);

            //XmlDocument companyFile = new XmlDocument();
            //companyFile.Load(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName).FullName
            //    + @"\Companies.xml");


            //XmlElement xRootEmployee = emploeeFile.DocumentElement;
            //foreach (XmlElement xNod in xRootEmployee)
            //{
            //    Employee tmpEmployee = new Employee { Name = xNod.Attributes.GetNamedItem("name").Value };

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

            //XmlElement xRootCompany = companyFile.DocumentElement;
            //foreach (XmlElement xNod in xRootCompany)
            //{
            //    Company tmpCompany = new Company { Name = xNod.Attributes.GetNamedItem("name").Value };
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


            ApplicationConfiguration.Initialize();
            Application.Run(new StartForm());

            Data.SaveFile();
        }
    }
}