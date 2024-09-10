using ObserverPattern;
using ObserverPattern.Product;

IProduct tablet = new Tablet("Samsung Tab S9+", 17000);
IProduct telefon = new Phone("Samsung S23", 30000);

// Müşteri oluşturuluyor
Customer customer = new Customer("Mehmet");

// Sepet oluşturuluyor
Basket cart = new Basket();
cart.AddProduct(tablet);
cart.AddProduct(telefon);

// Müşteri ürünleri sepetine ekliyor
tablet.AddObserver(customer);
telefon.AddObserver(customer);

// Fiyat güncelleme
tablet.Price = 16000; // Hem sepet hem de müşteri bilgilendirilecek
Console.WriteLine(Environment.NewLine);
telefon.Price = 29000; // Hem sepet hem de müşteri bilgilendirilecek

// Toplam fiyatı hesapla
Console.WriteLine(Environment.NewLine);
Console.WriteLine($"Sepetin toplam fiyatı: {cart.GetTotalPrice()} TL");