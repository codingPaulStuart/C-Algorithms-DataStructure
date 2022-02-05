using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace labs16_Exercises
{
    public class LinkedList<T> : 
        System.Collections.Generic.ICollection<T>
    {

        public int Count
        {
            get;
            private set;
        }

        public LinkedListNode<T> Head
        {
            get;
            private set;
        }

        public LinkedListNode<T> Tail
        {
            get;
            private set;
        }

        public object Value { get; internal set; }
        public LinkedList<T> Next { get; internal set; }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }
        
        public void AddFirst(LinkedListNode<T> node)
        {
            // Save off the head node so as not to lose
            LinkedListNode<T> temp = Head;

            // Point head to new node
            Head = node;

            // Insert rest of the list behind head
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                // If the list was empty then Head and Tail should both point to new Node
                Tail = Head;
            }
        }

        // Adds a value of Type T that adds new instance of Node to end of the list
        public void Addlast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }

        // Overload method that adds Node instance to end of the list
        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;
            Count++;
        }

        // Remove method that takes off first Node instance of the list
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                // Before: Head -> 3 -> 5
                // After: Head -------> 5
                // Head -> 3 -> null
                // Head ------> null
                Head = Head.Next;
                Count--;

                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count !=0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    // Before: Head --> 3 --> 5 --> 7
                    //         Tail = 7
                    // After:  Head --> 3 --> 5 --> null
                    //         Tail = 5
                    LinkedListNode<T> current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
                }

                Count--;
            }
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;

            // 1: Empty List = do nothing
            // 2: Single node: (previous is null)
            // 3: Many Nodes = a: node to remove is the first, b: node to remove is the middle/last

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    // Node in middle or end
                    if (previous != null)
                    {
                        // Case 3b
                        previous.Next = current.Next;
                        // It was end so update Tail
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }

                        Count--;
                    }
                    else
                    {
                        // Case 2 or 3a
                        RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Clear()
        {
            throw new NotImplementedException();
        }

        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public static implicit operator LinkedList<T>(LinkedListNode<T> v)
        {
            throw new NotImplementedException();
        }
    }
}
