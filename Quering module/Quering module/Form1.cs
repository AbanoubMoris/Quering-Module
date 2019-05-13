using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
namespace Quering_module
{

    public partial class Form1 : Form
    {
       
        bool hidden = false;
        int panelwidth;
        List<string> L =  new List<string>();

        private CarCollection cars;

        private List<Car> carLst = new List<Car>();

        //List<Car> result = new List<Car>();
        
        private DepartmentsList deps;
        private List<Department> deplist = new List<Department>();

        private EmployeesList emps;
        private List<Employee> empList = new List<Employee>();

        public bool comparison(string A, string B, string comp)
        {

            if (comp == "=" && A == B) return true;
            else if (comp == "!=" && A != B) return true;
            try
            {
                if (comp == ">" && int.Parse(A) > int.Parse(B)) return true;
            }
            catch (Exception) { }
            try
            {
                if (comp == "<" && int.Parse(A) < int.Parse(B)) return true;
            }
            catch (Exception) { }
            try
            {
                if (comp == "<=" && int.Parse(A) <= int.Parse(B)) return true;
            }
            catch (Exception) { }
            try
            {
                if (comp == ">=" && int.Parse(A) >= int.Parse(B)) return true;
            }
            catch (Exception) { }
            try{
                if (comp == "IN")
                {
                   string[]var = Split_txt();
                    for(int i = 0; i < var.Length; i++)
                    {
                        if(var[i] == (string)A)
                          return true;
                    }
                }
               }
               catch (Exception) { }
            
               return false;
        }

        public string[] Split_txt()
        {
            char seperator = ',';
            var str = textBox1.Text;
            string[] values = null;
            values = str.Split(seperator);
            return values;
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
                            if (booleanOperator == "And" && comparison(carLst[i].getCar(FirstComboBox), textBox1.Text, comp1)) {
                                if(comparison(carLst[i].getCar(SecondComboBox), textBox2.Text, comp2))
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                            if (booleanOperator == "And" && comparison(carLst[i].getCar(SecondComboBox), textBox2.Text, comp2))
                            {
                                if (comparison(carLst[i].getCar(FirstComboBox), textBox1.Text, comp1))
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }

                            if (booleanOperator == "OR" && comparison(carLst[i].getCar(FirstComboBox), textBox1.Text, comp1))
                            {
                                if (!result.Contains(carLst[i]))
                                    result.Add(carLst[i]);
                                if (comparison(carLst[i].getCar(SecondComboBox), textBox2.Text, comp2))
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                            if (booleanOperator == "OR" && comparison(carLst[i].getCar(SecondComboBox), textBox2.Text, comp2))
                            {
                                if (!result.Contains(carLst[i]))
                                    result.Add(carLst[i]);    
                                if (comparison(carLst[i].getCar(FirstComboBox), textBox1.Text, comp1))
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                            if (booleanOperator == "\"\"" && comparison(carLst[i].getCar(FirstComboBox), textBox1.Text, comp1))
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
                        if (booleanOperator == "And" && comparison(deplist[i].getDepartment(firstValue), textBox1.Text, comparison1) && comparison(deplist[i].getDepartment(secondValue), textBox2.Text, comparison2))
                        {
                                if (!result.Contains(deplist[i]))
                                    result.Add(deplist[i]);
                        }

                        else if (booleanOperator == "OR" && (comparison(deplist[i].getDepartment(firstValue), textBox1.Text, comparison1) || comparison(deplist[i].getDepartment(secondValue), textBox2.Text, comparison2)) )
                        {
                            if (!result.Contains(deplist[i]))
                                result.Add(deplist[i]);
                        }

                        else if (booleanOperator == "\"\"" && comparison(deplist[i].getDepartment(firstValue), textBox1.Text, comparison1))
                        {
                            if (!result.Contains(deplist[i]))
                                result.Add(deplist[i]);
                        }
                    }
                }
            }

            return result;
        }




