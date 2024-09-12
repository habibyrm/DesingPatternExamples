using MediatorPattern2.ConcreteMediator;
using MediatorPattern2;

IMediator mediator = new OfficeMediator();

Employee ali = new Employee(mediator, "Ali");
Employee ayşe = new Employee(mediator, "Ayşe");
Employee mehmet = new Employee(mediator, "Mehmet");

ali.SendMessage("Merhaba Ayşe, toplantı saat 14:00'te.", "Ayşe");
Console.WriteLine(Environment.NewLine);

ayşe.SendMessage("Tamam Ali, orada olacağım.", "Ali");
Console.WriteLine(Environment.NewLine);

mehmet.SendMessage("Ali, raporları hazırladın mı?", "Ali");
Console.WriteLine(Environment.NewLine);

// Olmayan bir çalışana mesaj gönderme denemesi
ali.SendMessage("Merhaba", "Zeynep");
//Birden fazla kişiye aynı anda mesaj gönderme
ali.SendMessage("Merhaba", "Ayşe", "Mehmet");
