//Bu ilke, bir sınıfın kullanmadığı metodları barındıran geniş bir arayüzü implemente etmesi durumunda yaşanacak sorunları çözmeyi amaçlar
using InterfaceSegregation.GoodExample;
//sadece GoodExample dosyasını kütüphane olarak kullandığım için isim çakışması yaşamadım

BasicUser basicUser = new BasicUser();
Console.WriteLine("BasicUser Permissions:");
basicUser.Read();
// basicUser.Write(); // Bu çalışmaz çünkü BasicUser'ın yazma yetkisi yok

// AdminUser tüm yetkilere sahip
AdminUser adminUser = new AdminUser();
Console.WriteLine("\nAdminUser Permissions:");
adminUser.Read();
adminUser.Write();
adminUser.Delete();