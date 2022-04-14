using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\Orkhan\OneDrive\Desktop\Relax");
            using (StreamWriter stream = new StreamWriter(@"C:\Users\Orkhan\OneDrive\Desktop\Relax\Summer.txt"))
            {
                stream.WriteLine("Summer");
            };
        }
    }
}
