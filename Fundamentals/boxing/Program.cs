using System;
using System.Collections.Generic;
namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty List of type object
            List<object> arr= new List<object>();

            //Add the following values to the list: 7, 28, -1, true, "chair"
            arr.Add(7);
            arr.Add(28);
            arr.Add(-1);
            arr.Add(true);
            arr.Add("chair");

//Loop through the list and print all the values
            for(int i=0;i<arr.Count;i++){
                Console.WriteLine(arr[i]);
            }


//Add all values that are Int type together and output the sum (Hint: Type Inference might help here!)

    int sum=0;
        for(int i=0;i<arr.Count;i++){
                if(arr[i] is int){
                    int e= (int) arr[i];
                    sum=sum+e;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
