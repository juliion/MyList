using System;
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
        public void Get_GetElementAtNegativeIndex_ThrowsException()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            int ind = -1;
            try
            {
                char gottenSecondElement = list.Get(ind);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Wrong index", e.Message);
            }
        }
        [TestMethod]
        public void Get_GetElementAtIndexGreaterIndexLastElem_ThrowsException()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            int ind = 3;
            try
            {
                char gottenSecondElement = list.Get(ind);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Wrong index", e.Message);
            }
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
        [TestMethod]
        public void InsertAt_InsertAtEnd_ElemInsertedAtIndexAtEnd()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            char insElem = 'i';
            int insInd = 3;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.InsertAt(insElem, insInd);
            Assert.AreEqual(insElem, list.Get(insInd));
        }
        [TestMethod]
        public void InsertAt_InsertAtNegativeIndex_ThrowsException()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            char insElem = 'i';
            int insInd = -1;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            try
            {
                list.InsertAt(insElem, insInd);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Wrong index", e.Message);
            }
        }
        [TestMethod]
        public void InsertAt_InsertAtIndexGreaterLength_ThrowsException()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            char insElem = 'i';
            int insInd = 4;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            try
            {
                list.InsertAt(insElem, insInd);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Wrong index", e.Message);
            }
        }
        [TestMethod]
        public void RemoveAt_RemoveFromEnd_ReduceLengthReturnRemElem()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            int remInd = 2;
            int expectedLength = 2;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            char remElem = list.RemoveAt(remInd);
            int actualLength = list.Count;
            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(thirdElement, remElem);
            Assert.AreEqual(firstElement, list.Get(0));
            Assert.AreEqual(secondElement, list.Get(1));
        }
        [TestMethod]
        public void RemoveAt_RemoveFromBegin_ReduceLengthReturnRemElem()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            int remInd = 0;
            int expectedLength = 2;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            char remElem = list.RemoveAt(remInd);
            int actualLength = list.Count;
            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(firstElement, remElem);
            Assert.AreEqual(secondElement, list.Get(0));
            Assert.AreEqual(thirdElement, list.Get(1));
        }
        [TestMethod]
        public void RemoveAt_RemoveFromMiddle_ReduceLengthReturnRemElem()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            int remInd = 1;
            int expectedLength = 2;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            char remElem = list.RemoveAt(remInd);
            int actualLength = list.Count;
            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(secondElement, remElem);
            Assert.AreEqual(firstElement, list.Get(0));
            Assert.AreEqual(thirdElement, list.Get(1));
        }
        [TestMethod]
        public void RemoveAt_RemoveFromListOfLength1_EmptyList()
        {
            List list = new List();
            char element = 'e';
            int remInd = 0;
            int expectedLength = 0;
            list.AddLast(element);
            char remElem = list.RemoveAt(remInd);
            int actualLength = list.Count;
            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(element, remElem);
        }
        [TestMethod]
        public void RemoveAt_RemoveAtNegativeIndex_ThrowsException()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            int ind = -1;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            try
            {
                list.RemoveAt(ind);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Wrong index", e.Message);
            }
        }
        [TestMethod]
        public void RemoveAt_RemoveAtIndexGreaterIndexLastElem_ThrowsException()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            int ind = 3;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            try
            {
                list.RemoveAt(ind);
                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Wrong index", e.Message);
            }
        }
        [TestMethod]
        public void RemoveAll_RemoveAllEntriesElem_ReduceLengthRemElem()
        {
            List list = new List();
            char firstElement = 't';
            char secondElement = 'r';
            char thirdElement = 't';
            char fourthElement = 'j';
            char fifthElement = 't';
            char remCh = 't';
            int expectedLength = 2;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.AddLast(fourthElement);
            list.AddLast(fifthElement);
            list.RemoveAll(remCh);
            int actualLength = list.Count;
            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(secondElement, list.Get(0));
            Assert.AreEqual(fourthElement, list.Get(1));
        }
        [TestMethod]
        public void RemoveAll_RemoveNotIncomingElem_NoChanges()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            char remCh = 'k';
            int expectedLength = 3;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.RemoveAll(remCh);
            int actualLength = list.Count;
            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(firstElement, list.Get(0));
            Assert.AreEqual(secondElement, list.Get(1));
            Assert.AreEqual(thirdElement, list.Get(2));
        }
        [TestMethod]
        public void RemoveAll_RemoveFromListOfLength1_EmptyList()
        {
            List list = new List();
            char element = 'e';
            char remCh = 'e';
            int expectedLength = 0;
            list.AddLast(element);
            list.RemoveAll(remCh);
            int actualLength = list.Count;
            Assert.AreEqual(expectedLength, actualLength);
        }
        [TestMethod]
        public void Clone_CloneList_ListCopiesCurrent()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            int lengthList = list.Count;
            List clonedList = list.Clone();
            int lengthClonedList = clonedList.Count;
            Assert.AreEqual(lengthList, lengthClonedList);
            Assert.AreEqual(list.Get(0), clonedList.Get(0));
            Assert.AreEqual(list.Get(1), clonedList.Get(1));
            Assert.AreEqual(list.Get(2), clonedList.Get(2));
        }
        [TestMethod]
        public void Clone_CloneEmptyList_EmptyList()
        {
            List list = new List();
            int lengthList = list.Count;
            List clonedList = list.Clone();
            int lengthClonedList = clonedList.Count;
            Assert.AreEqual(lengthList, lengthClonedList);
        }
        [TestMethod]
        public void Reverse_ReverseList_ChangedOrder()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.Reverse();
            Assert.AreEqual(thirdElement, list.Get(0));
            Assert.AreEqual(secondElement, list.Get(1));
            Assert.AreEqual(firstElement, list.Get(2));
        }
        [TestMethod]
        public void Reverse_ReverseEmptyList_EmptyList()
        {
            List list = new List();
            int expectedLength = 0;
            list.Reverse();
            int actualLength = list.Count;
            Assert.AreEqual(expectedLength, actualLength);
        }
        [TestMethod]
        public void Reverse_ReverseListListOfLength1_NoChanges()
        {
            List list = new List();
            char element = 'e';
            list.AddLast(element);
            int expectedLength = 1;
            list.Reverse();
            int actualLength = list.Count;
            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(element, list.Get(0));
        }
        [TestMethod]
        public void FindFirst_FindFirstEntryOfElem_ElemInd()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'e';
            char thirdElement = 't';
            char fourthElement = 'e';
            char target = 'e';
            int targetInd = 0;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.AddLast(fourthElement);
            int foundInd = list.FindFirst(target);
            Assert.AreEqual(targetInd, foundInd);
        }
        [TestMethod]
        public void FindFirst_FindNotIncludedElem_minus1()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'e';
            char thirdElement = 't';
            char fourthElement = 'e';
            char target = 'l';
            int targetInd = -1;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.AddLast(fourthElement);
            int foundInd = list.FindFirst(target);
            Assert.AreEqual(targetInd, foundInd);
        }
        [TestMethod]
        public void FindLast_FindLastEntryOfElem_ElemInd()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'e';
            char thirdElement = 't';
            char fourthElement = 'e';
            char target = 'e';
            int targetInd = 3;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.AddLast(fourthElement);
            int foundInd = list.FindLast(target);
            Assert.AreEqual(targetInd, foundInd);
        }
        [TestMethod]
        public void FindLast_FindNotIncludedElem_minus1()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'e';
            char thirdElement = 't';
            char fourthElement = 'e';
            char target = 'l';
            int targetInd = -1;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.AddLast(fourthElement);
            int foundInd = list.FindLast(target);
            Assert.AreEqual(targetInd, foundInd);
        }
        [TestMethod]
        public void Clear_ClearNotEmptyList_EmptyList()
        {
            List list = new List();
            char firstElement = 'e';
            char secondElement = 'r';
            char thirdElement = 't';
            int targetLength = 0;
            list.AddLast(firstElement);
            list.AddLast(secondElement);
            list.AddLast(thirdElement);
            list.Clear();
            int actualLength = list.Count;
            Assert.AreEqual(targetLength, actualLength);
        }
        [TestMethod]
        public void Clear_ClearEmptyList_EmptyList()
        {
            List list = new List();
            int targetLength = 0;
            list.Clear();
            int actualLength = list.Count;
            Assert.AreEqual(targetLength, actualLength);
        }
        [TestMethod]
        public void Extend_ExtendingListWithAnotherList_IncreaseLengthAddingNewElem()
        {
            List expandingList = new List();
            char firstElemExL = 'q';
            char secondElemExL = 'w';
            char thirdElemExL = 'y';
            expandingList.AddLast(firstElemExL);
            expandingList.AddLast(secondElemExL);
            expandingList.AddLast(thirdElemExL);
            List list = new List();
            char firstElemL = 'e';
            char secondElemL = 'r';
            char thirdElemL = 't';
            list.AddLast(firstElemL);
            list.AddLast(secondElemL);
            list.AddLast(thirdElemL);
            int targetLength = 6;
            expandingList.Extend(list);
            int actualLength = expandingList.Count;
            Assert.AreEqual(targetLength, actualLength);
            Assert.AreEqual(firstElemL, expandingList.Get(3));
            Assert.AreEqual(secondElemL, expandingList.Get(4));
            Assert.AreEqual(thirdElemL, expandingList.Get(5));
        }
        [TestMethod]
        public void Extend_ChangeListThatWasUsedForExtension_NotAffectExtendedList()
        {
            List expandingList = new List();
            char firstElemExL = 'q';
            char secondElemExL = 'w';
            char thirdElemExL = 'y';
            expandingList.AddLast(firstElemExL);
            expandingList.AddLast(secondElemExL);
            expandingList.AddLast(thirdElemExL);
            List list = new List();
            char firstElemL = 'e';
            char secondElemL = 'r';
            char thirdElemL = 't';
            list.AddLast(firstElemL);
            list.AddLast(secondElemL);
            list.AddLast(thirdElemL);
            int targetLength = 6;
            expandingList.Extend(list);
            list.Reverse();
            list.RemoveAt(1);
            list.AddLast('n');
            int actualLength = expandingList.Count;
            Assert.AreEqual(targetLength, actualLength);
            Assert.AreEqual(firstElemL, expandingList.Get(3));
            Assert.AreEqual(secondElemL, expandingList.Get(4));
            Assert.AreEqual(thirdElemL, expandingList.Get(5));
        }
        [TestMethod]
        public void Extend_ExtendEmptyListWithEmptyList_EmptyList()
        {
            List expandingList = new List();
            List list = new List();
            int targetLength = 0;
            expandingList.Extend(list);
            int actualLength = expandingList.Count;
            Assert.AreEqual(targetLength, actualLength);
        }
    }
}