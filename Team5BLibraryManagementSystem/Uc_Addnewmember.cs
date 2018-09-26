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
    public partial class Uc_Addnewmember : UserControl
    {
         public Uc_Addnewmember()
        {
            InitializeComponent();
        }
      
        private void btn_Submit_Click(object sender, EventArgs e)
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
                MessageBox.Show("Member Already Exists!");
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_gotosearch_Click(object sender, EventArgs e)
        {
            Uc_Membersearchedit Memedit = new Uc_Membersearchedit();
            Memedit.Show();
            Memedit.Dispose();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            textbox_Memname.Clear();
            textbox_Ic.Clear();
            textbox_Phone.Clear();
            textbox_Email.Clear();
            textbox_Address.Clear();
            dtp_Joindate.ResetText();
            dtp_Expirydate.ResetText();
            dtp_Dob.ResetText();
        }
    }
}
