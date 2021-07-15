namespace Modul2HW4
{
   public interface IMeasureConverterService
    {
        public Length ToMeters(Length length);
        public Speed ToKiloInHour(Speed speed);
        public Weight ToKilo(Weight weight);
    }
}
