namespace Modul2HW4
{
    public static class AnimalsExtensions
    {
        public static Animal[] FindByName(this Animal[] animals, string name)
        {
            var result = new Animal[0];
            foreach (var item in animals)
            {
                if (item.Name == name)
                {
                    result = result.Add(item);
                }
            }

            return result;
        }

        public static Animal[] Add(this Animal[] animals, Animal animal)
        {
            var newLength = animals.Length + 1;
            var result = new Animal[newLength];
            for (var i = 0; i < animals.Length; i++)
            {
                result[i] = animals[i];
            }

            result[newLength - 1] = animal;
            return result;
        }
    }
}
