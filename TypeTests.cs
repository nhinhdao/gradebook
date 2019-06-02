using System;
using Xunit;

namespace GradeBook.tests {
	public class TypeTests {
		[Fact]
		public void CSharpIsPassByValue () {
			// arrange
			var a = 4;
			var upper = a;
			a = 5;

			Assert.Equal(4, upper);

			// act

			// assert
			// Assert.Same (a, upper);

		}

		private string SetUpper (string a) {
			return a.ToUpper ();
		}

	}
}