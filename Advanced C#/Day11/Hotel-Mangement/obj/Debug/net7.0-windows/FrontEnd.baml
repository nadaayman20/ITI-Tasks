   M S B A M L   `   `   `  ����Q  MHotel-Mangement-System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Hotel_Mangement_SystemHotel_Mangement_System  5   	   %    Hotel_Mangement_System.FrontEnd   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Hotel_Mangement_System     5   	     � Title$  FrontEnd��5   	   $	��690��6   $
��1331��6'   .��5	      �� $��0,7,0,0q�6   ���	#FF2AAE6B._�5
   
   �  � RowDefinitions 5      �� 5      $
��1.3* �6    60   �� 5      $
��1.3* �6    60   �� 5      $	��18* �6    6/   .+�5      �� -   5         ��Name$ 	textBlock��5   &   $��30(�6   $
��Left=�69   $��24,0,0,0q�6T   $��Frontend��6g   $��Center=�6w   &   System.Windows.Controls.DataGrid  5      -   5          Name$ ReservationGrid��5      $��0,0,0,0q�5      $y�Hidden=�6%   $��1��69   �� 5      -   5        $��ErrorValidation��5   V   $��22(�6   ���	#FFDD1D1D$��490,10,346,529q�6>   $y�Hidden=�6m   $��2��6�   $��1��6�    Please Enter all required data6�   �� 5      -   5        $��SuccessfulMessage��5   V   $��22(�6   ���	#FF1DDD29$��490,10,346,529q�6>   $y�Hidden=�6o   $��2��6�   $��1��6�   +)Inserted new Reservation Successfully ✅6�   �� 5      -   5        $��ErrorMessage��5   V   $��22(�6   ���	#FFDD1D1D$��490,10,346,529q�6>   $y�Hidden=�6j   $��2��6~   $��1��6�   " Can't insert new Reservation ❌6�   � 5      $��2��6   .+�5      �� .@�5      �� ��5      �� 5       �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $��Reservation��6,   5      .��5      � ���#e7e7e7 � ColumnDefinitions 5       �� 5!   "   65   �� 5"   "   65   �� 5#   "   65   .+�5%      �� $��0��6%   
�������$��5q�6I    �� Padding$ 	0 30 0 0 q�6]   ._�5&   "   �� $ Vertical=�6-   $��0��6D   .+�5'   &   �� $ Vertical=�61   .+�5(   *   �� $��	14,5,5,-3q�60   $��13(�6C   .��6Q   Name6W   �� 5)   *   $ 
Horizontal=�65   .+�5*   .   �� -   5         ��Name$ 	firstName��5*   6   $��20(�6I   $��17,0,7,0q�6W   $	��195��6i   ��6u   �� *
first_name+ �� FallbackValue$ First��6�   �� 5+   .   -   5        $ lastName��5+   6   $��20(�6H   $	��195��6V   ��6b   �� *	last_name+$
 Last��6�   5,   +   5-   '   �� 5.   &   $ Vertical=�61   .+�5/   *   �� $��	14,5,5,-3q�60   $��13(�6C   .��6Q   
Birthday6[   �� 50   *   $ 
Horizontal=�65   .+�51   .   �� -   5        $��Month_combo��51   �   	 �� 
IsEditable$
	 True��67   
 �� 
IsReadOnly$

 True��6I    �� Text$ Month��6[   $��20(�6h   $��10,3,3,3q�6v   $��
17,0,3.5,0q�6�   $	��130��6�   ��6�   �� 53   /   �� 54   .   -	   5        $��	Day_combo��54   �   $
	 True��67   $

 True��6I   $	 Day��6[   $��20(�6f   $��20,3,3,3q�6t   $��	3.5,0,7,0q�6�   $	��130��6�   ��6�   �� .@�55   2   �� 6A   56   /   �� 57   .   -
   5        $��DBYear��57      $��20(�66   $��5,3,3,3q�6D   $	��130��6V   ��6b   �� *	birth_day+6�   58   +   59   '   �� 5;   &   $ Vertical=�61   .+�5<   *   �� $��	14,5,5,-3q�60   $��13(�6C   .��6Q   Gender6Y   �� 5=   *   -   5        $��Gender_combo��5=   3   $
	 True��6G   $

 True��6Y   $ .......��6k   $��20(�6z   $��10,3,3,3q�6�   $��	17,0,16,0q�6�   ��6�   �� 5?   +   5@   '   �� 5A   &   $ Vertical=�61   .+�5B   *   �� $��	14,5,5,-3q�60   $��13(�6C   .��6Q   Phone Number6_   �� 5C   *   -   5        $��PhoneTxt��5C   2   $��20(�6B   $��	17,0,16,0q�6P   ��6c   �� *phone_number+$ (999)-999-9999��6�   5D   '   �� 5E   &   $ Vertical=�61   .+�5F   *   �� $��	14,5,5,-3q�60   $��13(�6C   .��6Q   Email6X   �� 5G   *   -   5        $��EmailTxt��5G   2   $��20(�6B   $��	17,0,16,0q�6P   ��6c   �� *email_address+$ first.last@example.com��6�   5H   '   �� 5I   &   $ Vertical=�61   .+�5J   *   �� -   5        $��StreetAddress��5J   2   $��20(�6G   $��
17,15,16,0q�6U   ��6i   �� *street_address+$ StreetAddress��6�   5K   '   �� 5L   &   $ 
Horizontal=�61   .+�5M   *   �� -   5        $
��Appt��5M   2   $��20(�6>   $��	17,15,7,0q�6L   $	��195��6_   ��6k   �� *	apt_suite+$ 
Apt./Suite��6�   �� 5N   *   -   5        $
��City��5N   2   $��20(�6>   $��0,15,7,0q�6L   $	��195��6^   ��6j   �� *city+$
 City��6�   5O   '   �� 5P   &   $ 
Horizontal=�61   .+�5Q   *   �� -   5         ��Name$ 	stateComb��5Q   3   $
	 True��6F   $

 True��6X   $ State��6j   $��20(�6w   $��	17,15,7,0q�6�   $	��195��6�   ��6�   �� 5T   +   �� 5U   *   -   5        $��ZipCode��5U   2   $��20(�6A   $��0,15,7,0q�6O   $	��195��6a   ��6m   �� *
zip_code+$ zip_code��6�   5V   '   5X   #   5Z      �� 5\      $��1��6%   
�������$��5q�6I   $ 	0 30 0 0 q�6]   ._�5]   "   �� $ Vertical=�6-   $��0��6D   .+�5^   &   �� $ Vertical=�61   .+�5_   *   �� $��	14,5,5,-3q�60   $��13(�6C   .��6Q   Your Choices6_   �� 5`   *   $ 
Horizontal=�65   .+�5b   .   �� -   5        $��guestsCombo��5b   7   $
	 True��6K   $
{�True��6]   $ # of guests ��6n   $��20(�6�   $��17,0,7,0q�6�   $	��200��6�    �� SelectedValue$ 1��6�   ��6�   �� 5d   /   �� 5e   .   -   5        $��roomTypeComb��5e   7   $
	 True��6K   $
{�True��6]   $ 
Room Types��6n   $��20(�6�   $��0,0,7,0q�6�   $	��200��6�   ��6�   �� 5g   /   5i   +   5j   '   �� 5k   &   $ Vertical=�61   .+�5l   *   �� $ 
Horizontal=�65   .+�5n   .   �� -   5        $��
floorCombo��5n   7   $
	 True��6I   $
{�True��6[   $ Floor��6l   $��20(�6y   $��	17,30,7,0q�6�   $	��200��6�   ��6�   �� 5p   /   �� 5r   .   -   5        $��roomNumberComb��5r   7   $
	 True��6M   $
{�True��6_   $ #��6p   $��20(�6z   $��0,30,7,0q�6�   $	��200��6�   ��6�   �� 5t   /   5u   +   5v   '   �� 5w   &   $ Vertical=�61   .+�5x   *   �� $��	14,5,5,-3q�60   $��13(�6C   .��6Q   
Entry Date6]   (  "System.Windows.Controls.DatePicker  5y   *   -   5        $��
Entry_Date��5y   P   $��Center=�65   $��18(�6b   $��	14,0,12,0q�6p      SelectedDate 6�   ��  �� Path$ arrival_time�5z   '   �� 5{   &   $ Vertical=�61   .+�5|   *   �� $��	14,5,5,-3q�60   $��13(�6C   .��6Q   Departure Date6a     5}   *   -   5        $��Departure_Date��5}   P   $��Center=�65   $��18(�6f   $��	14,0,12,0q�6t    6�   �� $ arrival_time�5~   '   �� 5   &   $ Vertical=�61   .+�5�   *   �� -   5        $��16(�5�   1   $��0,8,0,8q�6?   $��
14,20,12,0q�6Q   ���	#FFF0EEEE���	#FF2AAE6B���	#FF2AAE6B$
��Bold"�6�   .��6�   Food and Menu6�   5�   '   �� 5�   &   $ 
Horizontal=�61   $��Center=�6J   .+�5�   *   �� -   5        $��Checkin��5�   ?   $��30q�63   $��	Check in?��6N    d� 	IsChecked 6�   �� *
check_in+�� 5�   *   -   5        $��SendSMS��5�   ?   $��30q�63   $��Send SMS��6N   �� 5�   *   -   5        $��FoodSupplyCheckBox��5�   @   $��30q�64   $��Food/Supply Status?��6   5�   '   �� 5�   &   $ Vertical=�61   .+�5�   *   �� -   5        $��16(�5�   1   $��0,8,0,8q�6?   $��	14,0,12,0q�6Q   ���	#FFF0EEEE���	#FF2AAE6B���	#FF2AAE6B$
��Bold"�6�   .��6�   Finalize Bill6�   �� 5�   *   -   5        $��
SubmitForm��5�     $��Submit��61   ���	#FF2AAE6B$��16(�6Y   $��40��6�   $��
10,18,10,0q�6�   ���	#FF279B0A$��3,3,3,3q�6�   ���	#FFF6FFF4$
��Bold"�6�   $	��398��6  6'  5�   '   5�   #   5�      �� 5�      $��2��6%   
�������$��5q�6J   $ 	0 30 0 0 q�6^   ._�5�   "   � $��2��6'   $��	0,230,0,0q�67    5�   &   �� 5�   *   $
��229* �6;   �� 5�   *   $
��215* �6;    5�   &   �� 5�   *   $	��26* �68   �� 5�   *   $	��15* �68   .+�5�   &   �� $��2q�6-   ���	#FFD8D7D7$��13,-230,10,10q�6Y   $��2��6p   $��2��6�   �� 5�   &   -   5        $��editReservationGrid��5�   f   $��0��61   $��
0,-200,0,0q�6>   $y�Hidden=�6R   $��2��6�   .+�5�   *   �� -    5        $��comboBoxEditReservation��5�   3   $
	 True��6R   $
{�True��6d   $  Select Reservation to edit��6u   $��18(�6�   
�������$��0,0,0,0q�6�   $��10q�6�   $	��380��6�   $��44��6�   5�   +   �� 5�   *   $��	0,150,0,0q�65   .+�5�   .   �� -!   5        $��UpdateReservationBtn��5�   5   ���	#FFF0EEEE���	#FF2AAE6B���	#FF2AAE6B$
��Bold"�6�   $��1q�6�   $��
15,20,10,0q�5�   2   $��0,8,0,8q�6F   $��16(�6X   $	��380��6f   $��44��6r   $��Update��5�   1   6B   �� 5�   .   -"   5         ��Name$ deleteReservation��5�   5   
���   �
���  ��
���  ��$
��Bold"�6�   $��1q�6�   $��
15,20,10,0q�5�   2   $��0,8,0,8q�6F   $��16(�6X   $	��380��6f   $��44��6r   $��Delete��5�   1   6B   5�   +   5�   '   �� 5�   &   $��15,146,10,-53q�61   $��2��6H   $��2��6\   .+�5�   *   �� -#   5        $ editReservation��5�   1   ���	#FFF0EEEE$��Edit existing Reservation��6b   ���	#FF2AAE6B���	#FF2AAE6B$
��Bold"�6�   $��1q�6�   $��44��6�   $	��380��6  $��0,0,0,10q�6  �� 5�   *   -$   5        $ addReservation��5�   1   ���	#FFF0EEEE$��New reservation��6a   ���	#FF2AAE6B���	#FF2AAE6B$
��Bold"�6�   $��1q�6�   $��44��6�   $	��380��6�   5�   '   5�   #   5�      5�      5�      �� 5�      ��5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   �� $��Universal Search��6,   5�      .��5�      �  5�      �� 5�   "   $��2* �60   6>   �� 5�   "   $��8* �60   6>   .+�5�      �� $��0��6)   $ 
Horizontal=�66   $��	0,-50,0,0q�6O   $��Center=�6b   .+�5�   "   �� -%   5        $ 
TBoxSearch��5�   *   $
��1000��6>   $��40��6K   $��40,0,0,0q�6W   $��5q�6i   $��20(�5�   *   $��Search.....��68   �� 5�   "   -&   5        
�������$��40��5�   <   $��60��6H   .��5�   &   �� $��/assets/room.png��6,   5�   #   5�      �� 5�      $��1��6)   .+�5�   "     -'   5        $��
searchData��5�   +   $	��400��6=   5�   #   5�      5�      5�      �� 5�      -(   5        ��5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   �� $��Reservation Adv. view��6,   5�      .��5�      � .+�5�        -)   5        $��Result��5�   '   5�      5�      5�      �� 5�      -*   5        ��5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   �� $��Room availibility��6,   5�      .��5�      �  5�      �� 5�   "   65   �� 5�   "   65   .+�5�      �� $ Vertical=�6)   ���#e7e7e7$��0��5�   ?   $��0,0,5,0q�6O   .+�5�   "   �� $��20(�6,    �� Padding$ 5q�6:   
Occupied6Q   �� 5�   "   $��16(�6,   $"Room# | Type | ID# | Name | Phone#6i   �� 5�   "   .��5�   &   �� -+   5        $��OccupiedList��5�   /   $��Visible=�6C   5�   '   5�   #   5�      �� 5�      $ Vertical=�6)   ���#e7e7e7$��1��6U   $��0,0,5,0q�6e   .+�5�   "   �� $��20(�6,   $ 5q�6:   
Reserved6P   �� 5�   "   $��16(�6,   53Room# | Type | ID# | Name | Phone# | Entry | Depart6z   �� 5�   "   -,   5        $��ReservedList��5�   *   5�   #   5�      5     5     5     5     5     5     5
     