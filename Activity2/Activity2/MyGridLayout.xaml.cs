using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Activity2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyGridLayout : ContentPage
    {
        public MyGridLayout()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Your Text",
                         entrytext.Text,
                         "OK");
        }
    }
}