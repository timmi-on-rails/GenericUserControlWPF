namespace EnumSelector
{
	public enum DayOfWeek
	{
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday
	}

	public class DayOfWeekSelector : EnumComboBox<DayOfWeek> { }
}
