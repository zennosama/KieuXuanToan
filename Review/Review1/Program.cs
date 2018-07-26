using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    class Program
    {
        static void Main(string[] args)
        {
            // data source
            string[] names = {"Thanh", "Ha", "Dung", "Huowng", "Linh","Ngoc" };
            // query
            IEnumerable<string> result = from n in names select n;

            // read result
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
