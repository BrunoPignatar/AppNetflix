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
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();
            img_logo.Source = ImageSource.FromResource("AppMelhorQueNetflix.Img.imgnetflix.png");

            btn_bigbug.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.bigbug.jpg");

            btn_tratamentodechoque.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.tratamento de choque.jpg");

            btn_gentegrande.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.gentegrande.jpg");

            btn_naoolheparacima.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.naoolheparacimajpg.jpg");

        }

        private async void btn_bigbug_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.bigbug());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

     

        private async void btn_tratamentodechoque_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.tratamentodechoque());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_gentegrande_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.gentegrande());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_naoolheparacima_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.naoolheparacima());
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
    
}