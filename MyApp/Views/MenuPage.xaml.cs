using MyApp.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Explorar" },
                new HomeMenuItem {Id = MenuItemType.Message, Title="Mensages" },
                new HomeMenuItem {Id = MenuItemType.Notification, Title="Notificaciones" },
                new HomeMenuItem {Id = MenuItemType.Photo, Title="Fotos" },
                new HomeMenuItem {Id = MenuItemType.Video, Title="Videos" },
                new HomeMenuItem {Id = MenuItemType.Location, Title="Encuentranos" },
                new HomeMenuItem {Id = MenuItemType.About, Title="Acerca" },
                new HomeMenuItem {Id = MenuItemType.Search, Title="Buscador" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}