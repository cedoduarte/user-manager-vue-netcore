using Microsoft.EntityFrameworkCore;
using UserManager.Models;

namespace UserManager.Models.Interface
{
    public interface IAppDbContext
    {
        DbSet<User> Users { get; set; }
    }
}
