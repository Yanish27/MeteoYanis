   M S B A M L   `   `   `  ����E  AMeteoYanis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MeteoYanis
MeteoYanis  5   	       MeteoYanis.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MeteoYanis     5   	   -   5          �Name$  MeteoYanis_��5   	    � Title$ Météo Yanis��5   	   $	��374��6   $	��324��6*   
���   � � 
ResizeMode$ NoResize=�6I    � Icon$ /unnamed.png��6_   4  .System.Windows.Automation.AutomationProperties   Name$ Météo Yanis��6s   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ 
ComboVille��5      $
��Left=�6'   $��	26,21,0,0q�6B   $	��Top=�6U   $	��258��6m   $��22��6�   ��5      �� 5       �� EndPoint$	 0,1&�6&   .��5      �  � Color$ 	#FFF0F0F0��6#   � 5      $ White��6#   	 � Offset$	 1Q�61   5      5      �� 5   
   -   5        
 ��Name$
 TxtTemp��5      $��Température :��6!   $
��Left=�69   $��	26,48,0,0q�6T   $	��Top=�6g   
�������$��88��6�   $��26��6�   �� 5   
   -   5        $
 	LabelTemp��5      $
��99°��6#   $
��Left=�61   $��
119,48,0,0q�6L   $	��Top=�6`   
�������$	��165��6�   $��26��6�   �� 5   
   -   5        $
 TxtHumidite��5      $��Humidité :��6%   $
��Left=�6:   $��	26,79,0,0q�6U   $	��Top=�6h   
�������$��88��6�   $��26��6�   �� 5   
   -   5        $
 LabelHum��5      $	��99%��6"   $
��Left=�60   $��
119,79,0,0q�6K   $	��Top=�6_   
�������$	��165��6�   $��26��6�   �� 5   
   -   5        $
 TxtRessenti��5      $��
Ressenti :��6%   $
��Left=�6:   $��
26,110,0,0q�6U   $	��Top=�6i   
�������$��88��6�   $��26��6�   �� 5   
   -   5        $
 LabelTempRESSENTI��5      $��10 °��6+   $
��Left=�6:   $��119,110,0,0q�6U   $	��Top=�6j   
�������$	��165��6�   $��26��6�   �� 5   
   -	   5        $
 TxtLeveSoleil��5      $��Levé soleil :��6'   $
��Left=�6?   $��
26,141,0,0q�6Z   $	��Top=�6n   
�������$��88��6�   $��26��6�   �� 5   
   -
   5        $
 LabelLeveSoleil��5      $��10h20��6)   $
��Left=�69   $��119,141,0,0q�6T   $	��Top=�6i   
�������$	��165��6�   $��26��6�   �� 5   
   -   5        $
 TxtCoucheSoleil��5      $��Couché soleil :��6)   $
��Left=�6C   $��
26,172,0,0q�6^   $	��Top=�6r   
�������$��88��6�   $��26��6�   �� 5    
   -   5        $
 LabelCoucheSoleil��5       $��10h20��6+   $
��Left=�6;   $��119,172,0,0q�6V   $	��Top=�6k   
�������$	��165��6�   $��26��6�   �� 5!   
   -   5         ��Name$ ImgLabel��5!      $
��Left=�6"   $��96��6=   $��107,234,0,0q�6I   $	��Top=�6^   $��96��6v   $��/unnamed.png��6�   �� 5"   
   -   5        $
 TxtVitesseVent��5"      $��Vent :��6(   $
��Left=�69   $��
26,203,0,0q�6T   $	��Top=�6h   
�������$��88��6�   $��26��6�   �� 5#   
   -   5        $
 	LabelVent��5#      $��99 km/h��6#   $
��Left=�65   $��119,203,0,0q�6P   $	��Top=�6e   
�������$	��165��6�   $��26��6�   5%      5&      