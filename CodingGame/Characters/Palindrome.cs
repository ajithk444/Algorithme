using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    /*
     A palindrome is a word that reads the same backward or forward.
    Write a function that checks if a given word is a palindrome. Character case should be ignored.
    For example, IsPalindrome("Deleveled") should return true as character case should be ignored, 
     * resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
    */
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            string str = word.ToLower();
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return str == new String(chars);
        }
    }
}
