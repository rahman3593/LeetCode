// Given a string s, find the length of the longest 
//     substring
// without repeating characters.
//
// Example 1:
//
// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3.
// Example 2:
//
// Input: s = "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.
// Example 3:
//
// Input: s = "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3.
//     Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
//  
//
// Constraints:
//
// 0 <= s.length <= 5 * 104
// s consists of English letters, digits, symbols and spaces.

using System.Runtime.CompilerServices;

namespace LeetCode;

public class Quest3
{
    public int LengthOfLongestSubstring(string s)
    {
        var dummyString = string.Empty;
        var lstString = new List<string>();

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                if (dummyString.Contains(s[j]))
                {
                    lstString.Add(dummyString);
                    dummyString = string.Empty;
                    break;
                }

                dummyString += s[j];

                if (j == s.Length - 1)
                    lstString.Add(dummyString);
            }
        }

        return lstString.Count > 0 ? lstString.Distinct().OrderByDescending(x => x.Length).First().Length : 0;
    }
}