   M S B A M L   `   `   `  ����  Movie-Rating-System(    "Movie_Rating_System.AddMovieWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	Add Movie��5   	   $	��415��6   $	��350��6(   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Enter Movie Name:��6   $��
10,10,10,0q�6,   �� 5   
   -   5         ��Name$ txtMovieName��5      $��	10,5,10,0q�6(   $��1��6;   �� 5   
   $��Select Rating:��6   $��
10,10,10,0q�6)   $��2��6=   �� 5   
   -   5         ��Name$ 	cmbRating��5      $��	10,5,10,0q�6&   $��3��69   .@�5      �� $��0.5 Star��6   �� 5      $��1 Star��6   �� 5      $��	1.5 Stars��6   �� 5      $��2 Stars��6   �� 5      $��	2.5 Stars��6   �� 5      $��3 Stars��6   �� 5      $��	3.5 Stars��6   �� 5      $��4 Stars��6   �� 5      $��	4.5 Stars��6   �� 5      $��5 Stars��6   5      �� 5    
   $��Date Watched:��6   $��10,10,10,157q�6(   $��4��6>   (  "System.Windows.Controls.DatePicker  5!   
   -   5          Name$ dpDateWatched��5!      $��10,41,10,131q�6,   $��4��6B   �� 5#   
   $��Written Review:��6   $��10,83,10,-27q�6*   $��4��6@   �� 5$   
   -   5        $ txtWrittenReview��5$      $��5��6   $��10,110,10,10q�69    �� TextWrapping$
 Wrap=�6O   $��78��6c   �� 5&   
   -   5        $	��Add��5&      $��4��6   $��Center=�6A   $��0,204,0,-38q�6^   $��80��6s   5'      5(      