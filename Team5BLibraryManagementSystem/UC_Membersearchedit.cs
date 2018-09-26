using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5BLibraryManagementSystem
{
    public partial class UC_Membersearchedit : UserControl
    {
        public UC_Membersearchedit()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                                        
        }

        private void Fetchdata(string comboboxselection)
        {

            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            var q = (from x in context.Members
                     where x.memberid.ToString() == Textbox_Category.Text
                     select x).First();

            Textbox_Membername.Text = q.name.ToString();
            Textbox_Idnumber.Text = q.name.ToString();
            Textbox_Phone.Text = q.phonenumber.ToString();
            Textbox_email.Text = q.email.ToString();
            Datetimepicker_Dob.Text = q.dateofbirth.ToString();
            Textbox_Address.Text = q.address.ToString();
            Datetimepicker_Joineddate.Text = q.joindate.ToString();
            Datetimepicker_Expirydate.Text = q.expirydate.ToString();
        }
    }
}
