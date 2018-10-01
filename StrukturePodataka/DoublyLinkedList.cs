namespace StrukturePodataka
{
    class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        //ako su head i tail null
        //ako je samo 1 element
        //ako ih je vise
        public void AddFirst(DoublyLinkedListNode<T> node)
        {
            var currentHead = Head;
            Head = node;
            Head.Next = currentHead;
            // ako je postojao current head, postavi ref na previous
            if (currentHead != null)
            {
                currentHead.Previous = Head;
            }
            //ako nije postojao head, head i tail su jedini element
            else
            {
                Head = node;
                Tail = node;
            }
        }

        public void AddLast(DoublyLinkedListNode<T> node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }
            Tail = node;
        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                Head = Head.Next;
                // ako je head.next null, nema elemenata
                if (Head == null)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Tail != null)
            {
                if (Head == Tail)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }
            }
        }
    }

    class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public DoublyLinkedListNode<T> Previous { get; set; }

        public DoublyLinkedListNode<T> Next { get; set; }
    }
}
