   M S B A M L   `   `   `  ����P  LClient Project Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Client_Project_Design.ViewsClient_Project_Design.Views  5   	   3    -Client_Project_Design.Views.ClientProfileView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Client_Project_Design.Views     5   	     � Title$  ClientProfileView��5   	   $	��750��6#   $	��420��60    � WindowStartupLocation$ CenterScreen=�6<   ���#F4F8FB.��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.1* �6   6,   �� 5      $��0.26* �6   6-   �� 5      $
��0.9* �6   6,   �� 5      $
��0.2* �6   6,   �� 5      $��0.05* �6   6-   .+�5   
   � 
�������.+�5      � $��0��6   $	��Top=�6%   $��10q�6=   .+�5      �� $*��$/Static Files/Images/Client Logo.png��6   $��60��6F   �� 5      $
��home��6   $
��Bold"�6(   $��18(�6:   $��	280 0 0 0q�6H   ���#01133D J� InputBindings 5      d� 5       d� Gesture$ 	LeftClicka�6'    �� Command 6;   �� *BackToHomeCommand+5      5      5      �� 5   
   $��3��6   $��15q�6   $��65��6*   $��61��65   $��Bottom=�6A   $��Right=�6\   ��6x   �� *
NewCommand+.��5       �� $$��/Static Files/Images/+ new.png��6   $��30��6<   5!      �� 5"   
   $��4��6   
�������$/��)Proudly created by Rustam Hasanli in 2023��63   $��Center=�6d   $��Center=�6�   6�   � 5%   
   $��1��6    � ColumnDefinitions 5&      �� 5'      6%   �� 5(      6%   .+�5,      �� $��0��6   .+�5-      ��  �� Orientation$ 
Horizontal=�6   $��	10 10 0 0q�66   .+�5.      �� ���#01133D$
��Bold"�65   $��20(�6G   $��0 0 5 0q�6z   ��6U   �� *SelectedClient.Name+6�   �� 5/      ���#01133D$
��Bold"�65   $��20(�6G   ��6U   �� *SelectedClient.Surname+6�   50      �� 52      $ 
Horizontal=�6   $��	10 10 0 0q�66   .+�53      �� $'��!/Static Files/Images/building.png��6   $��15��6G   $��0 0 10 0q�6R   6f   �� 54      ���#01133D$��15(�65   $��Light"�6C   ��6V   �� *SelectedClient.Company+6�   55      �� 57      $ 
Horizontal=�6   $��30��66   $��	10 10 0 0q�6B   .+�58      �� ���#01133D$��15(�65   $��Light"�6C   $��
Came from:��6V   $��0 0 5 0q�6h   6{   �� 59      ���#01133D$��15(�65   $��Light"�6C   $	��100��6|   $��Center=�6�   $��0 0 0 11q�6�   ��6V   �� *SelectedClient.Place+6�   5:      5;      �� 5>      $��1��6   .+�5?      �� $"��/Static Files/Images/pen.png��6   $��15��6>   $��Right=�6I   $��	0 10 15 0q�6e    5@      d� 5A       d� MouseAction$ 	LeftClicke�6'    6?   �� *EditCommand+5C      �� 5G      $ 
Horizontal=�6   $��	10 20 0 0q�66   .+�5H      �� $$��/Static Files/Images/phone.png��6   $��13��6D   $��0 0 10 0q�6O   6c   �� 5I      ���#01133D$��Light"�66   $��15(�6I   ��6W   �� *SelectedClient.Number+6�   5J      �� 5L      $ 
Horizontal=�6   $��30��66   $��	10 10 0 0q�6B   .+�5M      �� ���#01133D$��Light"�65   $��15(�6H   $��Registered :��6V   $��0 0 5 0q�6j   6}   �� 5N      ���#01133D$��Light"�65   $��15(�6H   ��6V   �� *SelectedClient.Regs+6~   5O      5R      5T      �� 5W   
   $��2��6      
OrdersList#���   6    6G   5[      5\      