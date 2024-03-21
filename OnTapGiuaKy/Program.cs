using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapGiuaKy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Lấy danh sách các Employee, Position và Department
            List<Employee> employees = Employee.employeeList();
            List<Position> positions = Position.positionList();
            List<Department> departments = Department.departmentList();

            // Nhập thông tin tìm kiếm từ người dùng
            Console.Write("Nhập từ khóa tìm kiếm:");
            string keyword = Console.ReadLine();
            Console.Write("Tuổi từ:");
            int minAge = int.Parse(Console.ReadLine());
            Console.Write("Đến tuổi:");
            int maxAge = int.Parse(Console.ReadLine());
            Console.Write("Vị trí:");
            string position = Console.ReadLine();
            Console.Write("Phòng ban:");
            string department = Console.ReadLine();

            // Thực hiện tìm kiếm sử dụng LINQ
            var result = from emp in employees
                         join pos in positions on emp.position_id equals pos.id
                         join dep in departments on emp.depatment_id equals dep.id
                         where (emp.name.Contains(keyword) || pos.name.Contains(keyword) || dep.name.Contains(keyword))
                               && emp.TinhTuoi() >= minAge && emp.TinhTuoi() <= maxAge
                         select new
                         {
                             EmployeeName = emp.name,
                             EmployeeAge = emp.TinhTuoi(),
                             Position = pos.name,
                             Department = dep.name
                         };

            // In kết quả
            foreach (var item in result)
            {
                Console.WriteLine($"Tên nhân viên: {item.EmployeeName}, Tuổi: {item.EmployeeAge}, Vị trí: {item.Position}, Phòng ban: {item.Department}");
            }
            Console.ReadKey(); 

        }
    }
}
