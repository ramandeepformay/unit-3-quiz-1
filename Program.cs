using System.Data;
using System;
using System.Collections.Generic;

namespace unit3
{
    class Program
    {
        public static void Main(string[] args)
        { var list = new List<int>();
        var i=0;
            var m1 = new Movie("Interstellar","Christopher Nolan",2014,12, list);
            while(i<3){
                System.Console.WriteLine("Enter the Rating for the movie");
                var userInput = Console.ReadLine();
                System.Console.WriteLine("============ /n");
                var intUserInput = Convert.ToInt32(userInput);
                m1.AddRating(intUserInput);
                list.Add(intUserInput);
              i++;
            }
            System.Console.WriteLine("============");
           m1.PrintDetails();
           System.Console.WriteLine("============");
           System.Console.WriteLine( $"{m1.Title}'s avergae Rating is {m1.getAverageRating()} ");
        }
    } 
   
}
