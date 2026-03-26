// This is the famous Minimum Window Substring problem 🔥
// 👉 Given two strings s and t, find the smallest substring of s that contains all characters of t

// ✅ Optimal Approach: Sliding Window + HashMap (O(n))

string MinWindow(string s, string t)
{
    if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
        return "";

    Dictionary<char, int> map = new Dictionary<char, int>();

// Count characters of t
    foreach (char c in t)
    {
        if (!map.ContainsKey(c))
            map[c] = 0;
        map[c]++;
    }
    int left = 0, count = map.Count;
    int minLen = int.MaxValue, start = 0;

    for (int right = 0; right < s.Length; right++)
    {
        char c = s[right];

        if (map.ContainsKey(c))
        {
            map[c]--;
            if (map[c] == 0)
                count--;
        }
        
        // When all chars matched
        while (count == 0)
        {
            if (right - left + 1 < minLen)
            {
                minLen = right - left + 1;
                start = left;
            }
            
            char leftChar = s[left];

            if (map.ContainsKey(leftChar))
            {
                map[leftChar]++;
                if (map[leftChar] > 0)
                    count++;
            }

            left++;
        }
    }

    return minLen == int.MaxValue ? "" : s.Substring(start, minLen);
}

// Intuition
//Expand window until you have all required characters → then shrink to make it minimum
// Use a frequency map of t
// Expand (right) → satisfy requirement
// Shrink (left) → minimize window
// Always keep window valid but smallest