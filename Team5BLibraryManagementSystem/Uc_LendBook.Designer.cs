namespace Team5BLibraryManagementSystem
{
    partial class Uc_LendBook
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
            this.label2 = new System.Windows.Forms.Label();
            this.date_Due = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_Issue = new System.Windows.Forms.DateTimePicker();
            this.textbox_BookID = new System.Windows.Forms.TextBox();
            this.textbox_MemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butLend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(248, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Memember ID";
            // 
            // date_Due
            // 
            this.date_Due.Enabled = false;
            this.date_Due.Location = new System.Drawing.Point(423, 294);
            this.date_Due.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date_Due.Name = "date_Due";
            this.date_Due.Size = new System.Drawing.Size(298, 26);
            this.date_Due.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(248, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(248, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Date Of Issue";
            // 
            // date_Issue
            // 
            this.date_Issue.Enabled = false;
            this.date_Issue.Location = new System.Drawing.Point(423, 229);
            this.date_Issue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.date_Issue.Name = "date_Issue";
            this.date_Issue.Size = new System.Drawing.Size(298, 26);
            this.date_Issue.TabIndex = 3;
            // 
            // textbox_BookID
            // 
            this.textbox_BookID.Location = new System.Drawing.Point(423, 164);
            this.textbox_BookID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_BookID.Name = "textbox_BookID";
            this.textbox_BookID.Size = new System.Drawing.Size(148, 26);
            this.textbox_BookID.TabIndex = 2;
            // 
            // textbox_MemberID
            // 
            this.textbox_MemberID.Location = new System.Drawing.Point(423, 99);
            this.textbox_MemberID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_MemberID.Name = "textbox_MemberID";
            this.textbox_MemberID.Size = new System.Drawing.Size(148, 26);
            this.textbox_MemberID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(248, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Book ID";
            // 
            // butLend
            // 
            this.butLend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butLend.Location = new System.Drawing.Point(423, 359);
            this.butLend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butLend.Name = "butLend";
            this.butLend.Size = new System.Drawing.Size(112, 38);
            this.butLend.TabIndex = 5;
            this.butLend.Text = "Lend";
            this.butLend.UseVisualStyleBackColor = true;
            this.butLend.Click += new System.EventHandler(this.butLend_Click);
            // 
            // Uc_LendBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_Due);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_Issue);
            this.Controls.Add(this.textbox_BookID);
            this.Controls.Add(this.textbox_MemberID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butLend);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Uc_LendBook";
            this.Size = new System.Drawing.Size(882, 517);
            this.Load += new System.EventHandler(this.Uc_LendBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_Due;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_Issue;
        private System.Windows.Forms.TextBox textbox_BookID;
        private System.Windows.Forms.TextBox textbox_MemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butLend;
    }
}
