using System;
using System.Collections;

namespace OOP_lab_7_7_1
{
    class Tree : IComparable
    {
        private string _type;
        private int _price;
        private int _height;
        private int _count;
        private bool _fruitfulness;

        public string Type
        {
            get => _type;
            set => _type = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public int Height
        {
            get => _height;
            set => _height = value;
        }

        public int Count
        {
            get => _count;
            set => _count = value;
        }

        public bool Fruitfulness
        {
            get => _fruitfulness;
            set => _fruitfulness = value;
        }

        public Tree(string type, int price, int height, bool fruitfulness, int count)
        {
            _type = type;
            _price = price;
            _height = height;
            _fruitfulness = fruitfulness;
            _count = count;
        }

        public int CompareTo(object tree)
        {
            Tree t = (Tree)tree;

            if (this.Price > t.Price)
            {
                return 1;
            }
            if (this.Price < t.Price)
            {
                return -1;
            }

            return 0;
        }

        public class SortByPrice : IComparer
        {
            int IComparer.Compare(object tree1, object tree2)
            {
                Tree t1 = (Tree)tree1;
                Tree t2 = (Tree)tree2;

                if (t1.Price > t2.Price)
                {
                    return 1;
                }
                if (t1.Price < t2.Price)
                {
                    return -1;
                }

                return 0;
            }
        }

        public class SortByHeight : IComparer
        {
            int IComparer.Compare(object tree1, object tree2)
            {
                Tree t1 = (Tree)tree1;
                Tree t2 = (Tree)tree2;

                if (t1.Height > t2.Height)
                {
                    return 1;
                }
                if (t1.Height < t2.Height)
                {
                    return -1;
                }

                return 0;
            }
        }
    }
}
