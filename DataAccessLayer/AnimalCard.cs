namespace DataAccessLayer
{
    public class AnimalCard
    {
        public enum Type
        {
            BIRD, REPTILE, FISH, MAMMAL
        }
        public static readonly Dictionary<string, Type> StringToType = new Dictionary<string, Type>()
        {
            { "bird", Type.BIRD },
            { "reptile", Type.REPTILE },
            { "fish", Type.FISH },
            { "mammal", Type.MAMMAL }
        };
        public string Name { get; set; }
        public string LatinName { get; set; }
        private Type? _animalType = null;
        public string AnimalType
        {
            get
            {
                if (_animalType == null)
                {
                    return "N/A";
                }
                // Warning disabled here because we already did the check.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                return _animalType.ToString().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            set
            {
                if (StringToType.ContainsKey(value.ToLower()))
                {
                    _animalType = StringToType[value.ToLower()];
                }
                else
                {
                    throw new Exception("This type doesn't exist in this program. No changes were made.");
                }
            }
        }
        public string ShortDesc { get; private set; }

        public AnimalCard(string name, string latinName, string shortDesc)
        {
            Name = name;
            LatinName = latinName;
            ShortDesc = shortDesc;
        }

        public override string ToString() => $"{Name} # {LatinName} # {AnimalType} # {ShortDesc}";
    }
}
