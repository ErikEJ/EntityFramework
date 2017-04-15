using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServerCompact;
using System.Data.SqlServerCe;

namespace Microsoft.EntityFrameworkCore.Benchmarks.EF6.Models
{
    public class SqlCeConfiguration : DbConfiguration
    {
        public SqlCeConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlServerCe.4.0", () => new DefaultExecutionStrategy());
            SetProviderFactory("System.Data.SqlServerCe.4.0", new SqlCeProviderFactory());
            SetProviderServices("System.Data.SqlServerCe.4.0", SqlCeProviderServices.Instance);
        }
    }

}
