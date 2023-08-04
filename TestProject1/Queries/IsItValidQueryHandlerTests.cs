using Api.Aplication.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.Test.Queries
{
    [TestClass]
    public class IsItValidQueryHandlerTests
    {
        [TestMethod]
        [DataRow(1, 1, 1, 1, "NO")]
        [DataRow(2, 0, 1, 0, "NO")]
        [DataRow(0, 3, 4, 9, "NO")]
        [DataRow(4, 1, 2, 2, "SI")]
        [DataRow(0, 3, 4, 2, "SI")]
        public async Task HandleTest(int x1, int v1, int x2, int v2, string res)
        {
            // Given
            var handler = new IsItValidQueryHandler();
            var request = new IsItValidQuery()
            {
                X1 = x1,
                V1 = v1,
                X2 = x2,
                V2 = v2,
            };

            // When
            var result = await handler.Handle(request, default);

            // Then
            Assert.AreEqual(res, result);
        }
    }
}
