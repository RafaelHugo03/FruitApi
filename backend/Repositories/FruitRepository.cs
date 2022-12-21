using Microsoft.EntityFrameworkCore;
using src.Data;
using src.Entities;
using src.Repositories.Contracts;

namespace src.Repositories;

public class FruitRepository : IFruitRepository
{
    private readonly FruitDataContext context;

    public FruitRepository(FruitDataContext context)
    {
        this.context = context;
    }

    public List<Fruit> GetAllFruits()
    {
        return context.Fruits.AsNoTracking().ToList();
    }
}