namespace Team5BLibraryManagementSystem
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
            this.Combobox_Category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox_Category = new System.Windows.Forms.TextBox();
            this.Gb_Memberinformation = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.Datetimepicker_Dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Textbox_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Datetimepicker_Expirydate = new System.Windows.Forms.DateTimePicker();
            this.Datetimepicker_Joineddate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Textbox_Address = new System.Windows.Forms.TextBox();
            this.Textbox_email = new System.Windows.Forms.TextBox();
            this.Textbox_Idnumber = new System.Windows.Forms.TextBox();
            this.Textbox_Membername = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.Gb_Memberinformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Combobox_Category
            // 
            this.Combobox_Category.FormattingEnabled = true;
            this.Combobox_Category.Items.AddRange(new object[] {
            "Member Name",
            "Member ID",
            "Phone",
            "Email"});
            this.Combobox_Category.Location = new System.Drawing.Point(321, 37);
            this.Combobox_Category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combobox_Category.Name = "Combobox_Category";
            this.Combobox_Category.Size = new System.Drawing.Size(236, 28);
            this.Combobox_Category.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(208, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search By";
            // 
            // Textbox_Category
            // 
            this.Textbox_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Textbox_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.Textbox_Category.Location = new System.Drawing.Point(321, 75);
            this.Textbox_Category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Category.Multiline = true;
            this.Textbox_Category.Name = "Textbox_Category";
            this.Textbox_Category.Size = new System.Drawing.Size(236, 28);
            this.Textbox_Category.TabIndex = 2;
            this.Textbox_Category.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Gb_Memberinformation
            // 
            this.Gb_Memberinformation.Controls.Add(this.btn_Cancel);
            this.Gb_Memberinformation.Controls.Add(this.btn_Save);
            this.Gb_Memberinformation.Controls.Add(this.btn_Delete);
            this.Gb_Memberinformation.Controls.Add(this.btn_Edit);
            this.Gb_Memberinformation.Controls.Add(this.btn_Print);
            this.Gb_Memberinformation.Controls.Add(this.Datetimepicker_Dob);
            this.Gb_Memberinformation.Controls.Add(this.label7);
            this.Gb_Memberinformation.Controls.Add(this.Textbox_Phone);
            this.Gb_Memberinformation.Controls.Add(this.label3);
            this.Gb_Memberinformation.Controls.Add(this.Datetimepicker_Expirydate);
            this.Gb_Memberinformation.Controls.Add(this.Datetimepicker_Joineddate);
            this.Gb_Memberinformation.Controls.Add(this.label9);
            this.Gb_Memberinformation.Controls.Add(this.label8);
            this.Gb_Memberinformation.Controls.Add(this.label5);
            this.Gb_Memberinformation.Controls.Add(this.label4);
            this.Gb_Memberinformation.Controls.Add(this.label2);
            this.Gb_Memberinformation.Controls.Add(this.label10);
            this.Gb_Memberinformation.Controls.Add(this.Textbox_Address);
            this.Gb_Memberinformation.Controls.Add(this.Textbox_email);
            this.Gb_Memberinformation.Controls.Add(this.Textbox_Idnumber);
            this.Gb_Memberinformation.Controls.Add(this.Textbox_Membername);
            this.Gb_Memberinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Memberinformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Gb_Memberinformation.Location = new System.Drawing.Point(176, 133);
            this.Gb_Memberinformation.Name = "Gb_Memberinformation";
            this.Gb_Memberinformation.Size = new System.Drawing.Size(556, 344);
            this.Gb_Memberinformation.TabIndex = 72;
            this.Gb_Memberinformation.TabStop = false;
            this.Gb_Memberinformation.Text = "Member Information";
            this.Gb_Memberinformation.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(435, 187);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 38);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(435, 131);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 38);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(435, 187);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 38);
            this.btn_Delete.TabIndex = 95;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(435, 131);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(112, 38);
            this.btn_Edit.TabIndex = 94;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(435, 77);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(112, 38);
            this.btn_Print.TabIndex = 12;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // Datetimepicker_Dob
            // 
            this.Datetimepicker_Dob.Location = new System.Drawing.Point(145, 182);
            this.Datetimepicker_Dob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Datetimepicker_Dob.Name = "Datetimepicker_Dob";
            this.Datetimepicker_Dob.Size = new System.Drawing.Size(284, 26);
            this.Datetimepicker_Dob.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(9, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "Date of Birth:";
            // 
            // Textbox_Phone
            // 
            this.Textbox_Phone.Location = new System.Drawing.Point(145, 107);
            this.Textbox_Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Phone.Name = "Textbox_Phone";
            this.Textbox_Phone.Size = new System.Drawing.Size(284, 26);
            this.Textbox_Phone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Phone:";
            // 
            // Datetimepicker_Expirydate
            // 
            this.Datetimepicker_Expirydate.Enabled = false;
            this.Datetimepicker_Expirydate.Location = new System.Drawing.Point(145, 293);
            this.Datetimepicker_Expirydate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Datetimepicker_Expirydate.Name = "Datetimepicker_Expirydate";
            this.Datetimepicker_Expirydate.Size = new System.Drawing.Size(284, 26);
            this.Datetimepicker_Expirydate.TabIndex = 11;
            // 
            // Datetimepicker_Joineddate
            // 
            this.Datetimepicker_Joineddate.Enabled = false;
            this.Datetimepicker_Joineddate.Location = new System.Drawing.Point(145, 254);
            this.Datetimepicker_Joineddate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Datetimepicker_Joineddate.Name = "Datetimepicker_Joineddate";
            this.Datetimepicker_Joineddate.Size = new System.Drawing.Size(284, 26);
            this.Datetimepicker_Joineddate.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(9, 298);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 82;
            this.label9.Text = "Expiry Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(9, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 81;
            this.label8.Text = "Joined Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(9, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Member ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(9, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(9, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 76;
            this.label10.Text = "Member Name:";
            // 
            // Textbox_Address
            // 
            this.Textbox_Address.Location = new System.Drawing.Point(145, 218);
            this.Textbox_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Address.Name = "Textbox_Address";
            this.Textbox_Address.Size = new System.Drawing.Size(284, 26);
            this.Textbox_Address.TabIndex = 9;
            // 
            // Textbox_email
            // 
            this.Textbox_email.Location = new System.Drawing.Point(145, 143);
            this.Textbox_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_email.Name = "Textbox_email";
            this.Textbox_email.Size = new System.Drawing.Size(284, 26);
            this.Textbox_email.TabIndex = 7;
            // 
            // Textbox_Idnumber
            // 
            this.Textbox_Idnumber.BackColor = System.Drawing.Color.White;
            this.Textbox_Idnumber.Location = new System.Drawing.Point(145, 71);
            this.Textbox_Idnumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Idnumber.Name = "Textbox_Idnumber";
            this.Textbox_Idnumber.ReadOnly = true;
            this.Textbox_Idnumber.Size = new System.Drawing.Size(284, 26);
            this.Textbox_Idnumber.TabIndex = 5;
            // 
            // Textbox_Membername
            // 
            this.Textbox_Membername.Location = new System.Drawing.Point(145, 31);
            this.Textbox_Membername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Textbox_Membername.Name = "Textbox_Membername";
            this.Textbox_Membername.Size = new System.Drawing.Size(284, 26);
            this.Textbox_Membername.TabIndex = 4;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search.Location = new System.Drawing.Point(611, 56);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 38);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.Crimson;
            this.labelSearch.Location = new System.Drawing.Point(317, 108);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(268, 20);
            this.labelSearch.TabIndex = 73;
            this.labelSearch.Text = "*Please key in the search words.";
            this.labelSearch.Visible = false;
            // 
            // Uc_Membersearchedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.Gb_Memberinformation);
            this.Controls.Add(this.Combobox_Category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Textbox_Category);
            this.Name = "Uc_Membersearchedit";
            this.Size = new System.Drawing.Size(882, 517);
            this.Load += new System.EventHandler(this.Uc_Membersearchedit_Load);
            this.Gb_Memberinformation.ResumeLayout(false);
            this.Gb_Memberinformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Combobox_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox_Category;
        private System.Windows.Forms.GroupBox Gb_Memberinformation;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.DateTimePicker Datetimepicker_Dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Textbox_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Datetimepicker_Expirydate;
        private System.Windows.Forms.DateTimePicker Datetimepicker_Joineddate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Textbox_Address;
        private System.Windows.Forms.TextBox Textbox_email;
        private System.Windows.Forms.TextBox Textbox_Idnumber;
        private System.Windows.Forms.TextBox Textbox_Membername;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label labelSearch;
    }
}
