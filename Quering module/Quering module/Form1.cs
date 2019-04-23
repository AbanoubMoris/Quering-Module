using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quering_module
{

    public partial class Form1 : Form
    {

        private CarCollection cars;
        private List<Car> carLst;
        public Form1()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            pictureBox1.ImageLocation = @"f.png";
            pictureBox2.ImageLocation = @"f.png";
            pictureBox3.ImageLocation = @"f.png";
            pictureBox4.ImageLocation = @"f.png";

            pictureBox1.ImageLocation = @"t.png";
            pictureBox2.ImageLocation = @"t.png";
            pictureBox3.ImageLocation = @"t.png";
            pictureBox4.ImageLocation = @"t.png";
        }
        private void TrueFalseImages(string TorF)
        {
            pictureBox1.ImageLocation = @"f.png";
            pictureBox2.ImageLocation = @"f.png";
            pictureBox3.ImageLocation = @"f.png";
            pictureBox4.ImageLocation = @"f.png";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TablePnl.Visible = true;
            ResPnl.Visible = false;
            QueryPnl.Visible = false;
            

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            TablePnl.Visible = false;
            ResPnl.Visible = false;
            QueryPnl.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TablePnl.Visible = false;
            ResPnl.Visible = true;
            QueryPnl.Visible = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            if (selectedItem == "cars"){
                cars = new CarCollection();
                carLst = cars.read();
                Tbl.DataSource = carLst;
                showColumnsOfCars();
            }
            else if (selectedItem == "Departments")
            {
                DepartmentsList dp = new DepartmentsList();
                Tbl.DataSource = dp.read();
            }
        }
        private void showColumnsOfCars()
        {
            for (int i = 0; i < cars.colNames().Count; i++)
            {
                comboBox6.Items.Add(cars.colNames()[i]);
                comboBox8.Items.Add(cars.colNames()[i]);
                comboBox9.Items.Add(cars.colNames()[i]);
                comboBox10.Items.Add(cars.colNames()[i]);
            }
        }
        private int clicked = 0;
        private void Comparision_compobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Comparision_compobox.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    if (clicked==0)
                        assign_lbl0.Text = ">";
                    if (clicked == 1)
                        assign_lbl1.Text = ">";
                    if (clicked == 2)
                        assign_lbl2.Text = ">";
                    if (clicked == 3)
                        assign_lbl3.Text = ">";
                    break;
                case 1:
                    if (clicked == 0)
                        assign_lbl0.Text = "<";
                    if (clicked == 1)
                        assign_lbl1.Text = "<";
                    if (clicked == 2)
                        assign_lbl2.Text = "<";
                    if (clicked == 3)
                        assign_lbl3.Text = "<";
                    break;
                case 2:
                    if (clicked == 0)
                        assign_lbl0.Text = "=";
                    if (clicked == 1)
                        assign_lbl1.Text = "=";
                    if (clicked == 2)
                        assign_lbl2.Text = "=";
                    if (clicked == 3)
                        assign_lbl3.Text = "=";
                    break;
                case 3:
                    if (clicked == 0)
                        assign_lbl0.Text = "!=";
                    if (clicked == 1)
                        assign_lbl1.Text = "!=";
                    if (clicked == 2)
                        assign_lbl2.Text = "!=";
                    if (clicked == 3)
                        assign_lbl3.Text = "!=";
                    break;

                default:
                    break;
            }
        }
        
        private void Bool_Compobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clicked++;
            int selectedIndex = bool_Compobox.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    if (clicked == 1)
                    {
                        AndOR_lbl1.Text = "And";
                        panel3.Visible = true;
                    }
                    else if (clicked == 2)
                    {
                        AndORlbl2.Text = "And";
                        panel4.Visible = true;
                    }
                    else if (clicked == 3)
                    {
                        AndORlbl3.Text = "And";
                        panel5.Visible = true;
                    }
                    break;
                case 1:
                    if (clicked == 1)
                    {
                        AndOR_lbl1.Text = "Or";
                        panel3.Visible = true;

                    }
                    if (clicked == 2)
                    {
                        AndORlbl2.Text = "Or";
                        panel4.Visible = true;
                    }
                    if (clicked == 3)
                    {
                        AndORlbl3.Text = "Or";
                        panel5.Visible = true;
                    }
                    break;
                default:
                    break;
            }
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           // if (co)
          //  if (carLst[0].StockNumber)
            pictureBox1.ImageLocation = @"f.png";
        }
    }
}
