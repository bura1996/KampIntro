using System;

namespace DenemeDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictonary<int,string> dictonary = new Dictonary<int,string>();
            dictonary.Add(3, "Salibaba");
        }
    }
}
