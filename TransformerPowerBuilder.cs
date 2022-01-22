namespace BuilderPattern
{
    public class TransformerPowerBuilder : IBuilder
    {
        private Transformer _transformer = new Transformer();

        public TransformerPowerBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _transformer = new Transformer();
        }

        public void SetMagneticCore()
        {
            _transformer.MagneticCore = "Create transformer power magnetic core.";
        }

        public void SetTank()
        {
            _transformer.Tank = "Create transformer power tank.";
        }

        public void SetWindingHighVoltage()
        {
            _transformer.WindingHighVoltage = "Create transformer power winding high voltage.";
        }

        public void SetWindingLowVoltage()
        {
            _transformer.WindingLowVoltage = "Create transformer power winding low voltage.";
        }

        public void SetWindingTapVoltage()
        {
            _transformer.WindingTapVoltage = "Create transformer power winding tap voltage.";
        }

        public void GetVoltage()
        {
            _transformer.GetVoltage = "Voltage from transformer power.\n";
        }

        public Transformer GetResult()
        {
            var result = _transformer;

            Reset();

            return result;
        }
    }
}
