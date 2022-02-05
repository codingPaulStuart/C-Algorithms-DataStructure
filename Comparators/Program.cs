using System;
using System.Collections.Generic;

namespace Session14_AssessableLab
{
    class Program
    {
        static void Main(string[] args)
        {

            // Labs 14 Assessable Person Testing --------------------------------------- //
            Console.WriteLine("\n--------------------------------------- Person Class Testing --------------------------------------- ");
            Person p1 = new Person(123, "Bob", 0432568439, "bob@example.com");
            Person p2 = new Person(123, "Bob", 0432568439, "bob@example.com");
            Person p3 = new Person(948, "Steve", 04629753, "steve@example.com");
            Person p4 = new Person(943, "Graham", 0135897415, "graham@example.com");
            Person p5 = new Person(715, "graham", 0135897415, "Graham@example.com");
            Person[] personList = { p1, p2, p3, p4, p5};

            HashSet<Person> hashSet = new HashSet<Person>(PersonItemEqComparer.Instance);
            hashSet.Add(p1);
            hashSet.Add(p2);
            hashSet.Add(p3);
            hashSet.Add(p4);
            hashSet.Add(p5);

            // Hashset Array Sort
            Console.WriteLine("\nSort List Alphabetical without duplicates removed by converting all to upper case: \n");
            Array.Sort(personList);
            foreach (var pers in personList)
            {
                Console.WriteLine(pers.Name);
            }

            Console.WriteLine("\nHashset Compare upper/lower case: \n");
            foreach (var pers in hashSet)
            {
                Console.WriteLine(pers.Name);
            }

            // Compare Override Tests
            Console.WriteLine("\nCompare Override Testing: \n");
            Console.WriteLine(p1.Compare(p1,p2));
            Console.WriteLine(p2.Compare(p2,p3)); 
            Console.WriteLine(p3.Compare(p3,p4)); 

            Console.WriteLine("\nHashcodes: \n");
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p3.GetHashCode());

            // Operators
            Console.WriteLine("\nPerson Operators Testing, 2 objects: \n");           
            if (p1 < p2)
            {
                Console.WriteLine("p1 is less than p2 using ID to compare");
            }
            if (p1 > p2)
            {
                Console.WriteLine("p1 is greater than p2 using ID to compare");
            }
            if (p1 >= p2)
            {
                Console.WriteLine("p1 is greater than/equal to p2 using ID to compare");
            }
            if (p1 <= p2)
            {
                Console.WriteLine("p1 is less than/equal to p2 using ID to compare");
            }
            Console.WriteLine("\nPerson = Operators Testing, 2 objects: \n");
            Console.WriteLine("p1 == p3: " + (p1 == p3));
            Console.WriteLine("p1 != p2: " + (p1 != p2));

            // CompareTo Testing
            Console.WriteLine("\nCompareTo testing for 2 objects (using ID: \n");
            Console.WriteLine(p1.CompareTo(p3));
            Console.WriteLine(p2.CompareTo(p4));

            // Labs 14 Assessable Address Testing --------------------------------------- //
            Console.WriteLine("--------------------------------------- Address Class Testing --------------------------------------- ");
            Address a1 = new Address(1, "smirty Street", "Hawthorne", 4589, "VIC");
            Address a2 = new Address(15, "Barry Street", "Hawthorne", 3204, "NSW");
            Address a3 = new Address(1, "South Road", "Beachworth", 6489, "WA");
            Address a4 = new Address(1, "Smirty street", "Hawthorne", 4589, "VIC");


            Address[] addresslist = { a1, a2, a3, a4 };

            HashSet<Address> hashSetAd = new HashSet<Address>(AddressItemEqCompare.Instance);
            hashSetAd.Add(a1);
            hashSetAd.Add(a2);
            hashSetAd.Add(a3);

            // Hashset Array Sort
            Console.WriteLine("\nSort List Alphabetical without duplicates removed by converting all to upper case: \n");
            Array.Sort(addresslist);
            foreach (var locations in addresslist)
            {
                Console.WriteLine(locations.Street);
            }

            Console.WriteLine("\nHashset Compare upper/lower case: \n");
            foreach (var locations in hashSetAd)
            {
                Console.WriteLine(locations.Street);
            }

            // Compare Override Tests
            Console.WriteLine("\nCompare Override Testing: \n");
            Console.WriteLine(a1.Compare(a1, a2));
            Console.WriteLine(a2.Compare(a1, a3));
            Console.WriteLine(a3.Compare(a3, a2));

            Console.WriteLine("\nHashcodes: \n");
            Console.WriteLine(a1.GetHashCode());
            Console.WriteLine(a2.GetHashCode());
            Console.WriteLine(a3.GetHashCode());

