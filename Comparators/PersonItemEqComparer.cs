using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Session14_AssessableLab
{
    class PersonItemEqComparer : EqualityComparer<Person>
    {
        private static readonly PersonItemEqComparer _instance = new PersonItemEqComparer();
        
        public static PersonItemEqComparer Instance { get { return _instance; } }
        
        private PersonItemEqComparer() { }
        
        
        public override bool Equals( Person x, Person y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            return x.Name.ToUpperInvariant() == y.Name.ToUpperInvariant() && x.Id == y.Id;
        }

        public override int GetHashCode( Person obj)
        {
            return obj.Name.ToUpperInvariant().GetHashCode() ^ obj.Id.GetHashCode();
        }
    }
}
