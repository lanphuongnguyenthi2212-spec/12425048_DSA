using System.Diagnostics;

namespace Bài_2
{
    internal class Program
    {
        static int LinearSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == key) return i;
            return -1;
        }

        static int BinarySearch(int[] arr, int key)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == key) return mid;
                else if (arr[mid] < key) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] sizes = { 10, 20, 30, 35, 40, 45 };
            int repeat = 35;

            Console.WriteLine("{0,12} {1,20} {2,20}", "n", "Tuần tự (ms)", "Nhị phân (ms)");

            foreach (int n in sizes)
            {
                int[] arr = new int[n];
                for (int i = 0; i < n; i++) arr[i] = i;

                int key = n - 1;

                Stopwatch sw = new Stopwatch();

                sw.Start();
                for (int r = 0; r < repeat; r++) LinearSearch(arr, key);
                sw.Stop();
                double tLinear = sw.Elapsed.TotalMilliseconds;

                sw.Restart();
                for (int r = 0; r < repeat; r++) BinarySearch(arr, key);
                sw.Stop();
                double tBinary = sw.Elapsed.TotalMilliseconds;

                Console.WriteLine("{0,12} {1,20:F4} {2,20:F4}", n, tLinear, tBinary);
            }
        }
    }
}