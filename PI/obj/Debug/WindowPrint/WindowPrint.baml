   M S B A M L   `   `   `  ����=  9PI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PIPI  5   	   clr-namespace:PIPI  5   	       PI.WindowPrint   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PI     5   	   &	viewModleclr-namespace:PI     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	      MaterialDesignBody#���   5
   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5   
    � Title$ WindowPrint��5   	   $	��630��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66    � 	Resources 5         PI.ViewModleWindowPrint  ViewModleWindowPrint��%   &	         5   
   6)   5      .��5      �� .��5   
   �  � DataContext# [ 6   .+�5      � -   5         �Name$ print��5       � RowDefinitions 5      �� 5      $	��150 �6$   �� 5      $	��800 �6$   .+�5      �� $��RightToLeft=�6    �� Orientation$ 
Horizontal=�69   $��20q�6R   $��0��6^   .+�5      �� $��/Images/deliver.png��6   $	��100��69   $	��100��6E   $��Center=�6S   �� 5       $��טופס שליחויות��6    $��Center=�65   $��Center=�6P   $��34(�6m   
���   �$��Normal$�6�   $
��Bold"�6�   �� 5!      $��                        ��6    $��Center=�6@   $��Center=�6[   $��34(�6x   
���   �$��Normal$�6�   $
��Bold"�6�   �� 5#      -   5        	 ��Name$	 printButton��5#      $
��Left=�6P   
����  �
�������$��60��6�   $��40��6�     MaterialDesignRaisedButton#���  5$      +  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth3=�5%      $��0,4,0,4.667q�66   ��5#   2   �� *	printUser+.��5&      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�63   $��24��6C   $��24��6O   
�������6Z   5'      5(      �� 5*      $��1��6   $��20q�6*   $��Stretch=�66   .+�5+      � $��Stretch=�6    � ColumnDefinitions 5,      �� 5-      $
��2.8* �6/   �� 5.      $��1* �6/   .+�50      �� $��RightToLeft=�6%   $��1��6A   $��10q�6Q   .+�51      �� $��פרטי מחלק:��6(   $��20(�6:   $��5q�6H   $
��Bold"�6S   �� 52      $�� ��6(   $��5(�60   $��5q�6=   $
��Bold"�6H   �� 53      $��שם פרטי: ��6(   $��15(�6:   $��5q�6H   �� 54      $��שם  משפחה: ��6(   $��15(�6;   $��5q�6I   �� 55      $��תאריך חלוקה:��6(   $��15(�6<   $��5q�6J   �� 56      $�� ��6(   $��20(�60   $��5q�6>   $
��Bold"�6I   57      �� 58      $��RightToLeft=�6%   $��0��6A   $��10q�6Q   .+�59      �� $�� ��6(   $��20(�60   $��5q�6>   $
��Bold"�6I   �� 5:      $�� ��6(   $��5(�60   $��5q�6=   $
��Bold"�6H   �� 5;      -   5         ��Name$ 	FirstName��5;   (   $��15(�6�   $��5q�6�   ��6;   �� *	firstName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5<      -   5        $ LastName��5<   (   $��15(�6�   $��5q�6�   ��6:   �� *
lastName+$ PropertyChanged=�$ TwoWay=�6�   �� 5=      -   5        $
 date��5=   (   $��15(�66   $��5q�6D   5>      5?      �� 5B      -   5         ��Name$ listView��5B      #��[ 61   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6q   $��2��6�   $��RightToLeft=�6�    �� View 5C      �� 5D       �� AllowsColumnReorder .  .P�5E   "   �� $��תעודת זהות��61    �� DisplayMemberBinding 6E   ��  �� Path$ recipients_id��� 5F   "   $��שם פרטי��61    6B   �� $ recipients_first_name��� 5G   "   $��שם משפחה��61    6C   �� $ recipients_last_name��� 5H   "   $��תאריך לידה��61    6E   �� $ recipients_date_of_birth� �� StringFormat$ 
dd-MM-yyyy���� 5I   "   $��
כתובת��61    6@   �� $ recipients_address��� 5J   "   $��
סטטוס��61    6@   �� $ recipients_status�5K      5M      5N      5O      5P      5S      5T      