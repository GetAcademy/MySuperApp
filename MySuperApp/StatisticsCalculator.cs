using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySuperApp
{
    public class StatisticsCalculator
    {
        private readonly List<int> _numbers = new List<int>();

        public void Add(int number)
        {
            _numbers.Add(number);
        }

        public int Sum()
        {
            return _numbers.Sum();
        }

        public int Divide()
        {
            if (_numbers.Count < 2) return _numbers[0];
            var result = _numbers[0];
            for (var i = 1; i < _numbers.Count; i++)
            {
                result /= _numbers[i];
            }

            return result;
        }
    }
}
