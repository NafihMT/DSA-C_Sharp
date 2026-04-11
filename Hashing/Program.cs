namespace Hashing
{
    internal class Program
    {
        public class Student
        {
            public string message()
            {
                return ("Hello");
            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1 = s2;
            
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

            Console.WriteLine("-------------------------------------------");


            HashTable h1 = new HashTable(1);

            Console.WriteLine(h1.GetIndex(1));
        }
    }
}
