   M S B A M L   `   `   `  ����W  SCE_UAA14WPF_Dec24_ClaudeMael, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CE_UAA14WPF_Dec24_ClaudeMaelCE_UAA14WPF_Dec24_ClaudeMael  5   	   -    'CE_UAA14WPF_Dec24_ClaudeMael.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:CE_UAA14WPF_Dec24_ClaudeMael     5   	     � Title$  
MainWindow��5   	   $
��1000��6   $
��1200��6*   ���#EBD9B4$
��Bold"�6L   $��22(�6^   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1* �6   6*   �� 5      $��8* �6   6*   �� 5      $��1* �6   6*   .+�5   
   �� $��34(�6   $��Center=�6#   $��Center=�6@   ���#9DBC98$"VERIFIONS VOS CONNAISSANCES en WPF6�   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��2* �6#   60   �� 5      $��1* �6#   60   .+�5!      � -   5         �Name$ gridMain��5!      5#      � 5%      $��1��6   ���#9DBC98.+�5&      �� $��Paramétrage��6   $	��Top=�60   .��5(      �� .+�5)      �� $��Choix de la disposition��6#   $	��Top=�6D   $��	10,0,0,40q�6\   $��10q�6o   .��5*      �� -   5         ��Name$
 stck��5*   )   .+�5+   "   	� -   5         	�Name$ radio_solitaire��5+   .   $��	Solitaire��6G    d� 	IsChecked$
 TrueY�6[   6n   	� 5,   "   -   5        $ radio_marelle��5,   .   $��Marelle��6E   6Y   	� 5-   "   -   5        $ radio_bande��5-   .   $��Une Bande Latérale��6C   6b   5.      50      �� 52      -   5         ��Name$ taille��52   #   $��Taille du plateau��63   $��0,0,0,30q�6N   .��53      �� .+�54   "   ��  �� Orientation$ 
Horizontal=�6-   $��0,10,0,5q�6F   .+�55   &   �� Nbre de Lignes6@   �� 56   &   -   5        	 ��Name$	 txtBox_lignes��56   .   $��30��6E   $��39,0,0,0q�6P   6d   57   #   �� 58   "   $ 
Horizontal=�6-   .+�59   &   �� Nbre de Colonnes6B   �� 5:   &   -   5        $	 
txtBox_col��5:   .   $��30��6B   $��10,0,0,0q�6M   6a   5;   #   5<      5=      5>      5A      �� 5C      -	   5        
 ��Name$
 btn_valider��5C      $��50��6.   $��VALIDER��6:   6N   5D      5E      �� 5G   
   -
   5         ��Name$ error��5G      $��2��6#   $��30(�60   $��Center=�6>   $��Center=�6[   
���  ��Test WPF 6T 20246�   5I      5J      