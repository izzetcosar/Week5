List<string>kahveler = new List<string>();   //kahveler adında bir liste oluşturduk
Console.WriteLine("Lütfen Sevdiğiniz Kahveleri Giriniz: ");

for (int i = 0; i < 5; i++)  //For döngüsü ile kullanıcıdan sırasıyla sevdiği kahveleri istiyoruz
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"Kahve {i + 1}:"); //liste sırasını 1 arttırarak yazdırıyoruz.
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    string kahve = Console.ReadLine(); //kullanıcıdan kahvesini yazdırıyoruz
    kahveler.Add( kahve );
    Console.ResetColor();
}
Console.WriteLine("Favori Kahveleriniz:"); 
foreach(var kahve in kahveler)      //foreach ile olusturduğunuz listemizi yazdırıyoruz
{
    Console.WriteLine(kahve);
}