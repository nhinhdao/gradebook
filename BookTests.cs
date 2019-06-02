using System;
using Xunit;

namespace GradeBook.tests {
	public class BookTests {
		[Fact]
		public void BookCalculation () {
			// arrange
			var book = new Book ("Nhinh");
			book.AddGrade (89.3);
			book.AddGrade (99.3);
			book.AddGrade (70.3);

			// act
			var result = book.GetStatistics ();

			// assert
			Assert.Equal (86.3, result.Average, 1);
			Assert.Equal (99.3, result.HighestGrade, 1);
			Assert.Equal (70.3, result.LowestGrade, 1);

			Console.WriteLine ($"Highest grade: {result.HighestGrade}");
			Console.WriteLine ($"Lowest grade: {result.LowestGrade}");
			Console.WriteLine ($"Average grade: {result.Average}");
		}
	}
}