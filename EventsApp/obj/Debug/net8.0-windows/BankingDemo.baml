   M S B A M L   `   `   `  ����D  @EventsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:EventsApp	EventsApp  5          EventsApp.BankingDemo   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:EventsApp     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  Banking Application��5      $	��800��5	      $	��450��5
      ���#d7d7d7.��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��5      $��0��5      $��2��5      $��Banking Demo��5      $��40(�5       �� 5!   
   $��1��5"      $��0��5#      $��Customer��5$      $��18(�5%      $
��Bold"�5&      �� 5'   
   -   5         ��Name$ lblCustomer��5(      $��1��5)      $��1��5*      $��<None>��5+      $��18(�5,      �� 5-   
   $��2��5.      $��0��5/      $��Checking Balance��50      $��18(�51      $
��Bold"�52      �� 53   
   -   5        $ lblCheckingBalance��54      $��2��55      $��1��56      $��$0.00��57      $��18(�58      �� 59   
   $��3��5:      $��0��5;      $
��Left=�5<      $	��Top=�5=      $��Savings Balance��5>      $��18(�5?      $
��Bold"�5@      �� 5A   
   -   5         ��Name$ denyOverdraft��5B      $��3��5C      $��0��5D      $��2��5E      $��0,0,0,10q�5F      $��Center=�5G      $��Bottom=�5H      $��Center=�5I      $��Prevent Overdraft��5J      $��18(�5K       d� 	IsChecked$ falseY�5L       � ToolTip$� �Checking this button will prevent an overdraft transfer from savings to checking account\nThe user will only be able to withdraw money if they have enough in their checking account��5M      �� 5N   
   -   5        $ lblSavingBalance��5O      $��3��5P      $��1��5Q      $��$0.00��5R      $��18(�5S      �� 5T   
   -   5         ��Name$ btnRecordTransactions��5U      $��4��5V      $��2��5W      $��0��5X      $��2��5Y      $��20,10,20,10q�5Z      $��Center=�5[      $��Center=�5\      ���#999   RoundButton#���   5_      .��5`      �� $��18(�6    �� TextAlignment$ Center=�6&   Record�� 5a      Transactions5b      5c      �� 5d   
   -   5        $ lblErrorMsg��5e      $��0��5f      $��2��5g      $��2��5h      $��Center=�5i      $��Center=�5j      $7��1You had an overdraft protection transfer of $0.00��5k      	 � Cursor$
	 Hand��5l      $��18(�5m      
���  ��$C =Click here to clear the overdraft protection transfer message��5p      $y�Hidden=�5q      �� 5r   
   $��1��5s      $��2��5t      $��Checking Transactions��5u      $��18(�5v      $
��Bold"�5w      �� 5x   
   $��1��5y      $��3��5z      $��Savings Transactions��5{      $��18(�5|      $
��Bold"�5}      �� 5~   
   -   5        
 ��Name$
 checkingTransactions��5      $��2��5�      $��3��5�      $��2��5�      $��5,-50,20,30q�5�      
�������5�      �� 5�   
   -   5        $
 savingTransactions��5�      $��2��5�      $��3��5�      $��3��5�      $��5,-50,20,30q�5�      
�������5�      5�      5�      