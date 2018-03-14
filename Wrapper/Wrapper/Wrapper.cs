using System;
using System.Collections.Generic;
using System.IO;

namespace Wrapper
{
    class Wrapper
    {
        private LinkedList<Person> List;

        Wrapper() // Default constructor
        {
            List.Clear();
        }

        void Insert(Person p) // Inserting element into end of list
        {
            List.AddLast(p);
        }

        void Remove()
        {
            List.Remove(List.First);
        }

        void Change(Person what, Person whom)
        {
            List.Find(what).Value = whom;
        }

        Person GetValue()
        {
            return List.First.Value;
        }

        LinkedListNode<Person> GetFirst()
        {
            return List.First;
        }

        LinkedListNode<Person> GetLast()
        {
            return List.Last;
        }

        LinkedListNode<Person> GetNext(LinkedListNode<Person> now)
        {
            return now.Next;
        }

        LinkedListNode<Person> GetPrev(LinkedListNode<Person> now)
        {
            return now.Previous;
        }

        void LoadFromFile(String fileName)
        {

        }
    }
}
