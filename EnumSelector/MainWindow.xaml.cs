using System.Windows;

namespace EnumSelector
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			DataContext = new SomeViewModel();
		}
	}
}
