   M S B A M L   `   `   `  ����D  @EventsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:EventsApp	EventsApp  5          EventsApp.ATM   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:EventsApp     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      X TXceed.Wpf.Toolkit, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5        � Title$	  ATM��5	      $	��400��5
      $	��400��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��5      $��0��5      $��2��5      $��Center=�5      $��Center=�5       $��Credit Card Machine��5!      $��40(�5"      �� 5#   
   $��1��5$      $��Center=�5%      $��Center=�5&      $��Customer Name:��5'      $��18(�5(      $
��Bold"�5)      �� 5*   
   -   5         ��Name$ lblErrorMsg��5+      $��4��5,      $��0��5-      $��2��5.      $��Center=�5/      $��Center=�50      $,��&Overdraft protection transfer of $0.00��51       � Cursor$
 Hand��52      $��18(�53      
���  �� � ToolTip$C =Click here to clear the overdraft protection transfer message��56      $y�Hidden=�57      �� 58   
   $��2��59      $��Center=�5:      $��Center=�5;      $��Amount��5<      $��18(�5=      $
��Bold"�5>      �� 5?   
   -   5        $ lblCustomer��5@      $��1��5A      $��1��5B      $
��Left=�5C      $��Center=�5D      $��<none>��5E      $��18(�5F      %  Xceed.Wpf.Toolkit.IntegerUpDown  5G   
   -   5          Name$ 	amountVal��5H      $��2��5I      $��2��5J      $	��150��5K      $
��Left=�5L      $��Center=�5M      $��18(�5N      �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]	   Minimum	 05O      ,  &Xceed.Wpf.Toolkit.Primitives.InputBase
   TextAlignment$

 Left=�5P         Value 05Q      �� 5R   
   -   5         ��Name$ btnMakePurchase��5S      $��3��5T      $��0��5U      $��2��5V      $��20q�5W      $��Center=�5X      $��Center=�5Y      $��Make Purchase��5[      $��25(�5\         RoundButton#���   5]      5^      5_      