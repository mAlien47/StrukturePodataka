using System;

namespace StrukturePodataka
{
    class Stack<T>
    {
        // array implementation

        T[] items = new T[0];

        // trenutno u arrayu items
        int size;

        public void Push(T item)
        {
            if (size == items.Length)
            {
                // pocetno 4, inace double
                int newLength = size == 0 ? 4 : size * 2;

                T[] newArray = new T[newLength];
                items.CopyTo(newArray, 0);
                items = newArray;
            }

            items[size] = item;
            size++;
        }

        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Empty stack");
            }
            size--;
            return items[size];
        }

        public T Peek()
        {
            if (size == 0)
                throw new InvalidOperationException("Empty stack");
            return items[size - 1];
        }

        public void Clear()
        {
            size = 0;
        }

    }
}
