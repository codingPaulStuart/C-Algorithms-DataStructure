using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Session14_AssessableLab
{
    public class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public Person(int id, string name, int phone, string email)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
        }

        public Person()
        {
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
            Person rhs = obj as Person;
            return this.Name == rhs.Name && this.Phone == rhs.Phone;
        }
        // Get Hashcode Override ---------------------------------------
        public override int GetHashCode()
        {
            int hash = 7;
            hash = 23 * hash + this.Phone.GetHashCode();
            hash = 23 * hash + this.Name.GetHashCode();
            hash = 23 * hash + this.Email.GetHashCode();
            hash = 23 * hash + this.Id.GetHashCode();

            return hash;
        }

        // Override the == Operator ---------------------------------------
        public static bool operator ==(Person x, Person y)
        {
            return object.Equals(x, y);
        }
        // Override the != Operator ---------------------------------------
        public static bool operator !=(Person x, Person y)
        {
            return !object.Equals(x, y);
        }

        // Compare To Implement ---------------------------------------
        public int CompareTo(Person other)
        {
            if (other == null)
                return 1;
            if (ReferenceEquals(other, this))
                return 0;
            if (other.GetType() != this.GetType())
                throw new ArgumentException();
            return this.Id.CompareTo(other.Id);
        }

        // Compare multi-field Override ---------------------------------------
        public int Compare(Person o1, Person o2)
        {
            // For Comparison
            int nameCompare = o1.Name.CompareTo(o2.Name);
            int phoneCompare = o1.Phone.CompareTo(o2.Phone);
            int emailCompare = o1.Email.CompareTo(o2.Email);
            int hashCompare = o1.GetHashCode().CompareTo(o2.GetHashCode());

            // Check variables and use hashcode
            if (nameCompare == 0)
            {
                return ((hashCompare == 0) ? phoneCompare : hashCompare);
            }
            if (emailCompare == 0)
            {
                return ((hashCompare == 0) ? phoneCompare : hashCompare);
            } else
            {
                return hashCompare;
            }
    
        }

        // Operator < > <= >= bool To Implement ---------------------------------------
        public static bool operator < (Person x, Person y)
        {
            return x.Id < y.Id;
        }
        public static bool operator >(Person x, Person y)
        {
            return x.Id > y.Id;
        }
        public static bool operator <=(Person x, Person y)
        {
            return x.Id <= y.Id;
        }
        public static bool operator >=(Person x, Person y)
        {
            return x.Id >= y.Id;
        }

    }
}
