using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEE
{



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to the DEU Letters Game!\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Objective:");
            Console.ResetColor();
            Console.WriteLine("- Your goal is to score the most points by creating specific sequences with the letters D, E, and U on a 3x3 board.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Game Setup:");
            Console.ResetColor();
            Console.WriteLine("- The game is played on a 3x3 board.");
            Console.WriteLine("- You and the computer are the players. You go first.");
            Console.WriteLine("- The board starts with random letters (D, E, or U) in random colors (red, green, or blue).\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("How to Play:");
            Console.ResetColor();
            Console.WriteLine("1. You and the computer take turns. Each turn, you can change one letter and its color on the board.");
            Console.WriteLine("2. Each change costs 10 points, so manage your score carefully.");
            Console.WriteLine("3. After each change, the board's score is recalculated based on the sequences you create.");
            Console.WriteLine("4. The game lasts for 5 rounds, and each round has 2 turns—one for you and one for the computer.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Scoring:");
            Console.ResetColor();
            Console.WriteLine("- You earn points by forming sequences of D, E, and U letters across rows, columns, or diagonals.");
            Console.WriteLine("- Points are awarded based on the type and color arrangement of the letters.");
            Console.WriteLine("- Example scoring:");
            Console.WriteLine("   - Ordered sequence (DEU or UED) of the same color: 120 points.");
            Console.WriteLine("   - Ordered sequence of different colors: 110 points.");
            Console.WriteLine("   - Other patterns earn fewer points depending on the letter and color combinations.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Winning:");
            Console.ResetColor();
            Console.WriteLine("- The game ends after 5 rounds.");
            Console.WriteLine("- The player with the highest score at the end wins!\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Good luck and have fun playing the DEU Letters Game!");
            Console.ResetColor();

            Console.WriteLine("Enter your name = ");
            string human = Console.ReadLine();

            int human_point = 20;
            int computer_current = 20;
            int computer_max = 0;
            int computer_point_total = 0;
            bool start = false;
            int randomAImoves = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("CHOOSE A GAME MODE : ");
                Console.ResetColor();
                Console.WriteLine("\n1-EASY\n2-MODERATE\n3-HARD");
                string gamemode = Console.ReadLine();

                if (gamemode == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("YOU CHOOSE EASY MODE ");
                    Console.ResetColor();
                    randomAImoves = 25;
                    start = false;
                }
                else if (gamemode == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("YOU CHOOSE MODERATE MODE");
                    Console.ResetColor();
                    randomAImoves = 50;
                    start = false;
                }
                else if (gamemode == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("YOU CHOOSE HARD MODE");
                    Console.ResetColor();
                    randomAImoves = 100;
                    start = false;
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER 1, 2, 3 !!!");
                    start = true;
                }

            }
            while (start);

            //initial boardun ilk değişkenlerini atama
            string a, b, c, d, e, f, g, h, i;
            Random random = new Random();

            int numA = random.Next(1, 4);
            int numB = random.Next(1, 4);
            int numC = random.Next(1, 4);
            int numD = random.Next(1, 4);
            int numE = random.Next(1, 4);
            int numF = random.Next(1, 4);
            int numG = random.Next(1, 4);
            int numH = random.Next(1, 4);
            int numI = random.Next(1, 4);

            a = ""; if (numA == 1) a = "D"; else if (numA == 2) a = "E"; else a = "U";
            b = ""; if (numB == 1) b = "D"; else if (numB == 2) b = "E"; else b = "U";
            c = ""; if (numC == 1) c = "D"; else if (numC == 2) c = "E"; else c = "U";
            d = ""; if (numD == 1) d = "D"; else if (numD == 2) d = "E"; else d = "U";
            e = ""; if (numE == 1) e = "D"; else if (numE == 2) e = "E"; else e = "U";
            f = ""; if (numF == 1) f = "D"; else if (numF == 2) f = "E"; else f = "U";
            g = ""; if (numG == 1) g = "D"; else if (numG == 2) g = "E"; else g = "U";
            h = ""; if (numH == 1) h = "D"; else if (numH == 2) h = "E"; else h = "U";
            i = ""; if (numI == 1) i = "D"; else if (numI == 2) i = "E"; else i = "U";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---Initial Board---");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("    1     2     3  ");
            Console.WriteLine(" |-----|-----|-----|");

            // A satırı
            Console.Write("A|  ");
            int colorA = random.Next(1, 4);
            if (colorA == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorA == 2)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(a);
            Console.ResetColor();
            Console.Write("  |  ");

            int colorB = random.Next(1, 4);
            if (colorB == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorB == 2)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(b);
            Console.ResetColor();
            Console.Write("  |  ");

            int colorC = random.Next(1, 4);
            if (colorC == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorC == 2)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(c);
            Console.ResetColor();
            Console.WriteLine("  |");
            Console.WriteLine(" |-----|-----|-----|");

            // B satırı
            Console.Write("B|  ");
            int colorD = random.Next(1, 4);
            if (colorD == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorD == 2)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(d);
            Console.ResetColor();
            Console.Write("  |  ");

            int colorE = random.Next(1, 4);
            if (colorE == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorE == 2)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(e);
            Console.ResetColor();
            Console.Write("  |  ");

            int colorF = random.Next(1, 4);
            if (colorF == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorF == 2)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(f);
            Console.ResetColor();
            Console.WriteLine("  |");
            Console.WriteLine(" |-----|-----|-----|");

            // C satırı
            Console.Write("C|  ");
            int colorG = random.Next(1, 4);
            if (colorG == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorG == 2)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(g);
            Console.ResetColor();
            Console.Write("  |  ");

            int colorH = random.Next(1, 4);
            if (colorH == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorH == 2)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(h);
            Console.ResetColor();
            Console.Write("  |  ");

            int colorI = random.Next(1, 4);
            if (colorI == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (colorI == 2)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(i);
            Console.ResetColor();
            Console.WriteLine("  |");
            Console.WriteLine(" |-----|-----|-----|");

            //puan hesaplama
            int row1 = 0;
            int row2 = 0;
            int row3 = 0;
            int col1 = 0;
            int col2 = 0;
            int col3 = 0;
            int diagonal1 = 0;
            int diagonal2 = 0;

            if (a == "D" && b == "E" && c == "U" || c == "D" && b == "E" && a == "U")
            {
                if (colorA == colorB && colorB == colorC)
                { human_point = human_point + 120; computer_current = computer_current + 120; row1 = row1 + 120; }
                else if (colorA != colorB && colorB != colorC && colorA != colorC)
                { human_point = human_point + 110; computer_current = computer_current + 110; row1 = row1 + 110; }
                else
                { human_point = human_point + 100; computer_current = computer_current + 100; row1 = row1 + 100; }

            }
            if (d == "D" && e == "E" && f == "U" || f == "D" && e == "E" && d == "U")
            {
                if (colorD == colorE && colorF == colorE)
                { human_point = human_point + 120; computer_current = computer_current + 120; row2 = row2 + 120; }
                else if (colorD != colorE && colorE != colorF && colorD != colorF)
                { human_point = human_point + 110; computer_current = computer_current + 110; row2 = row2 + 110; }
                else
                { human_point = human_point + 100; computer_current = computer_current + 100; row2 = row2 + 100; }

            }
            if (g == "D" && h == "E" && i == "U" || i == "D" && h == "E" && g == "U")
            {
                if (colorG == colorH && colorH == colorI)
                { human_point = human_point + 120; computer_current = computer_current + 120; row3 = row3 + 120; }
                else if (colorG != colorH && colorH != colorI && colorG != colorH)
                { human_point = human_point + 110; computer_current = computer_current + 110; row3 = row3 + 110; }
                else
                { human_point = human_point + 100; computer_current = computer_current + 100; row3 = row3 + 100; }

            }
            if (a == "D" && d == "E" && g == "U" || g == "D" && d == "E" && a == "U")
            {
                if (colorA == colorD && colorD == colorG)
                { human_point = human_point + 120; computer_current = computer_current + 120; col1 = col1 + 120; }
                else if (colorA != colorD && colorD != colorG && colorA != colorG)
                { human_point = human_point + 110; computer_current = computer_current + 110; col1 = col1 + 110; }
                else
                { human_point = human_point + 100; computer_current = computer_current + 100; col1 = col1 + 100; }
            }
            if (b == "D" && e == "E" && h == "U" || h == "D" && e == "E" && b == "U")
            {
                if (colorB == colorE && colorE == colorH)
                { human_point = human_point + 120; computer_current = computer_current + 120; col2 = col2 + 120; }
                else if (colorB != colorE && colorE != colorH && colorB != colorH)
                { human_point = human_point + 110; computer_current = computer_current + 110; col2 = col2 + 110; }
                else
                { human_point = human_point + 100; computer_current = computer_current + 100; col2 = col2 + 100; }
            }
            if (c == "D" && f == "E" && i == "U" || i == "D" && f == "E" && c == "U")
            {
                if (colorC == colorF && colorF == colorI)
                { human_point = human_point + 120; computer_current = computer_current + 120; col3 = col3 + 120; }
                else if (colorC != colorF && colorF != colorI && colorC != colorI)
                { human_point = human_point + 110; computer_current = computer_current + 110; col3 = col3 + 110; }
                else
                { human_point = human_point + 100; computer_current = computer_current + 100; col3 = col3 + 100; }
            }
            if (a == "D" && e == "E" && i == "U" || i == "D" && e == "E" && a == "U")
            {
                if (colorA == colorE && colorE == colorI)
                { human_point = human_point + 120; computer_current = computer_current + 120; diagonal1 = diagonal1 + 120; }
                else if (colorA != colorE && colorE != colorI && colorA != colorI)
                { human_point = human_point + 110; computer_current = computer_current + 110; diagonal1 = diagonal1 + 110; }
                else
                { human_point = human_point + 100; computer_current = computer_current + 100; diagonal1 = diagonal1 + 100; }
            }
            if (c == "D" && e == "E" && g == "U" || g == "D" && e == "E" && c == "U")
            {
                if (colorC == colorE && colorE == colorG)
                { human_point = human_point + 120; computer_current = computer_current + 120; diagonal2 = diagonal2 + 120; }
                else if (colorC != colorE && colorE != colorG && colorC != colorG)
                { human_point = human_point + 110; computer_current = computer_current + 110; diagonal2 = diagonal2 + 110; }
                else
                { human_point = human_point + 100; computer_current = computer_current + 100; diagonal2 = diagonal2 + 100; }
            }

            if (a == "D" && b == "U" && c == "E" || a == "U" && b == "D" && c == "E" || a == "E" && b == "U" && c == "D" || a == "E" && b == "D" && c == "U")
            {
                if (colorA == colorB && colorB == colorC)
                { human_point = human_point + 90; computer_current = computer_current + 90; row1 = row1 + 90; }
                else if (colorA != colorB && colorB != colorC && colorA != colorC)
                { human_point = human_point + 80; computer_current = computer_current + 80; row1 = row1 + 80; }
                else
                { human_point = human_point + 70; computer_current = computer_current + 70; row1 = row1 + 70; }
            }

            if (d == "D" && e == "U" && f == "E" || d == "U" && e == "D" && f == "E" || d == "E" && e == "U" && f == "D" || d == "E" && e == "D" && f == "U")
            {
                if (colorD == colorE && colorF == colorE)
                { human_point = human_point + 90; computer_current = computer_current + 90; row2 = row2 + 90; }
                else if (colorD != colorE && colorE != colorF && colorD != colorF)
                { human_point = human_point + 80; computer_current = computer_current + 80; row2 = row2 + 80; }
                else
                { human_point = human_point + 70; computer_current = computer_current + 70; row2 = row2 + 70; }
            }

            if (g == "D" && h == "U" && i == "E" || g == "U" && h == "D" && i == "E" || g == "E" && h == "U" && i == "D" || g == "E" && h == "D" && i == "U")
            {
                if (colorG == colorH && colorH == colorI)
                { human_point = human_point + 90; computer_current = computer_current + 90; row3 = row3 + 90; }
                else if (colorG != colorH && colorH != colorI && colorG != colorI)
                { human_point = human_point + 80; computer_current = computer_current + 80; row3 = row3 + 80; }
                else
                { human_point = human_point + 70; computer_current = computer_current + 70; row3 = row3 + 70; }
            }
            if (a == "D" && d == "U" && g == "E" || a == "U" && d == "D" && g == "E" || a == "E" && d == "U" && g == "D" || a == "E" && d == "D" && g == "U")
            {
                if (colorA == colorD && colorD == colorG)
                { human_point = human_point + 90; computer_current = computer_current + 90; col1 = col1 + 90; }
                else if (colorA != colorD && colorD != colorG && colorA != colorG)
                { human_point = human_point + 80; computer_current = computer_current + 80; col1 = col1 + 80; }
                else
                { human_point = human_point + 70; computer_current = computer_current + 70; col1 = col1 + 70; }
            }
            if (b == "D" && e == "U" && h == "E" || b == "U" && e == "D" && h == "E" || b == "E" && e == "U" && h == "D" || b == "E" && e == "D" && h == "U")
            {
                if (colorB == colorE && colorE == colorH)
                { human_point = human_point + 90; computer_current = computer_current + 90; col2 = col2 + 90; }
                else if (colorB != colorE && colorE != colorH && colorB != colorH)
                { human_point = human_point + 80; computer_current = computer_current + 80; col2 = col2 + 80; }
                else
                { human_point = human_point + 70; computer_current = computer_current + 70; col2 = col2 + 70; }
            }
            if (c == "D" && f == "U" && i == "E" || c == "U" && f == "D" && i == "E" || c == "E" && f == "U" && i == "D" || c == "E" && f == "D" && i == "U")
            {
                if (colorC == colorF && colorF == colorI)
                { human_point = human_point + 90; computer_current = computer_current + 90; col3 = col3 + 90; }
                else if (colorC != colorF && colorF != colorI && colorC != colorI)
                { human_point = human_point + 80; computer_current = computer_current + 80; col3 = col3 + 80; }
                else
                { human_point = human_point + 70; computer_current = computer_current + 70; col3 = col3 + 70; }
            }
            if (a == "D" && e == "U" && i == "E" || a == "U" && e == "D" && i == "E" || a == "E" && e == "U" && i == "D" || a == "E" && e == "D" && i == "U")
            {
                if (colorA == colorE && colorE == colorI)
                { human_point = human_point + 90; computer_current = computer_current + 90; diagonal1 = diagonal1 + 90; }
                else if (colorA != colorE && colorE != colorI && colorA != colorI)
                { human_point = human_point + 80; computer_current = computer_current + 80; diagonal1 = diagonal1 + 80; }
                else
                { human_point = human_point + 70; computer_current = computer_current + 70; diagonal1 = diagonal1 + 70; }
            }
            if (c == "D" && e == "U" && g == "E" || c == "U" && e == "D" && g == "E" || c == "E" && e == "U" && g == "D" || c == "E" && e == "D" && g == "U")
            {
                if (colorC == colorE && colorE == colorG)
                { human_point = human_point + 90; computer_current = computer_current + 90; diagonal2 = diagonal2 + 90; }
                else if (colorC != colorE && colorE != colorG && colorC != colorG)
                { human_point = human_point + 80; computer_current = computer_current + 80; diagonal2 = diagonal2 + 80; }
                else
                { human_point = human_point + 70; computer_current = computer_current + 70; diagonal2 = diagonal2 + 70; }
            }
            if (a == b && b != c || a == c && c != b || b == c && b != a)
            {
                if (colorA == colorB && colorB == colorC)
                { human_point = human_point + 30; computer_current = computer_current + 30; row1 = row1 + 30; }
                else if (colorA != colorB && colorB != colorC && colorA != colorC)
                { human_point = human_point + 20; computer_current = computer_current + 20; row1 = row1 + 20; }
                else
                { human_point = human_point + 0; computer_current = computer_current + 0; row1 = row1 + 0; }

            }
            if (d == e && e != f || d == f && f != e || e == f && f != d)
            {
                if (colorD == colorE && colorF == colorE)
                { human_point = human_point + 30; computer_current = computer_current + 30; row2 = row2 + 30; }
                else if (colorD != colorE && colorE != colorF && colorD != colorF)
                { human_point = human_point + 20; computer_current = computer_current + 20; row2 = row2 + 20; }
                else
                { human_point = human_point + 0; computer_current = computer_current + 0; row2 = row2 + 0; }

            }
            if (g == i && i != h || g == h && h != i || i == h && h != g)
            {
                if (colorG == colorH && colorH == colorI)
                { human_point = human_point + 30; computer_current = computer_current + 30; row3 = row3 + 30; }
                else if (colorG != colorH && colorH != colorI && colorG != colorI)
                { human_point = human_point + 20; computer_current = computer_current + 20; row3 = row3 + 20; }
                else
                { human_point = human_point + 0; computer_current = computer_current + 0; row3 = row3 + 0; }

            }
            if (a == d && d != g || a == g && g != d || d == g && a != g)
            {
                if (colorA == colorD && colorD == colorG)
                { human_point = human_point + 30; computer_current = computer_current + 30; col1 = col1 + 30; }
                else if (colorA != colorD && colorD != colorG && colorA != colorG)
                { human_point = human_point + 20; computer_current = computer_current + 20; col1 = col1 + 20; }
                else
                { human_point = human_point + 0; computer_current = computer_current + 0; col1 = col1 + 0; }

            }
            if (b == e && e != h || b == h && h != e || e == h && h != b)
            {
                if (colorB == colorE && colorE == colorH)
                { human_point = human_point + 30; computer_current = computer_current + 30; col2 = col2 + 30; }
                else if (colorB != colorE && colorE != colorH && colorB != colorH)
                { human_point = human_point + 20; computer_current = computer_current + 20; col2 = col2 + 20; }
                else
                    human_point = human_point + 0; computer_current = computer_current + 0; col2 = col2 + 0;

            }
            if (c == f && f != i || c == i && f != i || f == i && i != c)
            {
                if (colorC == colorF && colorF == colorI)
                { human_point = human_point + 30; computer_current = computer_current + 30; col3 = col3 + 30; }
                else if (colorC != colorF && colorF != colorI && colorC != colorI)
                { human_point = human_point + 20; computer_current = computer_current + 20; col3 = col3 + 20; }
                else
                    human_point = human_point + 0; computer_current = computer_current + 0; col3 = col3 + 0;

            }
            if (a == e && e != i || a == i && i != e || e == i && i != a)
            {
                if (colorA == colorE && colorE == colorI)
                { human_point = human_point + 30; computer_current = computer_current + 30; diagonal1 = diagonal1 + 30; }
                else if (colorA != colorE && colorE != colorI && colorA != colorI)
                { human_point = human_point + 20; computer_current = computer_current + 20; diagonal1 = diagonal1 + 20; }
                else
                    human_point = human_point + 0; computer_current = computer_current + 0; diagonal1 = diagonal1 + 0;
            }
            if (c == e && e != g || c == g && g != e || g == e && e != c)
            {
                if (colorC == colorE && colorE == colorG)
                { human_point = human_point + 30; computer_current = computer_current + 30; diagonal2 = diagonal2 + 30; }
                else if (colorC != colorE && colorE != colorG && colorC != colorG)
                { human_point = human_point + 20; computer_current = computer_current + 20; diagonal2 = diagonal2 + 20; }
                else
                    human_point = human_point + 0; computer_current = computer_current + 0; diagonal2 = diagonal2 + 0;
            }
            if (a == b && b == c)
            {
                if (colorA == colorB && colorB == colorC)
                { human_point = human_point + 60; computer_current = computer_current + 60; row1 = row1 + 60; }
                else if (colorA != colorB && colorB != colorC && colorA != colorC)
                { human_point = human_point + 50; computer_current = computer_current + 50; row1 = row1 + 50; }
                else
                { human_point = human_point + 40; computer_current = computer_current + 40; row1 = row1 + 40; }
            }
            if (d == e && e == f)
            {
                if (colorD == colorE && colorE == colorF)
                { human_point = human_point + 60; computer_current = computer_current + 60; row2 = row2 + 60; }
                else if (colorD != colorE && colorE != colorF && colorD != colorF)
                { human_point = human_point + 50; computer_current = computer_current + 50; row2 = row2 + 50; }
                else
                { human_point = human_point + 40; computer_current = computer_current + 40; row2 = row2 + 40; }
            }
            if (g == h && h == i)
            {
                if (colorG == colorH && colorH == colorI)
                { human_point = human_point + 60; computer_current = computer_current + 60; row3 = row3 + 60; }
                else if (colorG != colorH && colorH != colorI && colorG != colorI)
                { human_point = human_point + 50; computer_current = computer_current + 50; row3 = row3 + 50; }
                else
                { human_point = human_point + 40; computer_current = computer_current + 40; row3 = row3 + 40; }
            }
            if (a == e && e == i)
            {

                if (colorA == colorE && colorE == colorI)
                { human_point = human_point + 60; computer_current = computer_current + 60; diagonal1 = diagonal1 + 60; }
                else if (colorA != colorE && colorE != colorI && colorA != colorI)
                { human_point = human_point + 50; computer_current = computer_current + 50; diagonal1 = diagonal1 + 50; }
                else
                { human_point = human_point + 40; computer_current = computer_current + 40; diagonal1 = diagonal1 + 40; }
            }
            if (c == e && e == g)
            {

                if (colorC == colorE && colorE == colorG)
                { human_point = human_point + 60; computer_current = computer_current + 60; diagonal2 = diagonal2 + 60; }
                else if (colorC != colorE && colorE != colorG && colorC != colorG)
                { human_point = human_point + 50; computer_current = computer_current + 50; diagonal2 = diagonal2 + 50; }
                else
                { human_point = human_point + 40; computer_current = computer_current + 40; diagonal2 = diagonal2 + 40; }
            }
            if (a == d && d == g)
            {

                if (colorA == colorD && colorD == colorG)
                { human_point = human_point + 60; computer_current = computer_current + 60; col1 = col1 + 60; }
                else if (colorA != colorD && colorD != colorG && colorA != colorG)
                { human_point = human_point + 50; computer_current = computer_current + 50; col1 = col1 + 50; }
                else
                { human_point = human_point + 40; computer_current = computer_current + 40; col1 = col1 + 40; }
            }
            if (b == e && e == h)
            {

                if (colorB == colorE && colorE == colorH)
                { human_point = human_point + 60; computer_current = computer_current + 60; col2 = col2 + 60; }
                else if (colorB != colorE && colorE != colorH && colorB != colorH)
                { human_point = human_point + 50; computer_current = computer_current + 50; col2 = col2 + 50; }
                else
                { human_point = human_point + 40; computer_current = computer_current + 40; col2 = col2 + 40; }
            }
            if (c == f && f == i)
            {

                if (colorC == colorF && colorF == colorI)
                { human_point = human_point + 60; computer_current = computer_current + 60; col3 = col3 + 60; }
                else if (colorC != colorF && colorF != colorI && colorC != colorI)
                { human_point = human_point + 50; computer_current = computer_current + 50; col3 = col3 + 50; }
                else
                { human_point = human_point + 40; computer_current = computer_current + 40; col3 = col3 + 40; }
            }
            Console.WriteLine("Row1=" + row1 + "\nRow2=" + row2 + "\nRow3=" + row3 + "\nCol1=" + col1 + "\nCol2=" + col2 + "\nCol3=" + col3 + "\nDiagonal1=" + diagonal1 + "\nDiagonal2=" + diagonal2);
            row1 = 0;
            row2 = 0;
            row3 = 0;
            col1 = 0;
            col2 = 0;
            col3 = 0;
            diagonal1 = 0;
            diagonal2 = 0;

            Console.WriteLine(human + "'s initial point = " + human_point);
            Console.WriteLine("computers initial point = " + computer_current);
            Console.WriteLine();
            computer_point_total = computer_current;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.ResetColor();

            for (int raund = 1; raund <= 5; raund++) //raund sayısını belirleme
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---ROUND " + raund + "--- Turn = " + human);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("    1     2     3  ");
                Console.WriteLine(" |-----|-----|-----|");
                // A satırı
                Console.Write("A|  ");
                if (colorA == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorA == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(a);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorB == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorB == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(b);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorC == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorC == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(c);
                Console.ResetColor();
                Console.WriteLine("  |");
                Console.WriteLine(" |-----|-----|-----|");

                // B satırı
                Console.Write("B|  ");
                if (colorD == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorD == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(d);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorE == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorE == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(e);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorF == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorF == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(f);
                Console.ResetColor();
                Console.WriteLine("  |");
                Console.WriteLine(" |-----|-----|-----|");

                // C satırı
                Console.Write("C|  ");
                if (colorG == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorG == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(g);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorH == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorH == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(h);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorI == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorI == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i);
                Console.ResetColor();
                Console.WriteLine("  |");
                Console.WriteLine(" |-----|-----|-----|");
                human_point = human_point - 10;
                if (human_point == 0)
                { break; }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("CHOOSE a BLOCK  (A1,B2,C3,a1,b2,c3... )");
                Console.ResetColor();
                //seçim = block seçme
                //BLOCK İÇİN SEÇİM YAPTIRMAK
                string seçim;
                do
                {
                    seçim = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (seçim == "A1" || seçim == "a1") { Console.WriteLine("CHOOSE a LETTER ( enter 1,2 or 3 )"); Console.ResetColor(); break; }
                    else if (seçim == "A2" || seçim == "a2") { Console.WriteLine("CHOOSE a LETTER  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else if (seçim == "A3" || seçim == "a3") { Console.WriteLine("CHOOSE a LETTER  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else if (seçim == "B1" || seçim == "b1") { Console.WriteLine("CHOOSE a LETTER  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else if (seçim == "B2" || seçim == "b2") { Console.WriteLine("CHOOSE a LETTER  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else if (seçim == "B3" || seçim == "b3") { Console.WriteLine("CHOOSE a LETTER  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else if (seçim == "C1" || seçim == "c1") { Console.WriteLine("CHOOSE a LETTER  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else if (seçim == "C2" || seçim == "c2") { Console.WriteLine("CHOOSE a LETTER  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else if (seçim == "C3" || seçim == "c3") { Console.WriteLine("CHOOSE a LETTER  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else { Console.WriteLine(" PLEASE ENTER VALİD NUMBER   (A1,B2,C3,a1,b2,c3... )  !!!"); Console.ResetColor(); }

                } while (true);
                // seçim2 =harf seçme
                //HARFLER İÇİN SEÇİM YAPTIRMAK

                string seçim2;
                do
                {
                    Console.WriteLine("1-D");
                    Console.WriteLine("2-E");
                    Console.WriteLine("3-U");
                    seçim2 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (seçim2 == "1")
                    { Console.WriteLine("CHOOSE a COLOR  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else if (seçim2 == "2")
                    { Console.WriteLine("CHOOSE a COLOR  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else if (seçim2 == "3")
                    { Console.WriteLine("CHOOSE a COLOR  ( 1,2 or 3 )"); Console.ResetColor(); break; }
                    else
                    { Console.WriteLine("PLEASE ENTER VALİD NUMBER ( 1,2 or 3 ) !!!"); Console.ResetColor(); }

                } while (true);

                //renkleri sayı ile seçtirme
                //seçim3 = renklerin numarasını tutan int türünde değişken

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1-GREEN");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2-RED");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3-BLUE");
                Console.ResetColor();
                string seçim3;
                do
                {
                    seçim3 = Console.ReadLine();
                    if (seçim3 == "1")
                    { break; }
                    else if (seçim3 == "2")
                    { break; }
                    else if (seçim3 == "3")
                    { break; }
                    else
                    { Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("PLEASE ENTER VALİD NUMBER ( 1,2 or 3 ) !!!"); Console.ResetColor(); }
                } while (true);
                //oyuncunun seçtiği değerlerin haritadaki değişkenlere atanması
                if (seçim == "A1" || seçim == "a1")
                {
                    if (seçim3 == "1" && seçim2 == "1") { a = "D"; colorA = 1; }
                    else if (seçim3 == "2" && seçim2 == "1") { a = "D"; colorA = 2; }
                    else if (seçim3 == "3" && seçim2 == "1") { a = "D"; colorA = 3; }

                    if (seçim3 == "1" && seçim2 == "2") { a = "E"; colorA = 1; }
                    else if (seçim3 == "2" && seçim2 == "2") { a = "E"; colorA = 2; }
                    else if (seçim3 == "3" && seçim2 == "2") { a = "E"; colorA = 3; }

                    if (seçim3 == "1" && seçim2 == "3") { a = "U"; colorA = 1; }
                    else if (seçim3 == "2" && seçim2 == "3") { a = "U"; colorA = 2; }
                    else if (seçim3 == "3" && seçim2 == "3") { a = "U"; colorA = 3; }
                }
                else if (seçim == "A2" || seçim == "a2")
                {
                    if (seçim3 == "1" && seçim2 == "1") { b = "D"; colorB = 1; }
                    else if (seçim3 == "2" && seçim2 == "1") { b = "D"; colorB = 2; }
                    else if (seçim3 == "3" && seçim2 == "1") { b = "D"; colorB = 3; }

                    if (seçim3 == "1" && seçim2 == "2") { b = "E"; colorB = 1; }
                    else if (seçim3 == "2" && seçim2 == "2") { b = "E"; colorB = 2; }
                    else if (seçim3 == "3" && seçim2 == "2") { b = "E"; colorB = 3; }

                    if (seçim3 == "1" && seçim2 == "3") { b = "U"; colorB = 1; }
                    else if (seçim3 == "2" && seçim2 == "3") { b = "U"; colorB = 2; }
                    else if (seçim3 == "3" && seçim2 == "3") { b = "U"; colorB = 3; }
                }
                else if (seçim == "A3" || seçim == "a3")
                {
                    if (seçim3 == "1" && seçim2 == "1") { c = "D"; colorC = 1; }
                    else if (seçim3 == "2" && seçim2 == "1") { c = "D"; colorC = 2; }
                    else if (seçim3 == "3" && seçim2 == "1") { c = "D"; colorC = 3; }

                    if (seçim3 == "1" && seçim2 == "2") { c = "E"; colorC = 1; }
                    else if (seçim3 == "2" && seçim2 == "2") { c = "E"; colorC = 2; }
                    else if (seçim3 == "3" && seçim2 == "2") { c = "E"; colorC = 3; }

                    if (seçim3 == "1" && seçim2 == "3") { c = "U"; colorC = 1; }
                    else if (seçim3 == "2" && seçim2 == "3") { c = "U"; colorC = 2; }
                    else if (seçim3 == "3" && seçim2 == "3") { c = "U"; colorC = 3; }
                }
                else if (seçim == "B1" || seçim == "b1")
                {
                    if (seçim3 == "1" && seçim2 == "1") { d = "D"; colorD = 1; }
                    else if (seçim3 == "2" && seçim2 == "1") { d = "D"; colorD = 2; }
                    else if (seçim3 == "3" && seçim2 == "1") { d = "D"; colorD = 3; }

                    if (seçim3 == "1" && seçim2 == "2") { d = "E"; colorD = 1; }
                    else if (seçim3 == "2" && seçim2 == "2") { d = "E"; colorD = 2; }
                    else if (seçim3 == "3" && seçim2 == "2") { d = "E"; colorD = 3; }

                    if (seçim3 == "1" && seçim2 == "3") { d = "U"; colorD = 1; }
                    else if (seçim3 == "2" && seçim2 == "3") { d = "U"; colorD = 2; }
                    else if (seçim3 == "3" && seçim2 == "3") { d = "U"; colorD = 3; }
                }
                else if (seçim == "B2" || seçim == "b2")
                {
                    if (seçim3 == "1" && seçim2 == "1") { e = "D"; colorE = 1; }
                    else if (seçim3 == "2" && seçim2 == "1") { e = "D"; colorE = 2; }
                    else if (seçim3 == "3" && seçim2 == "1") { e = "D"; colorE = 3; }

                    if (seçim3 == "1" && seçim2 == "2") { e = "E"; colorE = 1; }
                    else if (seçim3 == "2" && seçim2 == "2") { e = "E"; colorE = 2; }
                    else if (seçim3 == "3" && seçim2 == "2") { e = "E"; colorE = 3; }

                    if (seçim3 == "1" && seçim2 == "3") { e = "U"; colorE = 1; }
                    else if (seçim3 == "2" && seçim2 == "3") { e = "U"; colorE = 2; }
                    else if (seçim3 == "3" && seçim2 == "3") { e = "U"; colorE = 3; }
                }
                else if (seçim == "B3" || seçim == "b3")
                {
                    if (seçim3 == "1" && seçim2 == "1") { f = "D"; colorF = 1; }
                    else if (seçim3 == "2" && seçim2 == "1") { f = "D"; colorF = 2; }
                    else if (seçim3 == "3" && seçim2 == "1") { f = "D"; colorF = 3; }

                    if (seçim3 == "1" && seçim2 == "2") { f = "E"; colorF = 1; }
                    else if (seçim3 == "2" && seçim2 == "2") { f = "E"; colorF = 2; }
                    else if (seçim3 == "3" && seçim2 == "2") { f = "E"; colorF = 3; }

                    if (seçim3 == "1" && seçim2 == "3") { f = "U"; colorF = 1; }
                    else if (seçim3 == "2" && seçim2 == "3") { f = "U"; colorF = 2; }
                    else if (seçim3 == "3" && seçim2 == "3") { f = "U"; colorF = 3; }
                }
                else if (seçim == "C1" || seçim == "c1")
                {
                    if (seçim3 == "1" && seçim2 == "1") { g = "D"; colorG = 1; }
                    else if (seçim3 == "2" && seçim2 == "1") { g = "D"; colorG = 2; }
                    else if (seçim3 == "3" && seçim2 == "1") { g = "D"; colorG = 3; }

                    if (seçim3 == "1" && seçim2 == "2") { g = "E"; colorG = 1; }
                    else if (seçim3 == "2" && seçim2 == "2") { g = "E"; colorG = 2; }
                    else if (seçim3 == "3" && seçim2 == "2") { g = "E"; colorG = 3; }

                    if (seçim3 == "1" && seçim2 == "3") { g = "U"; colorG = 1; }
                    else if (seçim3 == "2" && seçim2 == "3") { g = "U"; colorG = 2; }
                    else if (seçim3 == "3" && seçim2 == "3") { g = "U"; colorG = 3; }
                }
                else if (seçim == "C2" || seçim == "c2")
                {
                    if (seçim3 == "1" && seçim2 == "1") { h = "D"; colorH = 1; }
                    else if (seçim3 == "2" && seçim2 == "1") { h = "D"; colorH = 2; }
                    else if (seçim3 == "3" && seçim2 == "1") { h = "D"; colorH = 3; }

                    if (seçim3 == "1" && seçim2 == "2") { h = "E"; colorH = 1; }
                    else if (seçim3 == "2" && seçim2 == "2") { h = "E"; colorH = 2; }
                    else if (seçim3 == "3" && seçim2 == "2") { h = "E"; colorH = 3; }

                    if (seçim3 == "1" && seçim2 == "3") { h = "U"; colorH = 1; }
                    else if (seçim3 == "2" && seçim2 == "3") { h = "U"; colorH = 2; }
                    else if (seçim3 == "3" && seçim2 == "3") { h = "U"; colorH = 3; }
                }
                else if (seçim == "C3" || seçim == "c3")
                {
                    if (seçim3 == "1" && seçim2 == "1") { i = "D"; colorI = 1; }
                    else if (seçim3 == "2" && seçim2 == "1") { i = "D"; colorI = 2; }
                    else if (seçim3 == "3" && seçim2 == "1") { i = "D"; colorI = 3; }

                    if (seçim3 == "1" && seçim2 == "2") { i = "E"; colorI = 1; }
                    else if (seçim3 == "2" && seçim2 == "2") { i = "E"; colorI = 2; }
                    else if (seçim3 == "3" && seçim2 == "2") { i = "E"; colorI = 3; }

                    if (seçim3 == "1" && seçim2 == "3") { i = "U"; colorI = 1; }
                    else if (seçim3 == "2" && seçim2 == "3") { i = "U"; colorI = 2; }
                    else if (seçim3 == "3" && seçim2 == "3") { i = "U"; colorI = 3; }
                }
                //oyuncunun puanını hesaplama
                if (a == "D" && b == "E" && c == "U" || c == "D" && b == "E" && a == "U")
                {
                    if (colorA == colorB && colorB == colorC)
                    { human_point = human_point + 120; row1 = row1 + 120; }
                    else if (colorA != colorB && colorB != colorC && colorA != colorC)
                    { human_point = human_point + 110; row1 = row1 + 110; }
                    else
                    { human_point = human_point + 100; row1 = row1 + 100; }

                }
                if (d == "D" && e == "E" && f == "U" || f == "D" && e == "E" && d == "U")
                {
                    if (colorD == colorE && colorF == colorE)
                    { human_point = human_point + 120; row2 = row2 + 120; }
                    else if (colorD != colorE && colorE != colorF && colorD != colorF)
                    { human_point = human_point + 110; row2 = row2 + 110; }
                    else
                    { human_point = human_point + 100; row2 = row2 + 100; }

                }
                if (g == "D" && h == "E" && i == "U" || i == "D" && h == "E" && g == "U")
                {
                    if (colorG == colorH && colorH == colorI)
                    { human_point = human_point + 120; row3 = row3 + 120; }
                    else if (colorG != colorH && colorH != colorI && colorG != colorH)
                    { human_point = human_point + 110; row3 = row3 + 110; }
                    else
                    { human_point = human_point + 100; row3 = row3 + 100; }

                }
                if (a == "D" && d == "E" && g == "U" || g == "D" && d == "E" && a == "U")
                {
                    if (colorA == colorD && colorD == colorG)
                    { human_point = human_point + 120; col1 = col1 + 120; }
                    else if (colorA != colorD && colorD != colorG && colorA != colorG)
                    { human_point = human_point + 110; col1 = col1 + 110; }
                    else
                    { human_point = human_point + 100; col1 = col1 + 100; }
                }
                if (b == "D" && e == "E" && h == "U" || h == "D" && e == "E" && b == "U")
                {
                    if (colorB == colorE && colorE == colorH)
                    { human_point = human_point + 120; col2 = col2 + 120; }
                    else if (colorB != colorE && colorE != colorH && colorB != colorH)
                    { human_point = human_point + 110; col2 = col2 + 110; }
                    else
                    { human_point = human_point + 100; col2 = col2 + 100; }
                }
                if (c == "D" && f == "E" && i == "U" || i == "D" && f == "E" && c == "U")
                {
                    if (colorC == colorF && colorF == colorI)
                    { human_point = human_point + 120; col3 = col3 + 120; }
                    else if (colorC != colorF && colorF != colorI && colorC != colorI)
                    { human_point = human_point + 110; col3 = col3 + 110; }
                    else
                    { human_point = human_point + 100; col3 = col3 + 100; }
                }
                if (a == "D" && e == "E" && i == "U" || i == "D" && e == "E" && a == "U")
                {
                    if (colorA == colorE && colorE == colorI)
                    { human_point = human_point + 120; diagonal1 = diagonal1 + 120; }
                    else if (colorA != colorE && colorE != colorI && colorA != colorI)
                    { human_point = human_point + 110; diagonal1 = diagonal1 + 110; }
                    else
                    { human_point = human_point + 100; diagonal1 = diagonal1 + 100; }
                }
                if (c == "D" && e == "E" && g == "U" || g == "D" && e == "E" && c == "U")
                {
                    if (colorC == colorE && colorE == colorG)
                    { human_point = human_point + 120; diagonal2 = diagonal2 + 120; }
                    else if (colorC != colorE && colorE != colorG && colorC != colorG)
                    { human_point = human_point + 110; diagonal2 = diagonal2 + 110; }
                    else
                    { human_point = human_point + 100; diagonal2 = diagonal2 + 100; }
                }

                if (a == "D" && b == "U" && c == "E" || a == "U" && b == "D" && c == "E" || a == "E" && b == "U" && c == "D" || a == "E" && b == "D" && c == "U")
                {
                    if (colorA == colorB && colorB == colorC)
                    { human_point = human_point + 90; row1 = row1 + 90; }
                    else if (colorA != colorB && colorB != colorC && colorA != colorC)
                    { human_point = human_point + 80; row1 = row1 + 80; }
                    else
                    { human_point = human_point + 70; row1 = row1 + 70; }
                }

                if (d == "D" && e == "U" && f == "E" || d == "U" && e == "D" && f == "E" || d == "E" && e == "U" && f == "D" || d == "E" && e == "D" && f == "U")
                {
                    if (colorD == colorE && colorF == colorE)
                    { human_point = human_point + 90; row2 = row2 + 90; }
                    else if (colorD != colorE && colorE != colorF && colorD != colorF)
                    { human_point = human_point + 80; row2 = row2 + 80; }
                    else
                    { human_point = human_point + 70; row2 = row2 + 70; }
                }

                if (g == "D" && h == "U" && i == "E" || g == "U" && h == "D" && i == "E" || g == "E" && h == "U" && i == "D" || g == "E" && h == "D" && i == "U")
                {
                    if (colorG == colorH && colorH == colorI)
                    { human_point = human_point + 90; row3 = row3 + 90; }
                    else if (colorG != colorH && colorH != colorI && colorG != colorI)
                    { human_point = human_point + 80; row3 = row3 + 80; }
                    else
                    { human_point = human_point + 70; row3 = row3 + 70; }
                }
                if (a == "D" && d == "U" && g == "E" || a == "U" && d == "D" && g == "E" || a == "E" && d == "U" && g == "D" || a == "E" && d == "D" && g == "U")
                {
                    if (colorA == colorD && colorD == colorG)
                    { human_point = human_point + 90; col1 = col1 + 90; }
                    else if (colorA != colorD && colorD != colorG && colorA != colorG)
                    { human_point = human_point + 80; col1 = col1 + 80; }
                    else
                    { human_point = human_point + 70; col1 = col1 + 70; }
                }
                if (b == "D" && e == "U" && h == "E" || b == "U" && e == "D" && h == "E" || b == "E" && e == "U" && h == "D" || b == "E" && e == "D" && h == "U")
                {
                    if (colorB == colorE && colorE == colorH)
                    { human_point = human_point + 90; col2 = col2 + 90; }
                    else if (colorB != colorE && colorE != colorH && colorB != colorH)
                    { human_point = human_point + 80; col2 = col2 + 80; }
                    else
                    { human_point = human_point + 70; col2 = col2 + 70; }
                }
                if (c == "D" && f == "U" && i == "E" || c == "U" && f == "D" && i == "E" || c == "E" && f == "U" && i == "D" || c == "E" && f == "D" && i == "U")
                {
                    if (colorC == colorF && colorF == colorI)
                    { human_point = human_point + 90; col3 = col3 + 90; }
                    else if (colorC != colorF && colorF != colorI && colorC != colorI)
                    { human_point = human_point + 80; col3 = col3 + 80; }
                    else
                    { human_point = human_point + 70; col3 = col3 + 70; }
                }
                if (a == "D" && e == "U" && i == "E" || a == "U" && e == "D" && i == "E" || a == "E" && e == "U" && i == "D" || a == "E" && e == "D" && i == "U")
                {
                    if (colorA == colorE && colorE == colorI)
                    { human_point = human_point + 90; diagonal1 = diagonal1 + 90; }
                    else if (colorA != colorE && colorE != colorI && colorA != colorI)
                    { human_point = human_point + 80; diagonal1 = diagonal1 + 80; }
                    else
                    { human_point = human_point + 70; diagonal1 = diagonal1 + 70; }
                }
                if (c == "D" && e == "U" && g == "E" || c == "U" && e == "D" && g == "E" || c == "E" && e == "U" && g == "D" || c == "E" && e == "D" && g == "U")
                {
                    if (colorC == colorE && colorE == colorG)
                    { human_point = human_point + 90; diagonal2 = diagonal2 + 90; }
                    else if (colorC != colorE && colorE != colorG && colorC != colorG)
                    { human_point = human_point + 80; diagonal2 = diagonal2 + 80; }
                    else
                    { human_point = human_point + 70; diagonal2 = diagonal2 + 70; }
                }
                if (a == b && b != c || a == c && c != b || b == c && b != a)
                {
                    if (colorA == colorB && colorB == colorC)
                    { human_point = human_point + 30; row1 = row1 + 30; }
                    else if (colorA != colorB && colorB != colorC && colorA != colorC)
                    { human_point = human_point + 20; row1 = row1 + 20; }
                    else
                    { human_point = human_point + 0; row1 = row1 + 0; }

                }
                if (d == e && e != f || d == f && f != e || e == f && f != d)
                {
                    if (colorD == colorE && colorF == colorE)
                    { human_point = human_point + 30; row2 = row2 + 30; }
                    else if (colorD != colorE && colorE != colorF && colorD != colorF)
                    { human_point = human_point + 20; row2 = row2 + 20; }
                    else
                    { human_point = human_point + 0; row2 = row2 + 0; }

                }
                if (g == i && i != h || g == h && h != i || i == h && h != g)
                {
                    if (colorG == colorH && colorH == colorI)
                    { human_point = human_point + 30; row3 = row3 + 30; }
                    else if (colorG != colorH && colorH != colorI && colorG != colorI)
                    { human_point = human_point + 20; row3 = row3 + 20; }
                    else
                    { human_point = human_point + 0; row3 = row3 + 0; }

                }
                if (a == d && d != g || a == g && g != d || d == g && a != g)
                {
                    if (colorA == colorD && colorD == colorG)
                    { human_point = human_point + 30; col1 = col1 + 30; }
                    else if (colorA != colorD && colorD != colorG && colorA != colorG)
                    { human_point = human_point + 20; col1 = col1 + 20; }
                    else
                    { human_point = human_point + 0; col1 = col1 + 0; }

                }
                if (b == e && e != h || b == h && h != e || e == h && h != b)
                {
                    if (colorB == colorE && colorE == colorH)
                    { human_point = human_point + 30; col2 = col2 + 30; }
                    else if (colorB != colorE && colorE != colorH && colorB != colorH)
                    { human_point = human_point + 20; col2 = col2 + 20; }
                    else
                        human_point = human_point + 0; col2 = col2 + 0;

                }
                if (c == f && f != i || c == i && f != i || f == i && i != c)
                {
                    if (colorC == colorF && colorF == colorI)
                    { human_point = human_point + 30; col3 = col3 + 30; }
                    else if (colorC != colorF && colorF != colorI && colorC != colorI)
                    { human_point = human_point + 20; col3 = col3 + 20; }
                    else
                        human_point = human_point + 0; col3 = col3 + 0;

                }
                if (a == e && e != i || a == i && i != e || e == i && i != a)
                {
                    if (colorA == colorE && colorE == colorI)
                    { human_point = human_point + 30; diagonal1 = diagonal1 + 30; }
                    else if (colorA != colorE && colorE != colorI && colorA != colorI)
                    { human_point = human_point + 20; diagonal1 = diagonal1 + 20; }
                    else
                        human_point = human_point + 0; diagonal1 = diagonal1 + 0;
                }
                if (c == e && e != g || c == g && g != e || g == e && e != c)
                {
                    if (colorC == colorE && colorE == colorG)
                    { human_point = human_point + 30; diagonal2 = diagonal2 + 30; }
                    else if (colorC != colorE && colorE != colorG && colorC != colorG)
                    { human_point = human_point + 20; diagonal2 = diagonal2 + 20; }
                    else
                        human_point = human_point + 0; diagonal2 = diagonal2 + 0;
                }
                if (a == b && b == c)
                {
                    if (colorA == colorB && colorB == colorC)
                    { human_point = human_point + 60; row1 = row1 + 60; }
                    else if (colorA != colorB && colorB != colorC && colorA != colorC)
                    { human_point = human_point + 50; row1 = row1 + 50; }
                    else
                    { human_point = human_point + 40; row1 = row1 + 40; }
                }
                if (d == e && e == f)
                {
                    if (colorD == colorE && colorE == colorF)
                    { human_point = human_point + 60; row2 = row2 + 60; }
                    else if (colorD != colorE && colorE != colorF && colorD != colorF)
                    { human_point = human_point + 50; row2 = row2 + 50; }
                    else
                    { human_point = human_point + 40; row2 = row2 + 40; }
                }
                if (g == h && h == i)
                {
                    if (colorG == colorH && colorH == colorI)
                    { human_point = human_point + 60; row3 = row3 + 60; }
                    else if (colorG != colorH && colorH != colorI && colorG != colorI)
                    { human_point = human_point + 50; row3 = row3 + 50; }
                    else
                    { human_point = human_point + 40; row3 = row3 + 40; }
                }
                if (a == e && e == i)
                {

                    if (colorA == colorE && colorE == colorI)
                    { human_point = human_point + 60; diagonal1 = diagonal1 + 60; }
                    else if (colorA != colorE && colorE != colorI && colorA != colorI)
                    { human_point = human_point + 50; diagonal1 = diagonal1 + 50; }
                    else
                    { human_point = human_point + 40; diagonal1 = diagonal1 + 40; }
                }
                if (c == e && e == g)
                {

                    if (colorC == colorE && colorE == colorG)
                    { human_point = human_point + 60; diagonal2 = diagonal2 + 60; }
                    else if (colorC != colorE && colorE != colorG && colorC != colorG)
                    { human_point = human_point + 50; diagonal2 = diagonal2 + 50; }
                    else
                    { human_point = human_point + 40; diagonal2 = diagonal2 + 40; }
                }
                if (a == d && d == g)
                {

                    if (colorA == colorD && colorD == colorG)
                    { human_point = human_point + 60; col1 = col1 + 60; }
                    else if (colorA != colorD && colorD != colorG && colorA != colorG)
                    { human_point = human_point + 50; col1 = col1 + 50; }
                    else
                    { human_point = human_point + 40; col1 = col1 + 40; }
                }
                if (b == e && e == h)
                {

                    if (colorB == colorE && colorE == colorH)
                    { human_point = human_point + 60; col2 = col2 + 60; }
                    else if (colorB != colorE && colorE != colorH && colorB != colorH)
                    { human_point = human_point + 50; col2 = col2 + 50; }
                    else
                    { human_point = human_point + 40; col2 = col2 + 40; }
                }
                if (c == f && f == i)
                {

                    if (colorC == colorF && colorF == colorI)
                    { human_point = human_point + 60; col3 = col3 + 60; }
                    else if (colorC != colorF && colorF != colorI && colorC != colorI)
                    { human_point = human_point + 50; col3 = col3 + 50; }
                    else
                    { human_point = human_point + 40; col3 = col3 + 40; }
                }
                //boardun yeni halini yazdırma
                Console.WriteLine("    1     2     3        Row1=" + row1);
                Console.WriteLine(" |-----|-----|-----|     Row2=" + row2);
                // A satırı
                Console.Write("A|  ");
                if (colorA == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorA == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(a);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorB == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorB == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(b);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorC == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorC == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(c);
                Console.ResetColor();
                Console.WriteLine("  |     Row3=" + row3);
                Console.WriteLine(" |-----|-----|-----|     Col1=" + col1);

                // B satırı
                Console.Write("B|  ");
                if (colorD == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorD == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(d);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorE == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorE == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(e);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorF == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorF == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(f);
                Console.ResetColor();
                Console.WriteLine("  |     Col2=" + col2);
                Console.WriteLine(" |-----|-----|-----|     Col3=" + col3);

                // C satırı
                Console.Write("C|  ");
                if (colorG == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorG == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(g);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorH == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorH == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(h);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorI == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorI == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i);
                Console.ResetColor();
                Console.WriteLine("  |     Diag1=" + diagonal1);
                Console.WriteLine(" |-----|-----|-----|     Diag2=" + diagonal2);

                Console.WriteLine(human + "'s point = " + human_point);
                Console.WriteLine();
                row1 = 0;
                row2 = 0;
                row3 = 0;
                col1 = 0;
                col2 = 0;
                col3 = 0;
                diagonal1 = 0;
                diagonal2 = 0;

                for (int forsayacı = 0; forsayacı < 4; forsayacı++) //random 4 harfin değişmesi
                {
                    int değişim = random.Next(1, 10);
                    int num1 = random.Next(1, 4);
                    int num2 = random.Next(1, 4);
                    if (değişim == 1)
                    {
                        if (num1 == 1) { a = "D"; if (num2 == 1) colorA = 1; else if (num2 == 2) colorA = 2; else colorA = 3; }
                        else if (num1 == 2) { a = "E"; if (num2 == 1) colorA = 1; else if (num2 == 2) colorA = 2; else colorA = 3; }
                        else { a = "U"; if (num2 == 1) colorA = 1; else if (num2 == 2) colorA = 2; else colorA = 3; }
                    }
                    else if (değişim == 2)
                    {
                        if (num1 == 1) { b = "D"; if (num2 == 1) colorB = 1; else if (num2 == 2) colorB = 2; else colorB = 3; }
                        else if (num1 == 2) { b = "E"; if (num2 == 1) colorB = 1; else if (num2 == 2) colorB = 2; else colorB = 3; }
                        else { b = "U"; if (num2 == 1) colorB = 1; else if (num2 == 2) colorB = 2; else colorB = 3; }
                    }
                    else if (değişim == 3)
                    {
                        if (num1 == 1) { c = "D"; if (num2 == 1) colorC = 1; else if (num2 == 2) colorC = 2; else colorC = 3; }
                        else if (num1 == 2) { c = "E"; if (num2 == 1) colorC = 1; else if (num2 == 2) colorC = 2; else colorC = 3; }
                        else { c = "U"; if (num2 == 1) colorC = 1; else if (num2 == 2) colorC = 2; else colorC = 3; }
                    }
                    else if (değişim == 4)
                    {
                        if (num1 == 1) { d = "D"; if (num2 == 1) colorD = 1; else if (num2 == 2) colorD = 2; else colorD = 3; }
                        else if (num1 == 2) { c = "E"; if (num2 == 1) colorD = 1; else if (num2 == 2) colorD = 2; else colorD = 3; }
                        else { d = "U"; if (num2 == 1) colorD = 1; else if (num2 == 2) colorD = 2; else colorD = 3; }
                    }
                    else if (değişim == 5)
                    {
                        if (num1 == 1) { e = "D"; if (num2 == 1) colorE = 1; else if (num2 == 2) colorE = 2; else colorE = 3; }
                        else if (num1 == 2) { e = "E"; if (num2 == 1) colorE = 1; else if (num2 == 2) colorE = 2; else colorE = 3; }
                        else { e = "U"; if (num2 == 1) colorE = 1; else if (num2 == 2) colorE = 2; else colorE = 3; }
                    }
                    else if (değişim == 6)
                    {
                        if (num1 == 1) { f = "D"; if (num2 == 1) colorF = 1; else if (num2 == 2) colorF = 2; else colorF = 3; }
                        else if (num1 == 2) { f = "E"; if (num2 == 1) colorF = 1; else if (num2 == 2) colorF = 2; else colorF = 3; }
                        else { f = "U"; if (num2 == 1) colorF = 1; else if (num2 == 2) colorF = 2; else colorF = 3; }
                    }
                    else if (değişim == 7)
                    {
                        if (num1 == 1) { g = "D"; if (num2 == 1) colorG = 1; else if (num2 == 2) colorG = 2; else colorG = 3; }
                        else if (num1 == 2) { g = "E"; if (num2 == 1) colorG = 1; else if (num2 == 2) colorG = 2; else colorG = 3; }
                        else { g = "U"; if (num2 == 1) colorG = 1; else if (num2 == 2) colorG = 2; else colorG = 3; }
                    }
                    else if (değişim == 8)
                    {
                        if (num1 == 1) { h = "D"; if (num2 == 1) colorH = 1; else if (num2 == 2) colorH = 2; else colorH = 3; }
                        else if (num1 == 2) { h = "E"; if (num2 == 1) colorH = 1; else if (num2 == 2) colorH = 2; else colorH = 3; }
                        else { h = "U"; if (num2 == 1) colorH = 1; else if (num2 == 2) colorH = 2; else colorH = 3; }
                    }
                    else
                    {
                        if (num1 == 1) { i = "D"; if (num2 == 1) colorI = 1; else if (num2 == 2) colorI = 2; else colorI = 3; }
                        else if (num1 == 2) { i = "E"; if (num2 == 1) colorI = 1; else if (num2 == 2) colorI = 2; else colorI = 3; }
                    }

                }
                Console.WriteLine("random 4 block changed");
                Console.WriteLine("    1     2     3     ");
                Console.WriteLine(" |-----|-----|-----|  ");
                // A satırı
                Console.Write("A|  ");
                if (colorA == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorA == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(a);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorB == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorB == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(b);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorC == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorC == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(c);
                Console.ResetColor();
                Console.WriteLine("  |    ");
                Console.WriteLine(" |-----|-----|-----|   ");

                // B satırı
                Console.Write("B|  ");
                if (colorD == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorD == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(d);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorE == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorE == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(e);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorF == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorF == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(f);
                Console.ResetColor();
                Console.WriteLine("  |   ");
                Console.WriteLine(" |-----|-----|-----|   ");

                // C satırı
                Console.Write("C|  ");
                if (colorG == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorG == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(g);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorH == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorH == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(h);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorI == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorI == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i);
                Console.ResetColor();
                Console.WriteLine("  |     ");
                Console.WriteLine(" |-----|-----|-----|    ");
                //geçici olarak 0 değerini atadım, uyarı aldığım için 
                int the_best_location = 0;
                int the_best_letter = 0;
                int the_best_color = 0;

                int tur = 0;

                int row_1 = 0;
                int row_2 = 0;
                int row_3 = 0;
                int col_1 = 0;
                int col_2 = 0;
                int col_3 = 0;
                int diagonal_1 = 0;
                int diagonal_2 = 0;

                //

                int AI_Row1 = 0;
                int AI_Row2 = 0;
                int AI_Row3 = 0;
                int AI_Col1 = 0;
                int AI_Col2 = 0;
                int AI_Col3 = 0;
                int AI_Diag1 = 0;
                int AI_Diag2 = 0;
                computer_point_total = computer_point_total - 10;
                if (computer_point_total == 0)
                { break; }
                do
                { //ana değişkenin değerlerini her döngü başında tekardan yeni değişkene atamak için 
                    string k = a;
                    string l = b;
                    string m = c;
                    string n = d;
                    string o = e;
                    string p = f;
                    string q = g;
                    string r = h;
                    string s = i;
                    int colorK = colorA;
                    int colorL = colorB;
                    int colorM = colorC;
                    int colorN = colorD;
                    int colorO = colorE;
                    int colorP = colorF;
                    int colorQ = colorG;
                    int colorR = colorH;
                    int colorS = colorI;
                    // Rastgele bir blok seçme AI
                    int block_choice2 = random.Next(1, 10);
                    int letter_choice2 = random.Next(1, 4);
                    int color_choice2 = random.Next(1, 4);
                    row_1 = 0;
                    row_2 = 0;
                    row_3 = 0;
                    col_1 = 0;
                    col_2 = 0;
                    col_3 = 0;
                    diagonal_1 = 0;
                    diagonal_2 = 0;
                    computer_current = 0;

                    if (block_choice2 == 1)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { k = "D"; colorK = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { k = "D"; colorK = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { k = "D"; colorK = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { k = "E"; colorK = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { k = "E"; colorK = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { k = "E"; colorK = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { k = "U"; colorK = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { k = "U"; colorK = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { k = "U"; colorK = 3; }
                    }
                    if (block_choice2 == 2)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { l = "D"; colorL = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { l = "D"; colorL = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { l = "D"; colorL = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { l = "E"; colorL = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { l = "E"; colorL = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { l = "E"; colorL = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { l = "U"; colorL = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { l = "U"; colorL = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { l = "U"; colorL = 3; }
                    }
                    if (block_choice2 == 3)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { m = "D"; colorM = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { m = "D"; colorM = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { m = "D"; colorM = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { m = "E"; colorM = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { m = "E"; colorM = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { m = "E"; colorM = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { m = "U"; colorM = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { m = "U"; colorM = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { m = "U"; colorM = 3; }
                    }
                    if (block_choice2 == 4)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { n = "D"; colorN = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { n = "D"; colorN = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { n = "D"; colorN = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { n = "E"; colorN = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { n = "E"; colorN = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { n = "E"; colorN = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { n = "U"; colorN = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { n = "U"; colorN = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { n = "U"; colorN = 3; }
                    }
                    if (block_choice2 == 5)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { o = "D"; colorO = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { o = "D"; colorO = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { o = "D"; colorO = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { o = "E"; colorO = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { o = "E"; colorO = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { o = "E"; colorO = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { o = "U"; colorO = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { o = "U"; colorO = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { o = "U"; colorO = 3; }
                    }
                    if (block_choice2 == 6)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { p = "D"; colorP = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { p = "D"; colorP = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { p = "D"; colorP = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { p = "E"; colorP = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { p = "E"; colorP = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { p = "E"; colorP = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { p = "U"; colorP = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { p = "U"; colorP = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { p = "U"; colorP = 3; }
                    }
                    if (block_choice2 == 7)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { q = "D"; colorQ = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { q = "D"; colorQ = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { q = "D"; colorQ = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { q = "E"; colorQ = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { q = "E"; colorQ = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { q = "E"; colorQ = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { q = "U"; colorQ = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { q = "U"; colorQ = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { q = "U"; colorQ = 3; }
                    }
                    if (block_choice2 == 8)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { r = "D"; colorR = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { r = "D"; colorR = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { r = "D"; colorR = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { r = "E"; colorR = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { r = "E"; colorR = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { r = "E"; colorR = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { r = "U"; colorR = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { r = "U"; colorR = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { r = "U"; colorR = 3; }
                    }
                    else
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { s = "D"; colorS = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { s = "D"; colorS = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { s = "D"; colorS = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { s = "E"; colorS = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { s = "E"; colorS = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { s = "E"; colorS = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { s = "U"; colorS = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { s = "U"; colorS = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { s = "U"; colorS = 3; }
                    }
                    if (k == "D" && l == "E" && m == "U" || m == "D" && l == "E" && k == "U")
                    {
                        if (colorK == colorL && colorL == colorM)
                        { computer_current = computer_current + 120; row_1 = row_1 + 120; }
                        else if (colorK != colorL && colorL != colorM && colorK != colorM)
                        { computer_current = computer_current + 110; row_1 = row_1 + 110; }
                        else
                        { computer_current = computer_current + 100; row_1 = row_1 + 100; }

                    }
                    if (n == "D" && o == "E" && p == "U" || p == "D" && o == "E" && n == "U")
                    {
                        if (colorN == colorO && colorP == colorO)
                        { computer_current = computer_current + 120; row_2 = row_2 + 120; }
                        else if (colorN != colorO && colorO != colorP && colorN != colorP)
                        { computer_current = computer_current + 110; row_2 = row_2 + 110; }
                        else
                        { computer_current = computer_current + 100; row_2 = row_2 + 100; }

                    }
                    if (q == "D" && r == "E" && s == "U" || s == "D" && r == "E" && q == "U")
                    {
                        if (colorQ == colorR && colorR == colorS)
                        { computer_current = computer_current + 120; row_3 = row_3 + 120; }
                        else if (colorQ != colorR && colorR != colorS && colorQ != colorR)
                        { computer_current = computer_current + 110; row_3 = row_3 + 110; }
                        else
                        { computer_current = computer_current + 100; row_3 = row_3 + 100; }

                    }
                    if (k == "D" && n == "E" && q == "U" || q == "D" && n == "E" && k == "U")
                    {
                        if (colorK == colorN && colorN == colorQ)
                        { computer_current = computer_current + 120; col_1 = col_1 + 120; }
                        else if (colorK != colorN && colorN != colorQ && colorK != colorQ)
                        { computer_current = computer_current + 110; col_1 = col_1 + 110; }
                        else
                        { computer_current = computer_current + 100; col_1 = col_1 + 100; }
                    }
                    if (l == "D" && o == "E" && r == "U" || r == "D" && o == "E" && l == "U")
                    {
                        if (colorL == colorO && colorO == colorR)
                        { computer_current = computer_current + 120; col_2 = col_2 + 120; }
                        else if (colorL != colorO && colorO != colorR && colorL != colorR)
                        { computer_current = computer_current + 110; col_2 = col_2 + 110; }
                        else
                        { computer_current = computer_current + 100; col_2 = col_2 + 100; }
                    }
                    if (m == "D" && p == "E" && s == "U" || s == "D" && p == "E" && m == "U")
                    {
                        if (colorM == colorP && colorP == colorS)
                        { computer_current = computer_current + 120; col_3 = col_3 + 120; }
                        else if (colorM != colorP && colorP != colorS && colorM != colorS)
                        { computer_current = computer_current + 110; col_3 = col_3 + 110; }
                        else
                        { computer_current = computer_current + 100; col_3 = col_3 + 100; }
                    }
                    if (k == "D" && o == "E" && s == "U" || s == "D" && o == "E" && k == "U")
                    {
                        if (colorK == colorO && colorO == colorS)
                        { computer_current = computer_current + 120; diagonal_1 = diagonal_1 + 120; }
                        else if (colorK != colorO && colorO != colorS && colorK != colorS)
                        { computer_current = computer_current + 110; diagonal_1 = diagonal_1 + 110; }
                        else
                        { computer_current = computer_current + 100; diagonal_1 = diagonal_1 + 100; }
                    }
                    if (m == "D" && o == "E" && q == "U" || q == "D" && o == "E" && m == "U")
                    {
                        if (colorM == colorO && colorO == colorQ)
                        { computer_current = computer_current + 120; diagonal_2 = diagonal_2 + 120; }
                        else if (colorM != colorO && colorO != colorQ && colorM != colorQ)
                        { computer_current = computer_current + 110; diagonal_2 = diagonal_2 + 110; }
                        else
                        { computer_current = computer_current + 100; diagonal_2 = diagonal_2 + 100; }
                    }

                    if (k == "D" && l == "U" && m == "E" || k == "U" && l == "D" && m == "E" || k == "E" && l == "U" && m == "D" || k == "E" && l == "D" && m == "U")
                    {
                        if (colorK == colorL && colorL == colorM)
                        { computer_current = computer_current + 90; row_1 = row_1 + 90; }
                        else if (colorK != colorL && colorL != colorM && colorK != colorM)
                        { computer_current = computer_current + 80; row_1 = row_1 + 80; }
                        else
                        { computer_current = computer_current + 70; row_1 = row_1 + 70; }
                    }

                    if (n == "D" && o == "U" && p == "E" || n == "U" && o == "D" && p == "E" || n == "E" && o == "U" && p == "D" || n == "E" && o == "D" && p == "U")
                    {
                        if (colorN == colorO && colorP == colorO)
                        { computer_current = computer_current + 90; row_2 = row_2 + 90; }
                        else if (colorN != colorO && colorO != colorP && colorN != colorP)
                        { computer_current = computer_current + 80; row_2 = row_2 + 80; }
                        else
                        { computer_current = computer_current + 70; row_2 = row_2 + 70; }
                    }

                    if (q == "D" && r == "U" && s == "E" || q == "U" && r == "D" && s == "E" || q == "E" && r == "U" && s == "D" || q == "E" && r == "D" && s == "U")
                    {
                        if (colorQ == colorR && colorR == colorS)
                        { computer_current = computer_current + 90; row_3 = row_3 + 90; }
                        else if (colorQ != colorR && colorR != colorS && colorQ != colorS)
                        { computer_current = computer_current + 80; row_3 = row_3 + 80; }
                        else
                        { computer_current = computer_current + 70; row_3 = row_3 + 70; }
                    }

                    if (k == "D" && n == "U" && q == "E" || k == "U" && n == "D" && q == "E" || k == "E" && n == "U" && q == "D" || k == "E" && n == "D" && q == "U")
                    {
                        if (colorK == colorN && colorN == colorQ)
                        { computer_current = computer_current + 90; col_1 = col_1 + 90; }
                        else if (colorK != colorN && colorN != colorQ && colorK != colorQ)
                        { computer_current = computer_current + 80; col_1 = col_1 + 80; }
                        else
                        { computer_current = computer_current + 70; col_1 = col_1 + 70; }
                    }

                    if (l == "D" && o == "U" && r == "E" || l == "U" && o == "D" && r == "E" || l == "E" && o == "U" && r == "D" || l == "E" && o == "D" && r == "U")
                    {
                        if (colorL == colorO && colorO == colorR)
                        { computer_current = computer_current + 90; col_2 = col_2 + 90; }
                        else if (colorL != colorO && colorO != colorR && colorL != colorR)
                        { computer_current = computer_current + 80; col_2 = col_2 + 80; }
                        else
                        { computer_current = computer_current + 70; col_2 = col_2 + 70; }
                    }

                    if (m == "D" && p == "U" && s == "E" || m == "U" && p == "D" && s == "E" || m == "E" && p == "U" && s == "D" || m == "E" && p == "D" && s == "U")
                    {
                        if (colorM == colorP && colorP == colorS)
                        { computer_current = computer_current + 90; col_3 = col_3 + 90; }
                        else if (colorM != colorP && colorP != colorS && colorM != colorS)
                        { computer_current = computer_current + 80; col_3 = col_3 + 80; }
                        else
                        { computer_current = computer_current + 70; col_3 = col_3 + 70; }
                    }

                    if (k == "D" && o == "U" && s == "E" || k == "U" && o == "D" && s == "E" || k == "E" && o == "U" && s == "D" || k == "E" && o == "D" && s == "U")
                    {
                        if (colorK == colorO && colorO == colorS)
                        { computer_current = computer_current + 90; diagonal_1 = diagonal_1 + 90; }
                        else if (colorK != colorO && colorO != colorS && colorK != colorS)
                        { computer_current = computer_current + 80; diagonal_1 = diagonal_1 + 80; }
                        else
                        { computer_current = computer_current + 70; diagonal_1 = diagonal_1 + 70; }
                    }

                    if (m == "D" && o == "U" && q == "E" || m == "U" && o == "D" && q == "E" || m == "E" && o == "U" && q == "D" || m == "E" && o == "D" && q == "U")
                    {
                        if (colorM == colorO && colorO == colorQ)
                        { computer_current = computer_current + 90; diagonal_2 = diagonal_2 + 90; }
                        else if (colorM != colorO && colorO != colorQ && colorM != colorQ)
                        { computer_current = computer_current + 80; diagonal_2 = diagonal_2 + 80; }
                        else
                        { computer_current = computer_current + 70; diagonal_2 = diagonal_2 + 70; }
                    }

                    if (k == l && l != m || k == m && m != l || l == m && l != k)
                    {
                        if (colorK == colorL && colorL == colorM)
                        { computer_current = computer_current + 30; row_1 = row_1 + 30; }
                        else if (colorK != colorL && colorL != colorM && colorK != colorM)
                        { computer_current = computer_current + 20; row_1 = row_1 + 20; }
                        else
                        { computer_current = computer_current + 0; row_1 = row_1 + 0; }
                    }

                    if (n == o && o != p || n == p && p != o || o == p && p != n)
                    {
                        if (colorN == colorO && colorP == colorO)
                        { computer_current = computer_current + 30; row_2 = row_2 + 30; }
                        else if (colorN != colorO && colorO != colorP && colorN != colorP)
                        { computer_current = computer_current + 20; row_2 = row_2 + 20; }
                        else
                        { computer_current = computer_current + 0; row_2 = row_2 + 0; }
                    }

                    if (q == s && s != r || q == r && r != s || s == r && r != q)
                    {
                        if (colorQ == colorR && colorR == colorS)
                        { computer_current = computer_current + 30; row_3 = row_3 + 30; }
                        else if (colorQ != colorR && colorR != colorS && colorQ != colorS)
                        { computer_current = computer_current + 20; row_3 = row_3 + 20; }
                        else
                        { computer_current = computer_current + 0; row_3 = row_3 + 0; }
                    }

                    if (k == n && n != q || k == q && q != n || n == q && k != q)
                    {
                        if (colorK == colorN && colorN == colorQ)
                        { computer_current = computer_current + 30; col_1 = col_1 + 30; }
                        else if (colorK != colorN && colorN != colorQ && colorK != colorQ)
                        { computer_current = computer_current + 20; col_1 = col_1 + 20; }
                        else
                        { computer_current = computer_current + 0; col_1 = col_1 + 0; }
                    }

                    if (l == o && o != r || l == r && r != o || o == r && r != l)
                    {
                        if (colorL == colorO && colorO == colorR)
                        { computer_current = computer_current + 30; col_2 = col_2 + 30; }
                        else if (colorL != colorO && colorO != colorR && colorL != colorR)
                        { computer_current = computer_current + 20; col_2 = col_2 + 20; }
                        else
                        { computer_current = computer_current + 0; col_2 = col_2 + 0; }
                    }

                    if (m == p && p != s || m == s && p != s || p == s && s != m)
                    {
                        if (colorM == colorP && colorP == colorS)
                        { computer_current = computer_current + 30; col_3 = col_3 + 30; }
                        else if (colorM != colorP && colorP != colorS && colorM != colorS)
                        { computer_current = computer_current + 20; col_3 = col_3 + 20; }
                        else
                        { computer_current = computer_current + 0; col_3 = col_3 + 0; }
                    }

                    if (k == o && o != s || k == s && s != o || o == s && s != k)
                    {
                        if (colorK == colorO && colorO == colorS)
                        { computer_current = computer_current + 30; diagonal_1 = diagonal_1 + 30; }
                        else if (colorK != colorO && colorO != colorS && colorK != colorS)
                        { computer_current = computer_current + 20; diagonal_1 = diagonal_1 + 20; }
                        else
                        { computer_current = computer_current + 0; diagonal_1 = diagonal_1 + 0; }
                    }

                    if (m == o && o != q || m == q && q != o || q == o && o != m)
                    {
                        if (colorM == colorO && colorO == colorQ)
                        { computer_current = computer_current + 30; diagonal_2 = diagonal_2 + 30; }
                        else if (colorM != colorO && colorO != colorQ && colorM != colorQ)
                        { computer_current = computer_current + 20; diagonal_2 = diagonal_2 + 20; }
                        else
                        { computer_current = computer_current + 0; diagonal_1 = diagonal_1 + 0; }
                    }

                    if (k == l && l == m)
                    {
                        if (colorK == colorL && colorL == colorM)
                        { computer_current = computer_current + 60; row_1 = row_1 + 60; }
                        else if (colorK != colorL && colorL != colorM && colorK != colorM)
                        { computer_current = computer_current + 50; row_1 = row_1 + 50; }
                        else
                        { computer_current = computer_current + 40; row_1 = row_1 + 40; }
                    }

                    if (n == o && o == p)
                    {
                        if (colorN == colorO && colorO == colorP)
                        { computer_current = computer_current + 60; row_2 = row_2 + 60; }
                        else if (colorN != colorO && colorO != colorP && colorN != colorP)
                        { computer_current = computer_current + 50; row_2 = row_2 + 50; }
                        else
                        { computer_current = computer_current + 40; row_2 = row_2 + 40; }
                    }

                    if (q == r && r == s)
                    {
                        if (colorQ == colorR && colorR == colorS)
                        { computer_current = computer_current + 60; row_3 = row_3 + 60; }
                        else if (colorQ != colorR && colorR != colorS && colorQ != colorS)
                        { computer_current = computer_current + 50; row_3 = row_3 + 50; }
                        else
                        { computer_current = computer_current + 40; row_3 = row_3 + 40; }
                    }

                    if (k == o && o == s)
                    {
                        if (colorK == colorO && colorO == colorS)
                        { computer_current = computer_current + 60; diagonal_1 = diagonal_1 + 60; }
                        else if (colorK != colorO && colorO != colorS && colorK != colorS)
                        { computer_current = computer_current + 50; diagonal_1 = diagonal_1 + 50; }
                        else
                        { computer_current = computer_current + 40; diagonal_1 = diagonal_1 + 60; }
                    }

                    if (m == o && o == q)
                    {
                        if (colorM == colorO && colorO == colorQ)
                        { computer_current = computer_current + 60; diagonal_2 = diagonal_2 + 60; }
                        else if (colorM != colorO && colorO != colorQ && colorM != colorQ)
                        { computer_current = computer_current + 50; diagonal_2 = diagonal_2 + 50; }
                        else
                        { computer_current = computer_current + 40; diagonal_2 = diagonal_2 + 40; }
                    }

                    if (k == n && n == q)
                    {
                        if (colorK == colorN && colorN == colorQ)
                        { computer_current = computer_current + 60; col_1 = col_1 + 60; }
                        else if (colorK != colorN && colorN != colorQ && colorK != colorQ)
                        { computer_current = computer_current + 50; col_1 = col_1 + 50; }
                        else
                        { computer_current = computer_current + 40; col_1 = col_1 + 40; }
                    }

                    if (l == o && o == r)
                    {
                        if (colorL == colorO && colorO == colorR)
                        { computer_current = computer_current + 60; col_2 = col_2 + 60; }
                        else if (colorL != colorO && colorO != colorR && colorL != colorR)
                        { computer_current = computer_current + 50; col_2 = col_2 + 50; }
                        else
                        { computer_current = computer_current + 40; col_2 = col_2 + 40; }
                    }

                    if (m == p && p == s)
                    {
                        if (colorM == colorP && colorP == colorS)
                        { computer_current = computer_current + 60; col_3 = col_3 + 60; }
                        else if (colorM != colorP && colorP != colorS && colorM != colorS)
                        { computer_current = computer_current + 50; col_3 = col_3 + 50; }
                        else
                        { computer_current = computer_current + 40; col_3 = col_3 + 40; }
                    }

                    //eğer yeni hesapladığı puan eski puandan büyükse yeni puanı loopun dışına çıkaracağımız değişkene atama yapar
                    if (computer_current >= computer_max)
                    {
                        computer_max = computer_current;
                        //block ,harf ve renk değişkenlerini tutmak için 
                        the_best_location = block_choice2;
                        the_best_letter = letter_choice2;
                        the_best_color = color_choice2;
                        AI_Row1 = row_1;
                        AI_Row2 = row_2;
                        AI_Row3 = row_3;
                        AI_Col1 = col_1;
                        AI_Col2 = col_2;
                        AI_Col3 = col_3;
                        AI_Diag1 = diagonal_1;
                        AI_Diag2 = diagonal_2;
                    }


                    tur = tur + 1;
                } while (tur < randomAImoves);
                computer_point_total = computer_point_total + computer_max;
                computer_max = 0;

                //en iyi değerleri haritaya yazabileceğimiz türe dönüştürmek için
                if (the_best_location == 1)
                {
                    if (the_best_color == 1 && the_best_letter == 1) { a = "D"; colorA = 1; }
                    else if (the_best_color == 2 && the_best_letter == 1) { a = "D"; colorA = 2; }
                    else if (the_best_color == 3 && the_best_letter == 1) { a = "D"; colorA = 3; }

                    else if (the_best_color == 1 && the_best_letter == 2) { a = "E"; colorA = 1; }
                    else if (the_best_color == 2 && the_best_letter == 2) { a = "E"; colorA = 2; }
                    else if (the_best_color == 3 && the_best_letter == 2) { a = "E"; colorA = 3; }

                    else if (the_best_color == 1 && the_best_letter == 3) { a = "U"; colorA = 1; }
                    else if (the_best_color == 2 && the_best_letter == 3) { a = "U"; colorA = 2; }
                    else if (the_best_color == 3 && the_best_letter == 3) { a = "U"; colorA = 3; }
                }
                if (the_best_location == 2)
                {
                    if (the_best_color == 1 && the_best_letter == 1) { b = "D"; colorB = 1; }
                    else if (the_best_color == 2 && the_best_letter == 1) { b = "D"; colorB = 2; }
                    else if (the_best_color == 3 && the_best_letter == 1) { b = "D"; colorB = 3; }

                    else if (the_best_color == 1 && the_best_letter == 2) { b = "E"; colorB = 1; }
                    else if (the_best_color == 2 && the_best_letter == 2) { b = "E"; colorB = 2; }
                    else if (the_best_color == 3 && the_best_letter == 2) { b = "E"; colorB = 3; }

                    else if (the_best_color == 1 && the_best_letter == 3) { b = "U"; colorB = 1; }
                    else if (the_best_color == 2 && the_best_letter == 3) { b = "U"; colorB = 2; }
                    else if (the_best_color == 3 && the_best_letter == 3) { b = "U"; colorB = 3; }
                }
                if (the_best_location == 3)
                {
                    if (the_best_color == 1 && the_best_letter == 1) { c = "D"; colorC = 1; }
                    else if (the_best_color == 2 && the_best_letter == 1) { c = "D"; colorC = 2; }
                    else if (the_best_color == 3 && the_best_letter == 1) { c = "D"; colorC = 3; }

                    else if (the_best_color == 1 && the_best_letter == 2) { c = "E"; colorC = 1; }
                    else if (the_best_color == 2 && the_best_letter == 2) { c = "E"; colorC = 2; }
                    else if (the_best_color == 3 && the_best_letter == 2) { c = "E"; colorC = 3; }

                    else if (the_best_color == 1 && the_best_letter == 3) { c = "U"; colorC = 1; }
                    else if (the_best_color == 2 && the_best_letter == 3) { c = "U"; colorC = 2; }
                    else if (the_best_color == 3 && the_best_letter == 3) { c = "U"; colorC = 3; }
                }
                if (the_best_location == 4)
                {
                    if (the_best_color == 1 && the_best_letter == 1) { d = "D"; colorD = 1; }
                    else if (the_best_color == 2 && the_best_letter == 1) { d = "D"; colorD = 2; }
                    else if (the_best_color == 3 && the_best_letter == 1) { d = "D"; colorD = 3; }

                    else if (the_best_color == 1 && the_best_letter == 2) { d = "E"; colorD = 1; }
                    else if (the_best_color == 2 && the_best_letter == 2) { d = "E"; colorD = 2; }
                    else if (the_best_color == 3 && the_best_letter == 2) { d = "E"; colorD = 3; }

                    else if (the_best_color == 1 && the_best_letter == 3) { d = "U"; colorD = 1; }
                    else if (the_best_color == 2 && the_best_letter == 3) { d = "U"; colorD = 2; }
                    else if (the_best_color == 3 && the_best_letter == 3) { d = "U"; colorD = 3; }
                }
                if (the_best_location == 5)
                {
                    if (the_best_color == 1 && the_best_letter == 1) { e = "D"; colorE = 1; }
                    else if (the_best_color == 2 && the_best_letter == 1) { e = "D"; colorE = 2; }
                    else if (the_best_color == 3 && the_best_letter == 1) { e = "D"; colorE = 3; }

                    else if (the_best_color == 1 && the_best_letter == 2) { e = "E"; colorE = 1; }
                    else if (the_best_color == 2 && the_best_letter == 2) { e = "E"; colorE = 2; }
                    else if (the_best_color == 3 && the_best_letter == 2) { e = "E"; colorE = 3; }

                    else if (the_best_color == 1 && the_best_letter == 3) { e = "U"; colorE = 1; }
                    else if (the_best_color == 2 && the_best_letter == 3) { e = "U"; colorE = 2; }
                    else if (the_best_color == 3 && the_best_letter == 3) { e = "U"; colorE = 3; }
                }
                if (the_best_location == 6)
                {
                    if (the_best_color == 1 && the_best_letter == 1) { f = "D"; colorF = 1; }
                    else if (the_best_color == 2 && the_best_letter == 1) { f = "D"; colorF = 2; }
                    else if (the_best_color == 3 && the_best_letter == 1) { f = "D"; colorF = 3; }

                    else if (the_best_color == 1 && the_best_letter == 2) { f = "E"; colorF = 1; }
                    else if (the_best_color == 2 && the_best_letter == 2) { f = "E"; colorF = 2; }
                    else if (the_best_color == 3 && the_best_letter == 2) { f = "E"; colorF = 3; }

                    else if (the_best_color == 1 && the_best_letter == 3) { f = "U"; colorF = 1; }
                    else if (the_best_color == 2 && the_best_letter == 3) { f = "U"; colorF = 2; }
                    else if (the_best_color == 3 && the_best_letter == 3) { f = "U"; colorF = 3; }
                }
                if (the_best_location == 7)
                {
                    if (the_best_color == 1 && the_best_letter == 1) { g = "D"; colorG = 1; }
                    else if (the_best_color == 2 && the_best_letter == 1) { g = "D"; colorG = 2; }
                    else if (the_best_color == 3 && the_best_letter == 1) { g = "D"; colorG = 3; }

                    else if (the_best_color == 1 && the_best_letter == 2) { g = "E"; colorG = 1; }
                    else if (the_best_color == 2 && the_best_letter == 2) { g = "E"; colorG = 2; }
                    else if (the_best_color == 3 && the_best_letter == 2) { g = "E"; colorG = 3; }

                    else if (the_best_color == 1 && the_best_letter == 3) { g = "U"; colorG = 1; }
                    else if (the_best_color == 2 && the_best_letter == 3) { g = "U"; colorG = 2; }
                    else if (the_best_color == 3 && the_best_letter == 3) { g = "U"; colorG = 3; }
                }
                if (the_best_location == 8)
                {
                    if (the_best_color == 1 && the_best_letter == 1) { h = "D"; colorH = 1; }
                    else if (the_best_color == 2 && the_best_letter == 1) { h = "D"; colorH = 2; }
                    else if (the_best_color == 3 && the_best_letter == 1) { h = "D"; colorH = 3; }

                    else if (the_best_color == 1 && the_best_letter == 2) { h = "E"; colorH = 1; }
                    else if (the_best_color == 2 && the_best_letter == 2) { h = "E"; colorH = 2; }
                    else if (the_best_color == 3 && the_best_letter == 2) { h = "E"; colorH = 3; }

                    else if (the_best_color == 1 && the_best_letter == 3) { h = "U"; colorH = 1; }
                    else if (the_best_color == 2 && the_best_letter == 3) { h = "U"; colorH = 2; }
                    else if (the_best_color == 3 && the_best_letter == 3) { h = "U"; colorH = 3; }
                }
                else
                {
                    if (the_best_color == 1 && the_best_letter == 1) { i = "D"; colorI = 1; }
                    else if (the_best_color == 2 && the_best_letter == 1) { i = "D"; colorI = 2; }
                    else if (the_best_color == 3 && the_best_letter == 1) { i = "D"; colorI = 3; }

                    else if (the_best_color == 1 && the_best_letter == 2) { i = "E"; colorI = 1; }
                    else if (the_best_color == 2 && the_best_letter == 2) { i = "E"; colorI = 2; }
                    else if (the_best_color == 3 && the_best_letter == 2) { i = "E"; colorI = 3; }

                    else if (the_best_color == 1 && the_best_letter == 3) { i = "U"; colorI = 1; }
                    else if (the_best_color == 2 && the_best_letter == 3) { i = "U"; colorI = 2; }
                    else if (the_best_color == 3 && the_best_letter == 3) { i = "U"; colorI = 3; }
                }
                //yapay zeka hamlesi sonrası haritanın yazdırılması
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---ROUND " + raund + "--- Turn = Computer");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("    1     2     3        Row1=" + AI_Row1);
                Console.WriteLine(" |-----|-----|-----|     Row2=" + AI_Row2);
                // A satırı
                Console.Write("A|  ");
                if (colorA == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorA == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(a);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorB == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorB == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(b);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorC == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorC == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(c);
                Console.ResetColor();
                Console.WriteLine("  |     Row3=" + AI_Row3);
                Console.WriteLine(" |-----|-----|-----|     Col1=" + AI_Col1);

                // B satırı
                Console.Write("B|  ");
                if (colorD == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorD == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(d);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorE == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorE == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(e);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorF == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorF == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(f);
                Console.ResetColor();
                Console.WriteLine("  |     Col2=" + AI_Col2);
                Console.WriteLine(" |-----|-----|-----|     Col3=" + AI_Col3);

                // C satırı
                Console.Write("C|  ");
                if (colorG == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorG == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(g);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorH == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorH == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(h);
                Console.ResetColor();
                Console.Write("  |  ");

                if (colorI == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (colorI == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i);
                Console.ResetColor();
                Console.WriteLine("  |     Diag1=" + AI_Diag1);
                Console.WriteLine(" |-----|-----|-----|     Diag2=" + AI_Diag2);
                Console.WriteLine("Computer's point = " + computer_point_total);
                Console.WriteLine();
                //hangi satırdan kaç puan alığı değerleri tekrardan sıfırlıyoruz.
                AI_Row1 = 0;
                AI_Row2 = 0;
                AI_Row3 = 0;
                AI_Col1 = 0;
                AI_Col2 = 0;
                AI_Col3 = 0;
                AI_Diag1 = 0;
                AI_Diag2 = 0;
                // random 4 blocktaki değerlerin değişmesi
                for (int forsayacı2 = 0; forsayacı2 < 4; forsayacı2++)
                {
                    int değişim = random.Next(1, 10);
                    int num1 = random.Next(1, 4);
                    int num2 = random.Next(1, 4);
                    if (değişim == 1)
                    {
                        if (num1 == 1) { a = "D"; if (num2 == 1) colorA = 1; else if (num2 == 2) colorA = 2; else colorA = 3; }
                        else if (num1 == 2) { a = "E"; if (num2 == 1) colorA = 1; else if (num2 == 2) colorA = 2; else colorA = 3; }
                        else { a = "U"; if (num2 == 1) colorA = 1; else if (num2 == 2) colorA = 2; else colorA = 3; }
                    }
                    else if (değişim == 2)
                    {
                        if (num1 == 1) { b = "D"; if (num2 == 1) colorB = 1; else if (num2 == 2) colorB = 2; else colorB = 3; }
                        else if (num1 == 2) { b = "E"; if (num2 == 1) colorB = 1; else if (num2 == 2) colorB = 2; else colorB = 3; }
                        else { b = "U"; if (num2 == 1) colorB = 1; else if (num2 == 2) colorB = 2; else colorB = 3; }
                    }
                    else if (değişim == 3)
                    {
                        if (num1 == 1) { c = "D"; if (num2 == 1) colorC = 1; else if (num2 == 2) colorC = 2; else colorC = 3; }
                        else if (num1 == 2) { c = "E"; if (num2 == 1) colorC = 1; else if (num2 == 2) colorC = 2; else colorC = 3; }
                        else { c = "U"; if (num2 == 1) colorC = 1; else if (num2 == 2) colorC = 2; else colorC = 3; }
                    }
                    else if (değişim == 4)
                    {
                        if (num1 == 1) { d = "D"; if (num2 == 1) colorD = 1; else if (num2 == 2) colorD = 2; else colorD = 3; }
                        else if (num1 == 2) { c = "E"; if (num2 == 1) colorD = 1; else if (num2 == 2) colorD = 2; else colorD = 3; }
                        else { d = "U"; if (num2 == 1) colorD = 1; else if (num2 == 2) colorD = 2; else colorD = 3; }
                    }
                    else if (değişim == 5)
                    {
                        if (num1 == 1) { e = "D"; if (num2 == 1) colorE = 1; else if (num2 == 2) colorE = 2; else colorE = 3; }
                        else if (num1 == 2) { e = "E"; if (num2 == 1) colorE = 1; else if (num2 == 2) colorE = 2; else colorE = 3; }
                        else { e = "U"; if (num2 == 1) colorE = 1; else if (num2 == 2) colorE = 2; else colorE = 3; }
                    }
                    else if (değişim == 6)
                    {
                        if (num1 == 1) { f = "D"; if (num2 == 1) colorF = 1; else if (num2 == 2) colorF = 2; else colorF = 3; }
                        else if (num1 == 2) { f = "E"; if (num2 == 1) colorF = 1; else if (num2 == 2) colorF = 2; else colorF = 3; }
                        else { f = "U"; if (num2 == 1) colorF = 1; else if (num2 == 2) colorF = 2; else colorF = 3; }
                    }
                    else if (değişim == 7)
                    {
                        if (num1 == 1) { g = "D"; if (num2 == 1) colorG = 1; else if (num2 == 2) colorG = 2; else colorG = 3; }
                        else if (num1 == 2) { g = "E"; if (num2 == 1) colorG = 1; else if (num2 == 2) colorG = 2; else colorG = 3; }
                        else { g = "U"; if (num2 == 1) colorG = 1; else if (num2 == 2) colorG = 2; else colorG = 3; }
                    }
                    else if (değişim == 8)
                    {
                        if (num1 == 1) { h = "D"; if (num2 == 1) colorH = 1; else if (num2 == 2) colorH = 2; else colorH = 3; }
                        else if (num1 == 2) { h = "E"; if (num2 == 1) colorH = 1; else if (num2 == 2) colorH = 2; else colorH = 3; }
                        else { h = "U"; if (num2 == 1) colorH = 1; else if (num2 == 2) colorH = 2; else colorH = 3; }
                    }
                    else
                    {
                        if (num1 == 1) { i = "D"; if (num2 == 1) colorI = 1; else if (num2 == 2) colorI = 2; else colorI = 3; }
                        else if (num1 == 2) { i = "E"; if (num2 == 1) colorI = 1; else if (num2 == 2) colorI = 2; else colorI = 3; }
                    }

                }


            }
            Console.ForegroundColor = ConsoleColor.Red;
            if (computer_point_total > human_point)
            {
                Console.WriteLine("COMPUTER AI WON THE GAME with " + computer_point_total + " point");
                Console.ReadLine();
            }
            else if (computer_point_total < human_point)
            {
                Console.WriteLine(human + " WON THE GAME with " + human_point + " point");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("COMPUTER AI and" + human + "'s POINT ARE EQUAL with " + human_point + "point");
                Console.ReadLine();
            }




        }
    }
}





