namespace BuilderPattern
{
    public interface IBuilder
    {
        void SetWindingLowVoltage();
        void SetWindingHighVoltage();
        void SetWindingTapVoltage();
        void SetMagneticCore();
        void SetTank();
        void GetVoltage();
    }
}
