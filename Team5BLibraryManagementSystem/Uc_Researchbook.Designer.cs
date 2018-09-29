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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox_A1 = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.Label();
            this.pictureBox_B1 = new System.Windows.Forms.PictureBox();
            this.B1 = new System.Windows.Forms.Label();
            this.pictureBox_A2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_B2 = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_B2)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Search
            // 
            this.text_Search.Location = new System.Drawing.Point(213, 57);
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(190, 21);
            this.text_Search.TabIndex = 37;
            // 
            // data_Search
            // 
            this.data_Search.BackgroundColor = System.Drawing.Color.White;
            this.data_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Search.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.data_Search.Location = new System.Drawing.Point(17, 111);
            this.data_Search.Name = "data_Search";
            this.data_Search.RowTemplate.Height = 23;
            this.data_Search.Size = new System.Drawing.Size(558, 196);
            this.data_Search.TabIndex = 36;
            this.data_Search.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(137, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search By:";
            // 
            // butSearch
            // 
            this.butSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butSearch.Location = new System.Drawing.Point(418, 42);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
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
            "Location"});
            this.comboBox_Choose.Location = new System.Drawing.Point(213, 33);
            this.comboBox_Choose.Name = "comboBox_Choose";
            this.comboBox_Choose.Size = new System.Drawing.Size(190, 20);
            this.comboBox_Choose.TabIndex = 38;
            this.comboBox_Choose.SelectedIndexChanged += new System.EventHandler(this.comboBox_Choose_SelectedIndexChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.Crimson;
            this.labelSearch.Location = new System.Drawing.Point(210, 81);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(193, 13);
            this.labelSearch.TabIndex = 74;
            this.labelSearch.Text = "*Please key in the search words.";
            this.labelSearch.Visible = false;
            // 
            // pictureBox_A1
            // 
            this.pictureBox_A1.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox_A1.Location = new System.Drawing.Point(102, 130);
            this.pictureBox_A1.Name = "pictureBox_A1";
            this.pictureBox_A1.Size = new System.Drawing.Size(119, 62);
            this.pictureBox_A1.TabIndex = 79;
            this.pictureBox_A1.TabStop = false;
            this.pictureBox_A1.Visible = false;
            this.pictureBox_A1.Click += new System.EventHandler(this.pictureBox_A1_Click);
            this.pictureBox_A1.DoubleClick += new System.EventHandler(this.pictureBox_A1_DoubleClick);
            // 
            // A1
            // 
            this.A1.AutoSize = true;
            this.A1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.A1.Location = new System.Drawing.Point(153, 195);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(17, 12);
            this.A1.TabIndex = 80;
            this.A1.Text = "A1";
            this.A1.Visible = false;
            // 
            // pictureBox_B1
            // 
            this.pictureBox_B1.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox_B1.Location = new System.Drawing.Point(301, 130);
            this.pictureBox_B1.Name = "pictureBox_B1";
            this.pictureBox_B1.Size = new System.Drawing.Size(119, 62);
            this.pictureBox_B1.TabIndex = 81;
            this.pictureBox_B1.TabStop = false;
            this.pictureBox_B1.Visible = false;
            this.pictureBox_B1.Click += new System.EventHandler(this.pictureBox_B1_Click);
            this.pictureBox_B1.DoubleClick += new System.EventHandler(this.pictureBox_B1_DoubleClick);
            // 
            // B1
            // 
            this.B1.AutoSize = true;
            this.B1.Location = new System.Drawing.Point(349, 195);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(17, 12);
            this.B1.TabIndex = 82;
            this.B1.Text = "B1";
            this.B1.Visible = false;
            // 
            // pictureBox_A2
            // 
            this.pictureBox_A2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox_A2.Location = new System.Drawing.Point(102, 219);
            this.pictureBox_A2.Name = "pictureBox_A2";
            this.pictureBox_A2.Size = new System.Drawing.Size(119, 62);
            this.pictureBox_A2.TabIndex = 83;
            this.pictureBox_A2.TabStop = false;
            this.pictureBox_A2.Visible = false;
            this.pictureBox_A2.Click += new System.EventHandler(this.pictureBox_A2_Click);
            this.pictureBox_A2.DoubleClick += new System.EventHandler(this.pictureBox_A2_DoubleClick);
            // 
            // pictureBox_B2
            // 
            this.pictureBox_B2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox_B2.Location = new System.Drawing.Point(301, 219);
            this.pictureBox_B2.Name = "pictureBox_B2";
            this.pictureBox_B2.Size = new System.Drawing.Size(119, 62);
            this.pictureBox_B2.TabIndex = 84;
            this.pictureBox_B2.TabStop = false;
            this.pictureBox_B2.Visible = false;
            this.pictureBox_B2.Click += new System.EventHandler(this.pictureBox_B2_Click);
            this.pictureBox_B2.DoubleClick += new System.EventHandler(this.pictureBox_B2_DoubleClick);
            // 
            // A2
            // 
            this.A2.AutoSize = true;
            this.A2.Location = new System.Drawing.Point(153, 284);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(17, 12);
            this.A2.TabIndex = 85;
            this.A2.Text = "A2";
            this.A2.Visible = false;
            // 
            // B2
            // 
            this.B2.AutoSize = true;
            this.B2.Location = new System.Drawing.Point(349, 284);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(17, 12);
            this.B2.TabIndex = 86;
            this.B2.Text = "B2";
            this.B2.Visible = false;
            // 
            // Uc_Researchbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.pictureBox_B2);
            this.Controls.Add(this.pictureBox_A2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.pictureBox_B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.pictureBox_A1);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.comboBox_Choose);
            this.Controls.Add(this.text_Search);
            this.Controls.Add(this.data_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSearch);
            this.Name = "Uc_Researchbook";
            this.Size = new System.Drawing.Size(588, 310);
            this.Load += new System.EventHandler(this.Uc_Researchbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_B2)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox_A1;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.PictureBox pictureBox_B1;
        private System.Windows.Forms.Label B1;
        private System.Windows.Forms.PictureBox pictureBox_A2;
        private System.Windows.Forms.PictureBox pictureBox_B2;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.Label B2;
    }
}
