   M S B A M L   `   `   `  ����=  9PI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PIPI  5   	       PI.WindowMain   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PI     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   
   $��Regular"�5
   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5   
    � Title$ 
WindowMain��5   	   $	��460��6   $	��600��6+    � WindowStartupLocation$ CenterScreen=�67    � WindowState$ 	Maximized=�6\   .��5      �  � ShowGridLines .   � RowDefinitions 5   
   �� 5      $	��35* �6   �� 5      $
��130* �6   �� 5      $	��40* �6   �� 5      $	��34* �6   .+�5   
   � $��1��6   $��2��6    � ColumnDefinitions 5      �� 5      $	��14* �6$   �� 5      $
��130* �6$   �� 5      $	��71* �6$   .+�5        � -   5          �Name$ myFrame��5       $��1��6%   $��2��62   $��1��6C   	  � NavigationUIVisibility$	 Hidden=�6S   ��6s   �� *UserControl+5!      )  #MaterialDesignThemes.Wpf.DrawerHost  5'   
   $��Stretch=�6$   $��Stretch=�6B   $��2q�6_     MaterialDesignDivider#���  6s   $��4��6�   ��5(      �� 5)      
 �� 
TargetType"
  6    �� BasedOn# [B 6B    �� Triggers 5*      �� 5+       �� Binding 6)   �� *	IsChecked+ �� ElementName$ BackgroundToggle�� �� Value True6i   .a�5,      ��  �� Property �@ OverlayBackground  PrimaryHueMidBrush �� Value# �  6D   5-      5/         LeftDrawerContent 51      �� 52      $��16q�6   $��Stretch=�6+   $��Stretch=�6J   $��1��6f   .+�53      �� 
��� ���$��17(�64   $��	ExtraBold"�6B   $��4q�6Y   $��Center=�6d   :תוכן עניינים6�   �� 54      
����  �$��4q�6Z   $��Center=�6e     MaterialDesignFlatButton#���  6�   ��63   �� *openAddDistributor+.��6�   הכנס מחלק6�   �� 55      
����  �$��4q�6X   $��Center=�6c   #���  6�   ��63   �� *openAddRecipient+.��6�   הכנס מחולק6�   �� 56      
����  �$��4q�6]   $��Center=�6h   #���  6�   ��63   �� *openUpdateDistributor+.��6�   עדכן מחלק6�   �� 57      
����  �$��4q�6\   $��Center=�6g   #���  6�   ��63   �� *openUpdateRecipients+.��6�   עדכן מחולק6�   �� 58      
����  �$��4q�6Q   $��Center=�6\   #���  6z   ��63   �� *	openFiles+.��6�   
דוחות6�   �� 59      
����  �$��4q�6Q   $��Center=�6\   #���  6z   ��63   �� *	openChart+.��6�   
גרפים6�   �� 5;         CloseDrawerCommand#��Z 6   $��4q�6`   $��Center=�6k   #���  6�   .��6�   
סגור6�   5=      .��5?      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Custom=�6'   
����  �
�������$��16q�6^      CornerRadius$ 3��6k   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6|   $��3��6�   .��5@      �  5A      �� 5B      $	��20* �6,   �� 5C      $
��200* �6,   �� 5D      $	��20* �6,   .+�5F      d� -   5        $��
menuBotton��5F   #    ' #MaterialDesignHamburgerToggleButton#���  65      OpenDrawerCommand#��Z 6v   "  System.Windows.Controls.Dock   Left#��Z 6�   $
��Left=�6�   $��Center=�6�   $��0��6  �� 5G      $��Center=�6    $��Center=�6<   $��22(�6Y   $
��Bold"�6g   
��� ���$��1��6�   �� 6�   $M�Gברוכים הבאים למערכת לניתוב חבילות מזון��6�   6�   �� 5H      -   5        $��Admin_identify��5H       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6U   
��� ���$��Right=�6�   $��2��6�    � ToolTip$2 ,MaterialDesignFloatingActionMiniAccentButton��5I      ���	#FFFAFAFA���	#DD000000 J� RenderTransformOrigin$ 3.334,0.481&�6�   $��0,0,0.4,-0.2q�6�   $
��Auto��6�   ��5H   4   �� *openAdminWin+.��5J      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=�63   $��24��6D   $��24��6P   5K      5L      5M      5N      �� 5P   
   $��Right=�6   $	��Top=�6,   $&�� /PI;component/Images/deliver.png��6E   $��2��6q   $��2��6~   $��0,0.2,-82.4,0q�6�   5X      5Y      