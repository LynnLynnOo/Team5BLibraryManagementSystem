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
        DataSet1TableAdapters.LoandetailsTableAdapter ta;
        DataSet1TableAdapters.BooksTableAdapter ta1;
        public Uc_LendBook()
        {
            InitializeComponent();
            date_Due.Value = DateTime.Now.AddDays(14);
        }

        private void butLend_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["Loandetails"].NewRow();
            int x = Convert.ToInt32(ds.Tables["Loandetails"].Rows.Count.ToString());
            int y = Convert.ToInt32(ds.Tables["Loandetails"].Rows[x - 1]["loandetailsid"].ToString());
            int z;
          if (date_Issue.Value.Date <= date_Due.Value.Date)
            {
                r["loandetailsid"] = y + 1;
                r["memberid"] = textbox_MemberID.Text;
                r["bookid"] = textbox_BookID.Text;
                r["startdate"] = date_Issue.Value.Date;
                r["enddate"] = date_Due.Value.Date;
                z = find1(textbox_BookID.Text);
                ds.Tables["Books"].Rows[z]["status"] = "On Loan";
                ds.Tables["Loandetails"].Rows.Add(r);
                ta.Update(ds);
                ta1.Update(ds);
                MessageBox.Show("Successfully");
            }   
            if (date_Issue.Value.Date > date_Due.Value.Date)
            { MessageBox.Show("Data Wrong"); }
        }
        private int find1(string Search)
        {
            int i = 0;
            int T = 0;
            int x = Convert.ToInt32(ds.Tables["Books"].Rows.Count.ToString());
            while (i < x - 1)
            {

                if (ds.Tables["Books"].Rows[i]["bookid"].ToString() != Search)
                {
                    i++;
                }
                if (ds.Tables["Books"].Rows[i]["bookid"].ToString() == Search)
                {
                    T = i;
                    break;
                }
            }
            if (T == 0)
            {
                if (Search != ds.Tables["Books"].Rows[0]["bookid"].ToString())
                { MessageBox.Show("BookID is wrong"); }
            }
            return T;
        }

        private void Uc_LendBook_Load(object sender, EventArgs e)
        {
            ds = new DataSet1();
            ta = new DataSet1TableAdapters.LoandetailsTableAdapter();
            ta.Fill(ds.Loandetails);
            ta1 = new DataSet1TableAdapters.BooksTableAdapter();
            ta1.Fill(ds.Books);
        }
    }
}
