namespace Team5BLibraryManagementSystem
{
    partial class Frm_Member
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
            this.butMememberOK = new System.Windows.Forms.Button();
            this.dataMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // butMememberOK
            // 
            this.butMememberOK.Location = new System.Drawing.Point(502, 465);
            this.butMememberOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butMememberOK.Name = "butMememberOK";
            this.butMememberOK.Size = new System.Drawing.Size(112, 38);
            this.butMememberOK.TabIndex = 7;
            this.butMememberOK.Text = "OK";
            this.butMememberOK.UseVisualStyleBackColor = true;
            // 
            // dataMembers
            // 
            this.dataMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMembers.Location = new System.Drawing.Point(372, 160);
            this.dataMembers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataMembers.Name = "dataMembers";
            this.dataMembers.RowTemplate.Height = 23;
            this.dataMembers.Size = new System.Drawing.Size(360, 250);
            this.dataMembers.TabIndex = 6;
            // 
            // Frm_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 665);
            this.Controls.Add(this.butMememberOK);
            this.Controls.Add(this.dataMembers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Member";
            this.Text = "Member List";
            ((System.ComponentModel.ISupportInitialize)(this.dataMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butMememberOK;
        private System.Windows.Forms.DataGridView dataMembers;
    }
}