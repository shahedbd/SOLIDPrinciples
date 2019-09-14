using SOLID.Entity;
using System.Collections.Generic;

namespace SOLID.OpenClosedPrinciple
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;

        public SalaryCalculator(List<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devReport in _developerReports)
            {
                totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
            }

            return totalSalaries;
        }

        public double CalculateTotalSalaries2()
        {
            double totalSalaries = 0D;

            foreach (var devReport in _developerReports)
            {
                if (devReport.Level == "Senior developer")
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours * 1.2;
                }
                else
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
                }
            }

            return totalSalaries;
        }

    }
}
