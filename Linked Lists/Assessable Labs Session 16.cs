using labs16_Exercises;
using System;
using System.Collections.Generic;
using static labs16_Exercises.createList;

namespace Session16_AssessableLab
{
    class Program
    {
        static void Main(string[] args)
        {

            SortList<int> sList = new SortList<int>();

            //Adds data to the list  
            sList.addNode(9);
            sList.addNode(7);
            sList.addNode(2);
            sList.addNode(5);
            sList.addNode(4);

            //Displaying original list  
            Console.WriteLine("Original list: ");
            sList.display();

            //Sorting list  
            sList.sortList();

            //Displaying sorted list  
            Console.WriteLine("Sorted list: ");
            sList.display();

            Person p1 = new Person("James");
            Person p2 = new Person("Steve");
            Person p3 = new Person("Mary");
            Person p4 = new Person("Rita");
            Person p5 = new Person("Jesse");
            Person p6 = new Person("Paul");
            Person p7 = new Person("Amber");
            Person p8 = new Person("Craig");
            Person p9 = new Person("Holly");
            Person p10 = new Person("Stacey");
            Student s1 = new Student("Physics", DateTime.Today, p1);
            Student s2 = new Student("English", DateTime.Today, p2);
            Student s3 = new Student("Sports", DateTime.Today, p3);
            Student s4 = new Student("Physics", DateTime.Today, p4);
            Student s5 = new Student("Chemistry", DateTime.Today, p5);
            Student s6 = new Student("Maths", DateTime.Today, p6);
            Student s7 = new Student("Geography", DateTime.Today, p7);
            Student s8 = new Student("Art", DateTime.Today, p8);
            Student s9 = new Student("Sports", DateTime.Today, p9);
            Student s10 = new Student("maths", DateTime.Today, p10);

            // Labs Assessment 16 - Lab 1.a
            DoublyLinkedList<Student> listDoubleStu = new DoublyLinkedList<Student>();
            listDoubleStu.Add(s1);
            listDoubleStu.Add(s2);
            listDoubleStu.Add(s3);
            listDoubleStu.Add(s4);
            listDoubleStu.Add(s5);
            listDoubleStu.Add(s6);
            listDoubleStu.Add(s7);
            listDoubleStu.Add(s8);
            listDoubleStu.Add(s9);
            listDoubleStu.Add(s10);

            // Labs Assessment 16 - Lab 1.b
            Console.WriteLine("\n-------------------------- Assessable Lab 1.b --------------------------\n");
            PrintDoubleList(listDoubleStu);

            // Labs Assessment 16 - Lab 1.c
            Console.WriteLine("\n-------------------------- Assessable Lab 1.c --------------------------\n");
            Person p11 = new Person("Added to End");
            Student addedToEndStudent = new Student("History", DateTime.Now, p11);
            listDoubleStu.Addlast(addedToEndStudent);
            PrintDoubleList(listDoubleStu);

            // Labs Assessment 16 - Lab 1.d
            Console.WriteLine("\n-------------------------- Assessable Lab 1.d --------------------------\n");
            Console.WriteLine("Remove Student s4 (Rita) with Remove Method: " + listDoubleStu.Remove(s4));
            PrintDoubleList(listDoubleStu);

            // Labs Assessment 16 - Lab 1.e
            Console.WriteLine("\n-------------------------- Assessable Lab 1.e --------------------------\n");
            Console.WriteLine("Remove First Student From List (Stacey): \n");
            listDoubleStu.RemoveFirst();
            PrintDoubleList(listDoubleStu);

            // Labs Assessment 16 - Lab 1.f
            Console.WriteLine("\n-------------------------- Assessable Lab 1.f --------------------------\n");
            Console.WriteLine("Remove Last Student From List (History): \n");
            listDoubleStu.RemoveLast();
            PrintDoubleList(listDoubleStu);
        }

        // Enumerate through nodes and display values
        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        // Enumerate through Double Linked List
        private static void PrintDoubleList(DoublyLinkedList<Student> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.personObj.Name + " " + item.Program);
                
            }
        }

    }
}
