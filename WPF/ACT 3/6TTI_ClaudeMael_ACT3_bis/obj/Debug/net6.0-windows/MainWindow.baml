   M S B A M L   `   `   `  ����S  O6TTI_ClaudeMael_ACT3_bis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:_6TTI_ClaudeMael_ACT3_bis_6TTI_ClaudeMael_ACT3_bis  5   	   *    $_6TTI_ClaudeMael_ACT3_bis.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:_6TTI_ClaudeMael_ACT3_bis     5   	     � Title$3  -RESERVATION AU CENTRE DE VACANCES ASTY-MOULIN��5   	   $	��450��6?   $	��700��6L   $��15(�6X   .��5	      � 
���  �� � ColumnDefinitions 5
   
   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,    � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   �� 5      $��1* �6   6*   .+�5   
   �� 
��� ���$��Type de Logement��6)   $��50, 10,0, 10q�6C   $��2q�6Y   .��5      �� $
��0,20q�6   .+�5      	� 
��� ���$��CHALET��62   $
��Left=�6C   $	��Top=�6^   	� 5      
��� ���$��TENTE��62   $
��Left=�6B   $	��Top=�6]   5      5      �� 5   
   
��� ���$
��Bold"�6)   $��1��6;   $��RESERVATION��6H   $��	50,50,0,0q�6^   6s   �� 5    
   
��� ���$ ��CARACTERISTIQUES DE SEJOUR��6)   $��50,10,50,10q�6M   $��2q�6b   $��1��6v   $��2��6�   $��2��6�   .��5"      �� .+�5#      ��  �� Orientation$ 
Horizontal=�6   $
��5,10q�66   .+�5$      �� 
��� ���$��1��65   $��20��6E   $	��Top=�6Q   $��2��6l   #!Nbre de Personnes (entre 1 et 6):6�   �� 5%      -   5         ��Name$ txtbox_personnes��5%      $��1��68   $��2��6H   $��20��6\   $��30��6h   $	��Top=�6s   $��Right=�6�   6�   5&      �� 5'      $ 
Horizontal=�6   $
��5,10q�66   .+�5)      �� 
��� ���$��1��64   $	��Top=�6D   $��2��6_   Date d'arrivée :6�   (  "System.Windows.Controls.DatePicker  5*      -   5          Name$ date_arrivee��5*   !   $��1��67   $��2��6G   $	��Top=�6[   $��Right=�6s   6�   5+      �� 5-      $ 
Horizontal=�6   $
��5,10q�66   .+�5/      �� 
��� ���$��1��60   $	��Top=�6@   $��2��6[   $��1��6o   Date de sortie :6�     50      -   5        $ date_sortie��50      $��1��62   $��2��6B   $��2��6V   $	��Top=�6g   $��Right=�6   6�   51      �� 53      $ 
Horizontal=�6   $
��5,10q�67   .+�55      �� -   5         ��Name$ 	btn_duree��55      $��1��60   $��1��6@   $��30��6M   $	��110��6Y   $��DUREE SORTIE��6e   $
��Bold"�6|   6�   �� 56      -   5         ��Name$ semaine��56       
��� ���$��1��6E   $��1��6U   $��Center=�6b   $��10q�6}   $��2��6�   Durée en semaines6�   57      59      5:      �� 5<   
   
��� ���$��15(�6'   $��	RESULTATS��65   $��2��6H   $��2��6U   $��2q�6i   $��	5,5,50,10q�6}   .��5=      �� .+�5?      �� 
��� ���$��2��60   Prix à payer :6O   �� 5@      
��� ���$��2��60   Nombre de semaines :6U   5A      5B      �� 5D   
   $��2��6   $��2��6   $��CALCULER��6.   $��25��6A   $	��125��6M   $��18(�6Y   $
��Bold"�6g   $	��Top=�6y   $��0,30,0,0q�6�   6�   �� 5E   
   $��2��6   $��2��6   $
��INIT��6.   $��25��6=   $	��125��6I   $��18(�6U   $
��Bold"�6c   $	��Top=�6v   $��0,70,0,0q�6�   6�   5G      5H      