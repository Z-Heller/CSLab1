using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania1
{
    class Data
    {
        private DateTime data;

        public Data(DateTime data)
        {
            this.data = data;
        }

        public void DzisiajWypisz()
        {
            Console.WriteLine("Dzisiejsza data: " + data.ToString("d"));
        }

        public DateTime DodajTydzien()
        {
            return data.AddDays(7);
        }

        public DateTime OdejmijTydzien()
        {
            return data.AddDays(-7);
        }

    }
}
