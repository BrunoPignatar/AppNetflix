using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMelhorQueNetflix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Acao : ContentPage
    {
        public Acao()
        {
            InitializeComponent();

            btn_alertavermelho.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.alertavermelho.jpg");

            btn_infiltrado.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.infiltrado.jpg");

            btn_venom.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.venom.jpg");

            btn_avengers.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.avengers.jpg");
            
        }

        private async void btn_alertavermelho_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.alertavermelho());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_infiltrado_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.infiltrado());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_venom_Clicked(object sender, EventArgs e)
        {
            try
            {
               await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.venom());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_avengers_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.avengers());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

       
    }
}