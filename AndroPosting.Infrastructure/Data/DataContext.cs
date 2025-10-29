using System;
using AndroPosting.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AndroPosting.Infrastructure.Data;

public class DataContext(DbContextOptions options):DbContext(options)
{
public DbSet<AppUser> Users{get;set;}

}