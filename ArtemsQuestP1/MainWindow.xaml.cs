using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace ArtemsQuestP1
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		SolidColorBrush white = new SolidColorBrush(Colors.White);
		SolidColorBrush blue = new SolidColorBrush(Colors.Blue);
		SolidColorBrush red = new SolidColorBrush(Colors.Red);
		SolidColorBrush green = new SolidColorBrush(Colors.Green);
		SolidColorBrush black = new SolidColorBrush(Colors.Black);

		public void ChangeColor(Button button)
		{
			if (((SolidColorBrush)button.Background).Color == Colors.White)
			{
				button.BorderBrush = blue;
				button.Background = blue;
				return;
			}
			else if (((SolidColorBrush)button.Background).Color == Colors.Blue)
			{
				button.BorderBrush = red;
				button.Background = red;
				return;
			}
			else if (((SolidColorBrush)button.Background).Color == Colors.Red)
			{
				button.BorderBrush = green;
				button.Background = green;
				return;
			}
			else if (((SolidColorBrush)button.Background).Color == Colors.Green)
			{
				button.BorderBrush = black;
				button.Background = black;
				return;
			}
			else if (((SolidColorBrush)button.Background).Color == Colors.Black)
			{
				button.BorderBrush = white;
				button.Background = white;
				return;
			}
		}

		public MainWindow()
		{
			InitializeComponent();

			Button[] buttons = new Button[121];

			for (int j = 0; j < Math.Sqrt(buttons.Length); j++)
			{
				Grid1.RowDefinitions.Add(new RowDefinition() );
			}

			for (int j = 0; j < Math.Sqrt(buttons.Length); j++)
			{
				Grid1.ColumnDefinitions.Add(new ColumnDefinition() );
			}
			for (int i = 0; i < Math.Sqrt(buttons.Length); i++)
			{
				for (int j = 0; j < Math.Sqrt(buttons.Length); j++)
				{
					buttons[i * (int)Math.Sqrt(buttons.Length) + j] = new Button();
					buttons[i * (int)Math.Sqrt(buttons.Length) + j].Background = white;
					buttons[i * (int)Math.Sqrt(buttons.Length) + j].BorderBrush = white;
					buttons[i * (int)Math.Sqrt(buttons.Length) + j].Click += Button_Click;
					Grid1.Children.Add(buttons[i * (int)Math.Sqrt(buttons.Length) + j]);
					Grid.SetColumn(buttons[i * (int)Math.Sqrt(buttons.Length) + j], j);
					Grid.SetRow(buttons[i * (int)Math.Sqrt(buttons.Length) + j], i);
				}
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ChangeColor((Button)sender);
		}
	}
}
