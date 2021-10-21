using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_managment.all_user_control
{
    public partial class CustomerDetails : UserControl
    {
        function fn = new function();
        String query;
        private readonly String baseQuery = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomid = rooms.roomid ";
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void searchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchBy.SelectedIndex)
            {
                case 0:
                    query = baseQuery;
                    setRecord(query);
                    break;
                case 1:
                    query = baseQuery + "where checkout is null";
                    setRecord(query);
                    break;
                case 2:
                    query = baseQuery + "where checkout is not null";
                    setRecord(query);
                    break;

            }

        }

        private void setRecord(String query)
        {
            DataSet ds = fn.getData(query);
            customerCheckoutBoard.DataSource = ds.Tables[0];
        }
    }
}