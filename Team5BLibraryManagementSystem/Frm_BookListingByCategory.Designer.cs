namespace Team5BLibraryManagementSystem
{
    partial class Frm_BookListingByCategory
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
            this.crv_BookListingByCategory = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_BookListingByCategory
            // 
            this.crv_BookListingByCategory.ActiveViewIndex = -1;
            this.crv_BookListingByCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_BookListingByCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_BookListingByCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_BookListingByCategory.Location = new System.Drawing.Point(0, 0);
            this.crv_BookListingByCategory.Name = "crv_BookListingByCategory";
            this.crv_BookListingByCategory.Size = new System.Drawing.Size(800, 450);
            this.crv_BookListingByCategory.TabIndex = 0;
            this.crv_BookListingByCategory.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_BookListingByCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_BookListingByCategory);
            this.Name = "Frm_BookListingByCategory";
            this.Text = "Frm_BookListingByCategory";
            this.Load += new System.EventHandler(this.Frm_BookListingByCategory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_BookListingByCategory;
    }
}