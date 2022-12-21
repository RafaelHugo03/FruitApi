
using src.Entities;

namespace src.Repositories.Contracts
{
    public interface IFruitRepository
    {
        List<Fruit> GetAllFruits();
    }
}