using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodoDojo34;

namespace CodeDojo34Tests
{
    [TestFixture]
    public class Testable_Tests
    {
        [Test]
        [Ignore]
        public void Echo_returns_passed_string()
        {
            // Arrange
            var stringExpected = Guid.NewGuid().ToString();
            var testable = new Testable();

            // Act
            var stringActual = testable.Echo(stringExpected);

            // Assert
            Assert.AreEqual(stringExpected, stringActual);
        }
    }
}
