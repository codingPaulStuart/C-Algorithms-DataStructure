using System;
using System.Collections.Generic;
using System.Text;

namespace Session14_AssessableLab
{
    class CourseItemEqComparer : EqualityComparer<Course>
    {

        private static readonly CourseItemEqComparer _instance = new CourseItemEqComparer();

        public static CourseItemEqComparer Instance { get { return _instance; } }

        private CourseItemEqComparer() { }


        public override bool Equals(Course x, Course y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            return x.CourseName.ToUpperInvariant() == y.CourseName.ToUpperInvariant() && x.CourseCode == y.CourseCode;
        }

        public override int GetHashCode(Course obj)
        {
            return obj.CourseName.ToUpperInvariant().GetHashCode() ^ obj.CourseCode.GetHashCode();
        }

    }
}
