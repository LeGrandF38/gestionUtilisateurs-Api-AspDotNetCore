
using ApiProjetBlazor.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetBlazor.Data


{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
