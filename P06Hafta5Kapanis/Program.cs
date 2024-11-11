using P06Hafta5Kapanis;
class program
{

    static void Main()
    {
        List<Araba> arabalar = new List<Araba>();  //arabaları ekliyeceğimiz listemiz oluşturuldu.

        while (true)
        {
            Console.Write("Araba üretmek ister misiniz?(e/h)"); //Kullanıcıya araba üretip isteyip istemediğini sorguluyoruz
            tekrargir:
            string cevap = Console.ReadLine().ToLower();

            baskaarabaolustur: //ödevde istendiği gibi kullanıcı ekstra bir araba girmek isterse 2.bir sorgu olmasın diye go to ile bu satıra aktarılıyoruz.
            if (cevap == "h") //h tuşuna bastığında istemediğini anlayıp programı sonlandırıyoruz.
            {
                break;
            }
            else if (cevap != "e") //Cevabı e olmadığında if sekmesinde h yi de elediğimiz için isteğimiz dışında bir giriş yapılmıştır
            {
                Console.WriteLine("Geçersiz bir cevap verdiniz.Lütfen e veya h şeklinde cevaplayınız");//kullanıcıya bir uyarı veriyoruz.
                goto tekrargir;
            }
            Araba yeniAraba = new Araba(); //yeni arabamuzun propertylerini oluşturuyoruz.

            Console.Write("Seri Numarası: ");
            yeniAraba.SeriNumarasi = Console.ReadLine();

            Console.Write("Marka: ");
            yeniAraba.Marka = Console.ReadLine();

            Console.Write("Model: ");
            yeniAraba.Model = Console.ReadLine();

            Console.Write("Renk: ");
            yeniAraba.Renk = Console.ReadLine();

        KapiSayisiGir:  
            Console.Write("Kapı Sayısı: ");
            if (int.TryParse(Console.ReadLine(), out int kapiSayisi)) //kapı sayısına int bir sayı girilip girilmediğini kontrol ediyoruz.
            {
                yeniAraba.KapiSayisi = kapiSayisi; //int girildiyse kapı sayısını oluşturuyoruz.
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sayısal bir değer giriniz."); //int bir sayı girilmediyse uyarı veriyoruz.
                goto KapiSayisiGir; //go to ile daha önce oluşturduğumuz etikete yönlendiriyoruz.
            }
            arabalar.Add(yeniAraba); //arabalar isimli listemize yeni arabamızı ekledik.

            Console.Write("Başka bir araba üretmek ister misiniz? (e/h): "); //kullanıcıya başka bir araba ekleyip eklememek isteğini sorguluyoruz.
            tekrargir3:
            string devam = Console.ReadLine().Trim().ToLower();
            if (devam == "h") // cevabı h ise programı sonlandırıyoruz.
            {
                break;
            }
            else if (devam != "e") //e veya h degilse uyarı veriyoruz.
            {
                Console.WriteLine("Geçersiz cevap! 'e' veya 'h' ile yanıt veriniz."); 
                goto tekrargir3; //cevap istediğimiz şekilde değil ise etiketlediğimiz kısma geri dönüyoruz.
            }
            else 
            {
                goto baskaarabaolustur; //etiketlediğimiz satıra geri dönüyoruz
            }

        }
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar) 
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}"); //arabalar listesine eklediğimiz arabaların marka ve seri numaralarını giriyoruz
        }
        Console.ReadKey();

    }
}