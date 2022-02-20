using System;

namespace ECS.Legacy
{
    public class TempSensor : ITemp
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}