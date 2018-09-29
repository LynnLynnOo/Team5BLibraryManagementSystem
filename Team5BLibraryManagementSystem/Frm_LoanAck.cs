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
    public partial class Frm_LoanAck : Form
    {
        public Frm_LoanAck()
        {
            InitializeComponent();
        }

        private void Frm_LoanAck_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var ds = new Dataset_LoanAck();
            var dt = ds.ViewLoanedBooks;
            var adapter = new Dataset_LoanAckTableAdapters.ViewLoanedBooksTableAdapter();
            //link with loandetails id
            adapter.FillBy(dt, 2);
            //link with loan details id
            var cr1 = new Rpt_LoanAck();
            cr1.SetDataSource(ds);
            crv_LoanAck.ReportSource = cr1;
        }
    }
}
