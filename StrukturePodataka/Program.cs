using System;
using System.Collections;

namespace StrukturePodataka
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        private static void QueueExample()
        {
            var q = new Queue<int>();

            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            Console.ReadLine();
        }

        private static void DoublyExample()
        {
            var doublyLinkedList = new DoublyLinkedList<int>();

            for (int i = 0; i < 4; i++)
            {
                doublyLinkedList.AddFirst(new DoublyLinkedListNode<int>(i));
            }


            /*
            Console.WriteLine("Prolaz kroz listu od head to tail:");
            while (doublyLinkedList.Head != null)
            {
                Console.WriteLine(doublyLinkedList.Head.Value);
                doublyLinkedList.Head = doublyLinkedList.Head.Next;
            }
            */
            Console.WriteLine("Prolaz kroz listu od tail do head:");
            while (doublyLinkedList.Tail != null)
            {
                Console.WriteLine(doublyLinkedList.Tail.Value);
                doublyLinkedList.Tail = doublyLinkedList.Tail.Previous;
            }
            Console.ReadLine();
        }

        private static void SinglyLinkedListExample()
        {
            var list = new SinglyLinkedList<int>();
            for (int i = 0; i < 1; i++)
            {
                var val = new SinglyLinkedListNode<int>(i);
                list.AddLast(val);

            }
            while (list.Head != null)
            {
                Console.WriteLine(list.Head.Value);
                list.Head = list.Head.Next;
                Console.ReadLine();
            }
        }

        private static void StackExample()
        {
            var stack = new Stack<int>();

            for (int i = 0; i < 0; i++)
            {
                stack.Push(i);
            }

            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();
        }

        private static void BinaryTreeExample()
        {
            var tree = new BinaryTree();
            tree.Add(4);
            tree.Add(2);
            tree.Add(6);
            tree.Add(1);
            tree.Add(3);
            tree.Add(5);
            tree.Add(7);

            tree.Preorder();
            tree.InOrder();
            tree.PostOrder();


            Console.ReadLine();
        }
        private static void HashtableExample()
        {
            var hashtable = new Hashtable();
            hashtable.Add("One", 1);
            hashtable.Add("Two", 2);
            hashtable["Three"] = 3;
            hashtable.Add(3, 4);
            hashtable[7] = "mislav";

            int a = (int)hashtable["One"];
            int b = (int)hashtable[3];

            Console.WriteLine("a " + a + "b " + b + "ime " + hashtable[7]);

            foreach (DictionaryEntry item in hashtable)
                Console.WriteLine("Key: {0}, value: {1}", item.Key, item.Value);

            foreach (var value in hashtable.Values)
                Console.WriteLine("Value: {0}", value);

            hashtable.Remove(7);
            Console.WriteLine(hashtable.Contains(7));
            Console.WriteLine(hashtable.ContainsKey(7));
            Console.WriteLine(hashtable.ContainsKey("Two"));

            foreach (var key in hashtable.Keys)
                Console.WriteLine("Key: {0}", key);

            hashtable.Clear();

            Console.ReadLine();
        }
    }
}

