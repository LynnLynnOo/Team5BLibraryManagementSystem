﻿namespace Team5BLibraryManagementSystem
{
    partial class Frm_BookListingAll
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
            this.crv_BookListing = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_BookListing
            // 
            this.crv_BookListing.ActiveViewIndex = -1;
            this.crv_BookListing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_BookListing.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_BookListing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_BookListing.Location = new System.Drawing.Point(0, 0);
            this.crv_BookListing.Name = "crv_BookListing";
            this.crv_BookListing.Size = new System.Drawing.Size(800, 450);
            this.crv_BookListing.TabIndex = 0;
            this.crv_BookListing.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_BookListingAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_BookListing);
            this.Name = "Frm_BookListingAll";
            this.Text = "Frm_BookListingAll";
            this.Load += new System.EventHandler(this.Frm_BookListingAll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_BookListing;
    }
}