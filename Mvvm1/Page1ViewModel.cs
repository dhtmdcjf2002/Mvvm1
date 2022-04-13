using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm1
{
    class Page1ViewModel : Notifier
    {
        private decimal euros;

        public decimal Euros
        {
            get { return euros; }
            set
            {
                euros = value;
                OnPropertyChanged("Euros");
                OnEurosChanged();  
            }
        }

        private void OnEurosChanged()
        {
            Dollars = Euros * 1.1M;
        }

        private decimal dollars;

        public decimal Dollars
        {
            get { return dollars; }
            set {
                dollars = value;
                OnPropertyChanged("Dollars");
            }

        }
    }
}

