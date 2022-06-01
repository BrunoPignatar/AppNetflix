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
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();

            btn_panico.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.panico.jpg");

            btn_tempo.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.tempo.jpg");

            btn_umma.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.umma.jpg");

            btn_chucky.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.chucky.jpg");
        }

        private async void btn_panico_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.panico());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_tempo_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.tempo());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_umma_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.umma());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_chucky_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.chucky());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}