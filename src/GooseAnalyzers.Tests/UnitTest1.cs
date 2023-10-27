namespace GooseAnalyzers.Tests
{
	/// <summary>
	/// This is a documented interface.
	/// </summary>
	public interface ITestInterface
	{
		/// <summary>
		/// Gets the name.
		/// </summary>
		string Name { get; }
	}

	// The lack of XML doc should yield a warning.
	public interface ITestInterface2
	{
		// The lack of XML doc should yield a warning.
		string Name { get; }
	}

	// The lack of XML doc should NOT yield a warning (because this isn't an interface).
	public class UnitTest1
	{
		// The lack of XML doc should NOT yield a warning (because this isn't an interface member).
		[Fact]
		public void Test1()
		{
		}
	}
}