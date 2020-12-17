using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srezKPandYP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = Reader.GetArray();

            foreach (var item in mas)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Reader.ReplaceOddElements(mas, 0);

            Reader.SaveToFile(mas, "out.txt");
        }
    }
}
