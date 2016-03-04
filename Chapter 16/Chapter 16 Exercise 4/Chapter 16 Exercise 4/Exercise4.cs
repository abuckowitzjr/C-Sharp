using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_16_Exercise_4
{
    class Exercise4
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] articleArray = { "the", "a", "one", "some", "any" };
            string[] nounArray = { "boy", "girl", "dog", "town", "car" };
            string[] verbArray = { "drove", "jumped", "ran", "walked", "skipped" };
            string[] prepositionArray = { "to", "from", "over", "under", "on" };

            int articleIndex = rnd.Next(articleArray.Length);
            int nounIndex = rnd.Next(nounArray.Length);
            int verbIndex = rnd.Next(verbArray.Length);
            int prepositionIndex = rnd.Next(prepositionArray.Length);
            int articleIndex2 = rnd.Next(articleArray.Length);
            int nounIndex2 = rnd.Next(nounArray.Length);

            for (int i = 0; i <= 10; i++)
            {
                if (i == 0)
                    Console.WriteLine("{0} {1} {2} {3} {4} {5}{6}", articleArray[articleIndex], nounArray[nounIndex],
                        verbArray[verbIndex], prepositionArray[prepositionIndex], articleArray[articleIndex2],
                        nounArray[nounIndex2], ". ");
                else
                    articleIndex = rnd.Next(articleArray.Length);
                    nounIndex = rnd.Next(nounArray.Length);
                    verbIndex = rnd.Next(verbArray.Length);
                    prepositionIndex = rnd.Next(prepositionArray.Length);
                    articleIndex2 = rnd.Next(articleArray.Length);
                    nounIndex2 = rnd.Next(nounArray.Length);
                    Console.WriteLine("{0} {1} {2} {3} {4} {5}{6}", articleArray[articleIndex], nounArray[nounIndex],
                        verbArray[verbIndex], prepositionArray[prepositionIndex], articleArray[articleIndex2],
                        nounArray[nounIndex2], ". ");
            }
        }
    }
}
