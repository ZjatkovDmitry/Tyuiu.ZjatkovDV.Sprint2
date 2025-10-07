﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZjatkovDV.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return (x >= 0 ? y <= 1 : false) && (x >= 0 ? y >= x - 1 : false) || (x >= 0 ? (x * x + y * y <= 1) : false);
        }
    }
}
