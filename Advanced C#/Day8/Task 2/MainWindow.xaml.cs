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

namespace Day_8_P2
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
        private void set_text(object sender, RoutedEventArgs e)
        {

            text.Document.Blocks.Clear();
            text.Document.Blocks.Add(new Paragraph(new Run("Replace default text with initial text value")));

        }
        private void select_all(object sender, RoutedEventArgs e)
        {
            text.SelectAll();
            text.Focus();

        }
        private void clear(object sender, RoutedEventArgs e)
        {
            text.Document.Blocks.Clear();

        }
        private void prepend(object sender, RoutedEventArgs e)
        {
            FlowDocument flowDoc = new FlowDocument();
            Paragraph pr = new Paragraph(new Run(" *** Prepended text *** " + new TextRange(text.Document.ContentStart, text.Document.ContentEnd).Text));
            flowDoc.Blocks.Add(pr);
            text.Document = flowDoc;

        }
        private void insert(object sender, RoutedEventArgs e)
        {
            text.CaretPosition.InsertTextInRun(" *** inserted text *** ");
          
        }
        private void append(object sender, RoutedEventArgs e)
        {
            text.AppendText("*** appended text ***");
        }
        private void cut(object sender, RoutedEventArgs e)
        {
            if (text.Selection.IsEmpty)
                MessageBox.Show("Select text to cut first");
            else
            {
                Clipboard.SetText(text.Selection.Text);
                MessageBox.Show($"Cut : {text.Selection.Text}");
               
            }
        }
        private void paste(object sender, RoutedEventArgs e)
        {
            text.CaretPosition.InsertTextInRun(Clipboard.GetText());
        }
        private void undo(object sender, RoutedEventArgs e)
        {
            text.Undo();
        }

        private void editable(object sender, RoutedEventArgs e)
        {
            text.IsReadOnly = false;
        }
        private void ReadOnly(object sender, RoutedEventArgs e)
        {
            text.IsReadOnly = true;
        }
        private void LeftAlign(object sender, RoutedEventArgs e)
        {
            text.Document.TextAlignment= TextAlignment.Left;
        }
        private void CenterAlign(object sender, RoutedEventArgs e)
        {
            text.Document.TextAlignment = TextAlignment.Center;
        }
        private void RightAlign(object sender, RoutedEventArgs e)
        {
            text.Document.TextAlignment = TextAlignment.Right;
        }
    }
}
