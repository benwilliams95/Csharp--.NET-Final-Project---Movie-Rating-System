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
    public partial class ViewLogWindow : Window
    {
        public ViewLogWindow(Movie movie)
        {
            InitializeComponent();
            DataContext = movie;
        }

        // Properties to bind to the UI elements
        public double Rating { get; set; }
        public string WrittenReview { get; set; }
        public string DateWatched { get; set; }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected movie from the ListBox
            Movie selectedMovie = (Movie)this.DataContext;

            // Remove the selected movie from the main list of logged movies
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.loggedMovies.Remove(selectedMovie);
                mainWindow.lstLoggedMovies.Items.Refresh();
                mainWindow.UpdateFilters();
            }

            // Close the window
            Close();
        }
    }
}