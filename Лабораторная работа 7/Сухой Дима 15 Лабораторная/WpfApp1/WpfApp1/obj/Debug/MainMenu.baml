   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.MainMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N? Title$  MainMenu??5	       ? 	Resources 5
         FocusVisual ?? Property ?? Value ?? StrokeDashArray J? SnapsToDevicePixels  Button.Static.Background ?? Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 ?? 
TargetType ?? 
TargetType	 ??Name
 ?? CornerRadius ??Name ?? Triggers P? Property P? Value ?? 
TargetName??%j  &	        &	 ?     &	 ?     &	 ?     &	     &	 6    &	 Y    &	 |    &	 ?    &		 ?    &	
 ?    7   7  7  7  7  7 	 ?? 5   
   .?5      ??  ? ?? 5      ?? 5      .R?5      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E    . $??1??6?   5      5      5      ?? 5   
   $ 	#FFDDDDDD??6;   ?? 5   
   $ 	#FF707070??67   ?? 5   
   $ 	#FFBEE6FD??6>   ?? 5   
   $ 	#FF3C7FB1??6:   ?? 5   
   $ 	#FFC4E5F6??6<   ?? 5   
   $ 	#FF2C628B??68   ?? 5   
   $ 	#FFF4F4F4??6=   ?? 5   
   $ 	#FFADB2B5??69   ?? 5   
   $ 	#FF838383??6=   ?? 5   
   " ??6%   .?5      ??  ?@?FocusVisualStyle8   61   ?? 5       ? ??8  6+   ?? 5        ? ??8  6,   ?? 5!       ? ??# ? ??6+   ?? 5"       ? ??$ 1q?60   ?? 5#       ? ??$ Center=?6;   ?? 5$       ? ??$ Center=?69   ?? 5%       ? ??$ 1q?6(   ?? 5&       ? ?? 5'      ?? 5(      " ??6&   .R?5)      ?? $	 border??6!   #??z??61   $
 40??6[   #??z??6m   #??z??6?    . ._?5*      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. # z 6?   #??z??6  5+       5,      P? 5-       ?@??IsDefaulted . . ?5.   "   ?? $ border??6@   # ? ??6T    ? ??5/      P? 50       ?@J?IsMouseOver . . ?51   "   ?? $ border??6?    ? ?? ?	#FFFF00006S   ?? 52   "   $ border??6@    ? ?? ?	#FF0000006T   53      P? 54       ? ?? . . ?55   "   ?? $ border??6?    ? ?? ?	#FFFF45456S   ?? 56   "   $ border??6@    ? ?? ?	#FF0000006T   57      P? 58       ? {? .  . ?59   "   ?? $ border??6?   8   ? ??6S   ?? 5:   "   $ border??6@   8   ? ??6T   ?? 5;   "   $ contentPresenter??6K   8   ? ??6i   5<      5>      5@      5A      5B      .??5D      ? ???	#FFF5FF96.+?5E   
   ? $??Center=?6   $	??841??6,   $??Center=?69   $
??1549??6T   
???????6a   ?? 5F   
   
???   ?$??3q?6%   $??Center=?69   $	??841??6V   $??Center=?6c   $
??1549??6~   ?? 5G   
   $??Первая армия??6   $
??Left=?6'   $??84??6B   $??
273,46,0,0q?6N   $	??Top=?6b   $	??338??6z   $??48(?6?   $??Normal"?6?   $??Bahnschrift SemiLight)?6?   ?? 5H   
   $??Вторая армия??6   $
??Left=?6'   $??84??6B   $??1014,46,0,0q?6N   $	??Top=?6c   $	??338??6{   $??48(?6?   $??Normal"?6?   $??Bahnschrift SemiLight)?6?   ?? 5I   
   -   5         ??Name$ CbTypesOfArmyFirst??5I      $
??Left=?6/   $??64??6J   $??122,185,0,0q?6V   $	??Top=?6k   $	??428??6?   
???   ?$??28(?6?   $??Bahnschrift SemiLight)?6?    ?? SelectedIndex$ 0??6?   ??5J      ?? 5K       ?? EndPoint$	 0,1&?6&   .??5L      ?  ? Color$ 	#FFF0F0F0??6#   ? 5M      $ White??6#    ? Offset$ 1Q?61   5N      .@?5P      ?? $??Маги??6   6&   ?? 5Q      $??Стрелки??6   6)   5R      ?? 5S   
   $??Тип армии??6   $
??Left=?6$   $??40??6?   $??122,130,0,0q?6K   $	??Top=?6`   $	??172??6x   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5T   
   -   5        $ CbTypesOfArmySecond??5T      $
??Left=?60   $??64??6K   $??844,185,0,0q?6W   $	??Top=?6l   $	??428??6?   
???   ?$ 0??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ??5U      ?? 5V      $	 0,1&?6&   .??5W      ? $ 	#FFF0F0F0??6#   ? 5X      $ White??6#   $ 1Q?61   5Y      .@?5[      ?? $??Маги??6   6&   ?? 5\      $??Стрелки??6   6)   5]      ?? 5^   
   $??Тип армии??6   $
??Left=?6$   $??40??6?   $??844,130,0,0q?6K   $	??Top=?6`   $	??172??6x   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5_   
   -   5         ??Name$ LabelHpOfFirstArmy??5_      $!??Здоровье Армии??6,   $
??Left=?6E   $??44??6`   $??122,264,0,0q?6l   $	??Top=?6?   $	??230??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5`   
   -   5         ??Name$ TbHpOfFirstArmy??5`      $
??Left=?6+   $??2q?6F   $??71??6Z   $??122,313,0,0q?6f    ?? TextWrapping$
 Wrap=?6{   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?    ?? TextAlignment$ Center=?6  ?? 5a   
   -   5        $ TbHpOfSecondArmy??5a      $
??Left=?6,   $??2q?6G   $??71??6[   $??844,313,0,0q?6g   $
 Wrap=?6|   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5b   
   -   5        $ LabelHpOfSecondArmy??5b      $!??Здоровье Армии??6-   $
??Left=?6F   $??44??6a   $??844,264,0,0q?6m   $	??Top=?6?   $	??230??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5c   
   -   5        $ LabelDamageOfFirstArmy??5c      $??Атака Армии??60   $
??Left=?6F   $??44??6a   $??122,389,0,0q?6m   $	??Top=?6?   $	??184??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5d   
   -   5        $ TbDamageOfFirstArmy??5d      $
??Left=?6/   $??2q?6J   $??69??6^   $??122,434,0,0q?6j   $
 Wrap=?6   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5e   
   -	   5        $ LabelDamageOfSecondArmy??5e      $??Атака Армии??61   $
??Left=?6G   $??44??6b   $??844,389,0,0q?6n   $	??Top=?6?   $	??184??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5f   
   -
   5        $ TbDamageOfSecondArmy??5f      $
??Left=?60   $??2q?6K   $??70??6_   $??844,433,0,0q?6k   $
 Wrap=?6?   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5g   
   -   5         ??Name$ UseTypeOfArmyFirst??5g      $??Применить??6-   $??2q?6A   $
??Left=?6U   $??64??6p   $??590,185,0,0q?6|   $	??Top=?6?   $	??180??6?   
???????
???   ?$??28(?6?   $??Bahnschrift SemiLight)?6?   6  ?? 5h   
   -   5        $ UseTypeOfArmySecond??5h      $??Применить??6.   $??2q?6B   $
??Left=?6V   $??64??6q   $??1308,185,0,0q?6}   $	??Top=?6?   $	??180??6?   
???????
???   ?$??28(?6?   $??Bahnschrift SemiLight)?6?   6  ?? 5i   
   -   5        $ CountOfArrowFirstArmy??5i      $0??*Количество стрел армии??6/   $
??Left=?6P   $??44??6k   $??122,510,0,0q?6w   $	??Top=?6?   $	??340??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5j   
   -   5        $ TbOfCountArrowFirstArmy??5j      $
??Left=?63   $??2q?6N   $??71??6b   $??122,554,0,0q?6n   $
 Wrap=?6?   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5k   
   -   5        $ CountOfManaFirstArmy??5k      $.??(Количество маны армии??6.   $
??Left=?6N   $??44??6i   $??122,510,0,0q?6u   $	??Top=?6?   $	??340??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5l   
   -   5        $ TbOfCountManaFirstArmy??5l      $
??Left=?62   $??2q?6M   $??71??6a   $??122,554,0,0q?6m   $
 Wrap=?6?   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5m   
   -   5        $ TbOfCountManaSecondArmy??5m      $
??Left=?63   $??2q?6N   $??71??6b   $??843,554,0,0q?6n   $
 Wrap=?6?   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5n   
   -   5        $ CountOfArrowSecondArmy??5n      $0??*Количество стрел армии??60   $
??Left=?6Q   $??44??6l   $??843,510,0,0q?6x   $	??Top=?6?   $	??340??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5o   
   -   5        $ TbOfCountArrowSecondArmy??5o      $
??Left=?64   $??2q?6O   $??71??6c   $??843,554,0,0q?6o   $
 Wrap=?6?   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5p   
   -   5        $ CountOfManaSecondArmy??5p      $.??(Количество маны армии??6/   $
??Left=?6O   $??44??6j   $??844,510,0,0q?6v   $	??Top=?6?   $	??340??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5q   
   -   5        $ UseAllFirst??5q      $??Применить??6&   $
??Left=?6:   $??2q?6U   $??80??6i   $??319,734,0,0q?6u   $	??Top=?6?   $	??266??6?   
???????
???   ?$??28(?6?   6?   ?? 5r   
   -   5        $ UseAllSecond??5r      $??Применить??6'   $
??Left=?6;   $??2q?6V   $??80??6j   $??1095,731,0,0q?6v   $	??Top=?6?   $	??266??6?   
???????
???   ?$??28(?6?   6?   ?? 5s   
   -   5        $ TbHpOfFirstChemist??5s      $
??Left=?6.   $??71??6I   $??2q?6U   $??470,313,0,0q?6i   $
 Wrap=?6~   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5t   
   -   5        $ LabelHpOfFirstChemist??5t      $$??Число хп аптечки??6/   $
??Left=?6J   $??44??6e   $??470,264,0,0q?6q   $	??Top=?6?   $	??241??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5u   
   -   5        $ LabelCountOfFirstChemist??5u      $)??#Количество аптечек??62   $
??Left=?6O   $??44??6j   $??470,389,0,0q?6v   $	??Top=?6?   $	??282??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5v   
   -   5        $ TbCountOfFirstChemist??5v      $
??Left=?61   $??69??6L   $??2q?6X   $??470,434,0,0q?6l   $
 Wrap=?6?   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5w   
   -   5        $ TbHpOfSecondChemist??5w      $
??Left=?6/   $??71??6J   $??2q?6V   $??1220,313,0,0q?6j   $
 Wrap=?6?   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5x   
   -   5        $ LabelHpOfSecondChemist??5x      $$??Число хп аптечки??60   $
??Left=?6K   $??44??6f   $??1220,264,0,0q?6r   $	??Top=?6?   $	??241??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5y   
   -   5        $ LabelCountOfSecondChemist??5y      $)??#Количество аптечек??63   $
??Left=?6P   $??44??6k   $??1220,389,0,0q?6w   $	??Top=?6?   $	??282??6?   $??28(?6?   $??Bahnschrift SemiLight)?6?   ?? 5z   
   -   5        $ TbCountOfSecondChemist??5z      $
??Left=?62   $??69??6M   $??2q?6Y   $??1220,434,0,0q?6m   $
 Wrap=?6?   $	??Top=?6?   $	??230??6?   
???   ?
???????$??28(?6?   $??Bahnschrift SemiLight)?6?   $ Center=?6  ?? 5{   
   -   5        $
 Play??5{   8   #??? 
 6   $??Играть??6F   $??2q?6W   $
??Left=?6k   $	??145??6?   $??680,669,0,0q?6?   $	??Top=?6?   $	??315??6?   
???????
???   ?$??48(?6?   $??Bahnschrift SemiLight)?6  6$  5|      5}      