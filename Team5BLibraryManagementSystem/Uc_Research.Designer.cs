namespace Team5BLibraryManagementSystem
{
    partial class Uc_Research
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.dataRearch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.listSearch = new System.Windows.Forms.ListBox();
            this.butSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRearch)).BeginInit();
            this.SuspendLayout();
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(282, 86);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(100, 21);
            this.textSearch.TabIndex = 37;
            // 
            // dataRearch
            // 
            this.dataRearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRearch.Location = new System.Drawing.Point(120, 151);
            this.dataRearch.Name = "dataRearch";
            this.dataRearch.RowTemplate.Height = 23;
            this.dataRearch.Size = new System.Drawing.Size(291, 177);
            this.dataRearch.TabIndex = 36;
            this.dataRearch.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search By:";
            // 
            // listSearch
            // 
            this.listSearch.FormattingEnabled = true;
            this.listSearch.ItemHeight = 12;
            this.listSearch.Items.AddRange(new object[] {
            "Title",
            "Book ID",
            "Author"});
            this.listSearch.Location = new System.Drawing.Point(133, 86);
            this.listSearch.Name = "listSearch";
            this.listSearch.Size = new System.Drawing.Size(120, 16);
            this.listSearch.TabIndex = 33;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(411, 89);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 34;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // Uc_Research
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.dataRearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listSearch);
            this.Controls.Add(this.butSearch);
            this.Name = "Uc_Research";
            this.Size = new System.Drawing.Size(564, 381);
            ((System.ComponentModel.ISupportInitialize)(this.dataRearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.DataGridView dataRearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listSearch;
        private System.Windows.Forms.Button butSearch;
    }
}
