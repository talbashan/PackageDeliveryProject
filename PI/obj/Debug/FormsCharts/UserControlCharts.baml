   M S B A M L   `   `   `  ����=  9PI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PIPI  5          PI.UserControlCharts   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:PI     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	   
   $��Regular"�5
   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��6* �6   �� 5      $
��0.5* �6   �� 5      $��6* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��1��6    $��Card Group Box��60   $��RightToLeft=�6H     MaterialDesignCardGroupBox#���  6d   $��16q�6�   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�5         
Background
 ��  �   
Foreground
 �������5      �� 5       .R�5!      ��  �� Orientation$ 
Horizontal=�6!   .+�5"      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ChartBar=�62   
��� ���$��32��6V   $��32��6b   $��Center=�6m   �� 5#      $��8,0,0,0q�6$   $��Center=�65    $  MaterialDesignSubtitle1TextBlock#��[ 6P   $��RightToLeft=�6�   
�������$
��Bold"�6�   $3��-גרף עמודות לפילוג חבילות��6�   5$      5%      .��5'      �� 
������ $��90��6O   $��Center=�6[   $��Center=�6v   $��0q�6�   ��6   �� *openBarChart+��5(      �� 5)      $��/Images/chartBar.png��6   $��50��6:   $��Center=�6G   $��Center=�6b     
imageStyle#��[ 6   	 � ToolTip	 5+      _� 5,      .��5-      �� $
��Bold"�6$   הצג6;   5.      50      51      �� 53   
   $��1��6   $��0��6    $��Card Group Box��60   $��RightToLeft=�6H   #���  6d   $��16q�6�   $ Custom=�54      
 ��  �
 �������55      �� 56      .R�57      �� $ 
Horizontal=�6!   .+�58        $ ChartPie=�62   
��� ���$��32��6V   $��32��6b   $��Center=�6m   �� 59      $��8,0,0,0q�6$   $��Center=�65   #��[ 6P   $��RightToLeft=�6�   
�������$
��Bold"�6�   $/��)גרף עוגה לפילוג חבילות��6�   5:      5;      .��5=      �� 
������ $��90��6O   $��Center=�6[   $��Center=�6v   $��0q�6�   ��6   �� *openPieChart+��5>      �� 5?      $��/Images/pie-chart-xxl.png��6   $��50��6?   $��Center=�6K   $��Center=�6f   #��[ 6�   	 5A      _� 5B      .��5C      �� $
��Bold"�6$   הצג6;   5D      5F      5G      �� 5I   
   $��3��6   $��0��6    $��Card Group Box��60   $��RightToLeft=�6H   #���  6d   $��16q�6�   $ Custom=�5J      
 ��  �
 �������5K      �� 5L      .R�5M      �� $ 
Horizontal=�6!   .+�5N        $ 
ChartDonut=�62   
��� ���$��32��6X   $��32��6d   $��Center=�6o   �� 5O      $��8,0,0,0q�6$   $��Center=�65   #��[ 6P   $��RightToLeft=�6�   
�������$
��Bold"�6�   $>��8גרף דונאט לפילוג סטטוס מחולקים��6�   5P      5Q      .��5S      �� 
������ $��90��6Q   $��Center=�6]   $��Center=�6x   $��0q�6�   ��6   �� *openDountChart+��5T      �� 5U      $��/Images/dount-chart.png��6   $��50��6=   $��Center=�6I   $��Center=�6d   #��[ 6�   	 5W      _� 5X      .��5Y      �� $
��Bold"�6$   הצג6;   5Z      5\      5]      �� 5^   
   $��3��6   $��1��6    $��Card Group Box��60   $��RightToLeft=�6H   #���  6d   $��16q�6�   $ Custom=�5_      
 ��  �
 �������5`      �� 5a      .R�5b      �� $ 
Horizontal=�6!   .+�5c        $ ChartTimelineVariant=�62   
��� ���$��32��6b   $��32��6n   $��Center=�6y   �� 5d      $��8,0,0,0q�6$   $��Center=�65   #��[ 6P   $��RightToLeft=�6�   
�������$
��Bold"�6�   $)��#גרף מקלות לוז עבודה��6�   5e      5f      .��5h      �� 
������ $��90��6R   $��Center=�6^   $��Center=�6y   $��0q�6�   ��6   �� *openSticksChart+��5i      �� 5j      $��/Images/chartFour.png��6   $��50��6;   $��Center=�6G   $��Center=�6b   #��[ 6�   	 5l      _� 5m      .��5n      �� $
��Bold"�6$   הצג6;   5o      5q      5r      �� 5t   
   -   5        
 ��Name$
 label��5t      $��0��6   $��2��6,   $��
גרפים��6@   $��40(�6P   $
��Bold"�6^   $��Italic$�6p   
����  �$��Center=�6�   $��Center=�6�   5v      5x      