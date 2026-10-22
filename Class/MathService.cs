using System;
using System.Collections.Generic;
using System.Text;

namespace API1.Class

{
    public class MathService
    {
        public double Div(double[] numbers)
        {
            if (numbers.Length < 2) return 0;
            if (numbers[1] == 0) return 0;
            return numbers[0]/numbers[1]; 
        }
        public double Mult(double[] numbers)
        {
            if (numbers.Length < 2) return 0;
            return numbers[0] * numbers[1];
        }
        public double Add(double[] numbers)
        {
            if (numbers.Length < 2) return 0;
            return numbers[0] + numbers[1];
        }
        public double Sub(double[] numbers)
        {
            if (numbers.Length < 2) return 0;
            return numbers[0] - numbers[1];
        }
        public double Sum(double[] numbers)
        {
            var result = 0.0;
            foreach (var number in numbers)
            { result += number; }
            return result;
        }
        public double Max(double[] numbers)
        {
            if (numbers.Length == 0) return 0.0;
            var result = numbers[0]; 
            foreach (var number in numbers)
            { if (number > result) result = number; }
            return result;
        }
        public  double Min(double[] numbers)
        {
            if (numbers.Length == 0) return 0.0;
            var result = numbers[0];
            foreach (var number in numbers)
            { if (number < result) result = number; }
            return result;
        }
        public  double Count(double[] numbers)
        { 
            return numbers.Length; 
        }
        public  double Factorial(double[] numbers)
        {
            if (numbers.Length == 0) return 0;
            int n = (int)numbers[0];
            if (n<0) return 0;
            double result = 1.0;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public  double Precent(double[] numbers)
        {
            if (numbers.Length < 2) return 0;
            return numbers[0] * (numbers[1] / 100.0);
        }
        public  double Depercent(double[] numbers)
        {
            if (numbers.Length < 2) return 0;
            if (numbers[1] == 100) return 0;
            return numbers[0] / (1.0 - numbers[1] / 100.0);
        }
    }
}