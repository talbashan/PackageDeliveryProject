   M S B A M L   `   `   `  ����=  9PI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PIPI  5   	   clr-namespace:PIPI  5   	       PI.WindowMessageBox   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PI     5   	   &	viewModleclr-namespace:PI     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5
   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
    � WindowStartupLocation$ CenterScreen=�5   
    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������   MaterialDesignFont#���  5   
    � Title$ WindowMessageBox��5   	   $	��200��6"   $	��400��6/   .��5      ��  �� CornerRadius$ 10��6   $��8q�6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      � 	 � Color$	 LightSlateGray��6   
 � Offset$	
 0.0Q�66   5      ._�5   
   � 
������� � RowDefinitions 5      �� 5      $	��50* �6   �� 5      $	��10* �6   �� 5       $
��150* �6   �� 5!      $	��50* �6   �� 5"      $	��10* �6   .+�5$   
   �� -   5        $��header��5$      $��RightToLeft=�6   $��15(�6:   
�������$��Center=�6^   $��0��6z   6�   � 5%   
   $��2��6    � ColumnDefinitions 5&      �� 5'      $	��30* �6#   �� 5(      $	��70* �6#   .+�5*      �� -   5        $��content��5*      $��RightToLeft=�6#   $��12(�6?   $��1��6M   
���   �$��Stretch=�6q   $��Stretch=�6�   6�   �� 5+      -   5         ��Name$ error��5+      $��70��6#   $6��0/Images/icontexto-message-types-error-orange.png��6.   �� 5,      -   5        $ alert��5,      $��70��6#   $6��0/Images/icontexto-message-types-alert-orange.png��6.   5.      � 5/   
   $��3��6    50      �� 51      $	��30* �6#   �� 52      $	��50* �6#   �� 53      $	��30* �6#   .+�55      �� $��1��6   $��Stretch=�6%   
����  �
�������$��
אישור��6�   $��20(�6�   $
��Bold"�6�    ! MaterialDesignFlatMidBgButton#��[ 6�    � ToolTip$! MaterialDesignFlatMidButton��6�   ��6A   �� *close+6�   58      59      5:      5;      