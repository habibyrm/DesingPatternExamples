namespace DecoratorPattern
{
    public class Decorator : IRapor
    {
        protected IRapor _rapor;

        public Decorator(IRapor rapor)
        {
            _rapor = rapor;
        }

        public virtual void Yazdir(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException("content boş olamaz!");
            }

            _rapor.Yazdir(content);
        }
    }
}
