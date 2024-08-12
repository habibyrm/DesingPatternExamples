namespace AbstractFactoryPattern.Interface
{
    //Bu sınıf abstract factorydir
    public abstract class Tasit
    {
        //Bu metodlarda factory metoddur.
        public abstract IAraba CreateAraba();
        public abstract IBisiklet CreateBisiklet();
    }
}
