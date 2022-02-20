using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
    internal interface IThreshold
    {
        public void SetThreshold(int thr);

        public int GetThreshold();

    }
}
