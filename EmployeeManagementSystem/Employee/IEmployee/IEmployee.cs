using System;

namespace EmployeeManagementSystem.Employee.IEmployee
{
    public interface IEmployee
    {
        // property area
        int Id { get; set; }
        string Name { get; set; }
        DateTime StartDate { get; set; }
        string ChucVu { get; set; }
        
        // Method area 
        void Doing();

    }
}