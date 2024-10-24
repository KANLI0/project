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
            do
            {
                Console.WriteLine("\nCHOOSE A GAME MODE \n1-EASY\n2-MODERATE\n3-HARD");
                string gamemode = Console.ReadLine();
                if (gamemode == "1")
                {
                    Console.WriteLine("YOU CHOOSE EASY MODE ");
                    break;
                }
                else if (gamemode == "2")
                {
                    Console.WriteLine("YOU CHOOSE MODERATE MODE");
                    break;
                }
                else if (gamemode == "3")
                {
                    Console.WriteLine("YOU CHOOSE HARD MODE");
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
            Console.WriteLine("oyuncu puanı *****");

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
                Console.ReadLine();


                int rand = random.Next(1, 10);
                int rand2 = random.Next(1, 4);
                int rand3 = random.Next(1, 4);
                if (rand == 1)
                {
                    if (rand2 == 1) { a = "D"; if (rand3 == 1) colorA = 1; else if (rand3 == 2) colorA = 2; else colorA = 3; }
                    else if (rand2 == 2) { a = "E"; if (rand3 == 1) colorA = 1; else if (rand3 == 2) colorA = 2; else colorA = 3; }
                    else { a = "U"; if (rand3 == 1) colorA = 1; else if (rand3 == 2) colorA = 2; else colorA = 3; }
                }
                if (rand == 2)
                {
                    if (rand2 == 1) { b = "D"; if (rand3 == 1) colorB = 1; else if (rand3 == 2) colorB = 2; else colorB = 3; }
                    else if (rand2 == 2) { b = "E"; if (rand3 == 1) colorB = 1; else if (rand3 == 2) colorB = 2; else colorB = 3; }
                    else { b = "U"; if (rand3 == 1) colorB = 1; else if (rand3 == 2) colorB = 2; else colorB = 3; }
                }
                if (rand == 3)
                {
                    if (rand2 == 1) { c = "D"; if (rand3 == 1) colorC = 1; else if (rand3 == 2) colorC = 2; else colorC = 3; }
                    else if (rand2 == 2) { c = "E"; if (rand3 == 1) colorC = 1; else if (rand3 == 2) colorC = 2; else colorC = 3; }
                    else { c = "U"; if (rand3 == 1) colorC = 1; else if (rand3 == 2) colorC = 2; else colorC = 3; }
                }
                if (rand == 4)
                {
                    if (rand2 == 1) { d = "D"; if (rand3 == 1) colorD = 1; else if (rand3 == 2) colorD = 2; else colorD = 3; }
                    else if (rand2 == 2) { c = "E"; if (rand3 == 1) colorD = 1; else if (rand3 == 2) colorD = 2; else colorD = 3; }
                    else { d = "U"; if (rand3 == 1) colorD = 1; else if (rand3 == 2) colorD = 2; else colorD = 3; }
                }
                if (rand == 5)
                {
                    if (rand2 == 1) { e = "D"; if (rand3 == 1) colorE = 1; else if (rand3 == 2) colorE = 2; else colorE = 3; }
                    else if (rand2 == 2) { e = "E"; if (rand3 == 1) colorE = 1; else if (rand3 == 2) colorE = 2; else colorE = 3; }
                    else { e = "U"; if (rand3 == 1) colorE = 1; else if (rand3 == 2) colorE = 2; else colorE = 3; }
                }
                if (rand == 6)
                {
                    if (rand2 == 1) { f = "D"; if (rand3 == 1) colorF = 1; else if (rand3 == 2) colorF = 2; else colorF = 3; }
                    else if (rand2 == 2) { f = "E"; if (rand3 == 1) colorF = 1; else if (rand3 == 2) colorF = 2; else colorF = 3; }
                    else { f = "U"; if (rand3 == 1) colorF = 1; else if (rand3 == 2) colorF = 2; else colorF = 3; }
                }
                if (rand == 7)
                {
                    if (rand2 == 1) { g = "D"; if (rand3 == 1) colorG = 1; else if (rand3 == 2) colorG = 2; else colorG = 3; }
                    else if (rand2 == 2) { g = "E"; if (rand3 == 1) colorG = 1; else if (rand3 == 2) colorG = 2; else colorG = 3; }
                    else { g = "U"; if (rand3 == 1) colorG = 1; else if (rand3 == 2) colorG = 2; else colorG = 3; }
                }
                if (rand == 8)
                {
                    if (rand2 == 1) { h = "D"; if (rand3 == 1) colorH = 1; else if (rand3 == 2) colorH = 2; else colorH = 3; }
                    else if (rand2 == 2) { h = "E"; if (rand3 == 1) colorH = 1; else if (rand3 == 2) colorH = 2; else colorH = 3; }
                    else { h = "U"; if (rand3 == 1) colorH = 1; else if (rand3 == 2) colorH = 2; else colorH = 3; }
                }
                else
                {
                    if (rand2 == 1) { i = "D"; if (rand3 == 1) colorI = 1; else if (rand3 == 2) colorI = 2; else colorI = 3; }
                    else if (rand2 == 2) { i = "E"; if (rand3 == 1) colorI = 1; else if (rand3 == 2) colorI = 2; else colorI = 3; }
                    else { i = "U"; if (rand3 == 1) colorI = 1; else if (rand3 == 2) colorI = 2; else colorI = 3; }
                }












            }
        }
    }
}
