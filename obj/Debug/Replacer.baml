   M S B A M L   `   `   `  ����C  ?Notepad2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Notepad2Notepad2  5   	       Notepad2.Replacer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Notepad2     5   	   -   5          � ShowInTaskbar  .   � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterOwner=�6    � Title$ Replacer��5	   	   $	��195��6   $	��357��6'    � Icon$ /replace.png��6c   .��5
      �� ���	#FFF0F0F0.+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�5      $	��340��60   $��0,8,0,0q�5      .+�5      �� $��Fi_nd what:��6   �� 5      -   5         ��Name$ 
SearchText��5      $	��172��6*   $��22��5      $��	16,0,10,0q�6"   �� 5      -   5         ��Name$ FindNextBtn��5      $��	Find Next��6*   $��0,0,5,0q�5      $��22��6&   $��73��62   5      5      �� 5   
   $ 
Horizontal=�6   $
��Left=�5      $	��340��60   
 �� Top$ 37��5      $��Center=�6%   	 �� Left$	 1��5      .+�5      �� $��Re_place with:��6   �� 5      -   5        $ ReplaceText��5      $	��172��6+   $��22��67   $��0,0,6,0q�5      �� 5      -   5        $ replaceNextBtn��5      $��Replace��6-   $��5,0,5,0q�5      $��22��6&   $��73��62   5      5       �� 5"   
   -   5        $ replaceAllBtn��5"      $��Replace All��6(   $��22��5#      $��73��6   $
��Left=�5$      $		 263��6,   $��Center=�5%      $ 66��6,   �� 5&   
   -   5        $ cancelButton��5&      $��Cancel��6'   $��22��5'      $��73��6   
 �� IsCancel
 . $��Center=�5(      $		 263��6.   $	��Top=�5)      $ 92��6)   5*      �� 5,   
   -   5         ��Name$ ChkMatchCase��5,      $��Match _case��6)   $	 5��5-      $	 105��6#   $
��Left=�5.      $��Center=�5/      �� 50   
   -	   5        $ ChkWraparound��50      $��W_rap around��6*   $	 5��51      $	 132��6#   $��Center=�52      $	��Top=�53      56      57      