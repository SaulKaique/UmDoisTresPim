Console.Clear();

Console.ForegroundColor = ConsoleColor.Magenta;

Console.Write(".....Um-Dois-Tres-Pim.....\n");

Console.ResetColor();


Console.ForegroundColor = ConsoleColor.DarkRed;

for (int n = 1; n <= 40; n++)
    Console.Write(n % 4 == 0 ? "pim\n" : $"{n,2} ");


Console.ResetColor();