using System.Linq;

namespace SOLID._03LiskovsSubstitution
{
    public class EvenNumbersSumCalculator : SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        public new int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
