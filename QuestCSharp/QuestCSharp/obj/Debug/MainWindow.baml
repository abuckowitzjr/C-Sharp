   M S B A M L   `   `   `  ����F  BQuestCSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuestCSharpQuestCSharp  5   	       QuestCSharp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:QuestCSharp     5   	   -   5          �Name$  	QuestMain��5	   J    � Title$ Quest��5   	   $	��768��6   $
��1024��6$    � WindowStyle$
 None=�5	   	    � WindowState$ 	Maximized=�6    � 
ResizeMode$ NoResize=�64   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��0��6   $��4��6    � ColumnDefinitions 5      �� 5      �� 5      �� 5      5      � 5   
   $��4��6    5      �� 5      �� 5      �� 5      $	��150 �6#   .+�5      �� 
�������$
��1.75q�6,   $��4��6C   $��0��6Q   ._�5       �� -   5         ��Name$ chatScrollViewer��5       .��5!      �� -   5         ��Name$ 
chatInfoTB��5!      $��5,5,5,5q�62   $��50(�6C   	 �� TextWrapping$
	 Wrap=�6Q   $��0q�6e   6�   5"      5#      �� 5$      
�������$
��1.75q�6,   $��4��6C   $��1��6Q   ._�5%      �� -   5        $ gameScrollViewer��5%      .��5&      �� -   5        $ 
gameInfoTB��5&      $��5,5,5,5q�62   $��50(�6C   $
	 Wrap=�6Q   $��0q�6e   6�   5'      5(      �� 5)      
�������$
��1.75q�6,   $��4��6C   $��2��6P   ._�5*      �  5+      �� 5,      �� 5-      �� 5.      �� 5/      .+�52      �� -   5        
 ��Name$
 chrBtn��52      $	��125��6-   $��30��69   $��0��6V   .��6c   Character (C)6r   �� 53      -   5        $
 invBtn��53      $	��125��6-   $��30��69   $��1��6V   .��6c   Inventory (I)6r   �� 54      -   5        $
 sklBtn��54      $	��125��6-   $��30��69   $��2��6V   .��6c   
Skills (K)6o   �� 55      -	   5        $
 menuBtn��55      $	��125��6.   $��30��6:   $��3��6W   .��6d   
Menu (Esc)6p   56      57      58      �� 5;   
   5=      5>      5?      