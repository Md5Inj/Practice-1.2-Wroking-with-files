using System;
using System.Collections.Generic;
using System.IO;

namespace Wrapper
{
    class Wrapper
    {
        private LinkedList<Person> List;

        public Wrapper() // Default constructor
        {
            List = new LinkedList<Person>();
        }

        public void Insert(Person p) // Inserting element into end of list
        {
            List.AddLast(p);
        }

        public void Remove()
        {
            List.Remove(List.First);
        }

        public void Change(Person what, Person whom)
        {
            List.Find(what).Value = whom;
        }

        public Person GetValue()
        {
            return List.First.Value;
        }

        public LinkedListNode<Person> GetFirst()
        {
            return List.First;
        }

        public LinkedListNode<Person> GetLast()
        {
            return List.Last;
        }

        public void Print()
        {
            int count = 0;
            foreach (var item in List)
            {
                Console.WriteLine($"{count}:");
                Console.WriteLine($"name: { item.Name }");
                Console.WriteLine($"age: { item.Age }");
                Console.WriteLine($"gender: { item.Gender }");
                count++;
            }
        }

        public LinkedListNode<Person> GetNext(LinkedListNode<Person> now)
        {
            return now.Next;
        }

        public LinkedListNode<Person> GetPrev(LinkedListNode<Person> now)
        {
            return now.Previous;
        }

        public void LoadFromFile(String fileName)
        {
            this.List.Clear();
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            String line = "", age = "", gender = "";

            while (true)
            {
                line = reader.ReadLine();
                if (line == null) break;
                age = reader.ReadLine();
                gender = reader.ReadLine();
                this.Insert(new Person(line, Convert.ToUInt32(age), gender[0]));
            }

            reader.Close();
        }

        public void SaveToFile(String filename)
        {
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            foreach (var item in List)
            {
                writer.WriteLine(item.Name);
                writer.WriteLine(item.Age);
                writer.WriteLine(item.Gender);
            }
            writer.Close();
        }

        public Person getFromIndex(int index)
        {
            int count = 0;
            foreach (var item in List)
            {
                if (count == index) return item;
                count++;
            }
            return null;
        }
    }
}
