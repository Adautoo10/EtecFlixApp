using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using EtecFlixApp.Filmes; 



namespace EtecFlixApp.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);


            logo.Source = ImageSource.FromResource("EtecFlixApp.Img.Netflix.png");


            btnCapitaMarvel.Source = ImageSource.FromResource("EtecFlixApp.Posters.CapitaMarvel.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("EtecFlixApp.Posters.PanteraNegra.jpg");
            btnShazam.Source = ImageSource.FromResource("EtecFlixApp.Posters.Shazam.jpg");
            btnAlladin.Source = ImageSource.FromResource("EtecFlixApp.Posters.Aladdin.jpg");

        }
        private async void Btn_Open_Alladin(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Alladin());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops...Ocorreu um erro", ex.Message.ToString(), "Ok");
            }
        }

        private async void Btn_Open_CapitaMarvel(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CapitaMarvel());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops...Ocorreu um erro", ex.Message.ToString(), "Ok");
            }
        }

        private async void Btn_Open_PanteraNegra(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new PanteraNegra());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops...Ocorreu um erro", ex.Message.ToString(), "Ok");
            }
        }

        private async void Btn_Open_Shazam(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Shazam());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops...Ocorreu um erro", ex.Message.ToString(), "Ok");
            }
        }
    }
}











        