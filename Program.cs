Console.Clear();

Console.ForegroundColor = ConsoleColor.Magenta;

Console.Write(".....Um-Dois-Tres-Pim.....\n");

Console.ResetColor();


Console.ForegroundColor = ConsoleColor.DarkRed;

for (int Numero = 1; Numero <= 40; Numero++)
    Console.Write(Numero % 4 == 0 ? "pim\n" : $"{Numero,2} ");


Console.ResetColor();