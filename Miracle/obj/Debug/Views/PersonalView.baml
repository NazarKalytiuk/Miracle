   M S B A M L   `   `   `  ����B  >Miracle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Miracle.ViewsMiracle.Views  5      7 clr-namespace:Miracle.ViewModelsMiracle.ViewModels  5           Miracle.Views.PersonalView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Miracle.Views     5      /vm clr-namespace:Miracle.ViewModels     5        N� Title$  PersonalView��5
       � DataContext 5      *  $Miracle.ViewModels.PersonalViewModel  5   
   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeesListBox��5   d      
IsReadOnly .    AutoGenerateColumns .  $	��700��6~   $��10,10,506,0q�6�   $	��Top=�6�   
���������6%   �� *	Employees+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.5* 6%      CanUserSort .     Header$
 Name��5   )   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5   )   �� *Name+
 �� Mode$
 OneWay=�5   )     5      $
 1.5* 6%    .  $ Surname��5   )   	 5   )   �� *	Surname+$
 OneWay=�5   )     5      $
 1.5* 6%    .  $ 	Workplace��5   )   	 5   )   �� *	Workplace+$
 OneWay=�5   )     5      $
 1.5* 6%    .  $ Salary��5!   )   	 5   )   �� *Salary+$
 OneWay=�5!   )   5#      � 5$   
   $��Right=�6   $	��690��6+   $��0,0,10,0q�68   $	��Top=�6J   $	��481��6b   .+�5%      �� -   5         ��Name$ comboBox��5%      $ �� IsSynchronizedWithCurrentItem$
 TrueY�6L   $
��Left=�6�   $��120,168,0,0q�6�   $	��Top=�6�   $	��251��6�   ��6)   �� *
Workplaces+ �� SelectedValue 6q   �� *NewEmployeeWorkplace+$
 TwoWay=�6�   �� 5&      -   5         ��Name$ 	AddEmpBtn��5&      $��Додати��6�   $��	0,0,10,30q�6�   $��32��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Bottom=�6�   $��Right=�6�   $	��148��6  ��6(   �� *
AddCommand+��6G   ��  �� ElementName$ EmployeesListBox��6  �� 5'      $%��Додати Робітника��6   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   $��22(�6u   �� 5(      $��Ім'я��6   $
��Left=�6#   $��	10,74,0,0q�6>   $	��Top=�6Q   �� 5)      $��Прізвище��6   $
��Left=�6'   $��
10,126,0,0q�6B   $	��Top=�6V   �� 5*      -   5         ��Name$ tbName��5*      $
��Left=�6&   $��23��6A   $��
120,74,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6�   $	��251��6�   ��6u   �� *NewEmployeeName+6�   �� 5+      -   5        $ 	tbSurname��5+      $
��Left=�6)   $��23��6D   $��120,127,0,0q�6P   $
 Wrap=�6e   $	��Top=�6�   $	��251��6�   ��6y   �� *NewEmployeeSurname+6�   �� 5,      $��Робоче місце��6   $
��Left=�6+   $��
10,167,0,0q�6F   $	��Top=�6Z   5-      5/      50      