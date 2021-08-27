using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagementSystem.Employee;
using EmployeeManagementSystem.Employee.IEmployee;

namespace EmployeeManagementSystem.Services
{
   
    
    public class CRUDService
    {
        // storage area 
        public static List<IEmployee> EmployeeList = new List<IEmployee>();
        // show 

        public void Show()
        {
            Console.WriteLine("List Nhân viên: ");
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine($"Id của nhân viên {employee.Id}");
                Console.WriteLine($"Ten của nhân viên {employee.Name}");
                Console.WriteLine($"Chức vụ của nhân viên {employee.ChucVu}");
                Console.WriteLine($"Ngày bắt đầu làm việc của nhân viên {employee.StartDate}");
            }
        }

        // FindID

        public void FindId(int id)
        {
            var employees = from s in EmployeeList where s.Id == id select s;
            foreach (var employee in employees)
            {
                Console.WriteLine($"Id của nhân viên {employee.Id}");
                Console.WriteLine($"Ten của nhân viên {employee.Name}");
                Console.WriteLine($"Chức vụ của nhân viên {employee.ChucVu}");
                Console.WriteLine($"Ngày bắt đầu làm việc của nhân viên {employee.StartDate}");
            }
        }

        // FindName
        public void FindName(string name)
        {
            var employees = from s in EmployeeList where s.Name == name select s;
            foreach (var employee in employees)
            {
                Console.WriteLine($"Id của nhân viên {employee.Id}");
                Console.WriteLine($"Ten của nhân viên {employee.Name}");
                Console.WriteLine($"Chức vụ của nhân viên {employee.ChucVu}");
                Console.WriteLine($"Ngày bắt đầu làm việc của nhân viên {employee.StartDate}");
            }
        }

        // FindChucVu
        public void FindChucVu(string chucVu)
        {
            var employees = from s in EmployeeList where s.ChucVu == chucVu select s;
            foreach (var employee in employees)
            {
                Console.WriteLine($"Id của nhân viên {employee.Id}");
                Console.WriteLine($"Ten của nhân viên {employee.Name}");
                Console.WriteLine($"Chức vụ của nhân viên {employee.ChucVu}");
                Console.WriteLine($"Ngày bắt đầu làm việc của nhân viên {employee.StartDate}");
            }
        }

        // Add
        public void Add(int input)
        {
            int id;
            string name;
            DateTime dateStart;
            string chucVu;
            
            switch (input)
            {
                case 1:
                    Console.Write("Enter Id");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name");
                    name = Console.ReadLine();
                    Console.Write("Enter Date start");
                    dateStart = Convert.ToDateTime(Console.ReadLine());
                    chucVu = "staff";
                    Staff staff = new Staff(id, name, dateStart, chucVu);
                    EmployeeList.Add(staff);
                    break;
                case 2:
                    Console.Write("Enter Id");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name");
                    name = Console.ReadLine();
                    Console.Write("Enter Date start");
                    dateStart = Convert.ToDateTime(Console.ReadLine());
                    chucVu = "manager";
                    Manager manager = new Manager(id, name, dateStart, chucVu);
                    EmployeeList.Add(manager);
                    break;
                case 3:
                    Console.Write("Enter Id");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Name");
                    name = Console.ReadLine();
                    Console.Write("Enter Date start");
                    dateStart = Convert.ToDateTime(Console.ReadLine());
                    chucVu = "boss";
                    Boss boss = new Boss(id, name, dateStart, chucVu);
                    EmployeeList.Add(boss);
                    break;
            }
        }

        // Updated
        public void Update(int id)
        {
            if (id != null)
            {
                Console.WriteLine("Nhập vào tên cần sửa");
                EmployeeList.FirstOrDefault(e => e.Id == id).Name = Console.ReadLine();
                Console.WriteLine("Nhập vào chức vụ cần sửa");
                EmployeeList.FirstOrDefault(e => e.Id == id).ChucVu = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        // Delete
        
        public void Delete(int id)
        {
            if (id != null)
            {
                EmployeeList.Remove(EmployeeList.Where(e => e.Id == id).First());
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}