﻿using Day2.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HttpClient client = new HttpClient();
            HttpResponseMessage resp = client.GetAsync("https://localhost:7208/api/Instructor").Result;

            if (resp.IsSuccessStatusCode)
            {
                List<Instructor>? emps = resp.Content.ReadFromJsonAsync<List<Instructor>>().Result;
                Data.ItemsSource = emps.ToList();

            }
        }
    }
}
