   M S B A M L   `   `   `  ����O  KEfface Instagram Bot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Efface_Instagram_BotEfface_Instagram_Bot  5   	   %    Efface_Instagram_Bot.MainWindow   5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5
   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     5   
   4local"clr-namespace:Efface_Instagram_Bot     5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5	   	    � Title$' !Efface Instagram Bot Fix [In4.Bz]��5   	   $	��732��63   $	��800��6@    � Icon$ EInstaBotThumb.ico��6L   .��5      � .+�5   
   �� $
��Left=�6   $��445.9��60   .@�5      �� $��General��6   .��5      �� $
��Left=�6   $��0q�6:   $	��441��6E   .��5      �� $��20,20,20,20q�6!   .+�5      �� $&�� Assets/Images/instagram-logo.png��6    $��80��6J   $	��264��6V   �� 5      -   5         ��Name$ Emailbox��5   "   $��23��64    �� TextWrapping$
 Wrap=�6@   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��6T   $	��Top=�6{   $��0q�6�   G� 5      -   5         G�Name$ Passwordbox��5   &   $��23��6;   $ Password��6G   $	��Top=�6q   $��0,10,0,0q�6�   �� 5       �� Orientation$ 
Horizontal=�6%   $
��Left=�6>   $��0q�6Y   .+�5      �� -   5        	 ��Name$	 	SignInBtn��5   %   $��Sign In��68   $��75��6J   $��	0,10,0,10q�6U   6h   �� 5      $-��'or you can sign in manually by yourself��6(   $��Center=�6W   $��10,0,0,0q�6r   5      �� 5      -   5        $ Usernamebox��5   "   $��23��67   $
 Wrap=�6C   $ Username / Hashtag��6W   $	��Top=�6�   $��0q�6�   �� 5       $ 
Horizontal=�6%   $��Center=�6>   $��0,10,0,0q�6[   .+�5!      �� -   5        
 ��Name$
 ToggleByUsername��5!   '    d� 	IsChecked$
 TrueY�6A   $��By Username��6R   $��0,0,10,0q�6h   6z   �� 5#      -   5        $
 ToggleByHashtag��5#   '   $��
By Hashtag��6@   $��10,0,0,0q�6U   6g   5%      �� 5'      $ 
Horizontal=�6%   $��Center=�6>   $��0,10,0,0q�6[   $	��152��6m   .+�5(      �� -   5        $
 CheckLimitPhoto��5(   '   $ falseY�6@   $��See only photos��6R   $
��Left=�6l   $��0,0,0,0q�6�   6�   �� 5)      -   5        $ TLimitPhoto��5)   &   $��23��6;   $
 Wrap=�6G   $ 10��6[   $	��Top=�6   $��10,0,0,0q�6�   5*      �� 5,      $ 
Horizontal=�6%   $��Center=�6>   $��0,10,0,0q�6[   $	��105��6m   .+�5-      �� $��Center=�6)   $
��10,0q�6D   .+�5.   "   �� $ ��Assets/Images/LikeIcon.png��6(   $��40��6L   $��40��6X   �� 5/   "   -	   5        $
 
ToggleLike��5/   +   $
 TrueY�6?   $
��Like��6P   $��Center=�6_   $��0,0,0,5q�6�   6�   �� 50   "   -
   5        $
 ToggleUnlike��50   +   $��Unlike��6A   $��Center=�6R   6v   52      �� 53      $��Center=�6)   $
��10,0q�6D   .+�54   "   �� $$��Assets/Images/CommentsIcon.png��6(   $��30��6P   $��30��6\   $	��0,5q�6g   �� 55   "   -   5        $
 ToggleComment��55   +   $��Comment��6\   $��Center=�6n   $��0,0,0,5q�6�   �� 56   "   -   5        $
 ToggleMention��56   +   $��Mention��6B   $��Center=�6T   6x   58      �� 59      $��Center=�6)   $
��10,0q�6D   .+�5:   "   �� $"��Assets/Images/FollowIcon.png��6(   $��40��6N   $��40��6Z   �� 5;   "   -   5        $
 ToggleFollow��5;   +   $��Follow��6A   $��Center=�6R   $��0,0,0,5q�6v   6�   �� 5<   "   -   5        $
 ToggleUnfollow��5<   +   $��Unfollow��6C   $��Center=�6V   6z   5>      5@      �� 5B      $ 
Horizontal=�6%   $��Center=�6>   $��0,10,0,0q�6[   $	��152��6m   $	��304��6z   .+�5D      �� $��Center=�6)   $
��10,1q�6D   $	��280��6R   .+�5E   "   �� $��Assets/Images/Фон.png��6(   $��40��6G   $��40��6S   �� 5F   "   -   5        $
 UseSmile��5F   +   $��Add smilies��6=   $
��Left=�6S   $ FalseY�6u   6�   �� 5G   "   $��Center=�6-   $
��10,0q�6H   .+�5H   &   � $��
10,0,194,0q�6+   .+�5I   *   �� -   5        $
 	LoveSmile��5I   3   $ FalseY�6F   $
��Love��6X   $
��Left=�6g   $��0,0,0,3q�6�   {�.  6�   5J   '   � 5K   &   $��
10,0,194,0q�6+   .+�5L   *   �� -   5        $
 	FaceSmile��5L   3   $ FalseY�6F   $
��Face��6X   $
��Left=�6g   $��0,0,0,3q�6�   {�.  6�   5M   '   � 5N   &   $��
80,-65,0,0q�6+   .+�5O   *   �� -   5        $
 CatSmile��5O   3   $ FalseY�6E   $	��Cat��6W   $
��Left=�6e   $��	0,0,110,3q�6�   {�.  6�   5P   '   � 5Q   &   $��
80,-20,0,0q�6+   .+�5R   *   �� -   5        $
 	FlowSmile��5R   3   $ FalseY�6F   $��Flowers��6X   $
��Left=�6j   $��	0,0,107,3q�6�   {�.  6�   5S   '   � 5T   &   $��160,-65,0,0q�6+   .+�5U   *   �� -   5        $
 
FruitSmile��5U   3   $ FalseY�6G   $��Fruits��6Y   $
��Left=�6j   $��0,0,0,3q�6�   {�.  6�   5V   '   5X   #   5Z      5\      �� 5^      -   5        $ MentionsBox��5^   "   $��23��67   $
 Wrap=�6C   $ 	@Mentions��6W   $	��Top=�6�   $��0,10,0,0q�6�   �� 5_      $ 
Horizontal=�6%   $��Center=�6>   .+�5`      �� -   5        $	 	ImportBtn��5`   %   $��Import��68   $��	0,10,10,0q�6I   $	��120��6t   �� 5a      -   5        $	 	ExportBtn��5a   %   $��Export��68   $��	10,10,0,0q�6I   $	��120��6t   5c      �� 5d      -   5        $
 CheckRandomText��5d   #   $ falseY�6<   $��Random comments��6N   $
��Left=�6h   $��	10,10,0,0q�6�   �� 5f      -   5         ��Name$ ListBoxComment��5f   "   
�������$��1q�6M   $	��142��6a   $	��370��6n   $��1,10,1,0q�6z   �� 5h      $ 
Horizontal=�6%   $��Center=�6>   .+�5i      �� -   5        $	 StartBtn��5i   %   $��Start��67   $��	0,10,10,0q�6G   $	��120��6Z   6f   �� 5k      -   5        $	 StopBtn��5k   %   $
��Stop��66   $��	10,10,0,0q�6E   $	��120��6X   {�.  6v   5l      5o      5p      5q      5s      � 5v   
   $��	446,0,0,0q�6   .+�5w      �� -   5         ��Name$ 
Tabcontrol��5w      $��Stretch=�6-   $��Stretch=�6K   .@�5x      �� $��Primary��6   .��5y      � -   5         �Name$ BrowserContainerPrimary��5y      
�������6<   5z      �� 5{      $��	Secondary��6   .��5|      � -   5        $ BrowserContainerSecondary��5|      
�������6>   5}      5~      5      5�      5�      