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
    public partial class Frm_BookListingAll : Form
    {
        public Frm_BookListingAll()
        {
            InitializeComponent();
        }

        private void Frm_BookListingAll_Load(object sender, EventArgs e)
        {
            var ds = new Dataset_BookListAvailability();
            var dt = ds.ViewBooksListing;
            var adapter = new Dataset_BookListAvailabilityTableAdapters.ViewBooksListingTableAdapter();
            adapter.Fill(dt);
            var cr1 = new Rpt_BookListingByAvailability();
            cr1.SetDataSource(ds);
            crv_BookListing.ReportSource = cr1;

        }
    }
}
