   M S B A M L   `   `   `  ����C  ?PlantApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PlantAppPlantApp  5   	       PlantApp.DetailsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PlantApp     5   	     � Title$  Details Window��5   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Plant Details��6   $��2��5      $��40(�5      $��Center=�5      $��Center=�5      �� 5   
   $��Name: ��6   $��25(�5      $��1��5      $��Center=�5       $��Right=�5!      �� 5"   
   $��Environment: ��6   $��25(�5#      $��2��5$      $��Center=�5%      $��Right=�5&      �� 5'   
   $��Type: ��6   $��25(�5(      $��3��5)      $��Center=�5*      $��Right=�5+      �� 5,   
   $��Pick: ��6   $��25(�5-      $��4��5.      $��Center=�5/      $��Right=�50      �� 51   
   -   5         ��Name$ LblName��51      $��25(�52      $��1��53      $��1��54      $��Name Results...��55      $��Center=�56      $
��Left=�57      �� 58   
   -   5        $ LblEnvironment��58      $��25(�59      $��2��5:      $��1��5;      $��Environment Results...��5<      $��Center=�5=      $
��Left=�5>      �� 5?   
   -   5        $ LblType��5?      $��25(�5@      $��3��5A      $��1��5B      $��Type Results...��5C      $��Center=�5D      $
��Left=�5E      �� 5F   
   -   5        $ LblPick��5F      $��25(�5G      $��4��5H      $��1��5I      $��Pick Results...��5J      $��Center=�5K      $
��Left=�5L      �� 5M   
   -   5         ��Name$ BtnSniff��5M      $��30(�5N      $��Sniff��5O      $��5��5P      $��10q�5Q      6!   �� 5R   
   -   5        $ BtnClose��5R      $��30(�5S      $��Close��5T      $��1��5U      $��5��5V      $��10q�5W      6!   5X      5Y      