using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssiginment4.leetcode
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
                return "";

            int length = GCD(str1.Length, str2.Length);

            return str1.Substring(0, length);
        }

        int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }

}



//What it means for one string to divide another

//A string divides another string if the second string can be formed by repeating the first string one or more times.


//• How repeated string patterns are detected
//str1 = "ABABAB"   str2 = "ABAB"
//str1 + str2 == str2 + str1

// ABABAB + AB = ABABABAB
//AB + ABABAB = ABABABAB

//• Why some pairs of strings have no common divisor string

//لو مفيش pattern واحد نقدر نكرره عشان نكوّن الاتنين بالكامل، يبقى مفيش common divisor.



//• How the greatest valid pattern can be found
//لو عرفنا إن فيه pattern مشترك، بنجيب GCD لأطوال الـ strings.

//• The time complexity of the solution
//O(n)

//• The space complexity of the solution
//O(1)