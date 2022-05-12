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
    public partial class PanteraNegra : ContentPage
    {
        public PanteraNegra()
        {
            

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtecFlixApp.img.Netflix.png");
            poster.Source = ImageSource.FromResource("EtecFlixApp.Posters.PanteraNegra.jpg");

            
        }
    }
}