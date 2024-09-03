namespace StrategyPattern2
{
    public class SelectionSort : ISorting
    {
        public void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }

            Console.WriteLine("Selection Sort ile sıralandı: " + string.Join(", ", array));
        }
    }
}
