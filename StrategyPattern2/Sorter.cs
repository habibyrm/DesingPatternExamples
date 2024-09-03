namespace StrategyPattern2
{
    public class Sorter
    {
        private ISorting _sorting;

        // Strateji ayarlama
        public void SetSorting(ISorting sorting)
        {
            _sorting = sorting;
        }

        // Stratejiye göre sıralama yapma
        public void Sort(int[] array)
        {
            _sorting.Sort(array);
        }
    }
}
