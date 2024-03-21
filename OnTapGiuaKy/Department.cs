using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapGiuaKy
{
    class Department
    {
        public int id { get; set; }
        public string name { get; set; }

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static List<Department> departmentList()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department(1, "HR"));
            list.Add(new Department(2, "QC"));
            list.Add(new Department(3, "VIP"));

            return list;
        }

    }
}
