using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka1, angka2;
            char operatorMath;
            
            Console.WriteLine("=== KALKULATOR SEDERHANA ===");
            Console.Write("Masukkan angka pertama: ");
            angka1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan operator (+, -, *, /): ");
            operatorMath = Convert.ToChar(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            angka2 = Convert.ToInt32(Console.ReadLine());

            int hasil = Hitung(angka1, angka2, operatorMath);

            Console.WriteLine("Hasil dari " + angka1 + " " + operatorMath + " " + angka2 + " = " + hasil);
            Console.ReadLine();
        }

        static int Hitung(int angka1, int angka2, char operatorMath)
        {
            int hasil = 0;

            switch (operatorMath)
            {
                case '+':
                    hasil = Penambahan(angka1, angka2);
                    break;

                case '-':
                    hasil = Pengurangan(angka1, angka2);
                    break;

                case '*':
                    hasil = Perkalian(angka1, angka2);
                    break;

                case '/':
                    hasil = Pembagian(angka1, angka2);
                    break;

                default:
                    Console.WriteLine("Operator yang Anda masukkan salah!");
                    break;
            }

            return hasil;
        }

        static int Penambahan(int angka1, int angka2)
        {
            int hasil = angka1 + angka2;
            return hasil;
        }

        static int Pengurangan(int angka1, int angka2)
        {
            int hasil = angka1 - angka2;
            return hasil;
        }

        static int Perkalian(int angka1, int angka2)
        {
            int hasil = angka1 * angka2;
            return hasil;
        }

        static int Pembagian(int angka1, int angka2)
        {
            int hasil = angka1 / angka2;
            return hasil;
        }
    }
}
