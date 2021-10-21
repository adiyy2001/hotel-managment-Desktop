using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_managment
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query; 
        
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = "select username, pass from employee where username = '"+username.Text+"' and pass='"+password.Text+"'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            } else
            {
                labelError.Visible = true;
                password.Clear();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
