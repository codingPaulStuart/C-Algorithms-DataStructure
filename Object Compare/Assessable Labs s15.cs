using System;
using System.Collections.Generic;
using System.Text;
using MahApps.Metro.Controls.Dialogs;
using Session15_Labs;

namespace Session15_Labs
{
    class Program
    {

        static void Main(string[] args)

        {
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

            Student[] tenStudents = {s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };
            foreach (var item in tenStudents)
            {
                Console.WriteLine(item.printStudentValues());
            }

            // Assessable Labs 1 (Session 15) --------------------------------------- //   
            Console.WriteLine(" \n------------ Assessable Labs 1 ------------------------------ \n");
            Console.WriteLine("\nStudent Jesse, using Linear Search is located at index: " +  s1.LinearSearchOfStudent(tenStudents, s4) + "\n");



            // Assessable Labs 2 (Session 15) --------------------------------------- //
            Console.WriteLine(" \n------------ Assessable Labs 2 ------------------------------ \n");
            int foundPos = s7.BinarySearchOfStudent(tenStudents, s4);
            if (foundPos == -1)
            {
               Console.WriteLine(s4.personObj.Name + "not found using Binary Method");              
            }
            else
            {
                Console.WriteLine(s4.personObj.Name + " using Binary Method found at index " + foundPos);
            }



            // Assessable Labs 3 (Session 15) --------------------------------------- //
            Console.WriteLine(" \n------------ Assessable Labs 3 ------------------------------ \n");
            s1.BubbleSortOfStudent(tenStudents);
            Console.WriteLine("\nBubble Sort Students by Name Alphabetically\n");

            foreach (var item in tenStudents)
            {
                Console.WriteLine(item.printStudentValues());
            }
            s1.insertionSortStudent(tenStudents);
            Console.WriteLine("\nInsertion Sort Students by Name Alphabetically\n");

            foreach (var item in tenStudents)
            {
                Console.WriteLine(item.printStudentValues());
            }



            // -------------------------------------------------------- Practice Labs -------------------------------------------------------- //
            // Delcared int and String Arrays for Demonstrations --------------------------------------- //
            string[] tenCities = { "Melbourne", "Sydney", "Canberra", "Hobart", "Perth", "Adelaide", "Darwin", "Brisbane", "Alice Springs", "Gold Coast" };
            int[] tenInts = { 5, 8, 7, 9, 4, 3, 6, 9, 8, 10 };

            // Int Sorting --------------------------------------- //
            Console.WriteLine(" \n------------ Basic Sorting NOT using Array.Sort() for Int and String ------------------------------ \n");
            Console.WriteLine("\nPre=Sorted int Array: \n");
            foreach (var item in tenInts)
            {
                Console.WriteLine(item);
            }
            SortArrayInt(tenInts);
            Console.WriteLine("\nArray sort in asscending order");
            foreach (var item in tenInts)
            {
                Console.WriteLine(item);
            }
            SortArrayIntDescend(tenInts);
            Console.WriteLine("\nArray sort in descending order");
            foreach (var item in tenInts)
            {
                Console.WriteLine(item);
            }

            // String Sorting --------------------------------------- //
            Console.WriteLine("\nPre=Sorted String Array: \n");
            foreach (var item in tenCities)
            {
                Console.WriteLine(item);
            }
            SortArrayString(tenCities);
            Console.WriteLine("\nSorted String Array: \n");
            foreach (var item in tenCities)
            {
                Console.WriteLine(item);
            }
            SortArrayStringDescend(tenCities);
            Console.WriteLine("\nSorted String Array Reverse: \n");
            foreach (var item in tenCities)
            {
                Console.WriteLine(item);
            }

            // Searching --------------------------------------- //
            Console.WriteLine("\n ----------------------- Linear Searching Lab 1 and 2 -----------------------\n");

            Console.WriteLine(" \n------------ Basic Linear Searching of Int and String Arrays ------------------------------ \n");
            Console.WriteLine("Hobart is at index: " + LinearSearchOfCities(tenCities, "Hobart"));

            Console.WriteLine("The number 3 is at index: " + LinearSearchOfInt(tenInts, 3));

            Console.WriteLine(" \n------------ Binary Search Lab 3 ------------------------------ \n");
            int[] scores = { 50, 45, 58, 12, 26, 80, 68, 90, 99, 2 };
            Console.WriteLine(scores + "\nBinary Int Search Method: \n");
            BinarySearchOfInt();

            Console.WriteLine(" \n------------ Bubble Sort Lab 4 ------------------------------ \n");
            BubbleSortInt(scores);
            Console.WriteLine(scores + "\nBubble Sort int Array: \n");
            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" \n------------ Selection Sort Lab 5 ------------------------------ \n");
            int[] scores2 = { 50, 45, 58, 12, 26, 8, 76, 9, 19, 7 };        
            SelectionSortOfInt(scores2);
            Console.WriteLine("\nSelection Sorted int Array: \n");
            foreach (var item in scores2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" \n------------ Bubble Sort String Array Lab 6 ------------------------------ \n");
            string[] fiveStates = { "South Australia", "Victoria", "Tasmania", "Queensland", "Northern Territory"};
            Console.WriteLine("\nPre=Sorted String of States Array: \n");
            foreach (var item in fiveStates)
            {
                Console.WriteLine(item);
            }
            BubbleSortOfStringArray(fiveStates);
            Console.WriteLine("\nBubble Sorted String Array: \n");
            foreach (var item in fiveStates)
            {
                Console.WriteLine(item);
            }

