using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extractor.Tests
{
    [TestClass]
    public class FileReaderTest
    {
        [TestMethod]
        public void TestReader()
        {
            var extractor = new Extractor();
            int totalLines = extractor.Extract(@"C:\Users\saira_000\Desktop\Sai\dotnet\family.csv");
            Assert.AreEqual(4, totalLines);
        }
    }
}
