   M S B A M L   `   `   `  ????G  CGameOfTowers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:GameOfTowersGameOfTowers  5          GameOfTowers.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:GameOfTowers     5        N? Title$  MainPage??5	       ? 	Resources 5
         FocusVisual ?? Property ?? Value ?? StrokeDashArray J? SnapsToDevicePixels  Button.Static.Background ?? Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 ?? 
TargetType ?? 
TargetType	 ??Name
 ?? CornerRadius ??Name ?? Triggers P? Property P? Value ?? 
TargetName  FocusVisual1  Button.Static.Background1  Button.Static.Border1   Button.MouseOver.Background1  Button.MouseOver.Border1  Button.Pressed.Background1  Button.Pressed.Border1  Button.Disabled.Background1  Button.Disabled.Border1  Button.Disabled.Foreground1  ButtonStyle2  FocusVisual2  Button.Static.Background2  Button.Static.Border2   Button.MouseOver.Background2  Button.MouseOver.Border2  Button.Pressed.Background2  Button.Pressed.Border2  Button.Disabled.Background2  Button.Disabled.Border2  Button.Disabled.Foreground2   ButtonStyle3 ! FocusVisual3 " Button.Static.Background3 # Button.Static.Border3  $ Button.MouseOver.Background3 % Button.MouseOver.Border3 & Button.Pressed.Background3 ' Button.Pressed.Border3 ( Button.Disabled.Background3 ) Button.Disabled.Border3 * Button.Disabled.Foreground3 + ButtonStyle4??%(  &	        &	 ?     &	 ?     &	 ?     &	     &	 6    &	 Y    &	 |    &	 ?    &		 ?    &	
 ?    7   7  7  7  7  7  7  7  7  7 	 &	 ?    &	 ^    &	 ?    &	 ?    &	 ?    &	 ?    &	     &	 0    &	 S    &	 v    &	 ?    7  7  7  7  7  7  7  7  7  7  &	 h    &	     &	 5    &	 X    &	 {    &	 ?    &	 ?    &	 ?    &	     &	 *    &	  M    7  7  7  7  7  7  7  7  7  7  &	!     &	" ?    &	# ?    &	$     &	% /    &	& R    &	' u    &	( ?    &	) ?    &	* ?    &	+     7 ! 7 " 7 # 7 $ 7 % 7 & 7 ' 7 ( 7 ) 7 * ?? 5   
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
 40??6[   #??z??6m   #??z??6?    . ._?5*      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. # z 6?   #??z??6  5+       5,      P? 5-       ?@??IsDefaulted . . ?5.   "   ?? $ border??6@   # ? ??6T    ? ??5/      P? 50       ?@J?IsMouseOver . . ?51   "   ?? $ border??6?   8   ? ??6S   ?? 52   "   $ border??6@   8   ? ??6T   53      P? 54       ? ?? . . ?55   "   ?? $ border??6?   8   ? ??6S   ?? 56   "   $ border??6@   8   ? ??6T   57      P? 58       ? {? .  . ?59   "   ?? $ border??6?   8   ? ??6S   ?? 5:   "   $ border??6@   8   ? ??6T   ?? 5;   "   $ contentPresenter??6K   8 	  ? ??6i   5<      5>      5@      5A      ?? 5B   
   .?5C      ??  ? ?? 5D      ?? 5E      .R?5F      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E    . $??1??6?   5G      5I      5J      ?? 5K   
   $ 	#FFDDDDDD??6<   ?? 5L   
   $ 	#FF707070??68   ?? 5M   
   $ 	#FFBEE6FD??6?   ?? 5N   
   $ 	#FF3C7FB1??6;   ?? 5O   
   $ 	#FFC4E5F6??6=   ?? 5P   
   $ 	#FF2C628B??69   ?? 5Q   
   $ 	#FFF4F4F4??6>   ?? 5R   
   $ 	#FFADB2B5??6:   ?? 5S   
   $ 	#FF838383??6>   ?? 5T   
   " ??6%   .?5U      ??  ?@?FocusVisualStyle8   61   ?? 5V       ? ??8  6+   ?? 5W       ? ??8  6,   ?? 5X       ? ??# ? ??6+   ?? 5Y       ? ??$ 1q?60   ?? 5Z       ? ??$ Center=?6;   ?? 5[       ? ??$ Center=?69   ?? 5\       ? ??$ 1q?6(   ?? 5]       ? ?? 5^      ?? 5_      " ??6&   .R?5`      ?? $	 border??6!   #??z??61   $
 40??6[   #??z??6m   #??z??6?    . ._?5a      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. # z 6?   #??z??6  5b       5c      P? 5d       ?@??IsDefaulted . . ?5e   "   ?? $ border??6@   # ? ??6T    ? ??5f      P? 5g       ?@J?IsMouseOver . . ?5h   "   ?? $ border??6?   8   ? ??6S   ?? 5i   "   $ border??6@   8   ? ??6T   5j      P? 5k       ? ?? . . ?5l   "   ?? $ border??6?   8   ? ??6S   ?? 5m   "   $ border??6@   8   ? ??6T   5n      P? 5o       ? {? .  . ?5p   "   ?? $ border??6?   8   ? ??6S   ?? 5q   "   $ border??6@   8   ? ??6T   ?? 5r   "   $ contentPresenter??6K   8 	  ? ??6i   5s      5u      5w      5x      ?? 5y   
   .?5z      ??  ? ?? 5{      ?? 5|      .R?5}      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E    . $??1??6?   5~      5?      5?      ?? 5?   
   $ 	#FFDDDDDD??6<   ?? 5?   
   $ 	#FF707070??68   ?? 5?   
   $ 	#FFBEE6FD??6?   ?? 5?   
   $ 	#FF3C7FB1??6;   ?? 5?   
   $ 	#FFC4E5F6??6=   ?? 5?   
   $ 	#FF2C628B??69   ?? 5?   
   $ 	#FFF4F4F4??6>   ?? 5?   
   $ 	#FFADB2B5??6:   ?? 5?   
   $ 	#FF838383??6>   ?? 5?   
   " ??6%   .?5?      ??  ?@?FocusVisualStyle8   61   ?? 5?       ? ??8  6+   ?? 5?       ? ??8  6,   ?? 5?       ? ??# ? ??6+   ?? 5?       ? ??$ 1q?60   ?? 5?       ? ??$ Center=?6;   ?? 5?       ? ??$ Center=?69   ?? 5?       ? ??$ 1q?6(   ?? 5?       ? ?? 5?      ?? 5?      " ??6&   .R?5?      ?? $	 border??6!   #??z??61   $
 40??6[   #??z??6m   #??z??6?    . ._?5?      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. # z 6?   #??z??6  5?       5?      P? 5?       ?@??IsDefaulted . . ?5?   "   ?? $ border??6@   # ? ??6T    ? ??5?      P? 5?       ?@J?IsMouseOver . . ?5?   "   ?? $ border??6?   8   ? ??6S   ?? 5?   "   $ border??6@   8   ? ??6T   5?      P? 5?       ? ?? . . ?5?   "   ?? $ border??6?   8   ? ??6S   ?? 5?   "   $ border??6@   8   ? ??6T   5?      P? 5?       ? {? .  . ?5?   "   ?? $ border??6?   8   ? ??6S   ?? 5?   "   $ border??6@   8   ? ??6T   ?? 5?   "   $ contentPresenter??6K   8 	  ? ??6i   5?      5?      5?      5?      ?? 5?   
   .?5?      ??  ? ?? 5?      ?? 5?      .R?5?      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E    . $??1??6?   5?      5?      5?      ?? 5?   
   $ 	#FFDDDDDD??6<   ?? 5?   
   $ 	#FF707070??68   ?? 5?   
   $ 	#FFBEE6FD??6?   ?? 5?   
   $ 	#FF3C7FB1??6;   ?? 5?   
   $ 	#FFC4E5F6??6=   ?? 5?   
   $ 	#FF2C628B??69   ?? 5?   
   $ 	#FFF4F4F4??6>   ?? 5?   
   $ 	#FFADB2B5??6:   ?? 5?   
   $ 	#FF838383??6>   ?? 5?   
   " ??6%   .?5?      ??  ?@?FocusVisualStyle8   61   ?? 5?       ? ??8  6+   ?? 5?       ? ??8  6,   ?? 5?       ? ??# ? ??6+   ?? 5?       ? ??$ 1q?60   ?? 5?       ? ??$ Center=?6;   ?? 5?       ? ??$ Center=?69   ?? 5?       ? ??$ 1q?6(   ?? 5?       ? ?? 5?      ?? 5?      " ??6&   .R?5?      ?? $	 border??6!   #??z??61   $
 40??6[   #??z??6m   #??z??6?    . ._?5?      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. # z 6?   #??z??6  5?       5?      P? 5?       ?@??IsDefaulted . . ?5?   "   ?? $ border??6@   # ? ??6T    ? ??5?      P? 5?       ?@J?IsMouseOver . . ?5?   "   ?? $ border??6?   8   ? ??6S   ?? 5?   "   $ border??6@   8   ? ??6T   5?      P? 5?       ? ?? . . ?5?   "   ?? $ border??6?   8   ? ??6S   ?? 5?   "   $ border??6@   8   ? ??6T   5?      P? 5?       ? {? .  . ?5?   "   ?? $ border??6?   8   ? ??6S   ?? 5?   "   $ border??6@   8   ? ??6T   ?? 5?   "   $ contentPresenter??6K   8 	  ? ??6i   5?      5?      5?      5?      5?      .??5?      ? 
???????.+?5?   
   ? $??Center=?6   $	??850??6,   $??Center=?69   $
??1500??6T   ???	#FFA2FF64.+?5?      ?? -   5         ??Name$ NextStep??5?   <   #??? 
 6   $??
Далее??6N   $??Center=?6^   $??4q?6{   $	??128??6?   $??	0,680,0,0q?6?   $	??Top=?6?   $	??482??6?   $??72(?6?   
???   ?
???????$??Normal"?6  $??Bahnschrift Light)?6  6;  ? 5?      $
??Left=?6   $	??590??6.   $??	48,62,0,0q?6;   $	??Top=?6N   $
??1408??6f   
???????6s   5?      ?? 5?   
   
???   ?$??4q?6%   $??Center=?69   $	??593??6V   $??0,40,0,0q?6c   $	??Top=?6u   $
??1412??6?   ?? 5?   
   
???   ?$??2q?6%   $??Center=?69   $	??590??6V   $??0,40,0,0q?6c   $	??Top=?6u   $??4??6?    J? RenderTransformOrigin$ 0.5,0.5&?6?   z?5?      V? 5?      .~?5?      ??  ?? ScaleX$ 1Q?6%   ?? 5?      ?? 5?      T? 5?      5?      5?      ?? 5?   
   $%??Настройка войска??6   $
??Left=?6+   $??64??6F   $??
222,76,0,0q?6R   $	??Top=?6f   $	??316??6~   $??36(?6?   ?? 5?   
   $#??Настройка башни??6   $
??Left=?6*   $??64??6E   $??1000,76,0,0q?6Q   $	??Top=?6f   $	??318??6~   $??36(?6?   ?? 5?   
   
???   ?$??2q?6%   $
??Left=?69   $	??122??6T   $??769,161,0,0q?6a   $	??Top=?6v   $	??369??6?   ???	#FFFFFEE26?   ?? 5?   
   $8??2Поселить принцессу в башню???6   $
??Left=?66   $??50??6Q   $??783,161,0,0q?6]   $	??Top=?6r   $	??355??6?   $??24(?6?   ?? 5?   
   -   5        $ 
PrincessNo??5?      $??Нет??6%   $
??Left=?63   $??2q?6N   $??56??6b   $??954,211,0,0q?6n   $	??Top=?6?   $??82??6?   $ 0.543,0.536&?6?   $??24(?6?   
???   ????	#FFDEDEDE6  ?? 5?   
   -   5        $ PrincessYes??5?      $
??Да??6&   $
??Left=?63   $??56??6N   $??2q?6Z   $??854,211,0,0q?6o   $	??Top=?6?   $??82??6?   $ 0.543,0.536&?6?   $??24(?6?   
???   ????	#FFDEDEDE6  ?? 5?   
   
???   ?$??2q?6%   $
??Left=?69   $	??122??6T   $??769,305,0,0q?6a   $	??Top=?6v   $	??369??6?   ???	#FFFFFEE26?   ?? 5   
   $!??Здоровье башни??6   $
??Left=?6)   $??52??6D   $??838,305,0,0q?6P   $	??Top=?6e   $	??226??6}   $??24(?6?   ?? 5  
   -   5         ??Name$ 	HpOfTower??5     $
??Left=?6%   $??63??6@   $??838,347,0,0q?6L   $??2q?6a    ?? TextWrapping$
 Wrap=?6u   $	??Top=?6?   $	??198??6?   $??24(?6?    ?? TextAlignment$ Center=?6?   
???   ?6?   ?? 5  
   -   5        $ 	UseSecond??5  8   #???  6   $??Применить??6K   $
??Left=?6_   $??86??6z   $??995,491,0,0q?6?   $??2q?6?   $	??Top=?6?   $	??266??6?   
???????
???   ?$??36(?6?   6  ?? 5  
   
???   ?$??2q?6%   $
??Left=?69   $	??122??6T   $??1159,156,0,0q?6a   $	??Top=?6w   $	??274??6?   ???	#FFFFFEE26?   ?? 5  
   $??Атака башни??6   $
??Left=?6&   $??44??6A   $??1212,161,0,0q?6M   $	??Top=?6c   $	??168??6{   $??24(?6?   ?? 5  
   -   5        $ DamageOfTower??5     $
??Left=?6)   $??63??6D   $??1197,204,0,0q?6P   $??2q?6f   $
 Wrap=?6z   $	??Top=?6?   $	??198??6?   $??24(?6?   $ Center=?6?   
???   ?6?   ?? 5  
   -   5         ??Name$ CbOfArmy??5     $
??Left=?6%   $??75??6@   $??
78,161,0,0q?6L   $	??Top=?6`   $	??396??6x   
???   ?$??24(?6?    ?? SelectedIndex$ 0??6?   ??5     ?? 5      ?? EndPoint$	 0,1&?6&   .??5	     ?  ? Color$ 	#FFF0F0F0??6#   ? 5
     $ White??6#    ? Offset$ 1Q?61   5     .@?5     ?? $??Маги??6   6&   ?? 5     $??Стрелки??6   6)   5     ?? 5  
   -   5        $ 	UseArmyCb??5  8   #??? + 6   $??Применить??6K   $
??Left=?6_   $??2q?6z   $??75??6?   $??506,161,0,0q?6?   $	??Top=?6?   $	??204??6?   $??24(?6?   
???????
???   ?6  ?? 5  
   -	   5         ??Name$ LabelHpOfArmy??5     $#??Здоровье войска??6'   $
??Left=?6A   $??47??6\   $??132,256,0,0q?6h   $	??Top=?6}   $	??230??6?   $??24(?6?   ?? 5  
   -
   5        $ 
TbHpOfArmy??5     $
??Left=?6&   $??56??6A   $??2q?6M   $??116,307,0,0q?6a   $
 Wrap=?6v   $	??Top=?6?   $	??262??6?   
???   ?$??24(?6?   $ Center=?6?   ?? 5  
   -   5        $ UseFirst??5  8   #???   6   $??Применить??6J   $
??Left=?6^   $??86??6y   $??272,491,0,0q?6?   $??2q?6?   $	??Top=?6?   $	??266??6?   
???????
???   ?$??36(?6?   6  ?? 5  
   -   5        $ LabelDamageOfArmy??5     $??Атака войска??6+   $
??Left=?6B   $??47??6]   $??462,255,0,0q?6i   $	??Top=?6~   $	??166??6?   $??24(?6?   ?? 5  
   -   5        $ TbDamageOfArmy??5     $
??Left=?6*   $??56??6E   $??2q?6Q   $??428,307,0,0q?6e   $
 Wrap=?6z   $	??Top=?6?   $	??235??6?   
???   ?$??24(?6?   $ Center=?6?   ?? 5  
   -   5        $ LabelCountOfArrow??5     $??Число стрел??6+   $
??Left=?6A   $??45??6\   $??155,364,0,0q?6h   $	??Top=?6}   $	??184??6?   $??24(?6?   ?? 5  
   -   5        $ TbCountOfArrow??5     $
??Left=?6*   $??2q?6E   $??57??6Y   $??116,409,0,0q?6e   $
 Wrap=?6z   $	??Top=?6?   $	??262??6?   
???   ?$??24(?6?   $ Center=?6?   ?? 5  
   -   5        $ LabelCountOfMana??5     $??Число маны??6*   $
??Left=?6?   $??45??6Z   $??462,364,0,0q?6f   $	??Top=?6{   $	??184??6?   $??24(?6?   ?? 5  
   -   5        $ TbCountOfMana??5     $
??Left=?6)   $??2q?6D   $??57??6X   $??414,409,0,0q?6d   $
 Wrap=?6y   $	??Top=?6?   $	??262??6?   
???   ?$??24(?6?   $ Center=?6?   5     5     