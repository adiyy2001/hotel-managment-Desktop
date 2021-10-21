using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_managment.all_user_control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }

        private void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);
            String Id = ds.Tables[0].Rows[0][0].ToString();
            if (Id != "")
            {
                Int64 num = Int64.Parse(Id);
                labelToSet.Text = (num + 1).ToString();
            }
            else
            {
                labelToSet.Text = "0";
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (
              primaryName.Text != "" &&
              mobileNo.Text != "" &&
              genderType.Text != "" &
              email.Text != "" &&
              username.Text != "" &&
              password.Text != ""
            )
            {
                String name = primaryName.Text;
                Int64 mobile = Int64.Parse(mobileNo.Text);
                String gender = genderType.Text;
                String emailV = email.Text;
                String usernameV = username.Text;
                String pass = password.Text;

                query =
                  "insert into employee(name, mobile, gender, emailid, username, pass) " +
                  "values('" + name + "', '" + mobile + "', '" + gender + "', '" + emailV + "', '" + usernameV + "', '" + pass + "')";
                fn.setData(query, "Employee Registered ");

                clearAll();
                getMaxID();

            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll()
        {
            name.Clear();
            mobileNo.Clear();
            gender.SelectedIndex = -1;
            email.Clear();
            username.Clear();
            password.Clear();
        }

        private void tabEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabEmployees.SelectedIndex == 1)
            {
                loadEmployees(guna2DataGridView2);
            }
            else if (tabEmployees.SelectedIndex == 2)
            {
                loadEmployees(guna2DataGridView3);
            }
        }

        private void loadEmployees(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure?", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Int64 id = Int64.Parse(EmployeeId.Text);
                query = "delete from employee where eid = '" + id + "'";
             
                fn.setData(query, "Record Deleted");
                tabEmployees_SelectedIndexChanged(this, null);
            }

        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}