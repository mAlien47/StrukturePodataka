namespace StrukturePodataka
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
        public SinglyLinkedListNode<T> Tail { get; set; }

        // add first, add last

        public void AddFirst(SinglyLinkedListNode<T> node)
        {
            // ako postoji head, novi node pointa na njega
            var temp = Head;
            Head = node;
            Head.Next = temp;
            if (Head.Next == null)
                Tail = Head;
        }


        public void AddLast(SinglyLinkedListNode<T> node)
        {
            if (Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }

        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                Head = Head.Next;
            }
        }
        public void RemoveLast()
        {
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                Tail = current;
            }
        }

    }


    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public SinglyLinkedListNode<T> Next { get; set; }
    }


}
