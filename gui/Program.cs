using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Program
    {
        static void Main() { 

            A a = new A();
            B b = new B();
            C c = new C();
            D d = new D();

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());

            Console.WriteLine(a.Oneday());
            Console.WriteLine(b.Oneday());
            Console.WriteLine(c.Oneday());
            Console.WriteLine(d.Oneday());



        }


        
    }
}
