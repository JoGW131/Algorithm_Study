using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Board_1 board_1 = new Board_1();
            //board_1.Initialize();

            Board_Tile board_1 = new Board_Tile();
            board_1.Initialize(25);

            Console.CursorVisible = false;
            int lasttick = 0;

            const int WAIT_TICK = 1000 / 30;
            //const char CIRCLE = '\u25cf';

            while (true)
            {
                #region 프레임 관리
                int currenTick = System.Environment.TickCount;
                int elapsedTick = currenTick - lasttick;

                // 만약에 경과한 시간이 1/30초보다 작다면
                if (elapsedTick < WAIT_TICK)
                    continue;
                lasttick = currenTick;
                #endregion 
                // FPS 프레임 (60프레임 OK / 30 프레임 이하로 NO)
                // 입력

                // 로직

                // 렌더링 
                Console.SetCursorPosition(0, 0);
                board_1.Render();

                //for (int i = 0; i < 25; i++)
                //{
                //    for (int j = 0; j < 25; j++)
                //    {
                //        Console.ForegroundColor = ConsoleColor.Green;
                //        Console.Write(CIRCLE);
                //    }
                //    Console.WriteLine();
                //}
            }
        }
    }
}
