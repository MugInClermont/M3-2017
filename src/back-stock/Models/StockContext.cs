using Microsoft.EntityFrameworkCore;

namespace back_mug_stock.Models
{
    public class StockContext : DbContext
    {
        public DbSet<Stock> Stocks { get; set; }

        public StockContext(DbContextOptions<StockContext> opt):base(opt){
            
        }
    }
}