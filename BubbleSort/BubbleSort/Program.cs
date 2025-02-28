using System;
namespace SortingExample
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Bubble Sort Algoritma Analizi

                1. Zaman Karmaşıklığı Analizi:
                   - En Kötü Durum (Ters Sıralı): O(n^2)
                   - En İyi Durum (Zaten Sıralı): O(n) (erken durma özelliği sayesinde)
                   - Ortalama Durum (Rastgele Sıralı): O(n^2)
                   - En kötü durumda karşılaştırma sayısı: (n(n-1))/2 ≈ O(n^2)

                2. Alan Karmaşıklığı:
                   - O(1) (Yerinde sıralama, sadece birkaç ek değişken kullanır)

                3. Kararlılık (Stability):
                   - Bubble Sort, eşit elemanların göreceli sırasını değiştirmediği için
                     kararlı (stable) bir sıralama algoritmasıdır.

                4. Uyarlanabilirlik:
                   - Eğer dizi zaten sıralıysa, erken durarak gereksiz işlemleri önler ve 
                     neredeyse sıralı veriler için daha verimli çalışır.

                5. Pratik Kullanım:
                   - Büyük veri kümeleri için verimli değildir.
                   - Daha iyi alternatifler: Insertion Sort (küçük veri kümeleri için), Quick Sort veya Merge Sort.
                   - Genellikle öğretim amaçlı kullanılır, gerçek dünya uygulamalarında tercih edilmez.

                Sonuç:
                   - Bubble Sort basit bir algoritmadır ancak büyük veri kümeleri için verimsizdir.
                   - En iyi durumda O(n) performansı sayesinde, neredeyse sıralı veriler için kullanılabilir.
            */


            int[] number = { 12,45,13,52,46,76,98,100,23,51,41,52 };
            bool flag = true;
            int temp;
            int numLength = number.Length;

            //sorting an array
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            //Sorted array
            foreach (int num in number)
            {
                Console.Write("\t {0}", num);
            }
            Console.Read();
        }
    }
}