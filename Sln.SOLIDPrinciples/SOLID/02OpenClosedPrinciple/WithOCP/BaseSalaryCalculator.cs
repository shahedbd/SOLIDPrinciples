using SOLID.Entity;

namespace SOLID.OpenClosedPrinciple.WithOCP
{
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }

        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double CalculateSalary();
    }
}
