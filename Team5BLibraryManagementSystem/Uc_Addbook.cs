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
    public partial class Uc_Addbook : UserControl
    {
        DataSet1 ds;
        DataSet1TableAdapters.BooksdetailsTableAdapter ta;
        int pasn;
        public Uc_Addbook()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            pasn = find2(text_Bookdetail.Text);
            int a = Convert.ToInt32(text_Quantity.Text);
            int b = Convert.ToInt32(ds.Tables["Booksdetails"].Rows[pasn]["quantity"]);
            if (a < b)
            { Form selectbook = new Form1(); }
            if (a >b)
            {  while (a > b)
                {
                    DataRow r = ds.Tables["Books"].NewRow();
                    int x = Convert.ToInt32(ds.Tables["Books"].Rows.Count.ToString());
                    int y = Convert.ToInt32(ds.Tables["Books"].Rows[x - 1]["bookid"].ToString());
                    r["bookid"] = y + 1;
                    r["booksdetialsid"] = text_Bookdetail.Text;
                    r["status"] = "Avaliable";
                    b++;
                }
            }
            ds.Tables["Booksdetails"].Rows[pasn]["booksdetialsid"] = text_Bookdetail.Text;
           ds.Tables["Booksdetails"].Rows[pasn]["title"] = textBookName.Text ;
             ds.Tables["Booksdetails"].Rows[pasn]["author"]= textAuthor.Text ;
            ds.Tables["Booksdetails"].Rows[pasn]["category"] = textGenre.Text ;
            ds.Tables["Booksdetails"].Rows[pasn]["publisher"] = textPublisher.Text ;
            ds.Tables["Booksdetails"].Rows[pasn]["publishyear"]= comboBox_year.ValueMember;
            ds.Tables["Booksdetails"].Rows[pasn]["isbn"] = text_Isbn.Text;
             ds.Tables["Booksdetails"].Rows[pasn]["quantity"]= text_Quantity.Text;
          
            ta.Update(ds);
        }
        private int find2(string Search)
        {
            int i = 0;
            int T = 0;
            int x = Convert.ToInt32(ds.Tables["Booksdetails"].Rows.Count.ToString());
            while (i < x - 1)
            {

                if (ds.Tables["Booksdetails"].Rows[i]["booksdetialsid"].ToString() != Search)
                {
                    i++;
                }
                if (ds.Tables["Booksdetails"].Rows[i]["booksdetialsid"].ToString() == Search)
                {
                    T = i;
                    break;
                }
            }
            if (T == 0)
            {
                if (Search != ds.Tables["Booksdetails"].Rows[i]["booksdetialsid"].ToString())
                { MessageBox.Show("BooksdetailsID is wrong"); }
            }
            return T;
        }
     
        private void P()
        {
            text_Bookdetail.Text = ds.Tables["Booksdetails"].Rows[pasn]["booksdetialsid"].ToString();
            textBookName.Text = ds.Tables["Booksdetails"].Rows[pasn]["title"].ToString();
            textAuthor.Text = ds.Tables["Booksdetails"].Rows[pasn]["author"].ToString();
            textGenre.Text = ds.Tables["Booksdetails"].Rows[pasn]["category"].ToString();
            textPublisher.Text = ds.Tables["Booksdetails"].Rows[pasn]["publisher"].ToString();
            comboBox_year.ValueMember = ds.Tables["Booksdetails"].Rows[pasn]["publishyear"].ToString();
            text_Isbn.Text = ds.Tables["Booksdetails"].Rows[pasn]["isbn"].ToString();
            text_Quantity.Text = ds.Tables["Booksdetails"].Rows[pasn]["quantity"].ToString();
        }

        private void Uc_Addbook_Load(object sender, EventArgs e)
        {
            ds = new DataSet1();
            ta = new DataSet1TableAdapters.BooksdetailsTableAdapter();
            ta.Fill(ds.Booksdetails);
        }

        private void textBookID_TextChanged(object sender, EventArgs e)
        {
                    }

        private void butInsert_Click(object sender, EventArgs e)
        {
            pasn = find2(text_Bookdetail.Text);
            DataRow r = ds.Tables["Booksdetails"].NewRow();
            r["booksdetialsid"] = text_Bookdetail.Text;
            r["title"] = textBookName.Text;
            r["author"] = textAuthor.Text;
            r["category"] = textGenre.Text;
            r["publisher"] = textPublisher.Text;
            r["publishyear"] = comboBox_year.ValueMember;
            r["isbn"] = text_Isbn.Text;
            r["quantity"] = text_Quantity;
            ds.Tables["Booksdetails"].Rows.Add(r);
            ta.Update(ds);
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            pasn = find2(text_Bookdetail.Text);
            ds.Tables["Booksdetails"].Rows[pasn].Delete();
            ta.Update(ds);
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            pasn = find2(text_find.Text);
            P();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pasn = find2(text_Bookdetail.Text);
            if (pasn > 0)
            {
                pasn++;
                P();
            }
            else {
                MessageBox.Show("It is the first one");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pasn = find2(text_Bookdetail.Text);
            int x = Convert.ToInt32(ds.Tables["Booksdetails"].Rows.Count.ToString());
            if (pasn < x)
            {
                pasn++;
                P();
            }
            else
            {
                MessageBox.Show("It is the last one");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pasn = 0;
            P();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(ds.Tables["Booksdetails"].Rows.Count.ToString());
            pasn = x - 1;
            P();
        }
    }
}
