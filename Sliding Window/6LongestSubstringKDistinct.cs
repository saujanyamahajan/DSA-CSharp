public int LongestSubstringKDistinct(string s, int k)
{
    if (string.IsNullOrEmpty(s) || k == 0)
        return 0;

    Dictionary<char, int> map = new Dictionary<char, int>();
    int left = 0, maxLength = 0;

    for (int right = 0; right < s.Length; right++)
    {
        char c = s[right];

        // add current char
        if (!map.ContainsKey(c))
            map[c] = 0;
        map[c]++;

        // shrink if more than k distinct chars
        while (map.Count > k)
        {
            char leftChar = s[left];
            map[leftChar]--;

            if (map[leftChar] == 0)
                map.Remove(leftChar);

            left++;
        }

        // update max length
        maxLength = Math.Max(maxLength, right - left + 1);
    }

    return maxLength;
}