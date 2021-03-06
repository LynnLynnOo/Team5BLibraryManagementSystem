﻿using System;
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
    public partial class Frm_BookListingByCategory : Form
    {
        public Frm_BookListingByCategory()
        {
            InitializeComponent();
        }

        private void Frm_BookListingByCategory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var ds = new Dataset_BookListAvailability();
            var dt = ds.ViewBooksListing;
            var adapter = new Dataset_BookListAvailabilityTableAdapters.ViewBooksListingTableAdapter();
            adapter.Fill(dt);
            Rpt_BookListingByCategory cr1 = new Rpt_BookListingByCategory();
            cr1.SetDataSource(ds);
            crv_BookListingByCategory.ReportSource = cr1;

        }
    }
}
