public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
            return false;

        char[] first = s.ToCharArray();
        char[] second = t.ToCharArray();

        Array.Sort(first);
        Array.Sort(second);

        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i])
                return false;
        }

        return true;
    }
}
