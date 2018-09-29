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
    public partial class Frm_PrintMember : Form
    {
        public Frm_PrintMember()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Frm_PrintMember_Load(object sender, EventArgs e)
        {
            var ds = new Dataset_PrintMember();
            var dt = ds.HistoryByMembers;
            var adapter = new Dataset_PrintMemberTableAdapters.HistoryByMembersTableAdapter();
            adapter.Fill(dt, 1);
            Rpt_PrintMember cr1 = new Rpt_PrintMember();
            cr1.SetDataSource(ds);
            crv_MemberListing.ReportSource = cr1;
        }
    }
}
