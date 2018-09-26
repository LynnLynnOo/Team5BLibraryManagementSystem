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
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            Member q = context.Members.Where(x => x.memberid.ToString() == Textbox_Idnumber.Text).First();

            q.name = Textbox_Membername.Text;
            //q.memberid = Convert.ToInt32(Textbox_Idnumber.Text);
            q.phonenumber = Textbox_Phone.Text;
            q.email = Textbox_email.Text;
            q.dateofbirth = Convert.ToDateTime(Datetimepicker_Dob.Text);
            q.address = Textbox_Address.Text;
            //q.joindate = Convert.ToDateTime(Datetimepicker_Joineddate.Text);
            //q.expirydate = Convert.ToDateTime(Datetimepicker_Expirydate.Text);

            context.SaveChanges();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            var q = context.Members.Where(x => x.memberid.ToString() == Textbox_Idnumber.Text).First();

            DialogResult dialogResult = MessageBox.Show(String.Format("Are you sure you want to remove the user,{0}?",q.name), "Warning", MessageBoxButtons.YesNo);
           
            if(dialogResult==DialogResult.Yes)
            {                
                context.Members.Remove(q);
                context.SaveChanges();
                MessageBox.Show(String.Format("{0} has been removed.", q.name),"Confirmation",MessageBoxButtons.OK);
            }

            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            try
            {
                Gb_Memberinformation.Visible = true;

                SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();

                var q = (from x in context.Members
                         where x.memberid.ToString() == Textbox_Category.Text
                         select x).First();

                Textbox_Membername.Text = q.name.ToString();
                Textbox_Idnumber.Text = q.memberid.ToString();
                Textbox_Phone.Text = q.phonenumber.ToString();
                Textbox_email.Text = q.email.ToString();
                Datetimepicker_Dob.Text = q.dateofbirth.ToString();
                Textbox_Address.Text = q.address.ToString();
                Datetimepicker_Joineddate.Text = q.joindate.ToString();
                Datetimepicker_Expirydate.Text = q.expirydate.ToString();

            }

            catch
            {
                Gb_Memberinformation.Visible = false;
                MessageBox.Show("Member does not exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
              
            }
            
        }



    }
}
