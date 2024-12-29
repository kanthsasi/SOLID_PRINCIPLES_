using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principals
{
    public class GenerateStaffReport
    {
        //Definition By Barbara Liskov:

        //If "S" is a subtype (child) of type "T" , then the object of type "T" may be replaced with object of type "S".
        //Extensions of Open Closed Principle.
        //A-Parent
        //B-Child
        //A_a = new B();

        //Conditions:

        //1.Child class object must be substitute for a parent class object, and it should not give an incorrect output.
        //2.Child must have all the methods from the parent,it should not throw not implemented exception.
        //3.Child doesn't change the signature of the parent function.

        //--------------------------With LSP:-----------------------------------------------------------
        public interface IGenerateStaffReport
            {
                void StaffReport();
            }

            public interface IStaffReportFormat
            {
                void StaffReportTemplate();
            }

            public abstract class FormatReport : IGenerateStaffReport, IStaffReportFormat
            {
                public abstract void StaffReport();
                public abstract void StaffReportTemplate();
            }

            public class HTML_Report : FormatReport
            {
                public string Format { get; set; }
                public override void StaffReportTemplate()
                {
                    Console.WriteLine("Format:"+Format + "HTML");
                }

                public override void StaffReport()
                {
                    Console.WriteLine("HTML Staff Report");
                }
            }

            public class XML_Report : IGenerateStaffReport
            {
                public void StaffReport()
                {
                    Console.WriteLine("XML Staff Report");
                }
            }

            public class JSON_Report : IGenerateStaffReport
            {

                public void StaffReport()
                {
                    Console.WriteLine("JSON Staff Report");
                }
            }

       /* static void Main()
        {
            IGenerateStaffReport generateStaffReport = new HTML_Report();
            generateStaffReport.StaffReport();
            FormatReport formatReport = new HTML_Report();
            formatReport.StaffReportTemplate();
            generateStaffReport = new JSON_Report();
            generateStaffReport.StaffReport();
            generateStaffReport = new XML_Report();
            generateStaffReport.StaffReport();
            

        }
       */
    }

   
}