            // Operators
            Console.WriteLine("\nPerson Operators Testing, 2 objects: \n");
            if (a1 < a2)
            {
                Console.WriteLine("a1 is less than a2 using ID to compare");
            }
            if (a1 > a2)
            {
                Console.WriteLine("a1 is greater than a2 using ID to compare");
            }
            if (a1 >= a2)
            {
                Console.WriteLine("a1 is greater than/equal to a2 using ID to compare");
            }
            if (a1 <= a2)
            {
                Console.WriteLine("a1 is less than/equal to a2 using ID to compare");
            }
            Console.WriteLine("\nPerson = Operators Testing, 2 objects: \n");
            Console.WriteLine("a1 == a3: " + (a1 == a3));
            Console.WriteLine("a1 != a2: " + (a1 != a2));

            // CompareTo Testing
            Console.WriteLine("\nCompareTo testing for 2 objects (using ID: \n");
            Console.WriteLine(a1.CompareTo(a3));
            Console.WriteLine(a1.CompareTo(a2));

            // Labs 14 Assessable Student Testing --------------------------------------- //
            Console.WriteLine("--------------------------------------- Student Class Testing --------------------------------------- ");
            Student s1 = new Student("Maths", DateTime.Today, p1);
            Student s2 = new Student("Maths", DateTime.Today, p2);
            Student s3 = new Student("Sport", DateTime.Now, p3);


            Student[] studentList = { s1, s2, s3 };

            HashSet<Student> hashSetstu = new HashSet<Student>(StudentItemEqComparer.Instance);
            hashSetstu.Add(s1);
            hashSetstu.Add(s2);
            hashSetstu.Add(s3);

            // Hashset Array Sort
            Console.WriteLine("\nSort List Alphabetical without duplicates removed by converting all to upper case: \n");
            Array.Sort(studentList);
            foreach (var newStudents in studentList)
            {
                Console.WriteLine(newStudents.Program);
            }

            Console.WriteLine("\nHashset Compare upper/lower case: \n");
            foreach (var newStudents in hashSetstu)
            {
                Console.WriteLine(newStudents.Program);
            }

            // Compare Override Tests
            Console.WriteLine("\nCompare Override Testing: \n");
            Console.WriteLine("s1 and s2 = " + (s1.Compare(s1, s2)));
            Console.WriteLine("s1 and s3 = " + (s1.Compare(s1, s3)));
            Console.WriteLine("s3 and s2 = " + (s1.Compare(s3, s2)));

            Console.WriteLine("\nHashcodes: \n");
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());

            // Operators
            Console.WriteLine("\nPerson Operators Testing, 2 objects: \n");
            if (s1 < s2)
            {
                Console.WriteLine("s1 is less than s2 using ID to compare");
            }
            if (s1 > s2)
            {
                Console.WriteLine("s1 is greater than s2 using ID to compare");
            }
            if (s1 >= s2)
            {
                Console.WriteLine("s1 is greater than/equal to s2 using ID to compare");
            }
            if (s1 <= s2)
            {
                Console.WriteLine("s1 is less than/equal to s2 using ID to compare");
            }
            Console.WriteLine("\nPerson = Operators Testing, 2 objects: \n");
            Console.WriteLine("s1 == s3 : " + (s1 == s3));
            Console.WriteLine("s1 != s2 : " + (s1 != s2));

            // CompareTo Testing
            Console.WriteLine("\nCompareTo testing for 2 objects (using ID: \n");
            Console.WriteLine(s1.CompareTo(s3));
            Console.WriteLine(s1.CompareTo(s2));

            // Labs 14 Assessable Course Testing --------------------------------------- //
            Console.WriteLine("--------------------------------------- Course Class Testing --------------------------------------- ");
            Course c1 = new Course(1234, "Diploma of Sport", 450.50f);
            Course c2 = new Course(1234, "diploma of sport", 450.50f);
            Course c3 = new Course(5168, "Cert IV of Sport", 450.50f);



            Course[] courseList = { c1, c2, c3 };

            HashSet<Course> hashSetCour = new HashSet<Course>(CourseItemEqComparer.Instance);
            hashSetCour.Add(c1);
            hashSetCour.Add(c2);
            hashSetCour.Add(c3);

            // Hashset Array Sort
            Console.WriteLine("\nSort List Alphabetical without duplicates removed by converting all to upper case: \n");
            Array.Sort(courseList);
            foreach (var newCourse in courseList)
            {
                Console.WriteLine(newCourse.CourseCode + " " + newCourse.CourseName);
            }

