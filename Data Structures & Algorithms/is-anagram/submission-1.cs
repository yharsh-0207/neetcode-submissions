public class Solution {
    public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dictOfs = new Dictionary<char, int>();
            foreach (var item in s.ToLower())
            {
                if(dictOfs.TryGetValue(item, out int value))
                {
                    dictOfs[item] += 1;
                }
                else
                {
                    dictOfs[item] = value;
                }
            }

            Dictionary<char, int> dictOft = new Dictionary<char, int>();
            foreach (var item in t.ToLower())
            {
                if (dictOft.TryGetValue(item, out int value))
                {
                    dictOft[item] += 1;
                }
                else
                {
                    dictOft[item] = value;
                }
            }
            if(dictOfs.Count != dictOft.Count)
            {
                return false;
            }

            foreach (var item in dictOfs)
            {
                if(dictOft.TryGetValue(item.Key, out int valueOft))
                {
                    if(valueOft != item.Value)
                    {
                        return false;
                    }
                }
                else{
                    return false;
                }
            }
            return true;
        }
}
