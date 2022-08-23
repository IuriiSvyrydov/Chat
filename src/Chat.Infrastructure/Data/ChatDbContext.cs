

using Chat.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Chat.Infrastructure.Data;

    public class ChatDbContext: DbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext>options):base(options)
        {
            
        }
        public DbSet<User>Users { get; set; }
    }

