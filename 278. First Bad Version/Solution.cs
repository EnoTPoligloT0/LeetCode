namespace LeetCode._278._First_Bad_Version;

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int left = 1;
        int right = n;

        while (left<right)
        {
            int mid = left + (left + right) / 2;

            if (IsBadVersion(mid))
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
            
        }

        return left;
    }
}
