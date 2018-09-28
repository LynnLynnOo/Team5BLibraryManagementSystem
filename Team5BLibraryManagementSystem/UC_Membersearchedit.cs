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
        ZtkValidityCheck chkvldy = new ZtkValidityCheck();   
        public Uc_Membersearchedit()
        {
            InitializeComponent();
            labelSearch.Visible = false; ;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            var q = context.Members.Where(x => x.memberid.ToString() == textbox_Idnumber.Text).First();

            DialogResult dialogResult = MessageBox.Show(String.Format("Are you sure you want to remove the user,{0}?", q.name), "Warning", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                context.Members.Remove(q);
                context.SaveChanges();
                MessageBox.Show(String.Format("{0} has been removed.", q.name), "Confirmation", MessageBoxButtons.OK);
                Clearfields();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();

            if (textbox_Category.Text == "" || combobox_Category.SelectedItem == null)
            {
                labelSearch.Visible = true;
            }

            else
            {
                try
                {
                    labelSearch.Visible = false;
                    switch (combobox_Category.SelectedItem)
                    {
                        case "Member ID":
                            if (ZtkValidityCheck.IsValidID(textbox_Category.Text))
                            {
                                Gb_Memberinformation.Visible = true;
                                
                                var q = (from x in context.Members
                                         where x.memberid.ToString() == textbox_Category.Text
                                         select x).First();
                                
                                textbox_Membername.Text = q.name.ToString();
                                textbox_Idnumber.Text = q.memberid.ToString();
                                textbox_Phone.Text = q.phonenumber.ToString();
                                textbox_email.Text = q.email.ToString();
                                datetimepicker_Dob.Text = q.dateofbirth.ToString();
                                textbox_Address.Text = q.address.ToString();
                                datetimepicker_Joineddate.Text = q.joindate.ToString();
                                datetimepicker_Expirydate.Text = q.expirydate.ToString();                             

                                if(ZtkValidityCheck.MemberIsValid(q.expirydate))
                                {
                                    textbox_Status.Text = "Active";
                                }
                                else
                                {
                                    textbox_Status.Text="Expired";
                                }

                            }
                            break;

                        case "Member Name":
                            if (ZtkValidityCheck.IsValidName(textbox_Category.Text))
                            {

                                Gb_Memberinformation.Visible = true;

                                var r = (from x in context.Members
                                         where x.name == textbox_Category.Text
                                         select x).First();

                                textbox_Membername.Text = r.name.ToString();
                                textbox_Idnumber.Text = r.memberid.ToString();
                                textbox_Phone.Text = r.phonenumber.ToString();
                                textbox_email.Text = r.email.ToString();
                                datetimepicker_Dob.Text = r.dateofbirth.ToString();
                                textbox_Address.Text = r.address.ToString();
                                datetimepicker_Joineddate.Text = r.joindate.ToString();
                                datetimepicker_Expirydate.Text = r.expirydate.ToString();

                                if (ZtkValidityCheck.MemberIsValid(r.expirydate))
                                {
                                    textbox_Status.Text = "Active";
                                }
                                else
                                {
                                    textbox_Status.Text = "Expired";
                                }
                            }
                            break;

                        case "Phone":

                            if (ZtkValidityCheck.IsValidPhone(textbox_Category.Text))
                            {
                                Gb_Memberinformation.Visible = true;

                                var s = (from x in context.Members
                                         where x.phonenumber.ToString() == textbox_Category.Text
                                         select x).First();

                                textbox_Membername.Text = s.name.ToString();
                                textbox_Idnumber.Text = s.memberid.ToString();
                                textbox_Phone.Text = s.phonenumber.ToString();
                                textbox_email.Text = s.email.ToString();
                                datetimepicker_Dob.Text = s.dateofbirth.ToString();
                                textbox_Address.Text = s.address.ToString();
                                datetimepicker_Joineddate.Text = s.joindate.ToString();
                                datetimepicker_Expirydate.Text = s.expirydate.ToString();

                                if (ZtkValidityCheck.MemberIsValid(s.expirydate))
                                {
                                    textbox_Status.Text = "Active";
                                }
                                else
                                {
                                    textbox_Status.Text = "Expired";
                                }
                            }
                            break;

                        case "Email":

                            if (chkvldy.IsValidEmail(textbox_Category.Text))
                            {
                                var t = (from x in context.Members
                                         where x.email.ToString() == textbox_Category.Text
                                         select x).First();

                                Gb_Memberinformation.Visible = true;
                                textbox_Membername.Text = t.name.ToString();
                                textbox_Idnumber.Text = t.memberid.ToString();
                                textbox_Phone.Text = t.phonenumber.ToString();
                                textbox_email.Text = t.email.ToString();
                                datetimepicker_Dob.Text = t.dateofbirth.ToString();
                                textbox_Address.Text = t.address.ToString();
                                datetimepicker_Joineddate.Text = t.joindate.ToString();
                                datetimepicker_Expirydate.Text = t.expirydate.ToString();

                                if (ZtkValidityCheck.MemberIsValid(t.expirydate))
                                {
                                    textbox_Status.Text = "Active";
                                }
                                else
                                {
                                    textbox_Status.Text = "Expired";
                                }
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
            textbox_Address.Enabled = false;
            textbox_Membername.Enabled = false;
            textbox_Phone.Enabled = false;
            textbox_email.Enabled = false;
            datetimepicker_Dob.Enabled = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            btn_Edit.Visible = false;
            btn_Save.Visible = true;
            btn_Cancel.Visible = true;
            btn_Delete.Visible = false;
            textbox_Address.Enabled = true;
            textbox_Membername.Enabled = true;
            textbox_Phone.Enabled = true;
            textbox_email.Enabled = true;
            datetimepicker_Dob.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbox_Membername.Text == "" || textbox_Phone.Text == "" || textbox_email.Text == "" || textbox_Address.Text == "")
                {
                    MessageBox.Show("Please fill up all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
                    Member q = context.Members.Where(x => x.memberid.ToString() == textbox_Idnumber.Text).First();

                    if (ZtkValidityCheck.IsValidName(textbox_Membername.Text) && ZtkValidityCheck.IsValidPhone(textbox_Phone.Text))
                    {
                        q.name = textbox_Membername.Text;
                        q.phonenumber = textbox_Phone.Text;
                        if (chkvldy.IsValidEmail(textbox_email.Text))
                        {
                            q.email = textbox_email.Text;
                            q.dateofbirth = Convert.ToDateTime(datetimepicker_Dob.Text);
                            q.address = textbox_Address.Text;
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
            textbox_Address.Enabled = false;
            textbox_Membername.Enabled = false;
            textbox_Phone.Enabled = false;
            textbox_email.Enabled = false;
            datetimepicker_Dob.Enabled = false;
        }

        //To clear all the fields
        private void Clearfields()
        {
            textbox_Address.Clear();
            textbox_Idnumber.Clear();
            textbox_Membername.Clear();
            textbox_Phone.Clear();
            textbox_email.Clear();
            datetimepicker_Dob.ResetText();
            datetimepicker_Expirydate.ResetText();
            datetimepicker_Joineddate.ResetText();
        }
    }
}
