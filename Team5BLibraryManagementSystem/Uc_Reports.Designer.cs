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
            this.groupBox_MemberListing = new System.Windows.Forms.GroupBox();
            this.btn_PrintMemberListing = new System.Windows.Forms.Button();
            this.rdbtn_Membersbeforeexpiry = new System.Windows.Forms.RadioButton();
            this.rdbtn_Allmembers = new System.Windows.Forms.RadioButton();
            this.rdbtn_Membersafterexpiry = new System.Windows.Forms.RadioButton();
            this.groupBox_BookList = new System.Windows.Forms.GroupBox();
            this.rdbtn_Availability = new System.Windows.Forms.RadioButton();
            this.rdbtn_Category = new System.Windows.Forms.RadioButton();
            this.btn_BookList = new System.Windows.Forms.Button();
            this.groupBox_MemberListing.SuspendLayout();
            this.groupBox_BookList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Typesofreport
            // 
            this.label_Typesofreport.AutoSize = true;
            this.label_Typesofreport.BackColor = System.Drawing.Color.White;
            this.label_Typesofreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Typesofreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Typesofreport.Location = new System.Drawing.Point(374, 99);
            this.label_Typesofreport.Name = "label_Typesofreport";
            this.label_Typesofreport.Size = new System.Drawing.Size(130, 17);
            this.label_Typesofreport.TabIndex = 0;
            this.label_Typesofreport.Text = "Types of Report:";
            // 
            // cmb_Typesofreport
            // 
            this.cmb_Typesofreport.BackColor = System.Drawing.Color.White;
            this.cmb_Typesofreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Typesofreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmb_Typesofreport.FormattingEnabled = true;
            this.cmb_Typesofreport.Items.AddRange(new object[] {
            "Book List",
            "Member List"});
            this.cmb_Typesofreport.Location = new System.Drawing.Point(520, 99);
            this.cmb_Typesofreport.Name = "cmb_Typesofreport";
            this.cmb_Typesofreport.Size = new System.Drawing.Size(297, 24);
            this.cmb_Typesofreport.TabIndex = 1;
            this.cmb_Typesofreport.SelectedIndexChanged += new System.EventHandler(this.cmb_Typesofreport_SelectedIndexChanged);
            // 
            // groupBox_MemberListing
            // 
            this.groupBox_MemberListing.BackColor = System.Drawing.Color.White;
            this.groupBox_MemberListing.Controls.Add(this.btn_PrintMemberListing);
            this.groupBox_MemberListing.Controls.Add(this.rdbtn_Membersbeforeexpiry);
            this.groupBox_MemberListing.Controls.Add(this.rdbtn_Allmembers);
            this.groupBox_MemberListing.Controls.Add(this.rdbtn_Membersafterexpiry);
            this.groupBox_MemberListing.Location = new System.Drawing.Point(474, 192);
            this.groupBox_MemberListing.Name = "groupBox_MemberListing";
            this.groupBox_MemberListing.Size = new System.Drawing.Size(295, 195);
            this.groupBox_MemberListing.TabIndex = 3;
            this.groupBox_MemberListing.TabStop = false;
            this.groupBox_MemberListing.Visible = false;
            // 
            // btn_PrintMemberListing
            // 
            this.btn_PrintMemberListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintMemberListing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_PrintMemberListing.Location = new System.Drawing.Point(89, 123);
            this.btn_PrintMemberListing.Name = "btn_PrintMemberListing";
            this.btn_PrintMemberListing.Size = new System.Drawing.Size(115, 48);
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
            this.rdbtn_Membersbeforeexpiry.Location = new System.Drawing.Point(31, 31);
            this.rdbtn_Membersbeforeexpiry.Name = "rdbtn_Membersbeforeexpiry";
            this.rdbtn_Membersbeforeexpiry.Size = new System.Drawing.Size(235, 21);
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
            this.rdbtn_Allmembers.Location = new System.Drawing.Point(31, 85);
            this.rdbtn_Allmembers.Name = "rdbtn_Allmembers";
            this.rdbtn_Allmembers.Size = new System.Drawing.Size(117, 21);
            this.rdbtn_Allmembers.TabIndex = 3;
            this.rdbtn_Allmembers.Text = "All Members";
            this.rdbtn_Allmembers.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Membersafterexpiry
            // 
            this.rdbtn_Membersafterexpiry.AutoSize = true;
            this.rdbtn_Membersafterexpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Membersafterexpiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtn_Membersafterexpiry.Location = new System.Drawing.Point(31, 58);
            this.rdbtn_Membersafterexpiry.Name = "rdbtn_Membersafterexpiry";
            this.rdbtn_Membersafterexpiry.Size = new System.Drawing.Size(222, 21);
            this.rdbtn_Membersafterexpiry.TabIndex = 2;
            this.rdbtn_Membersafterexpiry.Text = "Members After Expiry Date";
            this.rdbtn_Membersafterexpiry.UseVisualStyleBackColor = true;
            // 
            // groupBox_BookList
            // 
            this.groupBox_BookList.Controls.Add(this.rdbtn_Availability);
            this.groupBox_BookList.Controls.Add(this.rdbtn_Category);
            this.groupBox_BookList.Controls.Add(this.btn_BookList);
            this.groupBox_BookList.Location = new System.Drawing.Point(480, 185);
            this.groupBox_BookList.Name = "groupBox_BookList";
            this.groupBox_BookList.Size = new System.Drawing.Size(283, 178);
            this.groupBox_BookList.TabIndex = 4;
            this.groupBox_BookList.TabStop = false;
            this.groupBox_BookList.Visible = false;
            // 
            // rdbtn_Availability
            // 
            this.rdbtn_Availability.AutoSize = true;
            this.rdbtn_Availability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Availability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbtn_Availability.Location = new System.Drawing.Point(24, 56);
            this.rdbtn_Availability.Name = "rdbtn_Availability";
            this.rdbtn_Availability.Size = new System.Drawing.Size(232, 21);
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
            this.rdbtn_Category.Location = new System.Drawing.Point(24, 27);
            this.rdbtn_Category.Name = "rdbtn_Category";
            this.rdbtn_Category.Size = new System.Drawing.Size(219, 21);
            this.rdbtn_Category.TabIndex = 1;
            this.rdbtn_Category.TabStop = true;
            this.rdbtn_Category.Text = "Books Listing By Category";
            this.rdbtn_Category.UseVisualStyleBackColor = true;
            // 
            // btn_BookList
            // 
            this.btn_BookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_BookList.Location = new System.Drawing.Point(77, 99);
            this.btn_BookList.Name = "btn_BookList";
            this.btn_BookList.Size = new System.Drawing.Size(115, 48);
            this.btn_BookList.TabIndex = 3;
            this.btn_BookList.Text = "Print";
            this.btn_BookList.UseVisualStyleBackColor = true;
            this.btn_BookList.Click += new System.EventHandler(this.btn_BookList_Click);
            // 
            // Uc_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmb_Typesofreport);
            this.Controls.Add(this.label_Typesofreport);
            this.Controls.Add(this.groupBox_BookList);
            this.Controls.Add(this.groupBox_MemberListing);
            this.Name = "Uc_Reports";
            this.Size = new System.Drawing.Size(1092, 520);
            this.groupBox_MemberListing.ResumeLayout(false);
            this.groupBox_MemberListing.PerformLayout();
            this.groupBox_BookList.ResumeLayout(false);
            this.groupBox_BookList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Typesofreport;
        private System.Windows.Forms.ComboBox cmb_Typesofreport;
        private System.Windows.Forms.GroupBox groupBox_MemberListing;
        private System.Windows.Forms.RadioButton rdbtn_Membersbeforeexpiry;
        private System.Windows.Forms.RadioButton rdbtn_Allmembers;
        private System.Windows.Forms.RadioButton rdbtn_Membersafterexpiry;
        private System.Windows.Forms.Button btn_PrintMemberListing;
        private System.Windows.Forms.GroupBox groupBox_BookList;
        private System.Windows.Forms.Button btn_BookList;
        private System.Windows.Forms.RadioButton rdbtn_Availability;
        private System.Windows.Forms.RadioButton rdbtn_Category;
    }
}
