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
    public partial class Frm_MemberListing : Form
    {
        Uc_Reports uc1;
        public Frm_MemberListing()
        {
            InitializeComponent();
        }
        public Frm_MemberListing(Uc_Reports uc1)
        {
            InitializeComponent();
            this.uc1 = uc1;
            uc1.RdbtnAllChecked += RdbtnAllLoad;
            uc1.RdbtnBeforeChecked += RdbtnBeforeLoad;
            uc1.RdbtnPastChecked += RdbtnPastLoad;
        }
        private void RdbtnAllLoad(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities ctx = new SA47Team05BESNETLMSEntities();
            Rpt_MemberListing cr1 = new Rpt_MemberListing();
            cr1.SetDataSource(ctx.Members);
            crv_MemberListing.ReportSource = cr1;
        }
        private void RdbtnPastLoad(object sender, EventArgs e)
        {
            var ds = new Dataset_MembersByExpiry();
            var dt = ds.MembersPastExpiry;
            var adapter = new Dataset_MembersByExpiryTableAdapters.MembersPastExpiryTableAdapter();
            adapter.Fill(dt);
            Rpt_MemberListingPastExpiry cr1 = new Rpt_MemberListingPastExpiry();
            cr1.SetDataSource(ds);
            crv_MemberListing.ReportSource = cr1;
        }
        private void RdbtnBeforeLoad(object sender, EventArgs e)
        {
            var ds = new Dataset_MembersByExpiry();
            var dt = ds.MembersBeforeExpiry;
            var adapter = new Dataset_MembersByExpiryTableAdapters.MembersBeforeExpiryTableAdapter();
            adapter.Fill(dt);
            Rpt_MemberListingBeforeExpiry cr1 = new Rpt_MemberListingBeforeExpiry();
            cr1.SetDataSource(ds);
            crv_MemberListing.ReportSource = cr1;
        }

        private void Frm_MemberListing_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


    }
}
