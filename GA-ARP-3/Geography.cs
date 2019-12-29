using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ARP_3
{
    public static class Geography
    {
        const double R = 6371000; // m
        const double Rad2Deg = 180.0 / Math.PI;
        const double Deg2Rad = Math.PI / 180.0;

        public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {

            double dLat = (lat2 - lat1) / 180.0 * Math.PI;

            double dLon = (lon2 - lon1) / 180.0 * Math.PI;

            double a = Math.Sin(dLat / 2.0) * Math.Sin(dLat / 2.0) +
                    Math.Sin(dLon / 2.0) * Math.Sin(dLon / 2.0) * Math.Cos(lat1 / 180.0 * Math.PI) * Math.Cos(lat2 / 180.0 * Math.PI);
            double c = 2.0 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1.0 - a));
            return R * c;
        }

        public static double AciHesapla(double x, double y)
        {
            double result = Math.Atan2(-1 * y, x) * Rad2Deg;
            result = Math.Abs(result);
            if ((x < 0 && y < 0) || (x > 0 && y < 0))
                result = 360 - result;

            return result;
        }

        public static string SwapCharacters(string value, int position1, int position2)
        {
            //
            // Swaps characters in a string. Must copy the characters and reallocate the string.
            //
            char[] array = value.ToCharArray(); // Get characters
            char temp = array[position1]; // Get temporary copy of character
            array[position1] = array[position2]; // Assign element
            array[position2] = temp; // Assign element
            return new string(array); // Return string
        }
        public static double AmaçFonkHesapla(int MüşteriSayısı, int[] Çözüm, double[,] Uzaklık)
        {
            int i, Müş1, Müş2;
            double Sonuç = 0;
            for (i = 0; i < MüşteriSayısı - 1; i++)
            {
                Müş1 = Çözüm[i];
                Müş2 = Çözüm[i + 1];
                Sonuç += Uzaklık[Müş1, Müş2];
            }
            Müş1 = Çözüm[Çözüm.Length - 1];
            Müş2 = Çözüm[0];
            Sonuç += Uzaklık[Müş1, Müş2];
            return Sonuç;
        }
    }
}

