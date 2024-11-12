namespace WinFormsApp11
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            tabPage2 = new TabPage();
            AddButton = new Button();
            label4 = new Label();
            GenreBox = new TextBox();
            label3 = new Label();
            YearBox = new TextBox();
            label2 = new Label();
            AuthorBox = new TextBox();
            label1 = new Label();
            NameBox = new TextBox();
            tabPage3 = new TabPage();
            button3 = new Button();
            label8 = new Label();
            ChangeGenre = new TextBox();
            label7 = new Label();
            ChangeYear = new TextBox();
            label6 = new Label();
            label5 = new Label();
            ChangeTitle = new TextBox();
            ChangeAuthor = new TextBox();
            listView3 = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            button1 = new Button();
            tabPage4 = new TabPage();
            button4 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            listView2 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(0, 28);
            tabControl1.Margin = new Padding(2, 4, 2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(763, 560);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(listView1);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Margin = new Padding(2, 4, 2, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 4, 2, 4);
            tabPage1.Size = new Size(755, 526);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Book list";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Info;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            listView1.Location = new Point(-5, -1);
            listView1.Margin = new Padding(2, 4, 2, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(759, 535);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Title";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Author";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Year";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Genre";
            columnHeader4.Width = 150;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightCyan;
            tabPage2.Controls.Add(AddButton);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(GenreBox);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(YearBox);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(AuthorBox);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(NameBox);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Margin = new Padding(2, 4, 2, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 4, 2, 4);
            tabPage2.Size = new Size(755, 526);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add book";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Green;
            AddButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddButton.ForeColor = SystemColors.ActiveCaptionText;
            AddButton.Location = new Point(6, 260);
            AddButton.Margin = new Padding(2, 4, 2, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(230, 47);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add book";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 197);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 7;
            label4.Text = "Book genre";
            // 
            // GenreBox
            // 
            GenreBox.Location = new Point(6, 227);
            GenreBox.Margin = new Padding(2, 4, 2, 4);
            GenreBox.Name = "GenreBox";
            GenreBox.Size = new Size(230, 29);
            GenreBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 134);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 25);
            label3.TabIndex = 5;
            label3.Text = "Year of publication";
            // 
            // YearBox
            // 
            YearBox.Location = new Point(6, 164);
            YearBox.Margin = new Padding(2, 4, 2, 4);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(230, 29);
            YearBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(218, 25);
            label2.TabIndex = 3;
            label2.Text = "The author of the book";
            // 
            // AuthorBox
            // 
            AuthorBox.Location = new Point(6, 101);
            AuthorBox.Margin = new Padding(2, 4, 2, 4);
            AuthorBox.Name = "AuthorBox";
            AuthorBox.Size = new Size(230, 29);
            AuthorBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 1;
            label1.Text = "The title of the book";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(6, 38);
            NameBox.Margin = new Padding(2, 4, 2, 4);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(230, 29);
            NameBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightCyan;
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(ChangeGenre);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(ChangeYear);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(ChangeTitle);
            tabPage3.Controls.Add(ChangeAuthor);
            tabPage3.Controls.Add(listView3);
            tabPage3.Controls.Add(button1);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Margin = new Padding(2, 4, 2, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 4, 2, 4);
            tabPage3.Size = new Size(755, 526);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Edit book";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkKhaki;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button3.Location = new Point(6, 449);
            button3.Margin = new Padding(2, 4, 2, 4);
            button3.Name = "button3";
            button3.Size = new Size(206, 51);
            button3.TabIndex = 16;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(324, 391);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 15;
            label8.Text = "Genre";
            // 
            // ChangeGenre
            // 
            ChangeGenre.Location = new Point(324, 412);
            ChangeGenre.Margin = new Padding(2, 4, 2, 4);
            ChangeGenre.Name = "ChangeGenre";
            ChangeGenre.Size = new Size(100, 29);
            ChangeGenre.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 391);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 13;
            label7.Text = "Year";
            // 
            // ChangeYear
            // 
            ChangeYear.Location = new Point(218, 412);
            ChangeYear.Margin = new Padding(2, 4, 2, 4);
            ChangeYear.Name = "ChangeYear";
            ChangeYear.Size = new Size(100, 29);
            ChangeYear.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 387);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 11;
            label6.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 391);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 10;
            label5.Text = "Title";
            // 
            // ChangeTitle
            // 
            ChangeTitle.Location = new Point(6, 412);
            ChangeTitle.Margin = new Padding(2, 4, 2, 4);
            ChangeTitle.Name = "ChangeTitle";
            ChangeTitle.Size = new Size(100, 29);
            ChangeTitle.TabIndex = 9;
            // 
            // ChangeAuthor
            // 
            ChangeAuthor.Location = new Point(112, 412);
            ChangeAuthor.Margin = new Padding(2, 4, 2, 4);
            ChangeAuthor.Name = "ChangeAuthor";
            ChangeAuthor.Size = new Size(100, 29);
            ChangeAuthor.TabIndex = 8;
            // 
            // listView3
            // 
            listView3.BackColor = SystemColors.Info;
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listView3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            listView3.Location = new Point(-5, -1);
            listView3.Margin = new Padding(2, 4, 2, 4);
            listView3.Name = "listView3";
            listView3.Size = new Size(759, 385);
            listView3.TabIndex = 7;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Title";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Author";
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Year";
            columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Genre";
            columnHeader12.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button1.Location = new Point(585, 449);
            button1.Margin = new Padding(2, 4, 2, 4);
            button1.Name = "button1";
            button1.Size = new Size(161, 51);
            button1.TabIndex = 6;
            button1.Text = "Delete book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.LightCyan;
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(comboBox2);
            tabPage4.Controls.Add(listView2);
            tabPage4.Location = new Point(4, 30);
            tabPage4.Margin = new Padding(2, 4, 2, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2, 4, 2, 4);
            tabPage4.Size = new Size(755, 526);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Search books";
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Location = new Point(599, 459);
            button4.Margin = new Padding(2, 4, 2, 4);
            button4.Name = "button4";
            button4.Size = new Size(152, 64);
            button4.TabIndex = 8;
            button4.Text = "The most popular books";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button2.Location = new Point(8, 459);
            button2.Margin = new Padding(2, 4, 2, 4);
            button2.Name = "button2";
            button2.Size = new Size(121, 67);
            button2.TabIndex = 7;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 426);
            textBox2.Margin = new Padding(2, 4, 2, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 29);
            textBox2.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Title", "Author", "Year", "Genre" });
            comboBox2.Location = new Point(8, 394);
            comboBox2.Margin = new Padding(2, 4, 2, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 29);
            comboBox2.TabIndex = 5;
            // 
            // listView2
            // 
            listView2.BackColor = SystemColors.Info;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            listView2.Location = new Point(-4, 0);
            listView2.Margin = new Padding(2, 4, 2, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(759, 383);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Title";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Author";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Year";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Genre";
            columnHeader8.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, loadToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(761, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(62, 20);
            fileToolStripMenuItem.Text = "Save file";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(64, 20);
            loadToolStripMenuItem.Text = "Load file";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 585);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 4, 2, 4);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ListView listView1;
        private Label label4;
        private TextBox GenreBox;
        private Label label3;
        private TextBox YearBox;
        private Label label2;
        private TextBox AuthorBox;
        private Label label1;
        private TextBox NameBox;
        private Button AddButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button2;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private ListView listView2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button button1;
        private ListView listView3;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Label label6;
        private Label label5;
        private TextBox ChangeTitle;
        private TextBox ChangeAuthor;
        private Label label8;
        private TextBox ChangeGenre;
        private Label label7;
        private TextBox ChangeYear;
        private Button button3;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
    }
}
