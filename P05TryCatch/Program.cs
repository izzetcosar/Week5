using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int kare = sayi * sayi;
            Console.WriteLine("Girdiğiniz sayının karesi: " + kare);
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş!");
        }
        Console.ReadKey();
    }
    
}
