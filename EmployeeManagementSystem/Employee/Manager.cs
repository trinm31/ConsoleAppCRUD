using System;
using EmployeeManagementSystem.Employee.IEmployee;

namespace EmployeeManagementSystem.Employee
{
    public class Manager: IEmployee.IEmployee, IManager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string ChucVu { get; set; }
        
        public Manager(int id, string name, DateTime startDate, string chucVu)
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            ChucVu = chucVu;
        } 
        
        public void Doing()
        {
            Console.WriteLine("Manager is doing sth....");
        }

        public void Manage()
        {
            Console.WriteLine("Manager is manage sth....");
        }
    }
}