using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Movie_Rating_System
{
    /// <summary>
    /// Interaction logic for Watchlist.xaml
    /// </summary>
    public partial class Watchlist : Window
    {
        public Watchlist()
        {
            InitializeComponent();

            // Load watchlist items from the static list
            foreach (string movieTitle in WatchlistManager.WatchlistItems)
            {
                lstWatchlist.Items.Add(movieTitle);
            }
        }

        private void AddToWatchlist_Click(object sender, RoutedEventArgs e)
        {
            // Get the movie title from the TextBox
            string movieTitle = txtAddMovie.Text;

            // Add the movie title to the static watchlist
            WatchlistManager.WatchlistItems.Add(movieTitle);

            // Add the movie title to the ListBox
            lstWatchlist.Items.Add(movieTitle);

            // Clear the TextBox after adding the movie
            txtAddMovie.Clear();
        }
    }
}
