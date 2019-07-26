using System;
using System.Collections.Generic;

namespace WordCounter.Models
{

    public static class Counter
    {
        public static int WordFrequency(string input, string sentence){
            
            char[] ignoreChars = new char[]{'\''};

            int count = 0;
            string currentStr = "";
            for(int i = 0; i < sentence.Length; i++){
                //special case
                if (sentence[i] != '\''){
                     currentStr += sentence[i];
                
                if (currentStr == input){
                    if (i < sentence.Length - 1){
                        if (isResetChar(sentence[i+1])){
                             count++;
                             currentStr = "";
                        }
                    } else { //last character of sentence
                        count++;
                        currentStr = "";
                    }
                } else {
                    if (isResetChar(sentence[i])){
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
    //need to check spaces
        public static bool isResetChar(char c){
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