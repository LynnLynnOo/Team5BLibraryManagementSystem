namespace Team5BLibraryManagementSystem
{
    partial class Uc_Lend
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
            this.btuRetirew1 = new System.Windows.Forms.Button();
            this.butRetriew2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.date_Due = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_Issue = new System.Windows.Forms.DateTimePicker();
            this.butReturn = new System.Windows.Forms.Button();
            this.textBookID2 = new System.Windows.Forms.TextBox();
            this.textbox_Bookid = new System.Windows.Forms.TextBox();
            this.textMemberID2 = new System.Windows.Forms.TextBox();
            this.textbox_MemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butLend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btuRetirew1
            // 
            this.btuRetirew1.Location = new System.Drawing.Point(353, 65);
            this.btuRetirew1.Name = "btuRetirew1";
            this.btuRetirew1.Size = new System.Drawing.Size(37, 23);
            this.btuRetirew1.TabIndex = 51;
            this.btuRetirew1.Text = "...";
            this.btuRetirew1.UseVisualStyleBackColor = true;
            // 
            // butRetriew2
            // 
            this.butRetriew2.Location = new System.Drawing.Point(353, 113);
            this.butRetriew2.Name = "butRetriew2";
            this.butRetriew2.Size = new System.Drawing.Size(37, 23);
            this.butRetriew2.TabIndex = 50;
            this.butRetriew2.Text = "...";
            this.butRetriew2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 49;
            this.label2.Text = "Memember ID";
            // 
            // date_Due
            // 
            this.date_Due.Location = new System.Drawing.Point(235, 213);
            this.date_Due.Name = "date_Due";
            this.date_Due.Size = new System.Drawing.Size(200, 21);
            this.date_Due.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 47;
            this.label5.Text = "Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 46;
            this.label4.Text = "Date Of Issue";
            // 
            // date_Issue
            // 
            this.date_Issue.Location = new System.Drawing.Point(235, 177);
            this.date_Issue.Name = "date_Issue";
            this.date_Issue.Size = new System.Drawing.Size(200, 21);
            this.date_Issue.TabIndex = 45;
            // 
            // butReturn
            // 
            this.butReturn.Location = new System.Drawing.Point(285, 277);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(75, 23);
            this.butReturn.TabIndex = 44;
            this.butReturn.Text = "Return";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // textBookID2
            // 
            this.textBookID2.Location = new System.Drawing.Point(235, 140);
            this.textBookID2.Name = "textBookID2";
            this.textBookID2.ReadOnly = true;
            this.textBookID2.Size = new System.Drawing.Size(100, 21);
            this.textBookID2.TabIndex = 41;
            // 
            // textbox_Bookid
            // 
            this.textbox_Bookid.Location = new System.Drawing.Point(235, 113);
            this.textbox_Bookid.Name = "textbox_Bookid";
            this.textbox_Bookid.Size = new System.Drawing.Size(100, 21);
            this.textbox_Bookid.TabIndex = 40;
            // 
            // textMemberID2
            // 
            this.textMemberID2.Location = new System.Drawing.Point(235, 89);
            this.textMemberID2.Name = "textMemberID2";
            this.textMemberID2.ReadOnly = true;
            this.textMemberID2.Size = new System.Drawing.Size(100, 21);
            this.textMemberID2.TabIndex = 39;
            // 
            // textbox_MemberID
            // 
            this.textbox_MemberID.Location = new System.Drawing.Point(235, 62);
            this.textbox_MemberID.Name = "textbox_MemberID";
            this.textbox_MemberID.Size = new System.Drawing.Size(100, 21);
            this.textbox_MemberID.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "Book ID";
            // 
            // butLend
            // 
            this.butLend.Location = new System.Drawing.Point(154, 277);
            this.butLend.Name = "butLend";
            this.butLend.Size = new System.Drawing.Size(75, 23);
            this.butLend.TabIndex = 36;
            this.butLend.Text = "Lend";
            this.butLend.UseVisualStyleBackColor = true;
            this.butLend.Click += new System.EventHandler(this.butLend_Click);
            // 
            // Uc_Lend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btuRetirew1);
            this.Controls.Add(this.butRetriew2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_Due);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_Issue);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.textBookID2);
            this.Controls.Add(this.textbox_Bookid);
            this.Controls.Add(this.textMemberID2);
            this.Controls.Add(this.textbox_MemberID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butLend);
            this.Name = "Uc_Lend";
            this.Size = new System.Drawing.Size(564, 381);
            this.Load += new System.EventHandler(this.Uc_Lend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btuRetirew1;
        private System.Windows.Forms.Button butRetriew2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_Due;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_Issue;
        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.TextBox textBookID2;
        private System.Windows.Forms.TextBox textbox_Bookid;
        private System.Windows.Forms.TextBox textMemberID2;
        private System.Windows.Forms.TextBox textbox_MemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butLend;
    }
}
