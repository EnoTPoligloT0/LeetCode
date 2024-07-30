namespace LeetCode._383._Ransom_Note;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        List<char> list = [..magazine];
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (!list.Remove(ransomNote[i]))
            {
                return false;
            }
        }

        return true;
    }
    
}