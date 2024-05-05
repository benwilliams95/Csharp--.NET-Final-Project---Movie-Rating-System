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
    public partial class AddMovieWindow : Window
    {
        // Properties to store the user input from the AddMovieWindow
        public string MovieName { get; private set; }
        public double MovieRating { get; private set; }
        public string WrittenReview { get; private set; }
        public DateTime DateWatched { get; private set; }

        public AddMovieWindow()
        {
            InitializeComponent();
            dpDateWatched.DisplayDateEnd = DateTime.Now;
            dpDateWatched.SelectedDateChanged += DpDateWatched_SelectedDateChanged;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMovieName.Text))
            {
                // If the movie name is empty, display a message box
                MessageBox.Show("No movie title entered!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                // Keep the AddMovieWindow open without adding to log
                return;
            }

            // Assign user input to the properties when the Add button is clicked
            MovieName = txtMovieName.Text;
            // Parse the selected rating from the ComboBox
            if (cmbRating.SelectedItem != null)
            {
                string ratingString = ((ComboBoxItem)cmbRating.SelectedItem).Content.ToString().Split(' ')[0];
                double.TryParse(ratingString, out double rating);
                MovieRating = rating;
            }
            WrittenReview = txtWrittenReview.Text;
            DateWatched = dpDateWatched.SelectedDate ?? DateTime.Now; // Use current date if no date is selected

            // Close the window with DialogResult set to true
            DialogResult = true;
        }

        private void DpDateWatched_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            // Check if the selected date is in the future
            if (dpDateWatched.SelectedDate > DateTime.Now)
            {
                // If the selected date is in the future, display a message box
                MessageBox.Show("Future date! Defaulting to current date.");
                // Set the date picker's selected date to the current date
                dpDateWatched.SelectedDate = DateTime.Now;
            }
        }
    }
}
