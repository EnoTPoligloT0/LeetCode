namespace LeetCode._1._Two_Sum;

public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> matches = new();

        matches.Add("(", ")");
        matches.Add("{", "}");
        matches.Add("[", "]");

        Stack<char> stack = new();

        foreach (var c in s) stack.Push(c);
        else
        {
            if (stack.Count == 0) return false;

            var topElement = stack.Pop();
            if (matches[topElement] != c) return false;
        }
    }
    return stack.Count== 0;
}