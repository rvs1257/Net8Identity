using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Net8Identity.Data.Entities;

namespace Net8Identity.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) :
    IdentityDbContext<MyUser>(options)
{
}
