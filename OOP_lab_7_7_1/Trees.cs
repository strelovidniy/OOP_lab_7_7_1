using System;
using System.Collections;

namespace OOP_lab_7_7_1
{
    class Trees : IEnumerable
    {
        private static Tree[] _trees;

        public Tree[] trees
        {
            get => _trees;
        }

        public Trees(string[] elements)
        {
            _trees = new Tree[elements.Length / 3];

            for (int i = 0; i < elements.Length; i += 3)
            {
                _trees[i / 3] = new Tree(elements[i], int.Parse(elements[i + 1]), int.Parse(elements[i + 2]));
            }
        }

        class SortByHeight : IComparer
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

        class SortByPrice : IComparer
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _trees.Length; ++i)
            {
                yield return _trees[i];
            }
        }
    }
}
