namespace Team5BLibraryManagementSystem
{
    partial class Uc_Researchbook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_Search = new System.Windows.Forms.TextBox();
            this.data_Search = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.butSearch = new System.Windows.Forms.Button();
            this.comboBox_Choose = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Search
            // 
            this.text_Search.Location = new System.Drawing.Point(319, 95);
            this.text_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(283, 26);
            this.text_Search.TabIndex = 37;
            // 
            // data_Search
            // 
            this.data_Search.BackgroundColor = System.Drawing.Color.White;
            this.data_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Search.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.data_Search.Location = new System.Drawing.Point(26, 176);
            this.data_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_Search.Name = "data_Search";
            this.data_Search.RowTemplate.Height = 23;
            this.data_Search.Size = new System.Drawing.Size(837, 326);
            this.data_Search.TabIndex = 36;
            this.data_Search.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(205, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search By:";
            // 
            // butSearch
            // 
            this.butSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butSearch.Location = new System.Drawing.Point(627, 70);
            this.butSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(112, 38);
            this.butSearch.TabIndex = 34;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // comboBox_Choose
            // 
            this.comboBox_Choose.FormattingEnabled = true;
            this.comboBox_Choose.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Book ID",
            "Publisher",
            "Category",
            "Publisher Year",
            "Isbn",
            "Status",
            ""});
            this.comboBox_Choose.Location = new System.Drawing.Point(319, 55);
            this.comboBox_Choose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Choose.Name = "comboBox_Choose";
            this.comboBox_Choose.Size = new System.Drawing.Size(283, 28);
            this.comboBox_Choose.TabIndex = 38;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.Crimson;
            this.labelSearch.Location = new System.Drawing.Point(315, 126);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(268, 20);
            this.labelSearch.TabIndex = 74;
            this.labelSearch.Text = "*Please key in the search words.";
            // 
            // Uc_Researchbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.comboBox_Choose);
            this.Controls.Add(this.text_Search);
            this.Controls.Add(this.data_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Uc_Researchbook";
            this.Size = new System.Drawing.Size(882, 517);
            this.Load += new System.EventHandler(this.Uc_Researchbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Search;
        private System.Windows.Forms.DataGridView data_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.ComboBox comboBox_Choose;
        private System.Windows.Forms.Label labelSearch;
    }
}
