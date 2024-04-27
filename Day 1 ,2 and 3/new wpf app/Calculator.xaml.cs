using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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

namespace new_wpf_app
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
            text.IsReadOnly = true;
        }

		private void btnClicked(object sender, RoutedEventArgs e)
		{
            var str = (sender as Button)?.Content.ToString();
			text.Text +=str;
		}

		private void equalClicked(object sender, RoutedEventArgs e)
		{
			string expression = text.Text.Trim();
			DataTable dt = new DataTable();
			var result = dt.Compute(expression, "");
			text.Text = result.ToString();
		}

		private void clearClicked(object sender, RoutedEventArgs e)
		{
			text.Text = "";
		}
	}
}
