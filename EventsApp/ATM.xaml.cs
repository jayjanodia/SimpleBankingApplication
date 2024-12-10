using Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EventsApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ATM : Window
    {

        private Customer _customer;
        public ATM(Customer customer)
        {
            InitializeComponent();
            this._customer = customer;

            lblCustomer.Content = _customer.CustomerName;
            if (this._customer.CheckingAccount != null)
            {
                this._customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
            }
        }

        private void CheckingAccount_OverdraftEvent(object? sender, OverdraftEventArgs e)
        {
            lblErrorMsg.Content = $"Overdraft protection transfer of {string.Format("{0:C2}", e.AmountOverdrafted)}";
            lblErrorMsg.Visibility = Visibility.Visible;
        }

        private void btnMakePurchase_Click(object sender, RoutedEventArgs e)
        {
            // decimal amount = amountVal.Value.HasValue ? (decimal)amountVal.Value.Value : 0; // useful if we are unsure if amountVal.Value will ever be null or not

            decimal amount = (decimal)(amountVal.Value ?? 0);

            if (amount == 0)
            {
                Console.WriteLine("Amount is 0, cannot or should not withdraw anything");
                MessageBox.Show("Please enter a valid amount", "Insufficient amount entered", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }

            if (_customer.CheckingAccount != null && _customer.SavingsAccount != null)
            {
                bool payment = _customer.CheckingAccount.MakePayment("Credit Card Purchase", amount, _customer.SavingsAccount);
            }
            amountVal.Value = 0;
        }
        
        private void lblErrorMsg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lblErrorMsg.Visibility = Visibility.Hidden; // Or Visibility.Collapsed for getting rid of the reserved space
        }
    }
}
