using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principals
{
     public interface ISalary 
     {
        //Definitions:
        //-->A class must not have to implement any interface which is not required by the class. 

        double basesalary();
        double hraallowance();
        double variable();
        
     }
    public class PermanentEmployee : ISalary
    {
        public double basesalary()
        {
            return 30000;
        }
        public double hraallowance()
        {
            return 8000;
        }
        public double variable()
        {
            return 6000;
        }
    }
    public class ContractEmployee : ISalary
    {
        public double basesalary()
        {
            return 20000;
           
        }
        public double hraallowance()
        {
            return 3000;
            
        }
        public double variable()
        {
            return 1000;
        }
    }



}
