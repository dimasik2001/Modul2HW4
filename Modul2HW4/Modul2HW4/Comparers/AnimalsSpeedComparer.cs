using System;
using System.Collections;
namespace Modul2HW4
{
    public class AnimalsSpeedComparer : IComparer
    {
        private readonly IMeasureConverterService _converterService;

        public AnimalsSpeedComparer(IMeasureConverterService converterService)
        {
            _converterService = converterService;
        }

        public int Compare(object x, object y)
        {
            var a1 = x as Animal;
            var a2 = y as Animal;

            if (a1 != null && a2 != null)
            {
                var firstSpeed = _converterService.ToKiloInHour(a1.Speed).Value;
                var secondSpeed = _converterService.ToKiloInHour(a2.Speed).Value;
                if (firstSpeed > secondSpeed)
                {
                    return 1;
                }
                else if (firstSpeed < secondSpeed)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
