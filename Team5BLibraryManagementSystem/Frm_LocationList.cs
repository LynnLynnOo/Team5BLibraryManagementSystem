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
    public partial class Frm_LocationList : Form
    {
       
        Uc_Researchbook uc2;
        public Frm_LocationList()
        {
            InitializeComponent();
        }
        public Frm_LocationList(Uc_Researchbook uc2)
        {
            InitializeComponent();
            this.uc2 = uc2;
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            var query = from x in context.Booksdetails where x.location== uc2.BookLocation select x;
            dataGridView1.DataSource = query.ToList();
        }

        private void Frm_LocationList_Load(object sender, EventArgs e)
        {
            
        }
    }
}
