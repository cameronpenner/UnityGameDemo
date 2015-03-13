using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class MyMath
    {
        public static float Clamp(float val, float min, float max)
        {
            if (val < min) return min;
            else if (val > max) return max;
            else return val;
        }
    }
}
