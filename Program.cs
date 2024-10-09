int sekil = 0;
int alan = 0;
double pi = 3.14;
int kisaYadaTaban = 0;
int uzunYadaYukseklik = 0;

programBilgi();
sekilSec();
ekranaYaz(alanHesapla(sekil), cevreHesapla(sekil));

void mesaj(string mesaj, ConsoleColor onrek = ConsoleColor.Gray)
{
    Console.ForegroundColor = onrek;
    Console.WriteLine(mesaj);
    Console.ForegroundColor = ConsoleColor.Gray;
}

void programBilgi()
{
    Console.WriteLine("Alan ve Çevre Hesaplama Programı");
}

void sekilSec()
{
    Console.Write("Lütfen İşlem için bir şekil seçin: (1 - Dikdörtgen, 2 - Daire, 3 - Kare, 4 - Üçgen) => ");
    sekil = Convert.ToInt32(Console.ReadLine());
}

int sGir(int sayi = 0, string metin = "")
{
    Console.Write((sayi == 0 ? "" : sayi + ". "));
    Console.Write((metin == string.Empty ? "Alanı Girin" : metin));
    Console.Write(" => ");

    return Convert.ToInt32(Console.ReadLine());
}

double alanHesapla(int sekil)
{
    switch (sekil)
    {
        case 1:
            kisaYadaTaban = sGir(1, "Kısa Kenar");
            uzunYadaYukseklik = sGir(2, "Uzun Kenar");
            return kisaYadaTaban * uzunYadaYukseklik;
        break;

        case 2: alan = sGir(); return pi * alan * alan; break;
        case 3: alan = sGir(); return alan * alan; break;

        case 4:
        kisaYadaTaban = sGir();
        uzunYadaYukseklik = sGir();
        return kisaYadaTaban * uzunYadaYukseklik / 2; 
        break;

        default: return 0; break;
    }
}

double cevreHesapla(int sekil)
{
    switch (sekil)
    {
        case 1: return (kisaYadaTaban * uzunYadaYukseklik) * 2; break;
        case 2: return 2 * pi * alan; break;
        case 3: return pi * alan * 2; break;
        case 4: return kisaYadaTaban + uzunYadaYukseklik; break;
        default: return 0; break;
    }
}

void ekranaYaz(double alan, double cevre)
{
    Console.Write($"Alan:  ");
    mesaj(Convert.ToString(alan), ConsoleColor.Green);

    Console.Write($"Çevre: ");
    mesaj(Convert.ToString(cevre), ConsoleColor.Green);
}
