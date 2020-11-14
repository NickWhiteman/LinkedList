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
            for (int i = 0; i < Length; i++)
            {
                current = current.Next;
                count++;
            }
            return count;
        }


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
            _root = prev;   // либо nextCurrent, либо prev

            //Node current = _root;
            //Node prev = null;
            //while (current != null)
            //{
            //    prev = current.Next;
            //    Node tmp = current.Next;
            //    current.Next = prev;
            //    prev = current;
            //    current = tmp;
            //}
            //_root = prev;
        }

    }
}
