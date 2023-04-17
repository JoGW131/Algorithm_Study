using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Room
    {
        Room next;
        //public 
    }

    class Board_1   //연결리스트 구현 연습
    {
        public List<int> _data2 = new List<int>();  // 동적배열   // 재너릴 형식
        public LinkedList<int> _data3 = new LinkedList<int>();  //연결 리스트

        public void Initialize()
        {
            _data3.AddLast(101);
            _data3.AddLast(102);
            LinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }
}