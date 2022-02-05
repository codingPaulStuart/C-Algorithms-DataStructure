using System;
using System.Collections.Generic;
using System.Text;

namespace Session13_AssessableLab
{
    public class Enrollment
    {
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public int Semester { get; set; }

        public Enrollment(DateTime dateEnrolled, string grade, int semester)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
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
            Enrollment rhs = obj as Enrollment;
            return this.DateEnrolled == rhs.DateEnrolled && this.Semester == rhs.Semester && this.Grade == rhs.Grade;
        }
        // Get Hashcode Override
        public override int GetHashCode()
        {
            return this.DateEnrolled.GetHashCode() ^ this.DateEnrolled.GetHashCode();  
        }
        // Override the == Operator
        public static bool operator ==(Enrollment x, Enrollment y)
        {
            return object.Equals(x, y);
        }
        // Override the != Operator
        public static bool operator !=(Enrollment x, Enrollment y)
        {
            return !object.Equals(x, y);
        }

    }
}
