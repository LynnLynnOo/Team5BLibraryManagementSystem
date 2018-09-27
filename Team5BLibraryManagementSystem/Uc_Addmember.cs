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
        int count = 0;
        public Uc_Addmember()
        {
            InitializeComponent();
        }

        //Submit button
        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }

        //Reset button
        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        //Member ID count
        private void Uc_Addnewmember_Load(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            int q = (from x in context.Members select x).Count();
            count = count + q + 1;
            textbox_Ic.Text = count.ToString();
        }


        //Phone number validation
        private void textbox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //Email Validation
        private void textbox_Email_Leave(object sender, EventArgs e)
        {

        }
    }
}
