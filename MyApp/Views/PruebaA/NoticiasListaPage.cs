using System;

using Xamarin.Forms;

namespace MyApp.Views.PruebaA
{
    public class NoticiasListaPage : ContentPage
    {
        public NoticiasListaPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

