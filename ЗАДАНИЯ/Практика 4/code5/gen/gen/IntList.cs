using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace gen
{
    public  class IntList : ICollection, IEnumerable
    {
        private ArrayList _innerList = new ArrayList();

        public void Add(int number)
        {
            _innerList.Add(number);
        }
        
        public int this[int index]
        {
            get
            {
                return (int)_innerList[index];
            }
        }


        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        #endregion

        #region ICollection Members

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
