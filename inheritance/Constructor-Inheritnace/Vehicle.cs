using System;

namespace Constructor_Inheritnace
{
    public class Vehicle
    {
        private string _rigistrationName;

        public Vehicle(string rigistrationName)
        {
            _rigistrationName = rigistrationName;
            RegistrationNumerFun();
        }

        private void RegistrationNumerFun()
        {
            Console.WriteLine($"rigistrationName : {_rigistrationName}");
        }
    }
}
