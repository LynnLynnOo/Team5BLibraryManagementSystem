﻿namespace Team5BLibraryManagementSystem
{
    partial class Frm_MemberListing
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
            this.crv_MemberListing = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_MemberListing
            // 
            this.crv_MemberListing.ActiveViewIndex = -1;
            this.crv_MemberListing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_MemberListing.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_MemberListing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_MemberListing.Location = new System.Drawing.Point(0, 0);
            this.crv_MemberListing.Name = "crv_MemberListing";
            this.crv_MemberListing.Size = new System.Drawing.Size(800, 450);
            this.crv_MemberListing.TabIndex = 0;
            this.crv_MemberListing.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_MemberListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_MemberListing);
            this.Name = "Frm_MemberListing";
            this.Text = "Frm_MemberListing";
            this.Load += new System.EventHandler(this.Frm_MemberListing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_MemberListing;
    }
}