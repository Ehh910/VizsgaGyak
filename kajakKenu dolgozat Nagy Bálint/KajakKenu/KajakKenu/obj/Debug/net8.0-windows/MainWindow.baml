   M S B A M L   `   `   `  ����D  @KajakKenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:KajakKenu	KajakKenu  5   	       KajakKenu.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:KajakKenu     5   	     � Title$  
MainWindow��5   	   $	��555��6   $
��1202��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridhaha��5
      $
��Left=�6)   $	��232��6D   $��	29,38,0,0q�6Q   $	��Top=�6d      AutoGenerateColumns$ False��6|   $
��auto��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Név��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Nev+  5      $ Azonosító��6%    68   �� *	Azonosito+  5      $ Tipus��6%    64   �� *Tipus+  5      $ Elvitel Óra��6%    6:   �� *
ElvitelOra+  5      $ Elivtel perc��6%    6;   �� *ElvitelPerc+  5      $ Visszahozás Óra��6%    6>   �� *	VisszaOra+  5      $ Visszahozás Perc��6%    6?   �� *
VisszaPerc+5      �� 5   
   -   5         ��Name$ ComboOra��5      $
��Left=�6%   $��48��6@   $��
545,79,0,0q�6L   $	��Top=�6`   $	��176��6x   .@�5      �� $��6��6   �� 5      $��7��6   �� 5      $��8��6   �� 5      $��9��6   �� 5      $��10��6   �� 5      $��11��6   �� 5      $��12��6   �� 5      $��13��6   �� 5      $��14��6   �� 5      $��15��6   �� 5       $��16��6   �� 5!      $��17��6   �� 5"      $��18��6   �� 5#      $��19��6   �� 5$      $��20��6   �� 5%      $��21��6   5&      �� 5'   
   -   5        $ 	ComboPerc��5'      $
��Left=�6&   $��48��6A   $��545,180,0,0q�6M   $	��Top=�6b   $	��176��6z     5(   
   $
��Left=�6   $	��231��6.   $��
759,39,0,0q�6;   $	��Top=�6O   $	��288��6g   �� 5)   
   $��Elvitel órája��6   $
��Left=�6(   $��46��6C   $��
547,28,0,0q�6O   $	��Top=�6c   $	��174��6{   �� 5*   
   $��Elvitel perce��6   $
��Left=�6(   $��48��6C   $��547,132,0,0q�6O   $	��Top=�6d   $	��174��6|   5,      5-      