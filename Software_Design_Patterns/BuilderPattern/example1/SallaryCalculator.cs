using Software_Design_Patterns.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.BuilderPattern.example1
{
    public class SallaryCalculator
    {
        public SallaryCalculator(
            int taxPercentage = 0, decimal bonusPercentage = 0, decimal educationPackage = 0, decimal transportation = 0,
            bool sendPaysLipToEmployee = true, bool postResultToGL = true)
        {
            TaxPercentage = taxPercentage;
            BonusPercentage = bonusPercentage;
            EducationPackage = educationPackage;
            Transportation = transportation;
            SendPaysLipToEmployee = sendPaysLipToEmployee;
            PostResultToGL = postResultToGL;
        }

        public int TaxPercentage { get; }
        public decimal BonusPercentage { get; }
        public decimal EducationPackage { get; }
        public decimal Transportation { get; }
        public bool SendPaysLipToEmployee { get; }
        public bool PostResultToGL { get; }

        public decimal Calculate(Employee employee)
        {
            var bonus = employee.BasicSallary * BonusPercentage / 100;
            var taxes = employee.BasicSallary * TaxPercentage / 100;
            var sallary = employee.BasicSallary * EducationPackage * Transportation * bonus - taxes;

            Console.ForegroundColor = ConsoleColor.Green;
            if (SendPaysLipToEmployee)
            {
                Console.WriteLine($"PaysLip send to {employee.Email}");
            }
            if (PostResultToGL)
            {
                Console.WriteLine($"Sallary voucher with total ammount ({sallary} EGP) has been sent to GL");
            }
            Console.ForegroundColor = ConsoleColor.White;

            return sallary;
        }
    }
}
