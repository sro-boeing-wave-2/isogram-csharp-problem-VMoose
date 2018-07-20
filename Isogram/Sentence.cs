using System;

namespace Isogram
{
    public class Sentence
    {
        public static bool IsogramSentence(string word){
            word = word.ToLower();
            char[] arr = word.ToCharArray();
            Array.Sort(arr);
            for (int i = 0; i < word.Length -1  ; i++) {
                if (arr[i] == arr[i + 1] && arr[i] != '-')
                    return false;
            }
            return true;


        }
    }
}
