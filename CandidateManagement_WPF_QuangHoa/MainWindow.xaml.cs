using Candidate_BusinessObjects;
using Candidate_Service;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CandidateManagement_WPF_QuangHoa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IHRAccountService hRAccountService;
        public MainWindow()
        {
            InitializeComponent();
            hRAccountService = new HRAccountService();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            Hraccount hraccount = hRAccountService.GetHraccountByEmail(txtEmail.Text);
            if (hraccount != null && hraccount.Password.Equals(txtPassword.Password) && hraccount.MemberRole == 1)
            {
                Candidate candidateProfileWindow = new Candidate();
                candidateProfileWindow.Show();
            }
            else
            {
                MessageBox.Show("Cook", "Notification");
            }
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}