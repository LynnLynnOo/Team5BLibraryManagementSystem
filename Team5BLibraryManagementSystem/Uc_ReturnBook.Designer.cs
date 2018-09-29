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
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(303, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LoanDetail ID";
            // 
            // text_Loanid
            // 
            this.text_Loanid.Location = new System.Drawing.Point(451, 133);
            this.text_Loanid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_Loanid.Name = "text_Loanid";
            this.text_Loanid.Size = new System.Drawing.Size(148, 26);
            this.text_Loanid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(303, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book ID";
            // 
            // text_Bookid
            // 
            this.text_Bookid.Location = new System.Drawing.Point(451, 206);
            this.text_Bookid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_Bookid.Name = "text_Bookid";
            this.text_Bookid.Size = new System.Drawing.Size(148, 26);
            this.text_Bookid.TabIndex = 3;
            // 
            // but_Return
            // 
            this.but_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Return.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.but_Return.Location = new System.Drawing.Point(451, 326);
            this.but_Return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_Return.Name = "but_Return";
            this.but_Return.Size = new System.Drawing.Size(112, 38);
            this.but_Return.TabIndex = 4;
            this.but_Return.Text = "Return";
            this.but_Return.UseVisualStyleBackColor = true;
            this.but_Return.Click += new System.EventHandler(this.but_Return_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(370, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 33);
            this.label9.TabIndex = 67;
            this.label9.Text = "Return Books";
            // 
            // Uc_ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.but_Return);
            this.Controls.Add(this.text_Bookid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Loanid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Uc_ReturnBook";
            this.Size = new System.Drawing.Size(882, 517);
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
        private System.Windows.Forms.Label label9;
    }
}
