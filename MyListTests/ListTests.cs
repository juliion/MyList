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
        [TestMethod]
        public void AddLast_AddElementAtEndList_ElementAtEnd()
        {
            List list = new List();
            char element = 'e';
            list.AddLast(element);
            char lastElement = list.Tail.Data;
            Assert.AreEqual(element, lastElement);
        }
        [TestMethod]
        public void Count_LengthAfterAddingThreeElements_3()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            int expectedLength = 3;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            int actualLength = list.Count;
            Assert.AreEqual(expectedLength, actualLength);
        }
        [TestMethod]
        public void Get_GetElementAtIndexOne_CorrectlyGottenElement()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            int ind = 1;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            char gottenSecondElement = list.Get(ind);
            Assert.AreEqual(secondElement, gottenSecondElement);
        }
        [TestMethod]
        public void InsertAt_InsertInMiddle_ElemInsertedAtIndexInMiddle()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            char insElem = 'i';
            int insInd = 1;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.InsertAt(insElem, insInd);
            Assert.AreEqual(insElem, list.Get(insInd));
        }
        [TestMethod]
        public void InsertAt_InsertAtBegin_ElemInsertedAtIndexZero()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            char insElem = 'i';
            int insInd = 0;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.InsertAt(insElem, insInd);
            Assert.AreEqual(insElem, list.Get(insInd));
        }
    }
}