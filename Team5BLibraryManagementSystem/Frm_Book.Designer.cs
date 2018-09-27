namespace Team5BLibraryManagementSystem
{
    partial class Frm_Book
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
            this.uc_ReturnBook1 = new Team5BLibraryManagementSystem.Uc_ReturnBook();
            this.SuspendLayout();
            // 
            // uc_ReturnBook1
            // 
            this.uc_ReturnBook1.Location = new System.Drawing.Point(77, 6);
            this.uc_ReturnBook1.Name = "uc_ReturnBook1";
            this.uc_ReturnBook1.Size = new System.Drawing.Size(564, 381);
            this.uc_ReturnBook1.TabIndex = 0;
            // 
            // Frm_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 399);
            this.Controls.Add(this.uc_ReturnBook1);
            this.Name = "Frm_Book";
            this.Text = "Frm_Book";
            this.ResumeLayout(false);

        }

        #endregion

        private Uc_ReturnBook uc_ReturnBook1;
    }
}