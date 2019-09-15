using SOLID.ZCommon;
using System.Linq;

namespace SOLID._05DependencyInversion.WithDIP
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _emp;

        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }

        public int CountFemaleManagers() =>
        _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}
