   M S B A M L   `   `   `  ����A  =Day 10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Day_10Day_10  5   	       Day_10.DetailedView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Day_10     5   	     � Title$  DetailedView��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ StackPanelCustom��5      .+�5      �� -   5         ��Name$ 	ProductID��5      $��22(�6'   $
��Left=�65   $��10,20q�6P   $��40��6_   $	��150��6k   �� 5      -   5         ��Name$ ProductName��5      $��6q�6+   $��18(�67   $��10q�6E   $
��Left=�6Q    �� TextWrapping$
 Wrap=�6l   $��Center=�6�   $	��150��6�   �� 5      -   5        $ ProductPrice��5      $��6q�6,   $��18(�68   $��10q�6F   $
��Left=�6R   $
 Wrap=�6n   $��Center=�6�   $	��150��6�   �� 5      -   5        $	��box��5      $
��Left=�6#   $��10,20q�6>   $��40��6M   $	��200��6Y   6g   �� 5      -   5        $
��Left=�5      $��20,20,20,20q�60   $	��Top=�6E   $��7q�6^   $��80��6j   $��18(�6�   .��6�   Save6�   5      �� 5   
   -   5         ��Name$ productList��5      $��1��6'   5      5      5      