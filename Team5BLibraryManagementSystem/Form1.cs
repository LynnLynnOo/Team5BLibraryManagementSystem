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
    public partial class Form1 : Form
    {
        DataSet1 ds;
        DataSet1TableAdapters.BooksTableAdapter ta;
        Uc_Addbook uc1;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Uc_Addbook uc1)
        {
            InitializeComponent();
            this.uc1 = uc1;
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            var query = from x in context.Books where x.booksdetailsid == uc1.bookDetailsID select x;
            dataGridView1.DataSource = query.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.dataSet1.Books);
            ds = new DataSet1();
            ta = new DataSet1TableAdapters.BooksTableAdapter();
            ta.Fill(ds.Books);
            Uc_Addbook uc1 = new Uc_Addbook();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Do you want to delete them?", "Confirmation", MessageBoxButtons.YesNoCancel);
            //if (dr == DialogResult.Yes)
            //{
                SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Do you want to delete them?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        int selectid = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                        Book c = context.Books.Where(x => x.bookid == selectid).First();
                        if (c.status == "On Loan")
                        {
                            MessageBox.Show("The book was lent out,please select other books");
                        }
                        else
                        {
                            context.Books.Remove(c);
                            context.SaveChanges();
                            this.DialogResult = DialogResult.OK;
                        }
                    }

                    }

                }
             // this.DialogResult = DialogResult.OK;
            
        }
        private void but_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
