using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinXaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Somma_Clicked(object sender, EventArgs e)
        {
            int iPrimoNumero;
            int iSecondoNumero;

            if (!int.TryParse(primoNumero.Text, out iPrimoNumero))
            {
                totale.Text = "(n/a)";
                return;
            }

            if (!int.TryParse(secondoNumero.Text, out iSecondoNumero))
            {
                totale.Text = "(n/a)";
                return;
            }

            totale.Text = string.Format("{0}", iPrimoNumero + iSecondoNumero);
        }
    }
}
