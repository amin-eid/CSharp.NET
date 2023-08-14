using System;

namespace wizard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Human h1=new Human("Amin");
            Ninja n1=new Ninja("Ninja1");
            n1.Attack(h1);
            
        }
    }
}
