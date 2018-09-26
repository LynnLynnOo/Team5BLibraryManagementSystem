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
    public partial class Frm_Booksloanedbymonth : Form
    {
        public Frm_Booksloanedbymonth()
        {
            InitializeComponent();
        }

        private void Frm_Booksloanedbymonth_Load(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            //Rpt_Booklistbycategory cr1 = new Rpt_Booklistbycategory();
            Rpt_Booksloanedbymonth cr1 = new Rpt_Booksloanedbymonth();
            cr1.SetDataSource(context.Booksdetails);
            crystalReportViewer1.ReportSource = cr1;
        }
    }
}
