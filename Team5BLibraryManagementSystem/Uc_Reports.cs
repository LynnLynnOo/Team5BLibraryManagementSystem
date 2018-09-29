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
    public partial class Uc_Reports : UserControl
    {
        public delegate void OnAllMembersCheckedEventHandler(object sender, EventArgs e);
        public event OnAllMembersCheckedEventHandler RdbtnAllChecked;

        public delegate void OnMembersPastExpiryCheckedEventHandler(object sender, EventArgs e);
        public event OnMembersPastExpiryCheckedEventHandler RdbtnPastChecked;

        public delegate void OnMembersBeforeExpiryCheckedEventHandler(object sender, EventArgs e);
        public event OnMembersBeforeExpiryCheckedEventHandler RdbtnBeforeChecked;

        public Uc_Reports()
        {
            InitializeComponent();

        }

        private void cmb_Typesofreport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Typesofreport.SelectedIndex == 0)
            {
                //BOOK LIST
                groupBox_BookList.Visible = true;
                groupBox_MemberListing.Visible = false;
            }
            else 
            {
                //MEMBER LIST
                groupBox_BookList.Visible = false;
                groupBox_MemberListing.Visible = true;
            }
            
        }

        private void btn_PrintMemberListing_Click(object sender, EventArgs e)
        {
            Frm_MemberListing f1 = new Frm_MemberListing(this);
            if (rdbtn_Membersafterexpiry.Checked == true)
            {
                if (RdbtnPastChecked != null)
                {
                    RdbtnPastChecked(this, EventArgs.Empty);
                }

                f1.ShowDialog();
                return;
            }
            if (rdbtn_Membersbeforeexpiry.Checked == true)
            {
                if (RdbtnBeforeChecked != null)
                {
                    RdbtnBeforeChecked(this, EventArgs.Empty);
                }

                f1.ShowDialog();
                return;
            }
            if (rdbtn_Allmembers.Checked == true)
            {
                if (RdbtnAllChecked != null)
                {
                    RdbtnAllChecked(this, EventArgs.Empty);
                }
                f1.ShowDialog();
                return;
            }
        }

        

        private void btn_BookList_Click(object sender, EventArgs e)
        {
            if (rdbtn_Availability.Checked == true)
            {
                Frm_BookListingByAvailability f1 = new Frm_BookListingByAvailability();
                f1.ShowDialog();
                return;
            }
            if (rdbtn_Category.Checked == true)
            {
                Frm_BookListingByCategory f1 = new Frm_BookListingByCategory();
                f1.ShowDialog();
                return;
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Frm_BookListingAll f1 = new Frm_BookListingAll();
            f1.ShowDialog();
            return;
        }
    }
}
