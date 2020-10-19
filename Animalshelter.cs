using System;

namespace unit3
{
    public class Animalshelter
    {  
        public Animalshelter(){
            typeOfAnimal="Rabbit";
            totalAnimals=5;
        }
        public string typeOfAnimal{ get; set;}
        public int totalAnimals { get; set;}

        public void info(){
            System.Console.WriteLine($"Type of animal is {typeOfAnimal}");
            System.Console.WriteLine($"Total {typeOfAnimal}s in the shelter are {totalAnimals}");
        }

        public void printAdopt(){
            System.Console.WriteLine("So, what would you like to do today ??adopt, donate or volunteer? \n");
             var userInput =Console.ReadLine().ToLower();
             if(userInput == "adopt"|| userInput =="a"){
                 totalAnimals--;
                  System.Console.WriteLine($"Thanks for adopting the {typeOfAnimal}");
             }
             else if(userInput == "donate"|| userInput =="d")
             {
                 totalAnimals++;
                  System.Console.WriteLine($"Thanks for rescuing and providing this {typeOfAnimal} with a new home");
             }
             else if(userInput == "volunteer"|| userInput =="v"){
                 System.Console.WriteLine("yes you can work here as a volunteer");
             }
        }

    }
}