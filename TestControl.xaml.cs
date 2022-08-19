using System.Windows.Controls;

namespace ProjectWideNullWithGenericControlls {
	public partial class TestControl : Generic<TypeArgument> {
		public TestControl()
		{
			InitializeComponent();
		}
	}

	public class TypeArgument {}
	public class Generic<T> : Base where T : class {}
	public class Base : UserControl {}
}
