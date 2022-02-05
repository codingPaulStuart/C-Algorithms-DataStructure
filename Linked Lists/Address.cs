using System;
using System.Collections.Generic;
using System.Text;

namespace labs16_Exercises
{
    public class Address : IComparable<Address>
    {

        public int Number { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public int PostCode { get; set; }
        public string State { get; set; }

        public Address(int number, string street, string suburb, int postCode, string state)
        {
            Number = number;
            Street = street;
            Suburb = suburb;
            PostCode = postCode;
            State = state;
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
            Address rhs = obj as Address;
            return this.Number == rhs.Number && this.Street == rhs.Street && this.Suburb == rhs.Suburb;
        }
        // Get Hashcode Override ---------------------------------------
        public override int GetHashCode()
        {
            int hash = 7;
            hash = 23 * hash + this.Street.GetHashCode();
            hash = 23 * hash + this.Suburb.GetHashCode();
            hash = 23 * hash + this.PostCode.GetHashCode();
            hash = 23 * hash + this.Number.GetHashCode();

            return hash;
        }
        // Override the == Operator ---------------------------------------
        public static bool operator ==(Address x, Address y)
        {
            return object.Equals(x, y);
        }
        // Override the != Operator
        public static bool operator !=(Address x, Address y)
        {
            return !object.Equals(x, y);
        }

        // Compare To Implement ---------------------------------------
        public int CompareTo(Address other)
        {
            if (other == null)
                return 1;
            if (ReferenceEquals(other, this))
                return 0;
            if (other.GetType() != this.GetType())
                throw new ArgumentException();
            return this.Street.CompareTo(other.Street);
        }

        // Compare multi-field Override ---------------------------------------
        public int Compare(Address o1, Address o2)
        {
            // For Comparison
            int streetCompare = o1.Street.CompareTo(o2.Street);
            int suburbCompare = o1.Suburb.CompareTo(o2.Suburb);
            int stnumberCompare = o1.PostCode.CompareTo(o2.PostCode);
            int hashCompare = o1.GetHashCode().CompareTo(o2.GetHashCode());

            // Check variables and use hashcode
            if (streetCompare == 0)
            {
                return ((hashCompare == 0) ? suburbCompare : hashCompare);
            }
            if (stnumberCompare == 0)
            {
                return ((hashCompare == 0) ? suburbCompare : hashCompare);
            }
            else
            {
                return hashCompare;
            }

        }

        // Operator < > <= >= bool To Implement ---------------------------------------
        public static bool operator <(Address x, Address y)
        {
            return x.GetHashCode() < y.GetHashCode();
        }
        public static bool operator >(Address x, Address y)
        {
            return x.GetHashCode() > y.GetHashCode();
        }
        public static bool operator <=(Address x, Address y)
        {
            return x.GetHashCode() <= y.GetHashCode();
        }
        public static bool operator >=(Address x, Address y)
        {
            return x.GetHashCode() >= y.GetHashCode();
        }

    }
}
