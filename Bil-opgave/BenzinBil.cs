﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_opgave
{
    public sealed class BenzinBil : Bil
    {
        public BenzinBil(string mærke, string registringsnr, int prisexafgift, int købsår, int kmprliter) : base(mærke, registringsnr, prisexafgift, købsår, kmprliter)
        {
        }

        public override int HalvÅrligEjerafgift()
        {
            int sum = 0;
            if (KmPrLiter<20)
            {
                sum += 1200;
            }
            else if (KmPrLiter >= 20 && KmPrLiter <= 28)
            {
                sum += 600;
            }
            else if (KmPrLiter >28)
            {
                sum += 320;
            }
            return sum;
        }
    }
}
