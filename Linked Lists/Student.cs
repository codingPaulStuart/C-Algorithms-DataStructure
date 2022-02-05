using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labs16_Exercises
{
    public class Student : IComparable<Student>
    {

        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }

        public Person personObj = new Person();

        public Student(string program, DateTime dateRegistered, Person obj)
        {
            Program = program;
            DateRegistered = dateRegistered;
            personObj = obj;

        }

        // Assessable Labs Session 15 (Q1 - search Linear Method using == override) ---------------------------------------
        public int LinearSearchOfStudent(Student[] array, Student key)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].personObj.Name == key.personObj.Name)
                {
                    return i;
                }
            }
            return -1;
        }

        // Assessable Labs Session 15 (Q2 - Binary Search Method) ---------------------------------------
        public int BinarySearchOfStudent(Student[] data, Student item)
        {
            
            int min = 0;
            int max = data.Length - 1;
            int mid;
            do
            {
                Array.Sort(data);
                mid = (min + max) / 2;
                if (data[mid] == item)
                    return mid;
                if (item.CompareTo(data[mid]) > 0)
                    min = mid + 1;
                else
                    max = mid - 1;
            } while (min <= max);
            return -1;
        }

        // Assessable Labs Session 15 (Q3 Bubble Sort using Students Name) ---------------------------------------
        public void BubbleSortOfStudent(Student[] studentArray)
        {
            Student temp;

            for (int i = 0; i <= studentArray.Length - 1; i++)
            {
                for (int j = i + 1; j < studentArray.Length; j++)
                {
                    if (studentArray[i].CompareTo(studentArray[j]) > 0)
                    {
                        temp = studentArray[i];
                        studentArray[i] = studentArray[j];
                        studentArray[j] = temp;
                    }
                }
            }
        }

        // Equals Override ---------------------------------------
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student rhs = obj as Student;
            return this.Program == rhs.Program && this.DateRegistered == rhs.DateRegistered;
        }
        // Get Hashcode Override ---------------------------------------
        public override int GetHashCode()
        {
            int hash = 7;
            hash = 23 * hash + this.Program.GetHashCode();
            hash = 23 * hash + this.DateRegistered.GetHashCode();
            
            return hash;
        }
        // Override the == Operator ---------------------------------------
        public static bool operator ==(Student x, Student y)
        {
            return object.Equals(x, y);
        }
        // Override the != Operator ---------------------------------------
        public static bool operator !=(Student x, Student y)
        {
            return !object.Equals(x, y);
        }
        // Compare To Implement ---------------------------------------
        public int CompareTo(Student other)
        {
            if (other.Program == null)
                return 1;
            if (ReferenceEquals(other.Program, this))
                return 0;
            if (other.GetType() != this.GetType())
                throw new ArgumentException();
            return this.personObj.Name.CompareTo(other.personObj.Name);
        }

        // Compare multi-field Override ---------------------------------------
        public int Compare(Student o1, Student o2)
        {
            // For Comparison
            int dateCompare = o1.DateRegistered.CompareTo(o2.DateRegistered);
            int progCompare = o1.Program.CompareTo(o2.Program);
            int hashCompare = o1.GetHashCode().CompareTo(o2.GetHashCode());

            // Check variables and use hashcode
            if (dateCompare == 0)
            {
                return ((hashCompare == 0) ? dateCompare : hashCompare);
            }
            if (progCompare == 0)
            {
                return ((hashCompare == 0) ? dateCompare : hashCompare);
            }
            else
            {
                return hashCompare;
            }

        }

        // Operator < > <= >= bool To Implement ---------------------------------------
        public static bool operator <(Student x, Student y)
        {
            return x.GetHashCode() < y.GetHashCode();
        }
        public static bool operator >(Student x, Student y)
        {
            return x.GetHashCode() > y.GetHashCode();
        }
        public static bool operator <=(Student x, Student y)
        {
            return x.GetHashCode() <= y.GetHashCode();
        }
        public static bool operator >=(Student x, Student y)
        {
            return x.GetHashCode() >= y.GetHashCode();
        }

        // Print Values
        public string printStudentValues()
        {
            return Program.ToString() + " " + DateRegistered.ToString() + " " + personObj.Name.ToString();
        }

        
    }
}
