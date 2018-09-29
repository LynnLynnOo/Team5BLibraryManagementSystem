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
        ZtkValidityCheck chkvldy = new ZtkValidityCheck();    // Class which contains methods for all the validity checkings
        public Uc_Membersearchedit()
        {
            InitializeComponent();
            labelSearch.Visible = false;
        }

        public string memberId
        {
            get { return textbox_Idnumber.Text; }       
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {

        }


        //Remove member
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            var q = context.Members.Where(x => x.memberid.ToString() == textbox_Idnumber.Text).First();
            if(ZtkValidityCheck.MemberIsValid(q.expirydate))
            {
                MessageBox.Show("Deletion of active member is not allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show(String.Format("Are you sure you want to remove the user,{0}?", q.name), "Warning", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    context.Members.Remove(q);
                    context.SaveChanges();
                    MessageBox.Show(String.Format("{0} has been removed.", q.name), "Confirmation", MessageBoxButtons.OK);
                    Clearfields();
                }
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
                                    btn_Renew.Visible = true;
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
                                    btn_Renew.Visible = true;
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
                                    btn_Renew.Visible = true;
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
                                    btn_Renew.Visible = true;
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
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            var u = (from x in context.Members
                     where x.memberid.ToString() == textbox_Idnumber.Text
                     select x).First();

            if (ZtkValidityCheck.MemberIsValid(u.expirydate))
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
            else
            {
                DialogResult dialogresult = MessageBox.Show("Membership has been expired!\nEditing is not allowed!\nWould you like to renew the membership?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogresult == DialogResult.Yes)
                {
                    RenewMembership();
                }
            }

            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
              
                if(textbox_Membername.Text == "" || textbox_Phone.Text == "" || textbox_email.Text == "" || textbox_Address.Text == "")
                {
                    if (textbox_Membername.Text == "")
                    {
                        label_MemberName.Visible = true;
                        MessageBox.Show("Member name field cannot be left empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        label_MemberName.Visible = false;
                    }


                    if (textbox_Phone.Text == "")
                    {
                        label_Phone.Visible = true;
                        MessageBox.Show("Phone number field cannot be left empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        label_Phone.Visible = false;
                    }

                    if (textbox_email.Text == "")
                    {
                        label_EmailAddress.Visible = true;
                        MessageBox.Show("Email address field cannot be left empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        label_EmailAddress.Visible = false;
                    }

                    if (textbox_Address.Text == "")
                    {
                        label_Address.Visible = true;
                        MessageBox.Show("Address field cannot be left empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        label_Address.Visible = false;
                    }
                }
                

                else
                {
                    WarningLabels(false);

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

        //Set warning labels' Visibilities

        private void WarningLabels(bool visibility)
        {
            label_EmailAddress.Visible = visibility;
            label_Address.Visible = visibility;
            label_MemberId.Visible = visibility;
            label_MemberName.Visible = visibility;
            label_Phone.Visible = visibility;
        }

        //Set Control's Visibility
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
            textbox_Status.Clear();
        }

        //Renew Membership Trigger
        private void btn_Renew_Click(object sender, EventArgs e)
        {
            RenewMembership();
        }

        //Renew Membership
        private void RenewMembership()
        {
            SA47Team05BESNETLMSEntities context = new SA47Team05BESNETLMSEntities();
            var u = (from x in context.Members
                     where x.memberid.ToString() == textbox_Idnumber.Text
                     select x).First();

            if (ZtkValidityCheck.MemberIsValid(u.expirydate))
            {
                MessageBox.Show("Membership is valid untill" + u.expirydate.Date + "!\nNo Need to renew!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                u.joindate = DateTime.Now;
                u.expirydate = DateTime.Now.AddYears(1);
                context.SaveChanges();
                MessageBox.Show("Membership has been updated for " + u.name + "\nNew Expiry Date: " + u.expirydate + "\nThank you!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            datetimepicker_Joineddate.Text = u.joindate.ToString();
            datetimepicker_Expirydate.Text = u.expirydate.ToString();

        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            Frm_TransactionHist transtForm = new Frm_TransactionHist(this);
            transtForm.ShowDialog();
        }
    }
}
