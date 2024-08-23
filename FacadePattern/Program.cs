using FacadePattern.Facade;

SiparisFacade siparisFacade = new SiparisFacade();

// Mevcut stok durumunu göster
siparisFacade.StokDurumunuGoster();
Console.WriteLine("\n");
decimal bakiye = 20000m; //müşterinin bakiyesi

// Sipariş işleme: Ürün Id: 101, Miktar: 2
siparisFacade.SiparisiIsle(101, 2, bakiye);

Console.WriteLine("\n");
// Sipariş sonrası stok durumunu göster
siparisFacade.StokDurumunuGoster();

Console.ReadLine();
