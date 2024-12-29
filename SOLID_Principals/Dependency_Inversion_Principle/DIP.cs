using System;

using static SOLID_Principals.Dependency_Inversion_Principle.Intimation;

namespace SOLID_Principals.Dependency_Inversion_Principle
{
    public class Switch
    {
        private readonly ILight light;

        public Switch(ILight light)
        {
            this.light = light;
        }

        public void Operate(bool turnOn)
        {
            if (turnOn)
            {
                light.TurnOn();
            }
            else
            {
                light.TurnOff();
            }

        }
    }



}

