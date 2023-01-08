namespace My_Notes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.AddCategory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddCategoryText = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.CBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteCategory = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.NewCategoryTextBox = new System.Windows.Forms.TextBox();
            this.OldCategoryBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ContentBox = new System.Windows.Forms.RichTextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteNote = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(473, 176);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(491, 41);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(172, 29);
            this.ViewButton.TabIndex = 11;
            this.ViewButton.Text = "View Content";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(436, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Category";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(430, 204);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.AddCategory);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.AddCategoryText);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(392, 171);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Add Category";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(277, 10);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(94, 29);
            this.AddCategory.TabIndex = 3;
            this.AddCategory.Text = "Add";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Category Name :";
            // 
            // AddCategoryText
            // 
            this.AddCategoryText.Location = new System.Drawing.Point(125, 10);
            this.AddCategoryText.Name = "AddCategoryText";
            this.AddCategoryText.Size = new System.Drawing.Size(137, 27);
            this.AddCategoryText.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.CBox);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.DeleteCategory);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(392, 171);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Delete Category ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // CBox
            // 
            this.CBox.FormattingEnabled = true;
            this.CBox.Location = new System.Drawing.Point(78, 17);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(151, 28);
            this.CBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Category :";
            // 
            // DeleteCategory
            // 
            this.DeleteCategory.Location = new System.Drawing.Point(235, 16);
            this.DeleteCategory.Name = "DeleteCategory";
            this.DeleteCategory.Size = new System.Drawing.Size(94, 29);
            this.DeleteCategory.TabIndex = 0;
            this.DeleteCategory.Text = "Delete";
            this.DeleteCategory.UseVisualStyleBackColor = true;
            this.DeleteCategory.Click += new System.EventHandler(this.DeleteCategory_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.EditButton);
            this.tabPage6.Controls.Add(this.NewCategoryTextBox);
            this.tabPage6.Controls.Add(this.OldCategoryBox);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(422, 171);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Edit Category";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // NewCategoryTextBox
            // 
            this.NewCategoryTextBox.Location = new System.Drawing.Point(116, 82);
            this.NewCategoryTextBox.Name = "NewCategoryTextBox";
            this.NewCategoryTextBox.Size = new System.Drawing.Size(226, 27);
            this.NewCategoryTextBox.TabIndex = 3;
            // 
            // OldCategoryBox
            // 
            this.OldCategoryBox.FormattingEnabled = true;
            this.OldCategoryBox.Location = new System.Drawing.Point(116, 30);
            this.OldCategoryBox.Name = "OldCategoryBox";
            this.OldCategoryBox.Size = new System.Drawing.Size(226, 28);
            this.OldCategoryBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "New Category :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Old Category :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SearchBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.SearchButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dtp);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(53, 6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(176, 27);
            this.SearchBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Title :";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(203, 77);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 29);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date :";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(54, 44);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(243, 27);
            this.dtp.TabIndex = 10;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 207);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 243);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ContentBox);
            this.tabPage1.Controls.Add(this.TitleBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AddButton);
            this.tabPage1.Controls.Add(this.CategoryBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(87, 80);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(321, 76);
            this.ContentBox.TabIndex = 2;
            this.ContentBox.Text = "";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(87, 13);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(321, 27);
            this.TitleBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title :";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(314, 175);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(87, 46);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(321, 28);
            this.CategoryBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category :";
            // 
            // DeleteNote
            // 
            this.DeleteNote.Location = new System.Drawing.Point(491, 92);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(172, 29);
            this.DeleteNote.TabIndex = 4;
            this.DeleteNote.Text = "Delete Note";
            this.DeleteNote.UseVisualStyleBackColor = true;
            this.DeleteNote.Click += new System.EventHandler(this.DeleteNote_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(491, 142);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(172, 29);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click_1);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(248, 115);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 29);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 483);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.DeleteNote);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "My Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button ViewButton;
        private TabPage tabPage3;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage2;
        private TextBox SearchBox;
        private Label label3;
        private Button SearchButton;
        private Label label4;
        private DateTimePicker dtp;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox TitleBox;
        private RichTextBox ContentBox;
        private Button AddButton;
        private ComboBox CategoryBox;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox AddCategoryText;
        private Button AddCategory;
        private ComboBox CBox;
        private Label label6;
        private Button DeleteCategory;
        private Button DeleteNote;
        private Button ResetButton;
        private TabPage tabPage6;
        private Label label8;
        private Label label7;
        private TextBox NewCategoryTextBox;
        private ComboBox OldCategoryBox;
        private Button EditButton;
    }
}