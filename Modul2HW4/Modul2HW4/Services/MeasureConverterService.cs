namespace Modul2HW4
{
    public class MeasureConverterService : IMeasureConverterService
    {
        public Weight ToKilo(Weight weight)
        {
            switch (weight.Units)
            {
                case WeightUnits.Gram:
                    return new Weight { Value = weight.Value / 1000, Units = WeightUnits.Kilogram };

                default:
                    return weight;
            }
        }

        public Speed ToKiloInHour(Speed speed)
        {
            switch (speed.Units)
            {
                case SpeedUnits.MetersInSecond:
                    return new Speed { Value = speed.Value * 3.6, Units = SpeedUnits.KilometersInHour };

                default:
                    return speed;
            }
        }

        public Length ToMeters(Length length)
        {
            switch (length.Units)
            {
               case LengthUnits.Centimeters:
                    return new Length { Value = length.Value / 100, Units = LengthUnits.Meters };
               default:
                    return length;
            }
        }
    }
}
