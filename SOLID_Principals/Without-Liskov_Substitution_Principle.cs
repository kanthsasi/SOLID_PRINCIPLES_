
using System;


namespace SOLID_Principals
{
    //-----------------------------Without LSP:------------------------------------------------------
    public class GenerateStudentReport
    {
     
        public interface IGenerateReport
        {
            void StudentReport();
            void ReportTemplate();
        }


        public class Report_HTML : IGenerateReport
        {
            public string Format { get; set; }
            public void ReportTemplate()
            {
                Console.WriteLine("Format:"+Format+"HTML");
            }

            public void StudentReport()
            {
                Console.WriteLine("HTML Student Report");
            }
        }

        public class Report_XML : IGenerateReport
        {
            public string Format { get; set; }
            public void ReportTemplate()
            {
                Console.WriteLine("Format:"+Format + "XML");
            }

            public void StudentReport()
            {
                Console.WriteLine("XML Student Report");
            }
        }

        public class Report_JSON : IGenerateReport
        {
            public string Format { get; set; }
            public void ReportTemplate()
            {
                Console.WriteLine("Format:"+Format + "JSON");
            }

            public void StudentReport()
            {
                Console.WriteLine("JSON Student Report");
            }
        }
       /* static void Main()
        {
            IGenerateReport generateReport = new Report_HTML();
            generateReport.StudentReport();
            generateReport.ReportTemplate();
            generateReport = new Report_XML();
            generateReport.StudentReport();
            generateReport.ReportTemplate();
            generateReport = new Report_JSON();
            generateReport.StudentReport();
            generateReport.ReportTemplate();
        }
       */
    }
   
}
