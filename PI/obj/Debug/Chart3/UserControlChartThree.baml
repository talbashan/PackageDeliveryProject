   M S B A M L   `   `   `  ����=  9PI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PIPI  5      clr-namespace:PIPI  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5	          PI.UserControlChartThree   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:PI     5      &	viewModleclr-namespace:PI     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5	      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
         MaterialDesignBody#���   5   
   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignFont#���  5   
    � 	Resources 5         PI.ViewModleChartThree  ViewModleChartThree��%   &	         5   
   6(   5      .��5      �  � DataContext# [ 6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
     LiveCharts.Wpf.PieChart  -   5        $��Chart��5      $��1��6$   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=�6U      InnerRadius$	 100Q�6m   $
��0 15q�6      Series 61   �� *SeriesCollection+   ChartLegend 5      "  LiveCharts.Wpf.DefaultLegend  5      	   
BulletSize$	 20Q�6$   66   
   DataTooltip
 5       #  LiveCharts.Wpf.DefaultTooltip  5!         
BulletSize$ 20Q�6%   67   5#      5$      5%      