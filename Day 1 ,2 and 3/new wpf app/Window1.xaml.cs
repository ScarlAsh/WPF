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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace new_wpf_app
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

		private void selectClicked(object sender, RoutedEventArgs e)
		{
			textBox.Focus();
			textBox.SelectAll();
		}

		private void setClicked(object sender, RoutedEventArgs e)
		{
			FlowDocument flowDocument = new FlowDocument(new Paragraph(new Run("Replace default text with initial text value")));
			textBox.Document = flowDocument;
		}

		private void clearClicked(object sender, RoutedEventArgs e)
		{
			textBox.Document = new FlowDocument();
		}

		private void prependClicked(object sender, RoutedEventArgs e)
		{
			TextRange textRange = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd);

			string text = textRange.Text;

			FlowDocument flowDocument = new FlowDocument(new Paragraph(new Run("prepended text" + " " + text)));
			textBox.Document = flowDocument;

		}

		private void appendClicked(object sender, RoutedEventArgs e)
		{
			TextRange textRange = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd);

			string text = textRange.Text;

			FlowDocument flowDocument = new FlowDocument(new Paragraph(new Run(text+" " + "Appended text")));
			textBox.Document = flowDocument;
		}

		private void insertClicked(object sender, RoutedEventArgs e)
		{
			TextPointer caretPosition = textBox.CaretPosition;
			caretPosition.InsertTextInRun("inserted text");
		}

		private void cutClicked(object sender, RoutedEventArgs e)
		{
			textBox.Cut();
		}

		private void pasteClicked(object sender, RoutedEventArgs e)
		{
			textBox.Paste();
		}

		private void undoClicked(object sender, RoutedEventArgs e)
		{
			textBox.Undo();
		}

		private void edit(object sender, RoutedEventArgs e)
		{
			textBox.IsReadOnly = false;
		}

		private void readonlyClicked(object sender, RoutedEventArgs e)
		{
			textBox.IsReadOnly = true;
		}

		private void leftCLicked(object sender, RoutedEventArgs e)
		{
			textBox.Document.TextAlignment = TextAlignment.Left;
		}

		private void centerClicked(object sender, RoutedEventArgs e)
		{
			textBox.Document.TextAlignment = TextAlignment.Center;
		}

		private void rightClicked(object sender, RoutedEventArgs e)
		{
			textBox.Document.TextAlignment = TextAlignment.Right;
		}
	}
}
