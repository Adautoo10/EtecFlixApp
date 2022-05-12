using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtecFlixApp.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CapitaMarvel : ContentPage
    {
        public CapitaMarvel()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlixApp.img.Netflix.png");
            poster.Source = ImageSource.FromResource("EtecFlixApp.Posters.CapitaMarvel.jpg");

           
        }
    }
}