using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Quering_module
{
    public class Department
    {
        public string id { get; set; }
        public string Name { get; set; }
    }

    public class DepartmentsList
    {
        public List<Department> read()
        {
            List<Department> deps = new List<Department>();

            XmlSerializer serializer = new XmlSerializer(deps.GetType());

            StreamReader reader = new StreamReader("Departments.xml");
            deps = (List<Department>)serializer.Deserialize(reader);
            reader.Close();
            return deps;

        }


    }
}
