namespace TepmlatePattern
{
    public abstract class Worker
    {
        // Template Method
        public void DailyRoutine()
        {
            WakeUp();
            EatBreakfast();
            GoToWork();
            DoWork();
            ReturnToHome();
            Sleep();
        }

        // Common steps for all workers
        private void WakeUp()
        {
            Console.WriteLine("Waking up...");
        }

        private void EatBreakfast()
        {
            Console.WriteLine("Eating breakfast...");
        }

        private void GoToWork()
        {
            Console.WriteLine("Going to work...");
        }

        private void ReturnToHome()
        {
            Console.WriteLine("Returning home...");
        }

        private void Sleep()
        {
            Console.WriteLine("Sleeping...");
            Console.WriteLine("\n");
        }

        // Abstract method to be implemented by subclasses
        protected abstract void DoWork();
    }
}
