using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_workshop.Models
{
    public class Employee(string name, string lastName, string email, double baseAmount, double pensionPercent, double healthPercent, double cooperationPercent)
    {
        private Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public string LastName { get; set;} = lastName;
        public string Email { get; set; } = email;
        public double BaseAmount { get; set;} = baseAmount;
        public double PensionPercent { get; set;} = pensionPercent;
        public double HealthPercent { get; set;} = healthPercent;
        public double CooperationPercent { get; set;} = cooperationPercent;

        public double CalculatorAmount(double BaseAmount, double PensionPercent, double HealthPercent, double CooperationPercent)
        {
            BaseAmount *= (PensionPercent / 100) + (HealthPercent / 100) + (CooperationPercent / 100);
            return BaseAmount;
        }

        private double CalculatorDeduction(double BaseAmount, double PensionPercent, double HealthPercent, double CooperationPercent)
        {
            double DeductionPencion = BaseAmount * (PensionPercent / 100);
            double DeductionHealth = BaseAmount * (HealthPercent / 100);
            double DeductionCooperation = BaseAmount * (CooperationPercent / 100);

            double Deduction = DeductionPencion + DeductionHealth + DeductionCooperation;            
            return Deduction;
        }

        private double CalculatorSaving(double BaseAmount, double CooperationPercent)
        {
            double SavingCooperation = BaseAmount * (CooperationPercent / 100);
            return SavingCooperation;
        }
    }
}