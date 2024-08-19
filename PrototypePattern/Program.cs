using PrototypePattern;
/*Bu desing pattern artısı Factory ya da Abstract Factory kalıplarında kullanıldığı zaman var olan miras mekanizmasını kullanmadığı için
 her nesne için ayrı bir üretici sınıfı kullanmak yerine yeni nesneler sadece var olan prototipten üretilir.
Yani karmaşık nesnelerde Factory Method ve Abstract Factory nesne oluştururken 
Prototype kalıbını kullanılabilir.*/

Oyuncu asker1 = new Asker("Kırmızı", "Er", "Kara", "SAR9", "100");

// Asker bilgilerini göster.
Console.WriteLine("Orijinal  Bilgileri:");
asker1.BilgileriGoster();
Console.WriteLine("\n");


Oyuncu asker2 = (Asker)asker1.Klonla();
Console.WriteLine("Klonlanarak oluşturulan  bilgileri");
asker2.BilgileriGoster();
Console.WriteLine("\n");

asker2.TechizatDegistir("Benelli M4");
asker2.GucDegistir("175");

// Klonlananın bilgilerini göster.
Console.WriteLine("\nKlonlanan  Bilgileri (Teçhizat ve Güç Değiştirilmiş):");
asker2.BilgileriGoster();
Console.WriteLine("\n");


Oyuncu asker3 = asker1.Klonla();
asker3.RutbeDegistir("Üst Teğmen");
asker3.TechizatDegistir("Uzi");
asker3.GucDegistir("255");
asker3.BilgileriGoster();