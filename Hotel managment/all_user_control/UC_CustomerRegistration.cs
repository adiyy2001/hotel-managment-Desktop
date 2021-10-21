using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_managment.all_user_control
{
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        String query;
        int rid;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        public void setCombo(String query, ComboBox name)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                    Console.WriteLine(sdr.GetString(0));
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    name.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void roomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomNo.Items.Clear();
            query = "select roomNo from rooms where bed = '" + bed.Text + "' and roomType='" + roomType.Text + "' and booked='NO'";
            setCombo(query, roomNo);
        }


        private void bed_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomType.SelectedIndex = -1;
            roomNo.Items.Clear();
            price.Clear();
        }

        private void roomNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            query = "select price, roomid from rooms where roomNo ='"+roomNo.Text+"'";
            DataSet ds = fn.getData(query);
            price.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());

        }

        private void register_Click(object sender, EventArgs e)
        {
            if(name.Text != "" && 
                mobileNo.Text != "" && 
                nationality.Text != "" && 
                gender.Text != "" && 
                address.Text != "" && 
                idProof.Text != "" && 
                dob.Text != "" &&
                checkIn.Text != "" &&
                bed.Text != "" &&
                roomType.Text != "" &&
                roomNo.Text != "" &&
                price.Text != ""
                )
            {
                String nameV = name.Text;

                Int64 mobileV = Int64.Parse(mobileNo.Text);
                String nationalV = nationality.Text;
                String genderV = gender.Text;
                
                String dobV = dob.Text;

                String idProofV = idProof.Text;

                String addressV = address.Text;

                String checkinV = checkIn.Text;

                query = "insert into customer(cname, mobile, nationality, gender, dob, idproof, addres, checkin, roomid) values ('" + nameV + "', " + mobileV + ", '" + nationalV + "', '" + genderV + "', '"+dobV+"', '"+idProofV+"', '" + addressV + "', '"+ checkinV + "', " + rid + ") update rooms set booked = 'YES' where roomNo='"+roomNo.Text+"'";
                fn.setData(query, "Room No " + roomNo.Text + " Allocation Successful.");
                clearAll();

            }
            else
            {
                MessageBox.Show("All fields are mandatory", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        public void clearAll()
        {
            name.Clear();
            mobileNo.Clear();
            nationality.Clear();
            gender.SelectedIndex = -1;
            dob.ResetText();
            idProof.Clear();
            address.Clear();
            checkIn.ResetText();
            bed.SelectedIndex = -1;
            roomType.SelectedIndex = -1;
            roomNo.Items.Clear();
            price.Clear();
        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }


}
