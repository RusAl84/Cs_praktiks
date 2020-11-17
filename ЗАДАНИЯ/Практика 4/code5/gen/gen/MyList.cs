using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace gen
{
    public  class MyList<T> //: ICollection, IEnumerable
    {
        private ArrayList _innerList = new ArrayList();
        public  void Add(T val)
        {
            _innerList.Add(val);
        }
        public T this[int index]
        {
            get
            {
                return (T)_innerList[index];
            }
        }



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

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
