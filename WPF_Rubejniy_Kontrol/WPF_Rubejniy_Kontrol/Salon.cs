using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Rubejniy_Kontrol
{
    class Salon
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public int Price { get; set; }
        public int Sale { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 0;
            else if (Price > ((Salon)obj).Price) return 1;
            return -1;
        }

    }
}
