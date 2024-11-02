using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easy = 25;
            int moderate = 50;
            int hard = 100;
            int zorluk;
            int human_point = 20;
            int computer_current = 0;
            int computer_max = 0;
            int computer_point_total = 0;
            do
            {
                Console.WriteLine("\nCHOOSE A GAME MODE \n1-EASY\n2-MODERATE\n3-HARD");
                string gamemode = Console.ReadLine();

                if (gamemode == "1")
                {
                    Console.WriteLine("YOU CHOOSE EASY MODE ");
                    zorluk = easy;
                    break;
                }
                else if (gamemode == "2")
                {
                    Console.WriteLine("YOU CHOOSE MODERATE MODE");
                    zorluk = moderate;
                    break;
                }
                else if (gamemode == "3")
                {
                    Console.WriteLine("YOU CHOOSE HARD MODE");
                    zorluk = hard;
                    break;
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER 1, 2, 3 !!!");
                }

            }
            while (true);


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
            
            for (int raund=0; raund<5; raund++)
            { 
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
                Console.WriteLine("CHOOSE a BLOCK   ");
                //seçim = block seçme
                //BLOCK İÇİN SEÇİM YAPTIRMAK
                string seçim;
                do
                {
                    seçim = Console.ReadLine();
                    if (seçim == "A1") { Console.WriteLine("CHOOSE a LETTER"); break; }
                    else if (seçim == "A2") { Console.WriteLine("CHOOSE a LETTER"); break; }
                    else if (seçim == "A3") { Console.WriteLine("CHOOSE a LETTER"); break; }
                    else if (seçim == "B1") { Console.WriteLine("CHOOSE a LETTER"); break; }
                    else if (seçim == "B2") { Console.WriteLine("CHOOSE a LETTER"); break; }
                    else if (seçim == "B3") { Console.WriteLine("CHOOSE a LETTER"); break; }
                    else if (seçim == "C1") { Console.WriteLine("CHOOSE a LETTER"); break; }
                    else if (seçim == "C2") { Console.WriteLine("CHOOSE a LETTER"); break; }
                    else if (seçim == "C3") { Console.WriteLine("CHOOSE a LETTER"); break; }
                    else { Console.WriteLine("GEÇERLİ BİR DEĞER GİRİNİZ !!!"); }

                } while (true);
                // seçim2 =harf seçme
                //HARFLER İÇİN SEÇİM YAPTIRMAK
                Console.WriteLine("\n1-D\n2-E\n3-U");
                int seçim2;
                do
                {
                    seçim2 = Convert.ToInt32(Console.ReadLine());
                    if (seçim2 == 1)
                    { Console.WriteLine("CHOOSE a COLOR"); break; }
                    else if (seçim2 == 2)
                    { Console.WriteLine("CHOOSE a COLOR"); break; }
                    else if (seçim2 == 3)
                    { Console.WriteLine("CHOOSE a COLOR"); break; }
                    else
                    { Console.WriteLine("GEÇERLİ BİR DEĞER GİRİNİZ !!!"); }

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
                int seçim3;
                do
                {
                    seçim3 = Convert.ToInt32(Console.ReadLine());
                    if (seçim3 == 1)
                    { break; }
                    else if (seçim3 == 2)
                    { break; }
                    else if (seçim3 == 3)
                    { break; }
                    else
                    { Console.WriteLine("GEÇERLİ BİR DEĞER GİRİNİZ !!!"); }
                } while (true);
                if (seçim == "A1")
                {
                    if (seçim3 == 1 && seçim2 == 1) { a = "D"; colorA = 1; }
                    else if (seçim3 == 2 && seçim2 == 1) { a = "D"; colorA = 2; }
                    else if (seçim3 == 3 && seçim2 == 1) { a = "D"; colorA = 3; }

                    if (seçim3 == 1 && seçim2 == 2) { a = "E"; colorA = 1; }
                    else if (seçim3 == 2 && seçim2 == 2) { a = "E"; colorA = 2; }
                    else if (seçim3 == 3 && seçim2 == 2) { a = "E"; colorA = 3; }

                    if (seçim3 == 1 && seçim2 == 3) { a = "U"; colorA = 1; }
                    else if (seçim3 == 2 && seçim2 == 3) { a = "U"; colorA = 2; }
                    else if (seçim3 == 3 && seçim2 == 3) { a = "U"; colorA = 3; }
                }
                else if (seçim == "A2")
                {
                    if (seçim3 == 1 && seçim2 == 1) { b = "D"; colorB = 1; }
                    else if (seçim3 == 2 && seçim2 == 1) { b = "D"; colorB = 2; }
                    else if (seçim3 == 3 && seçim2 == 1) { b = "D"; colorB = 3; }

                    if (seçim3 == 1 && seçim2 == 2) { b = "E"; colorB = 1; }
                    else if (seçim3 == 2 && seçim2 == 2) { b = "E"; colorB = 2; }
                    else if (seçim3 == 3 && seçim2 == 2) { b = "E"; colorB = 3; }

                    if (seçim3 == 1 && seçim2 == 3) { b = "U"; colorB = 1; }
                    else if (seçim3 == 2 && seçim2 == 3) { b = "U"; colorB = 2; }
                    else if (seçim3 == 3 && seçim2 == 3) { b = "U"; colorB = 3; }
                }
                else if (seçim == "A3")
                {
                    if (seçim3 == 1 && seçim2 == 1) { c = "D"; colorC = 1; }
                    else if (seçim3 == 2 && seçim2 == 1) { c = "D"; colorC = 2; }
                    else if (seçim3 == 3 && seçim2 == 1) { c = "D"; colorC = 3; }

                    if (seçim3 == 1 && seçim2 == 2) { c = "E"; colorC = 1; }
                    else if (seçim3 == 2 && seçim2 == 2) { c = "E"; colorC = 2; }
                    else if (seçim3 == 3 && seçim2 == 2) { c = "E"; colorC = 3; }

                    if (seçim3 == 1 && seçim2 == 3) { c = "U"; colorC = 1; }
                    else if (seçim3 == 2 && seçim2 == 3) { c = "U"; colorC = 2; }
                    else if (seçim3 == 3 && seçim2 == 3) { c = "U"; colorC = 3; }
                }
                else if (seçim == "B1")
                {
                    if (seçim3 == 1 && seçim2 == 1) { d = "D"; colorD = 1; }
                    else if (seçim3 == 2 && seçim2 == 1) { d = "D"; colorD = 2; }
                    else if (seçim3 == 3 && seçim2 == 1) { d = "D"; colorD = 3; }

                    if (seçim3 == 1 && seçim2 == 2) { d = "E"; colorD = 1; }
                    else if (seçim3 == 2 && seçim2 == 2) { d = "E"; colorD = 2; }
                    else if (seçim3 == 3 && seçim2 == 2) { d = "E"; colorD = 3; }

                    if (seçim3 == 1 && seçim2 == 3) { d = "U"; colorD = 1; }
                    else if (seçim3 == 2 && seçim2 == 3) { d = "U"; colorD = 2; }
                    else if (seçim3 == 3 && seçim2 == 3) { d = "U"; colorD = 3; }
                }
                else if (seçim == "B2")
                {
                    if (seçim3 == 1 && seçim2 == 1) { e = "D"; colorE = 1; }
                    else if (seçim3 == 2 && seçim2 == 1) { e = "D"; colorE = 2; }
                    else if (seçim3 == 3 && seçim2 == 1) { e = "D"; colorE = 3; }

                    if (seçim3 == 1 && seçim2 == 2) { e = "E"; colorE = 1; }
                    else if (seçim3 == 2 && seçim2 == 2) { e = "E"; colorE = 2; }
                    else if (seçim3 == 3 && seçim2 == 2) { e = "E"; colorE = 3; }

                    if (seçim3 == 1 && seçim2 == 3) { e = "U"; colorE = 1; }
                    else if (seçim3 == 2 && seçim2 == 3) { e = "U"; colorE = 2; }
                    else if (seçim3 == 3 && seçim2 == 3) { e = "U"; colorE = 3; }
                }
                else if (seçim == "B3")
                {
                    if (seçim3 == 1 && seçim2 == 1) { f = "D"; colorF = 1; }
                    else if (seçim3 == 2 && seçim2 == 1) { f = "D"; colorF = 2; }
                    else if (seçim3 == 3 && seçim2 == 1) { f = "D"; colorF = 3; }

                    if (seçim3 == 1 && seçim2 == 2) { f = "E"; colorF = 1; }
                    else if (seçim3 == 2 && seçim2 == 2) { f = "E"; colorF = 2; }
                    else if (seçim3 == 3 && seçim2 == 2) { f = "E"; colorF = 3; }

                    if (seçim3 == 1 && seçim2 == 3) { f = "U"; colorF = 1; }
                    else if (seçim3 == 2 && seçim2 == 3) { f = "U"; colorF = 2; }
                    else if (seçim3 == 3 && seçim2 == 3) { f = "U"; colorF = 3; }
                }
                else if (seçim == "C1")
                {
                    if (seçim3 == 1 && seçim2 == 1) { g = "D"; colorG = 1; }
                    else if (seçim3 == 2 && seçim2 == 1) { g = "D"; colorG = 2; }
                    else if (seçim3 == 3 && seçim2 == 1) { g = "D"; colorG = 3; }

                    if (seçim3 == 1 && seçim2 == 2) { g = "E"; colorG = 1; }
                    else if (seçim3 == 2 && seçim2 == 2) { g = "E"; colorG = 2; }
                    else if (seçim3 == 3 && seçim2 == 2) { g = "E"; colorG = 3; }

                    if (seçim3 == 1 && seçim2 == 3) { g = "U"; colorG = 1; }
                    else if (seçim3 == 2 && seçim2 == 3) { g = "U"; colorG = 2; }
                    else if (seçim3 == 3 && seçim2 == 3) { g = "U"; colorG = 3; }
                }
                else if (seçim == "C2")
                {
                    if (seçim3 == 1 && seçim2 == 1) { h = "D"; colorH = 1; }
                    else if (seçim3 == 2 && seçim2 == 1) { h = "D"; colorH = 2; }
                    else if (seçim3 == 3 && seçim2 == 1) { h = "D"; colorH = 3; }

                    if (seçim3 == 1 && seçim2 == 2) { h = "E"; colorH = 1; }
                    else if (seçim3 == 2 && seçim2 == 2) { h = "E"; colorH = 2; }
                    else if (seçim3 == 3 && seçim2 == 2) { h = "E"; colorH = 3; }

                    if (seçim3 == 1 && seçim2 == 3) { h = "U"; colorH = 1; }
                    else if (seçim3 == 2 && seçim2 == 3) { h = "U"; colorH = 2; }
                    else if (seçim3 == 3 && seçim2 == 3) { h = "U"; colorH = 3; }
                }
                else if (seçim == "C3")
                {
                    if (seçim3 == 1 && seçim2 == 1) { i = "D"; colorI = 1; }
                    else if (seçim3 == 2 && seçim2 == 1) { i = "D"; colorI = 2; }
                    else if (seçim3 == 3 && seçim2 == 1) { i = "D"; colorI = 3; }

                    if (seçim3 == 1 && seçim2 == 2) { i = "E"; colorI = 1; }
                    else if (seçim3 == 2 && seçim2 == 2) { i = "E"; colorI = 2; }
                    else if (seçim3 == 3 && seçim2 == 2) { i = "E"; colorI = 3; }

                    if (seçim3 == 1 && seçim2 == 3) { i = "U"; colorI = 1; }
                    else if (seçim3 == 2 && seçim2 == 3) { i = "U"; colorI = 2; }
                    else if (seçim3 == 3 && seçim2 == 3) { i = "U"; colorI = 3; }
                }
                if (a == "D" && b == "E" && c == "U" || c == "D" && b == "E" && a == "U")
                {
                    if (colorA == colorB && colorB == colorC)
                        human_point = human_point + 120;
                    else if (colorA != colorB && colorB != colorC && colorA != colorC)
                        human_point = human_point + 110;
                    else
                        human_point = human_point + 100;

                }
                if (d == "D" && e == "E" && f == "U" || f == "D" && e == "E" && d == "U")
                {
                    if (colorD == colorE && colorF == colorE)
                        human_point = human_point + 120;
                    else if (colorD != colorE && colorE != colorF && colorD != colorF)
                        human_point = human_point + 110;
                    else
                        human_point = human_point + 100;

                }
                if (g == "D" && h == "E" && i == "U" || i == "D" && h == "E" && g == "U")
                {
                    if (colorG == colorH && colorH == colorI)
                        human_point = human_point + 120;
                    else if (colorG != colorH && colorH != colorI && colorG != colorH)
                        human_point = human_point + 110;
                    else
                        human_point = human_point + 100;

                }
                if (a == "D" && d == "E" && g == "U" || g == "D" && d == "E" && a == "U")
                {
                    if (colorA == colorD && colorD == colorG)
                        human_point = human_point + 120;
                    else if (colorA != colorD && colorD != colorG && colorA != colorG)
                        human_point = human_point + 110;
                    else
                        human_point = human_point + 100;
                }
                if (b == "D" && e == "E" && h == "U" || h == "D" && e == "E" && b == "U")
                {
                    if (colorB == colorE && colorE == colorH)
                        human_point = human_point + 120;
                    else if (colorB != colorE && colorE != colorH && colorB != colorH)
                        human_point = human_point + 110;
                    else
                        human_point = human_point + 100;
                }
                if (c == "D" && f == "E" && i == "U" || i == "D" && f == "E" && c == "U")
                {
                    if (colorC == colorF && colorF == colorI)
                        human_point = human_point + 120;
                    else if (colorC != colorF && colorF != colorI && colorC != colorI)
                        human_point = human_point + 110;
                    else
                        human_point = human_point + 100;
                }
                if (a == "D" && e == "E" && i == "U" || i == "D" && e == "E" && a == "U")
                {
                    if (colorA == colorE && colorE == colorI)
                        human_point = human_point + 120;
                    else if (colorA != colorE && colorE != colorI && colorA != colorI)
                        human_point = human_point + 110;
                    else
                        human_point = human_point + 100;
                }
                if (c == "D" && e == "E" && g == "U" || g == "D" && e == "E" && g == "U")
                {
                    if (colorC == colorE && colorE == colorG)
                        human_point = human_point + 120;
                    else if (colorC != colorE && colorE != colorG && colorC != colorG)
                        human_point = human_point + 110;
                    else
                        human_point = human_point + 100;
                }

                if (a == "D" && b == "U" && c == "E" || a == "U" && b == "D" && c == "E" || a == "E" && b == "U" && c == "D" || a == "E" && b == "D" && c == "U")
                {
                    if (colorA == colorB && colorB == colorC)
                        human_point = human_point + 90;
                    else if (colorA != colorB && colorB != colorC && colorA != colorC)
                        human_point = human_point + 80;
                    else
                        human_point = human_point + 70;
                }

                if (d == "D" && e == "U" && f == "E" || d == "U" && e == "D" && f == "E" || d == "E" && e == "U" && f == "D" || d == "E" && e == "D" && f == "U")
                {
                    if (colorD == colorE && colorF == colorE)
                        human_point = human_point + 90;
                    else if (colorD != colorE && colorE != colorF && colorD != colorF)
                        human_point = human_point + 80;
                    else
                        human_point = human_point + 70;
                }

                if (g == "D" && h == "U" && i == "E" || g == "U" && h == "D" && i == "E" || g == "E" && h == "U" && i == "D" || g == "E" && h == "D" && i == "U")
                {
                    if (colorG == colorH && colorH == colorI)
                        human_point = human_point + 90;
                    else if (colorG != colorH && colorH != colorI && colorG != colorI)
                        human_point = human_point + 80;
                    else
                        human_point = human_point + 70;
                }
                if (a == "D" && d == "U" && g == "E" || a == "U" && d == "D" && g == "E" || a == "E" && d == "U" && g == "D" || a == "E" && d == "D" && g == "U")
                {
                    if (colorA == colorD && colorD == colorG)
                        human_point = human_point + 90;
                    else if (colorA != colorD && colorD != colorG && colorA != colorG)
                        human_point = human_point + 80;
                    else
                        human_point = human_point + 70;
                }
                if (b == "D" && e == "U" && h == "E" || b == "U" && e == "D" && h == "E" || b == "E" && e == "U" && h == "D" || b == "E" && e == "D" && h == "U")
                {
                    if (colorB == colorE && colorE == colorH)
                        human_point = human_point + 90;
                    else if (colorB != colorE && colorE != colorH && colorB != colorH)
                        human_point = human_point + 80;
                    else
                        human_point = human_point + 70;
                }
                if (c == "D" && f == "U" && i == "E" || c == "U" && f == "D" && i == "E" || c == "E" && f == "U" && i == "D" || c == "E" && f == "D" && i == "U")
                {
                    if (colorC == colorF && colorF == colorI)
                        human_point = human_point + 90;
                    else if (colorC != colorF && colorF != colorI && colorC != colorI)
                        human_point = human_point + 80;
                    else
                        human_point = human_point + 70;
                }
                if (a == "D" && e == "U" && i == "E" || a == "U" && e == "D" && i == "E" || a == "E" && e == "U" && i == "D" || a == "E" && e == "D" && i == "U")
                {
                    if (colorA == colorE && colorE == colorI)
                        human_point = human_point + 90;
                    else if (colorA != colorE && colorE != colorI && colorA != colorI)
                        human_point = human_point + 80;
                    else
                        human_point = human_point + 70;
                }
                if (c == "D" && e == "U" && g == "E" || c == "U" && e == "D" && g == "E" || c == "E" && e == "U" && g == "D" || c == "E" && e == "D" && g == "U")
                {
                    if (colorC == colorE && colorE == colorG)
                        human_point = human_point + 90;
                    else if (colorC != colorE && colorE != colorG && colorC != colorG)
                        human_point = human_point + 80;
                    else
                        human_point = human_point + 70;
                }
                if (a == b && b != c || a == c && c != b || b == c && b != a)
                {
                    if (colorA == colorB && colorB == colorC)
                        human_point = human_point + 30;
                    else if (colorA != colorB && colorB != colorC && colorA != colorC)
                        human_point = human_point + 20;
                    else
                        human_point = human_point + 0;

                }
                if (d == e && e != f || d == f && f != e || e == f && f != d)
                {
                    if (colorD == colorE && colorF == colorE)
                        human_point = human_point + 30;
                    else if (colorD != colorE && colorE != colorF && colorD != colorF)
                        human_point = human_point + 20;
                    else
                        human_point = human_point + 0;

                }
                if (g == i && i != h || g == h && h != i || i == h && h != g)
                {
                    if (colorG == colorH && colorH == colorI)
                        human_point = human_point + 30;
                    else if (colorG != colorH && colorH != colorI && colorG != colorI)
                        human_point = human_point + 20;
                    else
                        human_point = human_point + 0;

                }
                if (a == d && d != g || a == g && g != d || d == g && a != g)
                {
                    if (colorA == colorD && colorD == colorG)
                        human_point = human_point + 30;
                    else if (colorA != colorD && colorD != colorG && colorA != colorG)
                        human_point = human_point + 20;
                    else
                        human_point = human_point + 0;

                }
                if (b == e && e != h || b == h && h != e || e == h && h != b)
                {
                    if (colorB == colorE && colorE == colorH)
                        human_point = human_point + 30;
                    else if (colorB != colorE && colorE != colorH && colorB != colorH)
                        human_point = human_point + 20;
                    else
                        human_point = human_point + 0;

                }
                if (c == f && f != i || c == i && f != i || f == i && i != c)
                {
                    if (colorC == colorF && colorF == colorI)
                        human_point = human_point + 30;
                    else if (colorC != colorF && colorF != colorI && colorC != colorI)
                        human_point = human_point + 20;
                    else
                        human_point = human_point + 0;

                }
                if (a == e && e != i || a == i && i != e || e == i && i != a)
                {
                    if (colorA == colorE && colorE == colorI)
                        human_point = human_point + 30;
                    else if (colorA != colorE && colorE != colorI && colorA != colorI)
                        human_point = human_point + 20;
                    else
                        human_point = human_point + 0;
                }
                if (c == e && e != g || c == g && g != e || g == e && e != c)
                {
                    if (colorC == colorE && colorE == colorG)
                        human_point = human_point + 30;
                    else if (colorC != colorE && colorE != colorG && colorC != colorG)
                        human_point = human_point + 20;
                    else
                        human_point = human_point + 0;
                }
                if (a == b && b == c)
                {
                    if (colorA == colorB && colorB == colorC)
                        human_point = human_point + 60;
                    else if (colorA != colorB && colorB != colorC && colorA != colorC)
                        human_point = human_point + 50;
                    else
                        human_point = human_point + 40;
                }
                if (d == e && e == f)
                {
                    if (colorD == colorE && colorE == colorF)
                        human_point = human_point + 60;
                    else if (colorD != colorE && colorE != colorF && colorD != colorF)
                        human_point = human_point + 50;
                    else
                        human_point = human_point + 40;
                }
                if (g == h && h == i)
                {
                    if (colorG == colorH && colorH == colorI)
                        human_point = human_point + 60;
                    else if (colorG != colorH && colorH != colorI && colorG != colorI)
                        human_point = human_point + 50;
                    else
                        human_point = human_point + 40;
                }
                if (a == e && e == i)
                {

                    if (colorA == colorE && colorE == colorI)
                        human_point = human_point + 60;
                    else if (colorA != colorE && colorE != colorI && colorA != colorI)
                        human_point = human_point + 50;
                    else
                        human_point = human_point + 40;
                }
                if (c == e && e == g)
                {

                    if (colorC == colorE && colorE == colorG)
                        human_point = human_point + 60;
                    else if (colorC != colorE && colorE != colorG && colorC != colorG)
                        human_point = human_point + 50;
                    else
                        human_point = human_point + 40;
                }
                if (a == d && d == g)
                {

                    if (colorA == colorD && colorD == colorG)
                        human_point = human_point + 60;
                    else if (colorA != colorD && colorD != colorG && colorA != colorG)
                        human_point = human_point + 50;
                    else
                        human_point = human_point + 40;
                }
                if (b == e && e == h)
                {

                    if (colorB == colorE && colorE == colorH)
                        human_point = human_point + 60;
                    else if (colorB != colorE && colorE != colorH && colorB != colorH)
                        human_point = human_point + 50;
                    else
                        human_point = human_point + 40;
                }
                if (c == f && f == i)
                {

                    if (colorC == colorF && colorF == colorI)
                        human_point = human_point + 60;
                    else if (colorC != colorF && colorF != colorI && colorC != colorI)
                        human_point = human_point + 50;
                    else
                        human_point = human_point + 40;
                }

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
                Console.WriteLine("PLAYER's POINT = " + human_point);

                for (int forsayacı = 0; forsayacı < 4; forsayacı++)
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
               


                // geçici olarak 0 değerlerini atadım.
                int tur = 0;
             
               
                do
                {
                    Random rand = new Random();
                    // Rastgele bir blok seçme
                    int block_choice2 = rand.Next(1, 10);
                    int letter_choice2 = rand.Next(1, 4);
                    int color_choice2 = rand.Next(1, 4);

                    if (block_choice2 == 1)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { a = "D"; colorA = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { a = "D"; colorA = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { a = "D"; colorA = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { a = "E"; colorA = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { a = "E"; colorA = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { a = "E"; colorA = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { a = "U"; colorA = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { a = "U"; colorA = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { a = "U"; colorA = 3; }
                    }
                    if (block_choice2 == 2)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { b = "D"; colorB = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { b = "D"; colorB = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { b = "D"; colorB = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { b = "E"; colorB = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { b = "E"; colorB = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { b = "E"; colorB = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { b = "U"; colorB = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { b = "U"; colorB = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { b = "U"; colorB = 3; }
                    }
                    if (block_choice2 == 3)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { c = "D"; colorC = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { c = "D"; colorC = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { c = "D"; colorC = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { c = "E"; colorC = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { c = "E"; colorC = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { c = "E"; colorC = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { c = "U"; colorC = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { c = "U"; colorC = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { c = "U"; colorC = 3; }
                    }
                    if (block_choice2 == 3)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { d = "D"; colorD = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { d = "D"; colorD = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { d = "D"; colorD = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { d = "E"; colorD = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { d = "E"; colorD = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { d = "E"; colorD = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { d = "U"; colorD = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { d = "U"; colorD = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { d = "U"; colorD = 3; }
                    }
                    if (block_choice2 == 4)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { e = "D"; colorE = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { e = "D"; colorE = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { e = "D"; colorE = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { e = "E"; colorE = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { e = "E"; colorE = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { e = "E"; colorE = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { e = "U"; colorE = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { e = "U"; colorE = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { e = "U"; colorE = 3; }
                    }
                    if (block_choice2 == 5)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { f = "D"; colorF = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { f = "D"; colorF = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { f = "D"; colorF = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { f = "E"; colorF = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { f = "E"; colorF = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { f = "E"; colorF = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { f = "U"; colorF = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { f = "U"; colorF = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { f = "U"; colorF = 3; }
                    }
                    if (block_choice2 == 6)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { g = "D"; colorG = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { g = "D"; colorG = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { g = "D"; colorG = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { g = "E"; colorG = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { g = "E"; colorG = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { g = "E"; colorG = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { g = "U"; colorG = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { g = "U"; colorG = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { g = "U"; colorG = 3; }
                    }
                    if (block_choice2 == 7)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { h = "D"; colorH = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { h = "D"; colorH = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { h = "D"; colorH = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { h = "E"; colorH = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { h = "E"; colorH = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { h = "E"; colorH = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { h = "U"; colorH = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { h = "U"; colorH = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { h = "U"; colorH = 3; }
                    }
                    if (block_choice2 == 8)
                    {
                        if (color_choice2 == 1 && letter_choice2 == 1) { i = "D"; colorI = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 1) { i = "D"; colorI = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 1) { i = "D"; colorI = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 2) { i = "E"; colorI = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 2) { i = "E"; colorI = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 2) { i = "E"; colorI = 3; }

                        else if (color_choice2 == 1 && letter_choice2 == 3) { i = "U"; colorI = 1; }
                        else if (color_choice2 == 2 && letter_choice2 == 3) { i = "U"; colorI = 2; }
                        else if (color_choice2 == 3 && letter_choice2 == 3) { i = "U"; colorI = 3; }
                    }

                  
                    if (a == "D" && b == "E" && c == "U" || c == "D" && b == "E" && a == "U")
                    {
                        if (colorA == colorB && colorB == colorC)
                            computer_current = computer_current + 120;
                        else if (colorA != colorB && colorB != colorC && colorA != colorC)
                            computer_current = computer_current + 110;
                        else
                            computer_current = computer_current + 100;

                    }
                    if (d == "D" && e == "E" && f == "U" || f == "D" && e == "E" && d == "U")
                    {
                        if (colorD == colorE && colorF == colorE)
                            computer_current = computer_current + 120;
                        else if (colorD != colorE && colorE != colorF && colorD != colorF)
                            computer_current = computer_current + 110;
                        else
                            computer_current = computer_current + 100;

                    }
                    if (g == "D" && h == "E" && i == "U" || i == "D" && h == "E" && g == "U")
                    {
                        if (colorG == colorH && colorH == colorI)
                            computer_current = computer_current + 120;
                        else if (colorG != colorH && colorH != colorI && colorG != colorH)
                            computer_current = computer_current + 110;
                        else
                            computer_current = computer_current + 100;

                    }
                    if (a == "D" && d == "E" && g == "U" || g == "D" && d == "E" && a == "U")
                    {
                        if (colorA == colorD && colorD == colorG)
                            computer_current = computer_current + 120;
                        else if (colorA != colorD && colorD != colorG && colorA != colorG)
                            computer_current = computer_current + 110;
                        else
                            computer_current = computer_current + 100;
                    }
                    if (b == "D" && e == "E" && h == "U" || h == "D" && e == "E" && b == "U")
                    {
                        if (colorB == colorE && colorE == colorH)
                            computer_current = computer_current + 120;
                        else if (colorB != colorE && colorE != colorH && colorB != colorH)
                            computer_current = computer_current + 110;
                        else
                            computer_current = computer_current + 100;
                    }
                    if (c == "D" && f == "E" && i == "U" || i == "D" && f == "E" && c == "U")
                    {
                        if (colorC == colorF && colorF == colorI)
                            computer_current = computer_current + 120;
                        else if (colorC != colorF && colorF != colorI && colorC != colorI)
                            computer_current = computer_current + 110;
                        else
                            computer_current = computer_current + 100;
                    }
                    if (a == "D" && e == "E" && i == "U" || i == "D" && e == "E" && a == "U")
                    {
                        if (colorA == colorE && colorE == colorI)
                            computer_current = computer_current + 120;
                        else if (colorA != colorE && colorE != colorI && colorA != colorI)
                            computer_current = computer_current + 110;
                        else
                            computer_current = computer_current + 100;
                    }
                    if (c == "D" && e == "E" && g == "U" || g == "D" && e == "E" && g == "U")
                    {
                        if (colorC == colorE && colorE == colorG)
                            computer_current = computer_current + 120;
                        else if (colorC != colorE && colorE != colorG && colorC != colorG)
                            computer_current = computer_current + 110;
                        else
                            computer_current = computer_current + 100;
                    }

                    if (a == "D" && b == "U" && c == "E" || a == "U" && b == "D" && c == "E" || a == "E" && b == "U" && c == "D" || a == "E" && b == "D" && c == "U")
                    {
                        if (colorA == colorB && colorB == colorC)
                            computer_current = computer_current + 90;
                        else if (colorA != colorB && colorB != colorC && colorA != colorC)
                            computer_current = computer_current + 80;
                        else
                            computer_current = computer_current + 70;
                    }

                    if (d == "D" && e == "U" && f == "E" || d == "U" && e == "D" && f == "E" || d == "E" && e == "U" && f == "D" || d == "E" && e == "D" && f == "U")
                    {
                        if (colorD == colorE && colorF == colorE)
                            computer_current = computer_current + 90;
                        else if (colorD != colorE && colorE != colorF && colorD != colorF)
                            computer_current = computer_current + 80;
                        else
                            computer_current = computer_current + 70;
                    }

                    if (g == "D" && h == "U" && i == "E" || g == "U" && h == "D" && i == "E" || g == "E" && h == "U" && i == "D" || g == "E" && h == "D" && i == "U")
                    {
                        if (colorG == colorH && colorH == colorI)
                            computer_current = computer_current + 90;
                        else if (colorG != colorH && colorH != colorI && colorG != colorI)
                            computer_current = computer_current + 80;
                        else
                            computer_current = computer_current + 70;
                    }

                    if (a == "D" && d == "U" && g == "E" || a == "U" && d == "D" && g == "E" || a == "E" && d == "U" && g == "D" || a == "E" && d == "D" && g == "U")
                    {
                        if (colorA == colorD && colorD == colorG)
                            computer_current = computer_current + 90;
                        else if (colorA != colorD && colorD != colorG && colorA != colorG)
                            computer_current = computer_current + 80;
                        else
                            computer_current = computer_current + 70;
                    }

                    if (b == "D" && e == "U" && h == "E" || b == "U" && e == "D" && h == "E" || b == "E" && e == "U" && h == "D" || b == "E" && e == "D" && h == "U")
                    {
                        if (colorB == colorE && colorE == colorH)
                            computer_current = computer_current + 90;
                        else if (colorB != colorE && colorE != colorH && colorB != colorH)
                            computer_current = computer_current + 80;
                        else
                            computer_current = computer_current + 70;
                    }

                    if (c == "D" && f == "U" && i == "E" || c == "U" && f == "D" && i == "E" || c == "E" && f == "U" && i == "D" || c == "E" && f == "D" && i == "U")
                    {
                        if (colorC == colorF && colorF == colorI)
                            computer_current = computer_current + 90;
                        else if (colorC != colorF && colorF != colorI && colorC != colorI)
                            computer_current = computer_current + 80;
                        else
                            computer_current = computer_current + 70;
                    }

                    if (a == "D" && e == "U" && i == "E" || a == "U" && e == "D" && i == "E" || a == "E" && e == "U" && i == "D" || a == "E" && e == "D" && i == "U")
                    {
                        if (colorA == colorE && colorE == colorI)
                            computer_current = computer_current + 90;
                        else if (colorA != colorE && colorE != colorI && colorA != colorI)
                            computer_current = computer_current + 80;
                        else
                            computer_current = computer_current + 70;
                    }

                    if (c == "D" && e == "U" && g == "E" || c == "U" && e == "D" && g == "E" || c == "E" && e == "U" && g == "D" || c == "E" && e == "D" && g == "U")
                    {
                        if (colorC == colorE && colorE == colorG)
                            computer_current = computer_current + 90;
                        else if (colorC != colorE && colorE != colorG && colorC != colorG)
                            computer_current = computer_current + 80;
                        else
                            computer_current = computer_current + 70;
                    }

                    if (a == b && b != c || a == c && c != b || b == c && b != a)
                    {
                        if (colorA == colorB && colorB == colorC)
                            computer_current = computer_current + 30;
                        else if (colorA != colorB && colorB != colorC && colorA != colorC)
                            computer_current = computer_current + 20;
                        else
                            computer_current = computer_current + 0;
                    }

                    if (d == e && e != f || d == f && f != e || e == f && f != d)
                    {
                        if (colorD == colorE && colorF == colorE)
                            computer_current = computer_current + 30;
                        else if (colorD != colorE && colorE != colorF && colorD != colorF)
                            computer_current = computer_current + 20;
                        else
                            computer_current = computer_current + 0;
                    }

                    if (g == i && i != h || g == h && h != i || i == h && h != g)
                    {
                        if (colorG == colorH && colorH == colorI)
                            computer_current = computer_current + 30;
                        else if (colorG != colorH && colorH != colorI && colorG != colorI)
                            computer_current = computer_current + 20;
                        else
                            computer_current = computer_current + 0;
                    }

                    if (a == d && d != g || a == g && g != d || d == g && a != g)
                    {
                        if (colorA == colorD && colorD == colorG)
                            computer_current = computer_current + 30;
                        else if (colorA != colorD && colorD != colorG && colorA != colorG)
                            computer_current = computer_current + 20;
                        else
                            computer_current = computer_current + 0;
                    }

                    if (b == e && e != h || b == h && h != e || e == h && h != b)
                    {
                        if (colorB == colorE && colorE == colorH)
                            computer_current = computer_current + 30;
                        else if (colorB != colorE && colorE != colorH && colorB != colorH)
                            computer_current = computer_current + 20;
                        else
                            computer_current = computer_current + 0;
                    }

                    if (c == f && f != i || c == i && f != i || f == i && i != c)
                    {
                        if (colorC == colorF && colorF == colorI)
                            computer_current = computer_current + 30;
                        else if (colorC != colorF && colorF != colorI && colorC != colorI)
                            computer_current = computer_current + 20;
                        else
                            computer_current = computer_current + 0;
                    }

                    if (a == e && e != i || a == i && i != e || e == i && i != a)
                    {
                        if (colorA == colorE && colorE == colorI)
                            computer_current = computer_current + 30;
                        else if (colorA != colorE && colorE != colorI && colorA != colorI)
                            computer_current = computer_current + 20;
                        else
                            computer_current = computer_current + 0;
                    }

                    if (c == e && e != g || c == g && g != e || g == e && e != c)
                    {
                        if (colorC == colorE && colorE == colorG)
                            computer_current = computer_current + 30;
                        else if (colorC != colorE && colorE != colorG && colorC != colorG)
                            computer_current = computer_current + 20;
                        else
                            computer_current = computer_current + 0;
                    }

                    if (a == b && b == c)
                    {
                        if (colorA == colorB && colorB == colorC)
                            computer_current = computer_current + 60;
                        else if (colorA != colorB && colorB != colorC && colorA != colorC)
                            computer_current = computer_current + 50;
                        else
                            computer_current = computer_current + 40;
                    }

                    if (d == e && e == f)
                    {
                        if (colorD == colorE && colorE == colorF)
                            computer_current = computer_current + 60;
                        else if (colorD != colorE && colorE != colorF && colorD != colorF)
                            computer_current = computer_current + 50;
                        else
                            computer_current = computer_current + 40;
                    }

                    if (g == h && h == i)
                    {
                        if (colorG == colorH && colorH == colorI)
                            computer_current = computer_current + 60;
                        else if (colorG != colorH && colorH != colorI && colorG != colorI)
                            computer_current = computer_current + 50;
                        else
                            computer_current = computer_current + 40;
                    }

                    if (a == e && e == i)
                    {
                        if (colorA == colorE && colorE == colorI)
                            computer_current = computer_current + 60;
                        else if (colorA != colorE && colorE != colorI && colorA != colorI)
                            computer_current = computer_current + 50;
                        else
                            computer_current = computer_current + 40;
                    }

                    if (c == e && e == g)
                    {
                        if (colorC == colorE && colorE == colorG)
                            computer_current = computer_current + 60;
                        else if (colorC != colorE && colorE != colorG && colorC != colorG)
                            computer_current = computer_current + 50;
                        else
                            computer_current = computer_current + 40;
                    }

                    if (a == d && d == g)
                    {
                        if (colorA == colorD && colorD == colorG)
                            computer_current = computer_current + 60;
                        else if (colorA != colorD && colorD != colorG && colorA != colorG)
                            computer_current = computer_current + 50;
                        else
                            computer_current = computer_current + 40;
                    }

                    if (b == e && e == h)
                    {
                        if (colorB == colorE && colorE == colorH)
                            computer_current = computer_current + 60;
                        else if (colorB != colorE && colorE != colorH && colorB != colorH)
                            computer_current = computer_current + 50;
                        else
                            computer_current = computer_current + 40;
                    }

                    if (c == f && f == i)
                    {
                        if (colorC == colorF && colorF == colorI)
                            computer_current = computer_current + 60;
                        else if (colorC != colorF && colorF != colorI && colorC != colorI)
                            computer_current = computer_current + 50;
                        else
                            computer_current = computer_current + 40;
                    }
                    if (computer_current >= computer_max)
                    {
                        computer_max = computer_current;
                       
                    }

                    computer_current = 0;
                    tur = tur++;
                } while (tur <= zorluk);
                computer_point_total = computer_point_total + computer_max;
                computer_max = 0;
                
     
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
                Console.WriteLine("Computer AI's point = " + computer_point_total);
                
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
            if (computer_point_total > human_point)
            {
                Console.WriteLine("COMPUTER AI WON THE GAME with " + computer_point_total + " point");
                Console.ReadLine();
            }
            else if (computer_point_total < human_point)
            {
                Console.WriteLine("PLAYER WON THE GAME with " + human_point + " point");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("COMPUTER AI and PLAYER's POINT ARE EQUAL with " + human_point + "point");
                Console.ReadLine();
            }
        }
    }
}


