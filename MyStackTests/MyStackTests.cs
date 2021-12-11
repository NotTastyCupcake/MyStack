using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack;
using System;
using System.Text;

namespace MyStack.Tests
{
    [TestClass()]
    public class MyStackTests_NodeTest
    {
        #region Тестирование размера стека (Count, Push, Pop, Clear)

        #region Тестирование начального размера стека
        public void BeginSizeOfMyStackTestHelper<T>()
        {
            MyStack<T> target = new MyStack<T>();
            int expected = 0;
            int actual;
            actual = target.Count;
            Assert.AreEqual(expected,
                actual, $"Ошибка при измерении начального размера!!! Expected: {expected} не равен Actual: {actual}");
        }

        [TestMethod()]
        public void BeginSizeOfStackTest()
        {
            BeginSizeOfMyStackTestHelper<int>();
            BeginSizeOfMyStackTestHelper<string>();
            BeginSizeOfMyStackTestHelper<long>();
        }
        #endregion

        #region Тестирование изменения размера стека при дабовлении
        public void SizeOfMyStackAfterPushTestHelper<T>()
        {
            T val = default(T);
            MyStack<T> target = new MyStack<T>();

            var count = 15;
            while (count-- > 0)
            {
                target.Push(item: val);
            }

            int expected = 15;
            int actual;
            actual = target.Count;
            Assert.AreEqual(expected,
                actual, $"Ошибка при добавлении элемента!!! Expected: {expected} не равен Actual: {actual}");
        }


        [TestMethod()]
        public void SizeOfMyStackTest()
        {
            SizeOfMyStackAfterPushTestHelper<int>();
            SizeOfMyStackAfterPushTestHelper<string>();
            SizeOfMyStackAfterPushTestHelper<long>();
        }
        #endregion

        #region Тестирование изменения размера стека при отчистке
        public void ClearMyStackTestHelper<T>()
        {
            T val = default(T);
            MyStack<T> target = new MyStack<T>();

            var count = 3;
            while (count-- > 0)
            {
                target.Push(item: val);
            }

            target.Clear();

            int expected = 0;
            int actual;
            actual = target.Count;
            Assert.AreEqual(expected,
                actual, $"Ошибка при удалении элемента!!! Expected: {expected} не равен Actual: {actual}");
        }


        [TestMethod()]
        public void ClearMyStackTest()
        {
            ClearMyStackTestHelper<int>();
            ClearMyStackTestHelper<string>();
            ClearMyStackTestHelper<long>();
        }
        #endregion

        #region Тестирование изменения размера стека при извличении
        public void SizeOfMyStackAfterPopTestHelper<T>()
        {
            T val = default(T);
            MyStack<T> target = new MyStack<T>();

            var count = 15;
            while (count-- > 0)
            {
                target.Push(item: val);
            }

            target.Pop();

            int expected = 14;
            int actual;
            actual = target.Count;
            Assert.AreEqual(expected,
                actual, $"Ошибка при извличении элемента!!! Expected: {expected} не равен Actual: {actual}");
        }


        [TestMethod()]
        public void SizeOfMyStackAfterPopTest()
        {
            SizeOfMyStackAfterPopTestHelper<int>();
            SizeOfMyStackAfterPopTestHelper<string>();
            SizeOfMyStackAfterPopTestHelper<long>();
        }
        #endregion

        #region Тестирование изменения размера стека при получении первого элемента
        public void SizeOfMyStackAfterPeekTestHelper<T>()
        {
            T val = default(T);
            MyStack<T> target = new MyStack<T>();

            var count = 15;
            while (count-- > 0)
            {
                target.Push(item: val);
            }

            target.Peek();

            int expected = 15;
            int actual;
            actual = target.Count;
            Assert.AreEqual(expected,
                actual, $"Ошибка при извличении элемента!!! Expected: {expected} не равен Actual: {actual}");
        }


        [TestMethod()]
        public void SizeOfMyStackAfterPeekTest()
        {
            SizeOfMyStackAfterPeekTestHelper<int>();
            SizeOfMyStackAfterPeekTestHelper<string>();
            SizeOfMyStackAfterPeekTestHelper<long>();
        }
        #endregion

        #endregion

        #region Тестирование извличении элемента стека (Pop, Push, ToArray)

        #region Тестирование извличение на правильность получение
        public void PopArrIntMyStackTestHelper()
        {
            MyStack<int> target = new MyStack<int>();

            target.Push(1);
            target.Push(2);
            target.Push(3);
            target.Push(4);
            target.Push(5);

            target.Pop();

            int[] actual = target.ToArray();

            int[] expected = new int[] { 1, 2, 3, 4 };

            string a = "Массив: ";
            for (int i = 0; i < actual.Length; i++)
            {
                a = a + actual[i].ToString() + ",";
            }

            string e = "Массив: ";
            for (int i = 0; i < expected.Length; i++)
            {
                e = e + expected[i].ToString() + ",";
            }

            CollectionAssert.AreEqual(expected,
                actual, $"Ошибка при извличении элемента!!! Expected: {e} не равен Actual: {a}");
        }

