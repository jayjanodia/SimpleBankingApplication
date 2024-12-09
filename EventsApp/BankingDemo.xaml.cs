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
using Libraries;

namespace EventsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BankingDemo : Window
    {
        Customer customer = new Customer();
        private ATM _atmWindow; // Store a reference to the ATM window

        public BankingDemo()
        {
            InitializeComponent();

            LoadTestingData();
            WireUpForm();
        }

        private void LoadTestingData()
        {
            customer.CustomerName = "Jay Janodia";
            customer.CheckingAccount = new Account();
            customer.SavingsAccount = new Account();

            customer.CheckingAccount.AccountNumber = 1;
            customer.SavingsAccount.AccountNumber = 2;

            customer.CheckingAccount.AddDeposit("Initial Balance", 155.43M); // M indicates number is a decimal not a double
            customer.SavingsAccount.AddDeposit("Initial balance", 4838.57M); 
        }

        private void WireUpForm()
        {
            lblCustomer.Content = customer.CustomerName;
            checkingTransactions.ItemsSource = customer.CheckingAccount.Transactions;
            savingTransactions.ItemsSource = customer.SavingsAccount.Transactions;
            lblCheckingBalance.Content = string.Format("{0:C2}", customer.CheckingAccount.Balance);
            lblSavingBalance.Content = string.Format("{0:C2}", customer.SavingsAccount.Balance);

            customer.CheckingAccount.TransactionApprovedEvent += CheckingAccount_TransactionApprovedEvent;
            customer.SavingsAccount.TransactionApprovedEvent += SavingsAccount_TransactionApprovedEvent;
            customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }

        private void CheckingAccount_OverdraftEvent(object? sender, decimal e)
        {
            lblErrorMsg.Content = $"You had an overdraft protection transfer of {string.Format("{0:C2}", e)}";
            lblErrorMsg.Visibility = Visibility.Visible;
        }

        private void SavingsAccount_TransactionApprovedEvent(object? sender, string e)
        {
            savingTransactions.ItemsSource = customer.SavingsAccount.Transactions;
            lblSavingBalance.Content = string.Format("{0:C2}", customer.SavingsAccount.Balance);
        }

        private void CheckingAccount_TransactionApprovedEvent(object? sender, string e)
        {
            checkingTransactions.ItemsSource = customer.CheckingAccount.Transactions;
            lblCheckingBalance.Content = string.Format("{0:C2}", customer.CheckingAccount.Balance);
        }

        private void btnRecordTransactions_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of ATM if it does not exist or if it has been closed
            if (_atmWindow == null || !_atmWindow.IsLoaded)
            {
                _atmWindow = new ATM(customer);
                _atmWindow.Show();
            }
            else
            {
                // If an ATM instance is already open, bring it back into the foreground
                if (_atmWindow.WindowState == WindowState.Minimized)
                {
                    _atmWindow.WindowState = WindowState.Normal; // Restore if minimizzed
                }
                _atmWindow.Activate();
            }
        }

        private void lblErrorMsg_MouseDown(object sender, MouseButtonEventArgs e)
        {
             lblErrorMsg.Visibility = Visibility.Hidden; // Or Visibility.Collapsed for getting rid of the reserved space
        }
    }
}