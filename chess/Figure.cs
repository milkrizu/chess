﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawn.Core

    //поля
{
    public class Figure
    {
        public int x;
        public int y;

        //конструктор

        public Figure(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
    }
}