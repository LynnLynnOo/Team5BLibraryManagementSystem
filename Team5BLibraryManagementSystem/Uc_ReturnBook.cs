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
    public partial class Uc_ReturnBook : UserControl
    {
        DataSet1 ds;
        DataSet1TableAdapters.ReturndetailsTableAdapter ta;
        DataSet1TableAdapters.BooksTableAdapter ta1;
        public Uc_ReturnBook()
        {
            InitializeComponent();
        }

        private void but_Return_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["Returndetails"].NewRow();
            int x = Convert.ToInt32(ds.Tables["Returndetails"].Rows.Count.ToString());
            int y = Convert.ToInt32(ds.Tables["Returndetails"].Rows[x - 1]["Returndetailsid"].ToString());
            r["loandetailsid"] = text_Loanid.Text;
            r["Returndetailsid"] = y+1;
            r["returndate"] = DateTime.Now.ToString("yyyy-MM-dd"); 
            int z = find1(text_Bookid.Text);
            ds.Tables["Books"].Rows[z]["status"] = "Avaliable";
            ds.Tables["Returndetails"].Rows.Add(r);
            ta.Update(ds);
            ta1.Update(ds);
            MessageBox.Show("Successfully");
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

        private void Uc_ReturnBook_Load(object sender, EventArgs e)
        {
            ds = new DataSet1();
            ta = new DataSet1TableAdapters.ReturndetailsTableAdapter();
            ta.Fill(ds.Returndetails);
            ta1 = new DataSet1TableAdapters.BooksTableAdapter();
            ta1.Fill(ds.Books);
        }
    }
}
