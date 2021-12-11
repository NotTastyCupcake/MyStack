using System;

namespace MyStack
{
    public class MyStack<T>
    {
        /// <summary>
        /// Элементы стека
        /// </summary>
        private T[] items;
        /// <summary>
        /// Количество элементов
        /// </summary>
        private int count;

        public MyStack()
        {
            items = new T[] { };
        }

        /// <summary>
        /// Задать размер стека
        /// </summary>
        /// <param name="length">Размер стека</param>
        public MyStack(int length)
        {
            items = new T[length];
        }

        /// <summary>
        /// Проверяет пустоту стека
        /// </summary>
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        
        /// <summary>
        /// Количество элементов в стеке
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Добавляет элемент в стек на первое место
        /// </summary>
        /// <param name="item">Добавляемый в стек элемент</param>
        public void Push(T item)
        {
            // Увеличиваем стек
            if (count == items.Length)
                Resize(items.Length + 10);

            items[count++] = item;
        }

        /// <summary>
        /// Извлекает и возвращает первый элемент из стека
        /// </summary>
        /// <returns>Возвращает первый элемент из стека</returns>
        /// <exception cref="InvalidOperationException">Пустой стек</exception>
        public T Pop()
        {
            // Если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            T item = items[--count];
            items[count] = default(T); // Сбрасываем ссылку

            if (count > 0 && count < items.Length - 10)
                Resize(items.Length - 10);

            return item;
        }

        /// <summary>
        /// Отчистка стека
        /// </summary>
        public void Clear()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");

            Array.Clear(items, 0, count);
            count = 0;
        }

        public T Peek()
        {
            return items[count - 1];
        }

        public T[] ToArray()
        {
            Resize(count);
            return items;
        }

        private void Resize(int max)
        {
            T[] tempItems = new T[max];
            for (int i = 0; i < count; i++)
                tempItems[i] = items[i];
            items = tempItems;
        }
    }
}
