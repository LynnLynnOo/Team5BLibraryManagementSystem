namespace Team5BLibraryManagementSystem
{
    partial class Frm_BookListingByAvailability
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
            this.crv_BookListingByAvailiability = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_BookListingByAvailiability
            // 
            this.crv_BookListingByAvailiability.ActiveViewIndex = -1;
            this.crv_BookListingByAvailiability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_BookListingByAvailiability.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_BookListingByAvailiability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_BookListingByAvailiability.Location = new System.Drawing.Point(0, 0);
            this.crv_BookListingByAvailiability.Name = "crv_BookListingByAvailiability";
            this.crv_BookListingByAvailiability.Size = new System.Drawing.Size(800, 450);
            this.crv_BookListingByAvailiability.TabIndex = 0;
            this.crv_BookListingByAvailiability.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_BookListingByAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_BookListingByAvailiability);
            this.Name = "Frm_BookListingByAvailability";
            this.Text = "Frm_BookListingByAvailability";
            this.Load += new System.EventHandler(this.Frm_BookListingByAvailability_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_BookListingByAvailiability;
    }
}