   M S B A M L   `   `   `  ����C  ?Notepad2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Notepad2Notepad2  5   	       Notepad2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Notepad2     5   	   -   5          � Title$  Untitled - Notepad��5   	   $	��450��6$   $	��800��61    � Icon$ /icons8-notepad-64.png��6V    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.New��5      5        5   
   -   5        $ ApplicationCommands.Open��5      5        5   
   -   5        $ ApplicationCommands.Save��5      5        5   
   -   5        $" local:NotepadCommands.SaveAs��5      5        5   
   -   5        $ ApplicationCommands.Print��5      5        5   
   -   5        $  ApplicationCommands.Delete��5      5        5   
   -   5        $ ApplicationCommands.Find��5      5        5!   
   -	   5        $! ApplicationCommands.Replace��5!      5#        5'   
   -
   5        $% local:NotepadCommands.NewWindow��5'      5(        5*   
   -   5        $* $local:NotepadCommands.SearchWithBing��5*      5,        5.   
   -   5        $$ local:NotepadCommands.FindNext��5.      50        52   
   -   5        $( "local:NotepadCommands.FindPrevious��52      54        56   
   -   5        $  local:NotepadCommands.GoTo��56      57        59   
   -   5        $$ local:NotepadCommands.TimeDate��59      5:      .��5=      �  � RowDefinitions 5>   
   �� 5?      $
��auto �6   �� 5@      �� 5A      $
��auto �6   .+�5D   
   o� -   5        $��Menubar��5D   4      
MenuStyle1#���   6   $��0��6C   .@�5G      m�   MenuItemStyle1#���  6   $��_File��6@   .@�5I      m� $
��_New��6    m� Command$ ApplicationCommands.New��6)   m� 5J      $��New _Window��6   $% local:NotepadCommands.NewWindow��60   m� 5K      $��_Open...��6   $ ApplicationCommands.Open��6-   m� 5L      $��_Save��6   $ ApplicationCommands.Save��6*   m� 5M      $��Save _As...��6   $" local:NotepadCommands.SaveAs��60   �� 5N      m� 5O      -   5        $��Page Set_up...��5O      63   m� 5P      $��	_Print...��6   $ ApplicationCommands.Print��6.   �� 5Q      m� 5R      -   5        $��E_xit��5R      6*   5S      m� 5V      $��_Edit��6   .@�5W      m� $��_Undo��6   $ ApplicationCommands.Undo��6*   �� 5X      m� 5Y      $
��Cu_t��6   $ ApplicationCommands.Cut��6)   m� 5Z      $��_Copy��6   $ ApplicationCommands.Copy��6*   m� 5[      $��_Paste��6   $ ApplicationCommands.Paste��6+   m� 5\      $��De_lete��6   $  ApplicationCommands.Delete��6,   �� 5]      m� 5^      $��_Search with Bing...��6   $* $local:NotepadCommands.SearchWithBing��69   m� 5_      $��_Find��6   $ ApplicationCommands.Find��6*   m� 5`      $��
Find _Next��6   $$ local:NotepadCommands.FindNext��6/   m� 5a      $��Find Pre_vious��6   $( "local:NotepadCommands.FindPrevious��63   m� 5b      $��_Replace...��6   $! ApplicationCommands.Replace��60   m� 5c      $��	_Go To...��6   $  local:NotepadCommands.GoTo��6.   �� 5d      m� 5e      $��Select _All��6   $# ApplicationCommands.SelectAll��60   m� 5f      $��
Time/_Date��6   $$ local:NotepadCommands.TimeDate��6/   5h      m� 5k      $��F_ormat��6   .@�5l      m� -   5        $��WordWrapMenuitem��5l       m� IsCheckable . $��
_Word Wrap��6F   6}   m� 5m      -   5        $��_Font...��5m      6-   5n      m� 5q      $��_View��6   .@�5r      m� $��_Zoom��6   .@�5s      m� $��Zoom _In��6   m� 5t      $��	Zoom _Out��6   m� 5u      $��_Restore Default Zoom��6   5v      m� 5x      -   5        $��StatusbarMenuItem��5x       . $��_Status Bar��6G   6�   5y      m� 5|      $��_Help��6   .@�5}      m� -   5        $��
View _Help��5}      6/   m� 5~      -   5        $��Send _Feedback��5~      63   �� 5      m� 5�      -   5        $��_About Notepad��5�      63   5�      5�      �� 5�   
   -   5        $��TextArea��5�   :     TextBoxStyle1#���  6   $��Calibri)�6J   $��16(�6_   $��Normal$�5�      $��1��6%    �� AcceptsReturn .  �� 
AcceptsTab . "	 �� VerticalScrollBarVisibility$	 Visible=�5�      $
 �� HorizontalScrollBarVisibility$
 Visible=�5�      .��6]    � ContextMenu 5�      �� 5�      -   5        $��CustomContextMenu��5�        ContextMenuStyle1#���  67   .@�5�      m� $��_Undo��6   $ ApplicationCommands.Undo��6.    m� InputGestureText$  ��6Q   �� 5�      m� 5�      $
��Cu_t��6   $ ApplicationCommands.Cut��6-   $  ��6O   m� 5�      $��_Copy��6   $ ApplicationCommands.Copy��6.   $  ��6Q   m� 5�      $��_Paste��6   $ ApplicationCommands.Paste��6/   $  ��6S   m� 5�      $��De_lete��6   $  ApplicationCommands.Delete��60   $  ��6U   �� 5�      m� 5�      $��Select _All��6   $# ApplicationCommands.SelectAll��64   $  ��6\   �� 5�      m� 5�      -   5        $��RightToLeftMenuitem��5�       . $��Right to Left��6M   6�   m� 5�      $��_Search with Bing...��6   $* $local:NotepadCommands.SearchWithBing��6=   $  ��6l   5�      .��5�   #   5�      �� 5�   
   -   5        $��NotepadStatusBar��5�      $��2��6-   
�������$��0,1,0,0q�5�   ,   ��5�      �� 5�      .R�5�      �  � ColumnDefinitions 5�      �� 5�      62   �� 5�      $
��auto �6/   6>   �� 5�      $
��auto �6/   6>   �� 5�      $
��auto �6/   6>   �� 5�      $
��auto �6/   6>   �� 5�      $
��auto �6/   6?   �� 5�      $
��auto �6/   6>   �� 5�      $
��auto �6/   6>   5�      5�      .@�5�      �� $��0��6   $��Right=�5�      
�������5�   1   �� 5�      -   5        $��CaretLocationStatus��5�   -   $��1��6   $��Right=�5�      $	��130��5�      .��6)   Ln 1, Col 166   �� 5�      -   5         ��Name$ 	separator��5�      $��2��5�      $��Right=�5�      
�������5�   1   �� 5�      $��3��6   $��Right=�5�      $��60��5�      .��6'   100%6-   �� 5�      $��4��6   $��Right=�5�      
�������5�   1   �� 5�      $��5��6   $��Right=�5�      $	��130��5�      .��6(   Windows (CRLF)68   �� 5�      $��6��6   
�������$��Right=�5�      67   �� 5�      $��7��6   $��Right=�5�      $	��100��5�      .��6(   UTF-86/   5�      5�      5�      