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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddMovie_Click(object sender, RoutedEventArgs e)
        {
            AddMovieWindow addMovieWindow = new AddMovieWindow();
            addMovieWindow.Owner = this;
            addMovieWindow.ShowDialog();
        }

        private void CheckWatchlist_Click(object sender, RoutedEventArgs e)
        {
            Watchlist watchlistWindow = new Watchlist();
            watchlistWindow.ShowDialog();
        }

    }


}
