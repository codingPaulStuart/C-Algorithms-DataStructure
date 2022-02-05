using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Session14_AssessableLab
{
    class AddressItemEqCompare : EqualityComparer<Address>
    {

        private static readonly AddressItemEqCompare _instance = new AddressItemEqCompare();

        public static AddressItemEqCompare Instance { get { return _instance; } }

        private AddressItemEqCompare() { }


        public override bool Equals(Address x, Address y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;
            return x.Street.ToUpperInvariant() == y.Street.ToUpperInvariant() && x.PostCode == y.PostCode;
        }

        public override int GetHashCode(Address obj)
        {
            return obj.Street.ToUpperInvariant().GetHashCode() ^ obj.PostCode.GetHashCode();
        }

    }
}
