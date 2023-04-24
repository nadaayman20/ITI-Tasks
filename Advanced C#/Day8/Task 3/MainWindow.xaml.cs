using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Day_8_P3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            studentName.ItemsSource = new List<student>() {


                new student() { Name = "Omnia Ayman",Age = 24, Grade = 100, Image = "/images/image1.png" },
                new student() { Name = "Nada Ayman",Age = 22, Grade = 98, Image = "/images/image2.png" },
                new student() { Name = "Reem Ayman",Age = 20, Grade = 97, Image = "/images/image5.png" },
                new student() { Name = "Mohamed Ayman",Age = 15, Grade = 96, Image = "/images/image3.png" },
             
               
    };
}
} 
}
