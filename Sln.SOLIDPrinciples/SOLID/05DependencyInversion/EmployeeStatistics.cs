using SOLID.ZCommon;
using System.Linq;

namespace SOLID._05DependencyInversion
{
    public class EmployeeStatistics
    {
        private readonly EmployeeManager _empManager;

        public EmployeeStatistics(EmployeeManager empManager)
        {
            _empManager = empManager;
        }

        public int CountFemaleManagers() =>
      _empManager.Employees.Count(emp => emp.Gender == Gender.Female && emp.Position == Position.Manager);

    }
}
