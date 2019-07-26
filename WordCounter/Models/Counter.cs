using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

    public static class Counter
    {
        //takes in a word and a sentence, returns number of appearences of word in sentence
        public static int CountWordFrequency(string input, string sentence){
            
            char[] ignoreChars = new char[]{'\''};

            int count = 0;
            string currentStr = "";
            for(int i = 0; i < sentence.Length; i++){
                if (sentence[i] != '\''){
                     currentStr += sentence[i];
                
                if (currentStr == input){
                    if (i < sentence.Length - 1){
                        if (IsPunctuation(sentence[i+1])){
                             count++;
                             currentStr = "";
                        }
                    } else { //last character of sentence
                        count++;
                        currentStr = "";
                    }
                } else {
                    if (IsPunctuation(sentence[i])){
                        currentStr = "";
                    }
                }

                
                }
                //case where ' is last char
                if (i == sentence.Length - 1 && sentence[i] == '\''){
                    if (currentStr == input){
                        count++;
                    }
                }
            }
            return count;
        }

        public static bool IsPunctuation(char c){
            char[] resetChars = new char[]{' ', ',','.','?','!','.',';','(',')','&','*'};
            for(int i = 0; i < resetChars.Length; i++){
                if (resetChars[i] == c){
                    return true;
                }
            }
            return false;
        }
    }
}