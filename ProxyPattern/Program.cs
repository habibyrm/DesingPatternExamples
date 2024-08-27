using ProxyPattern.ControlledAccess;
using ProxyPattern.LazyLoading;
using ProxyPattern.Protection;
using ProxyPattern.RemoteAccess;

//COTROLLED ACCESS PROXY
Console.WriteLine("Controlled access proxy\n");
IDatabase database = new Database();
DatabaseProxy databaseProxy = new DatabaseProxy(database, isAuthorized: true);
Console.WriteLine("Yetkili kullanıcı:");
databaseProxy.RunQuery("SELECT * FROM Kullanicilar\n");

DatabaseProxy yetkisizVeritabani = new DatabaseProxy(database, isAuthorized: false);
Console.WriteLine("Yetkisiz kullanıcı:");
yetkisizVeritabani.RunQuery("DELETE FROM Kullanicilar");

//----------------------------------
//LAZY LOADING PROXY
Console.WriteLine("\n");
Console.WriteLine("Lazy loading proxy\n");
BigDataProxy bigDataProxy = new BigDataProxy();
// İlk çağrıda dosya yüklenecek
bigDataProxy.Process();
/* İkinci çağrıda dosya tekrar yüklenmeyecek
 vekil nesne kullanılacak*/
bigDataProxy.Process();

//--------------------------------------
//PROTECTION PROXY
Console.WriteLine("\n");
Console.WriteLine("Protection proxy\n");
IFileProcess process = new FileProcess();
FileProcessProxy dosyaProxy = new FileProcessProxy(process,isAuthorized: true);
dosyaProxy.DeleteFile("onemli_belge.txt");

FileProcessProxy yetkisizDosyaProxy = new FileProcessProxy(process,isAuthorized: false);
yetkisizDosyaProxy.DeleteFile("onemli_belge.txt");

//--------------------------------------
//REMOTE ACCESS PROXY
Console.WriteLine("\n");
Console.WriteLine("Remote access proxy\n");
RemoteServerProxy sunucuProxy = new RemoteServerProxy();
sunucuProxy.GetData();