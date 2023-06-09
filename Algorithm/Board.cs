﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class MyList<T>     // 재너릴 형식
    {
        const int DEFAULT_SIZE = 1;    // const :상수 (변하지 않는 값) / var : 변수(변하는 값)
        T[] _data = new T[DEFAULT_SIZE];
        public int Count;   // 실제로 사용중인 데이터 개수
        
        public int Capacity { get { return _data.Length; } }    // 예약된 데이터 개수 

        // 시간복잡도 0(1) 
        // 0(1) 예외 케이스 : 이사 비용은 무시한다
        public void Add(T item)
        {
            // 1. 공간이 충분히 남아있는지 확인한다.
            if (Count >= Capacity)
            {
                // 공간을 다시 늘려서 확보한다. 
                T[] newArray = new T[Count * 2];
                for (int i = 0; i < Count; i++)
                    newArray[i] = _data[i];
                _data = newArray;

            }
            // 2. 공간에다가 데이터를 넣어준다
            _data[Count] = item;
            Count++;
        }

        // 0(1) 예외 케이스 
        public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }
        // 0(N)
        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
                _data[i] = _data[index + 1];
            _data[Count - 1] = default(T);
            Count--;
        }

    }
    class Board     // 동적 배열 구현 연습
    {
        public int[] _data = new int[25];   // 배열
        public List<int> _data2 = new List<int>();  // 동적배열   // 재너릴 형식
        public LinkedList<int> _data3 = new LinkedList<int>();  //연결 리스트

        public void Initialize()
        {
            _data2.Add(101);
            _data2.Add(102);
            _data2.Add(103);
            _data2.Add(104);
            _data2.Add(105);

            int temp = _data2[2];

            _data2.RemoveAt(2);
        }
    }
}
