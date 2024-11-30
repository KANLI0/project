

Random random = new Random();
bool flag = false;
bool flag2 = false;
int totalmoney = 0;
do
{
    int a = random.Next(1, 7);
    int b = random.Next(1, 7);
    int c = random.Next(1, 7);
    int c1 = random.Next(1, 4);
    int c2 = random.Next(1, 4);
    int c3 = random.Next(1, 4);
    int para = 0;
    int bonus = 0;
    Console.WriteLine("|---|---|---|");
    Console.Write("| ");
    if (c1 == 1) { Console.ForegroundColor = ConsoleColor.Red; }
    else if (c1 == 2) { Console.ForegroundColor = ConsoleColor.Blue; }
    else if (c1 == 3) { Console.ForegroundColor = ConsoleColor.Green; }
    Console.Write(a);
    Console.ResetColor();
    Console.Write(" | ");
    if (c2 == 1) { Console.ForegroundColor = ConsoleColor.Red; }
    else if (c2 == 2) { Console.ForegroundColor = ConsoleColor.Blue; }
    else if (c2 == 3) { Console.ForegroundColor = ConsoleColor.Green; }
    Console.Write(b);
    Console.ResetColor();
    Console.Write(" | ");
    if (c3 == 1) { Console.ForegroundColor = ConsoleColor.Red; }
    else if (c3 == 2) { Console.ForegroundColor = ConsoleColor.Blue; }
    else if (c3 == 3) { Console.ForegroundColor = ConsoleColor.Green; }
    Console.Write(c);
    Console.ResetColor();
    Console.Write(" |");
    Console.WriteLine();
    Console.WriteLine("|---|---|---|");
    if (a == b && b == c && c1 == c2 && c2 == c3) { para += 30; }
    else if (a == b && b == c && c1 != c2 && c2 != c3 && c1 != c3) { para += 28; }
    else if (a == b && b == c && (c1 != c2 && c1 == c3 || c1 != c2 && c2 == c3 || c1 == c2 && c1 != c3)) { para += 26; }
    else if ((a == b + 1 && a == c + 2) && (c1 == c2 && c2 == c3)) { para += 20; }
    else if ((a == b - 1 && a == c - 2) && (c1 == c2 && c2 == c3)) { para += 20; }
    else if ((a == b + 1 && a == c - 1) && (c1 == c2 && c2 == c3)) { para += 20; }
    else if ((a == b + 2 && a == c + 1) && (c1 == c2 && c2 == c3)) { para += 20; }
    else if ((a == b - 1 && a == c + 1) && (c1 == c2 && c2 == c3)) { para += 20; }
    else if ((a == b - 2 && a == c - 1) && (c1 == c2 && c2 == c3)) { para += 20; }
    //sıralı sayılar hepsi farklı renk
    else if ((a == b + 1 && a == c + 2) && (c1 != c2 && c2 != c3 && c1 != c3)) { para += 18; }
    else if ((a == b - 1 && a == c - 2) && (c1 != c2 && c2 != c3 && c1 != c3)) { para += 18; }
    else if ((a == b + 1 && a == c - 1) && (c1 != c2 && c2 != c3 && c1 != c3)) { para += 18; }
    else if ((a == b + 2 && a == c + 1) && (c1 != c2 && c2 != c3 && c1 != c3)) { para += 18; }
    else if ((a == b - 1 && a == c + 1) && (c1 != c2 && c2 != c3 && c1 != c3)) { para += 18; }
    else if ((a == b - 2 && a == c - 1) && (c1 != c2 && c2 != c3 && c1 != c3)) { para += 18; }
    //sıralı sayılar 2 aynı 1 farklı renk
    else if ((a == b + 1 && a == c + 2) && (c1 != c2 && c1 == c3 || c1 != c2 && c2 == c3 || c1 == c2 && c1 != c3)) { para += 16; }
    else if ((a == b - 1 && a == c - 2) && (c1 != c2 && c1 == c3 || c1 != c2 && c2 == c3 || c1 == c2 && c1 != c3)) { para += 16; }
    else if ((a == b + 1 && a == c - 1) && (c1 != c2 && c1 == c3 || c1 != c2 && c2 == c3 || c1 == c2 && c1 != c3)) { para += 16; }
    else if ((a == b + 2 && a == c + 1) && (c1 != c2 && c1 == c3 || c1 != c2 && c2 == c3 || c1 == c2 && c1 != c3)) { para += 16; }
    else if ((a == b - 1 && a == c + 1) && (c1 != c2 && c1 == c3 || c1 != c2 && c2 == c3 || c1 == c2 && c1 != c3)) { para += 16; }
    else if ((a == b - 2 && a == c - 1) && (c1 != c2 && c1 == c3 || c1 != c2 && c2 == c3 || c1 == c2 && c1 != c3)) { para += 16; }
    //aynı ve sıralı olmayan aynı renk 
    else if ((a > b + 2 || a < b - 2 || b > c + 2 || b < c - 2 || a > c + 2 || a < c - 2) && (c1 == c2 && c2 == c3)) { para += 10; }
    //aynı ve sıralı olmayan farklı renk 
    else if ((a > b + 2 || a < b - 2 || b > c + 2 || b < c - 2 || a > c + 2 || a < c - 2) && (a != b) && (b != c) && (c1 != c2 && c2 != c3 && c1 != c3)) { para += 8; }
    // 2 sayı aynı 1 sayı farklı ve renkler aynıysa
    else if ((a == b && a != c && c1 == c2 && c2 == c3) || (a == c && a != b && c1 == c2 && c2 == c3) || (b == c && b != a && c1 == c2 && c2 == c3)) { para += 6; }
    //tek çift bonus puan
    if ((a % 2 == b % 2) && (b % 2 == c % 2)) { bonus += 3; }

    totalmoney += para + bonus;
    if (para > 0)
    {
        Console.WriteLine("Congratulations !");
        Console.WriteLine("YOU WİN " + para + "$");
    }
    if (para == 0)
    { Console.WriteLine("YOU LOST :("); }
    if (bonus > 0)
    { Console.WriteLine("YOU WİN 3$ BONUS"); }
    Console.WriteLine("Do you want to play again? (Y or N)");
    do
    {
        string seçim = Console.ReadLine();
        if (seçim == "N" || seçim == "n") { flag = true; flag2 = true; }
        else if (seçim == "Y" || seçim == "y") { flag2 = true; }
        else { Console.WriteLine("Please enter (Y or N)"); flag2 = false; }
    } while (!flag2);
} while (!flag);
Console.WriteLine("The game finished !");
Console.WriteLine("Total score obtained is " + totalmoney + "$");
Console.ReadLine();

