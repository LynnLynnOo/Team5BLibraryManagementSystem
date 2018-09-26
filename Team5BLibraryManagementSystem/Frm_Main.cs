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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void BooksMenu(bool visibility)
        {
            Btn_Searchbooks.Visible = visibility;
            Btn_Registernewbooks.Visible = visibility;
        }

        private void MemberMenu(bool visibility)
        {
            Btn_Searcheditmember.Visible = visibility;
            Btn_Addnewmember.Visible = visibility;
            Btn_Borrowreturnbooks.Visible = visibility;
        }

        private void Btn_Books_MouseEnter_1(object sender, EventArgs e)
        {
            BooksMenu(true);
            MemberMenu(false);
        }

        private void Btn_Members_MouseEnter_1(object sender, EventArgs e)
        {
            MemberMenu(true);
            BooksMenu(false);
        }

        private void Btn_Reports_MouseEnter_1(object sender, EventArgs e)
        {
            MemberMenu(false);
            BooksMenu(false);
        }

        private void Btn_Logout_MouseEnter(object sender, EventArgs e)
        {
            MemberMenu(false);
            BooksMenu(false);
        }

        private void uC_Membersearchedit1_Load(object sender, EventArgs e)
        {

        }
    }
}
