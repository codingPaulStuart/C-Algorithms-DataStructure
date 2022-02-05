using System;
using System.Collections.Generic;
using System.Text;

namespace Session14_AssessableLab
{
    class EnrolItemEqComparer : EqualityComparer<Enrollment>
    {
        private static readonly EnrolItemEqComparer _instance = new EnrolItemEqComparer();

        public static EnrolItemEqComparer Instance { get { return _instance; } }

        private EnrolItemEqComparer() { }


        public override bool Equals(Enrollment x, Enrollment y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            return x.Grade.ToUpperInvariant() == y.Grade.ToUpperInvariant() && x.Semester == y.Semester;
        }

        public override int GetHashCode(Enrollment obj)
        {
            return obj.Grade.ToUpperInvariant().GetHashCode() ^ obj.Grade.GetHashCode();
        }

    }
}
