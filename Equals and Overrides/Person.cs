using System;
using System.Collections.Generic;
using System.Text;

namespace Session13_AssessableLab
{
    public class Person
    {

        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public Person(string name, int phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
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
            Person rhs = obj as Person;
            return this.Name == rhs.Name && this.Phone == rhs.Phone;
        }
        // Get Hashcode Override
        public override int GetHashCode()
        {
            return this.Phone.GetHashCode() ^ this.Phone.GetHashCode();
        }
        // Override the == Operator
        public static bool operator ==(Person x, Person y)
        {
            return object.Equals(x, y);
        }
        // Override the != Operator
        public static bool operator !=(Person x, Person y)
        {
            return !object.Equals(x, y);
        }
    }
}
