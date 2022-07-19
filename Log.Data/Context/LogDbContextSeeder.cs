using Microsoft.EntityFrameworkCore;

namespace Log.Data;

public abstract class LogDbContextSeeder
    : LogDbContextBase
{
    protected override void SeedData(ModelBuilder builder)
    {
    }
}