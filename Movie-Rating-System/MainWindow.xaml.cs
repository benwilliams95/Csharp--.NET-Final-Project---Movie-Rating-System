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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Movie_Rating_System
{
    public static class WatchlistManager
    {
        public static List<string> WatchlistItems { get; set; } = new List<string>();
    }

    public class MovieBase
    {
        public string Title { get; set; }
        public double Rating { get; set; }
        public string WrittenReview { get; set; }
        public DateTime DateWatched { get; set; }

        // Constructor to initialize a movie with its properties
        public MovieBase(string title, double rating, string writtenReview, DateTime dateWatched)
        {
            Title = title;
            Rating = rating;
            WrittenReview = writtenReview;
            DateWatched = dateWatched;
        }

        // Override ToString() to return the movie title when displaying in ListBox
        public override string ToString()
        {
            return Title;
        }
    }
    public class Movie : MovieBase
    {
        public Movie(string title, double rating, string writtenReview, DateTime dateWatched)
            : base(title, rating, writtenReview, dateWatched)
        {
        }
    }

    public partial class MainWindow : Window
    {
        private List<Movie> loggedMovies = new List<Movie>();
        public MainWindow()
        {
            InitializeComponent();
            lstLoggedMovies.ItemsSource = loggedMovies;
        }
        private void AddMovie_Click(object sender, RoutedEventArgs e)
        {
            AddMovieWindow addMovieWindow = new AddMovieWindow();
            addMovieWindow.Owner = this;
            // Open the AddMovieWindow as a dialog
            if (addMovieWindow.ShowDialog() == true)
            {
                // If the user adds a movie (dialog result is true), add it to the list
                Movie newMovie = new Movie(addMovieWindow.MovieName,
                                           addMovieWindow.MovieRating,
                                           addMovieWindow.WrittenReview,
                                           addMovieWindow.DateWatched);
                loggedMovies.Add(newMovie);
                // Refresh the ListBox to update the displayed movies
                lstLoggedMovies.Items.Refresh();
            }
        }

        private void CheckWatchlist_Click(object sender, RoutedEventArgs e)
        {
            Watchlist watchlistWindow = new Watchlist();
            watchlistWindow.ShowDialog();
        }

        private void lstLoggedMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Get the selected movie from the ListBox
            Movie selectedMovie = (Movie)lstLoggedMovies.SelectedItem;

            if (selectedMovie != null)
            {
                // Open the ViewLogWindow with the details of the selected movie
                ViewLogWindow viewLogWindow = new ViewLogWindow();
                viewLogWindow.MovieTitle = selectedMovie.Title;
                viewLogWindow.Rating = selectedMovie.Rating;
                viewLogWindow.WrittenReview = selectedMovie.WrittenReview;
                viewLogWindow.DateWatched = selectedMovie.DateWatched.ToShortDateString();
                viewLogWindow.ShowDialog();
            }
        }



    }


}
