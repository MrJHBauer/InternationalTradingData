using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData
{
    public class BSTree<TKey, TValue> : BinaryTree<TKey, TValue> 
        where TKey : IComparable<TKey> 
        where TValue : IComparable<TValue>
    {
        public BSTree() : base() { }

        public BSTree(TKey Key, TValue Value ) : base(Key, Value) { }
    }
}
