using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using EtecFlixApp.Categorias;

namespace EtecFlixApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("EtecFlixApp.Img.Netflix.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Btn_Open_Aventura(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Aventura());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops...Ocorreu um erro", ex.Message.ToString(), "Ok");
            }
        }

        private async void Btn_Open_Comedia(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Comedia());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops...Ocorreu um erro", ex.Message.ToString(), "Ok");
            }
        }
        private async void Btn_Open_Drama(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Drama());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops...Ocorreu um erro", ex.Message.ToString(), "Ok");
            }
        }


        private async void Btn_Open_Terror(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Terror());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops...Ocorreu um erro", ex.Message.ToString(), "Ok");
            }
        }

            private async void Btn_Open_Acao(object sender, EventArgs e)
            {
                try
                {
                    await Navigation.PushAsync(new Drama());
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Ops...Ocorreu um erro", ex.Message.ToString(), "Ok");
                }
            }

            private async void Btn_Open_Documentario(object sender, EventArgs e)
            {
                try
                {
                    await Navigation.PushAsync(new Drama());
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Ops...Ocorreu um erro", ex.Message.ToString(), "Ok");
                }
            }

    }
}
            




                    