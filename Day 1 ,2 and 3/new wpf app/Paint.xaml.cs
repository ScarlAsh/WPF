using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;


namespace Labone
{
	/// <summary>
	/// Interaction logic for Paint.xaml
	/// </summary>
	public partial class Paint : Window
	{
		
		public Paint()
		{
			InitializeComponent();
		}

		private void changeColor(object sender, RoutedEventArgs e)
		{
			var color = (sender as RadioButton)?.Content.ToString();

			switch (color)
			{
				case "Red":
					canvas.DefaultDrawingAttributes.Color = Colors.Red;
					break;
				case "Green":
					canvas.DefaultDrawingAttributes.Color = Colors.Green;
					break;
				case "Blue":
					canvas.DefaultDrawingAttributes.Color = Colors.Blue;
					break;
				case "Magenta":
					canvas.DefaultDrawingAttributes.Color = Colors.Magenta;
					break;
				default:
					break;
			}
		}

		private void changeMode(object sender, RoutedEventArgs e)
		{
			var mode = (sender as RadioButton)?.Content?.ToString();

			switch (mode)
			{
				case "Ink":
					canvas.EditingMode = InkCanvasEditingMode.Ink;
					break;
				case "Select":
					canvas.EditingMode = InkCanvasEditingMode.Select;
					break;
				case "Erase":
					canvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
					break;
				case "Erase by stroke":
					canvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
					break;
				default:
					break;
			}
		}

		private void changeShape(object sender, RoutedEventArgs e)
		{
			var shape = (sender as RadioButton)?.Content.ToString();
			switch (shape)
			{
				case "Ellipse":
					canvas.DefaultDrawingAttributes.StylusTip = StylusTip.Ellipse;
					break;
				case "Rectangle":
					canvas.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;
					break;

				default:
					break;
			}

		}

		private void changeSize(object sender, RoutedEventArgs e)
		{
			var size = (sender as RadioButton)?.Content.ToString();

			switch (size)
			{
				case "Small":
					canvas.DefaultDrawingAttributes.Width = 1;
					canvas.DefaultDrawingAttributes.Height = 1;
					break;
				case "Normal":
					canvas.DefaultDrawingAttributes.Width = 5;
					canvas.DefaultDrawingAttributes.Height = 5;
					break;
				case "Large":
					canvas.DefaultDrawingAttributes.Width = 10;
					canvas.DefaultDrawingAttributes.Height = 10;
					break;
				default:
					break;
			}
		}

		private void newClicked(object sender, RoutedEventArgs e)
		{
			canvas.Strokes.Clear();
		}

		private void saveClicked(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "Ink Serialized Format (*.isf)|*.isf"
			};

			if (saveFileDialog.ShowDialog() == true)
			{
				using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
				{
					canvas.Strokes.Save(fs);
				}
			}
		}

		private void loadClicked(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Ink Serialized Format (*.isf)|*.isf"
			};

			if (openFileDialog.ShowDialog() == true)
			{
				canvas.Strokes.Clear();
				using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
				{
					StrokeCollection strokes = new StrokeCollection(fs);
					canvas.Strokes.Add(strokes);
				}
			}
		}

		private void copyClicked(object sender, RoutedEventArgs e)
		{
			canvas.CopySelection();
		}

		private void cutClicked(object sender, RoutedEventArgs e)
		{
			canvas.Strokes.Remove(canvas.GetSelectedStrokes());
		}

		private void pasteClicked(object sender, RoutedEventArgs e)
		{
			canvas.Paste();
		}
	}
}
