namespace StrategyPattern2
{
    public class QuickSort : ISorting
    {
        public void Sort(int[] array)
        {
            QuickSorting(array, 0, array.Length - 1);
            Console.WriteLine("Quick Sort ile sıralandı: " + string.Join(", ", array));
        }

        private void QuickSorting(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSorting(array, low, pi - 1);
                QuickSorting(array, pi + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    // Swap
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            // Swap pivot
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            return i + 1;
        }
    }
}
