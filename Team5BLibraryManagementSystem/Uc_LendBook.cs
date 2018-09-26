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
    public partial class Uc_LendBook : UserControl
    {
        DataSet1 ds;
        DataSet1TableAdapters.TransactionsTableAdapter ta;
        public Uc_LendBook()
        {
            InitializeComponent();
        }

        private void butLend_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["Transactions"].NewRow();
            int x = Convert.ToInt32(ds.Tables["Transactions"].Rows.Count.ToString());
            int y = Convert.ToInt32(ds.Tables["Transactions"].Rows[x - 1]["transactionid"].ToString());
            r["transactionid"] = y + 1;
            r["memberid"] = textbox_MemberID.Text;
            r["bookid"] = textbox_BookID.Text;
            r["status"] = "On Loan";
            r["startdate"] = date_Issue.Value.Date;
            r["enddate"] = date_Due.Value.Date;
            r["extensioncount"] = 0;
            ds.Tables["Transactions"].Rows.Add(r);
            ta.Update(ds);
        }

        private void Uc_LendBook_Load(object sender, EventArgs e)
        {
            ds = new DataSet1();
            ta = new DataSet1TableAdapters.TransactionsTableAdapter();
            ta.Fill(ds.Transactions);
        }
    }
}
