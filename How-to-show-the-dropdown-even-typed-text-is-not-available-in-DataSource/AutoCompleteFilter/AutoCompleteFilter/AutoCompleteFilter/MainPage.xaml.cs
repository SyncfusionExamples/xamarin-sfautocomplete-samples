using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoCompleteFilter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            autoComplete.Filter = ContainingSpaceFilter;
        }

        public bool ContainingSpaceFilter(string search, object item)
        {
            return true;
        }
    }
}
