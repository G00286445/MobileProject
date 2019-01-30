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

        // Navigation for toolbar on top of MainPage - to New player page
        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPlayerPage());
        }

        // Navigation for toolbar on top of MainPage - to League table view
        private void ToolbarItem_Activated_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LeagueTable());
        }

        private void playersListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as ViewModel;

            var player = e.Item as Player;

        }

        private void ToolbarItem_Delete_Player(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeletePlayerPage());

        }
    }
}
