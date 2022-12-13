﻿using FurnitureShop.Data.Context;
using FurnitureShop.Data.Entities;
using JFA.DependencyInjection;

namespace FurnitureShop.Data.Repositories.ConcreteTypeRepositories;

[Scoped]
public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context) { }
}