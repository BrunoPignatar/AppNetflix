﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMelhorQueNetflix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class esquadrao_suic : ContentPage
    {
        public esquadrao_suic()
        {
            InitializeComponent();
            img_filme.Source = ImageSource.FromResource("AppMelhorQueNetflix.Posters.Aventura.esquadrao_suicida.png");
            img_logo.Source = ImageSource.FromResource("AppMelhorQueNetflix.Img.imgnetflix.png");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' src='https://www.youtube.com/embed/UkFJ90ef4_I' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";

            visu.Source = htmlSource;
        }
    }
}