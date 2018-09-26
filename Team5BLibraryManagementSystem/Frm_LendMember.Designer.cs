namespace Team5BLibraryManagementSystem
{
    partial class For_Lend_Member
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
            this.butMememberOK.Location = new System.Drawing.Point(335, 279);
            this.butMememberOK.Name = "butMememberOK";
            this.butMememberOK.Size = new System.Drawing.Size(75, 23);
            this.butMememberOK.TabIndex = 5;
            this.butMememberOK.Text = "OK";
            this.butMememberOK.UseVisualStyleBackColor = true;
            // 
            // dataMembers
            // 
            this.dataMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMembers.Location = new System.Drawing.Point(248, 96);
            this.dataMembers.Name = "dataMembers";
            this.dataMembers.RowTemplate.Height = 23;
            this.dataMembers.Size = new System.Drawing.Size(240, 150);
            this.dataMembers.TabIndex = 4;
            // 
            // For_Lend_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 399);
            this.Controls.Add(this.butMememberOK);
            this.Controls.Add(this.dataMembers);
            this.Name = "For_Lend_Member";
            this.Text = "For_Lend_Member";
            ((System.ComponentModel.ISupportInitialize)(this.dataMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butMememberOK;
        private System.Windows.Forms.DataGridView dataMembers;
    }
}