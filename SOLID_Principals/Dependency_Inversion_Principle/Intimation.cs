using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principals.Dependency_Inversion_Principle
{
    internal class Intimation
    {
        public interface ILight
        {
            void TurnOn();
            void TurnOff();
        }

        public class LightBulb : ILight
        {
          
            public void TurnOn()
            {
                Console.WriteLine("Turn on LightBuib");
            }
            public void TurnOff()
            {
                Console.WriteLine("Turn off LightBulb");
            }
        }
    }
}
