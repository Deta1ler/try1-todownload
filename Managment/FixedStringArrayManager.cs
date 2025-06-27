using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try1
{
    public class FixedStringArray
    {
        private string[] _array;
        private int _currentIndex;

        public int Length => _array.Length;
        public int Count => _currentIndex;

        public FixedStringArray(int length)
        {
            if (length <= 0)
                throw new ArgumentException("Довжина масиву повинна бути більшою за 0.");
            _array = new string[length];
            _currentIndex = 0;
        }

        public bool Add(string value)
        {
            if (_currentIndex >= _array.Length)
                return false;
            _array[_currentIndex++] = value;
            return true;
        }

        public string GetByIndex(int index)
        {
            if (index < 0 || index >= _array.Length)
                throw new IndexOutOfRangeException("Індекс поза межами масиву.");
            return _array[index];
        }

        public string[] GetAll()
        {
            string[] result = new string[_currentIndex];
            Array.Copy(_array, result, _currentIndex);
            return result;
        }

        public void Clear()
        {
            _array = new string[_array.Length];
            _currentIndex = 0;
        }

        public static FixedStringArray ElementWiseConcat(FixedStringArray a, FixedStringArray b)
        {
            int minLen = Math.Min(a._currentIndex, b._currentIndex);
            FixedStringArray result = new FixedStringArray(minLen);
            for (int i = 0; i < minLen; i++)
            {
                result.Add(a._array[i] + b._array[i]);
            }
            return result;
        }

        public static FixedStringArray MergeUnique(FixedStringArray a, FixedStringArray b)
        {
            HashSet<string> unique = new HashSet<string>();
            foreach (var item in a.GetAll()) unique.Add(item);
            foreach (var item in b.GetAll()) unique.Add(item);
            FixedStringArray result = new FixedStringArray(unique.Count);
            foreach (var item in unique)
            {
                result.Add(item);
            }
            return result;
        }
    }
}
