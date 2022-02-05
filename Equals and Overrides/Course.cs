using System;
using System.Collections.Generic;
using System.Text;

namespace Session13_AssessableLab
{
    public class Course
    {

        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public float Cost { get; set; }

        public Course(string courseCode, string courseName, float cost)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Cost = cost;
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
            Course rhs = obj as Course;
            return this.CourseName == rhs.CourseName && this.CourseCode == rhs.CourseCode;
        }
        // Get Hashcode Override
        public override int GetHashCode()
        {
            return this.CourseName.GetHashCode() ^ this.CourseCode.GetHashCode();
        }
        // Override the == Operator
        public static bool operator ==(Course x, Course y)
        {
            return object.Equals(x, y); 
        }
        // Override the != Operator
        public static bool operator !=(Course x, Course y)
        {
            return !object.Equals(x, y);
        }
    

    }
}
