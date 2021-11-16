using System;
using System.IO;

namespace DZ_5__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "текстовый файл.txt";
            File.WriteAllText(filename, " Произвольный набор данных");
        }
    }
}
