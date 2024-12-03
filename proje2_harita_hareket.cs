using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int row = 19;
            int column = 33;


            char[,] table = new char[19, 33];

            for (int i = 0; i < 19; i++)
                for (int j = 0; j < 33; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)                      // haritadaki + lar için
                    { table[i, j] = '+'; }
                    else if ((i == 0 || i == 18) && j % 2 != 0)        // en üst ve en alttaki satırların arasındaki çizgileri koymak için 
                    { table[i, j] = '-'; }
                    else if ((j == 0 || j == 32) && i % 2 != 0)        // yan kenarlardaki | çizgileri için 
                    { table[i, j] = '|'; }
                    else { table[i, j] = ' '; }
                }
            Random random = new Random();
            int counter = 0;
            do
            {

                int dikey = random.Next(1, 33);
                int yatay = random.Next(1, 19);

                if (dikey % 2 == 0 && yatay % 2 != 0 && table[yatay, dikey] == ' ')
                {
                    table[yatay, dikey] = '|';
                    counter++;
                }
                else if (dikey % 2 == 1 && yatay % 2 == 0 && table[yatay, dikey] == ' ')
                {
                    table[yatay, dikey] = '-';
                    counter++;
                }
            } while (counter < 90);




            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 33; j++)
                { Console.Write(table[i, j]); }           // harita yazdırma 
                Console.WriteLine();
            }

            int cursorx = 0, cursory = 0;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo hareket = Console.ReadKey(true);

                    Console.SetCursorPosition(cursorx, cursory);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("X");
                    Console.ResetColor();


                    if (hareket.Key == ConsoleKey.RightArrow && cursorx < 32)
                        cursorx++;
                    else if (hareket.Key == ConsoleKey.LeftArrow && cursorx > 0)
                        cursorx--;
                    else if (hareket.Key == ConsoleKey.UpArrow && cursory > 0)
                        cursory--;
                    else if (hareket.Key == ConsoleKey.DownArrow && cursory < 18)
                        cursory++;

                    Console.SetCursorPosition(cursorx, cursory);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("X");
                    Console.ResetColor();


                    if (hareket.Key == ConsoleKey.Spacebar)
                    {
                        if (cursorx % 2 == 0 && cursory % 2 == 1 && table[cursory, cursorx] == ' ')
                            table[cursory, cursorx] = '|';
                        else if (cursorx % 2 == 1 && cursory % 2 == 0 && table[cursory, cursorx] == ' ')
                            table[cursory, cursorx] = '-';
                    }


                    Console.Clear();
                    for (int i = 0; i < 19; i++)
                    {
                        for (int j = 0; j < 33; j++)
                        {
                            Console.SetCursorPosition(j,i);
                            Console.Write(table[i, j]);
                        }
                    }

                    Console.SetCursorPosition(cursorx, cursory);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("X");
                    Console.ResetColor();

                }

















            }











        }








            
































        
    }
}
