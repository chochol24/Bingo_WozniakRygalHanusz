   M S B A M L   `   `   `  ����@  <Bingo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BingoBingo  5   	   =#clr-namespace:Bingo.Classes.ButtonsBingo.Classes.Buttons  5   	       Bingo.GameWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Bingo     5   	   7Buttons#clr-namespace:Bingo.Classes.Buttons     5   	     � Title$  
GameWindow��5	   	   $	��547��6   $	��850��6)    � 
ResizeMode$ CanMinimize=�65   ���	#FF9C8B8B.��5      � -   5         �Name$
 Main��5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��400 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   � -   5        $ Manager��5   ,   $��0��6   $��0��6   $��	0,10,0,10q�6=   .+�5      �� -   5         ��Name$ txbGeneratedNumber��5      $
��Left=�62   $��
533,23,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $��70��6�   $��46��6�   $��40(�6�   
���   �
�������$$��Bahnschrift SemiBold Condensed)�6�   �� 5      -   5         ��Name$ lblTitle��5      $��Wygenerowana liczba:��6&   $��Center=�6E   $��0,23,0,0q�6b   $	��Top=�6t   $	��262��6�   $��46��6�   $��28(�6�   $$��Bahnschrift SemiBold Condensed)�6�   �� 5      -   5        $ txbTimer��5      $
��Left=�6(   $��
142,23,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $��70��6�   $��46��6�   $��40(�6�   
���   �
�������$$��Bahnschrift SemiBold Condensed)�6�   �� 5      -   5        $ lblTimer��5      $�� Czas: ��6&   $
��Left=�68   $��	70,23,0,0q�6S   $	��Top=�6f   $��72��6~   $��46��6�   $��28(�6�   $$��Bahnschrift SemiBold Condensed)�6�   $
��Bold"�6�   �� 5      -   5         ��Name$ btnExit��5      $)��#Wyjdź do menu                     ��6&   $
��Left=�5      $��
669,14,0,0q�62   $	��Top=�6F   $��56��6^   $	��155��6j   ���	#FFCA8585
���   �$��2,2,2,2q�6�   $��30                     (�6�   $
��Bold"�5      $$��Bahnschrift SemiBold Condensed)�6)   5      +   %Bingo.Classes.Buttons.BingoFindButton  5   
   $��BingoFindButton��6"   $
��Left=�6<   $��1042,241,0,0q�6W   $��1��6m   $	��Top=�6z   5      5      