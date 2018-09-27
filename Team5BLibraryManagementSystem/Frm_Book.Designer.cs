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
            this.uc_Researchbook1 = new Team5BLibraryManagementSystem.Uc_Researchbook();
            this.SuspendLayout();
            // 
            // uc_Researchbook1
            // 
            this.uc_Researchbook1.Location = new System.Drawing.Point(50, 12);
            this.uc_Researchbook1.Name = "uc_Researchbook1";
            this.uc_Researchbook1.Size = new System.Drawing.Size(564, 381);
            this.uc_Researchbook1.TabIndex = 0;
            this.uc_Researchbook1.Load += new System.EventHandler(this.uc_Researchbook1_Load);
            // 
            // Frm_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 399);
            this.Controls.Add(this.uc_Researchbook1);
            this.Name = "Frm_Book";
            this.Text = "Frm_Book";
            this.ResumeLayout(false);

        }

        #endregion

        private Uc_Researchbook uc_Researchbook1;
    }
}