   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5      !    WpfApp1.Views.ConductorView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Views     5      ^ ZCaliburn.Micro.Platform, Version=4.0.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5        N� Title$  ConductorView��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��40,20q�6.   .+�5      �� -   5         ��Name$ AddTab��5      $��Add Tab��6%   $��0,0,10,0q�67   �� 5      -   5        $ CloseTab��5      $��	Close Tab��6'   5      �� 5   
   -   5         ��Name$ Items��5      $��1��6!    �� DisplayMemberPath$ DisplayName��6.   $
��40,0q�6N   ��5      �� 5      .R�5      $�  $� Orientation$ 
Horizontal=�6-   5      5      �� 5!   
   $��2��6?   $��40,20q�6L     Caliburn.Micro.View   Model 6   �� *
ActiveItem+6L   5#      5$      