using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.BinaryTrees
{

    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {

        //Методы интерфейса IEnumerable для получения элемента перечисления коллекции
        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Конструктор класса
        public BinaryTree() 
        {
            _items = new List<T>();
            this.value = default(T);
            right = null;
            left = null;
        }

        //Метод Add, работающий по принципу бинарного дерева.
        public void Add(T value)
        {
            bool temp = Equals(this.value, default(T));
            int temp1 = this.value.CompareTo(value);
            if (Equals(this.value,default(T)))  this.value = value;
             else
            {
                if (this.value.CompareTo(value) >= 0)
                {
                    if (left == null)
                    {
                        left = new BinaryTree<T>();
                        left.Value = value;
                    }
                    else left.Add(value);
                } else
                {
                    if (right == null)
                    {
                        right = new BinaryTree<T>();
                        right.Value = value;
                    }
                    else right.Add(value);
                }
            }
        }

        //Геттеры и сеттеры
        private List<T> _items;
        private BinaryTree<T> right;
        public BinaryTree<T> Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }

        private BinaryTree<T> left;
        public BinaryTree<T> Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }

        private T value;
        public T Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

    }

    //Вторая часть задания
    public class BinaryTree
    {
        public static int[] Create(params int[] values)
        {
            int[] temp = new int[values.Length];
            Array.Sort(values);
            temp = values;
            return temp;
        }
    }
}
