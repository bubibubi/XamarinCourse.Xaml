using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinXaml
{
    public partial class ScrollViewSample : ContentPage
    {
        public ScrollViewSample()
        {
            InitializeComponent();
            MyFamilyImage.Source = ImageSource.FromResource("XamarinXaml.MyFamily.jpg");
        }
    }
}
