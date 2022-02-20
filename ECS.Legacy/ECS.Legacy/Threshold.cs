using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
    public class Threshold : IThreshold
    {
        private int _threshold;
        public Threshold(int thr)
        {
            SetThreshold(thr);
        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }
    }
}
