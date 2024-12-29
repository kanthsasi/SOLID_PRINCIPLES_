using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principals
{
    public interface Isalary
    {
        //Definitions:
        //-->A class must not have to implement any interface which is not required by the class. 

        double Basesalary();
        double Hraallowance();

    }

    public interface IVariablePay
    {
        double Variable();
    }

    public class permanentEmployee : Isalary
    {
        public double Basesalary()
        {
            return 50000;
        }
        public double Hraallowance()
        {
            return 16000;
        }
        public double Variable()
        {
            return 12000;
        }
    }
    public class contractEmployee : Isalary
    {
        public double Basesalary()
        {
            return 30000;

        }
        public double Hraallowance()
        {
            return 5000;

        }
       
    }
}
