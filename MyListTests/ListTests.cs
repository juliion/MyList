using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyList;

namespace MyListTests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void Count_EmptyListLength_0()
        {
            List emptyList = new List();
            int expectedLength = 0;
            int actualLength = emptyList.Count;
            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}