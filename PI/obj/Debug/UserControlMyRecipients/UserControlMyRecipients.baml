   M S B A M L   `   `   `  ����=  9PI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PIPI  5      clr-namespace:PIPI  5           PI.UserControlMyRecipients   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:PI     5      &	viewModleclr-namespace:PI     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        $��printMyList��5   
      MaterialDesignBody#���   5
   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5   
    � 	Resources 5         PI.ViewModelMyRecipients  ViewModelMyRecipients   PI.ConvertIDandDate  ConvertIDandDate��%:   &	       &	        5   
   6*     5   
   6!   5      .��5      � -   5         �Name$ myGrid��5       � DataContext# [ 6    � RowDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��70* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��7* �6#   �� 5       $��4* �6#   �� 5!      $��1* �6#   �� 5"      $��7* �6#   �� 5#      $��0 �6#   �� 5$      $��6* �6#   �� 5%      $��2* �6#   .+�5(      �� -   5        $��
comboBoxId��5(      $��0��6)   $��RightToLeft=�66   $��Center=�6R   $��Center=�6m   $��5��6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  בחר תעודת זהות��6�      
Foreground
 � ���.  (MaterialDesignThemes.Wpf.TextFieldAssist	   UnderlineBrush
	 � ���
   HintOpacity$	
 .26Q�5)   ;    �� 
IsEditable .  ��6z   �� *myDistributors+(  "System.Windows.Controls.DatePicker  5+      -   5        $��
datePicked��5+      $��0��6+   $	��120��68   $��3��6E   $��Center=�6V   $��Center=�6q   $ 
תאריך��5,      $��RightToLeft=�6*   
 � ���
	 � ��� ( $MaterialDesignFloatingHintDatePicker#��[ 5.      $��38.667,0,39.333,14.333q�6A   �� 50      $	��100��6   $��1��6B   
����  �  MaterialDesignRaisedButton#��[ 6h   3  -MaterialDesignThemes.Wpf.ButtonProgressAssist   Value$ -1Q�6�      IsIndicatorVisible .     IsIndeterminate . $��חפש��51   Z   ��50   "   �� *
searchList+��52      `� 53       `� 	Converter# [ 6#   .1�54      ��  �� Path$
 Text�6"    �� ElementName$ 
comboBoxId��6.   �� 55      $
 Text�6"   $ 
datePicked��6.   56      58      �� 5:      -   5         ��Name$ print��5:      $��0��6$   $��0��61   
����  �
�������$��60��6k   #���  5;      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5<      ��66   �� *	printUser+.��5=      '	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ Printer=�6+   $��24��6;   $��24��6G   
�������6R   ��5>      `� 5?      # [ 6#   .1�5@      �� $
 Text�6"   $ 
comboBoxId��6.   �� 5A      $
 Text�6"   $ 
datePicked��6.   5B      5D      5E      �� 5G   
   -   5         ��Name$ listView��5G      $ �� IsSynchronizedWithCurrentItem$
 TrueY�6%   $��1��6J   $��RightToLeft=�6W   ��6t   �� *listOfRecipients+ �� View 5H      �� 5I       �� AllowsColumnReorder .  .P�5J      �� $��תעודת זהות��6%    �� DisplayMemberBinding 69   �� *recipients_id+�� 5K      $��שם פרטי��6%    66   �� *recipients_first_name+�� 5L      $��שם משפחה��6%    67   �� *recipients_last_name+�� 5M      $��תאריך לידה��6%    69   �� *recipients_date_of_birth+ �� StringFormat$ 
dd-MM-yyyy���� 5N      $��
כתובת��6%    �� Width$	 200��6h    64   �� *recipients_address+6h   �� 5O      $��
סטטוס��6%   $	 150��6g    64   �� *recipients_status+6g   5P      5R      5T      5V      