using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneration
{
    class BracesWordsResolver
    {
        public static IEnumerable<string> Resolve(string text, char[] separators, params (char In, char Out)[] braces)
        {
            return Resolve(text, false, separators, braces);
        }
        public static IEnumerable<string> Resolve(string text, bool splitOnBraces, char[] separators, params (char In, char Out)[] braces)
        {
            var rtnWords = new List<string>();
            StringBuilder word = new StringBuilder();
            int bracesCounter = 0;

            foreach (var ch in text)
            {
                if (separators.Contains(ch) && bracesCounter == 0)
                {
                    AddWord();
                }
                else
                {
                    if (braces.Any(x => x.In == ch))
                    {
                        if (splitOnBraces && bracesCounter == 0 )
                        {
                            AddWord();
                        }
                        bracesCounter++;
                    }
                    word.Append(ch);

                    if (braces.Any(x => x.Out == ch))
                    {
                        bracesCounter--;
                    }
                    if (splitOnBraces && bracesCounter == 0)
                    {
                        AddWord();
                    }
                }
            }
            AddWord();
            return rtnWords;

            void AddWord()
            {
                var str = word.ToString();
                if (!string.IsNullOrWhiteSpace(str))
                    rtnWords.Add(str);
                word.Clear();

            }

        }
    }
}
