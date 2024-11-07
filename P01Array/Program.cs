int[] Sayilar = new int[10];            //10 elemana sahip oluşturduğumuz liste
Console.WriteLine("Diziye 10 adet sayi giriniz: ");

for (int i = 0; i < Sayilar.Length; i++)        //For döngüsüyle 0 dan başlayarak elemanları kullanıcıya yazdırıyoruz.
{
    Console.Write($"Sayı[{i}] =");
    Sayilar[i] = int.Parse(Console.ReadLine());

}
Console.Clear();       //yazdırdıkdan sonra ekranı temizledik

foreach (var a in Sayilar)      //foreach ile dizi elemanlarını ekrana yazdırdık.
{
    Console.WriteLine(a);

}

Console.Clear();
Console.WriteLine("Dizimize 11.Elemanı Ekleyiniz:"); //11. elemanımızı ekliyoruz
int yeniSayi = int.Parse(Console.ReadLine());

int[] yeniSayilar = new int[Sayilar.Length + 1];


for (int i = 0; i < Sayilar.Length; i++)
{
    yeniSayilar[i] = Sayilar[i];
}
yeniSayilar[yeniSayilar.Length - 1] = yeniSayi;

Array.Sort(yeniSayilar);
Array.Reverse(yeniSayilar);

Console.WriteLine("\nDizinin Büyükten Küçüğe Sıralı Hali:");
foreach (var b in yeniSayilar)
{
    Console.WriteLine(b);
}

Console.ReadKey();