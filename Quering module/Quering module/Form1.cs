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

        //List<Car> result = new List<Car>();

        public bool comparison(string A , string B , string comp)
        {

                if (comp == "=" && A == B) return true;
                else if (comp == "!=" && A != B) return true;
                try{
                    if (comp == ">" && int.Parse(A) > int.Parse(B)) return true;
                }catch (Exception){}
                try{
                    if (comp == "<" && int.Parse(A) < int.Parse(B)) return true;
                }catch (Exception){}
            return false;
        }
        public List<Car> carTablel(string comp1, string comp2, string FirstComboBox , string SecondComboBox, string booleanOperator)
        {
            List<Car> result = new List<Car>();
            {

                for (int j = 0; j < cars.colNames().Count; j++)
                {
                    if (FirstComboBox == cars.colNames()[j])
                    {
                        for (int i = 0; i < carLst.Count; i++)
                        {
                            if (booleanOperator == "And" && comparison(carLst[i].getCar(FirstComboBox), textBox2.Text, comp1)) {
                                if(comparison(carLst[i].getCar(SecondComboBox), textBox1.Text, comp2))
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                            if (booleanOperator == "And" && comparison(carLst[i].getCar(SecondComboBox), textBox1.Text, comp2))
                            {
                                if (comparison(carLst[i].getCar(FirstComboBox), textBox2.Text, comp1))
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }

                            if (booleanOperator == "OR" && comparison(carLst[i].getCar(FirstComboBox), textBox2.Text, comp1))
                            {
                                if (!result.Contains(carLst[i]))
                                    result.Add(carLst[i]);
                                if (comparison(carLst[i].getCar(SecondComboBox), textBox1.Text, comp2))
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                            if (booleanOperator == "OR" && comparison(carLst[i].getCar(SecondComboBox), textBox1.Text, comp2))
                            {
                                if (!result.Contains(carLst[i]))
                                    result.Add(carLst[i]);    
                                if (comparison(carLst[i].getCar(FirstComboBox), textBox2.Text, comp1))
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                            if (booleanOperator == "" && comparison(carLst[i].getCar(FirstComboBox), textBox2.Text, comp1))
                            {
                                if (!result.Contains(carLst[i]))
                                    result.Add(carLst[i]);
                            }
                        }
                    }


                }
            }
            return result;
        }


       

        public Form1()
        {
            InitializeComponent();
            panel3.AutoScroll = true;

        }
        private void TrueFalseImages(string TorF)
        {
           
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

        private void Button3_Click(object sender, EventArgs e) //if click result
        {
            TablePnl.Visible = false;
            ResPnl.Visible = true;
            QueryPnl.Visible = false;
            resultGrid.DataSource = carTablel(assign_lbl1.Text, label3.Text, comboBox8.Text, comboBox2.Text, label8.Text);
        }
        string selectedItem;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem.ToString();
            if (selectedItem == "cars")
            {
                cars = new CarCollection();
                cars.read();
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
        private void showColumnsOfCars() //add columns names to each comboBox
        {
            for (int i = 0; i < cars.colNames().Count; i++)
            {
                comboBox8.Items.Add(cars.colNames()[i]);
                comboBox2.Items.Add(cars.colNames()[i]);
            }
            comboBox7.Items.Add(cars.colNames()[0]); //aggregation functions stock Number
        }
        
        private void Comparision_compobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Comparision_compobox.SelectedIndex;
            
            switch (selectedIndex)
            {
                case 0:
                    assign_lbl1.Text=">";
                    //resultGrid.DataSource = result;
                    break;
                case 1:
                    assign_lbl1.Text = "<";
                    //resultGrid.DataSource = result;
                    break;
                case 2:
                    assign_lbl1.Text = "=";
                    //resultGrid.DataSource = result;
                    break;
                case 3:
                    assign_lbl1.Text = "!=";
                    //resultGrid.DataSource = result;
                    break;

                default:
                    break;
            }
       
    }
        
        private void Bool_Compobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = bool_Compobox.SelectedIndex;
            switch (selectedIndex)
            {
                case 0: //And
                    label8.Text = "And";
                        break;
                case 1: //Or
                    label8.Text = "OR";
                    break;
                default:
                    break;
            }
        }
        private string TextTyped(string s)
        {
            string[] x = s.Split(':');
            return x[x.Length - 1];

        }
        protected void textBox_TextChanged(object sender, EventArgs e)
        {
            
           // MessageBox.Show(TextTyped(sender.ToString()));
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // if (co)
            //  if (carLst[0].StockNumber)

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox3.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    label3.Text = ">";
                   // resultGrid.DataSource = result;
                    break;
                case 1:
                    label3.Text = "<";
                   // resultGrid.DataSource = result;
                    break;
                case 2:
                    label3.Text = "=";
                    //resultGrid.DataSource = result;
                    break;
                case 3:
                    label3.Text = "!=";
                    //resultGrid.DataSource = result;
                    break;

                default:
                    break;
            }
        }
    }
}
