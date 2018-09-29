namespace Team5BLibraryManagementSystem
{
    partial class Frm_TransactionHist
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
            this.dataGridView_Transactions = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Transactions
            // 
            this.dataGridView_Transactions.AllowUserToResizeRows = false;
            this.dataGridView_Transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Transactions.Location = new System.Drawing.Point(12, 94);
            this.dataGridView_Transactions.Name = "dataGridView_Transactions";
            this.dataGridView_Transactions.RowTemplate.Height = 28;
            this.dataGridView_Transactions.Size = new System.Drawing.Size(860, 344);
            this.dataGridView_Transactions.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(386, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 33);
            this.label10.TabIndex = 71;
            this.label10.Text = "Transaction History ";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.Color.Red;
            this.label_Username.Location = new System.Drawing.Point(13, 51);
            this.label_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(19, 26);
            this.label_Username.TabIndex = 72;
            this.label_Username.Text = " ";
            // 
            // Frm_TransactionHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView_Transactions);
            this.Name = "Frm_TransactionHist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_TransactionHist";
            this.Load += new System.EventHandler(this.Frm_TransactionHist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Transactions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Username;
    }
}