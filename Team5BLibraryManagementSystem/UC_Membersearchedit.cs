using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Team5BLibraryManagementSystem
{
    public partial class Uc_Membersearchedit : UserControl
    {
        Checkemailvalidity chkvldy = new Checkemailvalidity();
        public Uc_Membersearchedit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_Print_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            var q = context.Members.Where(x => x.memberid.ToString() == Textbox_Idnumber.Text).First();

            DialogResult dialogResult = MessageBox.Show(String.Format("Are you sure you want to remove the user,{0}?", q.name), "Warning", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                context.Members.Remove(q);
                context.SaveChanges();
                MessageBox.Show(String.Format("{0} has been removed.", q.name), "Confirmation", MessageBoxButtons.OK);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();

            if (Textbox_Category.Text == "" || Combobox_Category.SelectedItem == null)
            {
                labelSearch.Visible = true;
            }

            else
            {
                try
                {
                    labelSearch.Visible = false;
                    switch (Combobox_Category.SelectedItem)
                    {
                        case "Member ID":
                            if (chkvldy.IsValidID(Textbox_Category.Text))
                            {
                                Gb_Memberinformation.Visible = true;

                                var q = (from x in context.Members
                                         where x.memberid.ToString() == Textbox_Category.Text
                                         select x).First();

                                Textbox_Membername.Text = q.name.ToString();
                                Textbox_Idnumber.Text = q.memberid.ToString();
                                Textbox_Phone.Text = q.phonenumber.ToString();
                                Textbox_email.Text = q.email.ToString();
                                Datetimepicker_Dob.Text = q.dateofbirth.ToString();
                                Textbox_Address.Text = q.address.ToString();
                                Datetimepicker_Joineddate.Text = q.joindate.ToString();
                                Datetimepicker_Expirydate.Text = q.expirydate.ToString();
                            }
                            break;

                        case "Member Name":
                            if (chkvldy.IsValidName(Textbox_Category.Text))
                            {

                                Gb_Memberinformation.Visible = true;

                                var r = (from x in context.Members
                                         where x.name == Textbox_Category.Text
                                         select x).First();

                                Textbox_Membername.Text = r.name.ToString();
                                Textbox_Idnumber.Text = r.memberid.ToString();
                                Textbox_Phone.Text = r.phonenumber.ToString();
                                Textbox_email.Text = r.email.ToString();
                                Datetimepicker_Dob.Text = r.dateofbirth.ToString();
                                Textbox_Address.Text = r.address.ToString();
                                Datetimepicker_Joineddate.Text = r.joindate.ToString();
                                Datetimepicker_Expirydate.Text = r.expirydate.ToString();
                            }
                            break;

                        case "Phone":

                            if (chkvldy.IsValidPhone(Textbox_Category.Text))
                            {
                                Gb_Memberinformation.Visible = true;

                                var s = (from x in context.Members
                                         where x.phonenumber.ToString() == Textbox_Category.Text
                                         select x).First();

                                Textbox_Membername.Text = s.name.ToString();
                                Textbox_Idnumber.Text = s.memberid.ToString();
                                Textbox_Phone.Text = s.phonenumber.ToString();
                                Textbox_email.Text = s.email.ToString();
                                Datetimepicker_Dob.Text = s.dateofbirth.ToString();
                                Textbox_Address.Text = s.address.ToString();
                                Datetimepicker_Joineddate.Text = s.joindate.ToString();
                                Datetimepicker_Expirydate.Text = s.expirydate.ToString();
                            }
                            break;

                        case "Email":

                            if (chkvldy.IsValidEmail(Textbox_Category.Text))
                            {
                                var t = (from x in context.Members
                                         where x.email.ToString() == Textbox_Category.Text
                                         select x).First();

                                Gb_Memberinformation.Visible = true;
                                Textbox_Membername.Text = t.name.ToString();
                                Textbox_Idnumber.Text = t.memberid.ToString();
                                Textbox_Phone.Text = t.phonenumber.ToString();
                                Textbox_email.Text = t.email.ToString();
                                Datetimepicker_Dob.Text = t.dateofbirth.ToString();
                                Textbox_Address.Text = t.address.ToString();
                                Datetimepicker_Joineddate.Text = t.joindate.ToString();
                                Datetimepicker_Expirydate.Text = t.expirydate.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Email");
                            }
                            break;
                    }
                }
                catch
                {
                    Gb_Memberinformation.Visible = false;
                    MessageBox.Show("Member does not exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Uc_Membersearchedit_Load(object sender, EventArgs e)
        {
            btn_Edit.Visible = true;
            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
            btn_Delete.Visible = true;
            Textbox_Address.Enabled = false;
            Textbox_Membername.Enabled = false;
            Textbox_Phone.Enabled = false;
            Textbox_email.Enabled = false;
            Datetimepicker_Dob.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            btn_Edit.Visible = false;
            btn_Save.Visible = true;
            btn_Cancel.Visible = true;
            btn_Delete.Visible = false;
            Textbox_Address.Enabled = true;
            Textbox_Membername.Enabled = true;
            Textbox_Phone.Enabled = true;
            Textbox_email.Enabled = true;
            Datetimepicker_Dob.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Textbox_Membername.Text == "" || Textbox_Phone.Text == "" || Textbox_email.Text == "" || Textbox_Address.Text == "")
                {
                    MessageBox.Show("Please fill up all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
                    Member q = context.Members.Where(x => x.memberid.ToString() == Textbox_Idnumber.Text).First();

                    if (chkvldy.IsValidName(Textbox_Membername.Text) && chkvldy.IsValidPhone(Textbox_Phone.Text))
                    {
                        q.name = Textbox_Membername.Text;
                        q.phonenumber = Textbox_Phone.Text;
                        if (chkvldy.IsValidEmail(Textbox_email.Text))
                        {
                            q.email = Textbox_email.Text;
                            q.dateofbirth = Convert.ToDateTime(Datetimepicker_Dob.Text);
                            q.address = Textbox_Address.Text;
                            context.SaveChanges();
                            DefaultVisibility();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email Address!", "Warning", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please confirm all the information!", "Warning", MessageBoxButtons.OK);
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DefaultVisibility();
        }

        private void DefaultVisibility()
        {
            btn_Edit.Visible = true;
            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
            btn_Delete.Visible = true;
            Textbox_Address.Enabled = false;
            Textbox_Membername.Enabled = false;
            Textbox_Phone.Enabled = false;
            Textbox_email.Enabled = false;
            Datetimepicker_Dob.Enabled = false;
        }



    }



}
