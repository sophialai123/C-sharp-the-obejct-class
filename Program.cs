using System;

namespace TheObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bk = new Book("Ta-Nehisi Coates", "Between the World and Me");

            Diary dy = new Diary(38);
            int i = 9;
            Random r = new Random();

            //Create a new Object reference for each one.
            // Object bko = bk;
            // Object dyo = dy;
            // Object io = i;
            //Create an array of type Object[]
            Object[] objects = { bk, dy, r, i };
            foreach (Object obj in objects)
            {
                Console.WriteLine(obj.GetType());
            }

            //bk.ToString() method
            Console.WriteLine(bk.ToString());
        }
    }
}
