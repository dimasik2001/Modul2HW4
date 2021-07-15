using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4
{
    public class AnimalSortService : IAnimalSortService
    {
        private readonly AnimalsSpeedComparer _speedComparer;
        private readonly AnimalsWeightComparer _weightComparer;
        public AnimalSortService(IMeasureConverterService converterService)
        {
            _speedComparer = new AnimalsSpeedComparer(converterService);
            _weightComparer = new AnimalsWeightComparer(converterService);
        }

        public void SortBySpeed(Animal[] animals)
        {
            Array.Sort(animals, _speedComparer);
        }

        public void SortByWeight(Animal[] animals)
        {
            Array.Sort(animals, _weightComparer);
        }
    }
}
