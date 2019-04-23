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
            this.TablePnl = new System.Windows.Forms.Panel();
            this.Tbl = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QueryPnl = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.AndORlbl3 = new System.Windows.Forms.Label();
            this.assign_lbl3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.assign_lbl2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.AndORlbl2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.assign_lbl1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AndOR_lbl1 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.assign_lbl0 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Comparision_compobox = new System.Windows.Forms.ComboBox();
            this.bool_Compobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Aggregate_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResPnl = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TablePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl)).BeginInit();
            this.panel2.SuspendLayout();
            this.QueryPnl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ResPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePnl
            // 
            this.TablePnl.Controls.Add(this.Tbl);
            this.TablePnl.Controls.Add(this.label2);
            this.TablePnl.Controls.Add(this.comboBox1);
            this.TablePnl.Controls.Add(this.label1);
            this.TablePnl.Location = new System.Drawing.Point(210, 15);
            this.TablePnl.Name = "TablePnl";
            this.TablePnl.Size = new System.Drawing.Size(594, 435);
            this.TablePnl.TabIndex = 0;
            // 
            // Tbl
            // 
            this.Tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl.Location = new System.Drawing.Point(40, 118);
            this.Tbl.Name = "Tbl";
            this.Tbl.Size = new System.Drawing.Size(537, 228);
            this.Tbl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Table";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "product",
            "Employees",
            "Departments",
            "cars"});
            this.comboBox1.Location = new System.Drawing.Point(430, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Table";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 450);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(3, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(0, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Result";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(0, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Types of query";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // QueryPnl
            // 
            this.QueryPnl.Controls.Add(this.panel5);
            this.QueryPnl.Controls.Add(this.panel4);
            this.QueryPnl.Controls.Add(this.panel3);
            this.QueryPnl.Controls.Add(this.comboBox7);
            this.QueryPnl.Controls.Add(this.Add_btn);
            this.QueryPnl.Controls.Add(this.panel1);
            this.QueryPnl.Controls.Add(this.Comparision_compobox);
            this.QueryPnl.Controls.Add(this.bool_Compobox);
            this.QueryPnl.Controls.Add(this.label7);
            this.QueryPnl.Controls.Add(this.Aggregate_combobox);
            this.QueryPnl.Controls.Add(this.label6);
            this.QueryPnl.Controls.Add(this.label5);
            this.QueryPnl.Controls.Add(this.label4);
            this.QueryPnl.Location = new System.Drawing.Point(207, 12);
            this.QueryPnl.Name = "QueryPnl";
            this.QueryPnl.Size = new System.Drawing.Size(594, 435);
            this.QueryPnl.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.comboBox10);
            this.panel5.Controls.Add(this.AndORlbl3);
            this.panel5.Controls.Add(this.assign_lbl3);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Location = new System.Drawing.Point(247, 221);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(333, 35);
            this.panel5.TabIndex = 21;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(48, 7);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 21);
            this.comboBox10.TabIndex = 11;
            // 
            // AndORlbl3
            // 
            this.AndORlbl3.AutoSize = true;
            this.AndORlbl3.Location = new System.Drawing.Point(6, 11);
            this.AndORlbl3.Name = "AndORlbl3";
            this.AndORlbl3.Size = new System.Drawing.Size(17, 13);
            this.AndORlbl3.TabIndex = 20;
            this.AndORlbl3.Text = "lbl";
            // 
            // assign_lbl3
            // 
            this.assign_lbl3.AutoSize = true;
            this.assign_lbl3.Location = new System.Drawing.Point(173, 11);
            this.assign_lbl3.Name = "assign_lbl3";
            this.assign_lbl3.Size = new System.Drawing.Size(17, 13);
            this.assign_lbl3.TabIndex = 9;
            this.assign_lbl3.Text = "lbl";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(192, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.comboBox9);
            this.panel4.Controls.Add(this.assign_lbl2);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.AndORlbl2);
            this.panel4.Location = new System.Drawing.Point(247, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 35);
            this.panel4.TabIndex = 19;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(48, 7);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 11;
            // 
            // assign_lbl2
            // 
            this.assign_lbl2.AutoSize = true;
            this.assign_lbl2.Location = new System.Drawing.Point(173, 11);
            this.assign_lbl2.Name = "assign_lbl2";
            this.assign_lbl2.Size = new System.Drawing.Size(17, 13);
            this.assign_lbl2.TabIndex = 9;
            this.assign_lbl2.Text = "lbl";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // AndORlbl2
            // 
            this.AndORlbl2.AutoSize = true;
            this.AndORlbl2.Location = new System.Drawing.Point(6, 10);
            this.AndORlbl2.Name = "AndORlbl2";
            this.AndORlbl2.Size = new System.Drawing.Size(17, 13);
            this.AndORlbl2.TabIndex = 18;
            this.AndORlbl2.Text = "lbl";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.comboBox8);
            this.panel3.Controls.Add(this.assign_lbl1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.AndOR_lbl1);
            this.panel3.Location = new System.Drawing.Point(247, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 35);
            this.panel3.TabIndex = 17;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(48, 7);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 11;
            // 
            // assign_lbl1
            // 
            this.assign_lbl1.AutoSize = true;
            this.assign_lbl1.Location = new System.Drawing.Point(173, 11);
            this.assign_lbl1.Name = "assign_lbl1";
            this.assign_lbl1.Size = new System.Drawing.Size(17, 13);
            this.assign_lbl1.TabIndex = 9;
            this.assign_lbl1.Text = "lbl";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // AndOR_lbl1
            // 
            this.AndOR_lbl1.AutoSize = true;
            this.AndOR_lbl1.Location = new System.Drawing.Point(6, 12);
            this.AndOR_lbl1.Name = "AndOR_lbl1";
            this.AndOR_lbl1.Size = new System.Drawing.Size(17, 13);
            this.AndOR_lbl1.TabIndex = 12;
            this.AndOR_lbl1.Text = "lbl";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(292, 308);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 11;
            // 
            // Add_btn
            // 
            this.Add_btn.FlatAppearance.BorderSize = 0;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_btn.Location = new System.Drawing.Point(234, 336);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(40, 27);
            this.Add_btn.TabIndex = 16;
            this.Add_btn.Text = "And";
            this.Add_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.assign_lbl0);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(289, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 35);
            this.panel1.TabIndex = 13;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(3, 7);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 11;
            // 
            // assign_lbl0
            // 
            this.assign_lbl0.AutoSize = true;
            this.assign_lbl0.Location = new System.Drawing.Point(128, 11);
            this.assign_lbl0.Name = "assign_lbl0";
            this.assign_lbl0.Size = new System.Drawing.Size(17, 13);
            this.assign_lbl0.TabIndex = 9;
            this.assign_lbl0.Text = "lbl";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
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
            this.Comparision_compobox.Location = new System.Drawing.Point(153, 103);
            this.Comparision_compobox.Name = "Comparision_compobox";
            this.Comparision_compobox.Size = new System.Drawing.Size(121, 21);
            this.Comparision_compobox.TabIndex = 8;
            this.Comparision_compobox.SelectedIndexChanged += new System.EventHandler(this.Comparision_compobox_SelectedIndexChanged);
            // 
            // bool_Compobox
            // 
            this.bool_Compobox.FormattingEnabled = true;
            this.bool_Compobox.Items.AddRange(new object[] {
            "And ",
            "OR"});
            this.bool_Compobox.Location = new System.Drawing.Point(153, 146);
            this.bool_Compobox.Name = "bool_Compobox";
            this.bool_Compobox.Size = new System.Drawing.Size(88, 21);
            this.bool_Compobox.TabIndex = 6;
            this.bool_Compobox.SelectedIndexChanged += new System.EventHandler(this.Bool_Compobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
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
            this.Aggregate_combobox.Location = new System.Drawing.Point(153, 309);
            this.Aggregate_combobox.Name = "Aggregate_combobox";
            this.Aggregate_combobox.Size = new System.Drawing.Size(121, 21);
            this.Aggregate_combobox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Aggregate functions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Comparison Query";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Types of query";
            // 
            // ResPnl
            // 
            this.ResPnl.Controls.Add(this.dataGridView2);
            this.ResPnl.Location = new System.Drawing.Point(197, 16);
            this.ResPnl.Name = "ResPnl";
            this.ResPnl.Size = new System.Drawing.Size(601, 429);
            this.ResPnl.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(581, 380);
            this.dataGridView2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(254, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(296, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(296, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(296, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.QueryPnl);
            this.Controls.Add(this.TablePnl);
            this.Controls.Add(this.ResPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TablePnl.ResumeLayout(false);
            this.TablePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.QueryPnl.ResumeLayout(false);
            this.QueryPnl.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TablePnl;
        private System.Windows.Forms.DataGridView Tbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label assign_lbl0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AndOR_lbl1;
        private System.Windows.Forms.ComboBox Comparision_compobox;
        private System.Windows.Forms.Panel ResPnl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label assign_lbl2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label AndORlbl2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label assign_lbl1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label assign_lbl3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label AndORlbl3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

