   M S B A M L   `   `   `  ����=  9PI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PIPI  5   	       PI.WindowAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PI     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   
   $��Regular"�5
   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
    � WindowStartupLocation$ CenterScreen=�5   
    � WindowStyle$
 None=�5   	     MaterialDesignFont#���  5   
   $	��350��5   
   $	��350��6    � 	Resources 5         PI.convertAdminFromView  convertAdminFromView��%   &	         5   
   6D   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6    � ColumnDefinitions 5   
   �� 5       $	��10* �6   �� 5!      $	��60* �6   �� 5"      $	��10* �6   .+�5%   
   �� -   5         ��Name$ 	idTextBox��5%      $��1��6'   $��1��64   $��RightToLeft=�6E   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ תעודת זהות��5&      	   
Foreground
	 ��  �.  (MaterialDesignThemes.Wpf.TextFieldAssist
   UnderlineBrush

 ��  � % !MaterialDesignFloatingHintTextBox#��[ 5)      $��Center=�5*      �� 5,   
   -   5        $ nameTextBox��5,      $��2��6'   $��1��64   $��RightToLeft=�6E   $ שם משתמש��5-      
	 ��  �

 ��  �#��[ 50      $��Center=�51      �� 53   
   -   5        $ passTextBox��53      $��3��6(   $��1��65   $��RightToLeft=�6F   $ 
סיסמה��54      
	 ��  �

 ��  �#��[ 57      $��Center=�58      �� 5;   
   $��1��6   $��0��6$   $��Center=�61   $
��Wrap=�6O   $!��התחברות למערכת��6c   $��Center=�6y   
����  �6�   �� 5?   
   $��1��6   $��4��6!   
����  � & "MaterialDesignFloatingActionButton#��[ 5@       � ToolTip$( "MaterialDesignFloatingActionButton��5A      ��5?   D   �� *
AddCommend+.��5B      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	CheckBold=�6'   $��24��69   $��24��6E   ��5C      `� 5D       `� 	Converter# [ 6   .1�5E      ��  �� Path$
 Text�6    �� ElementName$ 	idTextBox��6*   �� 5F      $
 Text�6   $ nameTextBox��6*   �� 5G      $
 Text�6   $ passTextBox��6*   5H      5J      5L      5M      