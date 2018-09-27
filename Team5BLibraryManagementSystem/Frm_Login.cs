using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5BLibraryManagementSystem
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            if (textbox_Username.Text == "" || textbox_Password.Text == "")
            {
                MessageBox.Show("Fields not entered!");
                return;
            }
            SA47Team05BESNETLMSEntities ctx = new SA47Team05BESNETLMSEntities();
            string username = textbox_Username.Text;
            var query1 = ctx.Users.Where(x => x.username == username).Count();
            if (query1 <= 0)
            {
                Console.WriteLine("invalid username");
                MessageBox.Show("Invalid Fields!");
                return;
            }
            string password = textbox_Password.Text;
            string hash = Helpersfunc.GetMD5(password);
            string query2 = ctx.Users.Where(x => x.username == username).First().password;
            if (query2 != hash)
            {
                MessageBox.Show("Invalid Fields!");
                return;
            }
            else
            {
                this.Hide();
                Frm_Main frm_Main = new Frm_Main();
                frm_Main.Show();
            }
        }

        private void textbox_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
