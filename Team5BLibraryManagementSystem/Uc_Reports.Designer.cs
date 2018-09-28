namespace Team5BLibraryManagementSystem
{
    partial class Uc_Reports
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
            this.label_Typesofreport = new System.Windows.Forms.Label();
            this.cmb_Typesofreport = new System.Windows.Forms.ComboBox();
            this.groupBox_Weeklyloanreport = new System.Windows.Forms.GroupBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.label_SelectMonth = new System.Windows.Forms.Label();
            this.groupBox_MemberListing = new System.Windows.Forms.GroupBox();
            this.btn_PrintMemberListing = new System.Windows.Forms.Button();
            this.rdbtn_Membersbeforeexpiry = new System.Windows.Forms.RadioButton();
            this.rdbtn_Allmembers = new System.Windows.Forms.RadioButton();
            this.rdbtn_Membersafterexpiry = new System.Windows.Forms.RadioButton();
            this.groupBox_BookList = new System.Windows.Forms.GroupBox();
            this.rdbtn_Availability = new System.Windows.Forms.RadioButton();
            this.rdbtn_Category = new System.Windows.Forms.RadioButton();
            this.btn_BookList = new System.Windows.Forms.Button();
            this.groupBox_OverdueBooks = new System.Windows.Forms.GroupBox();
            this.btn_PrintBooksOverdue = new System.Windows.Forms.Button();
            this.rdbtn_Overduebymorethan3days = new System.Windows.Forms.RadioButton();
            this.rdbtn_Overdueby3days = new System.Windows.Forms.RadioButton();
            this.rdbtn_Overdueby1day = new System.Windows.Forms.RadioButton();
            this.groupBox_Weeklyloanreport.SuspendLayout();
            this.groupBox_MemberListing.SuspendLayout();
            this.groupBox_BookList.SuspendLayout();
            this.groupBox_OverdueBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Typesofreport
            // 
            this.label_Typesofreport.AutoSize = true;
            this.label_Typesofreport.BackColor = System.Drawing.Color.White;
            this.label_Typesofreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Typesofreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Typesofreport.Location = new System.Drawing.Point(191, 39);
            this.label_Typesofreport.Name = "label_Typesofreport";
            this.label_Typesofreport.Size = new System.Drawing.Size(142, 20);
            this.label_Typesofreport.TabIndex = 0;
            this.label_Typesofreport.Text = "Types of Report:";
            // 
            // cmb_Typesofreport
            // 
            this.cmb_Typesofreport.BackColor = System.Drawing.Color.White;
            this.cmb_Typesofreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Typesofreport.ForeColor = System.Drawing.Color.Black;
            this.cmb_Typesofreport.FormattingEnabled = true;
            this.cmb_Typesofreport.Items.AddRange(new object[] {
            "Overdue Books",
            "Book List",
            "Member List",
            "Monthly Loan Report"});
            this.cmb_Typesofreport.Location = new System.Drawing.Point(355, 39);
            this.cmb_Typesofreport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Typesofreport.Name = "cmb_Typesofreport";
            this.cmb_Typesofreport.Size = new System.Drawing.Size(334, 28);
            this.cmb_Typesofreport.TabIndex = 1;
            this.cmb_Typesofreport.SelectedIndexChanged += new System.EventHandler(this.cmb_Typesofreport_SelectedIndexChanged);
            // 
            // groupBox_Weeklyloanreport
            // 
            this.groupBox_Weeklyloanreport.BackColor = System.Drawing.Color.White;
            this.groupBox_Weeklyloanreport.Controls.Add(this.btn_Print);
            this.groupBox_Weeklyloanreport.Controls.Add(this.label_EndDate);
            this.groupBox_Weeklyloanreport.Controls.Add(this.label_SelectMonth);
            this.groupBox_Weeklyloanreport.Location = new System.Drawing.Point(214, 95);
            this.groupBox_Weeklyloanreport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Weeklyloanreport.Name = "groupBox_Weeklyloanreport";
            this.groupBox_Weeklyloanreport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Weeklyloanreport.Size = new System.Drawing.Size(517, 324);
            this.groupBox_Weeklyloanreport.TabIndex = 2;
            this.groupBox_Weeklyloanreport.TabStop = false;
            this.groupBox_Weeklyloanreport.Visible = false;
            // 
            // btn_Print
            // 
            this.btn_Print.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Print.Location = new System.Drawing.Point(204, 222);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(129, 60);
            this.btn_Print.TabIndex = 4;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Location = new System.Drawing.Point(40, 121);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(0, 20);
            this.label_EndDate.TabIndex = 3;
            // 
            // label_SelectMonth
            // 
            this.label_SelectMonth.AutoSize = true;
            this.label_SelectMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_SelectMonth.Location = new System.Drawing.Point(65, 62);
            this.label_SelectMonth.Name = "label_SelectMonth";
            this.label_SelectMonth.Size = new System.Drawing.Size(64, 20);
            this.label_SelectMonth.TabIndex = 2;
            this.label_SelectMonth.Text = "Month:";
            // 
            // groupBox_MemberListing
            // 
            this.groupBox_MemberListing.BackColor = System.Drawing.Color.White;
            this.groupBox_MemberListing.Controls.Add(this.btn_PrintMemberListing);
            this.groupBox_MemberListing.Controls.Add(this.rdbtn_Membersbeforeexpiry);
            this.groupBox_MemberListing.Controls.Add(this.rdbtn_Allmembers);
            this.groupBox_MemberListing.Controls.Add(this.rdbtn_Membersafterexpiry);
            this.groupBox_MemberListing.Location = new System.Drawing.Point(214, 95);
            this.groupBox_MemberListing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_MemberListing.Name = "groupBox_MemberListing";
            this.groupBox_MemberListing.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_MemberListing.Size = new System.Drawing.Size(517, 324);
            this.groupBox_MemberListing.TabIndex = 3;
            this.groupBox_MemberListing.TabStop = false;
            this.groupBox_MemberListing.Visible = false;
            // 
            // btn_PrintMemberListing
            // 
            this.btn_PrintMemberListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintMemberListing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_PrintMemberListing.Location = new System.Drawing.Point(226, 230);
            this.btn_PrintMemberListing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PrintMemberListing.Name = "btn_PrintMemberListing";
            this.btn_PrintMemberListing.Size = new System.Drawing.Size(129, 60);
            this.btn_PrintMemberListing.TabIndex = 4;
            this.btn_PrintMemberListing.Text = "Print";
            this.btn_PrintMemberListing.UseVisualStyleBackColor = true;
            this.btn_PrintMemberListing.Click += new System.EventHandler(this.btn_PrintMemberListing_Click);
            // 
            // rdbtn_Membersbeforeexpiry
            // 
            this.rdbtn_Membersbeforeexpiry.AutoSize = true;
            this.rdbtn_Membersbeforeexpiry.Checked = true;
            this.rdbtn_Membersbeforeexpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Membersbeforeexpiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtn_Membersbeforeexpiry.Location = new System.Drawing.Point(169, 78);
            this.rdbtn_Membersbeforeexpiry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtn_Membersbeforeexpiry.Name = "rdbtn_Membersbeforeexpiry";
            this.rdbtn_Membersbeforeexpiry.Size = new System.Drawing.Size(263, 24);
            this.rdbtn_Membersbeforeexpiry.TabIndex = 1;
            this.rdbtn_Membersbeforeexpiry.TabStop = true;
            this.rdbtn_Membersbeforeexpiry.Text = "Members Before Expiry Date";
            this.rdbtn_Membersbeforeexpiry.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Allmembers
            // 
            this.rdbtn_Allmembers.AutoSize = true;
            this.rdbtn_Allmembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Allmembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtn_Allmembers.Location = new System.Drawing.Point(169, 145);
            this.rdbtn_Allmembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtn_Allmembers.Name = "rdbtn_Allmembers";
            this.rdbtn_Allmembers.Size = new System.Drawing.Size(132, 24);
            this.rdbtn_Allmembers.TabIndex = 3;
            this.rdbtn_Allmembers.Text = "All Members";
            this.rdbtn_Allmembers.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Membersafterexpiry
            // 
            this.rdbtn_Membersafterexpiry.AutoSize = true;
            this.rdbtn_Membersafterexpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Membersafterexpiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtn_Membersafterexpiry.Location = new System.Drawing.Point(169, 111);
            this.rdbtn_Membersafterexpiry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtn_Membersafterexpiry.Name = "rdbtn_Membersafterexpiry";
            this.rdbtn_Membersafterexpiry.Size = new System.Drawing.Size(249, 24);
            this.rdbtn_Membersafterexpiry.TabIndex = 2;
            this.rdbtn_Membersafterexpiry.Text = "Members After Expiry Date";
            this.rdbtn_Membersafterexpiry.UseVisualStyleBackColor = true;
            // 
            // groupBox_BookList
            // 
            this.groupBox_BookList.Controls.Add(this.rdbtn_Availability);
            this.groupBox_BookList.Controls.Add(this.rdbtn_Category);
            this.groupBox_BookList.Controls.Add(this.btn_BookList);
            this.groupBox_BookList.Location = new System.Drawing.Point(214, 95);
            this.groupBox_BookList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_BookList.Name = "groupBox_BookList";
            this.groupBox_BookList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_BookList.Size = new System.Drawing.Size(517, 316);
            this.groupBox_BookList.TabIndex = 4;
            this.groupBox_BookList.TabStop = false;
            this.groupBox_BookList.Visible = false;
            // 
            // rdbtn_Availability
            // 
            this.rdbtn_Availability.AutoSize = true;
            this.rdbtn_Availability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Availability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtn_Availability.Location = new System.Drawing.Point(192, 106);
            this.rdbtn_Availability.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtn_Availability.Name = "rdbtn_Availability";
            this.rdbtn_Availability.Size = new System.Drawing.Size(256, 24);
            this.rdbtn_Availability.TabIndex = 2;
            this.rdbtn_Availability.Text = "Books Listing By Availability";
            this.rdbtn_Availability.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Category
            // 
            this.rdbtn_Category.AutoSize = true;
            this.rdbtn_Category.Checked = true;
            this.rdbtn_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtn_Category.Location = new System.Drawing.Point(192, 70);
            this.rdbtn_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtn_Category.Name = "rdbtn_Category";
            this.rdbtn_Category.Size = new System.Drawing.Size(244, 24);
            this.rdbtn_Category.TabIndex = 1;
            this.rdbtn_Category.TabStop = true;
            this.rdbtn_Category.Text = "Books Listing By Category";
            this.rdbtn_Category.UseVisualStyleBackColor = true;
            // 
            // btn_BookList
            // 
            this.btn_BookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_BookList.Location = new System.Drawing.Point(218, 203);
            this.btn_BookList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_BookList.Name = "btn_BookList";
            this.btn_BookList.Size = new System.Drawing.Size(129, 60);
            this.btn_BookList.TabIndex = 3;
            this.btn_BookList.Text = "Print";
            this.btn_BookList.UseVisualStyleBackColor = true;
            this.btn_BookList.Click += new System.EventHandler(this.btn_BookList_Click);
            // 
            // groupBox_OverdueBooks
            // 
            this.groupBox_OverdueBooks.BackColor = System.Drawing.Color.White;
            this.groupBox_OverdueBooks.Controls.Add(this.btn_PrintBooksOverdue);
            this.groupBox_OverdueBooks.Controls.Add(this.rdbtn_Overduebymorethan3days);
            this.groupBox_OverdueBooks.Controls.Add(this.rdbtn_Overdueby3days);
            this.groupBox_OverdueBooks.Controls.Add(this.rdbtn_Overdueby1day);
            this.groupBox_OverdueBooks.Location = new System.Drawing.Point(214, 95);
            this.groupBox_OverdueBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_OverdueBooks.Name = "groupBox_OverdueBooks";
            this.groupBox_OverdueBooks.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_OverdueBooks.Size = new System.Drawing.Size(517, 324);
            this.groupBox_OverdueBooks.TabIndex = 5;
            this.groupBox_OverdueBooks.TabStop = false;
            this.groupBox_OverdueBooks.Visible = false;
            // 
            // btn_PrintBooksOverdue
            // 
            this.btn_PrintBooksOverdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintBooksOverdue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_PrintBooksOverdue.Location = new System.Drawing.Point(204, 218);
            this.btn_PrintBooksOverdue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PrintBooksOverdue.Name = "btn_PrintBooksOverdue";
            this.btn_PrintBooksOverdue.Size = new System.Drawing.Size(129, 60);
            this.btn_PrintBooksOverdue.TabIndex = 6;
            this.btn_PrintBooksOverdue.Text = "Print";
            this.btn_PrintBooksOverdue.UseVisualStyleBackColor = true;
            this.btn_PrintBooksOverdue.Click += new System.EventHandler(this.btn_PrintBooksOverdue_Click);
            // 
            // rdbtn_Overduebymorethan3days
            // 
            this.rdbtn_Overduebymorethan3days.AutoSize = true;
            this.rdbtn_Overduebymorethan3days.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Overduebymorethan3days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtn_Overduebymorethan3days.Location = new System.Drawing.Point(170, 124);
            this.rdbtn_Overduebymorethan3days.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtn_Overduebymorethan3days.Name = "rdbtn_Overduebymorethan3days";
            this.rdbtn_Overduebymorethan3days.Size = new System.Drawing.Size(276, 24);
            this.rdbtn_Overduebymorethan3days.TabIndex = 2;
            this.rdbtn_Overduebymorethan3days.Text = "Overdue By More Than 3 Days";
            this.rdbtn_Overduebymorethan3days.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Overdueby3days
            // 
            this.rdbtn_Overdueby3days.AutoSize = true;
            this.rdbtn_Overdueby3days.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Overdueby3days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtn_Overdueby3days.Location = new System.Drawing.Point(170, 90);
            this.rdbtn_Overdueby3days.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtn_Overdueby3days.Name = "rdbtn_Overdueby3days";
            this.rdbtn_Overdueby3days.Size = new System.Drawing.Size(184, 24);
            this.rdbtn_Overdueby3days.TabIndex = 1;
            this.rdbtn_Overdueby3days.Text = "Overdue by 3 Days";
            this.rdbtn_Overdueby3days.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Overdueby1day
            // 
            this.rdbtn_Overdueby1day.AutoSize = true;
            this.rdbtn_Overdueby1day.Checked = true;
            this.rdbtn_Overdueby1day.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Overdueby1day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtn_Overdueby1day.Location = new System.Drawing.Point(170, 56);
            this.rdbtn_Overdueby1day.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbtn_Overdueby1day.Name = "rdbtn_Overdueby1day";
            this.rdbtn_Overdueby1day.Size = new System.Drawing.Size(177, 24);
            this.rdbtn_Overdueby1day.TabIndex = 0;
            this.rdbtn_Overdueby1day.TabStop = true;
            this.rdbtn_Overdueby1day.Text = "Overdue By 1 Day";
            this.rdbtn_Overdueby1day.UseVisualStyleBackColor = true;
            // 
            // Uc_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmb_Typesofreport);
            this.Controls.Add(this.label_Typesofreport);
            this.Controls.Add(this.groupBox_BookList);
            this.Controls.Add(this.groupBox_OverdueBooks);
            this.Controls.Add(this.groupBox_MemberListing);
            this.Controls.Add(this.groupBox_Weeklyloanreport);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Uc_Reports";
            this.Size = new System.Drawing.Size(882, 517);
            this.groupBox_Weeklyloanreport.ResumeLayout(false);
            this.groupBox_Weeklyloanreport.PerformLayout();
            this.groupBox_MemberListing.ResumeLayout(false);
            this.groupBox_MemberListing.PerformLayout();
            this.groupBox_BookList.ResumeLayout(false);
            this.groupBox_BookList.PerformLayout();
            this.groupBox_OverdueBooks.ResumeLayout(false);
            this.groupBox_OverdueBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Typesofreport;
        private System.Windows.Forms.ComboBox cmb_Typesofreport;
        private System.Windows.Forms.GroupBox groupBox_Weeklyloanreport;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label_EndDate;
        private System.Windows.Forms.Label label_SelectMonth;
        private System.Windows.Forms.GroupBox groupBox_MemberListing;
        private System.Windows.Forms.RadioButton rdbtn_Membersbeforeexpiry;
        private System.Windows.Forms.RadioButton rdbtn_Allmembers;
        private System.Windows.Forms.RadioButton rdbtn_Membersafterexpiry;
        private System.Windows.Forms.Button btn_PrintMemberListing;
        private System.Windows.Forms.GroupBox groupBox_BookList;
        private System.Windows.Forms.Button btn_BookList;
        private System.Windows.Forms.GroupBox groupBox_OverdueBooks;
        private System.Windows.Forms.Button btn_PrintBooksOverdue;
        private System.Windows.Forms.RadioButton rdbtn_Overduebymorethan3days;
        private System.Windows.Forms.RadioButton rdbtn_Overdueby3days;
        private System.Windows.Forms.RadioButton rdbtn_Overdueby1day;
        private System.Windows.Forms.RadioButton rdbtn_Availability;
        private System.Windows.Forms.RadioButton rdbtn_Category;
    }
}
