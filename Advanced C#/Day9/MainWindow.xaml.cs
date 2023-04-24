using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using static Task9_WPF.Database_Handeler;

namespace Task9_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlCommand command=new SqlCommand();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        SqlCommandBuilder Builder = new SqlCommandBuilder();

        public MainWindow()
        {
            InitializeComponent();
            command.Connection = DBHandeler;
        }
        private void Load(object sender, RoutedEventArgs e)
        {
            if (!data.Items.IsEmpty)
            {
                data.ItemsSource = null;
            }
            command.CommandText = "Select * from products";
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            data.ItemsSource = dataTable.AsDataView();
        }
        private void Save(object sender, RoutedEventArgs e)
        {
            Builder.DataAdapter = dataAdapter;
            if (data == null || dataAdapter == null) 
                return ;
            else
            {
                data.CommitEdit();
                dataAdapter.Update(dataTable);
                dataAdapter.DeleteCommand = dataAdapter.SelectCommand;
            }
           
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            if (!data.Items.IsEmpty)
                data.ItemsSource = null;
        }
        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
