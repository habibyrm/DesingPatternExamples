namespace StrategyPattern2
{
    public class BubbleSort : ISorting
    {
        public void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Bubble Sort ile sıralandı: " + string.Join(", ", array));
        }
    }
}
