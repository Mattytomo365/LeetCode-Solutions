public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        int left = 0;
        int maxLength = 0;
        HashSet<string> seen = new HashSet<string>(); // Sliding window

        for(int i = 0; i <= s.Length - 1; i++)
        {
            while(seen.Contains(s[i].ToString()))
            {
                seen.Remove(s[left].ToString());
                left++;
            }
            seen.Add(s[i].ToString());
            maxLength = Math.Max(maxLength, i - left + 1); // Only updates variable if it is bigger
        }

        return maxLength;
    }
}