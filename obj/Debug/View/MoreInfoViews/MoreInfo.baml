   M S B A M L   `   `   `  ����D  @Maraphone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Marathone.View.MoreInfoViewsMarathone.View.MoreInfoViews  5      +    %Marathone.View.MoreInfoViews.MoreInfo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Marathone.View.MoreInfoViews     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��0.1* �6   6,   �� 5      $
��0.4* �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��0.1* �6   6,   .+�5   
   ��    sponsorTitles#��[  6   $��Center=�5      $��0, 20q�5      .��6    )'Подробная информация66   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      6%   �� 5      6%     5      �� 5      �� 5      �� 5       .+�5#      �� -   5        $��28(�5#      $��20q�5$      .��67   Marathon Skills 20166M   �� 5&      -   5        $��28(�5&      $��20q�5'      $��1��5(      ��5)      �� 5*      $
��Wrap=�6     �� TextAlignment$ Center=�5+       0.Насколько долгий марафон6Q   5-      �� 5/      $��28(�6   $��20q�50      $��1��51      ��53      �� 54      $
��Wrap=�6    $ Center=�55   !   +)Предыдущие результаты6O   58      �� 5:      $��28(�6   $��20q�5;      $��1��5<      $��1��5>      ��5=      �� *FonadtionsCommand+��5?      �� 5@      $
��Wrap=�6    $ Center=�5A       HFСписок благотворительных организаций6]   5C      �� 5F      $��28(�6   $��20q�5G      $��2��5I      ��5H      �� *BMICalculatorCommand+��5J      �� 5K      $
��Wrap=�6    $ Center=�5L       BMI Калькулятор6H   5N      �� 5P      $��28(�6   $��20q�5Q      $��1��5S      $��2��5T      ��5R      �� *BMRCalculatorCommand+��5U      �� 5V      $
��Wrap=�6    $ Center=�5W       BMR калькулятор6H   5Y      5[      5\      5]      