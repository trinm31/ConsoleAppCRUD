using System;
using EmployeeManagementSystem.Employee.IEmployee;

namespace EmployeeManagementSystem.Employee
{
    public class Boss: IEmployee.IEmployee, IBoss
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string ChucVu { get; set; }

        public Boss(int id, string name, DateTime startDate, string chucVu)
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            ChucVu = chucVu;
        }
        
        public void Doing()
        {
            Console.WriteLine("Boss is doing sth ....");
        }

        public void Operating()
        {
            Console.WriteLine("Boss is operating sth ....");
        }
    }
}