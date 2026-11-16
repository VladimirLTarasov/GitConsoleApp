using GitConsoleApp;

namespace GitCalculatorTestProject
{
	[TestClass]
	public sealed class ModernCalculatorTest
	{
		[TestMethod]
		public void Add_CorrectValues_Success()
		{
			/// Arrange
			var expectedSum = 11;

			/// Act
			var actualSum = ModernCalculator.Add(3, 7);

			/// Assert
			Assert.AreEqual(expectedSum, actualSum);
		}
	}
}
