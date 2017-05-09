using System;
using System.Windows;
using System.Windows.Controls;

namespace EnumSelector
{
	public abstract partial class EnumComboBox : UserControl { }

	public class EnumComboBox<T> : EnumComboBox where T : struct
	{
		public T SelectedEnumValue
		{
			get { return (T)GetValue(SelectedEnumValueProperty); }
			set { SetValue(SelectedEnumValueProperty, value); }
		}

		public static readonly DependencyProperty SelectedEnumValueProperty =
			DependencyProperty.Register("SelectedEnumValue", typeof(T), typeof(EnumComboBox<T>), new FrameworkPropertyMetadata { BindsTwoWayByDefault = true });

		public EnumComboBox()
		{
			InitializeComponent();

			foreach (Enum enumValue in Enum.GetValues(typeof(T)))
			{
				comboBox.Items.Add(enumValue);
			}
		}
	}
}
