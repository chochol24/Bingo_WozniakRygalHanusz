   M S B A M L   `   `   `  ����@  <Bingo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BingoBingo  5   	       Bingo.GameWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Bingo     5   	     � Title$  
GameWindow��5   	   $	��500��6   $	��800��6)   .��5
      � -   5         �Name$
 Main��5
       � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      $	��400 �6   6+    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   .+�5   
   � -   5        $ Manager��5   ,   $��0��6   $��0��6   $��	0,10,0,10q�6=   .+�5      �� -   5         ��Name$ txbGeneratedNumber��5      $
��Left=�62   $��
512,23,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��111��6�   $��46��6�   $��24(�6�   �� 5      $��Wygenerowana liczba:��6   $
��Left=�63   $��
258,23,0,0q�6N   $	��Top=�6b   $	��249��6z   $��46��6�   $��24(�6�   �� 5      -   5        $ txbTimer��5      $
��Left=�6(   $��
142,23,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��100��6�   $��46��6�   $��24(�6�   �� 5      $��Timer��6   $
��Left=�6$   $��	65,23,0,0q�6?   $	��Top=�6R   $��72��6j   $��46��6u   $��24(�6�   5      5      5      