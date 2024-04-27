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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //btn1.Content = "Click";
            InitializeComponent();
        }

        private void btn1Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Btn1 is Clicked");

        }
    }
}