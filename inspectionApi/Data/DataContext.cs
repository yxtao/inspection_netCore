using Microsoft.EntityFrameworkCore;
using inspectionApi;

namespace inspectionApi.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Inspection> Inspections { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<inspectionApi.InspectionType> InspectionType { get; set; }
    }
}
