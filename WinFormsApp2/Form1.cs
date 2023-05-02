using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            Delete_element.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != ListBox.NoMatches)
                Delete_element.Enabled = true;


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
                Delete_element.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Edit = new Form3(null);
            Edit.Owner = this;
            Edit.ShowDialog();
            listBox1.Sorted = true;
        }
        private void Delete_element_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            Delete_element.Enabled = false;

            if (typeListSort.SelectedItem.ToString() == "Company")
            {
                foreach (Company company in Data.companyList)
                    listBox1.Items.Add(company.Name);

                searchList2.Enabled = true;
                listBox2.Enabled = true;
            }

            if (typeListSort.SelectedItem.ToString() == "Employee")
            {
                foreach (Employee employee in Data.employeeList)
                    listBox1.Items.Add(employee.Name);

                searchList2.Enabled = false;
                listBox2.Enabled = false;
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
                Edit = new addCompany(listBox2.SelectedItem.ToString());

            if (typeListSort.Text == "Company" && listBox1.SelectedIndex != ListBox.NoMatches
                && listBox2.SelectedIndex == ListBox.NoMatches)
                Edit = new Form3(listBox1.SelectedItem.ToString());

            if (typeListSort.Text == "Employee" && listBox1.SelectedIndex != ListBox.NoMatches)
                Edit = new addCompany(listBox1.SelectedItem.ToString());


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
            addCompany AddEmployee = new addCompany(null);

            AddEmployee.Owner = this;
            AddEmployee.ShowDialog();

            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Tag = 1;

            typeListSort.DropDownStyle = ComboBoxStyle.DropDownList;
            typeListSort.Items.Add("Employee");
            typeListSort.Items.Add("Company");
            typeListSort.SelectedIndex = 0;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void searchList1_TextChanged(object sender, EventArgs e)
        {
            Delete_element.Enabled = false;

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            if (typeListSort.Text == "Employee")
            {
                foreach (Employee employee in Data.employeeList)
                {
                    if (employee.Name.ToLower().Contains(searchList1.Text.ToLower()))
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
            Delete_element.Enabled = false;

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


    }
}

