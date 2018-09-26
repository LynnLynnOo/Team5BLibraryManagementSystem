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
    public partial class Uc_Membersearchedit : UserControl
    {
        public Uc_Membersearchedit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
   
        
        private void btn_Print_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();

            var q = (from x in context.Members
                     where x.memberid == Convert.ToInt32(Textbox_Category.Text)
                     select x).First();
            textBox1.Text = q.name.ToString();

            //Textbox_Membername.Text = q.name.ToString();
            //Textbox_Idnumber.Text = q.memberid.ToString();
            //Textbox_Phone.Text = q.phonenumber.ToString();
            //Textbox_email.Text = q.email.ToString();
            //Datetimepicker_Dob.Text = q.dateofbirth.ToString();
            //Textbox_Address.Text = q.address.ToString();
            //Datetimepicker_Joineddate.Text = q.joindate.ToString();
            //Datetimepicker_Expirydate.Text = q.expirydate.ToString();
        }



    }
}
