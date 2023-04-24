using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Day8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxGender.Text = "";
            textBoxAddress.Text = "";
            textBoxMobile.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxJobTitle.Text = "";        
       
        }
      
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show($"FName : {textBoxFirstName.Text}\n\nLName : {textBoxLastName.Text}\n\nGender : {textBoxGender.Text}\n\nAddress : {textBoxAddress.Text}\n\nPhone : {textBoxPhone.Text}\n\nMobile : {textBoxMobile.Text} \n\nEmaill : {textBoxEmail.Text} \n\nJob Title : {textBoxJobTitle.Text}","Personal Information", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                MessageBox.Show("Data Saved Successfully !!! ");
            }
            else if(result == MessageBoxResult.Cancel)
            {
                Close();
            }

        }
    }
}