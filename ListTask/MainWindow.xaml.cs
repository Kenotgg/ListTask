using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListTask
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
        private void ThrowError(object sender, RoutedEventArgs e)
        {
            string text = "Error";
            if (text != "")
            {
                MessageBox.Show(text);
            }
        }

        private void DeleteAllElements(object sender, RoutedEventArgs e)
        {
           
           listView1.Items.Clear();
           number = 0;
            
        }

        private void DeleteHighlitedElement(object sender, RoutedEventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItem);
        }
        int number = 0;
        private void AddElementToListView(object sender, RoutedEventArgs e)
        {
            
            
            listView1.Items.Add(number);
            number++;

        }
    }
   
}