using System;
using System.Globalization;
namespace Algorithm
{
    internal class BinarySearch<T> where T : IComparable<T>
    {
        public T nodeData;
        public BinarySearch<T> left;
        public BinarySearch<T> right;
        int leftCount, rightCount;
        bool result = false;

        public BinarySearch(T data)
        {
            nodeData = data;
            left = null;
            right = null;
        }

        public void Insert(T item)
        {
            T node = nodeData;
            if (node.CompareTo(item) > 0)
            {
                leftCount++;
                if (left == null)
                {
                    left = new BinarySearch<T>(item);
                }
                else
                {
                    left.Insert(item);
                }
            }
            else
            {
                rightCount++;
                if (right == null)
                {
                    right = new BinarySearch<T>(item);
                }
                else
                {
                    right.Insert(item);
                }
            }
        }
        public void Display()
        {
            if (left != null)
            {

                left.Display();
            }
            Console.WriteLine(nodeData.ToString());
            if (right != null)
            {
                right.Display();
            }
        }
        public void Size()
        {
            int size = leftCount + rightCount + 1;
            Console.WriteLine("Size of tree is: " + size);
        }
        public bool Search(T data, BinarySearch<T> node)
        {
            if (node == null)
            {
                return false;
            }
            else if (node.nodeData.Equals(data))
            {
                return true;
            }
            else if (data.CompareTo(node.nodeData) > 0)
            {
                result = Search(data, node.right);
            }
            else if (data.CompareTo(node.nodeData) < 0)
            {
                result = Search(data, node.left);
            }
            return result;
        }
    }
}