using StartegyPattern;
using StartegyPattern.Strategies;

Navigation navigasyon = new Navigation();

string baslangic = "Ankara";
string bitis = "Sakarya";

Console.WriteLine("Lütfen bir rota hesaplama stratejisi seçiniz:");
Console.WriteLine("1. En Kısa Yol");
Console.WriteLine("2. En Hızlı Yol");
Console.WriteLine("3. Trafik Durumuna Göre");

int secim = Convert.ToInt32(Console.ReadLine());

switch (secim)
{
    case 1:
        navigasyon.SetRotaHesapla(new EnKisaYol());
        break;
    case 2:
        navigasyon.SetRotaHesapla(new EnHizliYol());
        break;
    case 3:
        navigasyon.SetRotaHesapla(new TrafikDurumu());
        break;
    default:
        Console.WriteLine("Geçersiz seçim! Varsayılan olarak En Kısa Yol seçildi.");
        navigasyon.SetRotaHesapla(new EnKisaYol());
        break;
}

navigasyon.RotaHesapla(baslangic, bitis);

Console.WriteLine("Rota hesaplama tamamlandı.");