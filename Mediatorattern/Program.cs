using Mediatorattern;

IAirTrafficControlMediator controlTower = new AirTrafficControlTower();

Airplane airplane1 = new Airplane("Airplane 101", controlTower);
Airplane airplane2 = new Airplane("Airplane 202", controlTower);
Airplane airplane3 = new Airplane("Airplane 303", controlTower);

controlTower.RegisterAirplane(airplane1);
controlTower.RegisterAirplane(airplane2);
controlTower.RegisterAirplane(airplane3);

airplane1.Send("İnişe geçiyorum.");
Console.WriteLine(Environment.NewLine);
airplane2.Send("İniş için sıradayım.");