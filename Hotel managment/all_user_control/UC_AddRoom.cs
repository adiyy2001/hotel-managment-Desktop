using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_managment.all_user_control
{
    public partial class UC_AddRoom : UserControl
    {
        public UC_AddRoom()
        {
            InitializeComponent();
        }
        function fn = new function();
        String query;


        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms ";
            DataSet ds = fn.getData(query);
            rooms.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if(
                txtRoomNo.Text != "" && 
                txtType.Text != "" && 
                txtBed.Text != "" && 
                txtPrice.Text != "")
            {
                String roomNo = txtRoomNo.Text;
                String type = txtType.Text;
                String bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms (roomNo, roomType, bed, price) values ('"+ roomNo +"', '"+type+"', '"+bed+"', '"+price+"')";
                fn.setData(query, "Room Added");
                UC_AddRoom_Load(this, null);

                ClearAllFields();
            } else
            {
                MessageBox.Show(
                    "Fill All Fileds.", 
                    "Warning", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
            }
        }
        public void ClearAllFields()
        {
            txtRoomNo.Clear();
            txtPrice.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
