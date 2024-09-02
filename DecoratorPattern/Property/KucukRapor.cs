namespace DecoratorPattern.Property
{
    public class KucukRapor : Decorator
    {
        public KucukRapor(IRapor rapor) : base(rapor) { }

        public override void Yazdir(string content)
        {
            string[] satirlar = content.Split('\n');
            List<string> duzenlenmisSatirlar = new List<string>();

            foreach (var satir in satirlar)
            {
                int baslangic = 0;
                while (baslangic < satir.Length)
                {
                    // Satırı 20 karakterlik parçalara böl.
                    int uzunluk = Math.Min(20, satir.Length - baslangic);
                    duzenlenmisSatirlar.Add(satir.Substring(baslangic, uzunluk));
                    baslangic += uzunluk;
                }
            }

            string kucukIcerik = string.Join("\n", duzenlenmisSatirlar);

            base.Yazdir(kucukIcerik);
        }
    }
}
