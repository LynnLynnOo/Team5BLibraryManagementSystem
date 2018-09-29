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
            //if (text_Search.Text == "" && comboBox_Choose.SelectedItem == null)
            //{
            //    labelSearch.Visible = true;
            //}
            //else
            //{
               // labelSearch.Visible = false;
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

                    case "Location":
                      
                        break;
                }
          //  }
        }
        private void Cannot()
        {
            pictureBox_A1.Visible =false;
            pictureBox_A2.Visible =false;
            pictureBox_B1.Visible =false;
            pictureBox_B2.Visible = false;
            A1.Visible = false;
            B1.Visible = false;
            A2.Visible = false;
            B2.Visible =false;
        }
        private void Can()
        {
            butSearch.Visible = true;
            labelSearch.Visible = true;
            text_Search.Visible = true;
        }


        private void pictureBox_A1_Click(object sender, EventArgs e)
        {
            pictureBox_A1.BackColor = Color.SandyBrown;
            pictureBox_A2.BackColor = Color.PeachPuff;
            pictureBox_B1.BackColor = Color.PeachPuff;
            pictureBox_B2.BackColor = Color.PeachPuff;
        }

        private void pictureBox_B1_Click(object sender, EventArgs e)
        {
            pictureBox_B1.BackColor = Color.SandyBrown;
            pictureBox_A2.BackColor = Color.PeachPuff;
            pictureBox_A1.BackColor = Color.PeachPuff;
            pictureBox_B2.BackColor = Color.PeachPuff;
        }

        private void pictureBox_A2_Click(object sender, EventArgs e)
        {
            pictureBox_A2.BackColor = Color.SandyBrown;
            pictureBox_B1.BackColor = Color.PeachPuff;
            pictureBox_A1.BackColor = Color.PeachPuff;
            pictureBox_B2.BackColor = Color.PeachPuff;
        }

        private void pictureBox_B2_Click(object sender, EventArgs e)
        {
            pictureBox_B2.BackColor = Color.SandyBrown;
            pictureBox_A2.BackColor = Color.PeachPuff;
            pictureBox_A1.BackColor = Color.PeachPuff;
            pictureBox_B1.BackColor = Color.PeachPuff;
        }
        string booklocation;
        private void pictureBox_A1_DoubleClick(object sender, EventArgs e)
        {
            
            booklocation = "A1";
            ShowFORM();
        }
        public string  BookLocation
        {
            get { return booklocation; }
        }

        private void pictureBox_B1_DoubleClick(object sender, EventArgs e)
        {
            
            booklocation = "B1";
            ShowFORM();
        }

        private void pictureBox_A2_DoubleClick(object sender, EventArgs e)
        {
           
             booklocation = "A2";
            ShowFORM();
        }

        private void pictureBox_B2_DoubleClick(object sender, EventArgs e)
        {
            
            booklocation = "B2";
            ShowFORM();
        }
        private void ShowFORM()
        {
            Frm_LocationList Location = new Frm_LocationList(this);
            DialogResult dr = Location.ShowDialog();
        }

        private void comboBox_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_Choose.SelectedItem)
            {
                case "Title":
                    Cannot();
                    Can();
                    break;
                case "Author":
                    Cannot();
                    Can();
                    break;
                case "Isbn":
                    Cannot();
                    Can();
                    break;
                case "Book ID":
                    Cannot();
                    Can();
                    break;
                case "Status":
                    Cannot();
                    Can();
                    break;
                case "Publisher":
                    Cannot();
                    Can();
                    break;
                case "Publisher Year":
                    Cannot();
                    Can();
                    break;
                case "Category":
                    Cannot();
                    Can();
                    break;
                case "Location":
                    data_Search.Visible = false;
                    labelSearch.Visible = false;
                    text_Search.Visible = false;
                    pictureBox_A1.Visible = true;
                    pictureBox_A2.Visible = true;
                    pictureBox_B1.Visible = true;
                    pictureBox_B2.Visible = true;
                    A1.Visible = true;
                    B1.Visible = true;
                    A2.Visible = true;
                    B2.Visible = true;
                    butSearch.Visible = false;
                    break;

            }
            }
    }
}
