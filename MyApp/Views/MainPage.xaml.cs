using MyApp.Models;
using MyApp.Views.PruebaA;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new NoticiasListaPage()));
                        break;
                    case (int)MenuItemType.Message:
                        MenuPages.Add(id, new NavigationPage(new DevPage()));
                        break;
                    case (int)MenuItemType.Notification:
                        MenuPages.Add(id, new NavigationPage(new DevPage()));
                        break;
                    case (int)MenuItemType.Photo:
                        MenuPages.Add(id, new NavigationPage(new DevPage()));
                        break;
                    case (int)MenuItemType.Video:
                        MenuPages.Add(id, new NavigationPage(new DevPage()));
                        break;
                    case (int)MenuItemType.Location:
                        MenuPages.Add(id, new NavigationPage(new DevPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AcercaPage()));
                        break;
                    case (int)MenuItemType.Search:
                        MenuPages.Add(id, new NavigationPage(new DevPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}