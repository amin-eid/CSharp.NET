using System;
using System.Collections.Generic;
namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Three Basic Arrays
            int[] nums={0,1,2,3,4,5,6,7,8,9};
            string[] names={"Tim", "Martin", "Nikki",  "Sofa"};
            bool[] test={true,false,true,false,true,false,true,false,true,false};


            //List of Flavors
            List<string> flavors=new List<string>();
            flavors.Add("Lemon");
            flavors.Add("Mint");
            flavors.Add("Apple");
            flavors.Add("Melon");
            flavors.Add("Watermelom");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.Remove("Apple");
            Console.WriteLine(flavors.Count);



//User Info Dictionary
Dictionary<string,string> dict= new Dictionary<string,string>();
Random rand = new Random();

foreach(string n in names){
    dict.Add(n,flavors[rand.Next(0,4)]);

}
foreach(var k in dict){
    Console.WriteLine(k.Key+" val i: " +k.Value);
}
        }
    }
}