            Console.WriteLine("\nHashset Compare upper/lower case: \n");
            foreach (var newCourse in hashSetCour)
            {
                Console.WriteLine(newCourse.CourseCode + " " + newCourse.CourseName);
            }

            // Compare Override Tests
            Console.WriteLine("\nCompare Override Testing: \n");
            Console.WriteLine("c1 and c2 = " + (c1.Compare(c1, c2)));
            Console.WriteLine("c2 and c3 = " + (c2.Compare(c2, c3)));
            Console.WriteLine("c1 and c3 = " + (c3.Compare(c1, c3)));


            Console.WriteLine("\nHashcodes: \n");
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
            Console.WriteLine(c3.GetHashCode());

            // Operators
            Console.WriteLine("\nPerson Operators Testing, 2 objects: \n");
            if (c1 < c3)
            {
                Console.WriteLine("c1 is less than c3 using CourseCode to compare");
            }
            if (c1 > c3)
            {
                Console.WriteLine("c1 is greater than c3 using CourseCode to compare");
            }
            if (c1 >= c3)
            {
                Console.WriteLine("c1 is greater than/equal to c3 using CourseCode to compare");
            }
            if (c1 <= c3)
            {
                Console.WriteLine("c1 is less than/equal to c3 using CourseCode to compare");
            }
            Console.WriteLine("\nCourse = Operators Testing, 2 objects: \n");
            Console.WriteLine("c1 == c3 : " + (c1 == c3));
            Console.WriteLine("c1 != c2 : " + (c1 != c2));

            // CompareTo Testing
            Console.WriteLine("\nCompareTo testing for 2 objects (using CourseCode): \n");
            Console.WriteLine(c1.CompareTo(c3));
            Console.WriteLine(c1.CompareTo(c2));

            // Labs 14 Assessable Enrollment Testing --------------------------------------- //
            Console.WriteLine("--------------------------------------- Enrollment Class Testing --------------------------------------- ");
            Enrollment e1 = new Enrollment(DateTime.Now, "D", 1);
            Enrollment e2 = new Enrollment(DateTime.Now, "D", 1);
            Enrollment e3 = new Enrollment(DateTime.Now, "C", 2);

            Enrollment[] enrolList = { e1, e2, e3 };

            HashSet<Enrollment> hashSetEnr = new HashSet<Enrollment>(EnrolItemEqComparer.Instance);
            hashSetEnr.Add(e1);
            hashSetEnr.Add(e2);
            hashSetEnr.Add(e3);

            // Hashset Array Sort
            Console.WriteLine("\nSort List Alphabetical without duplicates removed by converting all to upper case: \n");
            Array.Sort(enrolList);
            foreach (var newEnrol in enrolList)
            {
                Console.WriteLine(newEnrol.DateEnrolled + " " + newEnrol.Grade);
            }
            
            Console.WriteLine("\nHashset Compare upper/lower case: \n");
            foreach (var newEnrol in hashSetEnr)
            {
                Console.WriteLine(newEnrol.DateEnrolled + " " + newEnrol.Grade);
            }

            // Compare Override Tests
            Console.WriteLine("\nCompare Override Testing: \n");
            Console.WriteLine("e1 and e2 = " + (e1.Compare(e1, e2)));
            Console.WriteLine("e2 and e3 = " + (e2.Compare(e2, e3)));
            Console.WriteLine("e3 and e1 = " + (e3.Compare(e3, e1)));


            Console.WriteLine("\nHashcodes: \n");
            Console.WriteLine(e1.GetHashCode());
            Console.WriteLine(e2.GetHashCode());
            Console.WriteLine(e3.GetHashCode());

            // Operators
            Console.WriteLine("\nEnrollment Operators Testing, 2 objects: \n");
            if (e1 < e3)
            {
                Console.WriteLine("e1 is less than e3 using hashcode to compare");
            }
            if (e1 > e3)
            {
                Console.WriteLine("e1 is greater than e3 using hashcode to compare");
            }
            if (e1 >= e3)
            {
                Console.WriteLine("e1 is greater than/equal to e3 using hashcode to compare");
            }
            if (e1 <= e3)
            {
                Console.WriteLine("e1 is less than/equal to e3 using hashcode to compare");
            }
            Console.WriteLine("\nEnrollment = Operators Testing, 2 objects: \n");
            Console.WriteLine("e1 == e3 : " + (e1 == e3));
            Console.WriteLine("e1 != e2 : " + (e1 != e2));

            // CompareTo Testing
            Console.WriteLine("\nCompareTo testing for 2 objects (using hashcode): \n");
            Console.WriteLine(c1.CompareTo(c3));
            Console.WriteLine(c1.CompareTo(c2));








        }
    }
}
