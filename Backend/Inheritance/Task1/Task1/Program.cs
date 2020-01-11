using System;

namespace Task1
{
    public class Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }
    }
    public class A : Printer
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            A a =new A();
            printer = a;
            a.Print("hello");
            printer.Print("world");

            //a = printer;  так нельзя, нужно явное преобразование
            a =(A)printer;
            a.Print("aaaa");
        }
    }
}
