using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_6_Exercise_6._23
{
    class Program
    {
        static void Main(string[] args)
        {
            int spacewritecount = 4;
            int asteriskwritecount = 1;
            bool writeasterisk = false;
            for (int row = 1; row <= 4; ++row)
            {
                    for (int spacecount = 1; spacecount <= spacewritecount; ++spacecount)
                    {
                        Console.Write(" ");
                    }
                    writeasterisk = true;
                    if (writeasterisk == true)
                    {
                        for (int asteriskcount = 1; asteriskcount <= asteriskwritecount; ++asteriskcount)
                        {
                            Console.Write("*");
                        }
                    }
                    writeasterisk = false;
                Console.WriteLine();
                spacewritecount = spacewritecount - 1;
                asteriskwritecount = asteriskwritecount + 2;
            }
            for (int counter = 1; counter <= 9; ++counter)
            {
                if (counter < 9)
                    Console.Write("*");
                if (counter == 9)
                    Console.WriteLine("*");
            }
            spacewritecount = 1;
            asteriskwritecount = 7;
            for (int row = 1; row <= 4; ++row)
            {
                    for (int spacecount = 1; spacecount <= spacewritecount; ++spacecount)
                    {
                        Console.Write(" ");
                    }
                    writeasterisk = true;
                    if (writeasterisk == true)
                    {
                        for (int asteriskcount = 1; asteriskcount <= asteriskwritecount; ++asteriskcount)
                        {
                            Console.Write("*");
                        }
                    }
                    writeasterisk = false;
                Console.WriteLine();
                spacewritecount = spacewritecount + 1;
                asteriskwritecount = asteriskwritecount - 2;
            }
        }
    }
}

