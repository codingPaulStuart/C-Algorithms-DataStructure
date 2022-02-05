using System;

namespace Session13_AssessableLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Enrollment e1 = new Enrollment(DateTime.Today, "A", 2);
            Enrollment e2 = new Enrollment(DateTime.Today, "B", 2);
            Enrollment e3 = new Enrollment(DateTime.Today, "P", 1);
            Enrollment e4 = new Enrollment(DateTime.Today, "C", 1);

            Console.WriteLine("\n------------------------------ Enrollment Class Testing ------------------------------\n");
            Console.WriteLine("Comparing 2 Enrollment objects with .equals override: " + (e1.Equals(e2))); // False
            Console.WriteLine("Comparing 2 Enrollment objects with == override: " + (e1 == e2)); // False
            Console.WriteLine("Comparing 2 Enrollment objects with .equals override: " + (e3.Equals(e4))); // False
            Console.WriteLine("Comparing 2 Enrollment objects with == override: " + (e3 == e4)); // False
            Console.WriteLine("Get Hashcodes .equals for e1 and e2: " + e1.GetHashCode().Equals(e2.GetHashCode())); // Returns True becuase uses dateTime hashCode()

            Address a1 = new Address(13, "Davids Street", "Richmond", 5439, "SA");
            Address a2 = new Address(12, "Davids Street", "Richmond", 5439, "SA");
            Address a3 = new Address(450, "Main Road", "Enfield", 5731, "SA");
            Address a4 = new Address(450, "Main Road", "Brighton", 5798, "SA");

            Console.WriteLine("\n------------------------------ Address Class Testing ------------------------------\n");
            Console.WriteLine("Comparing 2 Address objects with .equals override: " + (a1.Equals(a2))); // False
            Console.WriteLine("Comparing 2 Address objects with == override: " + (a1 == a2)); // False
            Console.WriteLine("Comparing 2 Address objects with .equals override: " + (a3.Equals(a4))); // False
            Console.WriteLine("Comparing 2 Address objects with == override: " + (a3 == a4)); // False
            Console.WriteLine("Get Hashcodes .equals for a1 and a2: " + a1.GetHashCode().Equals(a2.GetHashCode())); // Returns True becuase uses street hashCode()

            Person p1 = new Person("Matt", 0456897426, "matt@gmail.com");
            Person p2 = new Person("Jim", 0456737226, "jim@gmail.com");
            Person p3 = new Person("Matt", 0459175426, "matt@gmail.com");
            Person p4 = new Person("Frank", 0456894582, "frank@gmail.com");

            Console.WriteLine("\n------------------------------ Person Class Testing ------------------------------\n");
            Console.WriteLine("Comparing 2 Person objects with .equals override: " + (p1.Equals(p2))); // False
            Console.WriteLine("Comparing 2 Person objects with == override: " + (p1 == p2)); // False
            Console.WriteLine("Comparing 2 Person objects with .equals override: " + (p3.Equals(p4))); // False
            Console.WriteLine("Comparing 2 Person objects with == override: " + (p3 == p4)); // False
            Console.WriteLine("Get Hashcodes .equals for p1 and p2: " + p1.GetHashCode().Equals(p2.GetHashCode())); // Returns True
            Console.WriteLine("Get Hashcodes == for p1 and p2: " + (p1.GetHashCode() == p2.GetHashCode())); // Returns True

            Course c1 = new Course("M101", "Maths", 450.50f);
            Course c2 = new Course("S101", "Science", 500.50f);
            Course c3 = new Course("SP101", "Sports", 330.60f);
            Course c4 = new Course("E101", "English", 220.50f);

            Console.WriteLine("\n------------------------------ Course Class Testing ------------------------------\n");
            Console.WriteLine("Comparing 2 Course Objects with .equals override: " + (c1.Equals(c2))); // False
            Console.WriteLine("Comparing 2 Course objects with == override: " + (c1 == c2)); // False
            Console.WriteLine("Comparing 2 Course Objects with .equals override: " + (c4.Equals(c3))); // False
            Console.WriteLine("Comparing 2 Course objects with == override: " + (c4 == c3)); // False
            Console.WriteLine("Get Hashcodes .equals for c1 and c2: " + c1.GetHashCode().Equals(c2.GetHashCode())); // Returns False
            Console.WriteLine("Get Hashcodes == for c1 and c2: " + (c1.GetHashCode() == c2.GetHashCode())); // Returns False

            Student stu1 = new Student("Diploma", DateTime.Today);
            Student stu2 = new Student("Cert IV", DateTime.Today);
            Student stu3 = new Student("Cert IV", DateTime.Today);
            Student stu4 = new Student("Cert III", DateTime.Today);

            Console.WriteLine("\n------------------------------ Student Class Testing ------------------------------\n");
            Console.WriteLine("Comparing 2 Course Objects with .equals override: " + (stu1.Equals(stu2))); // False
            Console.WriteLine("Comparing 2 Course objects with == override: " + (stu1 == stu2)); // False
            Console.WriteLine("Comparing 2 Course Objects with .equals override: " + (stu3.Equals(stu4))); // False
            Console.WriteLine("Comparing 2 Course objects with == override: " + (stu3 == stu4)); // False
            Console.WriteLine("Get Hashcodes .equals for c1 and c2: " + c1.GetHashCode().Equals(stu2.GetHashCode())); // Returns False
            Console.WriteLine("Get Hashcodes == for stu1 and stu2: " + (c1.GetHashCode() == c2.GetHashCode())); // Returns False


        }
    }
}
