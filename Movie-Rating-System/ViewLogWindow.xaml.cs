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
        public ViewLogWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        // Properties to bind to the UI elements
        public string Title { get; set; }
        public double Rating { get; set; }
        public string WrittenReview { get; set; }
        public string DateWatched { get; set; }
    }
}