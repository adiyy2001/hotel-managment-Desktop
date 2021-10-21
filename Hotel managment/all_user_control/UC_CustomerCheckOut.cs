using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_managment.all_user_control
{
    public partial class UC_CustomerCheckOut : UserControl
    {
        function fn = new function();
        String query;
        int id;
        private readonly String baseQuery = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid ";
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = baseQuery + "where chekout = 'NO'";
            DataSet ds = fn.getData(query);
            customerCheckoutBoard.DataSource = ds.Tables[0];
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            query = baseQuery + "where cname like '" + name.Text + "%' and chekout = 'NO'";
            DataSet ds = fn.getData(query);
            customerCheckoutBoard.DataSource = ds.Tables[0];
        }
        private void customerCheckoutBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clickedRow = customerCheckoutBoard.Rows[e.RowIndex];
            if (clickedRow.Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(clickedRow.Cells[0].Value.ToString());
                Cname.Text = clickedRow.Cells[1].Value.ToString();
                roomNo.Text = clickedRow.Cells[9].Value.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (Cname.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = checkOutDate.Text;
                    query = "update customer set checkout = 'YES', chekout='" + cdate + "' where cid = '" + id + "' update rooms set booked='NO' where roomNo='" + roomNo.Text + "'";
                    fn.setData(query, "Check out Successfully.");
                    UC_CustomerCheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            Cname.Clear();
            name.Clear();
            roomNo.Clear();
            checkOutDate.ResetText();
        }

        private void checkOutDate_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}