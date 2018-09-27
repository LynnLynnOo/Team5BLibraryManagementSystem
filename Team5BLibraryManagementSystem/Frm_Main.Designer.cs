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
            this.btn_Loanbooks = new System.Windows.Forms.Button();
            this.btn_Books = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Members = new System.Windows.Forms.Button();
            this.btn_Addnewmember = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Searcheditmember = new System.Windows.Forms.Button();
            this.btn_Registernewbooks = new System.Windows.Forms.Button();
            this.btn_Searchbooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Returnbooks = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uc_Researchbook1 = new Team5BLibraryManagementSystem.Uc_Researchbook();
            this.uc_Reports1 = new Team5BLibraryManagementSystem.Uc_Reports();
            this.uc_LendBook1 = new Team5BLibraryManagementSystem.Uc_LendBook();
            this.uc_Addbook1 = new Team5BLibraryManagementSystem.Uc_Addbook();
            this.uC_Membersearchedit1 = new Team5BLibraryManagementSystem.Uc_Membersearchedit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Loanbooks
            // 
            this.btn_Loanbooks.Location = new System.Drawing.Point(212, 403);
            this.btn_Loanbooks.Name = "btn_Loanbooks";
            this.btn_Loanbooks.Size = new System.Drawing.Size(214, 122);
            this.btn_Loanbooks.TabIndex = 29;
            this.btn_Loanbooks.Text = "Loan Books";
            this.btn_Loanbooks.UseVisualStyleBackColor = true;
            this.btn_Loanbooks.Visible = false;
            this.btn_Loanbooks.Click += new System.EventHandler(this.btn_Loanbooks_Click);
            this.btn_Loanbooks.MouseEnter += new System.EventHandler(this.btn_Loanbooks_MouseEnter);
            // 
            // btn_Books
            // 
            this.btn_Books.Location = new System.Drawing.Point(0, 166);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Size = new System.Drawing.Size(214, 122);
            this.btn_Books.TabIndex = 25;
            this.btn_Books.Text = "Books";
            this.btn_Books.UseVisualStyleBackColor = true;
            this.btn_Books.MouseEnter += new System.EventHandler(this.btn_Books_MouseEnter_1);
            // 
            // btn_Reports
            // 
            this.btn_Reports.Location = new System.Drawing.Point(0, 405);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(214, 122);
            this.btn_Reports.TabIndex = 28;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.UseVisualStyleBackColor = true;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            this.btn_Reports.MouseEnter += new System.EventHandler(this.btn_Reports_MouseEnter);
            // 
            // btn_Members
            // 
            this.btn_Members.Location = new System.Drawing.Point(0, 285);
            this.btn_Members.Name = "btn_Members";
            this.btn_Members.Size = new System.Drawing.Size(214, 122);
            this.btn_Members.TabIndex = 26;
            this.btn_Members.Text = "Members";
            this.btn_Members.UseVisualStyleBackColor = true;
            this.btn_Members.MouseEnter += new System.EventHandler(this.btn_Members_MouseEnter_1);
            // 
            // btn_Addnewmember
            // 
            this.btn_Addnewmember.Location = new System.Drawing.Point(212, 403);
            this.btn_Addnewmember.Name = "btn_Addnewmember";
            this.btn_Addnewmember.Size = new System.Drawing.Size(214, 122);
            this.btn_Addnewmember.TabIndex = 23;
            this.btn_Addnewmember.Text = "Add New Member";
            this.btn_Addnewmember.UseVisualStyleBackColor = true;
            this.btn_Addnewmember.Visible = false;
            this.btn_Addnewmember.Click += new System.EventHandler(this.btn_Addnewmember_Click);
            this.btn_Addnewmember.MouseEnter += new System.EventHandler(this.btn_Addnewmember_MouseEnter);
            this.btn_Addnewmember.MouseLeave += new System.EventHandler(this.btn_Addnewmember_MouseLeave);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(0, 523);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(214, 122);
            this.btn_Logout.TabIndex = 27;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Searcheditmember
            // 
            this.btn_Searcheditmember.Location = new System.Drawing.Point(212, 283);
            this.btn_Searcheditmember.Name = "btn_Searcheditmember";
            this.btn_Searcheditmember.Size = new System.Drawing.Size(214, 122);
            this.btn_Searcheditmember.TabIndex = 22;
            this.btn_Searcheditmember.Text = "Search / Edit Member Info";
            this.btn_Searcheditmember.UseVisualStyleBackColor = true;
            this.btn_Searcheditmember.Visible = false;
            this.btn_Searcheditmember.Click += new System.EventHandler(this.btn_Searcheditmember_Click);
            this.btn_Searcheditmember.MouseEnter += new System.EventHandler(this.btn_Searcheditmember_MouseEnter);
            // 
            // btn_Registernewbooks
            // 
            this.btn_Registernewbooks.Location = new System.Drawing.Point(212, 283);
            this.btn_Registernewbooks.Name = "btn_Registernewbooks";
            this.btn_Registernewbooks.Size = new System.Drawing.Size(214, 122);
            this.btn_Registernewbooks.TabIndex = 21;
            this.btn_Registernewbooks.Text = "Register New Books";
            this.btn_Registernewbooks.UseVisualStyleBackColor = true;
            this.btn_Registernewbooks.Visible = false;
            this.btn_Registernewbooks.Click += new System.EventHandler(this.btn_Registernewbooks_Click);
            this.btn_Registernewbooks.MouseEnter += new System.EventHandler(this.btn_Registernewbooks_MouseEnter);
            this.btn_Registernewbooks.MouseLeave += new System.EventHandler(this.btn_Registernewbooks_MouseLeave);
            // 
            // btn_Searchbooks
            // 
            this.btn_Searchbooks.Location = new System.Drawing.Point(212, 164);
            this.btn_Searchbooks.Name = "btn_Searchbooks";
            this.btn_Searchbooks.Size = new System.Drawing.Size(214, 122);
            this.btn_Searchbooks.TabIndex = 20;
            this.btn_Searchbooks.Text = "Search Books";
            this.btn_Searchbooks.UseVisualStyleBackColor = true;
            this.btn_Searchbooks.Visible = false;
            this.btn_Searchbooks.Click += new System.EventHandler(this.btn_Searchbooks_Click);
            this.btn_Searchbooks.MouseEnter += new System.EventHandler(this.btn_Searchbooks_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 166);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // btn_Returnbooks
            // 
            this.btn_Returnbooks.Location = new System.Drawing.Point(212, 523);
            this.btn_Returnbooks.Name = "btn_Returnbooks";
            this.btn_Returnbooks.Size = new System.Drawing.Size(214, 122);
            this.btn_Returnbooks.TabIndex = 31;
            this.btn_Returnbooks.Text = "Return Books";
            this.btn_Returnbooks.UseVisualStyleBackColor = true;
            this.btn_Returnbooks.Visible = false;
            this.btn_Returnbooks.Click += new System.EventHandler(this.btn_Returnbooks_Click);
            this.btn_Returnbooks.MouseEnter += new System.EventHandler(this.btn_Returnbooks_MouseEnter);
            this.btn_Returnbooks.MouseLeave += new System.EventHandler(this.btn_Returnbooks_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Registernewbooks);
            this.panel1.Controls.Add(this.btn_Addnewmember);
            this.panel1.Controls.Add(this.btn_Loanbooks);
            this.panel1.Controls.Add(this.btn_Searcheditmember);
            this.panel1.Controls.Add(this.btn_Searchbooks);
            this.panel1.Controls.Add(this.uc_Researchbook1);
            this.panel1.Controls.Add(this.uc_Reports1);
            this.panel1.Controls.Add(this.uc_LendBook1);
            this.panel1.Controls.Add(this.uc_Addbook1);
            this.panel1.Controls.Add(this.uC_Membersearchedit1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 643);
            this.panel1.TabIndex = 36;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // uc_Researchbook1
            // 
            this.uc_Researchbook1.Location = new System.Drawing.Point(212, 0);
            this.uc_Researchbook1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_Researchbook1.Name = "uc_Researchbook1";
            this.uc_Researchbook1.Size = new System.Drawing.Size(846, 635);
            this.uc_Researchbook1.TabIndex = 32;
            // 
            // uc_Reports1
            // 
            this.uc_Reports1.Location = new System.Drawing.Point(212, 0);
            this.uc_Reports1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uc_Reports1.Name = "uc_Reports1";
            this.uc_Reports1.Size = new System.Drawing.Size(846, 635);
            this.uc_Reports1.TabIndex = 33;
            // 
            // uc_LendBook1
            // 
            this.uc_LendBook1.Location = new System.Drawing.Point(212, 0);
            this.uc_LendBook1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_LendBook1.Name = "uc_LendBook1";
            this.uc_LendBook1.Size = new System.Drawing.Size(846, 635);
            this.uc_LendBook1.TabIndex = 34;
            // 
            // uc_Addbook1
            // 
            this.uc_Addbook1.Location = new System.Drawing.Point(212, 0);
            this.uc_Addbook1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_Addbook1.Name = "uc_Addbook1";
            this.uc_Addbook1.Size = new System.Drawing.Size(846, 635);
            this.uc_Addbook1.TabIndex = 35;
            // 
            // uC_Membersearchedit1
            // 
            this.uC_Membersearchedit1.Location = new System.Drawing.Point(217, 1);
            this.uC_Membersearchedit1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Membersearchedit1.Name = "uC_Membersearchedit1";
            this.uC_Membersearchedit1.Size = new System.Drawing.Size(880, 640);
            this.uC_Membersearchedit1.TabIndex = 30;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 645);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Books);
            this.Controls.Add(this.btn_Reports);
            this.Controls.Add(this.btn_Members);
            this.Controls.Add(this.btn_Returnbooks);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Loanbooks;
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
        private System.Windows.Forms.Button btn_Returnbooks;
        private Uc_Researchbook uc_Researchbook1;
        private Uc_Reports uc_Reports1;
        private Uc_LendBook uc_LendBook1;
        private Uc_Addbook uc_Addbook1;
        private System.Windows.Forms.Panel panel1;
    }
}