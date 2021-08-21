using System;
using System.Windows;

namespace Death_Counter
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		#region Private variables.
		private int counter = 0;
		private string FilePath = AppDomain.CurrentDomain.BaseDirectory + @"\counter.txt";
		#endregion

		#region Constructor.
		public MainWindow()
		{
			InitializeComponent();
			UpdateNumber(ReadFilePath());
		}
		#endregion

		#region Button interactions.
		/// <summary>
		/// Pressing the minus button
		/// </summary>
		private void Minus_Click(object sender, RoutedEventArgs e)
		{
			UpdateNumber(counter - 1);
		}

		/// <summary>
		/// Pressing the plus button
		/// </summary>
		private void Plus_Click(object sender, RoutedEventArgs e)
		{
			UpdateNumber(counter + 1);
		}

		/// <summary>
		/// Pressing the update counter button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CounterBtn_Click(object sender, RoutedEventArgs e)
		{
			UpdateNumber(CheckIfNumber(this.Counter.Text));
		}

		#endregion

		#region Helper methods.
		/// <summary>
		/// Updates the number of deaths.
		/// </summary>
		/// <param name="i">The number that it will update to.</param>
		private void UpdateNumber(int i)
		{
			counter = i;
			Counter.Text = counter.ToString();
			WriteFilePath(i);
		}

		/// <summary>
		/// Reads the number stored in counter.txt
		/// </summary>
		/// <returns>Returns the number stored in counter.txt</returns>
		private int ReadFilePath()
		{
			try
			{

				string text = System.IO.File.ReadAllText(FilePath);
				int num = CheckIfNumber(text);
				return num;
			}
			catch
			{
				return 0;
			}
		}

		/// <summary>
		/// Writes a number to counter.txt or creates the file.
		/// </summary>
		/// <param name="i">The Number to be written.</param>
		private void WriteFilePath(int i)
		{
			System.IO.File.WriteAllText(FilePath, i.ToString());
		}


		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			UpdateNumber(CheckIfNumber(this.Counter.Text));
		}

		private int CheckIfNumber(string str)
		{
			try
			{
				return Convert.ToInt32(str);
			}
			catch
			{
				return counter;
			}
		}
		#endregion
	}
}