            string[] fivenames = { "James", "Aaron", "Beth", "Zeena", "Patricia"};
            Console.WriteLine("\nSelection Sorting Method: \n");          
            SelectionSortOfString(fivenames);
            Console.WriteLine("\nSelection Sorted: \n");
            foreach (var item in fivenames)
            {
                Console.WriteLine(item);
            }
            SelectionSortOfStringDesc(fivenames);
            Console.WriteLine("\nSelection Sorted Reverse order: \n");
            foreach (var item in fivenames)
            {
                Console.WriteLine(item);
            }

        } // -------------------------------------------------------- End of Main Method -------------------------------------------------------- //

        // Bubble Sort Function (Asscending Order) - Lab 1 ------------------
        public static void SortArrayInt(int[] intArray)
        {
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
        }

        // Bubble Sort Function (Descending Order) - Lab 1 ------------------
        public static void SortArrayIntDescend(int[] intArray)
        {
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
        }

        // Basic Linear int Search from an Array - Lab 1 ------------------
        public static int LinearSearchOfInt(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        // Basic Sort Function (Asscending Order) Strings - Lab 2 ------------------
        public static void SortArrayString(String[] stringArray)
        {
            string temp;

            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                for (int j = i + 1; j < stringArray.Length; j++)
                {
                    if (stringArray[i].CompareTo(stringArray[j]) > 0)
                    {
                        temp = stringArray[i];
                        stringArray[i] = stringArray[j];
                        stringArray[j] = temp;
                    }
                }
            }
        }