        public List<Employee> EmployeesTable(string comparison1, string comparison2, string firstValue, string secondValue, string booleanOperator)
        {
            List<Employee> result = new List<Employee>();

            for (int j = 0; j < emps.colNames().Count; j++) // loops the columns of employee
            {
                if (firstValue == emps.colNames()[j])
                {
                    for (int i = 0; i < empList.Count; i++) // loops the objects in file
                    {
                        if (booleanOperator == "And" && comparison(empList[i].getEmployee(firstValue), textBox1.Text, comparison1) && comparison(empList[i].getEmployee(secondValue), textBox2.Text, comparison2))
                        {
                            if (!result.Contains(empList[i]))
                                result.Add(empList[i]);
                        }

                        else if (booleanOperator == "OR" && (comparison(empList[i].getEmployee(firstValue), textBox1.Text, comparison1) || comparison(empList[i].getEmployee(secondValue), textBox2.Text, comparison2)))
                        {
                            if (!result.Contains(empList[i]))
                                result.Add(empList[i]);
                        }

                        else if (booleanOperator == "\"\"" && comparison(empList[i].getEmployee(firstValue), textBox1.Text, comparison1))
                        {
                            if (!result.Contains(empList[i]))
                                result.Add(empList[i]);
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
            else if(type == "cars")
            {
                if (Aggregate_combobox.Text == "Sum")
                {
                    int result = 0;
                    for (int i = 0; i < carLst.Count; i++)
                    {
                        result += int.Parse(carLst[i].getCar(value));
                    }
                    label9.Text = ("Sum: " + result);
                }
                else if (Aggregate_combobox.Text == "Avg")
                {
                    double result = 0;
                    for (int i = 0; i < carLst.Count; i++)
                    {
                        result += double.Parse(carLst[i].getCar(value));
                    }
                    result /= carLst.Count;
                    result = Math.Round(result, 3);
                    label9.Text = ("Average: " + result);
                }
                else if (Aggregate_combobox.Text == "Count")
                {
                    label9.Text = ("Count: " + carLst.Count);
                }
                else if (Aggregate_combobox.Text == "Var")
                {
                    double result;
                    double mean = 0;
                    for (int i = 0; i < carLst.Count; i++)
                    {
                        mean += double.Parse(carLst[i].getCar(value));
                    }
                    mean /= carLst.Count;
                    mean = Math.Round(mean, 3);
                    double upper = 0;
                    for (int i = 0; i < carLst.Count; i++)
                    {
                        upper += Math.Pow(double.Parse(carLst[i].getCar(value)) - mean, 2);
                    }
                    result = upper / (carLst.Count - 1);
                    result = Math.Round(result, 3);
                    label9.Text = ("Variance: " + result);
                }
            }
            else if (type == "Employees")
            {
                if (Aggregate_combobox.Text == "Sum")
                {
                    int result = 0;
                    for (int i = 0; i < empList.Count; i++)
                    {
                        result += int.Parse(empList[i].getEmployee(value));
                    }
                    label9.Text = ("Sum: " + result);
                }
                else if (Aggregate_combobox.Text == "Avg")
                {
                    double result = 0;
                    for (int i = 0; i < empList.Count; i++)
                    {
                        result += double.Parse(empList[i].getEmployee(value));
                    }
                    result /= empList.Count;
                    result = Math.Round(result, 3);
                    label9.Text = ("Average: " + result);
                }
                else if (Aggregate_combobox.Text == "Count")
                {
                    label9.Text = ("Count: " + empList.Count);
                }
                else if (Aggregate_combobox.Text == "Var")
                {
                    double result;
                    double mean = 0;
                    for (int i = 0; i < empList.Count; i++)
                    {
                        mean += double.Parse(empList[i].getEmployee(value));
                    }
                    mean /= empList.Count;
                    mean = Math.Round(mean, 3);
                    double upper = 0;
                    for (int i = 0; i < empList.Count; i++)
                    {
                        upper += Math.Pow(double.Parse(empList[i].getEmployee(value)) - mean, 2);
                    }
                    result = upper / (empList.Count - 1);
                    result = Math.Round(result, 3);
                    label9.Text = ("Variance: " + result);
                }
            }
        }

        public Form1()
        {

            InitializeComponent();
            panel3.AutoScroll = true;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            panelwidth = Buttons_pnl_Sliding.Width;
            panel3.Visible = false;
            panel1.Visible = false;
             
        }
      

        private void Button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("Button Click .wav");
            sound.Play();
            TablePnl.Visible = true;
            ResPnl.Visible = false;
            QueryPnl.Visible = false;
            panel4.Visible = false;


        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("Button Click .wav");
            sound.Play();
            TablePnl.Visible = false;
            ResPnl.Visible = false;
            panel4.Visible = false;
            QueryPnl.Visible = true;
            clear();
            resultGrid.DataSource = null;
            try
            {
                if (comboBox1.SelectedItem.Equals("cars"))
                    resultGrid.DataSource = carTablel(assign_lbl1.Text, label3.Text, comboBox8.Text, comboBox2.Text, label8.Text);
                else if (comboBox1.SelectedItem.Equals("Departments"))
                    resultGrid.DataSource = DepartmentTable(assign_lbl1.Text, label3.Text, comboBox8.Text, comboBox2.Text, label8.Text);
                else if (comboBox1.SelectedItem.Equals("Employees"))
                    resultGrid.DataSource = EmployeesTable(assign_lbl1.Text, label3.Text, comboBox8.Text, comboBox2.Text, label8.Text);
            }
            catch (Exception ex)
            {
                SoundPlayer snd = new SoundPlayer("sms-alert.wav");
                snd.Play();
                MessageBox.Show("Please Select A Table First");
            }
        }

        private void Button3_Click(object sender, EventArgs e) //if click result
        {
            SoundPlayer sound = new SoundPlayer("Button Click .wav");
            sound.Play();
            TablePnl.Visible = false;
            panel4.Visible = false;
            ResPnl.Visible = true;
            QueryPnl.Visible = false;
            try
            {
                if (comboBox1.SelectedItem.Equals("cars"))
                    resultGrid.DataSource = carTablel(assign_lbl1.Text, label3.Text, comboBox8.Text, comboBox2.Text, label8.Text);
                else if (comboBox1.SelectedItem.Equals("Departments"))
                    resultGrid.DataSource = DepartmentTable(assign_lbl1.Text, label3.Text, comboBox8.Text, comboBox2.Text, label8.Text);
                else if (comboBox1.SelectedItem.Equals("Employees"))
                    resultGrid.DataSource = EmployeesTable(assign_lbl1.Text, label3.Text, comboBox8.Text, comboBox2.Text, label8.Text);

                Tbl.DataSource = null;
            }
            catch(Exception ex)
            {
                    SoundPlayer snd = new SoundPlayer("sms-alert.wav");
                    snd.Play();
                    MessageBox.Show("Please Select A Table First");
            }

        }
        string selectedItem;

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SoundPlayer sound = new SoundPlayer("Pen Clicking.wav");
            sound.Play();
            clear();
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

            else if (selectedItem == "Employees")
            {
                emps = new EmployeesList();
                empList = emps.read();
                Tbl.DataSource = empList;
                showColumns("Employees");
            }
        }
        private void showColumns(string type) //add columns names to each comboBox
        {
            comboBox8.Items.Clear();
            comboBox2.Items.Clear();
            comboBox7.Items.Clear();
            if (type == "Cars")
            {
                for (int i = 0; i < cars.colNames().Count; i++)
                {
                    comboBox8.Items.Add(cars.colNames()[i]);
                    comboBox2.Items.Add(cars.colNames()[i]);
                }
                comboBox7.Items.Add(cars.colNames()[0]); //aggregation functions stock Number
            }

            else if(type == "Departments")
            {
                for(int i=0; i<deps.colNames().Count; i++)
                {
                    comboBox8.Items.Add(deps.colNames()[i]);
                    comboBox2.Items.Add(deps.colNames()[i]);
                }
                comboBox7.Items.Add(deps.colNames()[2]); //aggregation functions for NumOfEmployees
            }

            else if (type == "Employees")
            {
                for (int i = 0; i < emps.colNames().Count; i++)
                {
                    comboBox8.Items.Add(emps.colNames()[i]);
                    comboBox2.Items.Add(emps.colNames()[i]);
                }
                comboBox7.Items.Add(emps.colNames()[3]); //aggregation functions for Salary
            }
        }
        
        private void Comparision_compobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("Pen Clicking.wav");
            sound.Play();
            int selectedIndex = Comparision_compobox.SelectedIndex;
            panel3.Visible = true;
            
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
                case 4:
                    assign_lbl1.Text = ">=";
                    //resultGrid.DataSource = result;
                    break;
                case 5:
                    assign_lbl1.Text = "<=";
                    //resultGrid.DataSource = result;
                    break;
                case 6:
                    assign_lbl1.Text = "IN";
                    //resultGrid.DataSource = result;
                    break;

                default:
                    break;
            }
       
    }
        
