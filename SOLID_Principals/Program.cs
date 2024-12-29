using System;


namespace SOLID_Principals
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Without SRP:

            Employee employee = new Employee();
            Console.WriteLine("[Without Single Responsiblity Principle.......]");
            employee.AddEmployee();
            Console.WriteLine(employee.GetEmployeeReport());

            //With SRP:

            Student student = new Student();
            StudentReport studentReport = new StudentReport();
            Console.WriteLine("[With Single Responsiblity Principle.......]");
            student.AddStudent();
            studentReport.GetStudentReport();

            //Without OCP:

            Generate_Report generate_Report = new Generate_Report();
            Console.WriteLine("[Without Open Closed Principle.......]");
            generate_Report.GetStudentReport();

            //With OCP:

            HTMLReport hTML_Report = new HTMLReport();
            XMLReport xML_Report = new XMLReport();
            JSONReport jSON_Report = new JSONReport();
            Console.WriteLine("[With Open Closed Principle.......]");
            hTML_Report.StudentReport1();
            xML_Report.StudentReport1();
            jSON_Report.StudentReport1();

            //Without ISP:

            PermanentEmployee permanentEmployee = new PermanentEmployee();
            Console.WriteLine("[Without Interface Segregation Principle]");
            Console.WriteLine("Permanent Employee Salary:"+(permanentEmployee.basesalary()+permanentEmployee.variable()+permanentEmployee.hraallowance()));
            ContractEmployee contractEmployee = new ContractEmployee();
            Console.WriteLine("Contract Employee:"+ (contractEmployee.basesalary()+contractEmployee.hraallowance()
             +contractEmployee.variable()));

            //With ISP:

            permanentEmployee PermanentEmployee = new permanentEmployee();
            Console.WriteLine("[With Interface Segregation Principle]");
            Console.WriteLine("Permanent Employee Salary:" + (PermanentEmployee.Basesalary() + PermanentEmployee.Variable() + PermanentEmployee.Hraallowance()));
            contractEmployee ContractEmployee = new contractEmployee();
            Console.WriteLine("Contract Employee Salary Without Variable Pay:" + (ContractEmployee.Basesalary() + ContractEmployee.Hraallowance()));
        }
    }

}