        // Basic Sort Function (Descending Order) Strings - Lab 2 ------------------
        public static void SortArrayStringDescend(String[] stringArray)
        {
            string temp;

            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                for (int j = i + 1; j < stringArray.Length; j++)
                {
                    if (stringArray[i].CompareTo(stringArray[j]) < 0)
                    {
                        temp = stringArray[i];
                        stringArray[i] = stringArray[j];
                        stringArray[j] = temp;
                    }
                }
            }
        }

        // Basic Linear String Search from an Array - Lab 2 ------------------
        public static int LinearSearchOfCities(string[] array, string key)
        {
            int pos = Array.IndexOf(array, key);
            if (pos > -1)
            {
                return pos;
            }
            else
            {
                return -1;
            }
        }


        // Binary Search Method - Lab 3 ------------------
        public static void BinarySearchOfInt()
        {
            Console.WriteLine("Number of elements in the array?");
            string elements = Console.ReadLine();
            int numElements = int.Parse(elements);
            int[] array = new int[numElements];
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter Array Elements: ");
            Console.WriteLine("--------------------");
            for (int i = 0; i < numElements; i++)
            {
                string s1 = Console.ReadLine();
                array[i] = int.Parse(s1);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter Search Elements: ");
            Console.WriteLine("--------------------");
            int searchElement = int.Parse(Console.ReadLine());
            int min = 0;
            int N = array.Length;
            int max = N - 1;
            do
            {
                int mid = (min + max) / 2;
                if (searchElement > array[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (array[mid] == searchElement)
                {
                    Console.WriteLine("Search Element found at index: " + mid);
                    break;
                }
                if (min > max)
                    break;         
            }   while (min <= max);
                Console.WriteLine("Search Element NOT found");
            Console.ReadLine();
        }

        // Bubble Sort Method - Lab 4 ------------------
        private static void BubbleSortInt(int[] integersArray)
        {
            int t;
            Console.WriteLine("\nThe unsorted Array is : \n");
            for (int i = 0; i < integersArray.Length; i++)
            {
                Console.WriteLine(integersArray[i]);
            }

            for (int j = 0; j <= integersArray.Length - 2; j++)
            {
                for (int i = 0; i <= integersArray.Length -2; i++)
                {
                    if (integersArray[i] > integersArray[i + 1])
                    {
                        t = integersArray[i + 1];
                        integersArray[i + 1] = integersArray[i];
                        integersArray[i] = t;
                    }
                }
            }
        }

        // Selection Sort Method - Lab 5 ------------------
        private static void SelectionSortOfInt(int[] integersArray)
        {
            Console.WriteLine("\nThe Array Before Selection Sort is: \n");
            for (int i = 0; i < integersArray.Length; i++)
            {
                Console.WriteLine(integersArray[i]);
            }
            int tmp, min_key;
            for (int j = 0; j < integersArray.Length - 1; j++)
            {
                min_key = j;
                for (int k = j + 1; k < integersArray.Length; k++)
                {
                    if (integersArray[k] < integersArray[min_key])
                    {
                        min_key = k;
                    }
                }

                tmp = integersArray[min_key];
                integersArray[min_key] = integersArray[j];
                integersArray[j] = tmp;
            }
        }

        // ------ Bubble Sort and Selection Sort for Strings - Lab 6
        private static void BubbleSortOfStringArray(String [] stringArray)
        {
            string temp;

            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                for (int j = i + 1; j < stringArray.Length; j++)
                {
                    if (stringArray[i].CompareTo(stringArray[j]) > 0)
                    {
                        temp = stringArray[i];
                        stringArray[i] = stringArray[j];
                        stringArray[j] = temp;
                    }
                }
            }
        }

        // Selection Sort String Ascending
        private static void SelectionSortOfString(string[] stringArray)
        {
            string tmp;

            Console.WriteLine("\nThe Array Before Selection Sort is: \n");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            int min_key;
            for (int j = 0; j < stringArray.Length - 1; j++)
            {
                min_key = j;
                for (int k = j + 1; k < stringArray.Length; k++)
                {
                    if (stringArray[k].CompareTo(stringArray[min_key]) < 0)
                    {
                        min_key = k;
                    }
                }

                tmp = stringArray[min_key];
                stringArray[min_key] = stringArray[j];
                stringArray[j] = tmp;
            }
        }

        // Selection Sort String Descending
        private static void SelectionSortOfStringDesc(string[] stringArray)
        {
            string tmp;

            Console.WriteLine("\nThe Array Before Selection Sort is: \n");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            int min_key;
            for (int j = 0; j < stringArray.Length - 1; j++)
            {
                min_key = j;
                for (int k = j + 1; k < stringArray.Length; k++)
                {
                    if (stringArray[k].CompareTo(stringArray[min_key]) > 0)
                    {
                        min_key = k;
                    }
                }

                tmp = stringArray[min_key];
                stringArray[min_key] = stringArray[j];
                stringArray[j] = tmp;
            }
        }


    }
}
