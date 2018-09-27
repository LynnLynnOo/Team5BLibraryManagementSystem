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
        DataSet1TableAdapters.BooksTableAdapter ta1;
        int pasn;
        public Uc_Addbook()
        {
            InitializeComponent();
        }
        public int bookDetailsID
        {
            get { return Convert.ToInt32(text_Bookdetail.Text); }
        }


        //public int Theid
        //{ get; set; }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            pasn = find2(text_Bookdetail.Text);
            int a = Convert.ToInt32(text_Quantity.Text);
            int b = Convert.ToInt32(ds.Tables["Booksdetails"].Rows[pasn]["quantity"]);
            //Theid = Convert.ToInt32(text_Bookdetail.Text);
            if (a < b)
            { Form1 selectbook = new Form1(this);
                DialogResult dr = selectbook.ShowDialog();
                SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
                if (dr == DialogResult.OK)
                {
                   int selectid = Convert.ToInt32(selectbook.selectedBookID);
                    Console.WriteLine(selectid);
                    Book c = context.Books.Where(x => x.bookid == selectid).First();
                    context.Books.Remove(c);
                    context.SaveChanges();
                   
                }
            }
            if (a >b)
            {  while (a > b)
                {
                    DataRow r = ds.Tables["Books"].NewRow();
                    int x = Convert.ToInt32(ds.Tables["Books"].Rows.Count.ToString());
                    int y = Convert.ToInt32(ds.Tables["Books"].Rows[x - 1]["bookid"].ToString());
                    r["bookid"] = y + 1;
                    r["booksdetailsid"] = text_Bookdetail.Text;
                    r["status"] = "Avaliable";
                    ds.Tables["Books"].Rows.Add(r);
                    b++;
                    ta1.Update(ds);
                }
            }
            //ds.Tables["Booksdetails"].Rows[pasn]["booksdetailsid"] = text_Bookdetail.Text;
           ds.Tables["Booksdetails"].Rows[pasn]["title"] = textBookName.Text ;
             ds.Tables["Booksdetails"].Rows[pasn]["author"]= textAuthor.Text ;
            ds.Tables["Booksdetails"].Rows[pasn]["category"] = textGenre.Text ;
            ds.Tables["Booksdetails"].Rows[pasn]["publisher"] = textPublisher.Text ;
            ds.Tables["Booksdetails"].Rows[pasn]["publishyear"]= comboBox_year.Text.ToString();
            ds.Tables["Booksdetails"].Rows[pasn]["isbn"] = text_Isbn.Text;
             ds.Tables["Booksdetails"].Rows[pasn]["quantity"]= text_Quantity.Text;        
            ta.Update(ds);
            MessageBox.Show("Update Successfully!");
        }
        private int find2(string Search)
        {
            int i = 0;
            int T = 0;
            int x = Convert.ToInt32(ds.Tables["Booksdetails"].Rows.Count.ToString());
            while (i < x - 1)
            {

                if (ds.Tables["Booksdetails"].Rows[i]["booksdetailsid"].ToString() != Search)
                {
                    i++;
                }
                if (ds.Tables["Booksdetails"].Rows[i]["booksdetailsid"].ToString() == Search)
                {
                    T = i;
                    break;
                }
            }
            if (T == 0)
            {
                if (Search != ds.Tables["Booksdetails"].Rows[0]["booksdetailsid"].ToString())
                { MessageBox.Show("BooksdetailsID is wrong"); }
            }
            return T;
        }
     
        private void P()
        {
            text_Bookdetail.Text = ds.Tables["Booksdetails"].Rows[pasn]["booksdetailsid"].ToString();
            textBookName.Text = ds.Tables["Booksdetails"].Rows[pasn]["title"].ToString();
            textAuthor.Text = ds.Tables["Booksdetails"].Rows[pasn]["author"].ToString();
            textGenre.Text = ds.Tables["Booksdetails"].Rows[pasn]["category"].ToString();
            textPublisher.Text = ds.Tables["Booksdetails"].Rows[pasn]["publisher"].ToString();
            comboBox_year.Text = ds.Tables["Booksdetails"].Rows[pasn]["publishyear"].ToString();
            text_Isbn.Text = ds.Tables["Booksdetails"].Rows[pasn]["isbn"].ToString();
            text_Quantity.Text = ds.Tables["Booksdetails"].Rows[pasn]["quantity"].ToString();
        }

        private void Uc_Addbook_Load(object sender, EventArgs e)
        {
            ds = new DataSet1();
            ta = new DataSet1TableAdapters.BooksdetailsTableAdapter();
            ta1 = new DataSet1TableAdapters.BooksTableAdapter();
            ta.Fill(ds.Booksdetails);
            ta1.Fill(ds.Books);
        }

        private void textBookID_TextChanged(object sender, EventArgs e)
        {
                    }

        private void butInsert_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(text_Quantity.Text);
            DataRow r = ds.Tables["Booksdetails"].NewRow();
            //r["booksdetailsid"] = text_Bookdetail.Text;
            r["title"] = textBookName.Text;
            r["author"] = textAuthor.Text;
            r["category"] = textGenre.Text;
            r["publisher"] = textPublisher.Text;
            r["publishyear"] = comboBox_year.Text;
            r["isbn"] = text_Isbn.Text;
            r["quantity"] = a;
            ds.Tables["Booksdetails"].Rows.Add(r);
            ta.Update(ds);
                while (a > 0)
                {
                    DataRow b = ds.Tables["Books"].NewRow();
                    int x = Convert.ToInt32(ds.Tables["Books"].Rows.Count.ToString());
                    int y = Convert.ToInt32(ds.Tables["Books"].Rows[x - 1]["bookid"].ToString());
                int z = Convert.ToInt32(ds.Tables["Booksdetails"].Rows.Count.ToString());
                b["bookid"] = y + 1;
                    b["booksdetailsid"] = ds.Tables["Booksdetails"].Rows[z-1]["booksdetailsid"]; ;
                    b["status"] = "Avaliable";
                ds.Tables["Books"].Rows.Add(b);
                a--;
                    ta1.Update(ds);
                MessageBox.Show("Insert Successfully!");
                }
            
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            int u= Convert.ToInt32(text_Bookdetail.Text);
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            Booksdetail a = context.Booksdetails.Where(d => d.booksdetailsid == u).First();
            Book c = context.Books.Where(x => x.booksdetailsid ==u ).First();
            context.Booksdetails.Remove(a);
            context.Books.Remove(c);
            context.SaveChanges();
            MessageBox.Show("Delete Sucessfully!");
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
                pasn--;
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
            if (pasn < x-1)
            {
                pasn++;
                P();
            }
            if (pasn ==x-1)
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
