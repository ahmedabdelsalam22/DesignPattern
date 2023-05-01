using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.BuilderPattern.example1
{
    public class SallaryCalculationBuilder
    {
        private int _taxPercentage = 0;
        private decimal _bonusPercentage = 0;
        private decimal _educationPackage = 0;
        private decimal _transportation = 0;
        private bool _sendPaysLipToEmployee = true;
        private bool _postResultToGL = true;

        public SallaryCalculationBuilder WithTaxes(int taxPercentage)
        {
            LoggMessage($"{taxPercentage} taxes will be deducted.");
            _taxPercentage = taxPercentage;
            return this;
        }
        public SallaryCalculationBuilder WithBonus(decimal bonusPercentage)
        {
            LoggMessage($"{bonusPercentage} bonus will be added.");
            _bonusPercentage = bonusPercentage;
            return this;
        }
        public SallaryCalculationBuilder WithEducationPackage(decimal educationPackage)
        {
            LoggMessage($"{educationPackage} EG educationel package will be added.");

            _educationPackage = educationPackage;
            return this;
        }
        public SallaryCalculationBuilder WithTransportation(decimal transportation)
        {
            LoggMessage($"{transportation} EG transportation will be added.");
            _transportation = transportation;
            return this;
        }
        public SallaryCalculationBuilder SendPaysLipToEmployee(bool sendPaysLipToEmployee)
        {
            _sendPaysLipToEmployee = sendPaysLipToEmployee;
            return this;
        }
        public SallaryCalculationBuilder PostResultToGL(bool postResultToGL)
        {
            _postResultToGL = postResultToGL;
            return this;
        }

        private void LoggMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //build object 

        public SallaryCalculator Build()
        {
            return new SallaryCalculator(_taxPercentage, _bonusPercentage, _educationPackage,
                _transportation, _sendPaysLipToEmployee, _postResultToGL);
        }

    }
}
