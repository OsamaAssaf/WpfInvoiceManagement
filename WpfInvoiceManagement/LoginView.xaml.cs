using System.Windows;
using System.Windows.Controls;

namespace WpfInvoiceManagement
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string passwordEnterned = PasswordBox.Password;

            if (string.IsNullOrEmpty(passwordEnterned)) return;

            string? envPassword = Environment.GetEnvironmentVariable("InvoiceManagementPassword");

            if (envPassword == null)
            {
                MessageBox.Show("Environment Variable \"InvoiceManagementPassword\" Is Not Set");
                return;
            }

            if (passwordEnterned == envPassword)
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid password. Please try again.");
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            string passwordEnterned = PasswordBox.Password;
            LoginButton.IsEnabled = !string.IsNullOrEmpty(passwordEnterned);
        }
    }
}