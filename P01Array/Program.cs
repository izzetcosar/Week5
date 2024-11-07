int[] Sayilar = new int[10];            //10 elemana sahip oluşturduğumuz liste
Console.WriteLine("Diziye 10 adet sayi giriniz: ");

for (int i = 0; i < Sayilar.Length; i++)        //For döngüsüyle 0 dan başlayarak elemanları kullanıcıya yazdırıyoruz.
{
    Console.Write($"Sayı[{i}] =");          
    Sayilar[i] = int.Parse(Console.ReadLine());

}
Console.Clear();        //yazdırdıkdan sonra ekranı temizledik
foreach (var a in Sayilar)      //foreach ile dizi elemanlarını ekrana yazdırdık.
{
    Console.WriteLine(a);

}
Console.WriteLine("Dizimize 11.Elemanı Ekleyiniz:"); //11. elemanımızı ekliyoruz
int yeniDeger = int.Parse(Console.ReadLine());

List<int> sayiListesi = Sayilar.ToList(); 
sayiListesi.Add(yeniDeger);
Sayilar = sayiListesi.ToArray();

Array.Sort(Sayilar);        //sort ile sayılarımızı sıraladık
Array.Reverse(Sayilar);     //reserve komutuyla sıralamamızı tersine çevirdik.


Console.WriteLine("\nDizinin Büyükten Küçüğe Sıralı Hali:");
foreach (var eleman in Sayilar)
{
    Console.WriteLine(eleman);
}
Console.ReadKey();