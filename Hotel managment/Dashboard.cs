using System;
using System.Windows.Forms;

namespace Hotel_managment
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
            movingPanel.Left = btnCustomerRegistration.Left + 20;

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
            movingPanel.Left = btnEmployee.Left + 20;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
            movingPanel.Left = btnCheckOut.Left + 20;
        }

        private void btnCustomerDetails_Click_1(object sender, EventArgs e)
        {
            customerDetails1.Visible = true;
            customerDetails1.BringToFront();
            movingPanel.Left = btnCustomerDetails.Left + 20;
        }

        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
            movingPanel.Left = btnAddRoom.Left + 20;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
