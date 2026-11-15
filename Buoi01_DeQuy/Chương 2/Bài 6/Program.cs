using System;
using System.Diagnostics;

class Bài_6
{
    // Giải thuật 1: Sắp xếp nổi bọt (Bubble Sort) - Đơn giản, dễ hiểu
    static void BubbleSort(double[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    double temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Giải thuật 2: Sắp xếp chọn (Selection Sort) - Cải thiện hơn Bubble Sort một chút
    static void SelectionSort(double[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            double temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double[] originalArr = { 5, 6, 7, 8, 9, 10, 22, 12, 99, 4, 3};

        double[] arr1 = (double[])originalArr.Clone(); 
        Stopwatch sw1 = Stopwatch.StartNew();
        BubbleSort(arr1);
        sw1.Stop();

        Console.WriteLine("Mảng sau khi sắp xếp (Bubble Sort):");
        Console.WriteLine(string.Join(", ", arr1));
        Console.WriteLine($"=> Thời gian chạy Bubble Sort: {sw1.Elapsed.TotalMilliseconds} ms\n");

        double[] arr2 = (double[])originalArr.Clone();
        Stopwatch sw2 = Stopwatch.StartNew();
        SelectionSort(arr2);
        sw2.Stop();

        Console.WriteLine("Mảng sau khi sắp xếp (Selection Sort):");
        Console.WriteLine(string.Join(", ", arr2));
        Console.WriteLine($"=> Thời gian chạy Selection Sort: {sw2.Elapsed.TotalMilliseconds} ms");
    }
}