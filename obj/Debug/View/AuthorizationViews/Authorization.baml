   M S B A M L   `   `   `  ����D  @Maraphone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Marathone.View.AuthorizationViews!Marathone.View.AuthorizationViews  5      5    /Marathone.View.AuthorizationViews.Authorization   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:Marathone.View.AuthorizationViews     5      .��5	      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   ��    sponsorTitles#��[  6   $��0, 20q�5      $��Center=�5      .��6-   #!Форма авторизации6@   �� 5   
   $��1��6   $��20(�5      $
��Wrap=�5       �� TextAlignment$ Center=�5       �� Padding$ 20, 20q�5      ��Пожалуйста, авторизируйтесь в системе, используя ваш адрес электронной почты и пароль5      � 5    
   $��2��6    � ColumnDefinitions 5"      �� 5#      $
��0.6* �6$   63   �� 5$      6%   �� 5%      $��2* �6#   60   �� 5&      $
��1.6* �6#   62   .+�5)      �� $��1��6   $��Center=�5*      $��Right=�5+      $��20, 0q�5,      $��24(�5-      .��6"   Email:6+   �� 5/      -   5         ��Name$ email��51      $��2��5/      $��24(�50      ��53      �� *Email+6/   55      � 57   
   $��3��6   $��0, 20q�58       5:      �� 5;      $
��0.6* �6$   63   �� 5<      6%   �� 5=      $��2* �6#   60   �� 5>      $
��1.6* �6#   62   .+�5A      �� $��1��6   $��Center=�5B      $��Right=�5C      $��20, 0q�5D      $��24(�5E      .��6"   	Password:6-   �� 5G      -   5        $ password��5H      $��2��5G      $��24(�5K      ��5J      �� *
Password+5K   &   5M      �� 5O   
   $��4��6   $��Center=�5P       �� Orientation$ 
Horizontal=�5Q      .+�5S      �� $��22(�6   $��20, 10q�5T      ��5U      �� *Login+.��6/   Login66   �� 5W      $��22(�6   $��20, 10q�5X      ��5Y      �� *Cancel+.��60   Cancel68   5[      5]      5^      