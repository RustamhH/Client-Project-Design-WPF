   M S B A M L   `   `   `  ����P  LClient Project Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Client_Project_Design.ViewsClient_Project_Design.Views  5   	   0    *Client_Project_Design.Views.AllClientsView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Client_Project_Design.Views     5   	     � Title$  AllClientsView��5   	   $	��750��6    $	��420��6-   ���#f4f8fb � WindowStartupLocation$ CenterScreen=�6N   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.1* �6   6,   �� 5      6   �� 5      $
��0.2* �6   6,   �� 5      $��0.05* �6   6-   .+�5   
   � 
�������.+�5      � $��0��6   $	��Top=�6%   $��10q�6=   .+�5      �� $*��$/Static Files/Images/Client Logo.png��6   $��60��6F   �� 5      $
��home��6   $
��Bold"�6(   $��18(�6:   $��	280 0 0 0q�6H   ���#01133D J� InputBindings 5      d� 5       d� Gesture$ 	LeftClicka�6'    �� Command 6;   �� *BackToHomeCommand+5      5      5      �� 5"   
   $��2��6   $��15q�6   $��65��6*   $��61��65   $	��Top=�6A   $��Right=�6Y   ��6u   �� *
NewCommand+.��5#      �� $$��/Static Files/Images/+ new.png��6   $��30��6<   5$      �� 5%   
   $��3��6   
�������$/��)Proudly created by Rustam Hasanli in 2023��63   $��Center=�6d   $��Center=�6�   6�   �� 5'   
   -   5        $��ClientsListView��5'         ClientsList#���   6_   $��1��6�   6�   5-      5.      