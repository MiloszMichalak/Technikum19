using System;
using System.IO;

namespace Program
{
    class TestClass
    {
        public static bool czyPierwsza (int n)
        {
            bool flaga = true;
            for (int i = 1; i < (int)Math.Sqrt(n)+1; i++){
                if (n % i == 0){
                    flaga = false;
                }
            }
            return flaga;
        }
    
        public static void Main(String[] args)
        {

            // Zadanie 4.1

            StreamReader streamReaderInt = new StreamReader("liczby_przyklad.txt");
            StreamWriter streamWriterInt = new StreamWriter("wyniki4_1.txt");

            while (!streamReaderInt.EndOfStream) {
                int n = Convert.ToInt32(streamReaderInt.ReadLine());
                if (czyPierwsza(n)) {
                    streamWriterInt.WriteLine(n);
                }
            }
            streamReaderInt.Close();
            streamWriterInt.Close();
        }
    }
}
