using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime date)
            {
                return date.ToShortDateString();
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public partial class MainWindow : Window
    {
        public List<Movie> loggedMovies = new List<Movie>();
        private string currentSortColumn = "Rating";
        private bool isSortAscending = false;

        public MainWindow()
        {
            InitializeComponent();

            loggedMovies = loggedMovies.OrderByDescending(movie => movie.Rating).ToList();

            lstLoggedMovies.ItemsSource = loggedMovies;

            // Populate the year filter ComboBox
            var uniqueYears = loggedMovies.Select(movie => movie.DateWatched.Year).Distinct().ToList();
            uniqueYears.Sort(); // Sort the years in ascending order
            var yearOptions = uniqueYears.Cast<object>().ToList(); // Convert years to object type
            yearOptions.Insert(0, "All Years"); // Insert "All Years" as the default option
            cmbYearFilter.ItemsSource = yearOptions;


            // Populate the rating filter ComboBox
            var uniqueRatings = loggedMovies.Select(movie => movie.Rating).Distinct().ToList();
            uniqueRatings.Sort(); // Sort the ratings in ascending order
            var ratingOptions = uniqueRatings.Cast<object>().ToList(); // Convert ratings to object type
            ratingOptions.Insert(0, "All Ratings"); // Insert "All Ratings" as the default option
            cmbRatingFilter.ItemsSource = ratingOptions;

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

                // Populate the year filter ComboBox
                var uniqueYears = loggedMovies.Select(movie => movie.DateWatched.Year).Distinct().ToList();
                uniqueYears.Sort(); // Sort the years in ascending order
                var yearOptions = uniqueYears.Cast<object>().ToList(); // Convert years to object type
                yearOptions.Insert(0, "All Years"); // Insert "All Years" as the default option
                cmbYearFilter.ItemsSource = yearOptions;


                // Populate the rating filter ComboBox
                var uniqueRatings = loggedMovies.Select(movie => movie.Rating).Distinct().ToList();
                uniqueRatings.Sort(); // Sort the ratings in ascending order
                var ratingOptions = uniqueRatings.Cast<object>().ToList(); // Convert ratings to object type
                ratingOptions.Insert(0, "All Ratings"); // Insert "All Ratings" as the default option
                cmbRatingFilter.ItemsSource = ratingOptions;

                // Sort the movies based on the current sorting column and order
                switch (currentSortColumn)
                {
                    case "Title":
                        loggedMovies = isSortAscending ? loggedMovies.OrderBy(movie => movie.Title).ToList()
                                                       : loggedMovies.OrderByDescending(movie => movie.Title).ToList();
                        break;
                    case "Rating":
                        loggedMovies = isSortAscending ? loggedMovies.OrderBy(movie => movie.Rating).ToList()
                                                       : loggedMovies.OrderByDescending(movie => movie.Rating).ToList();
                        break;
                    case "DateWatched":
                        loggedMovies = isSortAscending ? loggedMovies.OrderBy(movie => movie.DateWatched).ToList()
                                                       : loggedMovies.OrderByDescending(movie => movie.DateWatched).ToList();
                        break;
                    default:
                        break;
                }

                // Refresh the ListBox with the sorted movies
                lstLoggedMovies.ItemsSource = loggedMovies;
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
                ViewLogWindow viewLogWindow = new ViewLogWindow(selectedMovie);

                viewLogWindow.ShowDialog();
            }
        }

        public void RemoveMovie(Movie movie)
        {
            loggedMovies.Remove(movie);
            lstLoggedMovies.Items.Refresh();
        }

        private void SortHeader_Click(object sender, RoutedEventArgs e)
        {
            // Sort logic based on the clicked column header
            GridViewColumnHeader column = sender as GridViewColumnHeader;
            string sortBy = column.Tag.ToString();

            // Check if the clicked column is already the current sorting column
            if (sortBy == currentSortColumn)
            {
                // Toggle the sort order
                isSortAscending = !isSortAscending;
            }
            else
            {
                // If a different column is clicked, set it as the current sorting column and default to ascending order
                currentSortColumn = sortBy;
                isSortAscending = true;
            }

            // Apply sorting based on the current column and sort order
            switch (sortBy)
            {
                case "Title":
                    loggedMovies = isSortAscending ? loggedMovies.OrderBy(movie => movie.Title).ToList()
                                                   : loggedMovies.OrderByDescending(movie => movie.Title).ToList();
                    break;
                case "Rating":
                    loggedMovies = isSortAscending ? loggedMovies.OrderBy(movie => movie.Rating).ToList()
                                                   : loggedMovies.OrderByDescending(movie => movie.Rating).ToList();
                    break;
                case "DateWatched":
                    loggedMovies = isSortAscending ? loggedMovies.OrderBy(movie => movie.DateWatched).ToList()
                                                   : loggedMovies.OrderByDescending(movie => movie.DateWatched).ToList();
                    break;
                default:
                    break;
            }

            lstLoggedMovies.ItemsSource = loggedMovies;
        }


    }


}
