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

namespace Labone
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
		private void okClicked(object sender, RoutedEventArgs e)
		{
			string Fname = fname.Text;
			string Lname = lname.Text;
			string Gender = gender.Text;
			string Address = address.Text;
			string Phone = phone.Text;
			string Mobile = mobile.Text;
			string Email = email.Text;
			string Job = job.Text;
			var result = MessageBox.Show("your name is : " + Fname + " " + Lname +"\ngender : "+ Gender + "\nAddress : " + Address + "\nphone : " + Phone
				+"\nmobile : " + Mobile + "\nemail : " + Email + "\njob title : " + Job,
				"" , MessageBoxButton.OKCancel);

			if(result == MessageBoxResult.OK)
			{
				MessageBox.Show("your data was saved successfully");
			}
			
		}

		private void cancelClicked(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}