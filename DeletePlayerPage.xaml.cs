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
	public partial class DeletePlayerPage : ContentPage
	{
		public DeletePlayerPage ()
		{
			InitializeComponent ();
		}

        // Delete player from list
        private void Button_Clicked(object sender, EventArgs e)
        {
            Player player = new Player()
            {
                // Name = nameDelete.Text
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<Player>();
                var numberOfRows = conn.Insert(player);

                if (numberOfRows > 0)
                {
                    DisplayAlert("Confirmed", "Player successfully Delete", "Continue");
                }
                else
                {
                    DisplayAlert("Failed", "Player not Deleted", "Retry");
                }
            }
        }
    }
}