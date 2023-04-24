using Day_10.Entities;
using System;
using Microsoft.EntityFrameworkCore;
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


namespace Day_10
{
    /// <summary>
    /// Interaction logic for DetailedView.xaml
    /// </summary>
    public partial class DetailedView : Window
    {
        pubsContext Context;

        public DetailedView()
        {
            Context = new pubsContext();
            InitializeComponent();
            Closing += (sender, e) => Context.Dispose();
            Load();
        }

        private void Load()
        {
            if (!productList.Items.IsEmpty)
                productList.ItemsSource = null;
            Context.titles.Load();
            Context.publishers.Load();
            productList.ItemsSource = Context.titles.Local.ToBindingList();
            productList.DisplayMemberPath = "title1";
            productList.SelectedValuePath = "title_id";
            productList.SelectionChanged += (sender, e) => StackPanelCustom.DataContext = productList.SelectedItem;
            ProductID.SetBinding(ContentProperty, new Binding("title_id"));
            ProductName.SetBinding(TextBox.TextProperty, new Binding("title1"));
            ProductPrice.SetBinding(TextBox.TextProperty, new Binding("price"));
            box.ItemsSource = Context.publishers.Local.ToBindingList();
            box.SelectedValuePath = "pub_id";
            box.DisplayMemberPath = "pub_name";
            box.SetBinding(ComboBox.SelectedValueProperty, new Binding("pub_id"));
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Context.SaveChanges();
        }
    }
}
