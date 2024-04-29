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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
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
    }
}
