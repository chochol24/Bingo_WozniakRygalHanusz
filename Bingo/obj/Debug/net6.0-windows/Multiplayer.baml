   M S B A M L   `   `   `  ����@  <Bingo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BingoBingo  5   	       Bingo.Multiplayer   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Bingo     5   	     � Title$  Multiplayer��5   	   $	��460��6   $	��829��6*    � 
ResizeMode$ CanMinimize=�66   ���	#FF9C8B8B.��5	      � .+�5
   
   �� -   5         ��Name$ Serwer��5
      $��
Hostuj gre��6!   $
��Left=�66   $��561,107,0,0q�6Q   $	��Top=�6f   $��85��6~   $	��180��6�   
���   ����	#FFCA8585$��2,2,2,2q�6�   $$��Bahnschrift SemiBold Condensed)�6�   $��48(�6  $
��Bold"�6*  �� 5   
   -   5        $ Klient��5      $��Dołącz do gry��6!   $
��Left=�69   $��252,326,0,0q�6T   $	��Top=�6i   $��85��6�   $	��294��6�   
���   ����	#FFCA8585$��2,2,2,2q�6�   $$��Bahnschrift SemiBold Condensed)�6�   $��48(�6  $
��Bold"�6-  �� 5   
   $
��Left=�6   $��
96,346,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   ${�False��6o   $��24(�6�   �� 6�    � Language$ pl-pl�6�   $�	Podaj IP:��6�   $$��Bahnschrift SemiBold Condensed)�6�   $
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ daneIP��5      $
��Left=�6"   $��
29,380,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��200��6}    �� TextAlignment$ Center=�6�   $��30��6�   $��26(�6�   $
��Bold"�6�   
�������$$��Bahnschrift SemiBold Condensed)�6�   
���   �6
  �� 5   
   $
��Left=�6   $��
602,39,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��27��6o   $��98��6{   $��24(�6�    �� TextAlignment$ Center=�6�   �� 6�   $ pl-pl�6�   $�
IP serwera��6�   $$��Bahnschrift SemiBold Condensed)�6�   $
��Bold"�6�   6  �� 5   
   -   5        $ 	txtIPserw��5      $
��Left=�6%   $��
576,71,0,0q�6@   $
 Wrap=�6T   $	��Top=�6h   $	��150��6�    �� 
IsReadOnly$
 True��6�   	 � Cursor$	 Arrow��6�   
 �� IsReadOnlyCaretVisible$

 True��6�   $��30��6�   $ Center=�6�   
�������$$��Bahnschrift SemiBold Condensed)�6   $��26(�6,  
���   �$|�False��6N  �� 5   
   -   5         ��Name$ lstGameType��5      $��215,17,282,337q�6R   ���	#FFFFE4E4
���   �$��2,2,2,2q�6�   $	��332��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��22(�6  $��90��6%  �� 5   
   -   5        $ lstBoardSize��5      $��215,112,282,242q�6S   ���	#FFFFE4E4
���   �$��2,2,2,2q�6�   $	��332��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��22(�6  $��90��6(  �� 5   
   -   5        $ lstCategory��5      $��214,209,283,145q�6R   ���	#FFFFE4E4
���   �$��2,2,2,2q�6�   $	��332��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��22(�6  $��90��6&  �� 5   
   $
��Wrap=�6   $��Wybierz tryb gry:��6(   $ Right=�6A   $��26(�6W   $$��Bahnschrift SemiBold Condensed)�6e   $
��Bold"�6�   $��0,18,620,359q�6�   �� 5   
   $
��Wrap=�6   $��Wybierz rozmiar planszy:��6(   $	��180��6H   $��Right=�6T   $ Right=�6p   $$��Bahnschrift SemiBold Condensed)�6�   $
��Bold"�6�   $��26(�6�   $��0,112,620,252q�6�   �� 5   
   $
��Wrap=�6   $��Wybierz kategorię:��6(   $	��180��6B   $��Right=�6N   $ Right=�6j   $$��Bahnschrift SemiBold Condensed)�6�   $
��Bold"�6�   $��26(�6�   $��0,210,620,145q�6�   �� 5   
   -   5        $ btnBack��5      $��Wróć��6"   $
��Left=�61   $��651,326,0,0q�6L   $	��Top=�6a   $��85��6y   $	��129��6�   ���	#FFCA8585
���   �$��2,2,2,2q�6�   $��48(�6�   $
��Bold"�6�   $$��Bahnschrift SemiBold Condensed)�6  5      5      