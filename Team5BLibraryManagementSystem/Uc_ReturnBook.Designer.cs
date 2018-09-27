namespace Team5BLibraryManagementSystem
{
    partial class Uc_ReturnBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_Loanid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Bookid = new System.Windows.Forms.TextBox();
            this.but_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "LoanDetail ID";
            // 
            // text_Loanid
            // 
            this.text_Loanid.Location = new System.Drawing.Point(213, 75);
            this.text_Loanid.Name = "text_Loanid";
            this.text_Loanid.Size = new System.Drawing.Size(100, 21);
            this.text_Loanid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book ID";
            // 
            // text_Bookid
            // 
            this.text_Bookid.Location = new System.Drawing.Point(213, 119);
            this.text_Bookid.Name = "text_Bookid";
            this.text_Bookid.Size = new System.Drawing.Size(100, 21);
            this.text_Bookid.TabIndex = 3;
            // 
            // but_Return
            // 
            this.but_Return.Location = new System.Drawing.Point(213, 191);
            this.but_Return.Name = "but_Return";
            this.but_Return.Size = new System.Drawing.Size(75, 23);
            this.but_Return.TabIndex = 4;
            this.but_Return.Text = "Return";
            this.but_Return.UseVisualStyleBackColor = true;
            this.but_Return.Click += new System.EventHandler(this.but_Return_Click);
            // 
            // Uc_ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.but_Return);
            this.Controls.Add(this.text_Bookid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Loanid);
            this.Controls.Add(this.label1);
            this.Name = "Uc_ReturnBook";
            this.Size = new System.Drawing.Size(564, 381);
            this.Load += new System.EventHandler(this.Uc_ReturnBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Loanid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Bookid;
        private System.Windows.Forms.Button but_Return;
    }
}
