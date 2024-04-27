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
using System.Windows.Shapes;

namespace new_wpf_app
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
		public List<Student> std { get; set; }
		public List()
        {
            InitializeComponent();
			List<Student> students = new List<Student>()
			{
				new Student (){ Id = 1 , Age = 18 , Image = "Aaron.jpg" , Name = "Aaron"},
				new Student (){ Id = 2 , Age = 16 , Image = "Inej.jpg" , Name = "Inej"},
				new Student (){ Id = 3 , Age = 25 , Image = "Nesta.jpg" , Name = "Nesta"},
				new Student (){ Id = 4 , Age = 20 , Image = "Dorian.jpg" , Name = "Dorian"},
				new Student (){ Id = 5 , Age = 25 , Image = "Manon.jpg" , Name = "Manon"},
				new Student (){ Id = 6 , Age = 17 , Image = "Carden.jpg" , Name = "Carden"},
			};
			
			this.DataContext = this;
			std = students;
		}
    }
}
