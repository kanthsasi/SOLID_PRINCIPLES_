using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principals
{
    public class Generate_Report
    {
         //Definition:
         //Open for Extensions and closed for Modification.
         //-----------------------Without OCP:-------------------------------------
       
             public  string type { get; set; }

             public void GetStudentReport()
             {
                 if (type == "HTML")
                 {
                     Console.WriteLine("HTML Student Report");
                 }
                 //New modification  after the project created.
                 else if (type == "XML")
                 {
                     Console.WriteLine("XML Student Report");
                 }
                 else
                 {
                     Console.WriteLine("JSON Student Report");
                 }
             }
         }
    //---------------------------------With OCP:-----------------------------------------------

    public interface IGenerateReport
    {
        void StudentReport1();
    }

    public class HTMLReport : IGenerateReport
    {
        public void StudentReport1()
        {
            Console.WriteLine("HTML Student Report");
        }
    }

    public class XMLReport : IGenerateReport
    {
        public void StudentReport1()
        {
            Console.WriteLine("XML Student Report");
        }
    }

    public class JSONReport : IGenerateReport
    {
        public void StudentReport1()
        {
            Console.WriteLine("JSON Student Report");
        }
    }


}


