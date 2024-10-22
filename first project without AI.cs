using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace deejdkhefd
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
                if (değişim == 1) { if (num1 == 1) a = "D"; else if (num1 == 2) a = "E"; else a = "U"; if (num2 == 1) colorA = 1; else if (num2 == 2) colorA = 2; else colorA = 3; }
                else if (değişim == 2) { if (num1 == 1) b = "D"; else if (num1 == 2) b = "E"; else b = "U"; if (num2 == 1) colorB = 1; else if (num2 == 2) colorB = 2; else colorB = 3; }
                else if (değişim == 3) { if (num1 == 1) c = "D"; else if (num1 == 2) c = "E"; else c = "U"; if (num2 == 1) colorC = 1; else if (num2 == 2) colorC = 2; else colorC = 3; }
                else if (değişim == 4) { if (num1 == 1) d = "D"; else if (num1 == 2) d = "E"; else d = "U"; if (num2 == 1) colorD = 1; else if (num2 == 2) colorD = 2; else colorD = 3; }
                else if (değişim == 5) { if (num1 == 1) e = "D"; else if (num1 == 2) e = "E"; else e = "U"; if (num2 == 1) colorE = 1; else if (num2 == 2) colorE = 2; else colorE = 3; }
                else if (değişim == 6) { if (num1 == 1) f = "D"; else if (num1 == 2) f = "E"; else f = "U"; if (num2 == 1) colorF = 1; else if (num2 == 2) colorF = 2; else colorF = 3; }
                else if (değişim == 7) { if (num1 == 1) g = "D"; else if (num1 == 2) g = "E"; else g = "U"; if (num2 == 1) colorG = 1; else if (num2 == 2) colorG = 2; else colorG = 3; }
                else if (değişim == 8) { if (num1 == 1) h = "D"; else if (num1 == 2) h = "E"; else h = "U"; if (num2 == 1) colorH = 1; else if (num2 == 2) colorH = 2; else colorH = 3; }
                else { if (num1 == 1) i = "D"; else if (num1 == 2) i = "E"; else i = "U"; if (num2 == 1) colorI = 1; else if (num2 == 2) colorI = 2; else colorI = 3; }


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

            int human_point = 0;

            if (a == "D" && b == "E" && c == "U" || c == "D" && b == "E" && a == "U")
            {
                if (colorA == colorB && colorB == colorC)
                    human_point = human_point + 120;
                else if (colorA != colorB && colorB != colorC)
                    human_point = human_point + 110;
                else
                    human_point = human_point + 100;

            }
            if (d == "D" && e == "E" && f == "U" || f == "D" && e == "E" && d == "U")
            {
                if (colorD == colorE && colorF == colorE)
                    human_point = human_point + 120;
                else if (colorD != colorE && colorE != colorF)
                    human_point = human_point + 110;
                else
                    human_point = human_point + 100;

            }
            if (g == "D" && h == "E" && i == "U" || i == "D" && h == "E" && g == "U")
            {
                if (colorG == colorH && colorH == colorI)
                    human_point = human_point + 120;
                else if (colorG != colorH && colorH != colorI)
                    human_point = human_point + 110;
                else
                    human_point = human_point + 100;

            }
            if (a == "D" && d == "E" && g == "U" || g == "D" && d == "E" && a == "U")
            {
                if (colorA == colorD && colorD == colorG)
                    human_point = human_point + 120;
                else if (colorA != colorD && colorD != colorG)
                    human_point = human_point + 110;
                else
                    human_point = human_point + 100;
            }
            // DEU BITMEDİ
            bool r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21;
            bool r22, r23, r24, r25, r26, r27, r28, r29, r30, r31, r32, r33, r34, r35, r36, r37, r38, r39, r40, r41;
            bool r42, r43, r44, r45, r46, r47, r48, r49, r50, r51, r52, r53, r54, r55, r56, r57, r58, r59, r60, r61;
            bool r62, r63, r64, r65, r66, r67, r68, r69, r70, r71, r72, r73, r74, r75, r76, r77, r78, r79, r80, r81;
            r1=a== "D"&&colorA== 1;
            r2=a== "D"&&colorA== 2;
            r3=a== "D"&&colorA== 3;
            r4=a== "E"&&colorA== 1;
            r5=a== "E"&&colorA== 2;
            r6=a== "E"&&colorA== 3;
            r7=a== "U"&&colorA== 1;
            r8=a== "U"&&colorA== 2;
            r9=a== "U"&&colorA== 3;
            r10=b== "D"&&colorB== 1;
            r11=b== "D"&&colorB== 2;
            r12=b== "D"&&colorB== 3;
            r13=b== "E"&&colorB== 1;
            r14=b== "E"&&colorB== 2;
            r15=b== "E" &&colorB== 3;
            r16=b== "U" &&colorB== 1;
            r17=b== "U" &&colorB== 2;
            r18=b== "U" &&colorB== 3;
            r19=c== "D" &&colorC== 1;
            r20=c== "D" &&colorC== 2;
            r21=c== "D" &&colorC== 3;
            r22=c== "E" &&colorC== 1;
            r23=c== "E" &&colorC== 2;
            r24=c== "E" &&colorC== 3;
            r25=c== "U" &&colorC== 1;
            r26=c== "U" &&colorC== 2;
            r27=c== "U" &&colorC== 3;
            r28=d== "D" &&colorD== 1;
            r29=d== "D" &&colorD== 2;
            r30=d== "D" &&colorD== 3;
            r31=d== "E" &&colorD== 1;
            r32=d== "E" &&colorD== 2;
            r33=d== "E" &&colorD== 3;
            r34=d== "U" &&colorD== 1;
            r35=d== "U" &&colorD== 2;
            r36=d== "U" &&colorD== 3;
            r37=e== "D" &&colorE== 1;
            r38=e== "D" &&colorE== 2;
            r39=e== "D" &&colorE== 3;
            r40=e== "E" &&colorE== 1;
            r41=e== "E" &&colorE== 2;
            r42=e== "E" &&colorE== 3;
            r43=e== "U" &&colorE== 1;
            r44=e== "U" &&colorE== 2;  
            r45=e== "U" &&colorE== 3;
            r46=f== "D" &&colorF== 1;
            r47=f== "D" &&colorF== 2;
            r48=f== "D" &&colorF== 3;
            r49=f== "E" &&colorF== 1;
            r50=f== "E" &&colorF== 2;
            r51=f== "E" &&colorF== 3;
            r52=f== "U" &&colorF== 1;
            r53=f== "U" &&colorF== 2;
            r54=f== "U" &&colorF== 3;
            r55=g== "D" &&colorG== 1;
            r56=g== "D" &&colorG== 2;
            r57=g== "D" &&colorG== 3;
            r58=g== "E" &&colorG== 1;
            r59=g== "E" &&colorG== 2;
            r60=g== "E" &&colorG== 3;
            r61=g== "U" &&colorG== 1;
            r62=g== "U" &&colorG== 2;
            r63=g== "U" &&colorG== 3;
            r64=h== "D" &&colorH== 1;
            r65=h== "D" &&colorH== 2;
            r66=h== "D" &&colorH== 3;  
            r67=h== "E" &&colorH== 1;
            r68=h== "E" &&colorH== 2;
            r69=h== "E" &&colorH== 3;
            r70=h== "U" &&colorH== 1;
            r71=h== "U" &&colorH== 2;
            r72=h== "U" &&colorH== 3;
            r73=i== "D" &&colorI== 1;
            r74=i== "D" &&colorI== 2;
            r75=i== "D" &&colorI== 3;
            r76=i== "E" &&colorI== 1;
            r77=i== "E" &&colorI== 2;
            r78=i== "E" &&colorI== 3;
            r79=i== "U" &&colorI== 1;
            r80=i== "U" &&colorI== 2;
            r81=i== "U" &&colorI== 3;


            string easy_AI = random.Next(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21);










        }
    }

}

