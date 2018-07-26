using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review2
{
    class Stanff : IStanff, IComparable<Stanff>
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private double bonus;

        public double Bonus
        {
            get { return bonus; }
        }

        // Constructor default
        public Stanff()
        {

        }
        public Stanff(string id, string name, string address, double salary)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.salary = salary;
        }

        public void CaculateBonus()
        {
            if (salary > 200 && salary < 400)
                bonus = 20;
            else if (salary >= 400 && salary < 600)
                bonus = 50;
            else
                bonus = 100;
        }

        public int CompareTo(Stanff other)
        {
            if (this.salary > other.salary)
                return 1;
            else
                return -1;
        }

        public void Display()
        {
            Console.WriteLine("Id: "+ id);
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Address: "+ address);
            Console.WriteLine("Salary: "+ salary);
            Console.WriteLine("Bonus: "+ bonus);
        }

        public void InputData()
        {
            Console.WriteLine("Input ID: ");
            id = Console.ReadLine();
            Console.WriteLine("Input Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Input Address: ");
            address = Console.ReadLine();
            Console.WriteLine("Input Salary: ");
            salary = double.Parse(Console.ReadLine());
        }
    }
}
