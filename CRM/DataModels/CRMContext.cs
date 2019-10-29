namespace CRM.DataModels
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    class CRMContext : DbContext
    {
        public CRMContext()
            : base("CRMConnection")
        { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}