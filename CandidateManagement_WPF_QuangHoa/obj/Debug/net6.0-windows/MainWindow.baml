   M S B A M L   `   `   `  ����[  WCandidateManagement_WPF_QuangHoa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:CandidateManagement_WPF_QuangHoa CandidateManagement_WPF_QuangHoa  5   	   1    +CandidateManagement_WPF_QuangHoa.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:CandidateManagement_WPF_QuangHoa     5   	     � Title$  Login Screen��5	   	   $	��450��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67    � Icon$` ZE:\C#\TrialTest\PRN221PE_FA22_TrialTest_QuangHoa\CandidateManagement_WPF_QuangHoa\Icon.ico��5
   	   .��5      � $��0,10,-1709,-954q�6    J� RenderTransformOrigin$ 0.365,0.357&�6$    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      $	��55* �6   �� 5      $
��Auto �6   �� 5      $	��23* �6   �� 5      $
��618* �6   �� 5      $	��42* �6   �� 5      $��1487* �6   �� 5      $
��285* �6   .+�5   
   �� $��Email:
��6   $
��Left=�6+   $��	66,86,0,0q�6F   $	��Top=�6Y   $��18(�6q   $��4��6   �� 5   
   $��	Password:��6   $��Right=�6$   $��0,153,467,0q�6@   $	��Top=�6U   $��18(�6m   $��4��6{   $��89��6�   $	��100��6�   �� 5   
   $
��Left=�6   $��66,-4781,0,0q�6/   $
��Wrap=�6E   $��	TextBlock��6Y   $	��Top=�6j   $��4��6�   �� 5   
   -   5         ��Name$ txtEmail��5      $��4��6$   $��Center=�64   $��0,92,0,0q�6Q    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��287��6�   $��38��6�    �� 	UndoLimit$ 96��6�   $��	hoa@gmail��6�   G� 5   
   -   5         G�Name$ txtPassword��5      $��4��6+   $��Center=�6;   $��	0,160,0,0q�6X   $	��Top=�6k   $	��287��6�   $��35��6�   	 G� Password$	 1��6�   �� 5   
   -   5        
 ��Name$
 	login_btn��5      $��4��6$   $��Login��64   $
��Left=�6D   $��335,247,0,0q�6_   $	��Top=�6t   $��33��6�   $	��117��6�   ���	#FF09F417$
��Bold"�6�   �� 5   
   -   5        $
 
cancel_btn��5      $��4��6%   $��Cancel��65   $
��Left=�6F   $��165,249,0,0q�6a   $	��Top=�6v   $��31��6�   $	��113��6�   ���	#FFF11605$
��Bold"�6�   �� 5   
   $��4��6   $��LOGIN
��6    $
��Left=�6:   $��
240,10,0,0q�6U   $	��Top=�6i   $��50��6�   $	��192��6�   $��36(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ img_logo��5      $��1��6"   $
��Left=�62   $��95��6M   $��10,0,0,0q�6Y   $	��Top=�6k   $	��138��6�   $��4��6�   $*��$/Logo_Trường_Đại_học_FPT.png��6�   �� 5    
   -   5         ��Name$ MainContent��5       5!      5"      