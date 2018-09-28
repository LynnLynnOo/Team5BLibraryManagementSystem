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
    public partial class Uc_Researchbook : UserControl
    {
        public Uc_Researchbook()
        {
            InitializeComponent();
        }

        private void Uc_Researchbook_Load(object sender, EventArgs e)
        {

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            if (text_Search.Text == "" || comboBox_Choose.SelectedItem == null)
            {
                labelSearch.Visible = true;
            }
            else
            {
                labelSearch.Visible = false;
                switch (comboBox_Choose.SelectedItem)
                {
                    case "Title":
                        data_Search.Visible = true;
                        data_Search.DataSource = context.ViewBooksListings.Where(x => x.title.ToString() == text_Search.Text).ToList();
                        break;

                    case "Author":
                        data_Search.Visible = true;
                        data_Search.DataSource = context.ViewBooksListings.Where(x => x.author.ToString() == text_Search.Text).ToList();
                        break;

                    case "Isbn":
                        data_Search.Visible = true;
                        data_Search.DataSource = context.ViewBooksListings.Where(x => x.isbn.ToString() == text_Search.Text).ToList();
                        break;

                    case "Book ID":
                        data_Search.Visible = true;
                        data_Search.DataSource = context.ViewBooksListings.Where(x => x.bookid.ToString() == text_Search.Text).ToList();
                        break;

                    case "Status":
                        data_Search.Visible = true;
                        data_Search.DataSource = context.ViewBooksListings.Where(x => x.status.ToString() == text_Search.Text).ToList();
                        break;

                    case "Publisher":
                        data_Search.Visible = true;
                        data_Search.DataSource = context.ViewBooksListings.Where(x => x.publisher.ToString() == text_Search.Text).ToList();
                        break;

                    case "Publisher Year":
                        data_Search.Visible = true;
                        data_Search.DataSource = context.ViewBooksListings.Where(x => x.publishyear.ToString() == text_Search.Text).ToList();
                        break;

                    case "Category":
                        data_Search.Visible = true;
                        data_Search.DataSource = context.ViewBooksListings.Where(x => x.category.ToString() == text_Search.Text).ToList();
                        break;
                }
            }



        }
          
    }
}
