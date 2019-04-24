using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Quering_module
{
    public class Employee
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Salary { get; set; }
        public string DepartmentId { get; set; }


        public string getEmployee(string colName)
        {

            if (colName == "id") return id;
            else if (colName == "Name") return Name;
            else if (colName == "Gender") return Gender;
            else if (colName == "Salary") return Salary;
            else if (colName == "DepartmentId") return DepartmentId;
            return null;
        }

    }


    public class EmployeesList
    {
        public List<Employee> read()
        {
            List<Employee> emps = new List<Employee>();

            XmlSerializer serializer = new XmlSerializer(emps.GetType());

            StreamReader reader = new StreamReader("Employees.xml");
            emps = (List<Employee>)serializer.Deserialize(reader);
            reader.Close();
            return emps;

        }

        public List<string> colNames()
        {
            List<string> lst = new List<string>();
            lst.Add("id");
            lst.Add("Name");
            lst.Add("Gender");
            lst.Add("Salary");
            lst.Add("DepartmentId");
            return lst;
        }

    }


}
