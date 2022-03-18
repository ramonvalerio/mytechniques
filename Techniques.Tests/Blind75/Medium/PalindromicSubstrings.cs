namespace MyTechniques.Tests.Blind75.Medium
{
    public class PalindromicSubstrings
    {
        public int CountSubstrings(string s)
        {
            var n = s.Length;
            var count = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = i; j < n; j++)
                {

                    if (isPalindrome(s, i, j))
                        count++;
                }
            }

            return count;
        }

        private bool isPalindrome(string s, int start, int end)
        {

            while (start < end)
            {
                if (s[start] != s[end])
                    return false;

                ++start;
                --end;
            }

            return true;
        }

        //private bool isPalindrome(string s)
        //{

        //    var n = s.Length;
        //    for (var i = 0; i < n / 2; i++)
        //    {

        //        if (s[i] != s[n-1-i])
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
    }
}