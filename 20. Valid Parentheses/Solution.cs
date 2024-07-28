namespace LeetCode._20._Valid_Parentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> matches = new();

        matches.Add('(', ')');
        matches.Add('{', '}');
        matches.Add('[', ']');

        Stack<char> stack = new();

        foreach (var c in s)
        {
            if (matches.ContainsKey(c))
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) return false;

                var topElement = stack.Pop();
                if (matches[topElement] != c) return false;
            }
        }

        return stack.Count == 0;
    }
}