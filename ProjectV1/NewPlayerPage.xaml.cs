using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectV1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewPlayerPage : ContentPage
	{
		public NewPlayerPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Player player = new Player()
            {
                Name = nameHome.Text,
                Club = nameClub.Text
            };

            // Creat table for player objects and confirms if it was successful or not
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Player>();
                var numberOfRows = conn.Insert(player);

                if(numberOfRows > 0)
                {
                    DisplayAlert("Confirmed", "Player successfully added", "Continue");
                }
                else
                {
                    DisplayAlert("Failed", "Player not added", "Retry");
                }
            }
        }
	}
}