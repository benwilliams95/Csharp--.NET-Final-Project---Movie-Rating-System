   M S B A M L   `   `   `  ����N  JMovie-Rating-System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Movie_Rating_SystemMovie_Rating_System  5   	   $    Movie_Rating_System.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Movie_Rating_System     5   	     � Title$  	Movie Log��5   	   $	��600��6   $	��800��6(    � 
ResizeMode$ NoResize=�5	   	   
����=H� � 	Resources 5      '   !Movie_Rating_System.DateConverter   DateConverter��%   &	          5   
   6   5      .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ DarkSlateBlue��6    � Offset$ 0Q�65   � 5      $ 	LightBlue��6   $ 1Q�61   5      .+�5   
   �� $��My Movie Log��6   $��Center=�6'   $	��Top=�6D   $��36(�6\   $��0,2,0,0q�6j   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $	��Top=�6J   $��	0,60,37,0q�6b   .+�5      �� -   5        $��Log New Movie��5      $��33��6D   $	��104��6P   5      �� 5   
   $��My Logged Movies��6   $
��Left=�6+   $	��Top=�6F   $��24(�6^   $��	44,56,0,0q�6l   �� 5    
   -   5        $��lstLoggedMovies��5       $
��Left=�6^   $	��356��6y   $��	49,98,0,0q�6�   $	��Top=�6�   $	��698��6�   $��14(�6�    �� View 5!      �� 5"      .P�5#      �� $��Title��6%   	 �� Width$		 399��6[   
 �� DisplayMemberBinding
 64   �� *Title+ �� HeaderContainerStyle 5$      �� 5%       �� 
TargetType" ��6$   .�5&   "   ��  �� Property �@�Tag �� Value$ Title��68   -   5        5(      5*      �� 5+      $��Rating��6%   $	 99��6]   
 65   �� *Rating+ 5,      �� 5-      " ��6$   .�5.   "   ��  �@�Tag$ Rating��68   -   5        50      52      �� 53      $��Date Watched��6%   $		 200��6�   
 6;   �� *DateWatched+ �� 	Converter# [   54      �� 55      " ��6$   .�56   "   ��  �@�Tag$ DateWatched��68   -   5        58      5:      5;      5=      �� 5@   
   $��Filters��6   $
��Left=�6"   $��Bottom=�6=   $��24(�6X   $��	44,0,0,71q�6f   �� 5A   
   -   5         ��Name$ cmbYearFilter��5A      $	��200��6*   $��Bottom=�66   $
��Left=�6Q   $��
282,0,0,52q�6l   �� 5B   
   -   5        $ cmbRatingFilter��5B      $	��200��6,   $��Bottom=�68   $
��Left=�6S   $��	49,0,0,52q�6n   �� 5C   
   -   5        $��Check Watchlist��5C      $
��Left=�6H   $��Bottom=�6c   $��
547,0,0,52q�6~   $��39��6�   $	��200��6�   5E      5F      