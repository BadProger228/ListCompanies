using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp2
{
    public partial class mainForm : Form
    {
        int MaxAge = 0, MinAge = 0;
        string selectElementInListbox1;
        string selectElementInListbox2;
        public mainForm()
        {
            InitializeComponent();
            contextMenuStrip1.Items[2].Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (selectElementInListbox1 == listBox1.SelectedItem.ToString())
            //    listBox1.SetSelected(listBox1.Items.IndexOf(listBox1.SelectedItems[listBox1.SelectedIndex]), false);

            ////listBox1.ClearSelected();
            //else
            //    selectElementInListbox1 = listBox1.SelectedItem.ToString();           //I tried to write a fix for clear select if I select element the same in the list.


            if (listBox1.SelectedIndex != ListBox.NoMatches)
                contextMenuStrip1.Items[2].Enabled = true;


            if (typeListSort.SelectedItem.ToString() == "Company" && listBox1.SelectedIndex != ListBox.NoMatches)
            {
                listBox2.Items.Clear();
                foreach (Employee employee in Data.employeeList)
                {
                    if (listBox1.SelectedItem.ToString() == employee.company)
                        listBox2.Items.Add(employee.Name);
                }
                return;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != ListBox.NoMatches)
                contextMenuStrip1.Items[2].Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Delete_element_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            contextMenuStrip1.Items[2].Enabled = false;

            if (typeListSort.SelectedItem.ToString() == "Company")
            {
                foreach (Company company in Data.companyList)
                    listBox1.Items.Add(company.Name);

                AgeSortBox.Enabled = false;
                searchList2.Enabled = true;
                listBox2.Visible = true;
            }

            if (typeListSort.SelectedItem.ToString() == "Employee")
            {
                foreach (Employee employee in Data.employeeList)
                    if (MinAge == 0 || (employee.age >= MinAge && employee.age <= MaxAge))
                        listBox1.Items.Add(employee.Name);

                AgeSortBox.Enabled = true;
                searchList2.Enabled = false;
                listBox2.Visible = false;
            }

            if (searchList1.Text != "")
                searchList1_TextChanged(sender, e);

            if (searchList2.Text != "")
                searchList2_TextChanged(sender, e);

            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void EditElement()
        {
            if (listBox1.SelectedIndex == ListBox.NoMatches)
                return;
            Form Edit = new Form();

            if (typeListSort.Text == "Company" && listBox2.SelectedIndex != ListBox.NoMatches)
                Edit = new addEmployee(listBox2.SelectedItem.ToString());

            if (typeListSort.Text == "Company" && listBox1.SelectedIndex != ListBox.NoMatches
                && listBox2.SelectedIndex == ListBox.NoMatches)
                Edit = new Form3(listBox1.SelectedItem.ToString());

            if (typeListSort.Text == "Employee" && listBox1.SelectedIndex != ListBox.NoMatches)
                Edit = new addEmployee(listBox1.SelectedItem.ToString());


            Edit.Owner = this;
            Edit.ShowDialog();

            listBox1.Sorted = true;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != ListBox.NoMatches)
                EditElement();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != ListBox.NoMatches)
                EditElement();
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Tag = 1;

            typeListSort.DropDownStyle = ComboBoxStyle.DropDownList;
            typeListSort.Items.Add("Employee");
            typeListSort.Items.Add("Company");
            typeListSort.SelectedIndex = 0;

            AgeSortBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AgeSortBox.Text = AgeSortBox.Items[0].ToString();

            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox2.ContextMenuStrip = contextMenuStrip1;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        private void searchList1_TextChanged(object sender, EventArgs e)
        {
            contextMenuStrip1.Items[2].Enabled = false;

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            if (typeListSort.Text == "Employee")
            {
                foreach (Employee employee in Data.employeeList)
                {
                    if (employee.Name.ToLower().Contains(searchList1.Text.ToLower()) && (MinAge == 0 || (employee.age >= MinAge && employee.age <= MaxAge)))
                        listBox1.Items.Add(employee.Name);
                }

            }
            if (typeListSort.Text == "Company")
            {
                foreach (Company company in Data.companyList)
                {
                    if (company.Name.ToLower().Contains(searchList1.Text.ToLower()))
                        listBox1.Items.Add(company.Name);
                }
            }
        }

        private void searchList2_TextChanged(object sender, EventArgs e)
        {
            contextMenuStrip1.Items[2].Enabled = false;

            if (typeListSort.Text == "Company" && listBox1.SelectedIndex != ListBox.NoMatches)
            {
                listBox2.Items.Clear();
                foreach (Employee employee in Data.employeeList)
                {
                    if (employee.Name.Contains(searchList2.Text) && employee.company == listBox1.SelectedItem.ToString())
                        listBox2.Items.Add(employee.Name);
                }
            }
        }

        private void AgeSortBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (AgeSortBox.Text.ToString())
            {
                case ("All"):
                    MaxAge = 124;
                    MinAge = 18;
                    break;

                case ("18-25"):
                    MaxAge = 25;
                    MinAge = 18;
                    break;

                case ("26-35"):
                    MaxAge = 35;
                    MinAge = 26;
                    break;

                case ("36-50"):
                    MaxAge = 50;
                    MinAge = 36;
                    break;

                case ("50+"):
                    MaxAge = 124; // The most age that have person
                    MinAge = 50;
                    break;
            }
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.SaveFile();
        }

        private void saveInTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.TXT)|*.TXT";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string saveFile = "";
                int numberEmployee = 1;
                foreach (Employee employee in Data.employeeList)
                {
                    saveFile += $"#{numberEmployee++}. Name: {employee.Name}, age {employee.age}\nCompany: {employee.company}\nText about worker: {employee.text}\n\n";
                }
                File.WriteAllText(openFile.FileName, saveFile);
            }
        }

        private void WriteAllText()
        {
            throw new NotImplementedException();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addEmployee AddEmployee = new addEmployee(null);

            AddEmployee.Owner = this;
            AddEmployee.ShowDialog();

            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }

        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Edit = new Form3(null);
            Edit.Owner = this;
            Edit.ShowDialog();
            listBox1.Sorted = true;
        }

        private void deleteSelectElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (typeListSort.Text == "Company" && listBox2.SelectedIndex != ListBox.NoMatches)
            {

                DialogResult deleteMessage = MessageBox.Show($"Do you want to delete the employee: {listBox2.SelectedItem.ToString()}?", "Delete employee", MessageBoxButtons.YesNo);
                if (deleteMessage == DialogResult.Yes)
                {
                    foreach (Employee employee in Data.employeeList)
                    {
                        if (employee.Name == listBox2.SelectedItem.ToString())
                        {
                            Data.employeeList.Remove(employee);
                            listBox2.Items.Remove(listBox2.SelectedItem.ToString());
                            listBox2.Sorted = true;
                            return;
                        }
                    }
                }
            }
            if (typeListSort.Text == "Company" && listBox2.SelectedIndex == ListBox.NoMatches)
            {
                DialogResult deleteMessage = MessageBox.Show($"Do you want to delete the company: {listBox1.SelectedItem.ToString()}?", "Delete company", MessageBoxButtons.YesNo);
                if (deleteMessage == DialogResult.Yes)
                {
                    foreach (Company company in Data.companyList)
                    {
                        if (company.Name == listBox1.SelectedItem.ToString())
                        {
                            var EmployeesDelete = new List<Employee>();
                            foreach (Employee employee in Data.employeeList)
                            {
                                if (employee.company == company.Name)
                                    EmployeesDelete.Add(employee);
                            }

                            Data.employeeList = Data.employeeList.Except(EmployeesDelete).ToList();
                            Data.companyList.Remove(company);

                            listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                            listBox1.Sorted = true;

                            listBox2.Items.Clear();

                            return;
                        }
                    }
                }
            }

            if (typeListSort.Text == "Employee" && listBox1.SelectedIndex != ListBox.NoMatches)
            {
                DialogResult deleteMessage = MessageBox.Show($"Do you want to delete the employee: {listBox1.SelectedItem.ToString()}", "Delete employee", MessageBoxButtons.YesNo);
                if (deleteMessage == DialogResult.Yes)
                {
                    foreach (Employee employee in Data.employeeList)
                    {
                        if (employee.Name == listBox1.SelectedItem.ToString())
                        {
                            Data.employeeList.Remove(employee);
                            listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                            listBox1.Sorted = true;
                            return;
                        }
                    }
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openFileAndAddInYourListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            if (!(File.Exists(folderBrowserDialog.SelectedPath + "\\CompanyList") &&
                        File.Exists(folderBrowserDialog.SelectedPath + "\\EmployeeList") &&
                        Directory.Exists(folderBrowserDialog.SelectedPath + "\\Picture\\employee") &&
                        Directory.Exists(folderBrowserDialog.SelectedPath + "\\Picture\\company")))
                MessageBox.Show("File isn't correct");

            AddInXMLFile(folderBrowserDialog.SelectedPath, "EmployeeList", Data.pathEmployeeList);
            AddInXMLFile(folderBrowserDialog.SelectedPath, "CompanyList", Data.pathCompanyList);



            Data.OpenEmploeeListFrom(Data.pathEmployeeList);
            Data.OpenCompanyListFrom(Data.pathCompanyList);

            CopyAllFile(folderBrowserDialog.SelectedPath + "\\Picture\\employee", Data.pathPictureEmployee);
            CopyAllFile(folderBrowserDialog.SelectedPath + "\\Picture\\company", Data.pathPictureCompany);

            comboBox1_SelectedIndexChanged(sender, e);
        }
        private void AddInXMLFile(string sourcePath, string sourseNameFile, string pathFileFromData)
        {
            XDocument sourceEmployeeList = XDocument.Load(sourcePath + "\\" + sourseNameFile);
            XDocument targetEmployeeList = XDocument.Load(pathFileFromData);
            XElement targetRootElement = targetEmployeeList.Root;

            foreach (XElement sourceElement in sourceEmployeeList.Root.Elements())
                targetRootElement.Add(sourceElement);

            targetEmployeeList.Save(pathFileFromData);
        }
        private void CopyAllFile(string sourceDir, string targetDir)
        {
            foreach (string sourceFile in Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(sourceFile, targetDir + Path.GetFileName(sourceFile), false);
                Console.WriteLine($"Copy file: {sourceFile}");
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            if (!(File.Exists(folderBrowserDialog.SelectedPath + "\\CompanyList") &&
                        File.Exists(folderBrowserDialog.SelectedPath + "\\EmployeeList") &&
                        Directory.Exists(folderBrowserDialog.SelectedPath + "\\Picture\\employee") &&
                        Directory.Exists(folderBrowserDialog.SelectedPath + "\\Picture\\company")))
            {
                MessageBox.Show("File isn't correct");
                return;
            }

            Data.SaveFile();

            Data.pathCompanyList = folderBrowserDialog.SelectedPath + "\\CompanyList";
            Data.pathEmployeeList = folderBrowserDialog.SelectedPath + "\\EmployeeList";
            Data.pathPictureCompany = folderBrowserDialog.SelectedPath + "\\Picture\\company";
            Data.pathPictureEmployee = folderBrowserDialog.SelectedPath + "\\Picture\\employee";

            Data.OpenEmploeeListFrom(Data.pathEmployeeList);
            Data.OpenCompanyListFrom(Data.pathCompanyList);

            comboBox1_SelectedIndexChanged(sender, e);
        }
    }
}

