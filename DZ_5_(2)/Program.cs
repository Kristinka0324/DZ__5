using System;
using System.IO;


namespace DZ_5__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            File.WriteAllText(filename, DateTime.Now.ToString("F"));

        }
    }
}
