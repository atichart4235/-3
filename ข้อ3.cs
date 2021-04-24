using System;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            float filmBackWidth = float.Parse(Console.ReadLine());
            while (filmBackWidth <= 0)
            {
                Console.WriteLine("Invalid filmBackWidth.Please input again.");
                filmBackWidth = float.Parse(Console.ReadLine());
            }
            float fLength, fov;
            if (mode == "fLength")
            {
                fLength = float.Parse(Console.ReadLine());
                while (fLength <=0)
                {
                    Console.WriteLine("Invalid fLength.Please input again.");
                    fLength = float.Parse(Console.ReadLine());
                }
                fov = 2 * Math.Atan(double.Parse(filmBackWidth) / 2);
            }
        }
    }
}
