using System;

namespace DoubleLinkedList
{
    public class DoubleList
    {
        public int Length { get; private set; }
        private Node _root;
        private Node _tail;
        
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
        
        
    }
}