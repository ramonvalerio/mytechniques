using System.Collections.Generic;
using System.Linq;

namespace MyTechniques.Tests.Others
{
    public  class WordCountEngine
    {
        public string[,] GetWordCountEngine(string document)
        {
            var words = document.ToLower().Split(' ');
            var map = new Dictionary<string, int>();
            var n = words.Length;

            for (int i = 0; i < n; i++)
            {
                var cleanWord = new List<char>();

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (words[i][j] < 'a' || words[i][j] > 'z')
                        continue;

                    cleanWord.Add(words[i][j]);
                }

                var newWord = string.Join("", cleanWord);

                if (newWord == "")
                    continue;

                if (!map.ContainsKey(newWord))
                    map.Add(newWord, 1);
                else
                    map[newWord] = map[newWord] + 1;
            }

            var result = new string[map.Keys.Count, 2];
            var orderedMap = map.OrderByDescending(d => d.Value).ToList();
            var index = 0;

            foreach (var x in orderedMap)
            {
                result[index, 0] = x.Key;
                result[index, 1] = x.Value.ToString();
                index++;
            }

            return result;
        }
    }
}