        private void Bool_Compobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("Pen Clicking.wav");
            sound.Play();
           
            panel1.Visible = true;
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
       

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("Pen Clicking.wav");
            sound.Play();
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
                case 4:
                    label3.Text = ">=";
                    //resultGrid.DataSource = result;
                    break;
                case 5:
                    label3.Text = "<=";
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
            textBox1.Text = "";
            bool_Compobox.Text = "";
            comboBox3.Text = "";
            label8.Text = "\"\"";
            comboBox2.Text = "";
            label3.Text = "lbl";
            textBox2.Text = "";
            Aggregate_combobox.Text = "";
            comboBox7.Text = "";
            label9.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            panel3.Visible = false;
            panel1.Visible = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("Button Click .wav");
            sound.Play();
            
            clear();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("Pen Clicking.wav");
            sound.Play();
            if (comboBox1.Text != "" && comboBox7.Text != "")
                AggregationTable(comboBox1.Text, comboBox7.Text);
        }

        private void Aggregate_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("Pen Clicking.wav");
            sound.Play();
            if (comboBox1.Text!="" && comboBox7.Text!="")
               AggregationTable(comboBox1.Text, comboBox7.Text);
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (label3.Text == "=" || label3.Text == "!=")
            {
                if (comboBox1.Text == "cars")
                {
                    for (int i = 0; i < carLst.Count; i++)
                    {
                        if (carLst[i].getCar(comboBox2.Text) == textBox2.Text)
                        {

                            SoundPlayer sound = new SoundPlayer("A-Tone.wav");
                            sound.Play();
                            pictureBox2.ImageLocation = @"t.png";
                            break;
                        }
                        else if (textBox2.Text == "")
                        {
                            pictureBox2.Image = null;
                        }
                        else
                        {
                           // SoundPlayer snd = new SoundPlayer("beep.wav");
                           // snd.Play();
                            pictureBox2.ImageLocation = @"f.png";
                        }
                    }
                }

                else if (comboBox1.Text == "Departments")
                {
                    for (int i = 0; i < deplist.Count; i++)
                    {
                        if (deplist[i].getDepartment(comboBox2.Text) == textBox2.Text)
                        {
                            SoundPlayer sound = new SoundPlayer("A-Tone.wav");
                            sound.Play();
                            pictureBox2.ImageLocation = @"t.png";
                            break;
                        }
                        else if (textBox2.Text == "")
                        {
                            pictureBox2.Image = null;
                        }
                        else
                        {
                            pictureBox2.ImageLocation = @"f.png";
                           // SoundPlayer snd = new SoundPlayer("beep.wav");
                           // snd.Play();
                        }
                    }
                }
                else if (comboBox1.Text == "Employees")
                {
                    for (int i = 0; i < empList.Count; i++)
                    {
                        if (empList[i].getEmployee(comboBox2.Text) == textBox2.Text)
                        {
                            SoundPlayer sound = new SoundPlayer("A-Tone.wav");
                            sound.Play();
                            pictureBox2.ImageLocation = @"t.png";
                            break;
                        }
                        else if (textBox2.Text == "")
                        {
                            pictureBox2.Image = null;
                        }
                        else
                        {
                            pictureBox2.ImageLocation = @"f.png";
                          //  SoundPlayer snd = new SoundPlayer("beep.wav");
                          //  snd.Play();
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (assign_lbl1.Text == "=" || assign_lbl1.Text == "!=")
            {
                if (comboBox1.Text == "cars")
                {
                    for (int i = 0; i < carLst.Count; i++)
                    {
                        if (carLst[i].getCar(comboBox8.Text) == textBox1.Text)
                        {
                            SoundPlayer sound = new SoundPlayer("A-Tone.wav");
                            sound.Play();
                            pictureBox1.ImageLocation = @"t.png";
                            break;
                        }
                        else if (textBox1.Text == "")
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = @"f.png";
                          //  SoundPlayer snd = new SoundPlayer("beep.wav");
                          //  snd.Play();

                        }
                    }
                }
                else if (comboBox1.Text == "Departments")
                {
                    for (int i = 0; i < deplist.Count; i++)
                    {
                        if (deplist[i].getDepartment(comboBox8.Text) == textBox1.Text)
                        {
                            SoundPlayer sound = new SoundPlayer("A-Tone.wav");
                            sound.Play();
                            pictureBox1.ImageLocation = @"t.png";
                            break;
                        }
                        else if (textBox1.Text == "")
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = @"f.png";
                           // SoundPlayer snd = new SoundPlayer("beep.wav");
                            //snd.Play();
                        }
                    }
                }
                else if (comboBox1.Text == "Employees")
                {
                    for (int i = 0; i < empList.Count; i++)
                    {
                        if (empList[i].getEmployee(comboBox8.Text) == textBox1.Text)
                        {
                            SoundPlayer sound = new SoundPlayer("A-Tone.wav");
                            sound.Play();
                            pictureBox1.ImageLocation = @"t.png";
                            break;
                        }
                        else if (textBox1.Text == "")
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            pictureBox1.ImageLocation = @"f.png";
                            //SoundPlayer snd = new SoundPlayer("beep.wav");
                           // snd.Play();
                        }
                    }
                }
            }

        }

