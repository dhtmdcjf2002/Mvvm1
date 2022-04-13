using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm1
{
    class Currency
    {
        public string Title { get; set; }
        public decimal Rate { get; set; }

        public Currency(string title, decimal rate)
        {
            Title = title;
            Rate = rate;
        }
    }
}
