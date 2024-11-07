List<string>ziyaretciler = new List<string>()
{
    "Bülent Ersoy",
    "Ajda Pekkan",
    "Ebru Gündeş",
    "Hadise",
    "Hande Yener",
    "Tarkan",
    "Funda Arar",
    "Demet Akalın"
};

Console.WriteLine("**Davetliler**");
for (int i = 0; i < ziyaretciler.Count; i++)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{i+ 1}.");
    Console.ResetColor();
    Console.WriteLine( ziyaretciler[i]);
}
Console.ReadKey();