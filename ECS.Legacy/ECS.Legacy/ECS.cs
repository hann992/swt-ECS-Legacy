using System;

namespace ECS.Legacy
{
    public class ECS
    {
        private readonly ITemp _tempSensor;
        private readonly IHeater _heater;
        private readonly IThreshold _threshold;
        public ECS(int thr)
        {
            _threshold = new Threshold(thr);
            _tempSensor = new TempSensor();
            _heater = new Heater();
        }
        public void Regulate()
        {
            var temp = _tempSensor.GetTemp();
            Console.WriteLine($"Temperatur measured was {temp}");
            if (temp < _threshold.GetThreshold())
                _heater.TurnOn();
            else
                _heater.TurnOff();
        }
        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
