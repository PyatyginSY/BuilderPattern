namespace BuilderPattern
{
    public class Manager
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildTransformerPower()
        {
            _builder.SetWindingLowVoltage();
            _builder.SetWindingHighVoltage();
            _builder.SetWindingTapVoltage();
            _builder.SetMagneticCore();
            _builder.SetTank();
            _builder.GetVoltage();
        }

        public void BuildTransformerDistribution()
        {
            _builder.SetWindingLowVoltage();
            _builder.SetWindingHighVoltage();
            _builder.SetMagneticCore();
            _builder.SetTank();
            _builder.GetVoltage();
        }

        public void BuildTransformerPump()
        {
            _builder.SetWindingLowVoltage();
            _builder.SetWindingHighVoltage();
            _builder.SetMagneticCore();
            _builder.SetTank();
            _builder.GetVoltage();
        }
    }
}
