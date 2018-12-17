using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectV1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Populates table with data from SQLite
        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Player>();

                var players = conn.Table<Player>().ToList();
                playersListView.ItemsSource = players;
            }
        }

        // Navigation for toolbar on top of MainPage
        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPlayerPage());
        }

        // Remove a player from list
        private void ToolbarItem_Activated_1(object sender, EventArgs e)
        {

        }
    }
}
