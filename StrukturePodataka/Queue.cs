using System;

namespace StrukturePodataka
{
    class Queue<T>
    {
        T[] items = new T[0];

        // num items in q
        int size = 0;
        // first item in q
        int head = 0;
        // last item in q
        int tail = -1;

        public void Enqueue(T item)
        {
            // ako je array pun ili nema niti jedan item
            if (items.Length == size)
            {
                int newlength = (size == 0) ? 4 : size * 2;
                T[] newArray = new T[newlength];

                if (size > 0)
                {
                    int targetIndex = 0;
                    // ako je glava manja, doslo je do wrappanja
                    // kopiraj sve od glave do kraja pa od 0 do repa
                    if (tail < head)
                    {
                        for (int index = head; index < items.Length; index++)
                        {
                            newArray[targetIndex] = items[index];
                            targetIndex++;
                        }
                        for (int index = 0; index <= tail; index++)
                        {
                            newArray[targetIndex] = items[index];
                            targetIndex++;
                        }
                    }
                    // ako nije, kopiraj od glave do repa
                    else
                    {
                        for (int index = 0; index <= tail; index++)
                        {
                            newArray[targetIndex] = items[index];
                            targetIndex++;
                        }
                    }
                    head = 0;
                    tail = targetIndex - 1;
                }
                else
                {
                    //ako je array empty
                    head = 0;
                    tail = -1;
                }
                items = newArray;
            }
            // ako je tail na kraju array, wrappaj
            if (tail == items.Length)
            {
                tail = 0;
            }
            else
            {
                tail++;
            }
            items[tail] = item;
            size++;
        }

        public T Dequeue()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Empty q");
            }
            // FIFO
            T returnItem = items[head];

            // ako je glava na kraju, wrappaj
            if (head == items.Length - 1)
            {
                head = 0;
            }
            // pomaknu na sljedeci index
            else
            {
                head++;
            }
            size--;

            return returnItem;
        }

        public void Clear()
        {
            size = 0;
            head = 0;
            tail = -1;
        }
    }
}
