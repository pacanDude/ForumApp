   M S B A M L   `   `   `  ����C  ?ForumApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ВопросОтветВопросОтвет  5   	   +    %ВопросОтвет.ResponseWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ВопросОтвет     5   	     � Title$  ResponseWindow��5   	   $	��530��6    $	��600��6-    � 
ResizeMode$ NoResize=�69    � WindowStartupLocation$ CenterScreen=�6O   .��5	      �  � 	Resources 5
   
    �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value3  -System.Windows.Media.Effects.DropShadowEffect   Color   	Direction   ShadowDepth   
BlurRadius   Opacity �� ScaleX �� ScaleY �� 
TargetName T� Y��%%  '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      �� $ border��6%   $	 10��65   $��2q�6G   
�������
�������._�5   "   �� $
 ButtonContentPresenter��63   $��Center=�6S   $��Center=�6n   5       5      P� 5   "    �@J�IsMouseOver . . �5   &   ��  �@J�Effect 5   *     5   .   $
 Gray��6?   $
 1000Q�6L   $ 5Q�6]   $ 10Q�6m   $	 0.5Q�6}   5   '   �� 5   &    � z� 5   *   �� 5   .   $	 1.1Q�6=   $	 1.1Q�6J   5   '   �� 5   &    �@J�RenderTransformOrigin$ .5,.5&�6N   5    #   P� 5!   "    � �� . . �5"   &   �� $ ButtonContentPresenter��6-    � z� 5#   *   T� 5$   .   $	 1.0Q�6A   5&   '   5'   #   5)      5+      5,      5-      ��5/   
   �� 50       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W    �� RelativeTransform 51      V� 52      .~�53      ��  �� CenterY$	 0.5Q�6)    �� CenterX$	 0.5Q�67   �� 54       �� CenterY$	 0.5Q�6(    �� CenterX$	 0.5Q�66   �� 55       �� CenterY$	 0.5Q�6*     �� CenterX$	  0.5Q�68   ! �� Angle$
! -135Q�6F   T� 56      57      .��59      � " � Color$" 	#FF4D77D9��6   � 5:      $" 	#FF71DAE0��6   # � Offset$# 1Q�61   5;      .+�5>   
   �� -   5        $ ��Name$$ buttonOk��5>      $��Готово��6$   $
��Left=�65   $��	15,0,0,15q�6P   $��85��6c   $��30��6n   $��Bottom=�6z   % J� RenderTransformOrigin$% 	0.5,0.513&�6�   �� 5?   
   -   5        $$ buttonCancel��5?      $��Отмена��6'   $��Right=�68   $��	0,0,25,15q�6T   $��85��6g   $��30��6r   $��Bottom=�6~   6�   �� 5@   
   -   5        & ��Name$& title��5@      $1��+Ваш ответ пользователю ��6   $��20(�6A   $��Italic$�6O   $
��Bold"�6b   $
��Left=�6t   $��	30,10,0,0q�6�   $	��Top=�6�   �� 5A   
   $��Сообщение :��6   $��14(�6&   $��DemiBold"�64   $
��Left=�6J   $��	15,55,0,0q�6e   $	��Top=�6x   �� 5B   
   -   5        ' ��Name$' messageTextBox��5B      ( �� AcceptsReturn( . $	��155��6?   $��15,83,24.6,0q�6L   ) �� TextWrapping$
) Wrap=�6b   $	��Top=�6v   �� 5C   
   $��Для кода :��6   $��14(�6%   $��DemiBold"�63   $
��Left=�6I   $	��Top=�6d   $��
15,250,0,0q�6|   �� 5D   
   -   5        $' forCodeTextBox��5D      ( . $	��155��6?   $��15,278,24.6,0q�6L   $
) Wrap=�6c   $	��Top=�6w   5G      5H      