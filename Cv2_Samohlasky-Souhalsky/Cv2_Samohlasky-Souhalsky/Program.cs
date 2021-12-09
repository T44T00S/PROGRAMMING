using System;

namespace Cv2_Samohlasky_Souhalsky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš větu: ");
            string jedna = Console.ReadLine();
            jedna.ToCharArray();
            char[] arr = { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú', 'A', 'E', 'I', 'O', 'U', 'Á', 'É', 'Í', 'Ó', 'Ú' };
            char[] arr2 = { 'ů', 'ě', 'y', 'ý' };
            int pocet = 0;
            int pocet2 = 0;
            int pocet3 = 0;
            int pocet4 = 0;
            string dva = jedna;
            string dva2 = jedna;
            dva.ToCharArray();
            bool tri = false;
            bool ctyri = false;
            bool pet = false;

            for (int i = 0; i < jedna.Length; i++)
            {
                tri = false;
                for (int l = 0; l < arr.Length; l++)
                {
                    if (jedna[i] == arr[l])
                    {
                        pocet++;
                        dva = dva.Remove(i, 1);
                        dva = dva.Insert(i, "Z");
                        tri = true;
                    }
                }

                for (int a = 0; a < arr2.Length; a++)
                {
                    if (jedna[i] == arr2[a])
                    {
                        pocet2++;
                        ctyri = true;
                    }
                }

                if (jedna[i] == ' ')
                {
                    pocet3++;
                    pet = true;
                }

                if (tri == false && ctyri == false && pet == false)
                {
                    dva2 = dva2.Remove(i, 1);
                    dva2 = dva2.Insert(i, "X");
                }
            }

            pocet4 = jedna.Length - pocet - pocet2 - pocet3;

            Console.WriteLine("Počet souhlasek: " + pocet3);
            Console.WriteLine("Počet samohlasek: " + pocet4);
            Console.WriteLine(dva);
            Console.WriteLine(dva2);
            Console.ReadLine();
        }

    }
}
