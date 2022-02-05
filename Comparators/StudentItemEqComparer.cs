using System;
using System.Collections.Generic;
using System.Text;

namespace Session14_AssessableLab
{
    class StudentItemEqComparer : EqualityComparer<Student>
    {
        private static readonly StudentItemEqComparer _instance = new StudentItemEqComparer();

        public static StudentItemEqComparer Instance { get { return _instance; } }

        private StudentItemEqComparer() { }


        public override bool Equals(Student x, Student y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            return x.personObj.Name.ToString().ToUpperInvariant() == y.personObj.Name.ToString().ToUpperInvariant() && x.Program == y.Program;
        }

        public override int GetHashCode(Student obj)
        {
            return obj.personObj.Name.ToString().ToUpperInvariant().GetHashCode() ^ obj.personObj.Name.ToString().GetHashCode();
        }

    }
}
