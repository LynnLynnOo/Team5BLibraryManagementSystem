namespace Team5BLibraryManagementSystem
{
    partial class Frm_MonthlyLoanReport
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
            this.crystalReportViewer_MonthlyLoanReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_MonthlyLoanReport
            // 
            this.crystalReportViewer_MonthlyLoanReport.ActiveViewIndex = -1;
            this.crystalReportViewer_MonthlyLoanReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_MonthlyLoanReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_MonthlyLoanReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_MonthlyLoanReport.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_MonthlyLoanReport.Name = "crystalReportViewer_MonthlyLoanReport";
            this.crystalReportViewer_MonthlyLoanReport.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer_MonthlyLoanReport.TabIndex = 0;
            this.crystalReportViewer_MonthlyLoanReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_MonthlyLoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer_MonthlyLoanReport);
            this.Name = "Frm_MonthlyLoanReport";
            this.Text = "Frm_MonthlyLoanReport";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_MonthlyLoanReport;
    }
}