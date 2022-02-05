using System;
using System.Collections.Generic;
using System.Text;

namespace labs16_Exercises
{
    public class Course : IComparable<Course>
    {

        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        public float Cost { get; set; }

        public Course(int courseCode, string courseName, float cost)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Cost = cost;
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
            Course rhs = obj as Course;
            return this.CourseName == rhs.CourseName && this.CourseCode == rhs.CourseCode;
        }
        // Get Hashcode Override ---------------------------------------
        public override int GetHashCode()
        {
            int hash = 7;
            hash = 23 * hash + this.Cost.GetHashCode();
            hash = 23 * hash + this.CourseCode.GetHashCode();
            hash = 23 * hash + this.CourseName.GetHashCode();

            return hash;
        }
        // Override the == Operator ---------------------------------------
        public static bool operator ==(Course x, Course y)
        {
            return object.Equals(x, y); 
        }
        // Override the != Operator
        public static bool operator !=(Course x, Course y)
        {
            return !object.Equals(x, y);
        }
        // Compare To Implement ---------------------------------------
        public int CompareTo(Course other)
        {
            if (other == null)
                return 1;
            if (ReferenceEquals(other, this))
                return 0;
            if (other.GetType() != this.GetType())
                throw new ArgumentException();
            return this.CourseCode.CompareTo(other.CourseCode);
        }

        // Compare multi-field Override ---------------------------------------
        public int Compare(Course o1, Course o2)
        {
            // For Comparison
            int courseNameCompare = o1.CourseName.CompareTo(o2.CourseName);
            int courseCostCompare = o1.Cost.CompareTo(o2.Cost);
            int courseCodeCompare = o1.CourseCode.CompareTo(o2.CourseCode);
            int hashCompare = o1.GetHashCode().CompareTo(o2.GetHashCode());

            // Check variables and use hashcode
            if (courseNameCompare == 0)
            {
                return ((hashCompare == 0) ? courseCodeCompare : hashCompare);
            }
            if (courseCostCompare == 0)
            {
                return ((hashCompare == 0) ? courseCodeCompare : hashCompare);
            }
            else
            {
                return hashCompare;
            }

        }

        // Operator < > <= >= bool To Implement ---------------------------------------
        public static bool operator <(Course x, Course y)
        {
            return x.CourseCode < y.CourseCode;
        }
        public static bool operator >(Course x, Course y)
        {
            return x.CourseCode > y.CourseCode;
        }
        public static bool operator <=(Course x, Course y)
        {
            return x.CourseCode <= y.CourseCode;
        }
        public static bool operator >=(Course x, Course y)
        {
            return x.CourseCode >= y.CourseCode;
        }


    }
}
