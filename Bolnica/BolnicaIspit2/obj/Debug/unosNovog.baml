   M S B A M L   `   `   `  ����H  DBolnicaIspit2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BolnicaIspit2BolnicaIspit2  5   	       BolnicaIspit2.unosNovog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:BolnicaIspit2     5   	     � Title$  	unosNovog��5   	   $	��450��6   $��514.96��6(   .��5	      � $��0,0,85,0q�6   .+�5
   
   �� $
��Left=�6   $��	93,93,0,0q�6/   $
��Wrap=�6B   $��Sifra��6V   $	��Top=�6c   �� 5   
   $
��Left=�6   $��
93,128,0,0q�6/   $
��Wrap=�6C   $	��Ime��6W   $	��Top=�6b   �� 5   
   $
��Left=�6   $��
93,165,0,0q�6/   $
��Wrap=�6C   $��Prezime��6W   $	��Top=�6f   �� 5   
   $
��Left=�6   $��
93,207,0,0q�6/   $
��Wrap=�6C   $��	Prioritet��6W   $	��Top=�6h   �� 5   
   $
��Left=�6   $��
93,241,0,0q�6/   $
��Wrap=�6C   $��	Odeljenje��6W   $	��Top=�6h   �� 5   
   $
��Left=�6   $��
93,276,0,0q�6/   $
��Wrap=�6C   $
��Soba��6W   $	��Top=�6c   �� 5   
   $
��Left=�6   $��279,276,0,0q�6/   $
��Wrap=�6D   $��Sprat��6X   $	��Top=�6e    J� RenderTransformOrigin$ -0.549,0.924&�6}   �� 5   
   -   5        $��tbSifra��5      $
��Left=�6!   $��23��6<   $��
163,93,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $��tbIme��5      $
��Left=�6   $��23��6:   $��163,130,0,0q�6F   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        $��	tbPrezime��5      $
��Left=�6#   $��23��6>   $��163,164,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $��cbOdelj��5      $
��Left=�6"   $��163,241,0,0q�6=   $	��Top=�6R   $	��120��6j   ��5      �� 5      .R�5      �� ��6    ��  �� Path$ Naziv�5      5      �� 5   
   -   5        $��tbSprat��5      $
��Left=�6!   $��23��6<   $��343,275,0,0q�6H   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $��57��6�   �� 5   
   -   5        $��slider1��5       �� IsSnapToTickEnabled . $
��Left=�6;   $��163,207,0,0q�6V   $	��Top=�6k   $��84��6�    � Minimum$ 1Q�6�    � Maximum$ 7Q�6�   �� 5   
   -   5        $��tbPrio��5      $
��Left=�6    $��23��6;   $��261,207,0,0q�6G   $
 Wrap=�6\   $	��Top=�6�   $��46��6�   ��6p   �� *Value+ �� ElementName$ slider1�� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $��btnUnesi��5      $��Unesi��6!   $
��Left=�61   $��
74,350,0,0q�6L   $	��Top=�6`   $��75��6x   6�   �� 5   
   -	   5        $��btnOdustani��5      $��Odustani��6$   $
��Left=�67   $��261,355,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5    
   -
   5        $��cbSoba��5       $
��Left=�6!   $��127,275,0,0q�6<   $	��Top=�6Q   $��44��6i   ��5!      �� 5"      .R�5#      �� ��6    �� $ SobaID�5$      5&      5(      5)      