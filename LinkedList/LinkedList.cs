using System;
using System.Runtime.InteropServices;

namespace LinkedList
{
    public class LinkedList
    {
        public int Length { get; private set; }
        private Node _root;

        public int this[int index]
        {
            get
            {
                Node tmp = _root;
                for (int i = 1; i <= index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }

            set
            {
                Node tmp = _root;
                for (int i = 1; i <= index; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Value = value;
            }
        }

        //Конструкторы
        public LinkedList()
        {
            Length = 0;
            _root = null;
        }
        public LinkedList(int value)
        {
            _root = new Node(value);
            Length = 1;
        }
        public LinkedList(int[] array)
        {
            if (array.Length != 0)
            {
                _root = new Node(array[0]);
                Node tmp = _root;

                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp = tmp.Next;
                }

                Length = array.Length;
            }
            else
            {
                Length = 0;
                _root = null;
            }
        }


        //Метод добавления по индексу
        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index > Length)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (index == 0)
                {
                    Node tmp = _root;
                    _root = new Node(value);
                    _root.Next = tmp;
                }
                else
                {
                    Node current = _root;
                    for (int i = 1; i < index; i++)
                    {
                        current = current.Next;
                    }

                    Node tmp = current.Next;
                    current.Next = new Node(value);

                    current.Next.Next = tmp;
                }
                Length++;
            }
        }

        //Перегруженый Equals
        public override bool Equals(object obj)
        {
            LinkedList linkedList = (LinkedList)obj;

            if (Length != linkedList.Length)
            {
                return false;
            }

            //for (int i = 0; i < Length; i++)
            //{
            //    if(this[i]!=linkedList[i])
            //    {
            //        return false;
            //    }
            //}

            Node tmp1 = _root;
            Node tmp2 = linkedList._root;
            for (int i = 0; i < Length; i++)
            {
                if (tmp1.Value != tmp2.Value)
                {
                    return false;
                }
                tmp1 = tmp1.Next;
                tmp2 = tmp2.Next;
            }
            return true;
        }

        //Код для вывода в консоль для тестов
        public override string ToString()
        {
            string s = "";

            if (_root != null)
            {
                Node tmp = _root;

                while (tmp != null)
                {
                    s += tmp.Value + ";";
                    tmp = tmp.Next;
                }
            }
            return s;
        }

        //Метод добавления в конец
        public void AddByEnd(int value)
        {
            if (_root == null)
            {
                Node tmp = _root;
                _root = new Node(value);
                _root.Next = tmp;
            }
            else
            {
                Node current = _root;
                for (int i = 1; i < Length; i++)
                {
                    current = current.Next;
                }

                Node tmp = current.Next;
                current.Next = new Node(value);

                current.Next.Next = tmp;
            }
            Length++;
        }

        //Метод добавления значения в начало
        public void AddByStart(int value)
        {
            AddByIndex(0, value);
        }

        //Метод удаления значения с конца
        public void RemoveByEnd()
        {
            Node current = _root;
            for (int i = 1; i < Length; i++)
            {
                current = current.Next; 
            }

            current.Next = null;
            Length--;
        }

        //Метод удаления элемента из начала
        public void RemoveByStart()
        {
            Node tmp = _root;
            _root = tmp.Next;
            Length--;
        }

        //Метод удаленя элемента по индексу
        public void RemoveByIndex(int index)
        {
            if( index < 0 || index > Length)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (index == 0)
                {
                    Node tmp = _root;
                    _root = tmp.Next;
                }
                else
                {
                    Node current = _root;
                    for (int i = 1; i < index; i++)
                    {
                        current = current.Next;
                    }
                
                    current.Next = current.Next.Next;
                }
                Length--;
            }
        }

        //Метод возвращает длину
        public int GetLength()
        {
            int count = 0;
            Node current = _root;
            for (int i = 1; i <= Length; i++)
            {
                current = current.Next;
                count++;
            }
            return count;
        }

        //Реверс
        public void Reverse()
        {
            Node current = _root;
            Node nextCurrent = null;
            Node prev = null;
            while(current != null)
            {
                nextCurrent = current.Next;
                current.Next = prev;
                prev = current;
                current = nextCurrent;
            }
            _root = prev;
        }

        //Метод изменения по индексу
        public void ChangeIndex(int index, int value)
        {
            if (index < 0 || index > Length)
            {
                throw new NullReferenceException();
            }
            else
            {
                Node current = _root;

                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                current.Value = value; 
            }

        }

        //Поиск наибольшего элемента
        public int GetMaxItem()
        {
            Node current = _root;
            int maxItem = current.Value;

            while (current.Next != null)
            {
                current = current.Next;
                if(current.Value > maxItem)
                {
                    maxItem = current.Value;
                }
            }

            return maxItem;
        }

        //Поиск наименьшего элемента
        public int GetMinItem()
        {
            Node current = _root;
            int minItem = current.Value;

            while (current.Next != null)
            {
                current = current.Next;
                if (current.Value < minItem)
                {
                    minItem = current.Value;
                }
            }

            return minItem;
        }

        //Поиск index наибольшего элемента
        public int GetIndexMaxItem()
        {
            Node current = _root;
            int maxItem = current.Value;
            int maxIndex = 0;

            for (int i = 1; i < Length; i++)
            {
                current = current.Next;
                if (current.Value > maxItem)
                {
                    maxItem = current.Value;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        //Поиск index наименьшего элемента
        public int GetIndexMinItem()
        {
            Node current = _root;
            int minItem = current.Value;
            int minIndex = 0;

            for (int i = 1; i <= Length; i++)
            {
                current = current.Next;
                if (current.Value < minItem)
                {
                    minItem = current.Value;
                    minIndex = i;
                }    
            }

            return minIndex;
        }

        //Cортировка по возрастанию
        public void SortLayout()
        {
            for (int i = 0; i < Length; i++)
            {
                Node current = _root;
                for (int j = 1; j < Length - i; j++)
                {
                    if (current.Value > current.Next.Value)
                    {
                        int tmp = current.Next.Value;
                        current.Next.Value = current.Value;
                        current.Value = tmp;
                    }

                    current = current.Next;
                }
            }
        }
        
        // Сортировка по убыванию
        public void SortDecrease()
        {
            for (int i = 0; i < Length; i++)
            {
                Node current = _root;
                for (int j = 1; j < Length - i; j++)
                {
                    if (current.Value < current.Next.Value)
                    {
                        int tmp = current.Next.Value;
                        current.Next.Value = current.Value;
                        current.Value = tmp;
                    }
                    current = current.Next;
                }
            }
        }

        //Уделение по значению первого элемента
        public void RemoveItemFirstValue(int value, int quantity = 1)
        {
            for (int i = 0; i < quantity; i++)
            {
                int index = GetIndexByValue(value);
                RemoveByIndex(index);
            }
        }

        //Доступ к индексу по значению
        public int GetIndexByValue(int value)
        {
            Node current = _root;
            int indx = 0;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value == value)
                {
                    indx = i;
                }
                current = current.Next;
            }
            return indx;
        }

        //Удаление по значению всех
        public void RemoveItemByValueAll(int value)
        {
           int quantity =  QuantityAgainItem(value);
           RemoveItemFirstValue(value, quantity);
        }

        //Доступ по индексу
        public int AccessByIndex(int index)
        {
            Node current = _root;
            for (int i = 1; i <= index; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }

        //Добавление массива в конец
        public void AddArrayInEnd(int[] array)
        {
            if(array.Length == 0)
            {
                throw new Exception("Array empty, Add items in array");
            }
            else
            {
                Node current = _root;
                for (int i = 1; i < Length; i++)
                {
                    current = current.Next;
                }

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Node tmp = current.Next;
                    current.Next = new Node(array[i]);
                    current.Next.Next = tmp;
                    Length++;
                }
            }
        }

        //Добавление массива в начало
        public void AddArrayInFirst(int[] array)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array empty, Add items in array");
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Node tmp = _root;
                    _root = new Node(array[i]);
                    _root.Next = tmp;
                    Length++;
                }
            }
        }

        //Добавление массива по индексу
        public void AddArrayByIndex(int[] array, int index)
        {
            if (array.Length == 0)
            {
                throw new Exception("Array empty, Add items in array");
            }
            else if (index < 0 || index > Length)
            {
                throw new NullReferenceException();
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    AddByIndex(index, array[i]);
                }
            }
        }

        //Удаление из конца N элементов
        public void RemoveByEndItems(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                RemoveByEnd();
            }
        }

        //Удаление из начала N элементов
        public void RemoveByFirstItems(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                RemoveByStart();
            }
        }

        //Удаление по индексу N элементов
        public void RemovByIndexItems(int index, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                RemoveByIndex(index);
            }
        }

        //Количестно повторяющихся элементов в списке
        private int QuantityAgainItem(int value)
        {
            int quantity = 0;
            Node current = _root;
            for (int i = 0; i < Length; i++)
            {
                if (current.Value == value)
                {
                    quantity++;
                }
                current = current.Next;
            }

            return quantity;
        }

        //сортировка листа через преобразование массива
        //  public LinkedList SortList(LinkedList list)
        //  {
        //      Node current = _root;
        //
        //      if (Length > 1)
        //      {
        //          int[] array = new int[Length];
        //          while (current != null)
        //          {
        //              for (int i = 0; i < array.Length; i++)
        //              {
        //                  array[i] = current.Value;
        //              }
        //              current = current.Next;
        //          }
        //          
        //          for (int i = 0; i < Length; i++)
        //          {
        //              for (int j = 0; j < Length - 1; j++)
        //              {
        //                  if (array[j] > array[j + 1])
        //                  {
        //                      int item = array[j + 1];
        //                      array[j + 1] = array[j];
        //                      array[j] = item;
        //                  }
        //              }
        //          }
        //          LinkedList listArr = new LinkedList(array);
        //          return listArr;
        //      }
        // }
        
        // для двусвязного списака GetNodeByIndex;
    }
}
