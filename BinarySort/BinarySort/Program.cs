using System;

class BinaryInsertionSort
{

    /*
        Binary Insertion Sort Algorithm Analysis

        1. Zaman Karmaşıklığı Analizi:
           - En Kötü Durum (Ters Sıralı): 
             - Binary Search: O(log n) (her eleman için)
             - Eleman Kaydırma: O(n) (her eleman için)
             - Toplam: O(n²)
           - En İyi Durum (Zaten Sıralı):
             - Binary Search: O(log n) (her eleman için)
             - Eleman Kaydırma: O(1) (minimum kaydırma)
             - Toplam: O(n log n)
           - Ortalama Durum (Rastgele Sıralı):
             - Binary Search: O(log n) (her eleman için)
             - Eleman Kaydırma: O(n) (ortalama kaydırma)
             - Toplam: O(n²)

        2. Alan Karmaşıklığı:
           - O(1) (Ekstra bellek gerektirmez, yerinde sıralama yapar)

        3. Kararlılık (Stability):
           - Kararlı (Stable) bir sıralama algoritmasıdır. 
             - Eşit değerli elemanların sırası korunur.

        4. Uyarlanabilirlik:
           - Neredeyse sıralı diziler için O(n log n)** sürede çalışabilir.
           - Normal Insertion Sort’tan daha az karşılaştırma yapar.

        5. Pratik Kullanım:
           - Büyük veri kümeleri için verimli değildir** çünkü hala O(n²) karmaşıklığa sahiptir.
           - Ancak, normal Insertion Sort’a göre **daha az karşılaştırma** yapar.
           - Küçük veya **neredeyse sıralı diziler için tercih edilebilir**.

        Sonuç:
           - Binary Insertion Sort, karşılaştırma sayısını O(log n)’e düşürse de, eleman kaydırmaları nedeniyle hala O(n²) çalışır.
           - Daha iyi alternatifler:** Merge Sort (O(n log n)), Quick Sort (ortalama O(n log n)).
           - En iyi kullanım alanı:** Küçük veya büyük ölçüde sıralı veri kümeleri.
    */


    static int BinarySearch(int[] arr, int item, int low, int high)
    {
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == item)
                return mid + 1; // If the item is found, insert it after

            if (arr[mid] < item)
                low = mid + 1; // Search in the right half
            else
                high = mid - 1; // Search in the left half
        }
        return low; 
    }

    static void BinaryInsertionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            int loc = BinarySearch(arr, key, 0, j);

            while (j >= loc)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key; 
        }
    }

    static void Main()
    {
        int[] arr = { 37, 23, 17, 89, 56, 12, 72 };
        Console.WriteLine("Original Array: " + string.Join(", ", arr));

        BinaryInsertionSortAlgorithm(arr);

        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));
    }
}
