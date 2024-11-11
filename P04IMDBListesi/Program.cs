using System;
using System.Collections.Generic;
using System.Linq;

class Film
{
    public string Isim { get; set; }
    public double ImdbPuani { get; set; }

    public Film(string isim, double imdbPuani)
    {
        Isim = isim;
        ImdbPuani = imdbPuani;
    }
}

class Program
{
    static void Main()
    {
        List<Film> filmler = FilmEkle();

        // Bütün filmleri listele
        TumFilmleriListele(filmler);

        // IMDb puanı 4 ile 9 arasında olan filmleri listele
        ImdbPuaniArasindaFilmleriListele(filmler);

        // 'A' harfi ile başlayan filmleri listele
        AileBaslayanFilmleriListele(filmler);
    }

    static List<Film> FilmEkle()
    {
        List<Film> filmler = new List<Film>();

        while (true)
        {
            // Film adı ve IMDb puanı iste
            Console.Write("Film adını girin: ");
            string isim = Console.ReadLine();

            Console.Write("IMDb puanını girin: ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani))
            {
                Console.Write("Lütfen geçerli bir IMDb puanı girin: ");
            }

            // Yeni Film nesnesi oluştur ve listeye ekle
            Film film = new Film(isim, imdbPuani);
            filmler.Add(film);

            // Kullanıcıya başka film eklemek isteyip istemediğini sor
            Console.Write("Başka bir film eklemek ister misiniz? (evet/hayır): ");
            string devamMi = Console.ReadLine().Trim().ToLower();
            if (devamMi != "evet")
            {
                Console.WriteLine("Teşekkürler listeledğiniz filmlerin sıralaması yapılıyor.");
                break;
            }
        }

        return filmler;
    }

    static void TumFilmleriListele(List<Film> filmler)
    {
        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmler)
        {
            Console.WriteLine($"{film.Isim} - IMDb: {film.ImdbPuani}");
        }
    }

    static void ImdbPuaniArasindaFilmleriListele(List<Film> filmler)
    {
        Console.WriteLine("\nIMDb Puanı 4 ile 9 Arasında Olan Filmler:");
        var filtreliFilmler = filmler.Where(f => f.ImdbPuani >= 4 && f.ImdbPuani <= 9);

        foreach (var film in filtreliFilmler)
        {
            Console.WriteLine($"{film.Isim} - IMDb: {film.ImdbPuani}");
        }
    }

    static void AileBaslayanFilmleriListele(List<Film> filmler)
    {
        Console.WriteLine("\n'A' Harfi ile Başlayan Filmler:");
        var aIleBaslayanlar = filmler.Where(f => f.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase));

        foreach (var film in aIleBaslayanlar)
        {
            Console.WriteLine($"{film.Isim} - IMDb: {film.ImdbPuani}");
        }
    }
    
}

