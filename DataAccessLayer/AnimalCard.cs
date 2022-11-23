using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AnimalCard
    {
        public enum Type
        {
            BIRD, REPTILE, FISH, MAMMAL
        }
        public readonly Dictionary<string, Type> StringToType = new Dictionary<string, Type>()
        {
            { "bird", Type.BIRD },
            { "reptile", Type.REPTILE },
            { "fish", Type.FISH },
            { "mammal", Type.MAMMAL }
        };
        public string Name { get; private set; }
        public string LatinName { get; private set; }
        public Type? AnimalTypeByEnum { private get; set; } = null;
        public string AnimalType
        {
            get
            {
                if (AnimalTypeByEnum == null)
                {
                    return "N/A";
                }
                // Warning disabled here because we already did the check.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                return AnimalTypeByEnum.ToString().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }
        public string ShortDesc { get; private set; }

        public AnimalCard(string name, string latinName, string shortDesc)
        {
            Name = name;
            LatinName = latinName;
            ShortDesc = shortDesc;
        }

        public override string ToString() => $"{Name}, {LatinName}. Type: {AnimalType}, short description: {ShortDesc}";
    }
}
