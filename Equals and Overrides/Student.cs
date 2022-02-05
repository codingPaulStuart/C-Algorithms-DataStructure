using System;
using System.Collections.Generic;
using System.Text;

namespace Session13_AssessableLab
{
    public class Student
    {
      
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }

        public Student(string program, DateTime dateRegistered)
        {
            Program = program;
            DateRegistered = dateRegistered;
        }

        // Equals Override
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
        // Get Hashcode Override
        public override int GetHashCode()
        {
            return this.DateRegistered.GetHashCode() ^ this.DateRegistered.GetHashCode();
        }
        // Override the == Operator
        public static bool operator ==(Student x, Student y)
        {
            return object.Equals(x, y);
        }
        // Override the != Operator
        public static bool operator !=(Student x, Student y)
        {
            return !object.Equals(x, y);
        }
    }
}
