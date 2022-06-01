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
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();

          btn_meupai.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.meupai.jpg");

          btn_ourocobiça.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.ourocobiça.jpg");

          btn_regresso.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.regresso.jpg");

          btn_coda.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.coda.jpg");
        }

        private async void btn_meupai_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.meupai());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_ourocobiça_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.ourocobiça());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_regresso_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.regresso());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_coda_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.coda());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}