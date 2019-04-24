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

        List<Car> result = new List<Car>();
        public void oo(string comparison)
        {
          
            if (queryPnl.Count>0)
            {
                for (int j = 0; j < queryPnl.Count; j++)
                {
                    if (comparison == "=")
                    {
                        if (queryPnl[j].getComboBox().SelectedItem.ToString() == cars.colNames()[0])
                        {
                            for (int i = 0; i < carLst.Count; i++)
                            {
                                if (carLst[i].StockNumber == queryPnl[j].getTextBox().Text)
                                {
                                    if(!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                        }
                        else if (queryPnl[j].getComboBox().SelectedItem.ToString() == cars.colNames()[1])
                        {
                            for (int i = 0; i < carLst.Count; i++)
                            {
                                if (carLst[i].Make == queryPnl[j].getTextBox().Text)
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                        }
                        else if (queryPnl[j].getComboBox().SelectedItem.ToString() == cars.colNames()[2])
                        {
                            for (int i = 0; i < carLst.Count; i++)
                            {
                                if (carLst[i].Model == queryPnl[j].getTextBox().Text)
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                        }
                    }
                    else if (comparison == ">")
                    {
                        if (queryPnl[j].getComboBox().SelectedItem.ToString() == cars.colNames()[0])
                        {
                            for (int i = 0; i < carLst.Count; i++)
                            {
                                if ( int.Parse(carLst[i].StockNumber) > int.Parse(queryPnl[j].getTextBox().Text))
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                        }
                    }
                    else if (comparison == "<")
                    {
                        if (queryPnl[j].getComboBox().SelectedItem.ToString() == cars.colNames()[0])
                        {
                            for (int i = 0; i < carLst.Count; i++)
                            {
                                if (int.Parse(carLst[i].StockNumber) < int.Parse(queryPnl[j].getTextBox().Text))
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                        }
                    }
                    else if (comparison == "!=")
                    {
                        if (queryPnl[j].getComboBox().SelectedItem.ToString() == cars.colNames()[0])
                        {
                            for (int i = 0; i < carLst.Count; i++)
                            {
                                if (carLst[i].StockNumber != queryPnl[j].getTextBox().Text)
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                        }
                        else if (queryPnl[j].getComboBox().SelectedItem.ToString() == cars.colNames()[1])
                        {
                            for (int i = 0; i < carLst.Count; i++)
                            {
                                if (carLst[i].Make != queryPnl[j].getTextBox().Text)
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                        }
                        else if (queryPnl[j].getComboBox().SelectedItem.ToString() == cars.colNames()[2])
                        {
                            for (int i = 0; i < carLst.Count; i++)
                            {
                                if (carLst[i].Model != queryPnl[j].getTextBox().Text)
                                {
                                    if (!result.Contains(carLst[i]))
                                        result.Add(carLst[i]);
                                }
                            }
                        }
                    }
                }
            }
        }


        private List<typesOfquery> queryPnl;
        public Form1()
        {
            InitializeComponent();
            panel3.AutoScroll = true;
            queryPnl = new List<typesOfquery>();
            queryPnl.Add(new typesOfquery());
            panel3.Controls.Add(queryPnl[0]);

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

        private void Button3_Click(object sender, EventArgs e)
        {
            TablePnl.Visible = false;
            ResPnl.Visible = true;
            QueryPnl.Visible = false;
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
        private void showColumnsOfCars()
        {
            for (int i = 0; i < cars.colNames().Count; i++)
            {
                queryPnl[0].getComboBox().Items.Add(cars.colNames()[i]);
                

            }
            
        }
        private int clicked = 0;
        List<string> comp = new List<string>();
        private void Comparision_compobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Comparision_compobox.SelectedIndex;
            
            switch (selectedIndex)
            {
                case 0:
                    queryPnl[panel3.Controls.Count - 1].setComparison(">");
                    //comp.Add(">");
                    oo(">");
                    resultGrid.DataSource = result;
                    break;
                case 1:
                    queryPnl[panel3.Controls.Count - 1].setComparison("<");
                    oo("<");
                    resultGrid.DataSource = result;
                    break;
                case 2:
                    queryPnl[panel3.Controls.Count - 1].setComparison("=");
                    oo("=");
                    resultGrid.DataSource = result;
                    break;
                case 3:
                    queryPnl[panel3.Controls.Count - 1].setComparison("!=");
                    oo("!=");
                    resultGrid.DataSource = result;
                    break;

                default:
                    break;
            }
       
    }

        private void GetselectedTable(string s)
        {
            if (s == "cars")
            {
                queryPnl[queryPnl.Count - 1].setcolumnsNames(cars.colNames());
            }
        }
        private void Bool_Compobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = bool_Compobox.SelectedIndex;
            switch (selectedIndex)
            {
                case 0: //And
                    queryPnl.Add(new typesOfquery());
                    queryPnl[queryPnl.Count - 1].setAndOR("And");
                    GetselectedTable(selectedItem);

                        break;
                case 1: //Or
                    queryPnl.Add(new typesOfquery());
                    queryPnl[queryPnl.Count - 1].setAndOR("OR");
                    GetselectedTable(selectedItem);
                    break;
                default:
                    break;
            }
            AddqueryPnlToForm();
        }
        private void AddqueryPnlToForm()
        {
            queryPnl[queryPnl.Count - 1].Location = new Point(0, (panel3.Controls.Count * queryPnl[0].Height));
            queryPnl[queryPnl.Count - 1].getTextBox().TextChanged += new EventHandler(textBox_TextChanged);
            
            panel3.Controls.Add(queryPnl[queryPnl.Count - 1]);
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
    }
}
