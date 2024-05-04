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

            WatchlistManager.WatchlistItems = WatchlistManager.WatchlistItems.OrderBy(item => item).ToList();

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

            // Sort watchlist items alphabetically
            var sortedWatchlistItems = WatchlistManager.WatchlistItems.OrderBy(item => item).ToList();

            // Clear and reload the ListBox with sorted watchlist items
            lstWatchlist.Items.Clear();
            foreach (string title in sortedWatchlistItems)
            {
                lstWatchlist.Items.Add(title);
            }

            // Clear the TextBox after adding the movie
            txtAddMovie.Clear();
        }

        private void lstWatchlist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Get the selected item from the ListBox
            string selectedMovie = (string)lstWatchlist.SelectedItem;

            // Display a confirmation dialog box
            MessageBoxResult result = MessageBox.Show("Do you want to remove this movie?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            // If user confirms, remove the movie from the watchlist and ListBox
            if (result == MessageBoxResult.Yes)
            {
                WatchlistManager.WatchlistItems.Remove(selectedMovie);
                lstWatchlist.Items.Remove(selectedMovie);
            }
        }
    }
}
