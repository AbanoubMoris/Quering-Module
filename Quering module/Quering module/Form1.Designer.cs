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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.assign_lbl1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.TablePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl)).BeginInit();
            this.panel2.SuspendLayout();
            this.QueryPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ResPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
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
            this.QueryPnl.Location = new System.Drawing.Point(207, 12);
            this.QueryPnl.Name = "QueryPnl";
            this.QueryPnl.Size = new System.Drawing.Size(594, 435);
            this.QueryPnl.TabIndex = 4;
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
            this.comboBox3.Location = new System.Drawing.Point(156, 142);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(39, 21);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(250, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 35);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(296, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(48, 7);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "lbl";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "lbl";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.comboBox8);
            this.panel3.Controls.Add(this.assign_lbl1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Location = new System.Drawing.Point(250, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 35);
            this.panel3.TabIndex = 19;
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
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(292, 308);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 11;
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
            this.Comparision_compobox.Location = new System.Drawing.Point(107, 103);
            this.Comparision_compobox.Name = "Comparision_compobox";
            this.Comparision_compobox.Size = new System.Drawing.Size(88, 21);
            this.Comparision_compobox.TabIndex = 8;
            this.Comparision_compobox.SelectedIndexChanged += new System.EventHandler(this.Comparision_compobox_SelectedIndexChanged);
            // 
            // bool_Compobox
            // 
            this.bool_Compobox.FormattingEnabled = true;
            this.bool_Compobox.Items.AddRange(new object[] {
            "And ",
            "OR"});
            this.bool_Compobox.Location = new System.Drawing.Point(107, 142);
            this.bool_Compobox.Name = "bool_Compobox";
            this.bool_Compobox.Size = new System.Drawing.Size(43, 21);
            this.bool_Compobox.TabIndex = 6;
            this.bool_Compobox.SelectedIndexChanged += new System.EventHandler(this.Bool_Compobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 146);
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
            this.Aggregate_combobox.Location = new System.Drawing.Point(131, 310);
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
            this.ResPnl.Controls.Add(this.resultGrid);
            this.ResPnl.Location = new System.Drawing.Point(197, 16);
            this.ResPnl.Name = "ResPnl";
            this.ResPnl.Size = new System.Drawing.Size(601, 429);
            this.ResPnl.TabIndex = 5;
            // 
            // resultGrid
            // 
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Location = new System.Drawing.Point(10, 42);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.Size = new System.Drawing.Size(581, 380);
            this.resultGrid.TabIndex = 0;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
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
        private System.Windows.Forms.ComboBox Comparision_compobox;
        private System.Windows.Forms.Panel ResPnl;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label assign_lbl1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

