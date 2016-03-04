using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSHARP_Chapter_6_Extra_Credit
{
    class Program
    {
        static void Main(string[] args)
        {
            int asteriskswritecount1and4 = 1;
            int asteriskswritecount2and3 = 10;
            int spacewritecount1and3 = 14;
            int spacewritecount2 = 5;
            bool writeasterisk1 = true;
            bool writeasterisk2 = false;
            bool writeasterisk3 = false;
            bool writeasterisk4 = false;
            bool writespace1 = false;
            bool writespace2 = false;
            bool writespace3 = false;

            for (int counter = 1; counter <= 10; ++counter)
            {
                for (int writecount = 1; writecount <= 7; ++writecount)
                {
                    if (writeasterisk1 == true)
                    {
                        for (int shape1asteriskcount = 1; shape1asteriskcount <= asteriskswritecount1and4; ++shape1asteriskcount)
                        {
                            Console.Write("*");
                        }
                    }
                    if (writespace1 == true)
                    {
                        for (int shape1spacecount = 1; shape1spacecount <= spacewritecount1and3; ++shape1spacecount)
                        {
                            Console.Write(" ");
                        }
                    }
                    if (writeasterisk2 == true)
                    {
                        for (int shape2asteriskcount = 1; shape2asteriskcount <= asteriskswritecount2and3; ++shape2asteriskcount)
                        {
                            Console.Write("*");
                        }
                    }
                    if (writespace2 == true)
                    {
                        for (int shape2spacecount = 1; shape2spacecount <= spacewritecount2; ++shape2spacecount)
                        {
                            Console.Write(" ");
                        }
                    }
                    if (writeasterisk3 == true)
                    {
                        for (int shape3asteriskcount = 1; shape3asteriskcount <= asteriskswritecount2and3; ++shape3asteriskcount)
                        {
                            Console.Write("*");
                        }
                    }
                    if (writespace3 == true)
                    {
                        for (int shape3spacecount = 1; shape3spacecount <= spacewritecount1and3; ++shape3spacecount)
                        {
                            Console.Write(" ");
                        }
                    }
                    if (writeasterisk4 == true)
                    {
                        for (int shape4asteriskcount = 1; shape4asteriskcount <= asteriskswritecount1and4; ++shape4asteriskcount)
                        {
                            Console.Write("*");
                        }
                    }
                    if (writecount == 1)
                    {
                        writeasterisk1 = false;
                        writespace1 = true;
                    }
                    if (writecount == 2)
                    {
                        writespace1 = false;
                        writeasterisk2 = true;
                    }
                    if (writecount == 3)
                    {
                        writeasterisk2 = false;
                        writespace2 = true;
                    }
                    if (writecount == 4)
                    {
                        writespace2 = false;
                        writeasterisk3 = true;
                    }
                    if (writecount == 5)
                    {
                        writeasterisk3 = false;
                        writespace3 = true;
                    }
                    if (writecount == 6)
                    {
                        writespace3 = false;
                        writeasterisk4 = true;
                    }
                }
                Console.WriteLine();
                asteriskswritecount1and4 = asteriskswritecount1and4 + 1;
                asteriskswritecount2and3 = asteriskswritecount2and3 - 1;
                spacewritecount1and3 = spacewritecount1and3 - 1;
                spacewritecount2 = spacewritecount2 + 2;
                writeasterisk4 = false;
                writeasterisk1 = true;
            }

        }
    }
}
