using Azure.Messaging;
using BespokeFusion;
using Hotel_Mangement_System.Context;
using Microsoft.IdentityModel.Tokens;
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

namespace Hotel_Mangement_System
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>

    public partial class login : Window
    {
        LoginContext loginDB = new();

        public login()
        {
            InitializeComponent();
            Closed += (sender, e) => loginDB.Dispose();
        }
        private void UserGotFocus_Click(object sender, EventArgs e)
        {

            if (text1.Text == "Username")
                text1.Text = "";
            label1.Content = "Username";
        }

        private void PassGotFocus_Click(object sender, EventArgs e)
        {

            if (text2.Password == "Password")
                text2.Password = "";
            label2.Content = "Password";

        }

        private void SignIn_Button(object sender, EventArgs e)
        {

            if ((text1.Text == "admin" || text1.Text == "Admin") && (text2.Password == "admin" || text2.Password == "Admin"))
            {
                FrontEnd front = new FrontEnd();
                front.Show();
                Close();
            }
            else if ((text1.Text == "kitchen" || text1.Text == "Kitchen") && (text2.Password == "kitchen" || text2.Password == "Kitchen"))
            {
                Kitchen roomService = new Kitchen();
                roomService.Show();
                Close();
            }

            else
            {
                var result = MaterialMessageBox.ShowWithCancel("Username or password is wrong , Please try again! ", "Login Failed");



            }

        }
        private void License_Button(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("Open Source frameworks:\r\nModern UI - most of the metro UI implimented using this open source framework\r\nlicense under: MIT -" +
                " http://github.com/viperneo\r\n\r\nTwilio - this framework by twilio was used to send the Message to phone number \r\nregarding\r\ncustomer reservation." +
                " \r\nhttps://www.twilio.com/\r\n\r\n", "License");



        }
    }
}