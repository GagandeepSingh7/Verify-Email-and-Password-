using Microsoft.EntityFrameworkCore;
using VerifyEmailForgotPassword.Models;

namespace VerifyEmailForgotPassword.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) :base (options)
            {

            }

        

        public DbSet<User> Users { get; set; }
    }
}
