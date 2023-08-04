

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.Aplication.Queries.Tests
{
    [TestClass]
    public class IsItValidQueryHandlerTests
    {

        [TestMethod]
        public async void HandleTest()
        {
            // Given
            var handler = new IsItValidQueryHandler();
            var request = new IsItValidQuery()
            {
                X1 = 0,
                V1 = 1,
                X2 = 2,
                V2 = 2,
            };

            // When
            var result = await handler.Handle(request, default);

            // Then
            Assert.AreEqual("SI", result);
        }
    }
}