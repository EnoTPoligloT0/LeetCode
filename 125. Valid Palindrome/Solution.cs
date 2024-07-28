namespace LeetCode._125._Valid_Palindrome;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        string str = s.ToLower();

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(str[left]))
            {
                left++;
            }

            while (left < right && !char.IsLetterOrDigit(str[right]))
            {
                right--;
            }

            if (str[left] != str[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}