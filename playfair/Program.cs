using System;

namespace playfair
{
    internal class Program
    {
        static void Main()
        {
            PlayfairKodolo playfair = new PlayfairKodolo("kulcstabla.txt");

            Console.Write($"6. feladat - Kérek egy nagybetűt: ");
            string resp = Console.ReadLine().ToUpper();
            Console.WriteLine($"A karakter sorának indexe: {playfair.SorIndex(char.Parse(resp))}" +
                $"\nA karakter oszlopának indexe: {playfair.OszlopIndex(char.Parse(resp))}");
            Console.Write($"8. feladat - Kérek egy karakterpárt: ");
            resp = Console.ReadLine().ToUpper();
            Console.WriteLine($"Kódolva: {playfair.KodolBetupar(resp)}");
            Console.ReadLine();
        }
    }
}
