using System;
using System.Collections.Generic;
namespace unit3
{
    public class Movie{
    
        public String Title { get; set; }
        public String Director { get; set; }
        public int Year{get; set;}
        public int Id { get; set;}       
        public List<int> Rating { get; set;}

        public Movie(string title, string director, int year, int id, List<int> rating){
            Title= title;
            Director= director;
            Year= year;
            Id= id;
            Rating = rating;
        }
        public void PrintDetails(){ 
            System.Console.WriteLine($"Movie Title: {Title}");
            System.Console.WriteLine($"Movie Director: {Director}");
            System.Console.WriteLine($"Movie Title: {Year}");
            
        }

        public void AddRating(int num){
          System.Console.WriteLine($"{Title} rating is {num} \n");
        }
    
        public float getAverageRating(){
            int sum =0;
            float avgSum=0f;
            for(int i=0; i<Rating.Count; i++){
                sum+=Rating[i];
            }
            if(Rating.Count>1){
                avgSum = sum/(Rating.Count);
            }
            
            return avgSum;
        } 
    }

}
