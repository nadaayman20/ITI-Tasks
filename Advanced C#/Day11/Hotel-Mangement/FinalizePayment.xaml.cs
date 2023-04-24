using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hotel_Mangement_System
{
   
    /// <summary>
    /// Interaction logic for FinalizePayment.xaml
    /// </summary>
    public partial class FinalizePayment : Window
    {

        public FinalizePayment()
        {
            InitializeComponent();
            LoadPaymentDetails();
        }
        public int totalAmountFromFrontend = 20;
        public int foodBill = 0;
        private double finalTotalFinalized { get; set; } = 0.0;
        private string paymentType { get; set; }
        private string paymentCardNumber;
        private string MM_YY_Of_Card;
        private string CVC_Of_Card;
        private string CardType;



        public double FinalTotalFinalized
        {
            get { return finalTotalFinalized; }
            set { finalTotalFinalized = value; }
        }

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }

        public string PaymentCardNumber
        {
            get { return paymentCardNumber; }
            set { paymentCardNumber = value; }
        }

        public string MM_YY_Of_Card1
        {
            get { return MM_YY_Of_Card; }
            set { MM_YY_Of_Card = value; }
        }

        public string CVC_Of_Card1
        {
            get { return CVC_Of_Card; }
            set { CVC_Of_Card = value; }
        }

        public string CardType1
        {
            get { return CardType; }
            set { CardType = value; }
        }

        private void CheckType(object sender, EventArgs e)
        {


        }
        private void LoadPaymentDetails()
        {

            // load combobox

            foreach (var item in Enumerable.Range(1, 12))
            {
                MonthCombo.Items.Add(item);
            }

            foreach (var item in Enumerable.Range(14, 24))
            {
                yearCombo.Items.Add(item);
            }


        }

        public void LoadDetailsFromFrontEnd()
        {
            double totalWithTax = Convert.ToDouble(totalAmountFromFrontend) * 0.07;
            double FinalTotal = Convert.ToDouble(totalAmountFromFrontend) + totalWithTax + foodBill;


            // show prices on screen
            currentBill_Price.Content = "$" + Convert.ToString(totalAmountFromFrontend) + " USD";
            foodBill_Price.Content = "$" + Convert.ToString(foodBill) + " USD";
            Tax_Price.Content = "$" + Convert.ToString(totalWithTax) + " USD";
            Total_Price.Content = "$" + Convert.ToString(FinalTotal) + " USD";

            FinalTotalFinalized = FinalTotal;

            PaymentTypeComb.SelectedItem = PaymentType?.Trim().ToString() ?? "credit";
        }

        private void NextClick(object sender, RoutedEventArgs e)
        {
            try
            {
                PaymentType = ((ComboBoxItem)PaymentTypeComb.SelectedItem).Content.ToString() ?? "Depit";
                PaymentCardNumber = CardNumber.Text;

                MM_YY_Of_Card1 = MonthCombo?.SelectedItem?.ToString() + "/" + yearCombo?.SelectedItem?.ToString() ?? "NA";
                CVC_Of_Card1 = CVCText.Text;
                CardType1 = cardTypeTxt.Text;

                this.Hide();
            }
            catch (Exception)
            {
                PaymentError.Visibility = Visibility.Visible;
            }

        }
        private void MonthCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cardTypeTxt != null)
            {
               
                if (CardNumber.Text.Substring(0, 1) == "4")
                {
                    cardTypeTxt.Text = "Visa";
                }
                else if (CardNumber.Text.Substring(0, 1) == "5")
                {
                    cardTypeTxt.Text = "MasterCard";
                }
                else if (CardNumber.Text.Substring(0, 1) == "6")
                {
                    cardTypeTxt.Text = "Discover";
                }
                else
                    cardTypeTxt.Text = "Unknown";
            }

        }

        private void Error_CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            PaymentError.Visibility = Visibility.Hidden;

        }
        private void CardNumber_Leave(object sender, EventArgs e)
        {
            //long getNumber = Convert.ToInt64(cardTypeTxt.Text);
            //string formatString = String.Format("{0:0000-0000-0000-0000}", getNumber);
            //cardTypeTxt.Text = formatString;
        }
    }
}
