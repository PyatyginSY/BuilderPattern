using System;

namespace BuilderPattern
{
    public class Transformer
    {
        public string WindingLowVoltage { get; set; }

        public string WindingHighVoltage { get; set; }

        public string WindingTapVoltage { get; set; }

        public string MagneticCore { get; set; }

        public string Tank { get; set; }

        public string GetVoltage { get; set; }
    }
}
