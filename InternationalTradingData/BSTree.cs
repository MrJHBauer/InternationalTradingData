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

        public override void Create(TKey Key, TValue Value)
        {
            create(Key, Value, ref Root);
        }

        private void create(TKey key, TValue value, ref Node<TKey, TValue> node)
        {
            if(node != null)
            {
                if (key.CompareTo(node.Key) < 0)
                {
                    create(key, value, ref node.Left);
                }
                else if (key.CompareTo(node.Key) > 0)
                {
                    create(key, value, ref node.Right);
                }
            }
            else
            {
                node = new Node<TKey, TValue>(key, value);
            }            
        }

        public override TValue Get(TKey Key)
        {
            return base.Get(Key);
        }
        
        public override void Edit(TKey Key, TValue Value)
        {
            base.Edit(Key, Value);
        }

        public override void Delete(TKey Key)
        {
            delete(Key, ref Root);
        }

        private void delete(TKey key, ref Node<TKey, TValue> node)
        {
            if(node != null)
            {
                if(key.CompareTo(node.Key) == 0)
                {
                    if(node.Left != null)
                    {
                        if(node.Right != null)
                        {
                            Node<TKey, TValue> minNode = leastItem(node.Right);
                            node.Key = minNode.Key;
                            node.Value = minNode.Value;
                            delete(node.Key, ref node.Right);
                        }
                        else
                        {
                            node = node.Right;
                        }
                    }
                    else if(node.Right != null)
                    {
                        node = node.Right;
                    }
                    else
                    {
                        node = null;
                    }
                }
                else if(node.Left != null && key.CompareTo(node.Key) < 0)
                {
                    delete(key, ref node.Left);
                }
                else if(node.Right != null && key.CompareTo(node.Key) > 0)
                {
                    delete(key, ref node.Right);
                }
            }
        }

        private Node<TKey, TValue> leastItem(Node<TKey, TValue> node)
        {
            if (node.Left == null)
            {
                return node;
            }
            else
            {
                return leastItem(node.Left);
            }
        }
    }
}
