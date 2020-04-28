using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace April27
{
    class ClassTen : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
