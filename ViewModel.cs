using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ProjectV1
{
    public class ViewModel : INotifyPropertyChanged
    {

        private Player _player;

        public ObservableCollection<Player> Player { get; set; }

        public ViewModel()
        {
            Player = new ObservableCollection<Player>
            {
                
            };
        
        }

        // Implement interface
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
