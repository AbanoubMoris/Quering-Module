using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quering_module
{
    public partial class typesOfquery : UserControl
    {
        public typesOfquery()
        {
            InitializeComponent();
        }
        public void setAndOR(string s)
        {
            AndOR_lbl1.Text = s;
        }
        public string getAndOR()
        {
            return AndOR_lbl1.Text;
        }
        
        public void setcolumnsNames(List<string> s)
        {
            for (int i = 0; i < s.Count; i++)
            {
                comboBox8.Items.Add(s[i]);
            }
        }
        public List<string> getcolumnsNames()
        {
            List<string> x = new List<string>();
            for (int i = 0; i < comboBox8.Items.Count; i++)
            {
                x.Add(comboBox8.GetItemText(comboBox8.Items[i]));
            }
            return x;
        }
        public string getChoosedDate()
        {
            return textBox2.Text;
        }
        public void setChoosedDate(string s)
        {
            textBox2.Text = s;
        }
        public void SetPicture(string path)
        {
            pictureBox2.ImageLocation = path;
        }

    }
}
