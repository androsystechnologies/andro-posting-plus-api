using System;
using AndroPosting.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace AndroPosting.API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }

public DbSet<Customers> Customers { get; set; }


}

public class Customers
{
}