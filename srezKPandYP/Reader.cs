using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srezKPandYP
{
    class Reader
    {
        public static int MasSize { get; set; }
        public static int[] GetArray()
        {   
            MasSize = int.Parse(File.ReadAllLines("in.txt").First());
            int[] mas = new int[MasSize];

            int iter = 0;
            foreach (var item in File.ReadAllLines("in.txt").Skip(1))
            {
                mas[iter] = int.Parse(item);
                iter++;
            }

            return mas;
        }

        public static void ReplaceOddElements(int[] mas, int value)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 != 0)
                {
                    mas[i] = value;
                }
            }
        }

        public static void SaveToFile(int[] mas, string path)
        {
            string[] mass = new string[MasSize];
            for (int i = 0; i < mas.Length; i++)
            {
                mass[i] = mas[i].ToString();
            }
            File.WriteAllLines(path, mass);
        }
    }
}
