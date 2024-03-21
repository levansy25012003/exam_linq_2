using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapGiuaKy
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDay { get; set; }
        public int depatment_id { get; set; }
        public int position_id { get; set; }
        public Employee(int id, string name, DateTime birthDay, int depatment_id, int position_id)
        {
            this.id = id;
            this.name = name;
            this.birthDay = birthDay;
            this.depatment_id = depatment_id;
            this.position_id = position_id;
        }
        public static List<Employee> employeeList()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee(1, "Nguyen Van A", new DateTime(2003, 5, 15), 1, 1));
            list.Add(new Employee(2, "Tran Thi B", new DateTime(2003, 10, 25), 2, 2));
            list.Add(new Employee(3, "Hoang Van C", new DateTime(2003, 3, 8), 3, 3));
            list.Add(new Employee(4, "Le Thi D", new DateTime(2001, 9, 12), 1, 2));
            list.Add(new Employee(5, "Pham Van E", new DateTime(2002, 7, 20), 2, 3));
            list.Add(new Employee(6, "Doan Thi F", new DateTime(2000, 1, 5), 3, 1));
            list.Add(new Employee(7, "Trinh Van G", new DateTime(2003, 12, 3), 1, 3));
            list.Add(new Employee(8, "Nguyen Thi H", new DateTime(2002, 8, 18), 2, 1));
            list.Add(new Employee(9, "Vo Van I", new DateTime(2001, 4, 30), 3, 2));
            list.Add(new Employee(10, "Vu Thi K", new DateTime(2003, 6, 28), 1, 2));
            return list;
        }


        // Phương thức để tính tuổi từ ngày tháng năm sinh
        public int TinhTuoi()
        {
            DateTime ngayHienTai = DateTime.Today;
            int tuoi = ngayHienTai.Year - birthDay.Year;

            // Kiểm tra xem ngày hiện tại đã qua ngày sinh của nhân viên chưa
            if (birthDay.Date > ngayHienTai.AddYears(-tuoi))
            {
                tuoi--;
            }

            return tuoi;
        }
    }
}
