
# My Movie Log
Final project for INFOTC-4400 C#/.NET Development, Spring 2024

### Description
The Movie Rating System is a simple application built using WPF in C#. It allows users to log and track movies they have watched, along with their ratings and written reviews.

Add New Movie: Users can add new movies to the log by providing details such as title, rating, written review, and date watched.

### Features
View Movie Details: Users can double-click on a movie in the log to view its details, including title, rating, written review, and date watched.

Delete Movie: Users can delete a movie from the log.

Filter and Sort Movies: Movies can be filtered by year logged and rating. Additionally, they can be sorted by title, rating, and date logged.

Watchlist: Users can maintain a watchlist. Double-click entries to remove.

### Setup
To set up the development environment and run the application:

    1. Clone this repository to your local machine.

    2. Open the solution file (Movie-Rating-System/MovieRatingSystem.sln) in Visual Studio.

    3. Build and run the solution (F5).

### How to Use Features

Add Movie: Click the "Log New Movie" button to add a new movie to the log. Fill in the details in the prompted window and click "Add".

View Movie Details: Double-click on a movie in the log to view its details.

Delete Movie: In the movie details window, click the "Delete" button to delete the movie from the log.

Filter Movies: Use the filter combo boxes to filter movies by year watched and rating.

Sort Movies: Sort your logged movies by clicking the Title, Rating, Date Watched headers. The default sort method when the program is launched, is Rating (Descending).

Watchlist: Click "Check Watchlist" and a new window will appear. To add a movie to watchlist, you can type in the box and click "Add to Watchlist" to add entry to watchlist. To remove a watchlist entry, just double-click the entry. If you close this window and return, as long as the main window is still open, the Watchlist will still persist.

### Important Notes
Note that no user data will persist if the main window is closed. This is, essentially, a demo for the applicable use caases detailed above.

### Development
Created by Benjamin Williams
