using Api.Aplication.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.Aplication.Validator.Tests
{
    [TestClass]
    public class IsItValidCommandValidatorTests
    {
        [TestMethod]
        [DataRow(1, 1, 0, 0, " se debe cumplir lo siguiente 0 <= X1 < X2 <= 100000")]
        [DataRow(1, 1, 10001, 0, " se debe cumplir lo siguiente 0 <= X1 < X2 <= 100000")]
        [DataRow(1, 1, -1, 0, " se debe cumplir lo siguiente 0 <= X1 < X2 <= 100000")]
        [DataRow(-1, 1, 1, 0, " se debe cumplir lo siguiente 0 <= X1 < X2 <= 100000")]
        [DataRow(1, 0, 1, 0, " se debe cumplir lo siguiente 1 <= V1 <= 100000")]
        [DataRow(1, 10001, 1, 0, " se debe cumplir lo siguiente 1 <= V1 <= 100000")]
        [DataRow(1, 1, 0, 0, " se debe cumplir lo siguiente 1 <= V2 <= 100000")]
        [DataRow(1, 1, 0, 10001, " se debe cumplir lo siguiente 1 <= V2 <= 100000")]
        public void IsItInValidCommandValidatorTest(int x1, int v1, int x2, int v2, string res)
        {
            // Given
            var validator = new IsItValidCommandValidator();
            var request = new IsItValidQuery()
            {
                X1 = x1,
                V1 = v1,
                X2 = x2,
                V2 = v2,
            };

            // When
            var result = validator.Validate(request);

            // Then
            Assert.IsTrue(result.Errors.Any(x => x.ErrorMessage == res));
        }

        [TestMethod]
        [DataRow(0, 3, 4, 2)]
        [DataRow(2, 4, 4, 3)]
        [DataRow(4, 2, 5, 1)]
        public void IsItValidCommandValidatorTest(int x1, int v1, int x2, int v2)
        {
            // Given
            var validator = new IsItValidCommandValidator();
            var request = new IsItValidQuery()
            {
                X1 = x1,
                V1 = v1,
                X2 = x2,
                V2 = v2,
            };

            // When
            var result = validator.Validate(request);

            // Then
            Assert.IsTrue(result.Errors.Count() ==  0);
        }
    }
}