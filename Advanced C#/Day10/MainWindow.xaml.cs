using Day_10.Entities;
using Microsoft.EntityFrameworkCore;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Day_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         pubsContext Context ;

        public MainWindow()
        {
            Context = new pubsContext();
            InitializeComponent();
            Closing += (sender, e) => Context.Dispose();
        }

        private void DataLoaded(object sender, RoutedEventArgs e)
        {
            DataGridComboBoxColumn comboBox = new();
            comboBox.SelectedValueBinding = new Binding("pub_id");
            Context.titles.Load(); 
            Context.publishers.Load();
            comboBox.ItemsSource = Context.publishers.Local.ToBindingList();
            comboBox.Header = "Publisher Header";
            comboBox.DisplayMemberPath = "pub_name";
            comboBox.SelectedValuePath = "pub_id";
            
            data.ItemsSource = Context.titles.Local.ToBindingList();
            data.Columns.ElementAt(3).IsReadOnly = true;
            data.Columns.ElementAt(3).Header = "Publisher";
            data.Columns.ElementAt(1).Width = 150;
            data.Columns.ElementAt(3).Width = 80;
            data.Columns.ElementAt(4).Width = 80;
            data.Columns.ElementAt(6).Width = 80;
            data.Columns.ElementAt(7).Width = 80;
            data.Columns.ElementAt(8).Width = 130;
            data.Columns.RemoveAt(10);
            data.Columns.Add(comboBox);
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Context.SaveChanges();
        }
    }
}
