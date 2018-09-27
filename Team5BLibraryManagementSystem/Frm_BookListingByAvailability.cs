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
    public partial class Frm_BookListingByAvailability : Form
    {
        public Frm_BookListingByAvailability()
        {
            InitializeComponent();
        }

        private void Frm_BookListingByAvailability_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var ds = new Dataset_BookListAvailability();
            var dt = ds.ViewBooksListing;
            var adapter = new Dataset_BookListAvailabilityTableAdapters.ViewBooksListingTableAdapter();
            adapter.Fill(dt);
            Rpt_BookListByAvailability cr1 = new Rpt_BookListByAvailability();
            cr1.SetDataSource(ds);
            crv_BookListingByAvailiability.ReportSource = cr1;
        }
    }
}
