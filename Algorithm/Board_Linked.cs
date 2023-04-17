﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    // 연결리스트는 연속될 필요없다
    // 워프를 만든다 
    class MyLinkedListNode<T>
    {
        public T Data;
        public MyLinkedListNode<T> Next;    //  node의 개념 참조(주소)
        public MyLinkedListNode<T> Prev;    //     
    }

    class MyLinkedList<T>
    {
        public MyLinkedListNode<T> Head = null;    // 첫번째
        public MyLinkedListNode<T> Tail = null;    // 마지막
        public int Count = 0;

        public MyLinkedListNode<T> AddLast(T data)
        {
            MyLinkedListNode<T> newRoom = new MyLinkedListNode<T>();    
            newRoom.Data = data;

            // 만약에 아직 방이 아예 없었다면, 새로 추가한 첫번째 방이 곧 Head이다.
            if (Head == null)
                Head = newRoom;

            // 기존의 [마지막 방]과 새로 추가되는 방을 연결해준다. 
            if (Tail != null)
            {
                Tail.Next = newRoom;
                newRoom.Prev = Tail;
            }

            // [새로 추가되는 방]을 [마지막 방]으로 인정한다.
            Tail = newRoom;
            Count++;

            return newRoom;
        }

        // 
        public void Remove(MyLinkedListNode<T> room)
        {
            // 기존의 첫번째 방의 다음 방을 첫번째 방으로 인정한다.
            if (Head == room)
                Head = Head.Next;
            
            // 기존의 마지막 방의 앞의 방을 마지막 방으로 인정한다. 
            if (Tail == room)
                Tail = Tail.Prev;

            if (room.Prev != null)
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Prev.Prev = room.Prev;

            Count--;
        }
    }
    class Board_1   //연결리스트 구현 연습
    {
        public List<int> _data2 = new List<int>();  // 동적배열   // 재너릴 형식
        public MyLinkedList<int> _data3 = new MyLinkedList<int>();  //연결 리스트

        public void Initialize()
        {
            _data3.AddLast(101);
            _data3.AddLast(102);
            MyLinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }
}