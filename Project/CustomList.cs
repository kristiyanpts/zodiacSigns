using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class CustomList<T>
    {
        private T[] items;
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int capacity;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public CustomList()
        {
            count = 0;
            capacity = 2;
            items = new T[2];
        }
        public CustomList(int size)
        {
            count = 0;
            capacity = size;
            items = new T[capacity];
        }
        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
        public void Add(T item)//Добавя елемент в края на списъка
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] temp = items;
                items = new T[capacity];
                for (int k = 0; k < temp.Length; k = k + 1)
                {
                    items[k] = temp[k];
                }
                items[count] = item;
                count = count + 1;
            }
            else
            {
                items[count] = item;
                count = count + 1;
            }
        }
        public void Insert(int index, T item)//добавяне на елемент на определено място(индекс)
        {
            count = count + 1;
            Array.Copy(items, index, items, index + 1, count - index);
            items[index] = item;
        }
        public void Set(int index, T item)// Задаване(промяна) на стойност на елемент на даден индекс
        {
            items[index] = item;
        }
        public T GetElementAtIndex(int index)//Извличане на елемент по даден индекс 
        {
            return items[index];
        }
        public void RemoveAt(int index)//Премахва елемента на дадена позиция
        {
            T item = items[index];
            Array.Copy(items, index + 1, items, index, count - index - 1);
            count = count - 1;
        }
        public void Remove(T item)//Премахва съответния елемент
        {
            int index = IndexOf(item);
            RemoveAt(index);
        }
        public int IndexOf(T item)//Извлича индекса на даден елемент
        {
            for (int k = 0; k < items.Length; k = k + 1)
            {
                if (Equals(item, items[k])) { return k; }
            }
            return -1;
        }
    }
}
