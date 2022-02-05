using System;
using System.Collections.Generic;
using System.Text;

namespace Session13_AssessableLab
{
    public class Address
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
        // Equals Override
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
        // Get Hashcode Override
        public override int GetHashCode()
        {
            return this.Street.GetHashCode() ^ this.Street.GetHashCode();
        }
        // Override the == Operator
        public static bool operator ==(Address x, Address y)
        {
            return object.Equals(x, y);
        }
        // Override the != Operator
        public static bool operator !=(Address x, Address y)
        {
            return !object.Equals(x, y);
        }

    }
}
