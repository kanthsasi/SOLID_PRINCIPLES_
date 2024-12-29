using System;

namespace SOLID_Principals
{
   //------------------------------Without SRP:-----------------------------------------------
    public class Employee
    {
        //Definition:
        //-->Each and Every class or module should have only one reason to change.
        //-->Each and Every class or module should have only one responsibility.
        
        public string EmployeeName { get; set; }
        public int EmployeeMobile { get; set; }

        public void AddEmployee()
        {
            //Database Save
            Console.WriteLine("Employee Added");
        }

        public string GetEmployeeReport()
        {
            return "Employee Report";
        }

    }
    //----------------------------------With SRP:-----------------------------------------------
    //-->Each and Every class or module should have only one responsibility.
    public class Student
    {
        public string StudentName { get; set; }
        public int StudentRollNumber { get; set; }

        public void AddStudent()
        {
            Console.WriteLine("Student Added");
        }
        
    }

    public class StudentReport
    {
        public void GetStudentReport()
        {
            Console.WriteLine("Student Report");
        }
    }
}
