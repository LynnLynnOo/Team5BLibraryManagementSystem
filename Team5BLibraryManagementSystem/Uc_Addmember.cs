using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Team5BLibraryManagementSystem
{
    public partial class Uc_Addmember : UserControl
    {
        int count=0;
         public Uc_Addmember()
        {
            InitializeComponent();
        }

      //Submit button
        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (textbox_Memname.Text == "" || textbox_Email.Text == "" || textbox_Phone.Text == "" || textbox_Address.Text == "")
            {
                MessageBox.Show("Please must fill in all of the field","Warning!");
                return;
            }
            else
            {
                try
                {

                    SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
                    Member m = new Member();
                    m.name = textbox_Memname.Text;
                    m.memberid = Convert.ToInt32(textbox_Ic.Text);
                    m.phonenumber = textbox_Phone.Text;
                    m.email = textbox_Email.Text;
                    m.dateofbirth = Convert.ToDateTime(dtp_Dob.Text);
                    m.address = textbox_Address.Text;
                    m.joindate = Convert.ToDateTime(dtp_Joindate.Text);
                    m.expirydate = Convert.ToDateTime(dtp_Expirydate.Text);
                    context.Members.Add(m);
                    context.SaveChanges();
                }

                catch
                {
                    MessageBox.Show("Member Already Exists!","Warning!");
                }
            }

        }

        //Reset button
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            textbox_Memname.Clear();
            // textbox_Ic.Clear();
            textbox_Phone.Clear();
            textbox_Email.Clear();
            textbox_Address.Clear();
            dtp_Joindate.ResetText();
            dtp_Expirydate.ResetText();
            dtp_Dob.ResetText();
        }

        //Member ID count
        private void Uc_Addnewmember_Load(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            int q = (from x in context.Members select x).Count();
            count = count + q+ 1;
            textbox_Ic.Text =count.ToString();
        }


        //Phone number validation
        private void textbox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 9)
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.textbox_Phone, "Wrong Number!");
                return;
            }
        }

        //Email Validation
        private void textbox_Email_Leave(object sender, EventArgs e)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
           + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
           + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            if (Regex.IsMatch(textbox_Email.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textbox_Email, "eg.something@domain.com");
                return;
            }
        }
    }
}
