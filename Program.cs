using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BuilderPattern\n");

            var director = new Manager();

            var builderTransformerPower = new TransformerPowerBuilder();
            director.Builder = builderTransformerPower;
            director.BuildTransformerPower();
            var transformerPower = builderTransformerPower.GetResult();
            Console.WriteLine(transformerPower.WindingLowVoltage);
            Console.WriteLine(transformerPower.WindingHighVoltage);
            Console.WriteLine(transformerPower.WindingTapVoltage);
            Console.WriteLine(transformerPower.MagneticCore);
            Console.WriteLine(transformerPower.Tank);
            Console.WriteLine(transformerPower.GetVoltage);

            var builderTransformerDistribution = new TransformerDistributionBuilder();
            director.Builder = builderTransformerDistribution;
            director.BuildTransformerDistribution();
            var transformerDistribution = builderTransformerDistribution.GetResult();
            Console.WriteLine(transformerDistribution.WindingLowVoltage);
            Console.WriteLine(transformerDistribution.WindingHighVoltage);
            Console.WriteLine(transformerDistribution.MagneticCore);
            Console.WriteLine(transformerDistribution.Tank);
            Console.WriteLine(transformerDistribution.GetVoltage);

            var builderTransformerPump = new TransformerPumpBuilder();
            director.Builder = builderTransformerPump;
            director.BuildTransformerPump();
            var transformerPump = builderTransformerPump.GetResult();
            Console.WriteLine(transformerPump.WindingLowVoltage);
            Console.WriteLine(transformerPump.WindingHighVoltage);
            Console.WriteLine(transformerPump.MagneticCore);
            Console.WriteLine(transformerPump.Tank);
            Console.WriteLine(transformerPump.GetVoltage);

            Console.ReadLine();
        }
    }
}
