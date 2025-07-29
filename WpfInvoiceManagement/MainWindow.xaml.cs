using System.Windows;

namespace WpfInvoiceManagement
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Content = new LoginView();
        }
    }
}