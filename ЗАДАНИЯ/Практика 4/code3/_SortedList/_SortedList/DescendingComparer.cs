using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _SortedList
{
    public class DescendingComparer : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            // Для сортировки по убыванию,
            // объекты, переданные для сравнения, меняются местами 
            return comparer.Compare(y, x);

        }
    }
}
