using System;
namespace PierwszyProgram
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Pierwszy program");
            Console.WriteLine("W jezyku C#");
            Console.WriteLine("Test");
            Console.WriteLine("C#");

            /*
            * Typy danych - ile bitow
            * int 16, 32, 64
            * byte 0-255 - (8 bitow => 1 bajt)
            * sbyte -128 do 127 (8 bitow => 1 bajt)
            * short -32768 do 32767 (16 bitow => 2 bajty)
            * ushort 0 do 65535 (16 bitow => 2 bajty)
            * int -2 147 483 648 do 2 147 483 647 (32 bity => 4 bajty)
            * uint 0 - 4 294 967 295 (32 bity => 4 bajty)

            * Na kartowke long jest niepotrzebny
            * long -9223372036854775808 do 9223372036854775807 (64 bity => 8 bajtow)
            * ulong 0 do 18 446 744 073 709 551 615(64 bity => 8 bajtów, 18 trylionów)
            *
            * bool (true or false) - ile bitów/bajtów
            * char U+0000 do U+FFFF (16 bitowy znak z tablicy unicode)
            * string ?
            *
            * float -3,4 * 10^38 do 3,4 * 10^38 (32 bajty => 4 bity)
            * double (64 bity => 8 bajtow)
            * decimal (128 bitów => 16 bajtów)
            */

            int i; //deklaracja zmiennej
            int i1 = 10; // deklaracje z jednoczesna inicjalizacja zmiennej i

            Console.WriteLine("Zmienna i wynosi: " + i1);

            System.Int32 i2 = 100;

            Console.WriteLine("Zmienna i1 wynosi:  {0}, zmienna i2 wynosi:  {1}", i1, i2);
            Console.WriteLine($"Zmienna i1 wynosi: {i1}, zmienna i2 wynosi: {i2}");

            byte b = 10;
            sbyte sb = -10;
            short s = -20000;

            // Wszystkie zapisy oznaczaja to samo
            int incior = 2200000;
            Int32 takiInt = 10;
            System.Int32 jeszczeInny = 299;

            long l = -10L; //suffix L
            ulong ul = 10UL; // suffix UL
            
            Console.WriteLine("Zmienna l: {0}, zmienna ul: {1}", l, ul);

            float f = 10.5F; // suffix F
            
            

            Console.ReadKey();

        }
    }
}

