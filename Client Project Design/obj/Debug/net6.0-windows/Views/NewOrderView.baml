   M S B A M L   `   `   `  ����P  LClient Project Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Client_Project_Design.ViewsClient_Project_Design.Views  5   	   .    (Client_Project_Design.Views.NewOrderView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Client_Project_Design.Views     5   	     � Title$  NewOrderView��5   	   $	��750��6   $	��420��6+   ���#F4f8fb � WindowStartupLocation$ CenterScreen=�6L   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.1* �6   6,   �� 5      6   �� 5      $
��0.2* �6   6,   �� 5      $
��0.4* �6   6,   .+�5   
   � 
�������.+�5      � $��0��6   $	��Top=�6%   $��10q�6=   .+�5      �� $*��$/Static Files/Images/Client Logo.png��6   $��60��6F   �� 5      $
��home��6   $
��Bold"�6(   $��18(�6:   $��	280 0 0 0q�6H   ���#01133D J� InputBindings 5      d� 5       d� Gesture$ 	LeftClicka�6'    �� Command 6;   �� *BackToHomeCommand+5      5      5      �� 5   
   $��2��6   $��10q�6   $��Register��6*   $��15(�6=   $��70��6K   ��6W   �� *RegisterCommand+6}   �� 5   
   $��3��6   
�������$/��)Proudly created by Rustam Hasanli in 2023��63   $��Center=�6d   $��Bottom=�6�   $��10q�6�   6�   �� 5    
   $��1��6   $��7q�6"   .+�5!      �� $��Name of the order��6   $��20(�61   $
��Bold"�6?   ���#01133D$��5q�6f   6s   �� 5"      $	��400��6   
 � Tag$3 -Type the order name same with the order blank��6=   $��60��6q   ��6"   �� *	OrderName+6   �� 5$      $��Order quantity��6   $��20(�6.   $
��Bold"�6<   ���#01133D$��5q�6c   6p   �� 5%      $	��400��6   $3 -Type the order name same with the order blank��6A   $��60��6u   ��6"   �� *OrderQuantity+6�   �� 5'      $��Order opening day��6   $
��Bold"�61   ���#01133D$��5q�6X   $��20(�6c   6s   �� 5(       �� Orientation$ 
Horizontal=�6   $��0 0 0 10q�62   .+�5)      �� $	��115��6   $
  Day��6<   $��60��6G   $��0 0 20 0q�6S   ��6&   �� *DayO+6g   �� 5*      $	��115��6   $  Month��6>   $��60��6K   $��0 0 20 0q�6W   ��6&   �� *MonthO+6k   �� 5+      $	��115��6   $  Year��6=   $��60��6I   $��0 0 20 0q�6U   ��6&   �� *YearO+6i   5,      �� 5.      $��Order delivery day��6   $
��Bold"�62   ���#01133D$��5q�6Y   $��20(�6d   6t   �� 5/      $ 
Horizontal=�6   $��0 0 0 10q�62   .+�50      �� $	��115��6   $
  Day��6<   $��60��6G   $��0 0 20 0q�6S   ��6&   �� *DayD+6g   �� 51      $	��115��6   $  Month��6>   $��60��6K   $��0 0 20 0q�6W   ��6&   �� *MonthD+6k   �� 52      $	��115��6   $  Year��6=   $��60��6I   $��0 0 20 0q�6U   ��6&   �� *YearD+6i   53      58      5<      5=      