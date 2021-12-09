using System;

namespace Cv2_2_Samo_souhl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš větu: ");
            string veta = Console.ReadLine();

            int souhlasky = 0;
            int samohlasky = 0;

            char[] arr = { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú', 'A', 'E', 'I', 'O', 'U', 'Á', 'É', 'Í', 'Ó', 'Ú' };

            veta.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                foreach (var item in veta)
                {
                    if (item == arr[i])
                    {
                        int index = veta.IndexOf(arr[i]);

                        veta = veta.Remove(index, 1);
                        veta = veta.Insert(index, "Z");

                        samohlasky++;
                    }
                }
            }

            for (int i = 0; i < veta.Length; i++)
            {
                if (veta[i] != 'Z' && veta[i] != ' ')
                {
                    veta = veta.Remove(i, 1);
                    veta = veta.Insert(i, "X");

                    souhlasky++;
                }
            }

            Console.WriteLine("Počet samohlásek: " + samohlasky);
            Console.WriteLine("Počet souhlásek: " + souhlasky);

            Console.WriteLine(veta);

            Console.ReadKey();
        }
    }
}


