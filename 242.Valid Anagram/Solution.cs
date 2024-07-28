namespace LeetCode._242.Valid_Anagram;

public class Solution
{
        public bool IsAnagram(string s, string t)
        {
            string sortedS = new string(s.ToLower().OrderBy(c => c).ToArray());
            string sortedT = new string(t.ToLower().OrderBy(c => c).ToArray());
            
            return sortedS == sortedT;
        }   
}