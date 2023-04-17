using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Board_Tile
    {
        const char CIRCLE = '\u25cf';   // 사이클 
        public TileType[,] _tile;    //배열
        public int _size;   // 사이즈

        // 하드코딩 지양하자
        public enum TileType
        {
            Empty,
            Wall
        }
        public void Initialize(int size)    // 첫번째
        {
            _tile = new TileType[size, size];
            _size = size;

            for (int y = 0; y < _size; y++)    // 0 ~ 25 사이즈
            {
                for(int x = 0; x < _size; x++)    // 0 ~ 25 사이즈
                {
                    if (x == 0 || x == _size - 1 || y == 0 || y == size - 1)
                        _tile[y, x] = TileType.Wall;
                    else
                        _tile[y, x] = TileType.Empty;
                }
            }
        }

        public void Render()
        {
            Console.SetCursorPosition(0, 0);

            ConsoleColor prevColor = Console.ForegroundColor;

            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.ForegroundColor = GetTileColor(_tile[y, x]);
                    Console.Write(CIRCLE);
                }
                Console.WriteLine();
            }

            Console.ForegroundColor= prevColor;
        }

        ConsoleColor GetTileColor(TileType type)
        {
            switch (type)
            {
                case TileType.Empty:
                    return ConsoleColor.Green;
                case TileType.Wall:
                    return ConsoleColor.Red;
                default: 
                    return ConsoleColor.Green;
            }
        }
           


    }
}
