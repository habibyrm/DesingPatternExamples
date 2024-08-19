using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Method3();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace.ToString());
                Console.ReadKey();
            }

            Console.ReadLine();



            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace.ToString());
                Console.ReadKey();
            }

            Console.ReadLine();
        }

        private static void Method3()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                //throw ex stack trace resetler.Hata Method 1 oluşmuştur fakat oluştuğu yeri kaybederek yazıyor. Hatanın nerde olduğu açıklayıcı değildir.
                throw ex;
            }
        }

        private static void Method2()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                //throw stack trace korur. Hata Method 1 oluşturulmuştur. Yazarken ilk hatayı oluşturduğu yerden itibaren yazar.
                throw;
            }
        }

        private static void Method1()
        {
            try
            {
                throw new Exception("Inside Method1");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

