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
            this.btn_Registernewbooks = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Searchbooks = new System.Windows.Forms.Button();
            this.btn_Searcheditmember = new System.Windows.Forms.Button();
            this.btn_Addnewmember = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Returnbooks = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Books = new System.Windows.Forms.Button();
            this.btn_Members = new System.Windows.Forms.Button();
            this.uc_LendBook1 = new Team5BLibraryManagementSystem.Uc_LendBook();
            this.uc_Addbook1 = new Team5BLibraryManagementSystem.Uc_Addbook();
            this.uc_ReturnBook1 = new Team5BLibraryManagementSystem.Uc_ReturnBook();
            this.uc_Researchbook1 = new Team5BLibraryManagementSystem.Uc_Researchbook();
            this.uc_Reports4 = new Team5BLibraryManagementSystem.Uc_Reports();
            this.uc_Membersearchedit1 = new Team5BLibraryManagementSystem.Uc_Membersearchedit();
            this.uc_Addmember1 = new Team5BLibraryManagementSystem.Uc_Addmember();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Loanbooks
            // 
            this.btn_Loanbooks.BackColor = System.Drawing.Color.White;
            this.btn_Loanbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Loanbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Loanbooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Loanbooks.Location = new System.Drawing.Point(214, 400);
            this.btn_Loanbooks.Name = "btn_Loanbooks";
            this.btn_Loanbooks.Size = new System.Drawing.Size(214, 130);
            this.btn_Loanbooks.TabIndex = 29;
            this.btn_Loanbooks.TabStop = false;
            this.btn_Loanbooks.Text = "Loan Books";
            this.btn_Loanbooks.UseVisualStyleBackColor = false;
            this.btn_Loanbooks.Visible = false;
            this.btn_Loanbooks.Click += new System.EventHandler(this.btn_Loanbooks_Click);
            this.btn_Loanbooks.MouseEnter += new System.EventHandler(this.btn_Loanbooks_MouseEnter);
            // 
            // btn_Registernewbooks
            // 
            this.btn_Registernewbooks.BackColor = System.Drawing.Color.White;
            this.btn_Registernewbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registernewbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registernewbooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Registernewbooks.Location = new System.Drawing.Point(214, 271);
            this.btn_Registernewbooks.Name = "btn_Registernewbooks";
            this.btn_Registernewbooks.Size = new System.Drawing.Size(214, 130);
            this.btn_Registernewbooks.TabIndex = 21;
            this.btn_Registernewbooks.TabStop = false;
            this.btn_Registernewbooks.Text = "Register New Books";
            this.btn_Registernewbooks.UseVisualStyleBackColor = false;
            this.btn_Registernewbooks.Visible = false;
            this.btn_Registernewbooks.Click += new System.EventHandler(this.btn_Registernewbooks_Click);
            this.btn_Registernewbooks.MouseEnter += new System.EventHandler(this.btn_Registernewbooks_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Team5BLibraryManagementSystem.Properties.Resources._1b45d16ef05586efc45af2190c723278__library_logo_garfield;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Team5BLibraryManagementSystem.Properties.Resources.Banner;
            this.pictureBox2.Location = new System.Drawing.Point(216, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(881, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            // 
            // btn_Searchbooks
            // 
            this.btn_Searchbooks.BackColor = System.Drawing.Color.White;
            this.btn_Searchbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Searchbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Searchbooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Searchbooks.Location = new System.Drawing.Point(214, 142);
            this.btn_Searchbooks.Name = "btn_Searchbooks";
            this.btn_Searchbooks.Size = new System.Drawing.Size(214, 130);
            this.btn_Searchbooks.TabIndex = 20;
            this.btn_Searchbooks.TabStop = false;
            this.btn_Searchbooks.Text = "Search Books";
            this.btn_Searchbooks.UseVisualStyleBackColor = false;
            this.btn_Searchbooks.Visible = false;
            this.btn_Searchbooks.Click += new System.EventHandler(this.btn_Searchbooks_Click);
            this.btn_Searchbooks.MouseEnter += new System.EventHandler(this.btn_Searchbooks_MouseEnter);
            // 
            // btn_Searcheditmember
            // 
            this.btn_Searcheditmember.BackColor = System.Drawing.Color.White;
            this.btn_Searcheditmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Searcheditmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Searcheditmember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Searcheditmember.Location = new System.Drawing.Point(214, 271);
            this.btn_Searcheditmember.Name = "btn_Searcheditmember";
            this.btn_Searcheditmember.Size = new System.Drawing.Size(214, 130);
            this.btn_Searcheditmember.TabIndex = 22;
            this.btn_Searcheditmember.TabStop = false;
            this.btn_Searcheditmember.Text = "Search / Edit Member Info";
            this.btn_Searcheditmember.UseVisualStyleBackColor = false;
            this.btn_Searcheditmember.Visible = false;
            this.btn_Searcheditmember.Click += new System.EventHandler(this.btn_Searcheditmember_Click);
            this.btn_Searcheditmember.MouseEnter += new System.EventHandler(this.btn_Searcheditmember_MouseEnter);
            // 
            // btn_Addnewmember
            // 
            this.btn_Addnewmember.BackColor = System.Drawing.Color.White;
            this.btn_Addnewmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Addnewmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addnewmember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Addnewmember.Location = new System.Drawing.Point(214, 400);
            this.btn_Addnewmember.Name = "btn_Addnewmember";
            this.btn_Addnewmember.Size = new System.Drawing.Size(214, 130);
            this.btn_Addnewmember.TabIndex = 23;
            this.btn_Addnewmember.TabStop = false;
            this.btn_Addnewmember.Text = "Add New Member";
            this.btn_Addnewmember.UseVisualStyleBackColor = false;
            this.btn_Addnewmember.Visible = false;
            this.btn_Addnewmember.Click += new System.EventHandler(this.btn_Addnewmember_Click);
            this.btn_Addnewmember.MouseEnter += new System.EventHandler(this.btn_Addnewmember_MouseEnter);
            // 
            // btn_Reports
            // 
            this.btn_Reports.BackColor = System.Drawing.Color.White;
            this.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Reports.Location = new System.Drawing.Point(1, 400);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(214, 130);
            this.btn_Reports.TabIndex = 28;
            this.btn_Reports.TabStop = false;
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.UseVisualStyleBackColor = false;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            this.btn_Reports.MouseEnter += new System.EventHandler(this.btn_Reports_MouseEnter);
            // 
            // btn_Returnbooks
            // 
            this.btn_Returnbooks.BackColor = System.Drawing.Color.White;
            this.btn_Returnbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Returnbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Returnbooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Returnbooks.Location = new System.Drawing.Point(214, 529);
            this.btn_Returnbooks.Name = "btn_Returnbooks";
            this.btn_Returnbooks.Size = new System.Drawing.Size(214, 130);
            this.btn_Returnbooks.TabIndex = 31;
            this.btn_Returnbooks.TabStop = false;
            this.btn_Returnbooks.Text = "Return Books";
            this.btn_Returnbooks.UseVisualStyleBackColor = false;
            this.btn_Returnbooks.Visible = false;
            this.btn_Returnbooks.Click += new System.EventHandler(this.btn_Returnbooks_Click);
            this.btn_Returnbooks.MouseEnter += new System.EventHandler(this.btn_Returnbooks_MouseEnter);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Logout.Location = new System.Drawing.Point(1, 529);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(214, 130);
            this.btn_Logout.TabIndex = 27;
            this.btn_Logout.TabStop = false;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            this.btn_Logout.MouseEnter += new System.EventHandler(this.btn_Logout_MouseEnter);
            // 
            // btn_Books
            // 
            this.btn_Books.BackColor = System.Drawing.Color.White;
            this.btn_Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Books.Location = new System.Drawing.Point(1, 142);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Size = new System.Drawing.Size(214, 130);
            this.btn_Books.TabIndex = 25;
            this.btn_Books.TabStop = false;
            this.btn_Books.Text = "Books";
            this.btn_Books.UseVisualStyleBackColor = false;
            this.btn_Books.MouseEnter += new System.EventHandler(this.btn_Books_MouseEnter_1);
            // 
            // btn_Members
            // 
            this.btn_Members.BackColor = System.Drawing.Color.White;
            this.btn_Members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Members.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Members.Location = new System.Drawing.Point(1, 271);
            this.btn_Members.Name = "btn_Members";
            this.btn_Members.Size = new System.Drawing.Size(214, 130);
            this.btn_Members.TabIndex = 26;
            this.btn_Members.TabStop = false;
            this.btn_Members.Text = "Members";
            this.btn_Members.UseVisualStyleBackColor = false;
            this.btn_Members.MouseEnter += new System.EventHandler(this.btn_Members_MouseEnter_1);
            // 
            // uc_LendBook1
            // 
            this.uc_LendBook1.BackColor = System.Drawing.Color.White;
            this.uc_LendBook1.Location = new System.Drawing.Point(214, 142);
            this.uc_LendBook1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_LendBook1.Name = "uc_LendBook1";
            this.uc_LendBook1.Size = new System.Drawing.Size(882, 517);
            this.uc_LendBook1.TabIndex = 40;
            this.uc_LendBook1.MouseEnter += new System.EventHandler(this.uc_LendBook1_MouseEnter);
            // 
            // uc_Addbook1
            // 
            this.uc_Addbook1.BackColor = System.Drawing.Color.White;
            this.uc_Addbook1.ForeColor = System.Drawing.Color.White;
            this.uc_Addbook1.Location = new System.Drawing.Point(214, 142);
            this.uc_Addbook1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_Addbook1.Name = "uc_Addbook1";
            this.uc_Addbook1.Size = new System.Drawing.Size(882, 517);
            this.uc_Addbook1.TabIndex = 45;
            this.uc_Addbook1.MouseEnter += new System.EventHandler(this.uc_Addbook1_MouseEnter);
            // 
            // uc_ReturnBook1
            // 
            this.uc_ReturnBook1.BackColor = System.Drawing.Color.White;
            this.uc_ReturnBook1.Location = new System.Drawing.Point(214, 142);
            this.uc_ReturnBook1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_ReturnBook1.Name = "uc_ReturnBook1";
            this.uc_ReturnBook1.Size = new System.Drawing.Size(882, 517);
            this.uc_ReturnBook1.TabIndex = 44;
            this.uc_ReturnBook1.MouseEnter += new System.EventHandler(this.uc_ReturnBook1_MouseEnter);
            // 
            // uc_Researchbook1
            // 
            this.uc_Researchbook1.BackColor = System.Drawing.Color.White;
            this.uc_Researchbook1.Location = new System.Drawing.Point(214, 142);
            this.uc_Researchbook1.Margin = new System.Windows.Forms.Padding(6);
            this.uc_Researchbook1.Name = "uc_Researchbook1";
            this.uc_Researchbook1.Size = new System.Drawing.Size(882, 517);
            this.uc_Researchbook1.TabIndex = 43;
            this.uc_Researchbook1.MouseEnter += new System.EventHandler(this.uc_Researchbook1_MouseEnter);
            // 
            // uc_Reports4
            // 
            this.uc_Reports4.BackColor = System.Drawing.Color.White;
            this.uc_Reports4.Location = new System.Drawing.Point(214, 142);
            this.uc_Reports4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uc_Reports4.Name = "uc_Reports4";
            this.uc_Reports4.Size = new System.Drawing.Size(882, 517);
            this.uc_Reports4.TabIndex = 42;
            this.uc_Reports4.MouseEnter += new System.EventHandler(this.uc_Reports4_MouseEnter);
            // 
            // uc_Membersearchedit1
            // 
            this.uc_Membersearchedit1.BackColor = System.Drawing.Color.White;
            this.uc_Membersearchedit1.Location = new System.Drawing.Point(214, 142);
            this.uc_Membersearchedit1.Name = "uc_Membersearchedit1";
            this.uc_Membersearchedit1.Size = new System.Drawing.Size(882, 517);
            this.uc_Membersearchedit1.TabIndex = 41;
            this.uc_Membersearchedit1.MouseEnter += new System.EventHandler(this.uc_Membersearchedit1_MouseEnter);
            // 
            // uc_Addmember1
            // 
            this.uc_Addmember1.BackColor = System.Drawing.Color.White;
            this.uc_Addmember1.Location = new System.Drawing.Point(214, 142);
            this.uc_Addmember1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uc_Addmember1.Name = "uc_Addmember1";
            this.uc_Addmember1.Size = new System.Drawing.Size(882, 517);
            this.uc_Addmember1.TabIndex = 46;
            this.uc_Addmember1.MouseEnter += new System.EventHandler(this.uc_Addmember1_MouseEnter);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 660);
            this.Controls.Add(this.btn_Members);
            this.Controls.Add(this.btn_Books);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Returnbooks);
            this.Controls.Add(this.btn_Reports);
            this.Controls.Add(this.btn_Loanbooks);
            this.Controls.Add(this.btn_Searchbooks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Registernewbooks);
            this.Controls.Add(this.btn_Addnewmember);
            this.Controls.Add(this.btn_Searcheditmember);
            this.Controls.Add(this.uc_Addmember1);
            this.Controls.Add(this.uc_LendBook1);
            this.Controls.Add(this.uc_Addbook1);
            this.Controls.Add(this.uc_ReturnBook1);
            this.Controls.Add(this.uc_Researchbook1);
            this.Controls.Add(this.uc_Reports4);
            this.Controls.Add(this.uc_Membersearchedit1);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.MouseLeave += new System.EventHandler(this.Frm_Main_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Loanbooks;
        private System.Windows.Forms.Button btn_Registernewbooks;
        private Uc_Reports uc_Reports1;
        private Uc_Reports uc_Reports3;
        private Uc_Reports uc_Reports2;
        private Uc_ReturnBook uc_ReturnBook1;
        private Uc_Reports uc_Reports4;
        private Uc_Membersearchedit uc_Membersearchedit1;
        private Uc_LendBook uc_LendBook1;
        private Uc_Researchbook uc_Researchbook1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Searchbooks;
        private System.Windows.Forms.Button btn_Searcheditmember;
        private System.Windows.Forms.Button btn_Addnewmember;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button btn_Returnbooks;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Button btn_Members;
        private Uc_Addbook uc_Addbook1;
        private Uc_Addmember uc_Addmember1;
    }
}