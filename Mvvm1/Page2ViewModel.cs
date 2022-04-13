using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm1
{
    class Page2ViewModel : Notifier
    {
        private decimal euros;

        public decimal Euros
        {
            get { return euros; }
            set { 
                euros = value;
                OnPropertyChanged("Euros");
                OnEurosChanged();
                
            }
        }

        private void OnEurosChanged()
        {
           ComputeConverted();
        }

        private decimal converted;

        public decimal Converted
        {
            get { return converted; }
            set { 
                converted = value;
                OnPropertyChanged("Converted");
            }
        }

        private string resultText;

        public string ResultText
        {
            get { return resultText; }
            set {
                resultText = value;
                OnPropertyChanged("ResultText");
            }
        }

        private IEnumerable<Currency> currencies;

        public IEnumerable<Currency> Currencies
        {
            get { return currencies; }
            set
            {
                currencies = value;
                OnPropertyChanged("Currencies");
            }
        }
        private Currency selectedCurrency;

        public Currency SeletedCurrency
        {
            get { return selectedCurrency; }
            set { 
                selectedCurrency = value;
                OnPropertyChanged("SelectedCurrency");
                OnSelectedCurrencyChanged();
            }
        }

        private void OnSelectedCurrencyChanged()
        {
           ComputeConverted();
        }

        private void ComputeConverted()
        {
            if (SeletedCurrency == null)
                return;
            Converted = Euros * SeletedCurrency.Rate;
            ResultText = string.Format("Amount in {0}", SeletedCurrency.Title);
        }

        public Page2ViewModel()
        {
            Currencies = new Currency[]
            {
                 new Currency("US Dollar", 1.1M),
                 new Currency("British Pound", 0.9M),
                 new Currency("Korea Won", 1.3M)
            };
        }


    }
}
