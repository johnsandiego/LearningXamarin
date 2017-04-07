using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BangorSavingsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private int index = 0;
        private string[] quotes = new string[]
        {
            "An apple a day keeps the doctor away",
            "I have become death, destroyer of world",
            "I have a dream!"
        };
        public QuotesPage()
        {
            InitializeComponent();
            currentQuote.Text = quotes[index];
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            index++;
            if (index >= quotes.Length)
                index = 0;

            currentQuote.Text = quotes[index];
        }
    }
}
