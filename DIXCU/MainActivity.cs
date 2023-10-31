using Android.Content.Res;
using Android.Webkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dixcu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            menuItems.Add(new MenuItem { Text = "Actividades", Icon = "activities" });
            menuItems.Add(new MenuItem { Text = "Juegos", Icon = "games" });
        }

        private void MenuItem_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var menuItem = (MenuItem)e.SelectedItem;

            if (menuItem.Text == "Actividades")
            {
                Navigation.PushAsync(new ActivitiesPage());
            }
            else if (menuItem.Text == "Juegos")
            {
                Navigation.PushAsync(new GamesPage());
            }
        }
    }
}
