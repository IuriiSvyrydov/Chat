using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Chat.Infrastructure.Data;

    public class ChatDbContextFactory: IDesignTimeDbContextFactory<ChatDbContext>
    {
        public ChatDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ChatDbContext>();
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7CB8L9L\SQLEXPRESS;Database=ChatDb;Trusted_Connection=True;");

            return new ChatDbContext(optionsBuilder.Options);
    }
    }

