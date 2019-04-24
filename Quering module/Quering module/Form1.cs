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

        private DepartmentsList deps;
        private List<Department> deplist;

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
                            if (booleanOperator == "\"\"" && comparison(carLst[i].getCar(FirstComboBox), textBox2.Text, comp1))
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

        public List<Department> DepartmentTable(string comparison1 , string comparison2 , string firstValue , string secondValue , string booleanOperator)
        {
            List<Department> result = new List<Department>();

            for(int j=0; j<deps.colNames().Count; j++) // loops the columns of department
            {
                if(firstValue == deps.colNames()[j])
                {
                    for(int i=0; i<deplist.Count; i++) // loops the objects in file
                    {
                        if (booleanOperator == "And" && comparison(deplist[i].getDepartment(firstValue), textBox2.Text, comparison1) && comparison(deplist[i].getDepartment(secondValue), textBox1.Text, comparison2))
                        {
                                if (!result.Contains(deplist[i]))
                                    result.Add(deplist[i]);
                        }

                        else if (booleanOperator == "OR" && (comparison(deplist[i].getDepartment(firstValue), textBox2.Text, comparison1) || comparison(deplist[i].getDepartment(secondValue), textBox1.Text, comparison2)) )
                        {
                            if (!result.Contains(deplist[i]))
                                result.Add(deplist[i]);
                        }

                        else if (booleanOperator == "\"\"" && comparison(deplist[i].getDepartment(firstValue), textBox2.Text, comparison1))
                        {
                            if (!result.Contains(deplist[i]))
                                result.Add(deplist[i]);
                        }
                    }
                }
            }

            return result;
        }

        public void AggregationTable(string type , string value)
        {
            if (type == "Departments")
            {
                if (Aggregate_combobox.Text == "Sum")
                {
                    int result = 0;
                    for(int i=0; i<deplist.Count; i++)
                    {
                        result += int.Parse(deplist[i].getDepartment(value));
                    }
                    label9.Text = ("Sum: " + result);
                }
                else if(Aggregate_combobox.Text == "Avg")
                {
                    double result = 0;
                    for (int i = 0; i < deplist.Count; i++)
                    {
                        result += double.Parse(deplist[i].getDepartment(value));
                    }
                    result /= deplist.Count;
                    result = Math.Round(result,3);
                    label9.Text = ("Average: " + result);
                }
                else if(Aggregate_combobox.Text == "Count")
                {
                    label9.Text = ("Count: " + deplist.Count);
                }
                else if(Aggregate_combobox.Text == "Var")
                {
                    double result;
                    double mean = 0;
                    for (int i = 0; i < deplist.Count; i++)
                    {
                        mean += double.Parse(deplist[i].getDepartment(value));
                    }
                    mean /= deplist.Count;
                    mean = Math.Round(mean, 3);
                    double upper = 0;
                    for(int i=0; i<deplist.Count; i++)
                    {
                        upper += Math.Pow(double.Parse(deplist[i].getDepartment(value)) - mean,2);
                    }
                    result = upper / (deplist.Count - 1);
                    result = Math.Round(result, 3);
                    label9.Text = ("Variance: " + result);
                }
            }
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
            resultGrid.DataSource = null;
        }

        private void Button3_Click(object sender, EventArgs e) //if click result
        {
            TablePnl.Visible = false;
            ResPnl.Visible = true;
            QueryPnl.Visible = false;
            try
            {
                if (comboBox1.SelectedItem.Equals("cars"))
                    resultGrid.DataSource = carTablel(assign_lbl1.Text, label3.Text, comboBox8.Text, comboBox2.Text, label8.Text);
                else if (comboBox1.SelectedItem.Equals("Departments"))
                    resultGrid.DataSource = DepartmentTable(assign_lbl1.Text, label3.Text, comboBox8.Text, comboBox2.Text, label8.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Please Select A Table First");
            }

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
                
                showColumns("Cars");
            }
            else if (selectedItem == "Departments")
            {
                deps = new DepartmentsList();
                deplist =  deps.read();
                Tbl.DataSource = deplist;
                showColumns("Departments");
            }
        }
        private void showColumns(string type) //add columns names to each comboBox
        {
            if (type == "Cars")
            {
                for (int i = 0; i < cars.colNames().Count; i++)
                {
                    if (!comboBox8.Items.Contains(cars.colNames()[i]))
                        comboBox8.Items.Add(cars.colNames()[i]);
                    if (!comboBox2.Items.Contains(cars.colNames()[i]))
                        comboBox2.Items.Add(cars.colNames()[i]);
                }
                if (!comboBox7.Items.Contains(cars.colNames()[0]))
                    comboBox7.Items.Add(cars.colNames()[0]); //aggregation functions stock Number
            }

            else if(type == "Departments")
            {
                for(int i=0; i<deps.colNames().Count; i++)
                {
                    if (!comboBox8.Items.Contains(deps.colNames()[i]))
                        comboBox8.Items.Add(deps.colNames()[i]);
                    if (!comboBox2.Items.Contains(deps.colNames()[i]))
                        comboBox2.Items.Add(deps.colNames()[i]);
                }
                if (!comboBox7.Items.Contains(deps.colNames()[2]))
                    comboBox7.Items.Add(deps.colNames()[2]); //aggregation functions for NumOfEmployees
            }
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

        private void clear()
        {
            Comparision_compobox.Text = "";
            comboBox8.Text = "";
            assign_lbl1.Text = "lbl";
            textBox2.Text = "";
            bool_Compobox.Text = "";
            comboBox3.Text = "";
            label8.Text = "\"\"";
            comboBox2.Text = "";
            label3.Text = "lbl";
            textBox1.Text = "";
            Aggregate_combobox.Text = "";
            comboBox7.Text = "";
            label9.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox7.Text != "")
                AggregationTable(comboBox1.Text, comboBox7.Text);
        }

        private void Aggregate_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text!="" && comboBox7.Text!="")
               AggregationTable(comboBox1.Text, comboBox7.Text);
        }
    }
}
