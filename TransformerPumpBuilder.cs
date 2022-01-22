using System;

namespace BuilderPattern
{
    public class TransformerPumpBuilder : IBuilder
    {
        private Transformer _transformer = new Transformer();

        public TransformerPumpBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _transformer = new Transformer();
        }

        public void SetMagneticCore()
        {
            _transformer.MagneticCore = "Create transformer pump magnetic core.";
        }

        public void SetTank()
        {
            _transformer.Tank = "Create transformer pump tank.";
        }

        public void SetWindingHighVoltage()
        {
            _transformer.WindingHighVoltage = "Create transformer pump winding high voltage.";
        }

        public void SetWindingLowVoltage()
        {
            _transformer.WindingLowVoltage = "Create transformer pump winding low voltage.";
        }

        public void SetWindingTapVoltage()
        {
            _transformer.WindingTapVoltage = "No have transformer pump winding tap voltage.";
        }

        public void GetVoltage()
        {
            _transformer.GetVoltage = "Voltage from transformer pump.\n";
        }
        public Transformer GetResult()
        {
            var result = _transformer;

            Reset();

            return result;
        }
    }
}
