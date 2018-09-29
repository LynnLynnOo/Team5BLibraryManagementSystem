namespace Team5BLibraryManagementSystem
{
    partial class Frm_LoanAck
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
            this.crv_LoanAck = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_LoanAck
            // 
            this.crv_LoanAck.ActiveViewIndex = -1;
            this.crv_LoanAck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_LoanAck.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.crv_LoanAck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_LoanAck.Location = new System.Drawing.Point(0, 0);
            this.crv_LoanAck.Name = "crv_LoanAck";
            this.crv_LoanAck.Size = new System.Drawing.Size(800, 450);
            this.crv_LoanAck.TabIndex = 0;
            this.crv_LoanAck.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv_LoanAck.UseWaitCursor = true;
            // 
            // Frm_LoanAck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_LoanAck);
            this.Name = "Frm_LoanAck";
            this.Text = "Frm_LoanAck";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Frm_LoanAck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_LoanAck;
    }
}