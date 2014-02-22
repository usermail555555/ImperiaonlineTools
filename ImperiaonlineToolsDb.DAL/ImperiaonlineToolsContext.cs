using ImperiaonlineToolsModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperiaonlineToolsDb.DAL
{
    public class ImperiaonlineToolsContext : DbContext
    {
        public ImperiaonlineToolsContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<Product> Products{ get; set; }
    }
}
