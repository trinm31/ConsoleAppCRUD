using System;

namespace EmployeeManagementSystem.Employee
{
    public class Staff: IEmployee.IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string ChucVu { get; set; }
        
        public Staff(int id, string name, DateTime startDate, string chucVu)
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            ChucVu = chucVu;
        } 
        
        public void Doing()
        {
            Console.WriteLine("Staff is doing sth");
        }
    }
}