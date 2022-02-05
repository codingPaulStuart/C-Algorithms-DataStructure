using System;
using System.Collections.Generic;
using System.Text;

namespace Session14_AssessableLab
{
    public class Enrollment : IComparable<Enrollment>
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

        // Equals Override ---------------------------------------
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
        // Get Hashcode Override ---------------------------------------
        public override int GetHashCode()
        {
            int hash = 7;
            hash = 23 * hash + this.DateEnrolled.GetHashCode();
            hash = 23 * hash + this.Semester.GetHashCode();
            hash = 23 * hash + this.Grade.GetHashCode();

            return hash;
        }
        // Override the == Operator ---------------------------------------
        public static bool operator ==(Enrollment x, Enrollment y)
        {
            return object.Equals(x, y);
        }
        // Override the != Operator ---------------------------------------
        public static bool operator !=(Enrollment x, Enrollment y)
        {
            return !object.Equals(x, y);
        }

        // Compare To Implement ---------------------------------------
        public int CompareTo(Enrollment other)
        {
            if (other == null)
                return 1;
            if (ReferenceEquals(other, this))
                return 0;
            if (other.GetType() != this.GetType())
                throw new ArgumentException();
            return this.DateEnrolled.GetHashCode().CompareTo(other.DateEnrolled.GetHashCode());
        }

        // Compare multi-field Override ---------------------------------------
        public int Compare(Enrollment o1, Enrollment o2)
        {
            // For Comparison
            int gradeCompare = o1.Grade.CompareTo(o2.Grade);
            int semesterCompare = o1.Semester.CompareTo(o2.Semester);
            int dateCompare = o1.DateEnrolled.CompareTo(o2.DateEnrolled);
            int hashCompare = o1.GetHashCode().CompareTo(o2.GetHashCode());

            // Check variables and use hashcode
            if (gradeCompare == 0)
            {
                return ((hashCompare == 0) ? dateCompare : hashCompare);
            }
            if (semesterCompare == 0)
            {
                return ((hashCompare == 0) ? dateCompare : hashCompare);
            }
            else
            {
                return hashCompare;
            }

        }

        // Operator < > <= >= bool To Implement ---------------------------------------
        public static bool operator <(Enrollment x, Enrollment y)
        {
            return x.GetHashCode() < y.GetHashCode();
        }
        public static bool operator >(Enrollment x, Enrollment y)
        {
            return x.GetHashCode() > y.GetHashCode();
        }
        public static bool operator <=(Enrollment x, Enrollment y)
        {
            return x.GetHashCode() <= y.GetHashCode();
        }
        public static bool operator >=(Enrollment x, Enrollment y)
        {
            return x.GetHashCode() >= y.GetHashCode();
        }
    }
}
