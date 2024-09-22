/*Üst seviyedeki modüller, alt seviyedeki modüllere bağımlı olmamalıdır. 
 * Her ikisi de soyutlamalara (interfacelere veya abstract class'lara) bağımlı olmalıdır.
 * Soyutlamalar, detaylara bağımlı olmamalıdır. Detaylar, soyutlamalara bağımlı olmalıdır.*/
// Bir web programının belirli bir veritabanına bağımlı kalması sorununu dependency inversion ile çözme.

using DependencyInversion.GoodExample;

IProductRepository productSqlRepository = new SqlProductRepository();
IProductRepository productPostgreRepository = new PostgreSqlProductRepository();

ProductService productService = new ProductService(productSqlRepository);

productService.AddProduct("Laptop");
Console.WriteLine(productService.GetProduct(1));