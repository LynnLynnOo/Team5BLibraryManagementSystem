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
            DataView dv = new DataView(ds.Tables["Books"]);
            Uc_Addbook uc1 = new Uc_Addbook();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            SelectedRow = e.RowIndex;
        }
        public int SelectedRow
        { get; set; }

        private void but_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
