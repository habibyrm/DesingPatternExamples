using BuilderPattern;
using BuilderPattern.Builder;

IEvBuilder builder = new SomutEvBuilder();
Yonetici yonetici = new Yonetici(builder);

// Minimal Ev
yonetici.MinimalEvYap();
Ev minimalEv = builder.EviAl();
Console.WriteLine("Minimal Ev:");
Console.WriteLine(minimalEv);

// Tam Donanımlı Ev
builder = new SomutEvBuilder(); // Yeni bir builder gerekli
yonetici = new Yonetici(builder);
yonetici.TamDonanimliEvYap();
Ev tamDonanimliEv = builder.EviAl();
Console.WriteLine("Tam Donanımlı Ev:");
Console.WriteLine(tamDonanimliEv);