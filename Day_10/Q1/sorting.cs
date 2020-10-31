using System;
using System.Collections;

namespace ConsoleApplication12
{
    class sorting:IComparer
    {
        public int Compare(object x, object y)
        {
            Account a1 = (Account)x;
            Account a2 = (Account)y;
            if (a1 != null && a2 != null)
                return String.Compare(a1.Name, a2.Name);
            else
                throw new Exception("argument is null");
        }
    }
}