        private void ExitPic_Click(object sender, EventArgs e)
        {
           
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.25;

            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }
       
        private void timer2_Tick(object sender, EventArgs e)
        {
           
            if (hidden)
            {
                
                Buttons_pnl_Sliding.Width += 10;
                TablePnl.Left += 10;
                QueryPnl.Left += 10;
                ResPnl.Left += 10;
              

                if (Buttons_pnl_Sliding.Width >= panelwidth)
                {
                    timer2.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                Buttons_pnl_Sliding.Width -= 10;
                TablePnl.Left -= 10;
                QueryPnl.Left -= 10;
                ResPnl.Left -= 10;
               
                
                if (Buttons_pnl_Sliding.Width <= 0)
                {
                    timer2.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("Pen Clicking.wav");
            sound.Play();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("Pen Clicking.wav");
            sound.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        void readEverything()
        {
            cars = new CarCollection();
            carLst = cars.read();
            deps = new DepartmentsList();
            deplist = deps.read();
            emps = new EmployeesList();
            empList = emps.read();
        }


        // 1)select *  2)select column  3)COUNT  4)Sum  5)Avg
        void sqlSerialze(string Query)
        {
            readEverything();
            string[] newQuery = Query.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            if (newQuery[0].ToLower() == "select")
            {
                // 1)Select *
                if (newQuery[1] == "*")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "cars")
                        {
                            sqlGridView.DataSource = carLst;
                        }
                        else if(newQuery[3] == "Departments")
                        {
                            sqlGridView.DataSource = deplist;
                        }
                        else if(newQuery[3] == "Employees")
                        {
                            sqlGridView.DataSource = empList;
                        }
                    }
                }

                // 2)Select Column
                if(newQuery[1] == "StockNumber")
                {
                    if(newQuery[2].ToLower() == "from")
                    {
                        if(newQuery[3] == "cars")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("StockNumber", typeof(string)));
                            for(int i=0; i<carLst.Count; i++)
                            dt.Rows.Add(carLst[i].StockNumber);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1] == "Make")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "cars")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Make", typeof(string)));
                            for (int i = 0; i < carLst.Count; i++)
                                dt.Rows.Add(carLst[i].Make);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1] == "Model")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "cars")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Model", typeof(string)));
                            for (int i = 0; i < carLst.Count; i++)
                                dt.Rows.Add(carLst[i].Model);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1] == "id")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Departments")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("id", typeof(string)));
                            for (int i = 0; i < deplist.Count; i++)
                                dt.Rows.Add(deplist[i].id);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1] == "Name")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Departments")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Name", typeof(string)));
                            for (int i = 0; i < deplist.Count; i++)
                                dt.Rows.Add(deplist[i].Name);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1] == "NumOfEmployees")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Departments")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("NumOfEmployees", typeof(string)));
                            for (int i = 0; i < deplist.Count; i++)
                                dt.Rows.Add(deplist[i].NumOfEmployees);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1] == "id")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Employees")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("id", typeof(string)));
                            for (int i = 0; i < empList.Count; i++)
                                dt.Rows.Add(empList[i].id);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1] == "Name")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Employees")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Name", typeof(string)));
                            for (int i = 0; i < empList.Count; i++)
                                dt.Rows.Add(empList[i].Name);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1] == "Gender")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Employees")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Gender", typeof(string)));
                            for (int i = 0; i < empList.Count; i++)
                                dt.Rows.Add(empList[i].Gender);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1] == "Salary")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Employees")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Salary", typeof(string)));
                            for (int i = 0; i < empList.Count; i++)
                                dt.Rows.Add(empList[i].Salary);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1] == "DepartmentId")
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Employees")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("DepartmentId", typeof(string)));
                            for (int i = 0; i < empList.Count; i++)
                                dt.Rows.Add(empList[i].DepartmentId);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }

                // 3)Select Count()
                if (newQuery[1].ToLower().Contains("count") && (newQuery[1].Contains("StockNumber") || newQuery[1].Contains("Make") || newQuery[1].Contains("Model")) )
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "cars")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Count", typeof(string)));
                            dt.Rows.Add(carLst.Count);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1].ToLower().Contains("count") && (newQuery[1].Contains("NumOfEmployees") || newQuery[1].Contains("id") || newQuery[1].Contains("Name")))
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Departments")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Count", typeof(string)));
                            dt.Rows.Add(deplist.Count);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1].ToLower().Contains("count") && (newQuery[1].Contains("Gender") || newQuery[1].Contains("id") || newQuery[1].Contains("Name") || newQuery[1].Contains("Salary") || newQuery[1].Contains("DepartmentId")))
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Employees")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Count", typeof(string)));
                            dt.Rows.Add(empList.Count);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }

                // 4)Select Sum()
                if (newQuery[1].ToLower().Contains("sum") && newQuery[1].Contains("StockNumber"))
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "cars")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Sum", typeof(string)));
                            int result = 0;
                            for (int i = 0; i < carLst.Count; i++)
                            {
                                result += int.Parse(carLst[i].StockNumber);
                            }
                            dt.Rows.Add(result);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1].ToLower().Contains("sum") && newQuery[1].Contains("NumOfEmployees"))
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Departments")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Sum", typeof(string)));
                            int result = 0;
                            for (int i = 0; i < deplist.Count; i++)
                            {
                                result += int.Parse(deplist[i].NumOfEmployees);
                            }
                            dt.Rows.Add(result);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1].ToLower().Contains("sum") && newQuery[1].Contains("Salary"))
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Employees")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Sum", typeof(string)));
                            int result = 0;
                            for (int i = 0; i < empList.Count; i++)
                            {
                                result += int.Parse(empList[i].Salary);
                            }
                            dt.Rows.Add(result);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }

                // 5)Avg()
                if (newQuery[1].ToLower().Contains("avg") && newQuery[1].Contains("StockNumber"))
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "cars")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Average", typeof(string)));
                            double result = 0;
                            for (int i = 0; i < carLst.Count; i++)
                            {
                                result += double.Parse(carLst[i].StockNumber);
                            }
                            result /= carLst.Count;
                            result = Math.Round(result, 3);
                            dt.Rows.Add(result);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1].ToLower().Contains("avg") && newQuery[1].Contains("NumOfEmployees"))
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Departments")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Average", typeof(string)));
                            double result = 0;
                            for (int i = 0; i < deplist.Count; i++)
                            {
                                result += double.Parse(deplist[i].NumOfEmployees);
                            }
                            result /= deplist.Count;
                            result = Math.Round(result, 3);
                            dt.Rows.Add(result);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
                if (newQuery[1].ToLower().Contains("avg") && newQuery[1].Contains("Salary"))
                {
                    if (newQuery[2].ToLower() == "from")
                    {
                        if (newQuery[3] == "Employees")
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add(new DataColumn("Average", typeof(string)));
                            double result = 0;
                            for (int i = 0; i < empList.Count; i++)
                            {
                                result += double.Parse(empList[i].Salary);
                            }
                            result /= empList.Count;
                            result = Math.Round(result, 3);
                            dt.Rows.Add(result);
                            sqlGridView.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            sqlGridView.DataSource = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sqlSerialze(textBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TablePnl.Visible = false;
            ResPnl.Visible = false;
            QueryPnl.Visible = true;
            panel4.Visible = true;
        }
    }
}
