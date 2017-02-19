using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData
{
    class BSTree<TKey, TValue> : BinaryTree<TKey, TValue> 
        where TKey : IComparable<TKey> 
        where TValue : IComparable<TValue>
    {
    }
}
