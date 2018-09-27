namespace Team5BLibraryManagementSystem
{
    partial class Frm_Sjw
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
            this.uc_Reports1 = new Team5BLibraryManagementSystem.Uc_Reports();
            this.SuspendLayout();
            // 
            // uc_Reports1
            // 
            this.uc_Reports1.Location = new System.Drawing.Point(116, 23);
            this.uc_Reports1.Name = "uc_Reports1";
            this.uc_Reports1.Size = new System.Drawing.Size(752, 508);
            this.uc_Reports1.TabIndex = 0;
            // 
            // Frm_Sjw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 532);
            this.Controls.Add(this.uc_Reports1);
            this.Name = "Frm_Sjw";
            this.Text = "Frm_Sjw";
            this.ResumeLayout(false);

        }

        #endregion

        private Uc_Reports uc_Reports1;
    }
}