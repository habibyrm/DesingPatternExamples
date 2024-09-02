namespace DecoratorPattern.Property
{
    public class CizgiliRapor : Decorator
    {
        public CizgiliRapor(IRapor rapor) : base(rapor) { }

        public override void Yazdir(string icerik)
        {
            string[] satirlar = icerik.Split('\n');
            string cizgiliIcerik = string.Join("\n", satirlar.Select(s => "- " + s));

            base.Yazdir(cizgiliIcerik);
        }
    }
}
