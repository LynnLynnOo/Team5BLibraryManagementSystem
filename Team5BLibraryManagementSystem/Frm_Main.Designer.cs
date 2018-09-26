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
            this.Btn_Borrowreturnbooks = new System.Windows.Forms.Button();
            this.Btn_Books = new System.Windows.Forms.Button();
            this.Btn_Reports = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Members = new System.Windows.Forms.Button();
            this.Btn_Addnewmember = new System.Windows.Forms.Button();
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.Btn_Searcheditmember = new System.Windows.Forms.Button();
            this.Btn_Registernewbooks = new System.Windows.Forms.Button();
            this.Btn_Searchbooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_Membersearchedit1 = new Team5BLibraryManagementSystem.UC_Membersearchedit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Borrowreturnbooks
            // 
            this.Btn_Borrowreturnbooks.Location = new System.Drawing.Point(211, 523);
            this.Btn_Borrowreturnbooks.Name = "Btn_Borrowreturnbooks";
            this.Btn_Borrowreturnbooks.Size = new System.Drawing.Size(214, 121);
            this.Btn_Borrowreturnbooks.TabIndex = 29;
            this.Btn_Borrowreturnbooks.Text = "Borrow/Return Books";
            this.Btn_Borrowreturnbooks.UseVisualStyleBackColor = true;
            this.Btn_Borrowreturnbooks.Visible = false;
            // 
            // Btn_Books
            // 
            this.Btn_Books.Location = new System.Drawing.Point(0, 166);
            this.Btn_Books.Name = "Btn_Books";
            this.Btn_Books.Size = new System.Drawing.Size(214, 121);
            this.Btn_Books.TabIndex = 25;
            this.Btn_Books.Text = "Books";
            this.Btn_Books.UseVisualStyleBackColor = true;
            this.Btn_Books.MouseEnter += new System.EventHandler(this.Btn_Books_MouseEnter_1);
            // 
            // Btn_Reports
            // 
            this.Btn_Reports.Location = new System.Drawing.Point(0, 404);
            this.Btn_Reports.Name = "Btn_Reports";
            this.Btn_Reports.Size = new System.Drawing.Size(214, 121);
            this.Btn_Reports.TabIndex = 28;
            this.Btn_Reports.Text = "Reports";
            this.Btn_Reports.UseVisualStyleBackColor = true;
            this.Btn_Reports.MouseEnter += new System.EventHandler(this.Btn_Reports_MouseEnter_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Membersearchedit1);
            this.panel1.Location = new System.Drawing.Point(212, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 166);
            this.panel1.TabIndex = 24;
            // 
            // Btn_Members
            // 
            this.Btn_Members.Location = new System.Drawing.Point(0, 285);
            this.Btn_Members.Name = "Btn_Members";
            this.Btn_Members.Size = new System.Drawing.Size(214, 121);
            this.Btn_Members.TabIndex = 26;
            this.Btn_Members.Text = "Members";
            this.Btn_Members.UseVisualStyleBackColor = true;
            this.Btn_Members.MouseEnter += new System.EventHandler(this.Btn_Members_MouseEnter_1);
            // 
            // Btn_Addnewmember
            // 
            this.Btn_Addnewmember.Location = new System.Drawing.Point(212, 404);
            this.Btn_Addnewmember.Name = "Btn_Addnewmember";
            this.Btn_Addnewmember.Size = new System.Drawing.Size(214, 121);
            this.Btn_Addnewmember.TabIndex = 23;
            this.Btn_Addnewmember.Text = "Add New Member";
            this.Btn_Addnewmember.UseVisualStyleBackColor = true;
            this.Btn_Addnewmember.Visible = false;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.Location = new System.Drawing.Point(0, 523);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(214, 121);
            this.Btn_Logout.TabIndex = 27;
            this.Btn_Logout.Text = "Log out";
            this.Btn_Logout.UseVisualStyleBackColor = true;
            this.Btn_Logout.MouseEnter += new System.EventHandler(this.Btn_Logout_MouseEnter);
            // 
            // Btn_Searcheditmember
            // 
            this.Btn_Searcheditmember.Location = new System.Drawing.Point(212, 285);
            this.Btn_Searcheditmember.Name = "Btn_Searcheditmember";
            this.Btn_Searcheditmember.Size = new System.Drawing.Size(214, 121);
            this.Btn_Searcheditmember.TabIndex = 22;
            this.Btn_Searcheditmember.Text = "Search / Edit Member Info";
            this.Btn_Searcheditmember.UseVisualStyleBackColor = true;
            this.Btn_Searcheditmember.Visible = false;
            // 
            // Btn_Registernewbooks
            // 
            this.Btn_Registernewbooks.Location = new System.Drawing.Point(212, 285);
            this.Btn_Registernewbooks.Name = "Btn_Registernewbooks";
            this.Btn_Registernewbooks.Size = new System.Drawing.Size(214, 121);
            this.Btn_Registernewbooks.TabIndex = 21;
            this.Btn_Registernewbooks.Text = "Register New Books";
            this.Btn_Registernewbooks.UseVisualStyleBackColor = true;
            this.Btn_Registernewbooks.Visible = false;
            // 
            // Btn_Searchbooks
            // 
            this.Btn_Searchbooks.Location = new System.Drawing.Point(212, 166);
            this.Btn_Searchbooks.Name = "Btn_Searchbooks";
            this.Btn_Searchbooks.Size = new System.Drawing.Size(214, 121);
            this.Btn_Searchbooks.TabIndex = 20;
            this.Btn_Searchbooks.Text = "Search Books";
            this.Btn_Searchbooks.UseVisualStyleBackColor = true;
            this.Btn_Searchbooks.Visible = false;
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
            this.uC_Membersearchedit1.Location = new System.Drawing.Point(-1, 0);
            this.uC_Membersearchedit1.Name = "uC_Membersearchedit1";
            this.uC_Membersearchedit1.Size = new System.Drawing.Size(846, 635);
            this.uC_Membersearchedit1.TabIndex = 0;
            this.uC_Membersearchedit1.Load += new System.EventHandler(this.uC_Membersearchedit1_Load);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 644);
            this.Controls.Add(this.Btn_Borrowreturnbooks);
            this.Controls.Add(this.Btn_Books);
            this.Controls.Add(this.Btn_Reports);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Members);
            this.Controls.Add(this.Btn_Addnewmember);
            this.Controls.Add(this.Btn_Logout);
            this.Controls.Add(this.Btn_Searcheditmember);
            this.Controls.Add(this.Btn_Registernewbooks);
            this.Controls.Add(this.Btn_Searchbooks);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Borrowreturnbooks;
        private System.Windows.Forms.Button Btn_Books;
        private System.Windows.Forms.Button Btn_Reports;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Members;
        private System.Windows.Forms.Button Btn_Addnewmember;
        private System.Windows.Forms.Button Btn_Logout;
        private System.Windows.Forms.Button Btn_Searcheditmember;
        private System.Windows.Forms.Button Btn_Registernewbooks;
        private System.Windows.Forms.Button Btn_Searchbooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UC_Membersearchedit uC_Membersearchedit1;
    }
}