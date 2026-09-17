using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpAssiginment4.leetcode
{
    internal class ValidAnagram
    {

        public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s.Length != t.Length)
                {
                    return false;
                }

                char[] sArray = s.ToArray();
                char[] tArray = t.ToArray();

                Array.Sort(sArray);
                Array.Sort(tArray);

                return sArray.SequenceEqual(tArray);
            }
        }
    }
}



//1.How the solution determines whether the two strings are anagrams

//The solution first checks if the two strings have the same length.
//Then, it converts both strings into character arrays and sorts them.
//If the sorted arrays are equal, the two strings contain the same characters
//with the same frequencies, so the solution returns true.
//Otherwise, it returns false.


//2. What happens when the strings have different lengths

//If the strings have different lengths, they cannot be anagrams.
//The solution checks their lengths first and immediately returns false
//without performing the sorting.


//3. How character frequencies can be compared

//Character frequencies mean how many times each character appears.
//In this solution, the characters are sorted first.
//After sorting, characters with the same frequency appear in the same positions.
//SequenceEqual() then compares the two sorted arrays.
//If they are equal, the character frequencies are the same.


//4. The time complexity of the solution

//The time complexity is O(n log n).
//This is because the solution sorts the characters in both strings,
//and sorting takes O(n log n) time.


//5. The space complexity of the solution

//The space complexity is O(n).
//The solution creates two character arrays to store the characters
//of the two input strings.