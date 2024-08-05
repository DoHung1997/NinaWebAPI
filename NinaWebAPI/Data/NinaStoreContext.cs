using Microsoft.EntityFrameworkCore;

namespace NinaWebAPI.Data;

public class NinaStoreContext(DbContextOptions<NinaStoreContext> opt) : DbContext(opt)
{
    #region DbSet

    public DbSet<Product>? Products { get; set; }

    #endregion
}