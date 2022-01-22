using System;

namespace BuilderPattern
{
    public class TransformerDistributionBuilder : IBuilder
    {
        private Transformer _transformer = new Transformer();

        public TransformerDistributionBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _transformer = new Transformer();
        }

        public void SetMagneticCore()
        {
            _transformer.MagneticCore = "Create transformer distribution magnetic core.";
        }

        public void SetTank()
        {
            _transformer.Tank = "Create transformer distribution tank.";
        }

        public void SetWindingHighVoltage()
        {
            _transformer.WindingHighVoltage = "Create transformer distribution winding high voltage.";
        }

        public void SetWindingLowVoltage()
        {
            _transformer.WindingLowVoltage = "Create transformer distribution winding low voltage.";
        }

        public void SetWindingTapVoltage()
        {
            _transformer.WindingTapVoltage = "No have transformer distribution winding tap voltage.";
        }

        public void GetVoltage()
        {
            _transformer.GetVoltage = "Voltage from transformer distribution.\n";
        }

        public Transformer GetResult()
        {
            var result = _transformer;

            Reset();

            return result;
        }
    }
}
