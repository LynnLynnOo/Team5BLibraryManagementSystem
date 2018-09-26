namespace Team5BLibraryManagementSystem
{
    partial class For_Lend_Book
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
            this.butBookOK = new System.Windows.Forms.Button();
            this.dataBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).BeginInit();
            this.SuspendLayout();
            // 
            // butBookOK
            // 
            this.butBookOK.Location = new System.Drawing.Point(325, 299);
            this.butBookOK.Name = "butBookOK";
            this.butBookOK.Size = new System.Drawing.Size(75, 23);
            this.butBookOK.TabIndex = 7;
            this.butBookOK.Text = "OK";
            this.butBookOK.UseVisualStyleBackColor = true;
            // 
            // dataBook
            // 
            this.dataBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBook.Location = new System.Drawing.Point(205, 77);
            this.dataBook.Name = "dataBook";
            this.dataBook.RowTemplate.Height = 23;
            this.dataBook.Size = new System.Drawing.Size(327, 181);
            this.dataBook.TabIndex = 6;
            // 
            // For_Lend_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 399);
            this.Controls.Add(this.butBookOK);
            this.Controls.Add(this.dataBook);
            this.Name = "For_Lend_Book";
            this.Text = "For_Lend_Book";
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butBookOK;
        private System.Windows.Forms.DataGridView dataBook;
    }
}