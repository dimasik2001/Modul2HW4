namespace Modul2HW4
{
    public class AnimalProvider : IAnimalsProvider
    {
        public AnimalProvider()
        {
            Animals = new Animal[]
            {
                new Canine()
                {
                    Name = "Ethiopian",
                    FurColor = Colors.GREY,
                    Sex = Sex.FEMALE,
                    Species = CanineSpecies.VOLF,
                    Speed = new Speed { Value = 50, Units = SpeedUnits.KilometersInHour },
                    WayOfLife = WayOfLife.SETTLED,
                    Weight = new Weight { Value = 30, Units = WeightUnits.Kilogram }
                },

                new Feline()
                {
                    Species = FelineSpecies.CHEETAH,
                    Name = "Tanzanian",
                    FurColor = Colors.SPOTTED,
                    Sex = Sex.MALE,
                    Speed = new Speed { Value = 30, Units = SpeedUnits.MetersInSecond },
                    WayOfLife = WayOfLife.SETTLED,
                    Weight = new Weight { Value = 70, Units = WeightUnits.Kilogram }
                },

                new Bird()
                {
                    Name = "Eagle",
                    HasFlyingSkill = true,
                    Sex = Sex.FEMALE,
                    Speed = new Speed { Value = 42, Units = SpeedUnits.MetersInSecond },
                    Weight = new Weight { Value = 1200, Units = WeightUnits.Gram }
                },

                new Bovids()
                {
                    Name = "Cudu",
                    FurColor = Colors.GREY,
                    HoofToes = HoofToes.DOUBLE,
                    HornLength = new Length { Value = 50, Units = LengthUnits.Centimeters },
                    Sex = Sex.FEMALE,
                    Species = BovidsSpecies.ANTILOPE,
                    Speed = new Speed { Value = 30, Units = SpeedUnits.KilometersInHour },
                    Weight = new Weight { Value = 120, Units = WeightUnits.Kilogram }
                },

                new Giraffe()
                {
                    Name = "Angolensis",
                    FurColor = Colors.SPOTTED,
                    HornLength = new Length { Value = 10, Units = LengthUnits.Centimeters },
                    HoofToes = HoofToes.QUADRUPPLE,
                    NeckLength = 2,
                    Sex = Sex.FEMALE,
                    Speed = new Speed { Value = 55, Units = SpeedUnits.KilometersInHour },
                    Weight = new Weight { Value = 800, Units = WeightUnits.Kilogram }
                },

                new Nesting()
                {
                    Name = "Boar",
                    FurColor = Colors.BLACK,
                    HoofToes = HoofToes.TRIPPLE,
                    NestSize = new Length { Value = 40, Units = LengthUnits.Centimeters },
                    Sex = Sex.MALE,
                    Speed = new Speed { Value = 35, Units = SpeedUnits.KilometersInHour },
                    Weight = new Weight { Value = 100, Units = WeightUnits.Kilogram }
                },

                new Snake()
                {
                    Name = "Cobra",
                    ScaleColor = Colors.GREEN,
                    EggsNumber = 15,
                    Sex = Sex.FEMALE,
                    Speed = new Speed { Value = 1.67, Units = SpeedUnits.MetersInSecond },
                    TypeOfPoison = TypeOfPoison.LETHAL,
                    Weight = new Weight { Value = 11, Units = WeightUnits.Kilogram }
                },

                new Lizard()
                {
                    Name = "Varan",
                    EggsNumber = 4,
                    HasRegeneratedTail = false,
                    ScaleColor = Colors.BLACK,
                    Sex = Sex.FEMALE,
                    Speed = new Speed { Value = 20, Units = SpeedUnits.KilometersInHour },
                    Weight = new Weight { Value = 80, Units = WeightUnits.Kilogram }
                }
            };
        }

        public Animal[] Animals { get; }
    }
}
