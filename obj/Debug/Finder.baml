   M S B A M L   `   `   `  ����C  ?Notepad2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Notepad2Notepad2  5   	       Notepad2.Finder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Notepad2     5   	   -   5          � 
ResizeMode$  NoResize=�5       � WindowStartupLocation$ CenterOwner=�5   	    � ShowInTaskbar .   � Title$ Finder��5
   	   $	��140��6   $	��370��6%    � Icon$ /Magnifier (Custom).png��6a   .��5      �� ���	#FFF0F0F0.+�5   
   �� $��Fi_nd what:��6   $��Center=�6&   $	��Top=�5       �� Left$ 10��6(   
 �� Top$ 10��5      �� 5   
   -   5         ��Name$ 
SearchText��5      $	��194��6&   $��20��62   $ 73��5      $ 14��6#   $
��Left=�5      $��Center=�6-   �� 5   
   -   5         ��Name$ FindNextBtn��5      $��	Find Next��6&   $��22��6:   $��70��6F   $	 275��5      $ 12��6#   $
��Left=�63   $��Center=�5      6,   �� 5   
   -   5        $ 	Cancelbtn��5      $��Cancel��6$   $��22��65   $��70��6A   $	 275��5      $ 39��6#   $��Center=�63   $	��Top=�5      6)   �� 5   
   $��	Direction��6   $	 151��6&   $ 39��68   $
��Left=�6H   $��Center=�6c   .��5      �� 	 �� Orientation$	 
Horizontal=�6   .+�5      	� -   5        $��UpRBtn��5      $��Up��6,   
 d� 	IsChecked$

 TrueY�5       $��5q�6/   	� 5"      -   5        $��DownRBtn��5"      $
��Down��6.   $��5q�5#      5$      5%      �� 5'   
   $
��Left=�6   $ 48��60   $��Center=�6@   $ 8��6[   .+�5(      �� -   5         ��Name$ ChkMatchCase��5(      $��
Match case��6-   $��5q�6B   �� 5)      -   5        $ ChkWrapAround��5)      $��Wrap Around��6.   $��5q�6D   5*      5+      5,      