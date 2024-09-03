using StrategyPattern2;

int[] numbers = { 64, 25, 12, 22, 11 };

Sorter sorter = new Sorter();

Console.WriteLine("Sıralama algoritmasını seçiniz:");
Console.WriteLine("1. Bubble Sort");
Console.WriteLine("2. Selection Sort");
Console.WriteLine("3. Quick Sort");

int secim = Convert.ToInt32(Console.ReadLine());

switch (secim)
{
    case 1:
        sorter.SetSorting(new BubbleSort());
        break;
    case 2:
        sorter.SetSorting(new SelectionSort());
        break;
    case 3:
        sorter.SetSorting(new QuickSort());
        break;
    default:
        Console.WriteLine("Geçersiz seçim! Varsayılan olarak Bubble Sort seçildi.");
        sorter.SetSorting(new BubbleSort());
        break;
}

Console.WriteLine("Orijinal Dizi: " + string.Join(", ", numbers));
sorter.Sort(numbers);