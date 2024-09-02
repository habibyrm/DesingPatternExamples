using DecoratorPattern.Property;
using DecoratorPattern;

string content = "Bu bir test raporudur.\nBu satır uzunluğu 20 karakterden fazladır.\nKısa.";

// Temel düz raporu oluştur
IRapor rapor = new Rapor();

Console.WriteLine("Orijinal rapor ");
rapor.Yazdir(content);
Console.WriteLine(Environment.NewLine);

// Çizgili formatı ekle
Console.WriteLine("Çizgili rapor formatı.");
rapor = new CizgiliRapor(rapor);
rapor.Yazdir(content);
Console.WriteLine(Environment.NewLine);

// İmzalı formatı ekle
Console.WriteLine("İmzalı rapor formatı. ");
rapor = new ImzaliRapor(rapor);
rapor.Yazdir(content);
Console.WriteLine(Environment.NewLine);

// Küçük formatı ekle
Console.WriteLine("Küçük rapor formatı. ");
rapor = new KucukRapor(rapor);
rapor.Yazdir(content);

// Raporu yazdır
//rapor.Yazdir(icerik);