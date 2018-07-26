using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stanff> dataSource = new List<Stanff>();
            int choose;
            int n;
            do
            {
                Console.WriteLine("1. Input Data");
                Console.WriteLine("2. Show Data");
                Console.WriteLine("3. Caculate Bonus");
                Console.WriteLine("4. Sort");
                Console.WriteLine("5. Exit");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Input n: ");
                        n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Stanff s = new Stanff();
                            s.InputData();
                            dataSource.Add(s);
                        }
                        break;
                    case 2:
                        foreach (var item in dataSource)
                        {
                            item.Display();
                        }
                        break;
                    case 3:
                        foreach (var item in dataSource)
                        {
                            item.CaculateBonus();
                        }
                        foreach (var item in dataSource)
                        {
                            item.Display();
                        }
                        break;
                    case 4:
                        //dataSource.Sort();
                        var lts = dataSource.OrderBy(x => x.Salary);

                        foreach (var item in lts)
                        {
                            item.Display();
                        }
                        break;
                    case 5:
                        break;
                }
            } while (choose != 5);

        }
    }
}
