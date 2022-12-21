namespace src.Entities
{
    public class Fruit : BaseEntity
    {
        public string Name { get; private set; }
        public decimal PriceA { get; private set; }
        public decimal PriceB { get; private set; }

        public Fruit(string name, decimal priceA, decimal priceB)
        {
            Name = name;
            PriceA = priceA;
            PriceB = priceB;
        }
    }
}