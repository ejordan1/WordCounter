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
                Console.WriteLine("You were supposed to enter a sentence and instead you decided to just press enter");
                sentence = Console.ReadLine();
            }
            Console.WriteLine("Good");
            Console.WriteLine("Go ahead and enter the word");
            string word = Console.ReadLine();
            while(word == ""){
                Console.WriteLine("You just pressed enter. You have to type in the word, then press enter! ffs!");
                word = Console.ReadLine();
            }
            Random rnd = new Random();
            Console.WriteLine(word + " appeared " + Counter.CountWordFrequency(word, sentence) + " in the sentence you inputted. Nicely done. That is better than " + rnd.Next(1, 99) + "% of users! Niiiiiiice");
        
        } while(Program.AsksUserIfPlayAgain());
        Console.WriteLine("Until next time, Dave");
        }

        public static bool AsksUserIfPlayAgain(){
            Console.WriteLine("Would you like to enter another sentence?");
            string input = Console.ReadLine().ToLower();
            if (input == "n" || input == "no" || input == "nope" || input == "noo"){
                return false;
            }
            return true;
        }
    }
}