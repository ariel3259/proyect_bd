using System;

namespace school
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person p = new Person(1, "Ariel", "Santangelo", "susanarcia@gmail.com", "1234", "ariel3259", "06/22/21", "06/22/21");
            Console.WriteLine(p.ToString());
        }
    }

}