        public void PopArrStringMyStackTestHelper()
        {
            MyStack<string> target = new MyStack<string>();

            target.Push("A");
            target.Push("B");
            target.Push("C");
            target.Push("D");
            target.Push("E");

            target.Pop();

            string[] actual = target.ToArray();

            string[] expected = new string[] { "A", "B", "C", "D" };

            string a = "Массив: ";
            for (int i = 0; i < actual.Length; i++)
            {
                a = a + actual[i].ToString() + ",";
            }

            string e = "Массив: ";
            for (int i = 0; i < expected.Length; i++)
            {
                e = e + expected[i].ToString() + ",";
            }

            CollectionAssert.AreEqual(expected,
                actual, $"Ошибка при извличении элемента!!! Expected: {e} не равен Actual: {a}");
        }

        public void PopArrDoubleMyStackTestHelper()
        {
            MyStack<double> target = new MyStack<double>();

            target.Push(0.00);
            target.Push(0.01);
            target.Push(0.02);
            target.Push(0.03);
            target.Push(0.04);

            target.Pop();

            var actual = target.ToArray();

            var expected = new double[] { 0.00, 0.01, 0.02, 0.03 };

            string a = "Массив: ";
            for (int i = 0; i < actual.Length; i++)
            {
                a = a + actual[i].ToString() + ",";
            }

            string e = "Массив: ";
            for (int i = 0; i < expected.Length; i++)
            {
                e = e + expected[i].ToString() + ",";
            }

            CollectionAssert.AreEqual(expected,
                actual, $"Ошибка при извличении элемента!!! Expected: {e} не равен Actual: {a}");
        }

        [TestMethod()]
        public void PopArrMyStackTest()
        {
            PopArrIntMyStackTestHelper();
            PopArrStringMyStackTestHelper();
            PopArrDoubleMyStackTestHelper();
        }
        #endregion

        #region Тестирование извличение на правильность получение
        public void PopIntMyStackTestHelper()
        {
            MyStack<int> target = new MyStack<int>();

            target.Push(1);
            target.Push(2);
            target.Push(3);
            target.Push(4);
            target.Push(5);

            int actual = target.Pop();

            int expected = 5;

            Assert.AreEqual(expected,
                actual, $"Ошибка при извличении элемента!!! Expected: {expected} не равен Actual: {actual}");
        }

        public void PopStringMyStackTestHelper()
        {
            MyStack<string> target = new MyStack<string>();

            target.Push("A");
            target.Push("B");
            target.Push("C");
            target.Push("D");
            target.Push("E");

            string actual = target.Pop();

            string expected = "E";

            Assert.AreEqual(expected,
                actual, $"Ошибка при извличении элемента!!! Expected: {expected} не равен Actual: {actual}");
        }

        public void PopDoubleMyStackTestHelper()
        {
            MyStack<double> target = new MyStack<double>();

            target.Push(0.00);
            target.Push(0.01);
            target.Push(0.02);
            target.Push(0.03);
            target.Push(0.04);

            double actual = target.Pop();

            double expected = 0.04;

            Assert.AreEqual(expected,
                actual, $"Ошибка при извличении элемента!!! Expected: {expected} не равен Actual: {actual}");
        }

        [TestMethod()]
        public void PopMyStackTest()
        {
            PopIntMyStackTestHelper();
            PopStringMyStackTestHelper();
            PopDoubleMyStackTestHelper();
        }
        #endregion

        #region Тестирование извличение на получнеия схожего типа данных
        /// <summary>
        /// Проверка на получения схожего типа данных
        /// </summary>
        public void PopTypeMyStackTestHelper<T>()
        {
            T val = default(T);
            MyStack<T> target = new MyStack<T>();

            var count = 15;
            while (count-- > 0)
            {
                target.Push(item: val);
            }

            T actual = target.Pop();

            T expected = val;

            Assert.AreEqual(expected,
                actual, $"Ошибка при извличении элемента!!! Тип элемента Expected: {expected} не равен типу элемена Actual: {actual}");
        }


        [TestMethod()]
        public void PopTypeMyStackTest()
        {
            PopTypeMyStackTestHelper<int>();
            PopTypeMyStackTestHelper<string>();
            PopTypeMyStackTestHelper<long>();
        }
        #endregion

        #endregion

        #region Тестирование були пустого стека (IsEmpty, Push)

        #region Тестирование изначально пустого стека
        public void BeginIsEmptyMyStackTestHelper<T>()
        {
            MyStack<T> target = new MyStack<T>();
            bool expected = true;
            bool actual;
            actual = target.IsEmpty;
            Assert.AreEqual(expected,
                actual, $"Ошибка!!! Expected: {expected} не равен Actual: {actual}");
        }

        [TestMethod()]
        public void BeginIsEmptyStackTest()
        {
            BeginIsEmptyMyStackTestHelper<int>();
            BeginIsEmptyMyStackTestHelper<string>();
            BeginIsEmptyMyStackTestHelper<long>();
        }
        #endregion


        #region Тестирование заполненного стека
        public void IsEmptyMyStackTestHelper<T>()
        {
            T val = default(T);
            MyStack<T> target = new MyStack<T>();
            target.Push(val);
            target.Push(val);
            target.Push(val);

            bool expected = false;
            bool actual;
            actual = target.IsEmpty;
            Assert.AreEqual(expected,
                actual, $"Ошибка!!! Expected: {expected} не равен Actual: {actual}");
        }

        [TestMethod()]
        public void IsEmptyStackTest()
        {
            IsEmptyMyStackTestHelper<int>();
            IsEmptyMyStackTestHelper<string>();
            IsEmptyMyStackTestHelper<long>();
        }
        #endregion

        #endregion

    }
}