namespace Team5BLibraryManagementSystem
{
    partial class Uc_Addbook
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
            this.text_Isbn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPublisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butFind = new System.Windows.Forms.Button();
            this.text_find = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butInsert = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textBookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_Bookdetail = new System.Windows.Forms.TextBox();
            this.text_Quantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.but_Minus = new System.Windows.Forms.Button();
            this.but_Plus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_Isbn
            // 
            this.text_Isbn.Location = new System.Drawing.Point(236, 205);
            this.text_Isbn.Name = "text_Isbn";
            this.text_Isbn.Size = new System.Drawing.Size(100, 21);
            this.text_Isbn.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 55;
            this.label6.Text = "Isbn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textPublisher
            // 
            this.textPublisher.Location = new System.Drawing.Point(236, 151);
            this.textPublisher.Name = "textPublisher";
            this.textPublisher.Size = new System.Drawing.Size(100, 21);
            this.textPublisher.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 53;
            this.label5.Text = "Genre";
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(236, 121);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(100, 21);
            this.textGenre.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 51;
            this.label4.Text = "Publisher";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butFind);
            this.groupBox1.Controls.Add(this.text_find);
            this.groupBox1.Location = new System.Drawing.Point(98, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 54);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(163, 27);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(75, 23);
            this.butFind.TabIndex = 10;
            this.butFind.Text = "Find";
            this.butFind.UseVisualStyleBackColor = true;
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // text_find
            // 
            this.text_find.Location = new System.Drawing.Point(69, 27);
            this.text_find.Name = "text_find";
            this.text_find.Size = new System.Drawing.Size(73, 21);
            this.text_find.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(471, 327);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 23);
            this.button8.TabIndex = 49;
            this.button8.Text = ">>";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(61, 323);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 23);
            this.button7.TabIndex = 48;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(471, 296);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 23);
            this.button6.TabIndex = 47;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(61, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 23);
            this.button5.TabIndex = 46;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(331, 267);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 45;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(223, 267);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(75, 23);
            this.butInsert.TabIndex = 44;
            this.butInsert.Text = "Insert";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(117, 267);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(75, 23);
            this.butUpdate.TabIndex = 43;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "Title";
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(236, 94);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(100, 21);
            this.textAuthor.TabIndex = 38;
            // 
            // textBookName
            // 
            this.textBookName.Location = new System.Drawing.Point(236, 67);
            this.textBookName.Name = "textBookName";
            this.textBookName.Size = new System.Drawing.Size(100, 21);
            this.textBookName.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 57;
            this.label7.Text = "Publish Year";
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Items.AddRange(new object[] {
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.comboBox_year.Location = new System.Drawing.Point(236, 179);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(100, 20);
            this.comboBox_year.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 61;
            this.label9.Text = "Bookdetail ID";
            // 
            // text_Bookdetail
            // 
            this.text_Bookdetail.Location = new System.Drawing.Point(236, 37);
            this.text_Bookdetail.Name = "text_Bookdetail";
            this.text_Bookdetail.Size = new System.Drawing.Size(100, 21);
            this.text_Bookdetail.TabIndex = 62;
            // 
            // text_Quantity
            // 
            this.text_Quantity.Location = new System.Drawing.Point(261, 230);
            this.text_Quantity.Name = "text_Quantity";
            this.text_Quantity.Size = new System.Drawing.Size(48, 21);
            this.text_Quantity.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 59;
            this.label8.Text = "Quantity";
            // 
            // but_Minus
            // 
            this.but_Minus.Location = new System.Drawing.Point(236, 229);
            this.but_Minus.Name = "but_Minus";
            this.but_Minus.Size = new System.Drawing.Size(19, 23);
            this.but_Minus.TabIndex = 63;
            this.but_Minus.Text = "-";
            this.but_Minus.UseVisualStyleBackColor = true;
            this.but_Minus.Click += new System.EventHandler(this.but_Minus_Click);
            // 
            // but_Plus
            // 
            this.but_Plus.Location = new System.Drawing.Point(315, 230);
            this.but_Plus.Name = "but_Plus";
            this.but_Plus.Size = new System.Drawing.Size(19, 23);
            this.but_Plus.TabIndex = 64;
            this.but_Plus.Text = "+";
            this.but_Plus.UseVisualStyleBackColor = true;
            this.but_Plus.Click += new System.EventHandler(this.but_Plus_Click);
            // 
            // Uc_Addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.but_Plus);
            this.Controls.Add(this.but_Minus);
            this.Controls.Add(this.text_Bookdetail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text_Quantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_Isbn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPublisher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textBookName);
            this.Name = "Uc_Addbook";
            this.Size = new System.Drawing.Size(564, 381);
            this.Load += new System.EventHandler(this.Uc_Addbook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Isbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.TextBox text_find;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textBookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_Bookdetail;
        private System.Windows.Forms.TextBox text_Quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but_Minus;
        private System.Windows.Forms.Button but_Plus;
    }
}
