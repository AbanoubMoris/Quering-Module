namespace Quering_module
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TablePnl = new System.Windows.Forms.Panel();
            this.Tbl = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Buttons_pnl_Sliding = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QueryPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.assign_lbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.Comparision_compobox = new System.Windows.Forms.ComboBox();
            this.bool_Compobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Aggregate_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResPnl = new System.Windows.Forms.Panel();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.ExitPic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.TablePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl)).BeginInit();
            this.Buttons_pnl_Sliding.SuspendLayout();
            this.QueryPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ResPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablePnl
            // 
            this.TablePnl.Controls.Add(this.Tbl);
            this.TablePnl.Controls.Add(this.comboBox1);
            this.TablePnl.Controls.Add(this.label1);
            this.TablePnl.Location = new System.Drawing.Point(253, 50);
            this.TablePnl.Margin = new System.Windows.Forms.Padding(4);
            this.TablePnl.Name = "TablePnl";
            this.TablePnl.Size = new System.Drawing.Size(818, 542);
            this.TablePnl.TabIndex = 0;
            // 
            // Tbl
            // 
            this.Tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl.Location = new System.Drawing.Point(46, 145);
            this.Tbl.Margin = new System.Windows.Forms.Padding(4);
            this.Tbl.Name = "Tbl";
            this.Tbl.Size = new System.Drawing.Size(738, 364);
            this.Tbl.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "product",
            "Employees",
            "Departments",
            "cars"});
            this.comboBox1.Location = new System.Drawing.Point(322, 69);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Table";
            // 
            // Buttons_pnl_Sliding
            // 
            this.Buttons_pnl_Sliding.Controls.Add(this.button3);
            this.Buttons_pnl_Sliding.Controls.Add(this.button2);
            this.Buttons_pnl_Sliding.Controls.Add(this.button1);
            this.Buttons_pnl_Sliding.Location = new System.Drawing.Point(0, 50);
            this.Buttons_pnl_Sliding.Margin = new System.Windows.Forms.Padding(4);
            this.Buttons_pnl_Sliding.Name = "Buttons_pnl_Sliding";
            this.Buttons_pnl_Sliding.Size = new System.Drawing.Size(234, 555);
            this.Buttons_pnl_Sliding.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(4, 254);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Result";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(4, 194);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Types of query";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(4, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // QueryPnl
            // 
            this.QueryPnl.Controls.Add(this.label2);
            this.QueryPnl.Controls.Add(this.label9);
            this.QueryPnl.Controls.Add(this.clearButton);
            this.QueryPnl.Controls.Add(this.comboBox3);
            this.QueryPnl.Controls.Add(this.panel1);
            this.QueryPnl.Controls.Add(this.panel3);
            this.QueryPnl.Controls.Add(this.comboBox7);
            this.QueryPnl.Controls.Add(this.Comparision_compobox);
            this.QueryPnl.Controls.Add(this.bool_Compobox);
            this.QueryPnl.Controls.Add(this.label7);
            this.QueryPnl.Controls.Add(this.Aggregate_combobox);
            this.QueryPnl.Controls.Add(this.label6);
            this.QueryPnl.Controls.Add(this.label5);
            this.QueryPnl.Controls.Add(this.label4);
            this.QueryPnl.Location = new System.Drawing.Point(255, 50);
            this.QueryPnl.Margin = new System.Windows.Forms.Padding(4);
            this.QueryPnl.Name = "QueryPnl";
            this.QueryPnl.Size = new System.Drawing.Size(816, 542);
            this.QueryPnl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Coulmns";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(582, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 21);
            this.label9.TabIndex = 23;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(669, 481);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 37);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            "!="});
            this.comboBox3.Location = new System.Drawing.Point(239, 175);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(68, 24);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(388, 166);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 43);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(348, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(56, 9);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 24);
            this.comboBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "lbl";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 9);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 24);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "\"\"";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.comboBox8);
            this.panel3.Controls.Add(this.assign_lbl1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(388, 119);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 43);
            this.panel3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(348, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(56, 9);
            this.comboBox8.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(140, 24);
            this.comboBox8.TabIndex = 11;
            // 
            // assign_lbl1
            // 
            this.assign_lbl1.AutoSize = true;
            this.assign_lbl1.Location = new System.Drawing.Point(202, 14);
            this.assign_lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assign_lbl1.Name = "assign_lbl1";
            this.assign_lbl1.Size = new System.Drawing.Size(20, 17);
            this.assign_lbl1.TabIndex = 9;
            this.assign_lbl1.Text = "lbl";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 24);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(398, 360);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(140, 24);
            this.comboBox7.TabIndex = 11;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // Comparision_compobox
            // 
            this.Comparision_compobox.FormattingEnabled = true;
            this.Comparision_compobox.IntegralHeight = false;
            this.Comparision_compobox.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            "!="});
            this.Comparision_compobox.Location = new System.Drawing.Point(138, 127);
            this.Comparision_compobox.Margin = new System.Windows.Forms.Padding(4);
            this.Comparision_compobox.Name = "Comparision_compobox";
            this.Comparision_compobox.Size = new System.Drawing.Size(169, 24);
            this.Comparision_compobox.TabIndex = 8;
            this.Comparision_compobox.SelectedIndexChanged += new System.EventHandler(this.Comparision_compobox_SelectedIndexChanged);
            // 
            // bool_Compobox
            // 
            this.bool_Compobox.FormattingEnabled = true;
            this.bool_Compobox.Items.AddRange(new object[] {
            "And ",
            "OR"});
            this.bool_Compobox.Location = new System.Drawing.Point(138, 175);
            this.bool_Compobox.Margin = new System.Windows.Forms.Padding(4);
            this.bool_Compobox.Name = "bool_Compobox";
            this.bool_Compobox.Size = new System.Drawing.Size(93, 24);
            this.bool_Compobox.TabIndex = 6;
            this.bool_Compobox.SelectedIndexChanged += new System.EventHandler(this.Bool_Compobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Boolean Opertors";
            // 
            // Aggregate_combobox
            // 
            this.Aggregate_combobox.FormattingEnabled = true;
            this.Aggregate_combobox.Items.AddRange(new object[] {
            "Sum",
            "Avg",
            "Var",
            "Count"});
            this.Aggregate_combobox.Location = new System.Drawing.Point(167, 360);
            this.Aggregate_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.Aggregate_combobox.Name = "Aggregate_combobox";
            this.Aggregate_combobox.Size = new System.Drawing.Size(223, 24);
            this.Aggregate_combobox.TabIndex = 4;
            this.Aggregate_combobox.SelectedIndexChanged += new System.EventHandler(this.Aggregate_combobox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Aggregate functions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Comparison Query";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Types of query";
            // 
            // ResPnl
            // 
            this.ResPnl.Controls.Add(this.resultGrid);
            this.ResPnl.Location = new System.Drawing.Point(253, 50);
            this.ResPnl.Margin = new System.Windows.Forms.Padding(4);
            this.ResPnl.Name = "ResPnl";
            this.ResPnl.Size = new System.Drawing.Size(818, 542);
            this.ResPnl.TabIndex = 5;
            // 
            // resultGrid
            // 
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Location = new System.Drawing.Point(32, 25);
            this.resultGrid.Margin = new System.Windows.Forms.Padding(4);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.Size = new System.Drawing.Size(752, 532);
            this.resultGrid.TabIndex = 0;
            // 
            // ExitPic
            // 
            this.ExitPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitPic.BackgroundImage")));
            this.ExitPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPic.Location = new System.Drawing.Point(1073, 2);
            this.ExitPic.Margin = new System.Windows.Forms.Padding(2);
            this.ExitPic.Name = "ExitPic";
            this.ExitPic.Size = new System.Drawing.Size(36, 42);
            this.ExitPic.TabIndex = 6;
            this.ExitPic.TabStop = false;
            this.ExitPic.Click += new System.EventHandler(this.ExitPic_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(4, 5);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(51, 39);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 23;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.pictureBox21_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.ExitPic);
            this.panel2.Controls.Add(this.pictureBox21);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 46);
            this.panel2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Buttons_pnl_Sliding);
            this.Controls.Add(this.TablePnl);
            this.Controls.Add(this.ResPnl);
            this.Controls.Add(this.QueryPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TablePnl.ResumeLayout(false);
            this.TablePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl)).EndInit();
            this.Buttons_pnl_Sliding.ResumeLayout(false);
            this.QueryPnl.ResumeLayout(false);
            this.QueryPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TablePnl;
        private System.Windows.Forms.DataGridView Tbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Buttons_pnl_Sliding;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel QueryPnl;
        private System.Windows.Forms.ComboBox bool_Compobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Aggregate_combobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox Comparision_compobox;
        private System.Windows.Forms.Panel ResPnl;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label assign_lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ExitPic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
    }
}

