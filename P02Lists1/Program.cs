List<string>ziyaretciler = new List<string>() //Ziyaretçileri eklediğimiz listemiz
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
for (int i = 0; i < ziyaretciler.Count; i++) //listeleri for döngüsü ile ekrana yazdırıyoruz
{
    Console.ForegroundColor = ConsoleColor.Red; //yazımıza font color ekliyoruz.
    Console.Write($"{i+ 1}."); //sayilari 1 arttırarak listemizi sıralıyoruz.
    Console.ResetColor(); //isimlerde default renk kullanılmasını istediğimiz için renk kodunu resetliyoruz.
    Console.WriteLine( ziyaretciler[i]); // Listemizde olusturduğumuz elemanları döndürüyoruz.
}
Console.ReadKey();