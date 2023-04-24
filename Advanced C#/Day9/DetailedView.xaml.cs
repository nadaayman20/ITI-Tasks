using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
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
using static Task9_WPF.Database_Handeler;

namespace Task9_WPF
{
    /// <summary>
    /// Interaction logic for DetailedView.xaml
    /// </summary>
    public partial class DetailedView : Window
    {
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        SqlCommandBuilder Builder = new SqlCommandBuilder();

        public DetailedView()
        {
            InitializeComponent();
            command.Connection = DBHandeler;
            Load();

        }
        private void Load()
        {
            if (!productList.Items.IsEmpty)
            {
                productList.ItemsSource = null;
            }
            else
            {
                command.CommandText = "Select * from products";
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
                productList.ItemsSource = dataTable.AsDataView();
                productList.DisplayMemberPath = "ProductName";
                productList.SelectedValuePath = "ProductID";
                productList.SelectionChanged += (sender, e) => StackPanelCustom.DataContext = productList.SelectedItem;
                ProductID.SetBinding(ContentProperty, new Binding("ProductID"));
                ProductName.SetBinding(TextBox.TextProperty, new Binding("ProductName"));
                ProductPrice.SetBinding(TextBox.TextProperty, new Binding("UnitPrice"));
                productList.DataContext = dataTable;
            }
           
        }
        private void Save(object sender, RoutedEventArgs e)
        {
           
                Builder.DataAdapter = dataAdapter;
                if (productList == null || dataAdapter == null){
                return;
                }
                dataAdapter.Update(dataTable);
            

        }
    

    }
}
