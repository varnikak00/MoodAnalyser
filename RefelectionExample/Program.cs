
using System;

namespace RefelectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ConstructorInfo;
            double a = 10;
            Employer emp = new Employer();
             
            Type type = a.GetType();
            //Type t = typeof(emp);
            ConstructorInfo[]
            Type type = a.GetType();

            Console.WriteLine(type);
            Type t = typeof(System.String);
            Console.WriteLine("Constructor of {0}type", t);
            ConstructorInfo[] ci = t.GetConstructors(System.Reflection BindingFlags.public | BindingFlags.instance);
            foreach(ConstructorInfo c in mi)
            {
          Console.WriteLine(c);
           }
        }
    