using System;
using System.Collections.Generic;
using System.Text;

namespace Session14_AssessableLab
{
    public class Student : IComparable<Student>
    {
      
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }

        public Person personObj = new Person();


        public Student(string program, DateTime dateRegistered)
        {
            Program = program;
            DateRegistered = dateRegistered;
        }

        public Student(string program, DateTime dateRegistered, Person obj)
        {
            Program = program;
            DateRegistered = dateRegistered;
            personObj = obj;

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
            if (other == null)
                return 1;
            if (ReferenceEquals(other, this))
                return 0;
            if (other.GetType() != this.GetType())
                throw new ArgumentException();
            return this.DateRegistered.CompareTo(other.DateRegistered);
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
    }
}
