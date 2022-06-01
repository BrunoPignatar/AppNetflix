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
    public partial class Suspense : ContentPage
    {
        public Suspense()
        {
            InitializeComponent();

            btn_aforca.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.aforca.jpg");

            btn_ilhadomedo.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.ilhadomedo.jpg");

            btn_fuja.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.fuja.jpg");

            btn_vdevingança.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.vdevingança.jpg");
        }

        private async void btn_aforca_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.aforca());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_ilhadomedo_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.ilhadomedo());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_fuja_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.fuja());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void btn_vdevingança_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new AppMelhorQueNetflix.Filmes.vdevingança());

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}