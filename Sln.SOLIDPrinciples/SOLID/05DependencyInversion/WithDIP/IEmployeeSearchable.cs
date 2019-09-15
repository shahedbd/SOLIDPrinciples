using SOLID.Entity;
using SOLID.ZCommon;
using System.Collections.Generic;

namespace SOLID._05DependencyInversion.WithDIP
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}
