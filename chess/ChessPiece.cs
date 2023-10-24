using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static chess.ChessPiece;

namespace chess
{
    internal class ChessPiece
    {

            //шахматная фигура
        public class Figure
        {
            public int x;
            public int y;
            //конструктор поля
            public Figure(int newX, int newY)
            {
                x = newX;
                y = newY;
            }
        }
    }

}










