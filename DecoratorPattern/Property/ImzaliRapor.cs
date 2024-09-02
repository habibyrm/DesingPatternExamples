namespace DecoratorPattern.Property
{
    public class ImzaliRapor : Decorator
    {
        public ImzaliRapor(IRapor rapor) : base(rapor) { }

        public override void Yazdir(string icerik)
        {
            base.Yazdir(icerik);

            Console.WriteLine("Bu rapor imzalı formattadır.");
        }
    }

}
