﻿namespace SOLID._03LiskovsSubstitution.WithLS
{
    public abstract class Calculator
    {
        protected readonly int[] _numbers;

        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Calculate();
    }
}
