namespace Modul2HW4
{
    public class AviaryService : IAviaryService
    {
        private readonly IAnimalsProvider _animalsProvider;
        public AviaryService(IAnimalsProvider animalsProvider)
        {
            _animalsProvider = animalsProvider;
        }

        public void Add(ref Animal[] animals, int id)
        {
            animals = animals.Add(_animalsProvider.Animals[id]);
        }
    }
}
