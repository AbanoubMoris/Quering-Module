using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quering_module
{
    [Serializable]
    class product
    {
        public int Id;
        public String Name;
        public int price;

        public List<product> prod = new List<product>();
        public void ReadData()
        {
            XmlSerializer xsSubmit = new XmlSerializer(prod.GetType());
        }
    }
}
