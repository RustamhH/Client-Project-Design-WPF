   M S B A M L   `   `   `  ����P  LClient Project Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Client_Project_Design.ViewsClient_Project_Design.Views  5   	   7    1Client_Project_Design.Views.NewClientRegisterView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Client_Project_Design.Views     5   	     � Title$  NewClientRegisterView��5   	   $	��750��6'   $	��420��64   ���#F4F8FB � WindowStartupLocation$ CenterScreen=�6U   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.1* �6   6,   �� 5      6   �� 5      $
��0.1* �6   6,   �� 5      $��0.05* �6   6-   .+�5   
   � $��0��6   $	��Top=�6!   $��10q�69   .+�5      �� $*��$/Static Files/Images/Client Logo.png��6   $��60��6B   �� 5      $
��home��6   $
��Bold"�6$   $��18(�66   $��	280 0 0 0q�6D   ���#01133D J� InputBindings 5      d� 5       d� Gesture$ 	LeftClicka�6#    �� Command 67   �� *BackToHomeCommand+5      5      �� 5   
   $��2��6   $��5q�6   $��register��6)   $��15(�6<   ��6J   �� *RegisterCommand+6p   �� 5   
   $��3��6   
�������$/��)Proudly created by Rustam Hasanli in 2023��63   $��Center=�6d   $��Center=�6�   6�   �� 5   
   $��1��6   $��7q�6"   .+�5      �� $
��Name��6   $
��Bold"�6$   ���#01133D$��5q�6K   6X   �� 5       $	��400��6   
 � Tag$&   What is the name of the client?��69   $��50��6`   ��6#   �� *Name+6n   �� 5"      $��Surname��6   $
��Bold"�6'   ���#01133D$��5q�6N   6[   �� 5#      $	��400��6   $) # What is the surname of the client?��6=   $��50��6g   ��6#   �� *	Surname+6u   �� 5%      $��Number��6   $
��Bold"�6&   ���#01133D$��5q�6M   6Z   �� 5&      $	��400��6   $. ( What is the phone number of the client?��6<   $��50��6k   ��6#   �� *Number+6y   �� 5(      $��Company��6   $
��Bold"�6'   ���#01133D$��5q�6N   6[   �� 5)      $	��400��6   $/ ) Which company does the person belong to?��6=   $��50��6m   ��6#   �� *	Company+6{   �� 5+      $��Place��6   $
��Bold"�6%   ���#01133D$��5q�6L   6Y   �� 5,      $	��400��6   $!  Where did he/she found me?��6;   $��50��6]   ��6#   �� *Place+6k   �� 5.      $��Registration date��6   $
��Bold"�61   ���#01133D$��5q�6X   6e   �� 5/       �� Orientation$ 
Horizontal=�6   $��0 0 0 10q�62   .+�50      �� $	��115��6   $
  Day��6<   $��50��6G   $��0 0 20 0q�6S   ��6&   �� *Day+6g   �� 51      $	��115��6   $  Month��6>   $��50��6K   $��0 0 20 0q�6W   ��6&   �� *Month+6k   �� 52      $	��115��6   $  Year��6=   $��50��6I   $��0 0 20 0q�6U   ��6&   �� *Year+6i   53      �� 55      $��How do I know him/her��6   $
��Bold"�65   ���#01133D$��5q�6\   6i   �� 56      $	��400��6   $$  Write how do you know him/her��69   $��50��6^   ��6"   �� *How+6l   59      5=      5>      