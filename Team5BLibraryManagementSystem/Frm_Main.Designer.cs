namespace Team5BLibraryManagementSystem
{
    partial class Frm_Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Borrowreturnbooks = new System.Windows.Forms.Button();
            this.btn_Books = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Members = new System.Windows.Forms.Button();
            this.btn_Addnewmember = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Searcheditmember = new System.Windows.Forms.Button();
            this.btn_Registernewbooks = new System.Windows.Forms.Button();
            this.btn_Searchbooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_Membersearchedit1 = new Team5BLibraryManagementSystem.Uc_Membersearchedit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Borrowreturnbooks
            // 
            this.btn_Borrowreturnbooks.Location = new System.Drawing.Point(210, 523);
            this.btn_Borrowreturnbooks.Name = "btn_Borrowreturnbooks";
            this.btn_Borrowreturnbooks.Size = new System.Drawing.Size(214, 121);
            this.btn_Borrowreturnbooks.TabIndex = 29;
            this.btn_Borrowreturnbooks.Text = "Borrow/Return Books";
            this.btn_Borrowreturnbooks.UseVisualStyleBackColor = true;
            this.btn_Borrowreturnbooks.Visible = false;
            // 
            // btn_Books
            // 
            this.btn_Books.Location = new System.Drawing.Point(0, 166);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Size = new System.Drawing.Size(214, 121);
            this.btn_Books.TabIndex = 25;
            this.btn_Books.Text = "Books";
            this.btn_Books.UseVisualStyleBackColor = true;
            this.btn_Books.Click += new System.EventHandler(this.btn_Books_Click);
            this.btn_Books.MouseEnter += new System.EventHandler(this.Btn_Books_MouseEnter_1);
            this.btn_Books.MouseLeave += new System.EventHandler(this.btn_Books_MouseLeave);
            // 
            // btn_Reports
            // 
            this.btn_Reports.Location = new System.Drawing.Point(0, 404);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(214, 121);
            this.btn_Reports.TabIndex = 28;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.UseVisualStyleBackColor = true;
            this.btn_Reports.MouseEnter += new System.EventHandler(this.Btn_Reports_MouseEnter_1);
            // 
            // btn_Members
            // 
            this.btn_Members.Location = new System.Drawing.Point(0, 285);
            this.btn_Members.Name = "btn_Members";
            this.btn_Members.Size = new System.Drawing.Size(214, 121);
            this.btn_Members.TabIndex = 26;
            this.btn_Members.Text = "Members";
            this.btn_Members.UseVisualStyleBackColor = true;
            this.btn_Members.MouseEnter += new System.EventHandler(this.Btn_Members_MouseEnter_1);
            this.btn_Members.MouseLeave += new System.EventHandler(this.btn_Members_MouseLeave);
            // 
            // btn_Addnewmember
            // 
            this.btn_Addnewmember.Location = new System.Drawing.Point(211, 404);
            this.btn_Addnewmember.Name = "btn_Addnewmember";
            this.btn_Addnewmember.Size = new System.Drawing.Size(214, 121);
            this.btn_Addnewmember.TabIndex = 23;
            this.btn_Addnewmember.Text = "Add New Member";
            this.btn_Addnewmember.UseVisualStyleBackColor = true;
            this.btn_Addnewmember.Visible = false;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(0, 523);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(214, 121);
            this.btn_Logout.TabIndex = 27;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.MouseEnter += new System.EventHandler(this.Btn_Logout_MouseEnter);
            // 
            // btn_Searcheditmember
            // 
            this.btn_Searcheditmember.Location = new System.Drawing.Point(211, 285);
            this.btn_Searcheditmember.Name = "btn_Searcheditmember";
            this.btn_Searcheditmember.Size = new System.Drawing.Size(214, 121);
            this.btn_Searcheditmember.TabIndex = 22;
            this.btn_Searcheditmember.Text = "Search / Edit Member Info";
            this.btn_Searcheditmember.UseVisualStyleBackColor = true;
            this.btn_Searcheditmember.Visible = false;
            // 
            // btn_Registernewbooks
            // 
            this.btn_Registernewbooks.Location = new System.Drawing.Point(212, 285);
            this.btn_Registernewbooks.Name = "btn_Registernewbooks";
            this.btn_Registernewbooks.Size = new System.Drawing.Size(214, 121);
            this.btn_Registernewbooks.TabIndex = 21;
            this.btn_Registernewbooks.Text = "Register New Books";
            this.btn_Registernewbooks.UseVisualStyleBackColor = true;
            this.btn_Registernewbooks.Visible = false;
            // 
            // btn_Searchbooks
            // 
            this.btn_Searchbooks.Location = new System.Drawing.Point(212, 166);
            this.btn_Searchbooks.Name = "btn_Searchbooks";
            this.btn_Searchbooks.Size = new System.Drawing.Size(214, 121);
            this.btn_Searchbooks.TabIndex = 20;
            this.btn_Searchbooks.Text = "Search Books";
            this.btn_Searchbooks.UseVisualStyleBackColor = true;
            this.btn_Searchbooks.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 166);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // uC_Membersearchedit1
            // 
            this.uC_Membersearchedit1.Location = new System.Drawing.Point(212, 1);
            this.uC_Membersearchedit1.Name = "uC_Membersearchedit1";
            this.uC_Membersearchedit1.Size = new System.Drawing.Size(846, 635);
            this.uC_Membersearchedit1.TabIndex = 30;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 644);
            this.Controls.Add(this.btn_Borrowreturnbooks);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Registernewbooks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Books);
            this.Controls.Add(this.btn_Reports);
            this.Controls.Add(this.btn_Members);
            this.Controls.Add(this.btn_Addnewmember);
            this.Controls.Add(this.btn_Searcheditmember);
            this.Controls.Add(this.btn_Searchbooks);
            this.Controls.Add(this.uC_Membersearchedit1);
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Borrowreturnbooks;
        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button btn_Members;
        private System.Windows.Forms.Button btn_Addnewmember;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Searcheditmember;
        private System.Windows.Forms.Button btn_Registernewbooks;
        private System.Windows.Forms.Button btn_Searchbooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Uc_Membersearchedit uC_Membersearchedit1;
    }
}