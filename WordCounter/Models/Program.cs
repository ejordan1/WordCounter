using System;
using System.Collections.Generic;


namespace WordCounter.Models{
public class Program{

        public static void Main(){
            do{
            Console.WriteLine("This program takes in a word and a sentence and outputs how many times the word appeared in the sentence.");
            Console.WriteLine("Enter the sentence:");
            string sentence = Console.ReadLine();
            while(sentence == ""){
                Console.WriteLine("You just pressed the enter key instead of typing in the sentence and then pressing the enter key. Type the sentence first, then press enter. Two steps. You can do this.");
                sentence = Console.ReadLine();
            }
            Console.WriteLine("Good. This is great so far.");
            Console.WriteLine("Go ahead and enter the word and we will go from there: ");
            string word = Console.ReadLine();
            while(word == ""){
                Console.WriteLine("You just pressed enter. You have to type in the word, then press enter! ffs!");
                word = Console.ReadLine();
            }
            Console.WriteLine(word + " appeared " + Counter.WordFrequency(word, sentence) + " in the sentence you inputted. Nicely done. That is better than 37% of users!");
        
        } while(Program.PlayAgain());
        Console.WriteLine("Until next time, Dave");
        }

        public static bool PlayAgain(){
            Console.WriteLine("Would you like to enter another sentence?");
            string input = Console.ReadLine().ToLower();
            if (input == "n" || input == "no" || input == "nope" || input == "noo"){
                return false;
            }
            return true;
        }
    }
}