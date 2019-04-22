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


        public Form1()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
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
                CarCollection pt = new CarCollection();
                Tbl.DataSource = pt.read();
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
    }
}
