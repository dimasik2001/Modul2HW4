using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Modul2HW4
{
   public class Startup
    {
        private readonly IAnimalSortService _sortService;
        private readonly IAviaryService _aviaryService;
        public Startup(IAnimalSortService sortService, IAviaryService aviaryService)
        {
            _sortService = sortService;
            _aviaryService = aviaryService;
        }

        public void Run()
        {
            var aviary = new Animal[0];
            var rnd = new Random();
            var maxValue = 7;
            var animalsInAviary = 15;
            for (var i = 0; i < animalsInAviary; i++)
            {
                _aviaryService.Add(ref aviary, rnd.Next(maxValue));
            }

            _sortService.SortBySpeed(aviary);
            _sortService.SortByWeight(aviary);

            var findedAnimals = aviary.FindByName("Cobra");
        }
    }
}
