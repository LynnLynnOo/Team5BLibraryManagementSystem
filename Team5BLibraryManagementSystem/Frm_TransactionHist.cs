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
    public partial class Frm_TransactionHist : Form
    {
        Uc_Membersearchedit mbse;
        public Frm_TransactionHist()
        {
            InitializeComponent();
        }
        public Frm_TransactionHist(Uc_Membersearchedit mbse)
        {
            InitializeComponent();
            this.mbse = mbse;

        }

        private void Frm_TransactionHist_Load(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            var u = from x in context.Loandetails
                    where x.memberid.ToString() == mbse.memberId
                    select new
                    {
                        Member_ID = x.memberid,
                        Member_Name = x.Member.name,
                        Transaction_ID = x.loandetailsid,
                        Title = x.Book.Booksdetail.title,
                        Loaned_Date = x.startdate,
                        Returned_Date = x.enddate                       
                    };

            dataGridView_Transactions.DataSource = u.ToList();
        }
    }
}
