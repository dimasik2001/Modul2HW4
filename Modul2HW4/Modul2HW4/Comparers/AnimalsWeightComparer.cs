using System;
using System.Collections;
namespace Modul2HW4
{
   public class AnimalsWeightComparer : IComparer
    {
        private readonly IMeasureConverterService _converterService;

        public AnimalsWeightComparer(IMeasureConverterService converterService)
        {
            _converterService = converterService;
        }

        public int Compare(object x, object y)
        {
            var a1 = x as Animal;
            var a2 = y as Animal;

            if (a1 != null && a2 != null)
            {
                var firstWeight = _converterService.ToKilo(a1.Weight).Value;
                var secondWeight = _converterService.ToKilo(a2.Weight).Value;
                if (firstWeight > secondWeight)
                {
                    return 1;
                }
                else if (firstWeight < secondWeight)
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
