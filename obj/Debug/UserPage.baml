   M S B A M L   `   `   `  ����B  >TaskApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TaskAppTaskApp  5   	       TaskApp.UserPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:TaskApp     5   	     � Title$  UserPage��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   �� $��Employee��6   $��30(�6#   $��Center=�61   $��0,26,0,0q�6N   $	��Top=�6`   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ pindingGrid��5      $��
0,81,0,217q�6)   6=     5   
   -   5        $ completedGrid��5      $��	0,298,0,0q�6+   �� 5   
   -   5         ��Name$ empidtxt��5      $
��Left=�6$   $��141,252,0,0q�6?    �� TextWrapping$
 Wrap=�6T   $	��Top=�6i   $	��137��6�   $��25��6�   �� 5   
   $��Task ID��6   $
��Left=�6"   $��141,226,0,0q�6=   $	��Top=�6R   �� 5   
   -   5         ��Name$
 comp��5      $��Center=�6!   $��	0,252,0,0q�6>   $	��Top=�6Q   $	��120��6i   $��25��6u   .@�5      �� $��pending��6   �� 5      $��in progress��6   �� 5      $��	completed��6   5      �� 5   
   $��Status��6   $
��Left=�6!   $��340,226,0,0q�6<   $	��Top=�6Q   �� 5   
   -   5        $
��Save��5      $
��Left=�6    $��542,250,0,0q�6;   $	��Top=�6P   $��27��6h   $��64��6t   6   5      5      