﻿namespace Team5BLibraryManagementSystem
{
    partial class Uc_Membersearchedit
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combobox_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_Category = new System.Windows.Forms.TextBox();
            this.Gb_Memberinformation = new System.Windows.Forms.GroupBox();
            this.btn_Renew = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_EmailAddress = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_MemberId = new System.Windows.Forms.Label();
            this.label_MemberName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textbox_Status = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.datetimepicker_Dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datetimepicker_Expirydate = new System.Windows.Forms.DateTimePicker();
            this.datetimepicker_Joineddate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox_Address = new System.Windows.Forms.TextBox();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.textbox_Idnumber = new System.Windows.Forms.TextBox();
            this.textbox_Membername = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Gb_Memberinformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // combobox_Category
            // 
            this.combobox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_Category.FormattingEnabled = true;
            this.combobox_Category.Items.AddRange(new object[] {
            "Member Name",
            "Member ID",
            "Phone",
            "Email"});
            this.combobox_Category.Location = new System.Drawing.Point(455, 88);
            this.combobox_Category.Margin = new System.Windows.Forms.Padding(4);
            this.combobox_Category.Name = "combobox_Category";
            this.combobox_Category.Size = new System.Drawing.Size(293, 24);
            this.combobox_Category.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(307, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By";
            // 
            // textbox_Category
            // 
            this.textbox_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textbox_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.textbox_Category.Location = new System.Drawing.Point(455, 118);
            this.textbox_Category.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_Category.Multiline = true;
            this.textbox_Category.Name = "textbox_Category";
            this.textbox_Category.Size = new System.Drawing.Size(293, 23);
            this.textbox_Category.TabIndex = 2;
            // 
            // Gb_Memberinformation
            // 
            this.Gb_Memberinformation.Controls.Add(this.btn_Renew);
            this.Gb_Memberinformation.Controls.Add(this.btn_History);
            this.Gb_Memberinformation.Controls.Add(this.label_Address);
            this.Gb_Memberinformation.Controls.Add(this.label_EmailAddress);
            this.Gb_Memberinformation.Controls.Add(this.label_Phone);
            this.Gb_Memberinformation.Controls.Add(this.label_MemberId);
            this.Gb_Memberinformation.Controls.Add(this.label_MemberName);
            this.Gb_Memberinformation.Controls.Add(this.label11);
            this.Gb_Memberinformation.Controls.Add(this.textbox_Status);
            this.Gb_Memberinformation.Controls.Add(this.btn_Cancel);
            this.Gb_Memberinformation.Controls.Add(this.btn_Save);
            this.Gb_Memberinformation.Controls.Add(this.btn_Delete);
            this.Gb_Memberinformation.Controls.Add(this.btn_Edit);
            this.Gb_Memberinformation.Controls.Add(this.datetimepicker_Dob);
            this.Gb_Memberinformation.Controls.Add(this.label7);
            this.Gb_Memberinformation.Controls.Add(this.textbox_Phone);
            this.Gb_Memberinformation.Controls.Add(this.label3);
            this.Gb_Memberinformation.Controls.Add(this.datetimepicker_Expirydate);
            this.Gb_Memberinformation.Controls.Add(this.datetimepicker_Joineddate);
            this.Gb_Memberinformation.Controls.Add(this.label9);
            this.Gb_Memberinformation.Controls.Add(this.label8);
            this.Gb_Memberinformation.Controls.Add(this.label5);
            this.Gb_Memberinformation.Controls.Add(this.label4);
            this.Gb_Memberinformation.Controls.Add(this.label2);
            this.Gb_Memberinformation.Controls.Add(this.label10);
            this.Gb_Memberinformation.Controls.Add(this.textbox_Address);
            this.Gb_Memberinformation.Controls.Add(this.textbox_email);
            this.Gb_Memberinformation.Controls.Add(this.textbox_Idnumber);
            this.Gb_Memberinformation.Controls.Add(this.textbox_Membername);
            this.Gb_Memberinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Memberinformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Gb_Memberinformation.Location = new System.Drawing.Point(300, 160);
            this.Gb_Memberinformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Memberinformation.Name = "Gb_Memberinformation";
            this.Gb_Memberinformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gb_Memberinformation.Size = new System.Drawing.Size(670, 297);
            this.Gb_Memberinformation.TabIndex = 72;
            this.Gb_Memberinformation.TabStop = false;
            this.Gb_Memberinformation.Text = "Member Information";
            this.Gb_Memberinformation.Visible = false;
            // 
            // btn_Renew
            // 
            this.btn_Renew.Location = new System.Drawing.Point(558, 212);
            this.btn_Renew.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Renew.Name = "btn_Renew";
            this.btn_Renew.Size = new System.Drawing.Size(100, 30);
            this.btn_Renew.TabIndex = 103;
            this.btn_Renew.Text = "Renew";
            this.btn_Renew.UseVisualStyleBackColor = true;
            this.btn_Renew.Visible = false;
            this.btn_Renew.Click += new System.EventHandler(this.btn_Renew_Click);
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(558, 74);
            this.btn_History.Margin = new System.Windows.Forms.Padding(4);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(100, 30);
            this.btn_History.TabIndex = 13;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.ForeColor = System.Drawing.Color.Crimson;
            this.label_Address.Location = new System.Drawing.Point(516, 178);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(13, 17);
            this.label_Address.TabIndex = 102;
            this.label_Address.Text = "*";
            this.label_Address.Visible = false;
            // 
            // label_EmailAddress
            // 
            this.label_EmailAddress.AutoSize = true;
            this.label_EmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EmailAddress.ForeColor = System.Drawing.Color.Crimson;
            this.label_EmailAddress.Location = new System.Drawing.Point(516, 118);
            this.label_EmailAddress.Name = "label_EmailAddress";
            this.label_EmailAddress.Size = new System.Drawing.Size(13, 17);
            this.label_EmailAddress.TabIndex = 101;
            this.label_EmailAddress.Text = "*";
            this.label_EmailAddress.Visible = false;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Phone.ForeColor = System.Drawing.Color.Crimson;
            this.label_Phone.Location = new System.Drawing.Point(516, 89);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(13, 17);
            this.label_Phone.TabIndex = 100;
            this.label_Phone.Text = "*";
            this.label_Phone.Visible = false;
            // 
            // label_MemberId
            // 
            this.label_MemberId.AutoSize = true;
            this.label_MemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MemberId.ForeColor = System.Drawing.Color.Crimson;
            this.label_MemberId.Location = new System.Drawing.Point(516, 59);
            this.label_MemberId.Name = "label_MemberId";
            this.label_MemberId.Size = new System.Drawing.Size(13, 17);
            this.label_MemberId.TabIndex = 99;
            this.label_MemberId.Text = "*";
            this.label_MemberId.Visible = false;
            // 
            // label_MemberName
            // 
            this.label_MemberName.AutoSize = true;
            this.label_MemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MemberName.ForeColor = System.Drawing.Color.Crimson;
            this.label_MemberName.Location = new System.Drawing.Point(516, 30);
            this.label_MemberName.Name = "label_MemberName";
            this.label_MemberName.Size = new System.Drawing.Size(13, 17);
            this.label_MemberName.TabIndex = 98;
            this.label_MemberName.Text = "*";
            this.label_MemberName.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(68, 266);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 97;
            this.label11.Text = "Status:";
            // 
            // textbox_Status
            // 
            this.textbox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Status.Location = new System.Drawing.Point(218, 266);
            this.textbox_Status.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_Status.Name = "textbox_Status";
            this.textbox_Status.ReadOnly = true;
            this.textbox_Status.Size = new System.Drawing.Size(293, 23);
            this.textbox_Status.TabIndex = 12;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(558, 166);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 30);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(558, 121);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 30);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(558, 166);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 30);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(558, 121);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 30);
            this.btn_Edit.TabIndex = 15;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // datetimepicker_Dob
            // 
            this.datetimepicker_Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepicker_Dob.Location = new System.Drawing.Point(218, 148);
            this.datetimepicker_Dob.Margin = new System.Windows.Forms.Padding(4);
            this.datetimepicker_Dob.Name = "datetimepicker_Dob";
            this.datetimepicker_Dob.Size = new System.Drawing.Size(293, 23);
            this.datetimepicker_Dob.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(68, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 88;
            this.label7.Text = "Date of Birth:";
            // 
            // textbox_Phone
            // 
            this.textbox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Phone.Location = new System.Drawing.Point(218, 89);
            this.textbox_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_Phone.Name = "textbox_Phone";
            this.textbox_Phone.Size = new System.Drawing.Size(293, 23);
            this.textbox_Phone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(68, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 86;
            this.label3.Text = "Phone:";
            // 
            // datetimepicker_Expirydate
            // 
            this.datetimepicker_Expirydate.Enabled = false;
            this.datetimepicker_Expirydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepicker_Expirydate.Location = new System.Drawing.Point(218, 237);
            this.datetimepicker_Expirydate.Margin = new System.Windows.Forms.Padding(4);
            this.datetimepicker_Expirydate.Name = "datetimepicker_Expirydate";
            this.datetimepicker_Expirydate.Size = new System.Drawing.Size(293, 23);
            this.datetimepicker_Expirydate.TabIndex = 11;
            // 
            // datetimepicker_Joineddate
            // 
            this.datetimepicker_Joineddate.Enabled = false;
            this.datetimepicker_Joineddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepicker_Joineddate.Location = new System.Drawing.Point(218, 207);
            this.datetimepicker_Joineddate.Margin = new System.Windows.Forms.Padding(4);
            this.datetimepicker_Joineddate.Name = "datetimepicker_Joineddate";
            this.datetimepicker_Joineddate.Size = new System.Drawing.Size(293, 23);
            this.datetimepicker_Joineddate.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(68, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 82;
            this.label9.Text = "Expiry Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(68, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 81;
            this.label8.Text = "Joined Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(68, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 79;
            this.label5.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(68, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 78;
            this.label4.Text = "Member ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(68, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(68, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 76;
            this.label10.Text = "Member Name:";
            // 
            // textbox_Address
            // 
            this.textbox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Address.Location = new System.Drawing.Point(218, 178);
            this.textbox_Address.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_Address.Name = "textbox_Address";
            this.textbox_Address.Size = new System.Drawing.Size(293, 23);
            this.textbox_Address.TabIndex = 9;
            // 
            // textbox_email
            // 
            this.textbox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_email.Location = new System.Drawing.Point(218, 118);
            this.textbox_email.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(293, 23);
            this.textbox_email.TabIndex = 7;
            // 
            // textbox_Idnumber
            // 
            this.textbox_Idnumber.BackColor = System.Drawing.Color.White;
            this.textbox_Idnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Idnumber.Location = new System.Drawing.Point(218, 59);
            this.textbox_Idnumber.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_Idnumber.Name = "textbox_Idnumber";
            this.textbox_Idnumber.ReadOnly = true;
            this.textbox_Idnumber.Size = new System.Drawing.Size(293, 23);
            this.textbox_Idnumber.TabIndex = 5;
            // 
            // textbox_Membername
            // 
            this.textbox_Membername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Membername.Location = new System.Drawing.Point(218, 30);
            this.textbox_Membername.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_Membername.Name = "textbox_Membername";
            this.textbox_Membername.Size = new System.Drawing.Size(293, 23);
            this.textbox_Membername.TabIndex = 4;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.Crimson;
            this.labelSearch.Location = new System.Drawing.Point(459, 146);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(245, 17);
            this.labelSearch.TabIndex = 73;
            this.labelSearch.Text = "*Please key in the search words.";
            this.labelSearch.Visible = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search.Location = new System.Drawing.Point(797, 100);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 30);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(457, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 29);
            this.label6.TabIndex = 73;
            this.label6.Text = "Member Maintenance ";
            // 
            // Uc_Membersearchedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.Gb_Memberinformation);
            this.Controls.Add(this.combobox_Category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_Category);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Uc_Membersearchedit";
            this.Size = new System.Drawing.Size(1092, 520);
            this.Load += new System.EventHandler(this.Uc_Membersearchedit_Load);
            this.Gb_Memberinformation.ResumeLayout(false);
            this.Gb_Memberinformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox combobox_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_Category;
        private System.Windows.Forms.GroupBox Gb_Memberinformation;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DateTimePicker datetimepicker_Dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetimepicker_Expirydate;
        private System.Windows.Forms.DateTimePicker datetimepicker_Joineddate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textbox_Address;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.TextBox textbox_Idnumber;
        private System.Windows.Forms.TextBox textbox_Membername;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textbox_Status;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_EmailAddress;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_MemberId;
        private System.Windows.Forms.Label label_MemberName;
        private System.Windows.Forms.Button btn_Renew;
        private System.Windows.Forms.Button btn_History;
    }
}
