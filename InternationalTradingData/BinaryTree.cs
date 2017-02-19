using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData
{
    public class BinaryTree<TKey, TValue> 
        where TKey : IComparable<TKey> 
        where TValue : IComparable<TValue>
    {
        public Node<TKey, TValue> Root;

        public BinaryTree() { Root = null; }

        public BinaryTree(TKey Key, TValue Value) { Root = new Node<TKey, TValue>(Key, Value); }

        public virtual void Create(TKey Key, TValue Value) { }

        public virtual TValue Get(TKey Key)
        {
            foreach(Node<TKey, TValue> node in inOrder(Root))
            {
                if (node.Key.CompareTo(Key) == 0) return node.Value;
            }
            return default(TValue);
        }

        public virtual void Edit(TKey Key, TValue Value) { }

        public virtual void Delete(TKey Key) { }

        public virtual bool Contains(TKey Key)
        {
            foreach (Node<TKey, TValue> node in inOrder(Root))
            {
                if (node.Key.CompareTo(Key) == 0) return true;
            }
            return false;
        }

        public List<TKey> InOrder()
        {
            List<TKey> keys = new List<TKey>();
            foreach(Node<TKey, TValue> node in inOrder(Root))
            {
                keys.Add(node.Key);
            }
            return keys;
        }

        private IEnumerable<Node<TKey, TValue>> inOrder(Node<TKey, TValue> node)
        {
            if(node != null)
            {
                foreach (Node<TKey, TValue> leftNode in inOrder(node.Left))
                {
                    yield return leftNode;
                }
                yield return node;
                foreach (Node<TKey, TValue> rightNode in inOrder(node.Right))
                {
                    yield return rightNode;
                }
            }
            else
            {
                yield break;
            }
        }

        public List<TKey> PreOrder()
        {
            List<TKey> keys = new List<TKey>();
            foreach (Node<TKey, TValue> node in preOrder(Root))
            {
                keys.Add(node.Key);
            }
            return keys;
        }

        private IEnumerable<Node<TKey, TValue>> preOrder(Node<TKey, TValue> node)
        {
            if (node != null)
            {
                yield return node;
                foreach (Node<TKey, TValue> leftNode in preOrder(node.Left))
                {
                    yield return leftNode;
                }
                foreach (Node<TKey, TValue> rightNode in preOrder(node.Right))
                {
                    yield return rightNode;
                }
            }
            else
            {
                yield break;
            }
        }

        public List<TKey> PostOrder()
        {
            List<TKey> keys = new List<TKey>();
            foreach (Node<TKey, TValue> node in postOrder(Root))
            {
                keys.Add(node.Key);
            }
            return keys;
        }

        private IEnumerable<Node<TKey, TValue>> postOrder(Node<TKey, TValue> node)
        {
            if (node != null)
            {
                foreach (Node<TKey, TValue> leftNode in postOrder(node.Left))
                {
                    yield return leftNode;
                }
                foreach (Node<TKey, TValue> rightNode in postOrder(node.Right))
                {
                    yield return rightNode;
                }
                yield return node;
            }
            else
            {
                yield break;
            }
        }

        public int GetNodeCount()
        {
            return getNodeCount(Root);
        }

        private int getNodeCount(Node<TKey, TValue> node)
        {
            return node != null ? 1 + getNodeCount(node.Left)
                + getNodeCount(node.Right) : 0;
        }

        public int GetHeight()
        {
            return getHeight(Root) - 1;
        }

        private int getHeight(Node<TKey, TValue> node)
        {
            return node == null ? 0 : 1 + Math.Max(getHeight(node.Left),
                getHeight(node.Right));
        }
    }
}
