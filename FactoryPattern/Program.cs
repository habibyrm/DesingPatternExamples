using FactoryPattern.Factories;
using FactoryPattern.Interfaces;
using System.Data.Common;

//VeriTabaniFactory factory = new VeriTabaniFactory();

////
//IVeriTabani sqlConnection = factory.CreateConnection("sqlserver");
//sqlConnection.Connect();
//sqlConnection.Disconnect();
//Console.WriteLine("\n");

////
//IVeriTabani postgreConnection = factory.CreateConnection("postgresql");
//postgreConnection.Connect();
//postgreConnection.Disconnect();
//Console.WriteLine("\n");

////
//IVeriTabani mysqlConnection = factory.CreateConnection("mysql");
//mysqlConnection.Connect();
//mysqlConnection.Disconnect();
//Console.WriteLine("\n");



Console.WriteLine("Enter database türü: (PostgreSQL/MySQL/SQLServer):");
       string databaseType = Console.ReadLine();
       
       Console.WriteLine("Enter server:");
       string server = Console.ReadLine();
       
       Console.WriteLine("Enter database:");
       string databaseName = Console.ReadLine();
       
       Console.WriteLine("Enter user ID:");
       string userId = Console.ReadLine();
       
       Console.WriteLine("Enter password:");
       string password = Console.ReadLine();
       
       try
       {
           IVeriTabani db = VeriTabaniFactory.CreateDatabase(databaseType, server, databaseName, userId, password);
           DbConnection connection = db.CreateConnection();
           Console.WriteLine("Connection string: " + connection.ConnectionString);
           // connection.Open(); // Açmak için kullanılabilir.
           Console.WriteLine("Bağlantı başarıyla oluşturuldu!");
            
       }
       catch (Exception ex)
       {
           Console.WriteLine("Hata: " + ex.Message);
       }       