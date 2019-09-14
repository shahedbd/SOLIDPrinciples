using System.Linq;

namespace SOLID._03LiskovsSubstitution.WithLS
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Sum();
    }
}
