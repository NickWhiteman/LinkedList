using System;

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
            Node current = _root;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            current.Value = value; 
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
        //public void SortLayout()
        //{
        //    if (Length == 0)
        //    {
        //        throw new Exception("List empty!");
        //    }
        //    else
        //    {
        //        Node current = _root;
        //        Node temp = current.Next;
        //        _root = temp;

        //        for (int i = 1; i < Length; i++)
        //        {
        //            if(current.Value < current.Next.Value)
        //            {
                        
        //            }
        //            current = current.Next;
        //        }

        //    }

        //}


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


    }
}
